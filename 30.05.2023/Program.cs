using System;
using System.Collections.Generic;
using System.Linq;

public class IntegerArrayTasks
{
    public static void Main()
    {
        int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 2, 3, 5, 9, 1000, 945 };

        //1
        var product = array.Aggregate((x, y) => x * y);
        Console.WriteLine("Добуток елементів масиву: " + product);


        var count = array.Count();
        Console.WriteLine("Кількість елементів масиву: " + count);


        var countMultiplesOf9 = array.Count(x => x % 9 == 0);
        Console.WriteLine("Кількість елементів масиву, кратних 9: " + countMultiplesOf9);


        var countMultiplesOf7Above945 = array.Count(x => x % 7 == 0 && x > 945);
        Console.WriteLine("Кількість елементів масиву, кратних 7 і більших, ніж 945: " + countMultiplesOf7Above945);


        var sum = array.Sum();
        Console.WriteLine("Сума елементів масиву: " + sum);


        var sumEvenNumbers = array.Where(x => x % 2 == 0).Sum();
        Console.WriteLine("Сума парних елементів масиву: " + sumEvenNumbers);


        var min = array.Min();
        Console.WriteLine("Мінімум в масиві: " + min);

        
        var max = array.Max();
        Console.WriteLine("Максимум в масиві: " + max);

        
        double average = array.Average();
        Console.WriteLine("Середнє значення в масиві: " + average);

        //2
        var top3Max = array.OrderByDescending(x => x).Take(3);
        Console.WriteLine("Три перші максимальні елементи:");
        foreach (int num in top3Max)
        {
            Console.WriteLine(num);
        }

   
        var top3Min = array.OrderBy(x => x).Take(3);
        Console.WriteLine("Три перші мінімальні елементи:");
        foreach (int num in top3Min)
        {
            Console.WriteLine(num);
        }

        //3
        var numberStatistics = array.GroupBy(x => x)
                                    .Select(group => $"{group.Key} - {group.Count()} разів");
        Console.WriteLine("Статистика входження кожного числа до масиву:");
        foreach (var stat in numberStatistics)
        {
            Console.WriteLine(stat);
        }


        
        var evenNumberStatistics = array.Where(x => x % 2 == 0)
                                        .GroupBy(x => x)
                                        .Select(group => $"{group.Key} - {group.Count()} разів");
        Console.WriteLine("Статистика входження парних чисел у масив:");
        foreach (var stat in evenNumberStatistics)
        {
            Console.WriteLine(stat);
        }

        
        var oddEvenNumberStatistics = array.GroupBy(x => x % 2 == 0 ? "Парні" : "Непарні")
                                            .Select(group => $"{group.Key} - {group.Count()} разів");
        Console.WriteLine("Статистика входження парних і непарних чисел до масиву:");
        foreach (var stat in oddEvenNumberStatistics)
        {
            Console.WriteLine(stat);
        }
    }
}
