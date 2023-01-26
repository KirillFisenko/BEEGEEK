using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var NK = Console.ReadLine();
        var massive = Console.ReadLine().Split().ToList().ConvertAll(int.Parse);
        var numbers = Console.ReadLine().Split().ToList().ConvertAll(int.Parse);
        foreach (var number in numbers)
        {
            Console.WriteLine(JumpSearch(massive, number));
        }
    }

    static string JumpSearch(List<int> array, int x)
    {
        int B = (int)Math.Sqrt(array.Count); // вычисляем размер блока(прыжка)

        int start = 0; // начальная позиция блока
        int end = B - 1; // конечная позиция блока


        while (array[end] < x) // пока конец блока меньше искомого элемента
        {
            if (end == array.Count - 1) // если дошли до конца массива, выходим
            {
                break;
            }

            start = Math.Min(array.Count - 1, start + B); // перемещаем начало блока вправо
            end = Math.Min(array.Count - 1, end + B); // перемещаем конец блока вправо
        }


        if (x > array[end]) // если искомый элемент больше, чем последний элемент блока, значит не нашли нужный элемент
        {
            return "NO";
        }


        for (int i = end; i >= start; i--) // линейным поиском проходим по найденному блоку
        {
            if (array[i] == x) // если текущий элемент равен искомому, то возвращаем его индекс
            {
                return "YES";
            }
        }

        return "NO"; // если дошли до сюда значит не нашли в массиве искомый элемент
    }
}


