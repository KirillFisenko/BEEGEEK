using BallClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BillyardBallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected int quantityBalls = 10;
        protected List<BillyardBall> Balls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Balls = new List<BillyardBall>();
            for (int i = 0; i < quantityBalls; i++)
            {
                var ball = new BillyardBall(this);
                if (i % 2 == 0)
                {
                    ball.ChooseSide("left");
                }
                else
                {
                    ball.ChooseSide("right");
                }
                Balls.Add(ball);                
            }
            foreach (var ball in Balls)
            {                
                ball.Show(); //должны показаться, но не двигаться
            }
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var ball in Balls)
            {                
                ball.OnHited += Ball_OnHited;
                ball.Start();
            }
        }
        private void Ball_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftRedLabel.Text = (Convert.ToInt32(leftRedLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightRedLabel.Text = (Convert.ToInt32(rightRedLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topBlueLabel.Text = (Convert.ToInt32(topBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downBlueLabel.Text = (Convert.ToInt32(downBlueLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}