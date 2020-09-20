'Ian Gunter
'RCET 0265
'ShuffleTheDeck
'Fall 2020
'https://github.com/IanGunter/ShuffleTheDeck.git


Option Strict On
Option Explicit On
Option Compare Text

Module ShuffleTheDeck

    Sub Main()
        Dim row As Integer = 12
        Dim column As Integer = 3
        Dim currentArray(row, column) As Boolean
        Dim randomColumn As Integer
        Dim randomRow As Integer
        Dim goodData As Boolean
        Dim suite As String
        Dim cardNumber As String
        Dim cardValue As String
        Dim cardsDealt As Integer
        Randomize()

        Console.WriteLine("Press enter to receive a card or type Q to quit. ")
        If Console.ReadLine() = "Q" Then Exit Sub

        Do
            If cardsDealt = 0 Then

            Else Console.WriteLine("Press enter to receive a card or type Q to quit. ")
                If Console.ReadLine() = "Q" Then Exit Sub
            End If


            cardsDealt += 1
            Console.WriteLine(StrDup(4, vbTab) & "Cards Dealt: " & cardsDealt)


            goodData = False
            Do Until goodData = True
                randomColumn = CInt(Int((4 * Rnd())))
                randomRow = CInt(Int((13 * Rnd())))

                If Not currentArray(randomRow, randomColumn) = True Then
                    currentArray(randomRow, randomColumn) = True
                    goodData = True

                ElseIf goodData = False Then

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

            If cardsDealt = 52 Then
                Console.WriteLine(StrDup(4, vbTab) & "Cards Shuffled")
                For row = 0 To 12
                    For column = 0 To 3
                        currentArray(row, column) = False
                    Next
                    cardsDealt = 0
                Next

            Else
            End If

            If Console.ReadLine() = "Q" Then Exit Sub
            Console.Clear()
        Loop

    End Sub

End Module











