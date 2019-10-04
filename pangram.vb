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

        If Len(str2) < 26 Then
            Console.WriteLine(" This is not a pangram .. press any key to quit")
            Console.ReadKey()

        Else


            For A = 65 To 90
                pangram = True
                For B = 1 To Len(str2)
                    newstr = Mid(str2, B, 1)
                    If Asc(newstr) = B Then
                        pangram = True
                        Exit For

                    End If
                    If pangram = False Then
                        Console.WriteLine(" the string is not pangram")
                        Console.ReadKey()
                        Exit For

                    End If
                Next B
            Next A
            If pangram = True Then
                Console.WriteLine(" The string was pangram")
                Console.ReadKey()

            End If
        End If



    End Sub

End Module
