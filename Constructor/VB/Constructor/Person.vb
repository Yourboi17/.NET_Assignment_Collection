Public Class Person
    ' Properties
    Public Property Name As String
    Public Property Age As Integer

    ' Default constructor
    Public Sub New()
        Name = "Unknown"
        Age = 0
    End Sub

    ' Parameterized constructor
    Public Sub New(name As String, age As Integer)
        Me.Name = name
        Me.Age = age
    End Sub

    ' Method to display details
    Public Sub DisplayDetails()
        Console.WriteLine("Name: " & Name)
        Console.WriteLine("Age: " & Age)
    End Sub
End Class
