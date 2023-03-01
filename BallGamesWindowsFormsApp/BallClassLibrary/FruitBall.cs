using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class FruitBall : RandomSizeAndPointBall
    {
        private float g = 0.2f;
        public FruitBall(Form form) : base(form)
        {
            radius = random.Next(30, 60);
            centerY = DownSide() + 100;
            centerX = random.Next(Center() - Center() / 2, Center() + Center() / 2);
            vx = (float)random.NextDouble() * 6 - 3;
            vy = random.Next(-16, -9);
        }              
        
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
