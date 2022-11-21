using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersGameProject
{
    public partial class ControlsScreen : Form
    {
        public ControlsScreen()
        {
            InitializeComponent();

            ControlBox = false;

            pictureBox1.MaximumSize = pictureBox1.Image.Size;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ControlsScreen_Load(object sender, EventArgs e)
        {

        }

        private void ControlsBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ControlsBackButton_MouseHover(object sender, EventArgs e)
        {
            ControlsBackButton.BackColor = Color.Yellow;
            ControlsBackButton.ForeColor = Color.Black;
        }

        private void ControlsBackButton_MouseLeave(object sender, EventArgs e)
        {
            ControlsBackButton.BackColor = Color.White;
        }
    }
}
