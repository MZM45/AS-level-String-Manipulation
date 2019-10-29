Module Module1

    Sub Main()
        Dim counter As Integer = 0
        Dim str As String = ""
        Dim pickchar As String = ""
        Dim validbinarystring As Boolean = True

        Console.Write("Enter binary number: ")
        str = Console.ReadLine

        If Len(str) < 1 Or Len(str) > 8 Then
            validbinarystring = False
        End If
        If validbinarystring = True Then
            For counter = 1 To Len(str)
                pickchar = Mid(str, counter, 1)
                If pickchar < 0 Or pickchar > 1 Then
                    validbinarystring = False
                End If
            Next
        End If
       
        If validbinarystring = False Then
            Console.Write(" The number was not binary ")
            Console.ReadKey()
        ElseIf validbinarystring = True Then
            Console.Write(" The number was binary")
            Console.ReadKey()

        End If

    End Sub

End Module
