using System;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class VerticalBall : MoveBall
    {
        public VerticalBall(Form form, int centerX) : base(form)
        {
            radius = 24;
            this.centerX = centerX;
            centerY = DownSide();
            vx = 0;
            vy = -10;
        }

        public bool IsBallOnCenter()
        {
            var random = new Random();
            if (centerY < random.Next(form.ClientSize.Height / 3, form.ClientSize.Height / 2))
            {
                return true;
            }
            return false;
        }
    }
}
