using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Bird : FruitBall
    {        
        public Bird(Form form) : base(form)
        {
            radius = 40;
            centerX = LeftSide() + radius;
            centerY = DownSide() - radius;
            brush = Brushes.Blue;
            
            g = 0.2f;
        }

        protected override void Go()
        {
            base.Go();
            if (centerY > DownSide())
            {
                vy = -vy;
                if (vy < 0 && g < 0.8f)
                {
                    g = g + 0.2f;
                }               

            }
        }

        
    }    
}
