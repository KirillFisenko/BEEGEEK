using System.Drawing;
using BallGamesWindowsFormsApp;

namespace BallGamesWindowsFormsApp
{
    public class Ball
    {
        protected MainForm form;
        protected int vx = 2;
        protected int vy = 2;
        public int x;
        public int y;
        public int size = 50;
        protected Brush brush = Brushes.Green;

        public Ball(MainForm form)
        {
            this.form = form;
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();            
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        private void Go()
        {
            x += vx;
            y += vy;
        }

        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }
    }
}