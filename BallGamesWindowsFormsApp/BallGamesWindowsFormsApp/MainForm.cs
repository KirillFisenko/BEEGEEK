using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallClassLibrary;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected List<Ball> Balls;
        private int countBalls;
        private int quantityBalls = 15;

        public MainForm()
        {
            InitializeComponent();
        }

        private void stopBallButton_Click(object sender, EventArgs e)
        {
            stopBallButton.Enabled = false;
            restartButton.Enabled = true;

            foreach (var ball in Balls)
            {
                ball.Stop();
                if (ball.BallOnBoard())
                {
                    countBalls++;
                }
            }            
        }        

        private void drawRandomBallbutton_Click(object sender, EventArgs e)
        {
            stopBallButton.Enabled = true;            
            drawRandomBallbutton.Enabled = false;
            restartButton.Enabled = false;
            infoLabel.Visible = false;

            timer1.Start();

            Balls = new List<Ball>();
            for (int i = 0; i < quantityBalls; i++)
            {
                var moveBall = new MoveBall(this);
                Balls.Add(moveBall);
                moveBall.Start();               
            }            
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            drawRandomBallbutton.Enabled = true;
            infoLabel.Visible = true;

            foreach (var ball in Balls)
            {
                ball.Clear();                
            }
            Balls.Clear();
            countBalls = 0;
            timer1.Stop();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopBallButton.Enabled = false;
            restartButton.Enabled = false;
            infoLabel.Visible = true;
        }

        private bool EndOfGame()
        {
            foreach (var ball in Balls)
            {
                if (ball.BallOnBoard() && ball.IsMovable())
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (EndOfGame())
            {
                timer1.Stop();
                restartButton.Enabled = true;
                stopBallButton.Enabled = false;
                MessageBox.Show("Конец игры. Количество пойманных шариков = " + countBalls.ToString());                
            }
        }
    }
}