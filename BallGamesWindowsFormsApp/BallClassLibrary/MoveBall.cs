using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BallClassLibrary
{
    public class MoveBall : RandomSizeAndPointBall
    {
        private Timer timer;

        public MoveBall(Form form) : base(form)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
    }
}