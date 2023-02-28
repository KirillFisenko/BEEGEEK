using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BallClassLibrary
{
    public class MoveBall : RandomSizeAndPointBall
    {
        public MoveBall(Form form) : base(form)
        {
            vx = (float)random.NextDouble() * 10 - 5;
            vy = (float)random.NextDouble() * 10 - 5;
        }
    }
}