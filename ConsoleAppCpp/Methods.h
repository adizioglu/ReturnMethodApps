#include <iostream>
#include <string>
#include <vector>

namespace ConsoleAppCs
{
    class Methods
    {
    public:
        static void SayHi(const std::string& firstName)
        {
            std::cout << "Hello " << firstName << "!" << std::endl;
            std::cout << "I hope you are having a good day." << std::endl;
        }

        static std::string GetUsersName()
        {
            std::cout << "What is your name: ";
            std::string name;
            std::getline(std::cin, name);
            return name;
        }

        static void SayGoodbye()
        {
            std::cout << "Goodbye, my user." << std::endl;
            std::cout << "Thank you for visiting." << std::endl;
            std::cout << "I cannot wait to see you again." << std::endl;
        }

        static double Add(double x, double y)
        {
            // std::cout << "The value of " << x << " + " << y << " = " << (x + y) << std::endl;
            return x + y;
        }

        static void AddAll(const std::vector<double>& values)
        {
            double result = 0;

            for (double value : values)
            {
                result += value;
            }

            std::cout << "The total is " << result << std::endl;
        }
    };
}