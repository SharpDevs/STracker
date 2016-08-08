namespace STracker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.cbSystemTray = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNowPlaying = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output file:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(76, 6);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(256, 20);
            this.txtOutputPath.TabIndex = 2;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.cbSystemTray);
            this.gbControls.Controls.Add(this.btnStart);
            this.gbControls.Controls.Add(this.btnSave);
            this.gbControls.Location = new System.Drawing.Point(15, 32);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(357, 43);
            this.gbControls.TabIndex = 3;
            this.gbControls.TabStop = false;
            // 
            // cbSystemTray
            // 
            this.cbSystemTray.AutoSize = true;
            this.cbSystemTray.Location = new System.Drawing.Point(6, 18);
            this.cbSystemTray.Name = "cbSystemTray";
            this.cbSystemTray.Size = new System.Drawing.Size(172, 17);
            this.cbSystemTray.TabIndex = 1;
            this.cbSystemTray.Text = "Minimize window to system tray";
            this.cbSystemTray.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::STracker.Properties.Resources.control_play_blue;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(195, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::STracker.Properties.Resources.save_as;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(276, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNowPlaying);
            this.groupBox1.Location = new System.Drawing.Point(15, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Now playing:";
            // 
            // lblNowPlaying
            // 
            this.lblNowPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowPlaying.Location = new System.Drawing.Point(3, 16);
            this.lblNowPlaying.Name = "lblNowPlaying";
            this.lblNowPlaying.Size = new System.Drawing.Size(351, 37);
            this.lblNowPlaying.TabIndex = 0;
            this.lblNowPlaying.Text = "Not playing";
            this.lblNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Image = global::STracker.Properties.Resources.folder_search;
            this.btnBrowseOutput.Location = new System.Drawing.Point(338, 4);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(34, 23);
            this.btnBrowseOutput.TabIndex = 1;
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // nIcon
            // 
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "STracker";
            this.nIcon.Visible = true;
            this.nIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 149);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 188);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 188);
            this.Name = "MainForm";
            this.Text = "STracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNowPlaying;
        private System.Windows.Forms.CheckBox cbSystemTray;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NotifyIcon nIcon;
    }
}

