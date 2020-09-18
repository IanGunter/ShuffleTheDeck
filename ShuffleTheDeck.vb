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
        Dim goodData As Boolean
        Dim suite As String
        Dim cardNumber As String
        Dim cardValue As String
        Randomize()

        Do

            randomColumn = CInt(Int((4 * Rnd())))
            randomRow = CInt(Int((13 * Rnd())))


            Do Until currentArray(randomRow, randomColumn) = False
                If Not currentArray(randomRow, randomColumn) = True Then
                    currentArray(randomRow, randomColumn) = True

                Else
                    Console.WriteLine($"Row{randomRow} Column{randomColumn}")
                End If
            Loop


            cardNumber = CStr(randomRow + 1)
                If cardNumber = "11" Then
                    cardValue = "Jack"
                ElseIf cardNumber = "12" Then
                    cardValue = "King"
                ElseIf cardNumber = "13" Then
                    cardValue = "Queen"
                ElseIf cardNumber = "1" Then
                    cardValue = "Ace"
                Else cardValue = cardNumber

                End If


                If randomColumn = 0 Then
                    suite = "Spades"

                ElseIf randomColumn = 1 Then
                    suite = "Diamonds"

                ElseIf randomColumn = 2 Then
                    suite = "Hearts"

                ElseIf randomColumn = 3 Then
                    suite = "Clubs"


                End If
                Console.WriteLine(cardValue & " Of " & suite)
                Console.ReadLine()

            Loop
        ' For i = 0 To row
        'For j = 0 To column


        'formattedstring = $"{i},{j}"
        'Console.Write(formattedstring.PadRight(8))
        ' Console.Write(currentArray(row, column))
        'If currentArray(i, j) Then
        ' Console.Write(" T ")
        ' Else
        'Console.Write(" F ")
        ' End If
        'Next

        ' Console.WriteLine()
        ' Next

    End Sub

End Module
