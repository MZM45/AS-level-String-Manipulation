Module Module1

    Sub Main()
        Dim quitkey As Char = ""
        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim pickchar As Char = ""
        Dim a As Integer = 0
        Dim counter As Integer = 0
        Dim valid As Boolean = False

        While (UCase(quitkey) <> "F")
            Console.Write(" Enter string: ")
            str1 = Console.ReadLine
            Console.Write(" enter string to check anagram ")
            str2 = Console.ReadLine

            For counter = 1 To Len(str1)
                pickchar = Mid(str1, counter, 1)
                a = InStr(str2, pickchar)
                If a < 1 Then
                    valid = False
                Else : valid = True
                End If
            Next
            If valid = False Then
                Console.Write(" The String was not Anagram , Press F to quit or any other key to repeat")
                quitkey = Console.ReadLine
            ElseIf valid = True Then
                Console.Write(" The String was Anagram , Press F to quit or any other key to repeat")
                quitkey = Console.ReadLine
            End If
        End While
       



    End Sub

End Module
