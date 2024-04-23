using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassAndMethod
{
    class Massiv
    {
        public int dlinna;
        public int[] array;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну первого массива: ");
           Massiv MassOne = new Massiv();
            MassOne.dlinna = new int();
            MassOne.dlinna = int.Parse(Console.ReadLine());
            MassOne.array = new int[MassOne.dlinna];
            Console.WriteLine("Введите числа массива ");
            for (int i = 0;  i < MassOne.dlinna; i++) 
            { 
            MassOne.array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите длинну второго массива: ");
            Massiv MassTwo = new Massiv();           
            MassTwo.dlinna = int.Parse(Console.ReadLine());
            MassTwo.array = new int[MassTwo.dlinna];
            Console.WriteLine("Введите числа массива ");
            for (int i = 0; i < MassTwo.dlinna; i++)
            {
                MassTwo.array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Первый массив: ");
            for (int i = 0; i < MassOne.dlinna; i++)
            {
                Console.Write($"{MassOne.array[i]} ");
            }
            Console.WriteLine();
            Console.Write("Второй массив: ");
            for (int i = 0; i < MassTwo.dlinna; i++)
                {
                Console.Write($"{MassTwo.array[i]} ");
                }
            Console.WriteLine();
            if (MassOne.dlinna == MassTwo.dlinna)
            {
                Massiv MassSumm = new Massiv();
                MassSumm.dlinna = MassOne.dlinna;
                MassSumm.array = new int[MassSumm.dlinna];
                for (int i = 0; i < MassOne.dlinna; i++)
                {
                    MassSumm.array[i] = MassOne.array[i] + MassTwo.array[i];
                }

                Massiv MassSub = new Massiv();
                MassSub.dlinna = MassOne.dlinna;
                MassSub.array = new int[MassSub.dlinna];
                for (int i = 0; i < MassOne.dlinna; i++)
                {
                    MassSub.array[i] = MassOne.array[i] - MassTwo.array[i];
                }
                Console.Write("Сумма массивов: ");
                for (int i = 0; i < MassOne.dlinna; i++)
                {
                    Console.Write($"{MassSumm.array[i]} ");
                }
                Console.WriteLine();
                Console.Write("Вычитание массивов: ");
                for (int i = 0; i < MassOne.dlinna; i++)
                {
                    Console.Write($"{MassSub.array[i]} ");
                }

            }
            else 
            {
            Console.WriteLine("Вычитание и сложение невозможно так как длинна массивов разная");
            }
            Console.ReadKey();
        }
    }
}
