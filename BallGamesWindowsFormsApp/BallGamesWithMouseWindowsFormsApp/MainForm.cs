using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallClassLibrary;

namespace BallGamesWithMouseWindowsFormsApp
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

        private void MainForm_Load(object sender, EventArgs e)
        {            
            restartButton.Enabled = false;
            infoLabel.Visible = true;
        }

        private void drawRandomBallbutton_Click(object sender, EventArgs e)
        {            
            drawRandomBallbutton.Enabled = false;
            restartButton.Enabled = true;
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
                ball.Stop();
                ball.Clear();
            }
            Balls.Clear();
            countBalls = 0;
            countBallslabel.Text = countBalls.ToString();

            timer1.Stop();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {                                              
            if (Balls != null)
            {
                foreach (var ball in Balls)
                {
                    if (ball.IsMovable() && ball.BallOnBoard() && ball.Exists(e.X, e.Y))
                    {                        
                        ball.Stop();
                        
                        countBalls++;                        
                    }
                }
                countBallslabel.Text = countBalls.ToString();
            }            
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
            foreach (var ball in Balls)
            {
                if (!ball.IsMovable())
                {
                    ball.Show();
                }
            }

            if (EndOfGame())
            {
                timer1.Stop();
                MessageBox.Show("Конец игры. Количество пойманных шариков = " + countBalls.ToString());
            }
        }
    }
}