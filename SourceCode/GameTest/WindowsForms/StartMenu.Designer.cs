namespace GameTest.WindowsForms
{
    partial class StartMenu
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
            this.StartGameWinForms = new System.Windows.Forms.Button();
            this.RendererSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gameLoopSpeed = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NoOfFighters = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RespawnScroller = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.NumberOfTeamsScroller = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PickupScroller = new System.Windows.Forms.TrackBar();
            this.checkStatistics = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RendererSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLoopSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfFighters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RespawnScroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTeamsScroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickupScroller)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGameWinForms
            // 
            this.StartGameWinForms.Location = new System.Drawing.Point(482, 349);
            this.StartGameWinForms.Name = "StartGameWinForms";
            this.StartGameWinForms.Size = new System.Drawing.Size(228, 82);
            this.StartGameWinForms.TabIndex = 0;
            this.StartGameWinForms.Text = "Start in Win. Forms";
            this.StartGameWinForms.UseVisualStyleBackColor = true;
            this.StartGameWinForms.Click += new System.EventHandler(this.StartGameWinForms_Click);
            // 
            // RendererSpeed
            // 
            this.RendererSpeed.Location = new System.Drawing.Point(135, 33);
            this.RendererSpeed.Maximum = 100;
            this.RendererSpeed.Name = "RendererSpeed";
            this.RendererSpeed.Size = new System.Drawing.Size(134, 56);
            this.RendererSpeed.TabIndex = 1;
            this.RendererSpeed.Value = 20;
            this.RendererSpeed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time per Frame (Renderer)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "As fast as possible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "100 ms";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "100 ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "As fast as possible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time per Tick (GameLoop)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // gameLoopSpeed
            // 
            this.gameLoopSpeed.Location = new System.Drawing.Point(517, 33);
            this.gameLoopSpeed.Maximum = 100;
            this.gameLoopSpeed.Name = "gameLoopSpeed";
            this.gameLoopSpeed.Size = new System.Drawing.Size(134, 56);
            this.gameLoopSpeed.TabIndex = 5;
            this.gameLoopSpeed.Value = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "50 VS 50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "1 VS 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "AI-Fighters";
            // 
            // NoOfFighters
            // 
            this.NoOfFighters.Location = new System.Drawing.Point(135, 174);
            this.NoOfFighters.Maximum = 50;
            this.NoOfFighters.Minimum = 1;
            this.NoOfFighters.Name = "NoOfFighters";
            this.NoOfFighters.Size = new System.Drawing.Size(134, 56);
            this.NoOfFighters.TabIndex = 9;
            this.NoOfFighters.Value = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "every 200th tick";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "each tick";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Respawn Rate";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // RespawnScroller
            // 
            this.RespawnScroller.Location = new System.Drawing.Point(130, 254);
            this.RespawnScroller.Maximum = 200;
            this.RespawnScroller.Minimum = 1;
            this.RespawnScroller.Name = "RespawnScroller";
            this.RespawnScroller.Size = new System.Drawing.Size(134, 56);
            this.RespawnScroller.TabIndex = 14;
            this.RespawnScroller.Value = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(672, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(436, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(410, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Number of Teams";
            // 
            // NumberOfTeamsScroller
            // 
            this.NumberOfTeamsScroller.Location = new System.Drawing.Point(507, 175);
            this.NumberOfTeamsScroller.Maximum = 5;
            this.NumberOfTeamsScroller.Minimum = 2;
            this.NumberOfTeamsScroller.Name = "NumberOfTeamsScroller";
            this.NumberOfTeamsScroller.Size = new System.Drawing.Size(134, 56);
            this.NumberOfTeamsScroller.TabIndex = 18;
            this.NumberOfTeamsScroller.Value = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(656, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 17);
            this.label16.TabIndex = 25;
            this.label16.Text = "every 500th tick";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(447, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "each tick";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(427, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Pickup Rate";
            // 
            // PickupScroller
            // 
            this.PickupScroller.Location = new System.Drawing.Point(517, 254);
            this.PickupScroller.Maximum = 500;
            this.PickupScroller.Minimum = 1;
            this.PickupScroller.Name = "PickupScroller";
            this.PickupScroller.Size = new System.Drawing.Size(134, 56);
            this.PickupScroller.TabIndex = 22;
            this.PickupScroller.Value = 100;
            // 
            // checkStatistics
            // 
            this.checkStatistics.AutoSize = true;
            this.checkStatistics.Location = new System.Drawing.Point(10, 95);
            this.checkStatistics.Name = "checkStatistics";
            this.checkStatistics.Size = new System.Drawing.Size(122, 21);
            this.checkStatistics.TabIndex = 26;
            this.checkStatistics.Text = "show Statistics";
            this.checkStatistics.UseVisualStyleBackColor = true;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 443);
            this.Controls.Add(this.checkStatistics);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PickupScroller);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.NumberOfTeamsScroller);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RespawnScroller);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NoOfFighters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gameLoopSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RendererSpeed);
            this.Controls.Add(this.StartGameWinForms);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            ((System.ComponentModel.ISupportInitialize)(this.RendererSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLoopSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfFighters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RespawnScroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTeamsScroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickupScroller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGameWinForms;
        private System.Windows.Forms.TrackBar RendererSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar gameLoopSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar NoOfFighters;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar RespawnScroller;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar NumberOfTeamsScroller;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar PickupScroller;
        private System.Windows.Forms.CheckBox checkStatistics;
    }
}