using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Ball
    {
        protected Form form;
        protected int vx = 2;
        protected int vy = 2;
        public int x;
        public int y;
        public int size = 50;
        protected Brush brush = Brushes.Green;

        public Ball(Form form)
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
            var brush = new SolidBrush(form.BackColor);
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