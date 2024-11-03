Module InheritanceExample

    Public Class Animal
        Public Sub Eat()
            Console.WriteLine("Animal is eating...")
        End Sub
    End Class

    Public Class Dog
        Inherits Animal

        Public Sub Bark()
            Console.WriteLine("Dog is barking...")
        End Sub
    End Class

    Public Class Puppy
        Inherits Dog

        Public Sub Weep()
            Console.WriteLine("Puppy is weeping...")
        End Sub
    End Class

    Sub Main()
        Console.WriteLine("Program started..." & vbNewLine)

        Dim dog As New Dog()
        Console.WriteLine("Single Inheritance Example:")
        dog.Eat()
        dog.Bark()

        Console.WriteLine()

        Dim puppy As New Puppy()
        Console.WriteLine("Multi-Level Inheritance Example:")
        puppy.Eat()
        puppy.Bark()
        puppy.Weep()

        Console.WriteLine(vbNewLine & "Press Enter to exit...")
        Console.ReadLine()
    End Sub

End Module
