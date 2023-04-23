using static OOP_Lab_16.IntegralActionsHandler;
using static OOP_Lab_16.NameContributor;

namespace OOP_Lab_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntegralActionsHandler integral = new IntegralActionsHandler(10, 100, -3, 5);

            integral.UseFunctionIntegralEvent += EventFunctionIntegralHandler;

            Console.WriteLine("--------------------------Task 1: Integrals and delegates------------------------------------");

            integral.FunctionWithModulAndSquare(-3);
            integral.FunctionLogarithm(-8);
            integral.FunctionPower(6);

            integral.Integral(-6, 5, integral.FunctionLogarithm);
            integral.Integral(-5, 3, integral.FunctionPower);
            integral.Integral(-2, 2, integral.FunctionWithModulAndSquare);

            //integral.Integral(-1, 6, integral.FunctionDx); this method  has different parameters


            Console.WriteLine("--------------------------Task 2: Events and Handlers------------------------------");

            NameContributor contributor = new NameContributor();

            contributor.NameContribution += KeyHandler;

            contributor.ButtonClickB();
        }
    }
}
