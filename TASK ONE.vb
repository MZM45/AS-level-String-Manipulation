Module Module1

    Sub Main()
        'task one input str1 and str2 and combine first worrd of str1 and last word of str2 
        Dim str1 As String
        Dim str2 As String
        Dim newstr1 As String
        Dim newstr2 As String
        Dim str3 As String
        Dim str4 As String
        Dim finalstr As String

        finalstr = ""
        str4 = ""
        str3 = ""
        str1 = ""
        str2 = ""
        newstr1 = ""
        newstr2 = ""

        'for First NAME
        Console.WriteLine("Input Name")
        Console.Write(" Enter FIRST NAME: ")
        str1 = Console.ReadLine
        Console.Write("Enter LAST NAME: ")
        str2 = Console.ReadLine

        'For Second name
        Console.WriteLine(" Input Second Name")
        Console.Write(" Enter FIRST NAME: ")
        str3 = Console.ReadLine
        Console.Write("Enter LAST NAME: ")
        str4 = Console.ReadLine

        'processing/working
        newstr1 = str1
        newstr2 = str4
        finalstr = newstr1 & " " & newstr2
        Console.WriteLine(" The New name is: " & finalstr)
        Console.WriteLine(" TASK ONE COMPLETED PRESS any key TO QUIT")
        Console.ReadKey()




    End Sub

End Module
