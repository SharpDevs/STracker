using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace STracker {
    public partial class MainForm : Form {
        private Timer timer = new Timer(5000);
        private SManager manager = new SManager();
        private string CurrentTrack = "";
        private bool IsRunning = false;
        private App app = new App();
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            app.Load();
            if (string.IsNullOrEmpty(App.OutputPath)) {
                btnStart.Enabled = false;
            }
            txtOutputPath.Text = App.OutputPath;
            cbSystemTray.Checked = App.Minimize;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (!IsRunning) {
                timer.Start();
                timer.Elapsed += (timerSender, elapsedArgs) => {
                    var title = manager.GetTrackInfo();
                    if (title != CurrentTrack)
                        Invoke((MethodInvoker)delegate {
                            lblNowPlaying.Text = title;
                            CurrentTrack = title;
                        });
                    Write();
                };
                IsRunning = true;
                btnStart.Text = @"Stop";
                btnStart.Image = Properties.Resources.control_stop_blue;
            }
            else {
                timer.Stop();
                btnStart.Text = @"Start";
                btnStart.Image = Properties.Resources.control_play_blue;
                IsRunning = false;
                lblNowPlaying.Text = @"Not playing";
                CurrentTrack = "";
                Write();
            }

        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(txtOutputPath.Text) || string.IsNullOrWhiteSpace(txtOutputPath.Text)) {
                    throw new NullReferenceException("File path one can not be null");
                }
                App.Minimize = cbSystemTray.Checked;
                App.OutputPath = txtOutputPath.Text;
                app.Update();
                if (!string.IsNullOrEmpty(App.OutputPath)) {
                    btnStart.Enabled = true;
                }
            }
            catch (Exception ex) {

                MessageBox.Show("Failed to save. Please try again.", "Save Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Write() {
            try {
                using (var writer = new StreamWriter(App.OutputPath, false)) {
                    writer.Write(CurrentTrack);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to write file. Please restart the app.", "Write Failed", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }

        }
        private string GetFilePath() {
            try {
                var ofd = new OpenFileDialog {
                    Filter = @"Textfiles|*.txt",
                    Multiselect = false,
                    CheckFileExists = true
                };
                var result = ofd.ShowDialog();
                return result == DialogResult.OK ? ofd.FileName : "";

            }
            catch (Exception ex) {
                MessageBox.Show($"Failed to get path Error: {ex.ToString()}");
                return "";
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e) {
            var file = GetFilePath();
            App.OutputPath = file;
            txtOutputPath.Text = App.OutputPath;
        }

        private void MainForm_Resize(object sender, EventArgs e) {

            nIcon.BalloonTipTitle = "STracker";
            nIcon.BalloonTipText = "STracker is still running in the background. Click the system tray to get me back.";

            switch (this.WindowState) {
                case FormWindowState.Minimized:
                    if (App.Minimize) {

                        nIcon.Visible = true;
                        nIcon.ShowBalloonTip(500);
                        this.Hide();
                    }
                    break;
                case FormWindowState.Normal:
                    nIcon.Visible = false;
                    break;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
