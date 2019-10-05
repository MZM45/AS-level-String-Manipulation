Module Module1

    Sub Main()
        Dim str1, str2, newstr As String
        Dim A, B As Integer
        Dim pangram As Boolean

        str1 = ""
        str2 = ""
        newstr = ""
        A = 0
        B = 0
        pangram = True

        Console.Write("enter string : ")
        str1 = Console.ReadLine
        str2 = UCase(str1)





        For A = 65 To 90
            pangram = False

            For B = 1 To Len(str2)
                newstr = Asc(Mid(str2, B, 1))
                If newstr <> A Then
                    pangram = False
                ElseIf newstr = A Then
                    pangram = True
                    Exit For

                End If
            Next B
        Next A
        If pangram = True Then
            Console.WriteLine(" The string was pangram")
            Console.ReadKey()
        ElseIf pangram = False Then
            Console.Write(" The string was not pangram ")
            Console.ReadKey()
        End If


    End Sub

End Module
