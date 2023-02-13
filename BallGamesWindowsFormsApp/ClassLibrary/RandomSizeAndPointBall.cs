using System;
using System.Collections.Generic;
using System.Drawing;
using BallGamesWindowsFormsApp;

namespace BallGamesWindowsFormsApp
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

        public RandomSizeAndPointBall(MainForm form) : base(form)
        {
            x = random.Next(70, form.Size.Width / 2);
            y = random.Next(70, form.Size.Height / 2);
            vx = random.Next(-6, 6);
            vy = random.Next(-6, 6);
            size = random.Next(20, 70);
            brush = colors[random.Next(0, colors.Count)];
        }
    }
}