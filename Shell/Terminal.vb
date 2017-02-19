Module Terminal
    'Variables
    Dim Input As String
    Sub Main()
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.Write("Command)")
        Input = System.Console.ReadLine()
        If Input = "" Then
            Main()
        End If
        If Input.ToLower = "help" Then
            Help.Main()
        End If
        If Input.ToLower = "cls" Then
            Console.Clear()
            Main()
        End If
        If Input.ToLower = "calc" Then
            Calculator.Main()
        End If
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Error: Invalid Command")
        Console.WriteLine("")
        Main()
    End Sub
End Module
