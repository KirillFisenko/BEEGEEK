using System;

namespace TestClassLibrary
{
    public class Triangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }        

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;            
        }

        public static bool IsExists(Triangle triangle, out double p, out double s)
        {
            p = 0;
            s = 0;
            if (triangle.a < triangle.b + triangle.c && triangle.b < triangle.a + triangle.c && triangle.c < triangle.a + triangle.b)
            {
                p = triangle.a + triangle.b + triangle.c;
                s = Math.Sqrt((p / 2 - triangle.a) * (p / 2 - triangle.b) * (p / 2 - triangle.c));
                return true;
            }
            return false;
        }
    }
}
