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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            Width = 800;
            Height = 600;

            pictureBox1.MaximumSize = pictureBox1.Image.Size;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            ControlBox = false;
        }

        public virtual System.Drawing.Image? backImage { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();

            gameScreen.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor =  Color.White;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlsScreen controlscreen = new ControlsScreen();

            controlscreen.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
    }
}
