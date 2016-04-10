namespace GameTest.WindowsForms
{
    partial class QuickStartForm
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
            this.NoOfPlayers = new System.Windows.Forms.ComboBox();
            this.GameMode = new System.Windows.Forms.ComboBox();
            this.TeamNumber = new System.Windows.Forms.ComboBox();
            this.Pickups = new System.Windows.Forms.ComboBox();
            this.Respawn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotNumber = new System.Windows.Forms.ComboBox();
            this.Points = new System.Windows.Forms.ComboBox();
            this.StartQuickMatch = new System.Windows.Forms.Button();
            this.QuickStart = new System.Windows.Forms.GroupBox();
            this.WeaponCeption = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuickStart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoOfPlayers
            // 
            this.NoOfPlayers.FormattingEnabled = true;
            this.NoOfPlayers.Items.AddRange(new object[] {
            "Only Bots",
            "1 Player",
            "2 Players",
            "3 Players",
            "4 Players"});
            this.NoOfPlayers.Location = new System.Drawing.Point(5, 21);
            this.NoOfPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoOfPlayers.Name = "NoOfPlayers";
            this.NoOfPlayers.Size = new System.Drawing.Size(121, 24);
            this.NoOfPlayers.TabIndex = 0;
            // 
            // GameMode
            // 
            this.GameMode.FormattingEnabled = true;
            this.GameMode.Items.AddRange(new object[] {
            "Free Roam",
            "DeathMatch",
            "MoneyMaker"});
            this.GameMode.Location = new System.Drawing.Point(133, 21);
            this.GameMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameMode.Name = "GameMode";
            this.GameMode.Size = new System.Drawing.Size(121, 24);
            this.GameMode.TabIndex = 1;
            this.GameMode.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TeamNumber
            // 
            this.TeamNumber.FormattingEnabled = true;
            this.TeamNumber.Items.AddRange(new object[] {
            "2 Teams",
            "3 Teams",
            "4 Teams",
            "5 Teams"});
            this.TeamNumber.Location = new System.Drawing.Point(5, 52);
            this.TeamNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamNumber.Name = "TeamNumber";
            this.TeamNumber.Size = new System.Drawing.Size(121, 24);
            this.TeamNumber.TabIndex = 2;
            // 
            // Pickups
            // 
            this.Pickups.FormattingEnabled = true;
            this.Pickups.Items.AddRange(new object[] {
            "Few Pickups",
            "Some Pickups",
            "Pickups ",
            "Many Pickups",
            "WTF ?"});
            this.Pickups.Location = new System.Drawing.Point(133, 84);
            this.Pickups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pickups.Name = "Pickups";
            this.Pickups.Size = new System.Drawing.Size(121, 24);
            this.Pickups.TabIndex = 3;
            // 
            // Respawn
            // 
            this.Respawn.FormattingEnabled = true;
            this.Respawn.Items.AddRange(new object[] {
            "Fast",
            "Middle",
            "Slow",
            "Very Slow"});
            this.Respawn.Location = new System.Drawing.Point(133, 114);
            this.Respawn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Respawn.Name = "Respawn";
            this.Respawn.Size = new System.Drawing.Size(121, 24);
            this.Respawn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pickups";
            // 
            // BotNumber
            // 
            this.BotNumber.FormattingEnabled = true;
            this.BotNumber.Items.AddRange(new object[] {
            "No Bots",
            "Some Bots",
            "Normal Bots",
            "Many Bots",
            "WFT?"});
            this.BotNumber.Location = new System.Drawing.Point(133, 52);
            this.BotNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotNumber.Name = "BotNumber";
            this.BotNumber.Size = new System.Drawing.Size(121, 24);
            this.BotNumber.TabIndex = 7;
            // 
            // Points
            // 
            this.Points.FormattingEnabled = true;
            this.Points.Items.AddRange(new object[] {
            "50   Points",
            "100 Points",
            "200 Points",
            "300 Points",
            "500 Points",
            "1000 Points"});
            this.Points.Location = new System.Drawing.Point(261, 18);
            this.Points.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(121, 24);
            this.Points.TabIndex = 8;
            // 
            // StartQuickMatch
            // 
            this.StartQuickMatch.Location = new System.Drawing.Point(261, 52);
            this.StartQuickMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartQuickMatch.Name = "StartQuickMatch";
            this.StartQuickMatch.Size = new System.Drawing.Size(121, 86);
            this.StartQuickMatch.TabIndex = 9;
            this.StartQuickMatch.Text = "Start !";
            this.StartQuickMatch.UseVisualStyleBackColor = true;
            this.StartQuickMatch.Click += new System.EventHandler(this.StartQuickMatch_Click);
            // 
            // QuickStart
            // 
            this.QuickStart.Controls.Add(this.WeaponCeption);
            this.QuickStart.Controls.Add(this.label2);
            this.QuickStart.Controls.Add(this.NoOfPlayers);
            this.QuickStart.Controls.Add(this.StartQuickMatch);
            this.QuickStart.Controls.Add(this.GameMode);
            this.QuickStart.Controls.Add(this.Points);
            this.QuickStart.Controls.Add(this.TeamNumber);
            this.QuickStart.Controls.Add(this.BotNumber);
            this.QuickStart.Controls.Add(this.Pickups);
            this.QuickStart.Controls.Add(this.Respawn);
            this.QuickStart.Controls.Add(this.label1);
            this.QuickStart.Location = new System.Drawing.Point(12, 12);
            this.QuickStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuickStart.Name = "QuickStart";
            this.QuickStart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuickStart.Size = new System.Drawing.Size(397, 177);
            this.QuickStart.TabIndex = 10;
            this.QuickStart.TabStop = false;
            this.QuickStart.Text = "QuickStart";
            // 
            // WeaponCeption
            // 
            this.WeaponCeption.AutoSize = true;
            this.WeaponCeption.Checked = true;
            this.WeaponCeption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WeaponCeption.Location = new System.Drawing.Point(7, 142);
            this.WeaponCeption.Name = "WeaponCeption";
            this.WeaponCeption.Size = new System.Drawing.Size(193, 21);
            this.WeaponCeption.TabIndex = 11;
            this.WeaponCeption.Text = "Weapon Stacking Allowed";
            this.WeaponCeption.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bot Respawn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Customize it yourself!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 20);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(343, 68);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Minigame\r\n\r\nCopyright © 2016, M. A. Huber\r\nThis work is licensed under the BSD 3-" +
    "Clause license";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(393, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fighting Squares";
            // 
            // QuickStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuickStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(437, 400);
            this.MinimumSize = new System.Drawing.Size(437, 400);
            this.Name = "QuickStartForm";
            this.Text = "QuickStartForm";
            this.QuickStart.ResumeLayout(false);
            this.QuickStart.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox NoOfPlayers;
        private System.Windows.Forms.ComboBox GameMode;
        private System.Windows.Forms.ComboBox TeamNumber;
        private System.Windows.Forms.ComboBox Pickups;
        private System.Windows.Forms.ComboBox Respawn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BotNumber;
        private System.Windows.Forms.ComboBox Points;
        private System.Windows.Forms.Button StartQuickMatch;
        private System.Windows.Forms.GroupBox QuickStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox WeaponCeption;
    }
}