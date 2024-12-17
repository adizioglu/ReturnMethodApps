Namespace ConsoleAppCs
    Public Module Methods

        Public Sub SayHi(firstName As String)
            Console.WriteLine($"Hello {firstName}!")
            Console.WriteLine("I hope you are having a good day.")
        End Sub

        Public Function GetUsersName() As String
            Console.Write("What is your name: ")
            Dim name As String = Console.ReadLine()
            Return name
        End Function

        Public Sub SayGoodbye()
            Console.WriteLine("Goodbye, my user.")
            Console.WriteLine("Thank you for visiting.")
            Console.WriteLine("I cannot wait to see you again.")
        End Sub

        Public Function Add(x As Double, y As Double) As Double
            'Console.WriteLine($"The value of {x} + {y} = {x+y}")
            Dim output As Double = x + y
            Return output
        End Function

        Public Sub AddAll(values As Double())
            Dim result As Double = 0

            For Each value As Double In values
                result += value
            Next

            Console.WriteLine($"The total is {result}")
        End Sub

    End Module
End Namespace
