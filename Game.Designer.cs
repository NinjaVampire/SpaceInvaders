namespace SpaceAIDS
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pB_Player = new System.Windows.Forms.PictureBox();
            this.pB_Health1 = new System.Windows.Forms.PictureBox();
            this.pB_Health2 = new System.Windows.Forms.PictureBox();
            this.pB_Health3 = new System.Windows.Forms.PictureBox();
            this.label_Score = new System.Windows.Forms.Label();
            this.pB_Enemy1 = new System.Windows.Forms.PictureBox();
            this.pB_Asteroid1 = new System.Windows.Forms.PictureBox();
            this.pB_Buff = new System.Windows.Forms.PictureBox();
            this.pB_Asteroid2 = new System.Windows.Forms.PictureBox();
            this.pB_Asteroid3 = new System.Windows.Forms.PictureBox();
            this.timer_Game = new System.Windows.Forms.Timer(this.components);
            this.pB_Bullet = new System.Windows.Forms.PictureBox();
            this.pB_Enemy2 = new System.Windows.Forms.PictureBox();
            this.pB_Enemy3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Health2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Health3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Asteroid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Buff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Asteroid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Asteroid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Enemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_Player
            // 
            this.pB_Player.BackColor = System.Drawing.Color.Transparent;
            this.pB_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_Player.Image = global::SpaceAIDS.Properties.Resources.ship2;
            this.pB_Player.Location = new System.Drawing.Point(256, 479);
            this.pB_Player.Name = "pB_Player";
            this.pB_Player.Size = new System.Drawing.Size(62, 81);
            this.pB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Player.TabIndex = 0;
            this.pB_Player.TabStop = false;
            // 
            // pB_Health1
            // 
            this.pB_Health1.BackColor = System.Drawing.Color.Transparent;
            this.pB_Health1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Health1.Image = global::SpaceAIDS.Properties.Resources.fullHeart;
            this.pB_Health1.Location = new System.Drawing.Point(12, 517);
            this.pB_Health1.Name = "pB_Health1";
            this.pB_Health1.Size = new System.Drawing.Size(26, 25);
            this.pB_Health1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Health1.TabIndex = 1;
            this.pB_Health1.TabStop = false;
            // 
            // pB_Health2
            // 
            this.pB_Health2.BackColor = System.Drawing.Color.Transparent;
            this.pB_Health2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Health2.Image = global::SpaceAIDS.Properties.Resources.fullHeart;
            this.pB_Health2.Location = new System.Drawing.Point(12, 548);
            this.pB_Health2.Name = "pB_Health2";
            this.pB_Health2.Size = new System.Drawing.Size(26, 25);
            this.pB_Health2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Health2.TabIndex = 2;
            this.pB_Health2.TabStop = false;
            // 
            // pB_Health3
            // 
            this.pB_Health3.BackColor = System.Drawing.Color.Transparent;
            this.pB_Health3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Health3.Image = global::SpaceAIDS.Properties.Resources.fullHeart;
            this.pB_Health3.Location = new System.Drawing.Point(12, 579);
            this.pB_Health3.Name = "pB_Health3";
            this.pB_Health3.Size = new System.Drawing.Size(26, 25);
            this.pB_Health3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Health3.TabIndex = 3;
            this.pB_Health3.TabStop = false;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.ForeColor = System.Drawing.Color.White;
            this.label_Score.Location = new System.Drawing.Point(9, 9);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(97, 19);
            this.label_Score.TabIndex = 4;
            this.label_Score.Text = "SCORE: ";
            // 
            // pB_Enemy1
            // 
            this.pB_Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.pB_Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Enemy1.Image = global::SpaceAIDS.Properties.Resources.enemy_Purple;
            this.pB_Enemy1.Location = new System.Drawing.Point(378, 60);
            this.pB_Enemy1.Name = "pB_Enemy1";
            this.pB_Enemy1.Size = new System.Drawing.Size(88, 62);
            this.pB_Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Enemy1.TabIndex = 5;
            this.pB_Enemy1.TabStop = false;
            // 
            // pB_Asteroid1
            // 
            this.pB_Asteroid1.BackColor = System.Drawing.Color.Transparent;
            this.pB_Asteroid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Asteroid1.Image = global::SpaceAIDS.Properties.Resources.asteroid1;
            this.pB_Asteroid1.Location = new System.Drawing.Point(396, 208);
            this.pB_Asteroid1.Name = "pB_Asteroid1";
            this.pB_Asteroid1.Size = new System.Drawing.Size(58, 50);
            this.pB_Asteroid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Asteroid1.TabIndex = 7;
            this.pB_Asteroid1.TabStop = false;
            // 
            // pB_Buff
            // 
            this.pB_Buff.BackColor = System.Drawing.Color.Transparent;
            this.pB_Buff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Buff.Image = global::SpaceAIDS.Properties.Resources.buff;
            this.pB_Buff.Location = new System.Drawing.Point(256, -2);
            this.pB_Buff.Name = "pB_Buff";
            this.pB_Buff.Size = new System.Drawing.Size(44, 46);
            this.pB_Buff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Buff.TabIndex = 9;
            this.pB_Buff.TabStop = false;
            // 
            // pB_Asteroid2
            // 
            this.pB_Asteroid2.BackColor = System.Drawing.Color.Transparent;
            this.pB_Asteroid2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Asteroid2.Image = global::SpaceAIDS.Properties.Resources.asteroid2;
            this.pB_Asteroid2.Location = new System.Drawing.Point(67, 145);
            this.pB_Asteroid2.Name = "pB_Asteroid2";
            this.pB_Asteroid2.Size = new System.Drawing.Size(62, 50);
            this.pB_Asteroid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Asteroid2.TabIndex = 10;
            this.pB_Asteroid2.TabStop = false;
            // 
            // pB_Asteroid3
            // 
            this.pB_Asteroid3.BackColor = System.Drawing.Color.Transparent;
            this.pB_Asteroid3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Asteroid3.Image = global::SpaceAIDS.Properties.Resources.asteroid3;
            this.pB_Asteroid3.Location = new System.Drawing.Point(256, 156);
            this.pB_Asteroid3.Name = "pB_Asteroid3";
            this.pB_Asteroid3.Size = new System.Drawing.Size(62, 50);
            this.pB_Asteroid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Asteroid3.TabIndex = 11;
            this.pB_Asteroid3.TabStop = false;
            // 
            // timer_Game
            // 
            this.timer_Game.Interval = 10;
            this.timer_Game.Tick += new System.EventHandler(this.timer_Game_Tick);
            // 
            // pB_Bullet
            // 
            this.pB_Bullet.BackColor = System.Drawing.Color.Transparent;
            this.pB_Bullet.BackgroundImage = global::SpaceAIDS.Properties.Resources.bullet1;
            this.pB_Bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Bullet.Location = new System.Drawing.Point(272, 433);
            this.pB_Bullet.Name = "pB_Bullet";
            this.pB_Bullet.Size = new System.Drawing.Size(30, 40);
            this.pB_Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Bullet.TabIndex = 13;
            this.pB_Bullet.TabStop = false;
            // 
            // pB_Enemy2
            // 
            this.pB_Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.pB_Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Enemy2.Image = global::SpaceAIDS.Properties.Resources.enemy_Green;
            this.pB_Enemy2.Location = new System.Drawing.Point(67, 60);
            this.pB_Enemy2.Name = "pB_Enemy2";
            this.pB_Enemy2.Size = new System.Drawing.Size(62, 50);
            this.pB_Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Enemy2.TabIndex = 6;
            this.pB_Enemy2.TabStop = false;
            // 
            // pB_Enemy3
            // 
            this.pB_Enemy3.BackColor = System.Drawing.Color.Transparent;
            this.pB_Enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Enemy3.Image = global::SpaceAIDS.Properties.Resources.enemy_Red;
            this.pB_Enemy3.Location = new System.Drawing.Point(169, 189);
            this.pB_Enemy3.Name = "pB_Enemy3";
            this.pB_Enemy3.Size = new System.Drawing.Size(62, 50);
            this.pB_Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Enemy3.TabIndex = 8;
            this.pB_Enemy3.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 613);
            this.Controls.Add(this.pB_Health3);
            this.Controls.Add(this.pB_Health2);
            this.Controls.Add(this.pB_Health1);
            this.Controls.Add(this.pB_Player);
            this.Controls.Add(this.pB_Bullet);
            this.Controls.Add(this.pB_Asteroid3);
            this.Controls.Add(this.pB_Asteroid2);
            this.Controls.Add(this.pB_Buff);
            this.Controls.Add(this.pB_Enemy3);
            this.Controls.Add(this.pB_Asteroid1);
            this.Controls.Add(this.pB_Enemy2);
            this.Controls.Add(this.pB_Enemy1);
            this.Controls.Add(this.label_Score);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cosmic Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Health2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Health3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Asteroid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Buff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Asteroid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Asteroid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Enemy3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_Player;
        private System.Windows.Forms.PictureBox pB_Health1;
        private System.Windows.Forms.PictureBox pB_Health2;
        private System.Windows.Forms.PictureBox pB_Health3;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.PictureBox pB_Enemy1;
        private System.Windows.Forms.PictureBox pB_Asteroid1;
        private System.Windows.Forms.PictureBox pB_Buff;
        private System.Windows.Forms.PictureBox pB_Asteroid2;
        private System.Windows.Forms.PictureBox pB_Asteroid3;
        private System.Windows.Forms.Timer timer_Game;
        private System.Windows.Forms.PictureBox pB_Bullet;
        private System.Windows.Forms.PictureBox pB_Enemy2;
        private System.Windows.Forms.PictureBox pB_Enemy3;
    }
}