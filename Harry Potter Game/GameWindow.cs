using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harry_Potter_Game
{
    public partial class GameWindow : Form
    {
        int buildingSpeed = 8;
        int cloudSpeed = 8;
        int gravity = 10 ;
        int score = 0;
        int bestScore = 0;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            harryPotter.Top += gravity;
            cloud.Left -= cloudSpeed;
            building.Left -= buildingSpeed;
            scoreLabel.Text = score.ToString();

            isTimeToEndGame();
            saveScore();
            checkTheBestScore();

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -6;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 6 ;
            }
        }

        private void isTimeToEndGame()
        {
            if (harryPotter.Bounds.IntersectsWith(cloud.Bounds) || harryPotter.Bounds.IntersectsWith(building.Bounds) || harryPotter.Bounds.IntersectsWith(grass.Bounds) || harryPotter.Top < -10)
            {
                gameTimer.Stop();
            }
        }

        private void saveScore()
        {
            if (cloud.Left < -100)
            {
                cloud.Left = 830;
                score++;
            }
            else if (building.Left < -100)
            {
                building.Left = 900;
                score++;
                increaseObstaclesSpeed();
            }
        }

        private void increaseObstaclesSpeed()
        {
            buildingSpeed++;
            cloudSpeed++;
        }

        private void checkTheBestScore()
        {
            if (score > bestScore) 
            {
                bestScore = score;
                bestLabel.Text = bestScore.ToString();
            }
        }
    }
}
