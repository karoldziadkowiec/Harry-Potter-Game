namespace Harry_Potter_Game
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.grass = new System.Windows.Forms.PictureBox();
            this.building = new System.Windows.Forms.PictureBox();
            this.cloud = new System.Windows.Forms.PictureBox();
            this.harryPotter = new System.Windows.Forms.PictureBox();
            this.scoreDESCLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bestLabel = new System.Windows.Forms.Label();
            this.bestDESCLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harryPotter)).BeginInit();
            this.SuspendLayout();
            // 
            // grass
            // 
            this.grass.Image = ((System.Drawing.Image)(resources.GetObject("grass.Image")));
            this.grass.Location = new System.Drawing.Point(-2, 560);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(1086, 95);
            this.grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.grass.TabIndex = 0;
            this.grass.TabStop = false;
            // 
            // building
            // 
            this.building.Image = ((System.Drawing.Image)(resources.GetObject("building.Image")));
            this.building.Location = new System.Drawing.Point(651, 308);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(85, 253);
            this.building.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building.TabIndex = 1;
            this.building.TabStop = false;
            // 
            // cloud
            // 
            this.cloud.Image = ((System.Drawing.Image)(resources.GetObject("cloud.Image")));
            this.cloud.Location = new System.Drawing.Point(611, 0);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(162, 111);
            this.cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud.TabIndex = 2;
            this.cloud.TabStop = false;
            // 
            // harryPotter
            // 
            this.harryPotter.BackColor = System.Drawing.Color.Transparent;
            this.harryPotter.Image = ((System.Drawing.Image)(resources.GetObject("harryPotter.Image")));
            this.harryPotter.Location = new System.Drawing.Point(175, 183);
            this.harryPotter.Name = "harryPotter";
            this.harryPotter.Size = new System.Drawing.Size(145, 109);
            this.harryPotter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.harryPotter.TabIndex = 3;
            this.harryPotter.TabStop = false;
            // 
            // scoreDESCLabel
            // 
            this.scoreDESCLabel.BackColor = System.Drawing.Color.Maroon;
            this.scoreDESCLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreDESCLabel.ForeColor = System.Drawing.Color.White;
            this.scoreDESCLabel.Location = new System.Drawing.Point(416, 587);
            this.scoreDESCLabel.Name = "scoreDESCLabel";
            this.scoreDESCLabel.Size = new System.Drawing.Size(168, 39);
            this.scoreDESCLabel.TabIndex = 4;
            this.scoreDESCLabel.Text = "SCORE:";
            this.scoreDESCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Maroon;
            this.scoreLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(580, 587);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(81, 39);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestLabel
            // 
            this.bestLabel.BackColor = System.Drawing.Color.Maroon;
            this.bestLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestLabel.ForeColor = System.Drawing.Color.Gold;
            this.bestLabel.Location = new System.Drawing.Point(964, 587);
            this.bestLabel.Name = "bestLabel";
            this.bestLabel.Size = new System.Drawing.Size(81, 39);
            this.bestLabel.TabIndex = 7;
            this.bestLabel.Text = "0";
            this.bestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestDESCLabel
            // 
            this.bestDESCLabel.BackColor = System.Drawing.Color.Maroon;
            this.bestDESCLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestDESCLabel.ForeColor = System.Drawing.Color.Gold;
            this.bestDESCLabel.Location = new System.Drawing.Point(828, 587);
            this.bestDESCLabel.Name = "bestDESCLabel";
            this.bestDESCLabel.Size = new System.Drawing.Size(140, 39);
            this.bestDESCLabel.TabIndex = 6;
            this.bestDESCLabel.Text = "BEST:";
            this.bestDESCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.bestLabel);
            this.Controls.Add(this.bestDESCLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreDESCLabel);
            this.Controls.Add(this.harryPotter);
            this.Controls.Add(this.cloud);
            this.Controls.Add(this.building);
            this.Controls.Add(this.grass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harry Potter Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harryPotter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox grass;
        private System.Windows.Forms.PictureBox building;
        private System.Windows.Forms.PictureBox cloud;
        private System.Windows.Forms.PictureBox harryPotter;
        private System.Windows.Forms.Label scoreDESCLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label bestLabel;
        private System.Windows.Forms.Label bestDESCLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}