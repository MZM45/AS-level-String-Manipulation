Module Module1

    Sub Main()
        Dim input As String
        Dim counter As Integer
        Dim newinput As String
        Dim space As Char
        Dim input2 As String
        Dim quitkey As Char
      
        input = ""
        space = " "
        newinput = ""
        input2 = ""
        counter = 0
        quitkey = ""

        While UCase(quitkey) <> "Y"
            Console.Write(" Enter string: ")
            input = Console.ReadLine
            For counter = 1 To Len(input)
                input2 = Mid(input, counter, 1)
                newinput = newinput & input2
                If input2 = space Then
                    Console.WriteLine("" & newinput)
                    newinput = ""
                End If

            Next
            Console.WriteLine(newinput)
            newinput = ""
            Console.WriteLine(" Press Y to quit or press any other key to repeat")
            quitkey = Console.ReadLine
        End While
    End Sub

End Module
