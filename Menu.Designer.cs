namespace SpaceAIDS
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bttn_Play = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.bttn_Exit = new System.Windows.Forms.Button();
            this.pB_Red = new System.Windows.Forms.PictureBox();
            this.pB_Purple = new System.Windows.Forms.PictureBox();
            this.pB_Green = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Green)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Play
            // 
            this.bttn_Play.BackColor = System.Drawing.Color.LemonChiffon;
            this.bttn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Play.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Play.Location = new System.Drawing.Point(225, 209);
            this.bttn_Play.Name = "bttn_Play";
            this.bttn_Play.Size = new System.Drawing.Size(211, 46);
            this.bttn_Play.TabIndex = 0;
            this.bttn_Play.Text = "PLAY";
            this.bttn_Play.UseVisualStyleBackColor = false;
            this.bttn_Play.Click += new System.EventHandler(this.bttn_Play_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Engravers MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Yellow;
            this.label.Location = new System.Drawing.Point(122, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(409, 93);
            this.label.TabIndex = 2;
            this.label.Text = "Cosmic Invaders";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttn_Exit
            // 
            this.bttn_Exit.BackColor = System.Drawing.Color.LemonChiffon;
            this.bttn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Exit.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Exit.Location = new System.Drawing.Point(225, 271);
            this.bttn_Exit.Name = "bttn_Exit";
            this.bttn_Exit.Size = new System.Drawing.Size(211, 46);
            this.bttn_Exit.TabIndex = 3;
            this.bttn_Exit.Text = "EXIT";
            this.bttn_Exit.UseVisualStyleBackColor = false;
            this.bttn_Exit.Click += new System.EventHandler(this.bttn_Exit_Click);
            // 
            // pB_Red
            // 
            this.pB_Red.BackColor = System.Drawing.Color.Transparent;
            this.pB_Red.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pB_Red.BackgroundImage")));
            this.pB_Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_Red.Location = new System.Drawing.Point(291, 358);
            this.pB_Red.Name = "pB_Red";
            this.pB_Red.Size = new System.Drawing.Size(86, 81);
            this.pB_Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Red.TabIndex = 4;
            this.pB_Red.TabStop = false;
            // 
            // pB_Purple
            // 
            this.pB_Purple.BackColor = System.Drawing.Color.Transparent;
            this.pB_Purple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pB_Purple.BackgroundImage")));
            this.pB_Purple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_Purple.Location = new System.Drawing.Point(163, 358);
            this.pB_Purple.Name = "pB_Purple";
            this.pB_Purple.Size = new System.Drawing.Size(86, 81);
            this.pB_Purple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Purple.TabIndex = 4;
            this.pB_Purple.TabStop = false;
            // 
            // pB_Green
            // 
            this.pB_Green.BackColor = System.Drawing.Color.Transparent;
            this.pB_Green.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pB_Green.BackgroundImage")));
            this.pB_Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_Green.Location = new System.Drawing.Point(419, 358);
            this.pB_Green.Name = "pB_Green";
            this.pB_Green.Size = new System.Drawing.Size(86, 81);
            this.pB_Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Green.TabIndex = 5;
            this.pB_Green.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 451);
            this.Controls.Add(this.pB_Green);
            this.Controls.Add(this.pB_Purple);
            this.Controls.Add(this.pB_Red);
            this.Controls.Add(this.bttn_Exit);
            this.Controls.Add(this.label);
            this.Controls.Add(this.bttn_Play);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cosmic Invaders";
            ((System.ComponentModel.ISupportInitialize)(this.pB_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Green)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_Play;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button bttn_Exit;
        private System.Windows.Forms.PictureBox pB_Red;
        private System.Windows.Forms.PictureBox pB_Purple;
        private System.Windows.Forms.PictureBox pB_Green;
    }
}

