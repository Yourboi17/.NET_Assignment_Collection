Module Module1
    Sub Main()
        Dim arrayList As New ArrayList()
        arrayList.Add("Apple")
        arrayList.Add("Banana")
        arrayList.Add("Cherry")

        Console.WriteLine("ArrayList contents:")
        For Each item In arrayList
            Console.WriteLine(item)
        Next

        Dim dictionary As New Dictionary(Of String, Integer)()
        dictionary.Add("Apple", 1)
        dictionary.Add("Banana", 2)
        dictionary.Add("Cherry", 3)

        Console.WriteLine(vbCrLf & "Dictionary contents:")
        For Each kvp In dictionary
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}")
        Next

        Console.ReadLine()
    End Sub
End Module
