using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class BillyardBall : MoveBall
    {
        public BillyardBall(Form form) : base(form)
        {

        }

        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftSide() || centerX >= RightSide())
            {
                vx = -vx;
            }
            if (centerY <= TopSide() || centerY >= DownSide())
            {
                vy = -vy;
            }
        }
    }
} 