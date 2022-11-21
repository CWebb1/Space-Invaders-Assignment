using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpaceInvadersGameProject
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

            //
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    //controller.MotherShipMoveLeft();
                    break;
                case Keys.D:
                    //controller.MotherShipMoveLeft();
                    break;
                case Keys.Escape:
                    //controller.PauseGame();
                    break;
            }
        }
    }
}
