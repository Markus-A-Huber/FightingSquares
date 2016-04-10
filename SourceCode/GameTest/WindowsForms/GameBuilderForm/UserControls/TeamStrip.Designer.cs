namespace GameTest.WindowsForms.GameBuilderForm.UserControls
{
    partial class TeamStrip
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeamName = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TeamColor = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.AddBot = new System.Windows.Forms.Button();
            this.TeamName.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.BackColor = System.Drawing.Color.White;
            this.TeamName.Controls.Add(this.tableLayoutPanel1);
            this.TeamName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamName.Location = new System.Drawing.Point(0, 0);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(607, 262);
            this.TeamName.TabIndex = 2;
            this.TeamName.TabStop = false;
            this.TeamName.Text = "Team 1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.66277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.33723F));
            this.tableLayoutPanel1.Controls.Add(this.TeamColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 241);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TeamColor
            // 
            this.TeamColor.BackColor = System.Drawing.Color.Red;
            this.TeamColor.ForeColor = System.Drawing.Color.Red;
            this.TeamColor.Location = new System.Drawing.Point(3, 3);
            this.TeamColor.Name = "TeamColor";
            this.TeamColor.Size = new System.Drawing.Size(118, 102);
            this.TeamColor.TabIndex = 0;
            this.TeamColor.UseVisualStyleBackColor = false;
            this.TeamColor.Click += new System.EventHandler(this.TeamColor_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.07512F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(471, 235);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.AddPlayer, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddBot, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 229);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // AddPlayer
            // 
            this.AddPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPlayer.Location = new System.Drawing.Point(3, 3);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(194, 108);
            this.AddPlayer.TabIndex = 0;
            this.AddPlayer.Text = "+Player";
            this.AddPlayer.UseVisualStyleBackColor = true;
            this.AddPlayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBot
            // 
            this.AddBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBot.Location = new System.Drawing.Point(3, 117);
            this.AddBot.Name = "AddBot";
            this.AddBot.Size = new System.Drawing.Size(194, 109);
            this.AddBot.TabIndex = 1;
            this.AddBot.Text = "+Bot";
            this.AddBot.UseVisualStyleBackColor = true;
            this.AddBot.Click += new System.EventHandler(this.AddBot_Click);
            // 
            // TeamStrip
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.TeamName);
            this.Name = "TeamStrip";
            this.Size = new System.Drawing.Size(607, 262);
            this.TeamName.ResumeLayout(false);
            this.TeamName.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TeamName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button TeamColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.Button AddBot;
    }
}
