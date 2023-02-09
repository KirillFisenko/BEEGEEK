using System;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        RandomSizeAndPointBall randomSizeAndPointBall;
        PointBall pointBall;
        public MainForm()
        {
            InitializeComponent();
        }

        private void moveBallButton_Click(object sender, EventArgs e)
        {
            randomSizeAndPointBall.Move();            
        }

        private void drawRandomBallbutton_Click(object sender, EventArgs e)
        {
            randomSizeAndPointBall = new RandomSizeAndPointBall(this);
            randomSizeAndPointBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void moveBallbutton2_Click(object sender, EventArgs e)
        {
            pointBall.Move();            
        }
    }
}
