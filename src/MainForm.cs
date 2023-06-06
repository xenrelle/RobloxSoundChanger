using MetroFramework.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using RobloxDeathSoundChanger.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobloxDeathSoundChanger {
    public partial class MainForm : MetroForm {
        public MainForm() {
            InitializeComponent();
            this.StyleManager = MSM;
            this.soundTypeBox.SelectedIndex = 0;
        }

        private void ChangeSoundType(object sender, EventArgs e) {
            noDirectoryLabel.Visible = false;
            soundEffectGrid.Rows.Clear();
            var selectedDir = "";
            var selectedFileType = "mp3";
            if (this.soundTypeBox.SelectedIndex == 0) {
                selectedFileType = "ogg";
                selectedDir = Settings.Default.deathDirectory;
            } else if (this.soundTypeBox.SelectedIndex == 1) {
                selectedFileType = "mp3";
                selectedDir = Settings.Default.jumpDirectory;
            }
            if (String.IsNullOrEmpty(selectedDir)) {
                noDirectoryLabel.Text = "No directory has been set for this sound type.\r\nUse the 'Set Sound Directory' button below to choose what folder your sounds are stored in.";
                noDirectoryLabel.Visible = true;
                return;
            }
            var files = Directory.GetFiles(selectedDir, $"*.{selectedFileType}", SearchOption.TopDirectoryOnly);
            if (files.Length <= 0) {
                noDirectoryLabel.Text = $"No files of type {selectedFileType} have been found in this directory.";
                noDirectoryLabel.Visible = true;
                return;
            }
            foreach (var file in files) {
                soundEffectGrid.Rows.Add(Path.GetFileName(file));
            }
        }

        private void MSGBox(string text, MessageBoxIcon icon = MessageBoxIcon.Asterisk) {
            MessageBox.Show(text, "Roblox Sound Editor", MessageBoxButtons.OK, icon);
        }

        private string GetRobloxDir() {
            var robloxDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Roblox\Versions";
            var dirs = Directory.GetDirectories(robloxDir);
            var gameDir = "";
            foreach (var dir in dirs) {
                var files = Directory.GetFiles(dir);
                foreach (var file in files) {
                    if (Path.GetFileName(file) == "RobloxPlayerBeta.exe") {
                        gameDir = dir;
                        break;
                    }
                }
                if (gameDir != "") {
                    break;
                }
            }
            return gameDir;
        }

        private void SetSoundDirectory(object sender, EventArgs e) {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                if (soundTypeBox.SelectedIndex == 0) {
                    Settings.Default.deathDirectory = dialog.FileName;
                } else if (soundTypeBox.SelectedIndex == 1) {
                    Settings.Default.jumpDirectory = dialog.FileName;
                }
                Settings.Default.Save();
                MSGBox("Successfully set the directory!");
                ChangeSoundType(null, null);
            }
        }

        private void ResetToDefault(object sender, EventArgs e) {
            var robloxDir = GetRobloxDir();
            if (String.IsNullOrEmpty(robloxDir)) {
                MSGBox("Could not find the Roblox directory. Try reinstalling Roblox, and if the issue still persists, please create an issue on the GitHub repository.", MessageBoxIcon.Error);
                return;
            }
            if (soundTypeBox.SelectedIndex == 0) {
                File.WriteAllBytes($@"{robloxDir}\content\sounds\ouch.ogg", Resources.ouch);
                MSGBox("Successfully reset the Roblox death sound. Either rejoin the game you're in or restart Roblox for changes to take effect.");
            } else if (soundTypeBox.SelectedIndex == 1) {
                File.WriteAllBytes($@"{robloxDir}\content\sounds\action_jump.mp3", Resources.action_jump);
                MSGBox("Successfully reset the Roblox jump sound. Either rejoin the game you're in or restart Roblox for changes to take effect.");
            }
        }

        private void SetSound(object sender, EventArgs e) {
            var robloxDir = GetRobloxDir();
            if (String.IsNullOrEmpty(robloxDir)) {
                MSGBox("Could not find the Roblox directory. Try reinstalling Roblox, and if the issue still persists, please create an issue on the GitHub repository.", MessageBoxIcon.Error);
                return;
            }
            if (soundEffectGrid.SelectedRows.Count <= 0) {
                MSGBox("Please select a sound first before attempting to replace.", MessageBoxIcon.Error);
                return;
            }
            var selectedRow = soundEffectGrid.SelectedRows[0];
            if (soundTypeBox.SelectedIndex == 0) {
                var initialSound = $"{Settings.Default.deathDirectory}\\{(string)selectedRow.Cells[0].Value}";
                File.WriteAllBytes($@"{robloxDir}\content\sounds\ouch.ogg", File.ReadAllBytes(initialSound));
                MSGBox("Successfully changed the Roblox death sound. Either rejoin the game you're in or restart Roblox for changes to take effect.");
            } else if (soundTypeBox.SelectedIndex == 1) {
                var initialSound = $"{Settings.Default.jumpDirectory}\\{(string)selectedRow.Cells[0].Value}";
                File.WriteAllBytes($@"{robloxDir}\content\sounds\action_jump.mp3", File.ReadAllBytes(initialSound));
                MSGBox("Successfully changed the Roblox jump sound. Either rejoin the game you're in or restart Roblox for changes to take effect.");
            }
        }

        private void SetMaxFPS(object sender, EventArgs e) {
            var robloxDir = GetRobloxDir();
            if (String.IsNullOrEmpty(robloxDir)) {
                MSGBox("Could not find the Roblox directory. Please contact xenona about this.", MessageBoxIcon.Error);
                return;
            }
            var clientSettingsDir = $@"{robloxDir}\ClientSettings";
            if (!Directory.Exists(clientSettingsDir)) Directory.CreateDirectory(clientSettingsDir);
            File.WriteAllText($@"{clientSettingsDir}\ClientAppSettings.json", $"{{\n\t\"DFIntTaskSchedulerTargetFps\": {fpsCount.Value}\n}}");
            MSGBox($"Successfully set the maximum FPS to {fpsCount.Value}! Please restart Roblox for changes to take effect.");
        }
    }
}
