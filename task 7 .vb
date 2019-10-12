Module Module1

    Sub Main()
        Dim str As String = ""
        Dim chr As Char = ""
        Dim ascvalue As Integer = 0
        Dim range As Integer = 0
        Dim letters As String = ""
        Dim numbers As Integer = 0
        Dim spchr As String = ""
        Dim quitkey As Char = ""

        Console.Write("Enter the string to seperate it: ")
        str = Console.ReadLine
        While UCase(quitkey) <> "F"
            For range = 1 To Len(str)
                chr = Mid(str, range, 1)
                ascvalue = Asc(chr)
                If ascvalue >= 65 And ascvalue <= 90 Or ascvalue >= 97 And ascvalue <= 122 Then
                    letters = letters & chr
                ElseIf ascvalue >= 48 And ascvalue <= 57 Then
                    numbers = numbers & chr
                Else : spchr = spchr & chr

                End If

            Next


            Console.WriteLine("The letters in the string: " & letters)
            Console.ReadKey()

            Console.WriteLine("The numbers in the string " & numbers)
            Console.ReadKey()

            Console.WriteLine("The specials in the string " & spchr)
            Console.ReadKey()

            Console.WriteLine(" press F to Quit or any other key to output again")
            quitkey = Console.ReadLine
        End While
    End Sub

End Module
