using GameTest.Game.GameElements;
using System.Collections.Generic;
using System.Drawing;

namespace GameTest.WindowsForms.GameBuilderForm
{
    partial class GameBuilderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBuilderForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WingsCheckbox = new System.Windows.Forms.CheckBox();
            this.TwisterCheckbox = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.RocketCheckbox = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TentacleCheckbox = new System.Windows.Forms.CheckBox();
            this.FlameCheckbox = new System.Windows.Forms.CheckBox();
            this.CannonCheckbox = new System.Windows.Forms.CheckBox();
            this.ShieldCheckbox = new System.Windows.Forms.CheckBox();
            this.HealthCheckbox = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GameMode = new System.Windows.Forms.ComboBox();
            this.Points = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PickupScroller = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RespawnScroller = new System.Windows.Forms.TrackBar();
            this.checkStatistics = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gameLoopSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.RendererSpeed = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WeaponceptionCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickupScroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RespawnScroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLoopSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RendererSpeed)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WingsCheckbox);
            this.groupBox2.Controls.Add(this.TwisterCheckbox);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.RocketCheckbox);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.TentacleCheckbox);
            this.groupBox2.Controls.Add(this.FlameCheckbox);
            this.groupBox2.Controls.Add(this.CannonCheckbox);
            this.groupBox2.Controls.Add(this.ShieldCheckbox);
            this.groupBox2.Controls.Add(this.HealthCheckbox);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 164);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dropping Pickups";
            // 
            // WingsCheckbox
            // 
            this.WingsCheckbox.AutoSize = true;
            this.WingsCheckbox.Checked = true;
            this.WingsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WingsCheckbox.Location = new System.Drawing.Point(744, 27);
            this.WingsCheckbox.Name = "WingsCheckbox";
            this.WingsCheckbox.Size = new System.Drawing.Size(69, 21);
            this.WingsCheckbox.TabIndex = 15;
            this.WingsCheckbox.Text = "Wings";
            this.WingsCheckbox.UseVisualStyleBackColor = true;
            // 
            // TwisterCheckbox
            // 
            this.TwisterCheckbox.AutoSize = true;
            this.TwisterCheckbox.Checked = true;
            this.TwisterCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TwisterCheckbox.Location = new System.Drawing.Point(636, 27);
            this.TwisterCheckbox.Name = "TwisterCheckbox";
            this.TwisterCheckbox.Size = new System.Drawing.Size(75, 21);
            this.TwisterCheckbox.TabIndex = 13;
            this.TwisterCheckbox.Text = "Twister";
            this.TwisterCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(744, 54);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(90, 93);
            this.panel8.TabIndex = 14;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // RocketCheckbox
            // 
            this.RocketCheckbox.AutoSize = true;
            this.RocketCheckbox.Checked = true;
            this.RocketCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RocketCheckbox.Location = new System.Drawing.Point(529, 27);
            this.RocketCheckbox.Name = "RocketCheckbox";
            this.RocketCheckbox.Size = new System.Drawing.Size(93, 21);
            this.RocketCheckbox.TabIndex = 11;
            this.RocketCheckbox.Text = "Grenades";
            this.RocketCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(636, 54);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(90, 93);
            this.panel7.TabIndex = 12;
            // 
            // TentacleCheckbox
            // 
            this.TentacleCheckbox.AutoSize = true;
            this.TentacleCheckbox.Checked = true;
            this.TentacleCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TentacleCheckbox.Location = new System.Drawing.Point(429, 27);
            this.TentacleCheckbox.Name = "TentacleCheckbox";
            this.TentacleCheckbox.Size = new System.Drawing.Size(92, 21);
            this.TentacleCheckbox.TabIndex = 10;
            this.TentacleCheckbox.Text = "Tentacles";
            this.TentacleCheckbox.UseVisualStyleBackColor = true;
            // 
            // FlameCheckbox
            // 
            this.FlameCheckbox.AutoSize = true;
            this.FlameCheckbox.Checked = true;
            this.FlameCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FlameCheckbox.Location = new System.Drawing.Point(323, 27);
            this.FlameCheckbox.Name = "FlameCheckbox";
            this.FlameCheckbox.Size = new System.Drawing.Size(75, 21);
            this.FlameCheckbox.TabIndex = 9;
            this.FlameCheckbox.Text = "Flames";
            this.FlameCheckbox.UseVisualStyleBackColor = true;
            // 
            // CannonCheckbox
            // 
            this.CannonCheckbox.AutoSize = true;
            this.CannonCheckbox.Checked = true;
            this.CannonCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CannonCheckbox.Location = new System.Drawing.Point(223, 27);
            this.CannonCheckbox.Name = "CannonCheckbox";
            this.CannonCheckbox.Size = new System.Drawing.Size(79, 21);
            this.CannonCheckbox.TabIndex = 8;
            this.CannonCheckbox.Text = "Cannon";
            this.CannonCheckbox.UseVisualStyleBackColor = true;
            // 
            // ShieldCheckbox
            // 
            this.ShieldCheckbox.AutoSize = true;
            this.ShieldCheckbox.Checked = true;
            this.ShieldCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShieldCheckbox.Location = new System.Drawing.Point(118, 27);
            this.ShieldCheckbox.Name = "ShieldCheckbox";
            this.ShieldCheckbox.Size = new System.Drawing.Size(69, 21);
            this.ShieldCheckbox.TabIndex = 7;
            this.ShieldCheckbox.Text = "Shield";
            this.ShieldCheckbox.UseVisualStyleBackColor = true;
            // 
            // HealthCheckbox
            // 
            this.HealthCheckbox.AutoSize = true;
            this.HealthCheckbox.Checked = true;
            this.HealthCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HealthCheckbox.Location = new System.Drawing.Point(9, 27);
            this.HealthCheckbox.Name = "HealthCheckbox";
            this.HealthCheckbox.Size = new System.Drawing.Size(71, 21);
            this.HealthCheckbox.TabIndex = 6;
            this.HealthCheckbox.Text = "Health";
            this.HealthCheckbox.UseVisualStyleBackColor = true;
            this.HealthCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(529, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(90, 93);
            this.panel5.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(323, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 93);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(429, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(90, 93);
            this.panel6.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(118, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 93);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(223, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 93);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(9, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 93);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.WeaponceptionCheckbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.GameMode);
            this.groupBox1.Controls.Add(this.Points);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.PickupScroller);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.RespawnScroller);
            this.groupBox1.Controls.Add(this.checkStatistics);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gameLoopSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RendererSpeed);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Time per Frame (Renderer)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Respawn Rate";
            // 
            // GameMode
            // 
            this.GameMode.FormattingEnabled = true;
            this.GameMode.Items.AddRange(new object[] {
            "Free Roam",
            "DeathMatch",
            "MoneyMaker"});
            this.GameMode.Location = new System.Drawing.Point(9, 167);
            this.GameMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameMode.Name = "GameMode";
            this.GameMode.Size = new System.Drawing.Size(121, 24);
            this.GameMode.TabIndex = 45;
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
            this.Points.Location = new System.Drawing.Point(136, 167);
            this.Points.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(121, 24);
            this.Points.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 76);
            this.label1.TabIndex = 44;
            this.label1.Text = "Attention:\r\nYou are responsible to choose reasonable values regarding your CPU. \r" +
    "\nIf your PC freezes, try excaping with ESC key.";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(706, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "100 ms";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(204, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "every 500th tick";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "each tick";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(94, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "Pickup Rate";
            // 
            // PickupScroller
            // 
            this.PickupScroller.Location = new System.Drawing.Point(74, 44);
            this.PickupScroller.Maximum = 500;
            this.PickupScroller.Minimum = 1;
            this.PickupScroller.Name = "PickupScroller";
            this.PickupScroller.Size = new System.Drawing.Size(134, 56);
            this.PickupScroller.TabIndex = 39;
            this.PickupScroller.Value = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "every 200th tick";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "each tick";
            // 
            // RespawnScroller
            // 
            this.RespawnScroller.Location = new System.Drawing.Point(74, 118);
            this.RespawnScroller.Maximum = 200;
            this.RespawnScroller.Minimum = 1;
            this.RespawnScroller.Name = "RespawnScroller";
            this.RespawnScroller.Size = new System.Drawing.Size(134, 56);
            this.RespawnScroller.TabIndex = 35;
            this.RespawnScroller.Value = 50;
            // 
            // checkStatistics
            // 
            this.checkStatistics.AutoSize = true;
            this.checkStatistics.Location = new System.Drawing.Point(13, 217);
            this.checkStatistics.Name = "checkStatistics";
            this.checkStatistics.Size = new System.Drawing.Size(86, 21);
            this.checkStatistics.TabIndex = 34;
            this.checkStatistics.Text = "Statistics";
            this.checkStatistics.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "100 ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "As fast as possible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Time per Tick (GameLoop)";
            // 
            // gameLoopSpeed
            // 
            this.gameLoopSpeed.Location = new System.Drawing.Point(574, 39);
            this.gameLoopSpeed.Maximum = 100;
            this.gameLoopSpeed.Name = "gameLoopSpeed";
            this.gameLoopSpeed.Size = new System.Drawing.Size(134, 56);
            this.gameLoopSpeed.TabIndex = 30;
            this.gameLoopSpeed.Value = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "As fast as possible";
            // 
            // RendererSpeed
            // 
            this.RendererSpeed.Location = new System.Drawing.Point(574, 118);
            this.RendererSpeed.Maximum = 100;
            this.RendererSpeed.Name = "RendererSpeed";
            this.RendererSpeed.Size = new System.Drawing.Size(134, 56);
            this.RendererSpeed.TabIndex = 27;
            this.RendererSpeed.Value = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 651);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(870, 130);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(438, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(429, 124);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 876F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 887);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // WeaponceptionCheckbox
            // 
            this.WeaponceptionCheckbox.AutoSize = true;
            this.WeaponceptionCheckbox.Checked = true;
            this.WeaponceptionCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WeaponceptionCheckbox.Location = new System.Drawing.Point(613, 217);
            this.WeaponceptionCheckbox.Name = "WeaponceptionCheckbox";
            this.WeaponceptionCheckbox.Size = new System.Drawing.Size(136, 21);
            this.WeaponceptionCheckbox.TabIndex = 47;
            this.WeaponceptionCheckbox.Text = "Weapon-Ception";
            this.WeaponceptionCheckbox.UseVisualStyleBackColor = true;
            // 
            // GameBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 887);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameBuilderForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GameBuilderForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickupScroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RespawnScroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLoopSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RendererSpeed)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.TeamStrip teamStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox RocketCheckbox;
        private System.Windows.Forms.CheckBox TentacleCheckbox;
        private System.Windows.Forms.CheckBox FlameCheckbox;
        private System.Windows.Forms.CheckBox CannonCheckbox;
        private System.Windows.Forms.CheckBox ShieldCheckbox;
        private System.Windows.Forms.CheckBox HealthCheckbox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar PickupScroller;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar RespawnScroller;
        private System.Windows.Forms.CheckBox checkStatistics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar gameLoopSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar RendererSpeed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox GameMode;
        private System.Windows.Forms.ComboBox Points;
        private System.Windows.Forms.CheckBox WingsCheckbox;
        private System.Windows.Forms.CheckBox TwisterCheckbox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox WeaponceptionCheckbox;
    }
}