namespace RobloxDeathSoundChanger {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MSM = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mainTabs = new MetroFramework.Controls.MetroTabControl();
            this.soundReplaceTab = new MetroFramework.Controls.MetroTabPage();
            this.noDirectoryLabel = new MetroFramework.Controls.MetroLabel();
            this.soundTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.soundTypeBox = new MetroFramework.Controls.MetroComboBox();
            this.changeDirButton = new MetroFramework.Controls.MetroButton();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.setSoundButton = new MetroFramework.Controls.MetroButton();
            this.soundEffectGrid = new MetroFramework.Controls.MetroGrid();
            this.soundFileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrasTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.fpsGroupBoxPanel = new MetroFramework.Controls.MetroPanel();
            this.setFPSButton = new MetroFramework.Controls.MetroButton();
            this.fpsLabel = new MetroFramework.Controls.MetroLabel();
            this.fpsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MSM)).BeginInit();
            this.mainTabs.SuspendLayout();
            this.soundReplaceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundEffectGrid)).BeginInit();
            this.extrasTab.SuspendLayout();
            this.fpsGroupBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // MSM
            // 
            this.MSM.Owner = this;
            this.MSM.Style = MetroFramework.MetroColorStyle.Red;
            this.MSM.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.soundReplaceTab);
            this.mainTabs.Controls.Add(this.extrasTab);
            this.mainTabs.Location = new System.Drawing.Point(23, 63);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(814, 408);
            this.mainTabs.TabIndex = 0;
            this.mainTabs.UseSelectable = true;
            // 
            // soundReplaceTab
            // 
            this.soundReplaceTab.Controls.Add(this.noDirectoryLabel);
            this.soundReplaceTab.Controls.Add(this.soundTypeLabel);
            this.soundReplaceTab.Controls.Add(this.soundTypeBox);
            this.soundReplaceTab.Controls.Add(this.changeDirButton);
            this.soundReplaceTab.Controls.Add(this.resetButton);
            this.soundReplaceTab.Controls.Add(this.setSoundButton);
            this.soundReplaceTab.Controls.Add(this.soundEffectGrid);
            this.soundReplaceTab.HorizontalScrollbarBarColor = true;
            this.soundReplaceTab.HorizontalScrollbarHighlightOnWheel = false;
            this.soundReplaceTab.HorizontalScrollbarSize = 10;
            this.soundReplaceTab.Location = new System.Drawing.Point(4, 38);
            this.soundReplaceTab.Name = "soundReplaceTab";
            this.soundReplaceTab.Size = new System.Drawing.Size(806, 366);
            this.soundReplaceTab.TabIndex = 0;
            this.soundReplaceTab.Text = "Sound Replacer";
            this.soundReplaceTab.VerticalScrollbarBarColor = true;
            this.soundReplaceTab.VerticalScrollbarHighlightOnWheel = false;
            this.soundReplaceTab.VerticalScrollbarSize = 10;
            // 
            // noDirectoryLabel
            // 
            this.noDirectoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noDirectoryLabel.Location = new System.Drawing.Point(98, 108);
            this.noDirectoryLabel.Name = "noDirectoryLabel";
            this.noDirectoryLabel.Size = new System.Drawing.Size(611, 147);
            this.noDirectoryLabel.TabIndex = 8;
            this.noDirectoryLabel.Text = "No directory has been set for this sound type.\r\nUse the \'Set Sound Directory\' but" +
    "ton below to choose what folder your sounds are stored in.";
            this.noDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noDirectoryLabel.Visible = false;
            // 
            // soundTypeLabel
            // 
            this.soundTypeLabel.AutoSize = true;
            this.soundTypeLabel.Location = new System.Drawing.Point(3, 6);
            this.soundTypeLabel.Name = "soundTypeLabel";
            this.soundTypeLabel.Size = new System.Drawing.Size(80, 19);
            this.soundTypeLabel.TabIndex = 7;
            this.soundTypeLabel.Text = "Sound Type:";
            // 
            // soundTypeBox
            // 
            this.soundTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundTypeBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.soundTypeBox.FormattingEnabled = true;
            this.soundTypeBox.ItemHeight = 19;
            this.soundTypeBox.Items.AddRange(new object[] {
            "Death Sound Effect (Takes .OGG files)",
            "Jump Sound Effect (Takes .MP3 files)"});
            this.soundTypeBox.Location = new System.Drawing.Point(89, 4);
            this.soundTypeBox.Name = "soundTypeBox";
            this.soundTypeBox.Size = new System.Drawing.Size(714, 25);
            this.soundTypeBox.TabIndex = 6;
            this.soundTypeBox.UseSelectable = true;
            this.soundTypeBox.SelectedIndexChanged += new System.EventHandler(this.ChangeSoundType);
            // 
            // changeDirButton
            // 
            this.changeDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeDirButton.Location = new System.Drawing.Point(3, 340);
            this.changeDirButton.Name = "changeDirButton";
            this.changeDirButton.Size = new System.Drawing.Size(192, 23);
            this.changeDirButton.TabIndex = 5;
            this.changeDirButton.Text = "Set Sound Directory";
            this.changeDirButton.UseSelectable = true;
            this.changeDirButton.Click += new System.EventHandler(this.SetSoundDirectory);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(611, 340);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(192, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset Sound to Default";
            this.resetButton.UseSelectable = true;
            this.resetButton.Click += new System.EventHandler(this.ResetToDefault);
            // 
            // setSoundButton
            // 
            this.setSoundButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setSoundButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.setSoundButton.Location = new System.Drawing.Point(201, 321);
            this.setSoundButton.Name = "setSoundButton";
            this.setSoundButton.Size = new System.Drawing.Size(404, 42);
            this.setSoundButton.TabIndex = 4;
            this.setSoundButton.Text = "Set Sound";
            this.setSoundButton.UseSelectable = true;
            this.setSoundButton.Click += new System.EventHandler(this.SetSound);
            // 
            // soundEffectGrid
            // 
            this.soundEffectGrid.AllowUserToAddRows = false;
            this.soundEffectGrid.AllowUserToDeleteRows = false;
            this.soundEffectGrid.AllowUserToResizeColumns = false;
            this.soundEffectGrid.AllowUserToResizeRows = false;
            this.soundEffectGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundEffectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soundEffectGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.soundEffectGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soundEffectGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.soundEffectGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.soundEffectGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.soundEffectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soundEffectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soundFileColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.soundEffectGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.soundEffectGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.soundEffectGrid.EnableHeadersVisualStyles = false;
            this.soundEffectGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.soundEffectGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.soundEffectGrid.Location = new System.Drawing.Point(3, 34);
            this.soundEffectGrid.Name = "soundEffectGrid";
            this.soundEffectGrid.ReadOnly = true;
            this.soundEffectGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.soundEffectGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.soundEffectGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.soundEffectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soundEffectGrid.Size = new System.Drawing.Size(800, 281);
            this.soundEffectGrid.TabIndex = 3;
            // 
            // soundFileColumn
            // 
            this.soundFileColumn.HeaderText = "File Name";
            this.soundFileColumn.Name = "soundFileColumn";
            this.soundFileColumn.ReadOnly = true;
            // 
            // extrasTab
            // 
            this.extrasTab.Controls.Add(this.metroLabel1);
            this.extrasTab.Controls.Add(this.fpsGroupBoxPanel);
            this.extrasTab.HorizontalScrollbarBarColor = true;
            this.extrasTab.HorizontalScrollbarHighlightOnWheel = false;
            this.extrasTab.HorizontalScrollbarSize = 10;
            this.extrasTab.Location = new System.Drawing.Point(4, 38);
            this.extrasTab.Name = "extrasTab";
            this.extrasTab.Size = new System.Drawing.Size(806, 366);
            this.extrasTab.TabIndex = 1;
            this.extrasTab.Text = "Extras";
            this.extrasTab.VerticalScrollbarBarColor = true;
            this.extrasTab.VerticalScrollbarHighlightOnWheel = false;
            this.extrasTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "FPS Unlocker";
            // 
            // fpsGroupBoxPanel
            // 
            this.fpsGroupBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsGroupBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpsGroupBoxPanel.Controls.Add(this.setFPSButton);
            this.fpsGroupBoxPanel.Controls.Add(this.fpsLabel);
            this.fpsGroupBoxPanel.Controls.Add(this.fpsCount);
            this.fpsGroupBoxPanel.HorizontalScrollbarBarColor = true;
            this.fpsGroupBoxPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.fpsGroupBoxPanel.HorizontalScrollbarSize = 10;
            this.fpsGroupBoxPanel.Location = new System.Drawing.Point(3, 11);
            this.fpsGroupBoxPanel.Name = "fpsGroupBoxPanel";
            this.fpsGroupBoxPanel.Size = new System.Drawing.Size(800, 58);
            this.fpsGroupBoxPanel.TabIndex = 11;
            this.fpsGroupBoxPanel.VerticalScrollbarBarColor = true;
            this.fpsGroupBoxPanel.VerticalScrollbarHighlightOnWheel = false;
            this.fpsGroupBoxPanel.VerticalScrollbarSize = 10;
            // 
            // setFPSButton
            // 
            this.setFPSButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setFPSButton.Location = new System.Drawing.Point(471, 17);
            this.setFPSButton.Name = "setFPSButton";
            this.setFPSButton.Size = new System.Drawing.Size(105, 23);
            this.setFPSButton.TabIndex = 11;
            this.setFPSButton.Text = "Set FPS Limit";
            this.setFPSButton.UseSelectable = true;
            this.setFPSButton.Click += new System.EventHandler(this.SetMaxFPS);
            // 
            // fpsLabel
            // 
            this.fpsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.fpsLabel.Location = new System.Drawing.Point(404, 18);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(61, 19);
            this.fpsLabel.TabIndex = 10;
            this.fpsLabel.Text = "Max FPS";
            // 
            // fpsCount
            // 
            this.fpsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fpsCount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsCount.ForeColor = System.Drawing.SystemColors.Window;
            this.fpsCount.Location = new System.Drawing.Point(222, 12);
            this.fpsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fpsCount.Name = "fpsCount";
            this.fpsCount.Size = new System.Drawing.Size(176, 33);
            this.fpsCount.TabIndex = 9;
            this.fpsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpsCount.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 494);
            this.Controls.Add(this.mainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Roblox Sound Editor v2.1";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.MSM)).EndInit();
            this.mainTabs.ResumeLayout(false);
            this.soundReplaceTab.ResumeLayout(false);
            this.soundReplaceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundEffectGrid)).EndInit();
            this.extrasTab.ResumeLayout(false);
            this.extrasTab.PerformLayout();
            this.fpsGroupBoxPanel.ResumeLayout(false);
            this.fpsGroupBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager MSM;
        private MetroFramework.Controls.MetroTabControl mainTabs;
        private MetroFramework.Controls.MetroTabPage soundReplaceTab;
        private MetroFramework.Controls.MetroLabel soundTypeLabel;
        private MetroFramework.Controls.MetroComboBox soundTypeBox;
        private MetroFramework.Controls.MetroButton changeDirButton;
        private MetroFramework.Controls.MetroButton resetButton;
        private MetroFramework.Controls.MetroButton setSoundButton;
        private MetroFramework.Controls.MetroGrid soundEffectGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn soundFileColumn;
        private MetroFramework.Controls.MetroLabel noDirectoryLabel;
        private MetroFramework.Controls.MetroTabPage extrasTab;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel fpsGroupBoxPanel;
        private MetroFramework.Controls.MetroButton setFPSButton;
        private MetroFramework.Controls.MetroLabel fpsLabel;
        private System.Windows.Forms.NumericUpDown fpsCount;
    }
}