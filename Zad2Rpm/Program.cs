using System;
using System.Globalization;
using Zad2Rpm;

namespace Zad2Rpm
{
    public class Massiv
    {

        double[] array;
        public void arr()
        {
            VvodMass();
            ZapolnMass();
        }
        void VvodMass()
        {
            Console.WriteLine("Введите длинну массива ");
            int dLinna = Convert.ToInt32(Console.ReadLine());
            array = new double[dLinna];
        }
        void ZapolnMass()
        {
            Console.WriteLine("Заполните массив ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void PrintMass() 
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write($"{array[i]} ");
            }
        }
        public void SceplenieMassWithCheck(Massiv Mass2) 
        {
            
            for (int i = 0; i < array.Length; i++) 
            {

                for (int j = 0; j < array.Length; j++) 
                {
                    if (array[i] == Mass2.array[j]) 
                    {
                        Console.Write(array[i] + " ");
                    }

                }

            }
        }

    }

        internal class Program
        {

            static void Main(string[] args)
            {
                Massiv Mass1 = new Massiv();
                Mass1.arr();
                Massiv Mass2 = new Massiv();
                Mass2.arr();
               Mass1.PrintMass();
            Console.WriteLine();
               Mass2.PrintMass();
            Console.WriteLine();
            Mass1.SceplenieMassWithCheck(Mass2);



            }
    }
}

//Console.Write(array[i] + "" + Mass2.array[i] + " ");