﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected List<RandomSizeAndPointBall> randomSizeAndPointBalls = new List<RandomSizeAndPointBall>();
        private int countBalls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void stopBallButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Количество пойманных шаров: " + countBalls);
        }        

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        

        private void timer_Tick(object sender, EventArgs e)
        {            
            for (int i = 0; i < 10; i++)
            {
                randomSizeAndPointBalls[i].Move();
            }            
        }

        private void drawRandomBallbutton_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < 10; i++)
            {
                var randomSizeAndPointBall = new RandomSizeAndPointBall(this);                
                randomSizeAndPointBalls.Add(randomSizeAndPointBall);
            }            
            timer.Start();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}