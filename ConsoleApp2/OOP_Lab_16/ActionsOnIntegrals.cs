using System.Reflection;

namespace OOP_Lab_16
{
    internal abstract class Integral
    {
        protected int Precision { get; private set; }
        protected double ArgumentX { get; private set; }
        protected double LowerBoundary { get; private set; }
        protected double UpperBoundary { get; private set; }

        public Integral(double argumentX, int precision, double lowerBoundary, double upperBoundary)
        {
            ArgumentX = argumentX;
            Precision = precision;
            LowerBoundary = lowerBoundary;
            UpperBoundary = upperBoundary;
        }
    }

    internal class IntegralActionsHandler : Integral
    {
        public delegate double FunctionHandler(double function);

        //public event FunctionHandler? UseFunctionModuleAndSquareEvent; 
        //public event FunctionHandler? UseFunctionPowerEvent;
        //public event FunctionHandler? UseFunctionLogarithmEvent;
        public event FunctionHandler? UseFunctionIntegralEvent;

        public IntegralActionsHandler(double argumentX, int precision, double lowerBoundary,
            double upperBoundary) : base(argumentX, precision, lowerBoundary, upperBoundary)
        {

        }

        public double FunctionWithModulAndSquare(double argumentX)
        {
            return 1 / Math.Sqrt(Math.Abs(argumentX));
        }
        public double FunctionPower(double argumentX)
        {
            return 1 / (Math.Pow(argumentX, 2) + 1);
        }
        public double FunctionLogarithm(double argumentX)
        {
            return Math.Log(Math.Abs(argumentX));
        }

        public double FunctionDx(double lowerBoundary, double upperBoundary)
        {
            return (lowerBoundary - upperBoundary) / Precision;
        }

        public double Integral(double lowerBoundary, double upperBoundary, FunctionHandler function)
        {
            double sum = 0;
            double x = lowerBoundary;

            for (int i = 0; i < Precision; i++)
            {
                sum += function(x) + function(x + FunctionDx(lowerBoundary, upperBoundary))
                    / 2 * FunctionDx(lowerBoundary, upperBoundary);

                x += FunctionDx(lowerBoundary, upperBoundary);
            }

            UseFunctionIntegralEvent?.Invoke(sum);

            return sum;
        }

        //public static double EventFunctionModuleAndSquareHandler(double function)
        //{
        //    Console.WriteLine($"Function with module and square result: {function}");
        //    return function;
        //}
        //public static double EventFunctionPowerHandler(double function)
        //{
        //    Console.WriteLine($"Power function result: {function}");
        //    return function;
        //}
        //public static double EventFunctionLogarithmHandler(double function)
        //{
        //    Console.WriteLine($"Logarithm function result: {function}");
        //    return function;
        //}
        public static double EventFunctionIntegralHandler(double function)
        {
            Console.WriteLine($"Integral function result: {function}");
            return function;
        }

    }
}