using System.Drawing;

namespace BallGamesWindowsFormsApp
{
    public class Ball
    {
        private MainForm form;
        protected int x;
        protected int y;
        protected int size = 50;
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
            x += 10;
            y += 10;
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