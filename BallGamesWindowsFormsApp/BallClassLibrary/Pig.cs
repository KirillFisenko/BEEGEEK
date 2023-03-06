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
        public Random random = new Random();
        public Pig(Form form) : base(form)
        {
            radius = 50;
            centerX = random.Next(Center(), RightSide());
            centerY = random.Next(TopSide(), Center());
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
    }
}
