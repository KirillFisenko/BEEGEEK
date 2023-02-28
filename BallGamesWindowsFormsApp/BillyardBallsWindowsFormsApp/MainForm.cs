using BallClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BillyardBallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected int quantityBalls = 20;
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
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();

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
                case Side.LeftRed:
                    leftRedLabel.Text = (Convert.ToInt32(leftRedLabel.Text) + 1).ToString();
                    break;
                case Side.RightRed:
                    rightRedLabel.Text = (Convert.ToInt32(rightRedLabel.Text) + 1).ToString();
                    break;
                case Side.TopRed:
                    topRedLabel.Text = (Convert.ToInt32(topRedLabel.Text) + 1).ToString();
                    break;
                case Side.DownRed:
                    downRedLabel.Text = (Convert.ToInt32(downRedLabel.Text) + 1).ToString();
                    break;

                case Side.LeftBlue:
                    leftBlueLabel.Text = (Convert.ToInt32(leftBlueLabel.Text) + 1).ToString();
                    break;
                case Side.RightBlue:
                    rightBlueLabel.Text = (Convert.ToInt32(rightBlueLabel.Text) + 1).ToString();
                    break;
                case Side.TopBlue:
                    topBlueLabel.Text = (Convert.ToInt32(topBlueLabel.Text) + 1).ToString();
                    break;
                case Side.DownBlue:
                    downBlueLabel.Text = (Convert.ToInt32(downBlueLabel.Text) + 1).ToString();
                    break;
            }
        }
        
        private bool EndOfMixBalls()
        {
            var blueBallsLeftCount = 0;
            var blueBallsRightCount = 0;
            var redBallsLeftCount = 0;
            var redBallsRightCount = 0;

            foreach (var ball in Balls)
            {
                if (ball.centerX < ball.Center())
                {
                    if (ball.brush == Brushes.Blue)
                    {
                        blueBallsLeftCount++;
                    }
                    if (ball.brush == Brushes.Red)
                    {
                        redBallsLeftCount++;
                    }
                }
                if (ball.centerX > ball.Center())
                {
                    if (ball.brush == Brushes.Blue)
                    {
                        blueBallsRightCount++;
                    }
                    if (ball.brush == Brushes.Red)
                    {
                        redBallsRightCount++;
                    }
                }
            }
            if(blueBallsLeftCount == redBallsLeftCount && blueBallsRightCount == redBallsRightCount
                && blueBallsLeftCount == blueBallsRightCount && redBallsLeftCount == redBallsRightCount)
            {
                return true;
            }
            return false;            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (EndOfMixBalls())
            {
                timer1.Stop();
                foreach (var ball in Balls)
                {                    
                    ball.Stop();
                }                
            }
        }        
    }
}