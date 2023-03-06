using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

            this.form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Show();
        }

        public bool Exists(float pointX, float pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;
            return dx * dx + dy * dy <= radius * radius;
        }
    }
}
