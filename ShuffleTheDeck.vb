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



        Do



            Console.WriteLine("Press enter to receive a card, Type S to shuffle, or type Q to quit. ")
            'Add 1 to the number of cards dealt.
            cardsDealt += 1

            Console.WriteLine(StrDup(4, vbTab) & "Cards Dealt: " & cardsDealt)


            'Do loop sets a Random Row, Random Column of the table to true  
            goodData = False
            Do Until goodData = True
                randomColumn = CInt(Int((4 * Rnd())))
                randomRow = CInt(Int((13 * Rnd())))

                If Not currentArray(randomRow, randomColumn) = True Then
                    currentArray(randomRow, randomColumn) = True
                    goodData = True

                    'If Row, Column chosen is already true the loop restarts
                ElseIf goodData = False Then

                End If
            Loop

            'If statements select the cards number suite based of Row and Column 

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

            'Writes Random card determined.
            Console.WriteLine(cardValue & " Of " & suite)


            'Automatic card shuffle when 52 cards are dealt.
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

            'Select case allows quit or shuffle at any time 
            Select Case Console.ReadLine()
                Case "Q"
                    Exit Sub
                Case "S"
                    Console.WriteLine(StrDup(4, vbTab) & "Cards Shuffled")
                    For row = 0 To 12
                        For column = 0 To 3
                            currentArray(row, column) = False
                        Next
                        cardsDealt = 0
                    Next

                    Console.ReadLine()
            End Select



            Console.Clear()
        Loop

    End Sub

End Module











