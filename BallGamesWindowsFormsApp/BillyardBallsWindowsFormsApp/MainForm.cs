using BallClassLibrary;
using System;
using System.Windows.Forms;

namespace BillyardBallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int quantityBalls = 10;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < quantityBalls; i++)
            {
                Ball ball = new BillyardBall(this);
                ball.Start();
            }                 
        }
    }
}
