using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class RandomSizeAndPointBall : Ball
    {
        protected static Random random = new Random();

        protected List<Brush> colors = new List<Brush>()
        { Brushes.Black,
          Brushes.Yellow,
          Brushes.Yellow,
          Brushes.Yellow,
          Brushes.Yellow,
          Brushes.Yellow,
          Brushes.Yellow,
          Brushes.Yellow,
          Brushes.Yellow,
          Brushes.Brown,
          Brushes.Violet,
          Brushes.Green,
          Brushes.Blue,
          Brushes.Red,
          Brushes.DarkGreen,
          Brushes.Olive,
          Brushes.Pink,
          Brushes.Tomato,
          Brushes.Orange,
          Brushes.Goldenrod };

        public RandomSizeAndPointBall(Form form) : base(form)
        {
            radius = random.Next(10, 40);
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
            brush = colors[random.Next(0, colors.Count)];
        }
    }
}