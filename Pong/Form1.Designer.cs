namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paredeTopo = new System.Windows.Forms.Panel();
            this.paredeBase = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftWall = new System.Windows.Forms.Panel();
            this.RightWall = new System.Windows.Forms.Panel();
            this.MiddleBar = new System.Windows.Forms.Panel();
            this.pongLeft = new System.Windows.Forms.Panel();
            this.pongRight = new System.Windows.Forms.Panel();
            this.bola = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lPointsRight = new System.Windows.Forms.Label();
            this.lPointsLeft = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnStart = new System.Windows.Forms.Button();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paredeTopo
            // 
            this.paredeTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paredeTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paredeTopo.Location = new System.Drawing.Point(0, 24);
            this.paredeTopo.Name = "paredeTopo";
            this.paredeTopo.Size = new System.Drawing.Size(800, 10);
            this.paredeTopo.TabIndex = 0;
            // 
            // paredeBase
            // 
            this.paredeBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paredeBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paredeBase.Location = new System.Drawing.Point(0, 440);
            this.paredeBase.Name = "paredeBase";
            this.paredeBase.Size = new System.Drawing.Size(800, 10);
            this.paredeBase.TabIndex = 1;
            // 
            // LeftWall
            // 
            this.LeftWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LeftWall.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftWall.Location = new System.Drawing.Point(0, 34);
            this.LeftWall.Name = "LeftWall";
            this.LeftWall.Size = new System.Drawing.Size(10, 406);
            this.LeftWall.TabIndex = 2;
            // 
            // RightWall
            // 
            this.RightWall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RightWall.Location = new System.Drawing.Point(790, 34);
            this.RightWall.Name = "RightWall";
            this.RightWall.Size = new System.Drawing.Size(10, 406);
            this.RightWall.TabIndex = 3;
            // 
            // MiddleBar
            // 
            this.MiddleBar.BackColor = System.Drawing.Color.Gray;
            this.MiddleBar.Location = new System.Drawing.Point(390, 24);
            this.MiddleBar.Name = "MiddleBar";
            this.MiddleBar.Size = new System.Drawing.Size(14, 428);
            this.MiddleBar.TabIndex = 4;
            // 
            // pongLeft
            // 
            this.pongLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pongLeft.Location = new System.Drawing.Point(16, 180);
            this.pongLeft.Name = "pongLeft";
            this.pongLeft.Size = new System.Drawing.Size(10, 92);
            this.pongLeft.TabIndex = 4;
            // 
            // pongRight
            // 
            this.pongRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pongRight.Location = new System.Drawing.Point(774, 180);
            this.pongRight.Name = "pongRight";
            this.pongRight.Size = new System.Drawing.Size(10, 92);
            this.pongRight.TabIndex = 4;
            // 
            // bola
            // 
            this.bola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bola.Location = new System.Drawing.Point(313, 159);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(12, 14);
            this.bola.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lPointsRight
            // 
            this.lPointsRight.AutoSize = true;
            this.lPointsRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPointsRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lPointsRight.Location = new System.Drawing.Point(434, 43);
            this.lPointsRight.Name = "lPointsRight";
            this.lPointsRight.Size = new System.Drawing.Size(36, 37);
            this.lPointsRight.TabIndex = 6;
            this.lPointsRight.Text = "0";
            // 
            // lPointsLeft
            // 
            this.lPointsLeft.AutoSize = true;
            this.lPointsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPointsLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lPointsLeft.Location = new System.Drawing.Point(322, 43);
            this.lPointsLeft.Name = "lPointsLeft";
            this.lPointsLeft.Size = new System.Drawing.Size(36, 37);
            this.lPointsLeft.TabIndex = 6;
            this.lPointsLeft.Text = "0";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Segoe Print", 69.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Score.Location = new System.Drawing.Point(114, 111);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(560, 164);
            this.Score.TabIndex = 7;
            this.Score.Text = "CFAI Pong";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Score.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(329, 278);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 54);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Commencer";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lentToolStripMenuItem,
            this.moyenToolStripMenuItem,
            this.rapideToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Options";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.OptionToolStripMenuItem_Click);
            // 
            // lentToolStripMenuItem
            // 
            this.lentToolStripMenuItem.Name = "lentToolStripMenuItem";
            this.lentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lentToolStripMenuItem.Text = "Lent";
            this.lentToolStripMenuItem.Click += new System.EventHandler(this.LentToolStripMenuItem_Click);
            // 
            // moyenToolStripMenuItem
            // 
            this.moyenToolStripMenuItem.Name = "moyenToolStripMenuItem";
            this.moyenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moyenToolStripMenuItem.Text = "Moyen";
            this.moyenToolStripMenuItem.Click += new System.EventHandler(this.MoyenToolStripMenuItem_Click);
            // 
            // rapideToolStripMenuItem
            // 
            this.rapideToolStripMenuItem.Name = "rapideToolStripMenuItem";
            this.rapideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rapideToolStripMenuItem.Text = "Rapide";
            this.rapideToolStripMenuItem.Click += new System.EventHandler(this.RapideToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.lPointsLeft);
            this.Controls.Add(this.lPointsRight);
            this.Controls.Add(this.bola);
            this.Controls.Add(this.pongRight);
            this.Controls.Add(this.pongLeft);
            this.Controls.Add(this.MiddleBar);
            this.Controls.Add(this.RightWall);
            this.Controls.Add(this.LeftWall);
            this.Controls.Add(this.paredeBase);
            this.Controls.Add(this.paredeTopo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paredeTopo;
        private System.Windows.Forms.FlowLayoutPanel paredeBase;
        private System.Windows.Forms.Panel LeftWall;
        private System.Windows.Forms.Panel RightWall;
        private System.Windows.Forms.Panel MiddleBar;
        private System.Windows.Forms.Panel pongLeft;
        private System.Windows.Forms.Panel pongRight;
        private System.Windows.Forms.Panel bola;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lPointsRight;
        private System.Windows.Forms.Label lPointsLeft;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moyenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapideToolStripMenuItem;
    }
}

