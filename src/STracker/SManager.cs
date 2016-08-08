using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STracker {
    class SManager {
        public static readonly string ProcessName = "Spotify";
        public string GetTrackInfo() {
            var proc = Process.GetProcessesByName(ProcessName).FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null) {
                return "";
            }

            if (string.Equals(proc.MainWindowTitle, ProcessName, StringComparison.InvariantCultureIgnoreCase)) {
                return "";
            }


            return proc.MainWindowTitle;
        }
    }
}
