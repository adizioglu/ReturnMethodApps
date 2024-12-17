Module Program
    Sub Main()
        Dim name As String = ConsoleAppCs.Methods.GetUsersName()

        ConsoleAppCs.Methods.SayHi(name)

        Dim result As Double = ConsoleAppCs.Methods.Add(5, 3)
        Console.WriteLine($"The result is {result}")

        Dim vals As Double() = {2, 5, 6, 21, 52, 98}
        ConsoleAppCs.Methods.AddAll(vals)

        ConsoleAppCs.Methods.SayGoodbye()
    End Sub
End Module
