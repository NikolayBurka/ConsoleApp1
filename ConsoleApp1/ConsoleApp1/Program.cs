using System;

class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = new int[6];
//        for (int i = 0; i < 6; i++)
//        {
//            Console.Write("Введите число: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Исходный массив: " + string.Join(", ", arr));
//        Console.WriteLine("Массив в обратном порядке: " + string.Join(", ", arr.Reverse()));
//    }
//}
//{
//    static void Main(string[] args)
//    {
//        int[] precipitation = new int[31]; 

//        Random rnd = new Random();
//        for (int i = 0; i < 31; i++)
//        {
//            precipitation[i] = rnd.Next(5, 61);
//        }

//        int totalPrecipitation = 0; 
//        for (int i = 0; i < 31; i++)
//        {
//            totalPrecipitation += precipitation[i];
//        }

//        Console.WriteLine("Общее количество осадков за январь: " + totalPrecipitation + " мм");
//    }
//}
//{
//    static void Main(string[] args)
//    {
//        double[] weights = new double[20]; // Создаем массив для хранения весов

//        Random rnd = new Random(); // Создаем объект класса Random для генерации случайных чисел

//        // Заполняем массив случайными вещественными значениями от 50 до 100
//        for (int i = 0; i < 20; i++)
//        {
//            weights[i] = rnd.NextDouble() * (100 - 50) + 50;
//        }

//        double averageWeight = 0; // Средний вес

//        // Считаем средний вес
//        for (int i = 0; i < 20; i++)
//        {
//            averageWeight += weights[i];
//        }
//        averageWeight /= 20;

//        Console.WriteLine("Средний вес: " + averageWeight);
//    }
//}
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { -37, 0, 50, 46, 34, 46, -4, 13 }; // Создаем массив с явной инициализацией

        int negativeCount = 0; // Количество отрицательных элементов

        // Считаем количество отрицательных элементов в массиве
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Количество отрицательных элементов в массиве: " + negativeCount);
    }
}

