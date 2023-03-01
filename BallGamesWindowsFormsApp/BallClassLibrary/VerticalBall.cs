using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class VerticalBall : MoveBall
    {
        public VerticalBall(Form form, int centerX) : base(form)
        {
            this.centerX = centerX;
            centerY = DownSide();
            vx = 0;
            vy = -10;
        }

        public bool IsBallOnCenter()
        {            
            if (centerY < form.ClientSize.Height / 2)
            {
                return true;                               
            }
            return false;
        }
    }
}
