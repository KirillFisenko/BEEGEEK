using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Bird : Ball
    {
        private float g = 0.2f;
        private float elastic = 0.5f;
        public Bird(Form form) : base(form)
        {
            radius = 40;
            centerX = LeftSide();
            centerY = DownSide();
            brush = Brushes.Blue;            
            g = 0.2f;
        }

        protected override void Go()
        {
            base.Go();
            
            if (centerY > DownSide())
            {
                vy = -vy;
                centerY = DownSide();
                vy = vy * elastic;
                vx = vx * elastic;
            }            
            if (vy < 0.1 && vx < 0.1)
            {
                Stop();
            }
            vy += g;
        }   
        
        public void SetVelocity(int x, int y)
        {
            vx = (x - centerX) / 30;
            vy = (y - centerY) / 30;
        }
    }    
}