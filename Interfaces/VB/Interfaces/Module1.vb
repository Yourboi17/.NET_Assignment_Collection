Module Module1
    Interface IAnimal
        Sub Speak()
    End Interface

    Interface IMammal
        Inherits IAnimal
        Sub Walk()
    End Interface

    Class Dog
        Implements IMammal

        Public Sub Speak() Implements IAnimal.Speak
            Console.WriteLine("Woof!")
        End Sub

        Public Sub Walk() Implements IMammal.Walk
            Console.WriteLine("The dog walks on four legs.")
        End Sub
    End Class

    Sub Main()
        Dim myDog As IMammal = New Dog()
        myDog.Speak()
        myDog.Walk()

        Console.ReadLine()
    End Sub
End Module
