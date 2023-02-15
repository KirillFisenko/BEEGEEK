using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallClassLibrary;

namespace BallGamesWithMouseWindowsFormsApp
{    
    public partial class MainForm : Form
    {
        protected List<MoveBall> moveBalls;
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
            restartButton.Enabled = false;
            infoLabel.Visible = false;

            moveBalls = new List<MoveBall>();
            for (int i = 0; i < quantityBalls; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
            
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            drawRandomBallbutton.Enabled = true;
            infoLabel.Visible = true;

            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }
            moveBalls.Clear();
            countBalls = 0;
            countBallslabel.Text = countBalls.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {            
            restartButton.Enabled = true;                        
            if (moveBalls != null)
            {
                foreach (var ball in moveBalls)
                {
                    if (ball.IsMovable() && ball.BallOnBoard() && ball.ClickIsOnBall(e.X, e.Y))
                    {
                        ball.brush = Brushes.Black;
                        ball.Stop();
                        countBalls++;                        
                    }
                }
                countBallslabel.Text = countBalls.ToString();
            }
            if (EndOfGame())
            {
                MessageBox.Show("Конец игры. Количество пойманных шариков = " + countBalls.ToString());
            }
        }

        private bool EndOfGame()
        {            
            foreach (var ball in moveBalls)
            {
                if (ball.BallOnBoard())
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
    }
}