'Tori Gomez
'RCET0265
'Spring 2021
'Simple Calculator
'https://github.com/ToriGomez/SimpleCalculator.git

Option Explicit On
Option Strict On
Option Compare Binary

Module SimpleCalculator

    Sub Main()
        Dim userInput As String
        Dim firstNumber As Decimal
        Dim secondNumber As Decimal
        Dim problem As Boolean = False



        Console.WriteLine("HELLO! Welcome to Simple Calculator! Select 2 numbers to add or multiply. 
                           Press Enter to START!")

        Console.ReadLine()

        Console.WriteLine("Type a number and Press Enter")
        Try
            userInput = Console.ReadLine()
            firstNumber = CInt(userInput)
        Catch ex As Exception
            problem = True
            Console.Clear()
            Console.WriteLine("ERROR!")
            Console.Beep(500, 700)
        End Try

        Console.WriteLine("Type another number and Press Enter")
        Try
            userInput = Console.ReadLine()
            secondNumber = CInt(userInput)
        Catch ex As Exception
            problem = True
            Console.Clear()
            Console.WriteLine("ERROR!")
            Console.Beep(500, 700)
        End Try


        If problem = True Then
            Console.WriteLine("Try again later. Have a good day!")
            Console.ReadLine()
            End
        End If

        Console.WriteLine()
        Console.WriteLine($"You entered {firstNumber} and {secondNumber}")
        Console.WriteLine()

        Console.WriteLine("type 1 to ADD or 2 to MULTIPLY")
        userInput = Console.ReadLine()


        If userInput = "1" Then
            Console.WriteLine()
            Console.WriteLine("Your answer is =")
            Console.WriteLine((CInt(firstNumber)) + (CInt(secondNumber)))
            Console.WriteLine()
            Console.WriteLine("Thank You!")
            Console.ReadLine()
            End
        End If

        If userInput = "2" Then
            Console.WriteLine()
            Console.WriteLine("Your answer is =")
            Console.WriteLine((CInt(firstNumber)) * (CInt(secondNumber)))
            Console.WriteLine()
            Console.WriteLine("Thank You!")
            Console.ReadLine()
            End
        End If



        Console.Read()

    End Sub

End Module
