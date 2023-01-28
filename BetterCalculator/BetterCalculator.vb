'Christopher Pickens
'RCET0265
'Spring 2023
'Better Calculator
'https://github.com/Pickchr/BetterCalculator.Git

Option Explicit On
Option Strict On
Option Compare Text

Imports System

Module BetterCalculator
    Sub Main(args As String())
        Dim userQuits As Boolean = False
        Dim userInput As String = ""
        Do Until userQuits = True
            Console.WriteLine("Please enter two numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")

            Select Case userInput
                Case "Q"
                    userQuits = True
                Case Else

            End Select
        Loop
    End Sub
End Module
