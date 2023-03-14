using BallClassLibrary;
using System;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected Bird bird;
        protected Pig pig;
        Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!bird.IsMovable() || !bird.BallOnBoard())
            {
                CreateNewBird();
            }

            if (bird.Intersect(pig))
            {
                CreateNewPig();
                CreateNewBird();
                label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            label2.Text = "0";
            CreateNewBird();
            CreateNewPig();            
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {            
            bird.SetVelocity(e.X, e.Y);
            timer.Start();          
            bird.Start();            
        }
             

        private void CreateNewBird()
        {
            timer.Stop();
            if (bird != null)
            {
                bird.Stop();
                bird.Clear();
            }
            bird = new Bird(this);
            bird.Show();
        }

        private void CreateNewPig()
        {            
            if (pig != null)
            {
                pig.Stop();
                pig.Clear();
            }
            pig = new Pig(this);
            pig.Show();
        }        
    }
}