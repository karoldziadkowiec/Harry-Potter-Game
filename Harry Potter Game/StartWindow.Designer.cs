namespace Harry_Potter_Game
{
    partial class StartWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.harryPotterGameLabel = new System.Windows.Forms.Label();
            this.pressSpaceToFlyLabel = new System.Windows.Forms.Label();
            this.spacePictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Maroon;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Gold;
            this.playButton.Location = new System.Drawing.Point(369, 359);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(337, 60);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.goToGameWindow);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Gold;
            this.exitButton.Location = new System.Drawing.Point(369, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(337, 60);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitApplication);
            // 
            // harryPotterGameLabel
            // 
            this.harryPotterGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.harryPotterGameLabel.Font = new System.Drawing.Font("Algerian", 55F, System.Drawing.FontStyle.Bold);
            this.harryPotterGameLabel.ForeColor = System.Drawing.Color.Gold;
            this.harryPotterGameLabel.Location = new System.Drawing.Point(56, 108);
            this.harryPotterGameLabel.Name = "harryPotterGameLabel";
            this.harryPotterGameLabel.Size = new System.Drawing.Size(962, 241);
            this.harryPotterGameLabel.TabIndex = 2;
            this.harryPotterGameLabel.Text = "Harry Potter Game";
            this.harryPotterGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pressSpaceToFlyLabel
            // 
            this.pressSpaceToFlyLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressSpaceToFlyLabel.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold);
            this.pressSpaceToFlyLabel.ForeColor = System.Drawing.Color.White;
            this.pressSpaceToFlyLabel.Location = new System.Drawing.Point(388, 518);
            this.pressSpaceToFlyLabel.Name = "pressSpaceToFlyLabel";
            this.pressSpaceToFlyLabel.Size = new System.Drawing.Size(297, 50);
            this.pressSpaceToFlyLabel.TabIndex = 3;
            this.pressSpaceToFlyLabel.Text = "press SPACE to fly";
            this.pressSpaceToFlyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spacePictureBox
            // 
            this.spacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("spacePictureBox.Image")));
            this.spacePictureBox.Location = new System.Drawing.Point(483, 571);
            this.spacePictureBox.Name = "spacePictureBox";
            this.spacePictureBox.Size = new System.Drawing.Size(111, 60);
            this.spacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spacePictureBox.TabIndex = 4;
            this.spacePictureBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(483, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(111, 102);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 5;
            this.logoPictureBox.TabStop = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.spacePictureBox);
            this.Controls.Add(this.pressSpaceToFlyLabel);
            this.Controls.Add(this.harryPotterGameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harry Potter Game";
            ((System.ComponentModel.ISupportInitialize)(this.spacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label harryPotterGameLabel;
        private System.Windows.Forms.Label pressSpaceToFlyLabel;
        private System.Windows.Forms.PictureBox spacePictureBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}

