using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallClassLibrary;

namespace BallGamesWindowsFormsApp
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

        private void stopBallButton_Click(object sender, EventArgs e)
        {
            stopBallButton.Enabled = false;
            restartButton.Enabled = true;

            foreach (var ball in moveBalls)
            {
                ball.Stop();
                if (ball.BallOnBoard())
                {
                    countBalls++;
                }
            }
            MessageBox.Show("Количество пойманных шаров: " + countBalls);
        }        

        private void drawRandomBallbutton_Click(object sender, EventArgs e)
        {
            stopBallButton.Enabled = true;            
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
    }
}