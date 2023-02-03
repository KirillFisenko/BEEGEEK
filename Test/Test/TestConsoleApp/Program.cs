using System;

public class Program
{
    static void Main(string[] args)
    {
        int V = Convert.ToInt32(Console.ReadLine());
        //string[,] matrix = new string[V,V];

        for (int i = 0; i < V; i++)
        {
            var line = Console.ReadLine().Split();
            for (int j = 0; j < V; j++)
            {
                if (line[j] == "1")
                {
                    Console.WriteLine((i + 1) + " " + (j + 1));
                }
            }
        }

        //for (int i = 0; i < V; i++)
        //{            
        //    for (int j = 0; j < V; j++)
        //    {
        //        if(matrix[i, j] == "1")
        //        {
        //            Console.WriteLine((i+1) + " " + (j+1));
        //        } 
        //    }
        //}
    }

    
}


