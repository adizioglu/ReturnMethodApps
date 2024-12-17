#include <iostream>
#include <vector>
#include <string>
#include "Methods.h"

int main()
{
    std::string name = ConsoleAppCs::Methods::GetUsersName();

    ConsoleAppCs::Methods::SayHi(name);

    double result = ConsoleAppCs::Methods::Add(5, 3);
    std::cout << "The result is " << result << std::endl;

    std::vector<double> vals = { 2, 5, 6, 21, 52, 98 };
    ConsoleAppCs::Methods::AddAll(vals);

    ConsoleAppCs::Methods::SayGoodbye();

    return 0;
}