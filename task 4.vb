Module Module1

    Sub Main()
        Dim str As String = ""
        Dim delchar As Char = ""
        Dim counter As Integer = 0
        Dim newstr As String = ""
        Dim pickchar As Char = ""
        Dim counter2 As Integer = 0
        Dim delchar2 As Char = ""

        Console.WriteLine(" Enter String: ")
        str = Console.ReadLine
        Console.WriteLine(" Enter Letter you want to remove from the string")
        delchar = Console.ReadLine
        For counter = 1 To Len(str)
            pickchar = Mid(str, counter, 1)
            For counter2 = 1 To Len(str)
                delchar2 = Mid(delchar, counter2, 1)
            Next
            If pickchar <> delchar Then
                newstr = newstr & pickchar
            End If
        Next
        Console.WriteLine("New String is :" & newstr)
        Console.ReadKey()


    End Sub

End Module
