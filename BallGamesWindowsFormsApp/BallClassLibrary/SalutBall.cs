using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class SalutBall : MoveBall
    {
        private float g = 0.15f;
        public SalutBall(Form form, float centerX, float centerY) : base(form)
        {
            radius = 12;
            this.centerX = centerX;
            this.centerY = centerY;
            vy = -Math.Abs(vy);
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
