using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Program
{

    static void Main(string[] args)
    {
        var n = Console.ReadLine();
        var balls = Console.ReadLine().Split().ToList();
        var result = new List<string>();
        var cnt = 0;
        for (int i = 1; i < balls.Count; i++)
        {
            if (balls[i] == balls[i - 1])
            {
                cnt++;
            }
        }


    }

    while (в balls есть более 2-х подряд)
    {
    for (int i = 1; i < balls.Count; i++)
        {
        if(в balls есть более 2-х подряд)
            {
        result.Add(одинаковые);
        balls.Remove(одинаковые);
        }
    }
    Console.WriteLine(result.Count());


}


