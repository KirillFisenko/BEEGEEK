using BallClassLibrary;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public Random random = new Random();
        protected List<Ball> Balls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Balls = new List<Ball>();
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
                        ball.Stop();
                        ball.Clear();
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
        
    }
}
