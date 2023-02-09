using System.Drawing;

namespace BallGamesWindowsFormsApp
{
    public class RandomSizeAndPointBall : RandomPointBall
    {        
        public RandomSizeAndPointBall(MainForm form) : base(form)
        {
            size = random.Next(10, 80);            
        }
    }
}