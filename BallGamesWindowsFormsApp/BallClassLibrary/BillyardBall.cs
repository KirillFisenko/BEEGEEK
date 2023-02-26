using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class BillyardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BillyardBall(Form form) : base(form)
        {
            radius = 30;            
        }

        public void ChooseSide(string side)
        {
            if (side == "left")
            {
                centerX = random.Next(LeftSide(), form.ClientSize.Width / 2 - radius);
                brush = Brushes.Blue;                
            }
            if (side == "right")
            {
                centerX = random.Next(form.ClientSize.Width / 2 + radius, RightSide());
                brush = Brushes.Red;                
            }            
        }

        public override void Show()
        {
            base.Show();
            DrawLine();
        }
        protected override void Go()
        {      
            base.Go();

            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }                

        public void DrawLine()
        {
            var graphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            int x1 = form.ClientSize.Width / 2;
            int y1 = 0;
            int x2 = form.ClientSize.Width / 2;
            int y2 = form.ClientSize.Height;
            graphics.DrawLine(blackPen, x1, y1, x2, y2);
        }
    }
} 