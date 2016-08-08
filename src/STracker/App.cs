using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Config.NET;
using ExtensionMethods;

namespace STracker {
    internal class App {
        public static string OutputPath { get; set; }
        public static bool Minimize { get; set; }
        public static ConfigFile file = new ConfigFile("", "settings");
        public void Load() {
            if (!file.FileExists()) {
                file.AddConfig("outputPath", "");
                file.AddConfig("minimizeToTray", "0");
                file.Write();
            }
            file.Load();
            OutputPath = file.GetConfig("outputPath");
            Minimize = file.GetConfig("minimizeToTray").ToBool();
        }

        public void Update() {
            file.RemoveConfig("outputPath");
            file.RemoveConfig("minimizeToTray");
            file.AddConfig("outputPath", OutputPath);
            file.AddConfig("minimizeToTray", Minimize.ToString());
            file.Write();
        }
    }
}
