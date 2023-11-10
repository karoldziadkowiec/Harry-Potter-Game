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
    public partial class StartWindow : Form
    {
        Player _player = new Player();
        public StartWindow()
        {
            InitializeComponent();
        }

        private void goToGameWindow(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow(_player);
            gameWindow.Show();
            this.Hide();
        }

        private void exitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
