using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class RandomSizeAndPointBall : Ball
    {
        protected static Random random = new Random();
        protected List<int> vxRandom;
        protected List<int> vyRandom;
        protected List<Brush> colors = new List<Brush>()
        { Brushes.Brown,
          Brushes.Violet,
          Brushes.Green,
          Brushes.Blue,
          Brushes.Red,
          Brushes.Yellow,
          Brushes.Olive,
          Brushes.Pink,
          Brushes.Tomato,
          Brushes.Goldenrod };

        public RandomSizeAndPointBall(Form form) : base(form)
        {
            x = random.Next(70, form.Size.Width / 2);
            y = random.Next(70, form.Size.Height / 2);
            vxRandom = new List<int>() { random.Next(-2, -1), random.Next(1, 2) };
            vyRandom = new List<int>() { random.Next(-2, -1), random.Next(1, 2) };
            vx = vxRandom[random.Next(0, 2)];
            vy = vyRandom[random.Next(0, 2)];
            size = random.Next(40, 70);
            brush = colors[random.Next(0, colors.Count)];
        }
    }
}