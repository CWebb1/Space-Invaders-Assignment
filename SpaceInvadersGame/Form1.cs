namespace SpaceInvadersGame
{
    public partial class Form1 : Form
    {
        private Bitmap bufferImage;
        private Graphics bufferGraphics;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();

            Width = 800;
            Height = 600;

            bufferImage = new Bitmap(Width, Height);

            bufferGraphics = Graphics.FromImage(bufferImage);

            graphics = CreateGraphics();

            controller = new Controller(ClientSize, bufferGraphics);

            timer1.Enabled = true;
        }

        public void Draw()
        {
            //Add graphics.DrawImage(); with true functionality
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}