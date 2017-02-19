Module Module1
    Sub Main()
        Console.WriteLine("Starting LS-DOS...")
        Threading.Thread.Sleep(1000)
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Welcome to LS-DOS " & My.Settings.username & ", " & "Check out all of the commands by using help!")
        Console.WriteLine("")
        Terminal.Main()
    End Sub
End Module
