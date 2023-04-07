
Module Program
    Sub Main(args As String())
        Do
            Dim guessStr As String
            Do
                Dim number As Integer = CInt(Int((9876 * Rnd()) + 1))
                Console.WriteLine(number)
            ' Int((9876 - 1023 + 1) * Rnd + 1023)
        
                Console.WriteLine("Enter your guess: ")
                guessStr = Console.ReadLine()
                
            Loop While Len(guessStr) <> 4
        Loop While True
    End Sub
End Module
