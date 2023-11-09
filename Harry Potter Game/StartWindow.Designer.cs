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
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(437, 359);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(166, 60);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.goToGameWindow);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(437, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 60);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitApplication);
            // 
            // harryPotterGameLabel
            // 
            this.harryPotterGameLabel.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harryPotterGameLabel.Location = new System.Drawing.Point(100, 80);
            this.harryPotterGameLabel.Name = "harryPotterGameLabel";
            this.harryPotterGameLabel.Size = new System.Drawing.Size(947, 82);
            this.harryPotterGameLabel.TabIndex = 2;
            this.harryPotterGameLabel.Text = "Harry Potter Game";
            this.harryPotterGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.harryPotterGameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harry Potter Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label harryPotterGameLabel;
    }
}

