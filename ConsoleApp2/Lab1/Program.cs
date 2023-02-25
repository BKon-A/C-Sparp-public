namespace Lab1
{
    class Program
    {
        static double FormulaCalculation(double x, double y, double z)
        {
            double a; 
            a = Math.Sqrt(Math.Pow(x,3) + Math.Pow(y, 2) + z);

            return a;
        }

        static void Task1()
        {
            //Task1
            string dataStorage;
            double x, y, z, result;

            while (true)
            {

                Console.WriteLine("\nEnter x: ");
                dataStorage = Console.ReadLine();
                if (dataStorage == "0")
                {
                    Console.WriteLine("Cycle is completed");
                    break;
                }
                x = Convert.ToDouble(dataStorage);

                Console.WriteLine("\nEnter y: ");
                dataStorage = Console.ReadLine();
                y = Convert.ToDouble(dataStorage);

                Console.WriteLine("\nEnter z: ");
                dataStorage = Console.ReadLine();
                z = Convert.ToDouble(dataStorage);

                result = FormulaCalculation(x, y, z);
                Console.WriteLine("\nFormula result: " + result);

                if (x <= -10)
                {
                    Console.WriteLine("\nX is less than -10");
                }
                else if (x <= -1)
                {
                    Console.WriteLine("\nX is less than -1");
                }
                else if (x >= 1)
                {
                    Console.WriteLine("\nX is over than 1");
                }
                else if (x >= 10)
                {
                    Console.WriteLine("\nX is over than 10");
                }
                if (result >= 0)
                {
                    Console.WriteLine("\n\"Formula result\" have a positive value");
                }
                else
                {
                    Console.WriteLine("\n\"Formula result\" have a negative value");
                }
            }
        }

        class RestorantProducts
        {
            double productCost;
            int productWeight;

            public RestorantProducts(double productCost, int productWeight)
            {
                this.productCost = productCost;
                this.productWeight = productWeight;
            }

            private void SetCost(double productCost)
            {
                this.productCost = productCost;
            }
            private void SetWeight(int productWeight)
            {
                this.productWeight = productWeight;
            }
            public double GetCost()
            {
                return productCost;
            }
            public int GetWeight()
            {
                return productWeight;
            }
        }

        static void Task2()
        {
            RestorantProducts butter = new RestorantProducts(8.50, 1);
            RestorantProducts sourCream = new RestorantProducts(2.40, 2);
            RestorantProducts cream = new RestorantProducts(4.10, 3);

            Console.WriteLine("\n---------------------Task2------------------------\n");
            Console.WriteLine("Spend on butter every day: " + (butter.GetCost() * butter.GetWeight())
                + " UAH");
            Console.WriteLine("Spend on sour cream every day: " + (sourCream.GetCost() * sourCream.GetWeight())
                + " UAH");
            Console.WriteLine("Spend on cream every day: " + (cream.GetCost() * cream.GetWeight())
                + " UAH");
            Console.WriteLine("Spend on products every day: " + ((butter.GetCost() * butter.GetWeight())
                + (sourCream.GetCost() * sourCream.GetWeight()) + (cream.GetCost() * cream.GetWeight()))
                + " UAH");
        }

        static void Main(string[] args)
        {
            //Task1
            Task1();

            //Task2
            Task2();
        }
    }
}