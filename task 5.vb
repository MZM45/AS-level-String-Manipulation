Module Module1

    Sub Main()
        Dim str As String = ""
        Dim newstr As String = ""
        
        Console.Write(" Enter string: ")
        str = Console.ReadLine

        str = StrReverse(str)
        Console.Write("The new string is :" & str)
        Console.ReadKey()

    End Sub

End Module
