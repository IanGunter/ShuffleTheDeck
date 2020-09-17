'Ian Gunter
'RCET 0265
'ShuffleTheDeck
'Fall 2020
'


Option Strict On
Option Explicit On
Option Compare Text

Module ShuffleTheDeck

    Sub Main()
        Dim row As Integer = 12
        Dim column As Integer = 3
        Dim formattedstring As String
        Dim currentArray(row, column) As Boolean
        Dim randomColumn As Integer
        Dim randomRow As Integer
        Randomize()


        For i = 1 To 15
            randomColumn = CInt(Int((4 * Rnd())))
            randomRow = CInt(Int((13 * Rnd())))

            If Not currentArray(randomRow, randomColumn) = True Then
                currentArray(randomRow, randomColumn) = True
            Else
                Console.WriteLine($"Row{randomRow} Column{randomColumn}")
            End If

        Next

        For i = 0 To row
            For j = 0 To column
                formattedstring = $"{i},{j}"
                'Console.Write(formattedstring.PadRight(8))
                ' Console.Write(currentArray(row, column))
                If currentArray(i, j) Then
                    Console.Write(" T ")
                Else
                    Console.Write(" F ")
                End If
            Next

            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub

End Module
