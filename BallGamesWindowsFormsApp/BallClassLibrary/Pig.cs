using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Pig : Ball
    {
        public static Random random = new Random();
        public Pig(Form form) : base(form)
        {
            radius = 50;
            centerX = random.Next(Center() - 4*radius, RightSide() - 4*radius);
            centerY = random.Next(TopSide() + 2*radius, 2*radius + form.ClientSize.Height / 2);
            brush = Brushes.Pink;                       
        }             
    }
}