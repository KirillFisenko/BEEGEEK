using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Ball
    {
        protected Form form;
        private Timer timer;

        protected int vx = 5;
        protected int vy = 5;

        public int centerX = 5;
        public int centerY = 5;
        public int radius = 10;

        public Brush brush = Brushes.Black;

        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
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

        public void Show()
        {            
            Draw(brush);
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;            
        }

        public void Clear()
        {
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool BallOnBoard()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }

        public bool Exists(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;
            return dx * dx + dy * dy <= radius * radius;
        }

        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}