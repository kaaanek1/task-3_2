using System;

namespace task3_2
{
    class Program
    {
        static void Main()
        {
            ParentClass[] array = new ParentClass[3];

            Console.WriteLine("Будешь заполнть массивы сам? true/false");
            bool fill = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Длина одномерного массива: ");
            int n1 = int.Parse(Console.ReadLine());
            LVL1 arr1 = new(n1, fill);

            Console.WriteLine();

            Console.Write("Количество подмассивов в двумерном массиве: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Длина каждого подмассива: ");
            int a = int.Parse(Console.ReadLine());
            LVL2 arr2 = new(a, b, fill);

            Console.WriteLine();

            Console.Write("Длина ступенчатого массива: ");
            int n3 = int.Parse(Console.ReadLine());
            LVL3 arr3 = new(n3, fill);
            
            Console.WriteLine();

            array[0] = arr1;
            array[1] = arr2;
            array[2] = arr3;

            for (int i = 0; i<3; i++)
            {
                array[i].Print();
                Console.Write("Среднее значение: ");
                Console.WriteLine(array[i].Average());
                Console.WriteLine();
            }
        }
    }
} 

