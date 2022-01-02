Imports System

Namespace AdventOfCode2021
    Module Program

        Public cDebug As Boolean = True

        Sub Main(args As String())
            Do
                Console.Write("Day?       : ")
                Dim day = Integer.Parse(Console.ReadLine())
                Console.Write("Part?      : ")
                Dim part = Integer.Parse(Console.ReadLine())
                Console.Write("Debug? Y/n : ")
                cDebug = UserSaysYes()

                Console.WriteLine("")
                With DayX(day)
                    Select Case part
                        Case 1
                            Console.WriteLine("The answer to Day " & .DayNumber & " - Part One = " & .PartOne())
                        Case 2
                            Console.WriteLine("The answer to Day " & .DayNumber & " - Part Two = " & .PartTWo())
                    End Select
                End With

                Console.Write(vbCrLf & "Try again? Y/n :")
            Loop While UserSaysYes()
        End Sub

        Function UserSaysYes() As Boolean
            Dim input As String = Console.ReadLine
            Return (input = "" OrElse input.ToLower.Substring(0, 1).Equals("y"))
        End Function

        Function DayX(number As Integer) As DayBase
            Select Case number
                Case 1
                    Return New Day1
                Case 2
                    Return New Day2
                Case 3
                Case 4
                Case 5
                Case 6
                Case 7
                Case 8
                Case 9
                Case 0
                Case 11
                Case 12
                Case 13
                Case 14
                Case 15
                Case 16
                Case 17
                Case 18
                Case 19
                Case 20
                Case 21
                Case 22
                Case 23
                Case 24
                Case 25
            End Select
            Return Nothing
        End Function

    End Module

End Namespace