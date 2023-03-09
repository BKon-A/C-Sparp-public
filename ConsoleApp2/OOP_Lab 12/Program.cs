using System;

namespace OOP_Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userCoordinateX, userCoordinateY;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter coordite X for first vector");
                    userCoordinateX = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter coordite Y for first vector");
                    userCoordinateY = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nError: Invalid format! Try again...\n");
                    continue;
                }
                break;
            }

            NormalVectorActions firstNormalVector = new NormalVectorActions(userCoordinateX, userCoordinateY);

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter coordite X for second vector");
                    userCoordinateX = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter coordite Y for second vector");
                    userCoordinateY = Convert.ToDouble(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("\nError: Invalid format! Try again...\n");
                    continue;
                }
                break;
            }

            NormalVectorActions secondNormalVector = new NormalVectorActions(userCoordinateX, userCoordinateY);
            NormalVectorActions defoultNormalVector = new NormalVectorActions();

            Console.WriteLine("\nFirst normalized vector -->\t" + firstNormalVector.ToString());
            Console.WriteLine("\nSecond normalized vector -->\t" + secondNormalVector.ToString());
            Console.WriteLine("\nDefoult vector -->\t" + defoultNormalVector.ToString());

            Console.WriteLine("\nNew vector(first+second) -->\t" + (firstNormalVector * secondNormalVector) + "\n");
            Console.WriteLine("New vector(first+defoult) -->\t" + (firstNormalVector * defoultNormalVector) + "\n");
        }
    }
}