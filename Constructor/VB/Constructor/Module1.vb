Module Module1
    Sub Main()
        ' Create an instance using the default constructor
        Dim person1 As New Person()
        Console.WriteLine("Using Default Constructor:")
        person1.DisplayDetails()

        ' Create an instance using the parameterized constructor
        Dim person2 As New Person("Alice", 25)
        Console.WriteLine(vbCrLf & "Using Parameterized Constructor:")
        person2.DisplayDetails()

        ' Wait for user input before closing
        Console.ReadLine()
    End Sub
End Module
