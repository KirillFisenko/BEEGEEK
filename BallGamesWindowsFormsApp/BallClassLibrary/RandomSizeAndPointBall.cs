﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class RandomSizeAndPointBall : Ball
    {
        protected static Random random = new Random();

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
            //radius = random.Next(10, 40);
            centerX = random.Next(LeftSide() + radius, RightSide() - radius);
            centerY = random.Next(TopSide() - radius, DownSide() + radius);            
            brush = colors[random.Next(0, colors.Count)];
        }        
    }
}