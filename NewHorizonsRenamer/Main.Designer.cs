namespace NewHorizonsRenamer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveOldButton = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.TownNameLabel = new System.Windows.Forms.Label();
            this.PlayerNum = new System.Windows.Forms.NumericUpDown();
            this.TownName = new System.Windows.Forms.TextBox();
            this.PlayerID = new System.Windows.Forms.Label();
            this.TownID = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SaveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenButton.Location = new System.Drawing.Point(12, 71);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(90, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open main.dat";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveBox
            // 
            this.SaveBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBox.Controls.Add(this.TownID);
            this.SaveBox.Controls.Add(this.PlayerID);
            this.SaveBox.Controls.Add(this.TownName);
            this.SaveBox.Controls.Add(this.PlayerNum);
            this.SaveBox.Controls.Add(this.TownNameLabel);
            this.SaveBox.Controls.Add(this.PlayerNameLabel);
            this.SaveBox.Controls.Add(this.PlayerName);
            this.SaveBox.Controls.Add(this.SaveOldButton);
            this.SaveBox.Controls.Add(this.SaveButton);
            this.SaveBox.Enabled = false;
            this.SaveBox.Location = new System.Drawing.Point(12, 100);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(348, 149);
            this.SaveBox.TabIndex = 1;
            this.SaveBox.TabStop = false;
            this.SaveBox.Text = "Editor";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(267, 120);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveOldButton
            // 
            this.SaveOldButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveOldButton.Location = new System.Drawing.Point(145, 120);
            this.SaveOldButton.Name = "SaveOldButton";
            this.SaveOldButton.Size = new System.Drawing.Size(116, 23);
            this.SaveOldButton.TabIndex = 1;
            this.SaveOldButton.Text = "Save (with old IDs)";
            this.SaveOldButton.UseVisualStyleBackColor = true;
            this.SaveOldButton.Visible = false;
            this.SaveOldButton.Click += new System.EventHandler(this.SaveOldButton_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerName.Location = new System.Drawing.Point(82, 19);
            this.PlayerName.MaxLength = 10;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(216, 20);
            this.PlayerName.TabIndex = 2;
            this.PlayerName.TextChanged += new System.EventHandler(this.PlayerName_TextChanged);
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(6, 22);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(70, 13);
            this.PlayerNameLabel.TabIndex = 3;
            this.PlayerNameLabel.Text = "Player Name:";
            // 
            // TownNameLabel
            // 
            this.TownNameLabel.AutoSize = true;
            this.TownNameLabel.Location = new System.Drawing.Point(6, 72);
            this.TownNameLabel.Name = "TownNameLabel";
            this.TownNameLabel.Size = new System.Drawing.Size(68, 13);
            this.TownNameLabel.TabIndex = 4;
            this.TownNameLabel.Text = "Town Name:";
            // 
            // PlayerNum
            // 
            this.PlayerNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerNum.Location = new System.Drawing.Point(304, 19);
            this.PlayerNum.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PlayerNum.Name = "PlayerNum";
            this.PlayerNum.Size = new System.Drawing.Size(33, 20);
            this.PlayerNum.TabIndex = 5;
            this.PlayerNum.ValueChanged += new System.EventHandler(this.PlayerNum_ValueChanged);
            // 
            // TownName
            // 
            this.TownName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TownName.Location = new System.Drawing.Point(82, 69);
            this.TownName.MaxLength = 10;
            this.TownName.Name = "TownName";
            this.TownName.Size = new System.Drawing.Size(216, 20);
            this.TownName.TabIndex = 6;
            this.TownName.TextChanged += new System.EventHandler(this.TownName_TextChanged);
            // 
            // PlayerID
            // 
            this.PlayerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerID.Location = new System.Drawing.Point(82, 42);
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.Size = new System.Drawing.Size(216, 24);
            this.PlayerID.TabIndex = 7;
            this.PlayerID.Text = "ID: 00000000";
            this.PlayerID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TownID
            // 
            this.TownID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TownID.Location = new System.Drawing.Point(82, 92);
            this.TownID.Name = "TownID";
            this.TownID.Size = new System.Drawing.Size(216, 24);
            this.TownID.TabIndex = 8;
            this.TownID.Text = "ID: 00000000";
            this.TownID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.Location = new System.Drawing.Point(108, 68);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(252, 31);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Browse and open a main.dat file.";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(348, 52);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "This tool allows you to edit Villager and Town names in AC:NH without side effect" +
    "s. The latest supported version is v1.4.2. Based off of NHSE. Make sure you back" +
    " up your save!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 261);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SaveBox);
            this.Controls.Add(this.OpenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "New Horizons Renamer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SaveBox.ResumeLayout(false);
            this.SaveBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.GroupBox SaveBox;
        private System.Windows.Forms.Label TownID;
        private System.Windows.Forms.Label PlayerID;
        private System.Windows.Forms.TextBox TownName;
        private System.Windows.Forms.NumericUpDown PlayerNum;
        private System.Windows.Forms.Label TownNameLabel;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Button SaveOldButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}

