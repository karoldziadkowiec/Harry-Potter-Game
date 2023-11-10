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
        Player _player = null;
        int buildingSpeed = 8;
        int cloudSpeed = 8;
        int gravity = 10 ;

        public GameWindow(Player player)
        {
            _player = player;
            InitializeComponent();

            displayPlayerScores();
        }

        private void displayPlayerScores()
        {
            scoreLabel.Text = _player.myScore.ToString();
            bestLabel.Text = _player.bestScore.ToString();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            harryPotter.Top += gravity;
            cloud.Left -= cloudSpeed;
            building.Left -= buildingSpeed;
            scoreLabel.Text = _player.myScore.ToString();

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
                ScoreWindow scoreWindow = new ScoreWindow(_player);
                scoreWindow.Show();
                //this.Hide();
            }
        }

        private void saveScore()
        {
            if (cloud.Left < -100)
            {
                cloud.Left = 830;
                _player.myScore++;
            }
            else if (building.Left < -100)
            {
                building.Left = 900;
                _player.myScore++;
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
            if (_player.myScore > _player.bestScore) 
            {
                _player.bestScore = _player.myScore;
                bestLabel.Text = _player.bestScore.ToString();
            }
        }
    }
}
