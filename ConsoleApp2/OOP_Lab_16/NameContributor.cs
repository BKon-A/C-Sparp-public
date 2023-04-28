using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_16
{
    internal class NameContributor
    {
        public delegate void NameContributorDelegate(ConsoleKeyInfo key);

        public event NameContributorDelegate? NameContribution;
        public void ButtonClickB()
        {
            while(true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.KeyChar == 'B')
                {
                    NameContribution?.Invoke(key);
                }
                else if (key.KeyChar == 'x')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nTry again!");
                }
            }
        }

        public static void KeyHandler(ConsoleKeyInfo key)
        {
            Console.Write("ohdan\n");
        }
    }
}
