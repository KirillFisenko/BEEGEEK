using System;
using System.Collections;

public class MainClass
{
    static int LeftBinarySearch(int[] array, int x)
    {
        int left = -1; // исключаем из возможных значений ответа
        int right = array.Length - 1; // ответ будет находится здесь
        while (left + 1 < right)
        {
            int m = left + (right - left) / 2; // вычисление серединного элемента

            if (array[m] < x) // если серединный элемент меньше искомого, то смещаем левую границу
                left = m;
            else
                right = m; // если серединный элемент больше либо равно искомому, то смещаем правую границу
        }        
        return array[right]; // если не нашли соответствующего элемента, возвращаем "-1"
    }

    static int RightBinarySearch(int[] array, int x)
    {
        int left = 0; // ответ будет находится здесь
        int right = array.Length; // исключаем из возможных значений ответа
        while (left + 1 < right)
        {
            int m = left + (right - left) / 2; // вычисление серединного элемента

            if (array[m] <= x) // если серединный элемент меньше либо равно искомому, то смещаем левую границу
                left = m;
            else
                right = m; // если серединный элемент больше искомого, то смещаем правую границу
        }        
        return array[left]; // если не нашли соответствующего элемента, возвращаем "-1"
    }

    static int[] ConvertArray(string[] array)
    {
        int[] new_array = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            new_array[i] = Convert.ToInt32(array[i]);
        }
        return new_array;
    }  

    public static void Main()
    {
        string N = Console.ReadLine();

        string[] S = Console.ReadLine().Split();
        int[] SP = ConvertArray(S);


        string[] C = Console.ReadLine().Split();
        int[] CH = ConvertArray(C);

        foreach (var num in CH)
        {
            Console.WriteLine(LeftBinarySearch(SP, num));
        }
        Console.ReadLine();
    }
}
