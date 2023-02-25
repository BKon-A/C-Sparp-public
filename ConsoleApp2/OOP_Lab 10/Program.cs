using System;

namespace OOP_Lab_10
{
    
    internal class Program
    {
        static void Task1()
        {
            const int SIZE = 50;
            int elementsNumber = 0;
            int[] incomingArray = new int[SIZE];
            int[] outcomingArray = new int[SIZE];

            Random random = new Random();

            Console.WriteLine("Incoming array: ");

            for (int i = 0; i < incomingArray.Length; i++)
            {
                incomingArray[i] = random.Next(-10, 10);
                elementsNumber++;
                Console.Write(" " + incomingArray[i]);
            }
            Console.WriteLine("\nNumber of eleemnts: " + elementsNumber + "\n\nOutcoming array: ");

            elementsNumber = 0;

            for (int i = 0; i < incomingArray.Length; i++)
            {
                if (incomingArray[i] != 0)
                {
                    outcomingArray[i] = incomingArray[i];
                    elementsNumber++;
                }
            }
            for (int i = outcomingArray.Length - 1; i >= 0; i--)
            {
                if (outcomingArray[i] != 0)
                {
                    Console.Write(" " + outcomingArray[i]);
                }
                
            }
            Console.WriteLine("\nNumber of eleemnts: " + elementsNumber);
        }

        static void Task2()
        {
            const int SIZE = 50;
            int elementsNumber = 0;
            double squereSum = 0;
            int[] fascistArray = new int[SIZE];
            int[] outFascistArray = new int[SIZE];
            Random random = new Random();

            Console.WriteLine("Incoming array: ");

            for (int i = 0; i < fascistArray.Length; i++)
            {
                fascistArray[i] = random.Next(-10, 10);
                elementsNumber++;
                Console.Write(" " + fascistArray[i]);
            }
            Console.WriteLine("\nNumber of eleemnts: " + elementsNumber + "\n");

            elementsNumber = 0;
            Console.WriteLine("Outcoming array:");

            for (int i = 0; i < fascistArray.Length; i++)
            {
                if (fascistArray[i] > 1)
                {
                    outFascistArray[i] = fascistArray[i];
                    squereSum += Math.Pow(outFascistArray[i], 2);
                    elementsNumber++;
                }
                if (outFascistArray[i] != 0)
                {
                    Console.Write(" " + outFascistArray[i]);
                }
            }
            Console.WriteLine("\nNumber of eleemnts: " + elementsNumber + "\n");
            Console.WriteLine("Squere sum: " + squereSum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------------------Task1----------------\n");
            Task1();

            Console.WriteLine("\n------------------Task2----------------\n");
            Task2();
        }
    }
}
