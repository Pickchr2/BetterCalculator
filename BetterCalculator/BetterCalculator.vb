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
    Dim userQuits As Boolean = False
    Sub Main(args As String())
        Dim userInput As String = ""
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim desiredOperation As String = ""
        Dim mathResult As Integer

        Do Until userQuits = True
            Console.WriteLine("Please enter two whole numbers to perform arithmetic. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")
            firstNumber = AcceptFirstNumber(firstNumber)
            secondNumber = AcceptSecondNumber(secondNumber)
        Loop
    End Sub

    Function AcceptFirstNumber(_firstNumber As Integer) As Integer
        Dim userInput As String

        If userQuits = False Then
            Console.WriteLine("First number?")
            userInput = Console.ReadLine()
            Try
                _firstNumber = CInt(userInput)
            Catch ex As Exception
                Select Case userInput
                    Case "Q"
                        userQuits = True
                    Case Else
                        Console.WriteLine("Sorry, that is not a whole number.")
                        _firstNumber = AcceptFirstNumber(_firstNumber)
                End Select
            End Try
        End If
        Return _firstNumber
    End Function

    Function AcceptSecondNumber(_secondNumber As Integer) As Integer
        Dim userInput As String

        If userQuits = False Then
            Console.WriteLine("Second number?")
            userInput = Console.ReadLine()
            Try
                _secondNumber = CInt(userInput)
            Catch ex As Exception
                Select Case userInput
                    Case "Q"
                        userQuits = True
                    Case Else
                        Console.WriteLine("Sorry, that is not a whole number.")
                        _secondNumber = AcceptSecondNumber(_secondNumber)
                End Select
            End Try
        End If
        Return _secondNumber
    End Function
End Module
