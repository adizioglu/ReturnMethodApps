
namespace ConsoleAppCs
{
    public static class Methods
    {

        public static void SayHi(string firstName)
        {
            Console.WriteLine($"Hello {firstName}!");
            Console.WriteLine("I hope you are having a good day.");
        }

        public static string GetUsersName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye, my user.");
            Console.WriteLine("Thank you for visiting.");
            Console.WriteLine("I cannot wait to see you again.");
        }

        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value of {x} + {y} = {x+y}");
            double output = x + y;

            return output;
        }

        public static void AddAll(double[] values)
        {
            double result = 0;

            foreach (double value in values)
            {
                result += value;
            }

            Console.WriteLine($"The total is {result}");
        }

    }
}
