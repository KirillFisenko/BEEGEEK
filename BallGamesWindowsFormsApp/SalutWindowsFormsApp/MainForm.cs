using BallClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public VerticalBall verticalBall;
        public Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var x = e.X;
            verticalBall = new VerticalBall(this, x);
            verticalBall.Start();
            timer1.Start();
        }

        private void MakeSalut(int count, float x, float y)
        {
            for (var i = 0; i < count; i++)
            {
                var salut = new SalutBall(this, x, y);
                salut.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var count = random.Next(5, 20);
            if (verticalBall.IsBallOnCenter())
            {
                verticalBall.Stop();
                verticalBall.Clear();
                MakeSalut(count, verticalBall.centerX, verticalBall.centerY);
                timer1.Stop();
            }
        }
    }
}
