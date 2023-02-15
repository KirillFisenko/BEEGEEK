using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Ball
    {
        protected Form form;
        protected int vx;
        protected int vy;
        public int x;
        public int y;
        public int size;
        protected Brush brush;

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

        public void Clear()
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
        public bool BallOnBoard()
        {
            return x >= 0 && x + size <= form.Size.Width && y >= 0 && y + size <= form.Size.Height;
        }
    }
}