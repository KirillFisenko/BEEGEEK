using BallClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected Bird bird;
        protected Pig pig;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pig = new Pig(this);
            pig.Start();

            bird = new Bird(this);
            timer1.Start();

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Start();
            var X = e.X;
            var Y = e.Y;

            bird.vx = X / 50;
            bird.vy = (Y - bird.DownSide()) / 30;

            timer1.Stop();
            bird.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pig.Exists(bird.centerX, bird.centerY))
            {

                pig.Stop();
                pig.Clear();
                label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
                timer2.Stop();
            }
        }
    }
}
