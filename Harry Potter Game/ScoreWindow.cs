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
    public partial class ScoreWindow : Form
    {
        Player _player = null;
        public ScoreWindow(Player player)
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

        private void resetMyScore()
        {
            int bestScore = _player.bestScore;
            _player = new Player(bestScore);
        }

        private void goToGameWindow(object sender, EventArgs e)
        {
            resetMyScore();

            GameWindow gameWindow = new GameWindow(_player);
            gameWindow.Show();
            this.Close();
        }

        private void goToStartWindow(object sender, EventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
            this.Hide();
        }
    }
}
