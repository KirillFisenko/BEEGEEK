using BallClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public Random random = new Random();
        protected List<FruitBall> Balls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Balls = new List<FruitBall>();
            timer1.Start();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Balls != null)
            {
                foreach (var ball in Balls)
                {
                    if (ball.IsMovable() && ball.BallOnBoard() && ball.Exists(e.X, e.Y))
                    {
                        if (ball.brush == Brushes.Black)
                        {
                            timer1.Stop();                            
                            MessageBox.Show("Соприкосновение с бомбой, игра закончена");
                            Application.Restart();
                        }
                        if (ball.brush == Brushes.Yellow)
                        {                            
                            timer2.Start();
                            
                        }
                        ball.Stop();
                        ball.Clear();
                        label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var ball = new FruitBall(this);
            Balls.Add(ball);
            ball.Start();
            timer1.Interval = random.Next(100, 1400);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            foreach (var ball in Balls)
            {
                ball.timer.Interval = 100;
            }
            
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 5000;
                        
            foreach (var ball in Balls)
            {
                ball.timer.Interval = 20;
            }
            timer2.Stop();
            timer3.Stop();
        }
    }
}