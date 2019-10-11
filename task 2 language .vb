Module Module1

    Sub Main()

        Dim str1 As String
        Dim a As Integer
        Dim b As Integer
        Dim midstr As String
        Dim space As Char
        Dim counter As Integer
        Dim spacecounter As Integer
        Dim myspace As Char
        Dim limit As Boolean
        
    
        limit = False
        counter = 0
        space = " "
        midstr = ""
        str1 = ""
        a = 0
        b = 0

        ' input
        Console.Write(" Enter string of three words: ")
        str1 = Console.ReadLine
        'process
        For counter = 1 To Len(str1)
            myspace = Mid(str1, counter, 1)
            If InStr(space, myspace) > 0 Then
                spacecounter = spacecounter + 1
                End If
        Next
        
        If spacecounter > 2 Then
            limit = False
        ElseIf spacecounter <= 1 Then
            limit = True
        End If
        a = InStr(str1, " ")
        b = InStr(a + 1, str1, " ")
        midstr = Mid(str1, a + 1, b - a - 1)
        
        If limit = False Then
            Console.Write(" Sorry the string should only be of three words ... press any key to quit ")
            Console.ReadKey()

        ElseIf limit = True Then
            Console.Write(" The mid word is: " & midstr)
            Console.ReadKey()
        End If




    End Sub

End Module
