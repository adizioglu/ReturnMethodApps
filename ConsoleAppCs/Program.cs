string name = ConsoleAppCs.Methods.GetUsersName();

ConsoleAppCs.Methods.SayHi(name);

double result = ConsoleAppCs.Methods.Add(5, 3);
Console.WriteLine($"The result is {result}");

double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };
ConsoleAppCs.Methods.AddAll(vals);

ConsoleAppCs.Methods.SayGoodbye();
