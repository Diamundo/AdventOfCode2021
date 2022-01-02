Imports System

Namespace AdventOfCode2021
    Module Program

        Public ReadOnly cDebug As Boolean = False

        Sub Main(args As String())
            Console.WriteLine("Hello World!")

            With New Day1
                Console.WriteLine("The answer to Day " & .DayNumber & " - Part One = " & .PartOne())
                Console.WriteLine("The answer to Day " & .DayNumber & " - Part Two = " & .PartTwo())
            End With

        End Sub

    End Module

End Namespace