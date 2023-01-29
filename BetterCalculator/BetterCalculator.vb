'Christopher Pickens
'RCET0265
'Spring 2023
'Better Calculator
'https://github.com/Pickchr2/BetterCalculator.git

Option Explicit On
Option Strict On
Option Compare Text

Imports System

Module BetterCalculator
    Dim userQuits As Boolean = False
    Sub Main(args As String())
        Dim userInput As String = ""
        Dim firstNumber As Long
        Dim secondNumber As Long
        Dim desiredOperation As String = ""

        Do Until userQuits = True
            Console.WriteLine("Please enter two whole numbers to perform arithmetic. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")
            firstNumber = AcceptFirstNumber(firstNumber)
            secondNumber = AcceptSecondNumber(secondNumber)
            desiredOperation = AcceptDesiredOperation(desiredOperation)
            PerformMath(firstNumber, secondNumber, desiredOperation)
        Loop
    End Sub

    Function AcceptFirstNumber(_firstNumber As Long) As Long
        Dim userInput As String

        If userQuits = False Then
            Console.WriteLine("First number?")
            userInput = Console.ReadLine()
            Try
                _firstNumber = CLng(userInput)
            Catch ex As Exception
                Select Case userInput
                    Case "Q"
                        userQuits = True
                    Case Else
                        Console.WriteLine($"Sorry, {userInput} is not a whole number.")
                        _firstNumber = AcceptFirstNumber(_firstNumber)
                End Select
            End Try
        End If
        Return _firstNumber
    End Function

    Function AcceptSecondNumber(_secondNumber As Long) As Long
        Dim userInput As String

        If userQuits = False Then
            Console.WriteLine("Second number?")
            userInput = Console.ReadLine()
            Try
                _secondNumber = CLng(userInput)
            Catch ex As Exception
                Select Case userInput
                    Case "Q"
                        userQuits = True
                    Case Else
                        Console.WriteLine($"Sorry, {userInput} is not a whole number.")
                        _secondNumber = AcceptSecondNumber(_secondNumber)
                End Select
            End Try
        End If
        Return _secondNumber
    End Function

    Function AcceptDesiredOperation(_desiredOperation As String) As String
        If userQuits = False Then
            Console.WriteLine("Please choose your desired operation. Enter an option below:")
            Console.WriteLine("1: +")
            Console.WriteLine("2: -")
            Console.WriteLine("3: *")
            Console.WriteLine("4: /")
            _desiredOperation = Console.ReadLine()
            Select Case _desiredOperation
                Case "Q"
                    userQuits = True
                Case "1"
                    _desiredOperation = "+"
                Case "2"
                    _desiredOperation = "-"
                Case "3"
                    _desiredOperation = "*"
                Case "4"
                    _desiredOperation = "/"
                Case Else
                    Console.WriteLine($"Sorry, {_desiredOperation} is not a valid choice.")
                    _desiredOperation = AcceptDesiredOperation(_desiredOperation)
            End Select
        End If
        Return _desiredOperation
    End Function

    Sub PerformMath(_firstNumber As Long, _secondNumber As Long, _desiredOperation As String)
        Dim mathResult As Decimal

        If userQuits = False Then
            Select Case _desiredOperation
                Case "+"
                    Try
                        mathResult = _firstNumber + _secondNumber
                        Console.WriteLine($"{_firstNumber} {_desiredOperation} {_secondNumber} = {mathResult}")
                    Catch ex As Exception
                        Console.WriteLine("Result is too large to compute.")
                    End Try
                Case "-"
                    Try
                        mathResult = _firstNumber - _secondNumber
                        Console.WriteLine($"{_firstNumber} {_desiredOperation} {_secondNumber} = {mathResult}")
                    Catch ex As Exception
                        Console.WriteLine("Result is too large to compute.")
                    End Try
                Case "*"
                    Try
                        mathResult = _firstNumber * _secondNumber
                        Console.WriteLine($"{_firstNumber} {_desiredOperation} {_secondNumber} = {mathResult}")
                    Catch ex As Exception
                        Console.WriteLine("Result is too large to compute.")
                    End Try
                Case "/"
                    Try
                        mathResult = CDec(_firstNumber / _secondNumber)
                        Console.WriteLine($"{_firstNumber} {_desiredOperation} {_secondNumber} = {mathResult}")
                    Catch ex As Exception
                        Console.WriteLine("Result is too large to compute.")
                    End Try
            End Select
        End If
    End Sub
End Module
