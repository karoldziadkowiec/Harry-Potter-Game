namespace Harry_Potter_Game
{
    partial class ScoreWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreWindow));
            this.scoreDESCLabel = new System.Windows.Forms.Label();
            this.bestDESCLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreDESCLabel
            // 
            this.scoreDESCLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreDESCLabel.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.scoreDESCLabel.ForeColor = System.Drawing.Color.White;
            this.scoreDESCLabel.Location = new System.Drawing.Point(116, 50);
            this.scoreDESCLabel.Name = "scoreDESCLabel";
            this.scoreDESCLabel.Size = new System.Drawing.Size(150, 50);
            this.scoreDESCLabel.TabIndex = 4;
            this.scoreDESCLabel.Text = "SCORE:";
            this.scoreDESCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bestDESCLabel
            // 
            this.bestDESCLabel.BackColor = System.Drawing.Color.Transparent;
            this.bestDESCLabel.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.bestDESCLabel.ForeColor = System.Drawing.Color.Gold;
            this.bestDESCLabel.Location = new System.Drawing.Point(137, 115);
            this.bestDESCLabel.Name = "bestDESCLabel";
            this.bestDESCLabel.Size = new System.Drawing.Size(122, 50);
            this.bestDESCLabel.TabIndex = 5;
            this.bestDESCLabel.Text = "BEST:";
            this.bestDESCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Maroon;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Algerian", 22F);
            this.playButton.ForeColor = System.Drawing.Color.Gold;
            this.playButton.Location = new System.Drawing.Point(123, 208);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(183, 51);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.goToGameWindow);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Algerian", 22F);
            this.exitButton.ForeColor = System.Drawing.Color.Gold;
            this.exitButton.Location = new System.Drawing.Point(123, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(183, 51);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.goToStartWindow);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(257, 50);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(101, 50);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestLabel
            // 
            this.bestLabel.BackColor = System.Drawing.Color.Transparent;
            this.bestLabel.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.bestLabel.ForeColor = System.Drawing.Color.Gold;
            this.bestLabel.Location = new System.Drawing.Point(257, 115);
            this.bestLabel.Name = "bestLabel";
            this.bestLabel.Size = new System.Drawing.Size(101, 50);
            this.bestLabel.TabIndex = 9;
            this.bestLabel.Text = "0";
            this.bestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.ControlBox = false;
            this.Controls.Add(this.bestLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.bestDESCLabel);
            this.Controls.Add(this.scoreDESCLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScoreWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harry Potter Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label scoreDESCLabel;
        private System.Windows.Forms.Label bestDESCLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label bestLabel;
    }
}