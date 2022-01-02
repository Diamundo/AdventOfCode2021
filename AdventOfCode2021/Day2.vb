Namespace AdventOfCode2021
    Public Class Day2
        Inherits DayBase

        Public Overrides ReadOnly Property DayNumber As Integer = 2

        Public Overrides Function PartOne() As Integer
            Dim x, y As Integer

            For Each line As String In IO.File.ReadAllLines(cInputFile)
                With line.Split(" ")
                    Dim move As Integer = Integer.Parse(.GetValue(1))
                    Select Case .GetValue(0)
                        Case "forward"
                            If cDebug Then Console.WriteLine("Day 2: line = '" & line & "' > x(" & x & ") + " & move & " = " & (x + move))
                            x += move
                        Case "down"
                            If cDebug Then Console.WriteLine("Day 2: line = '" & line & "   ' > y(" & y & ") + " & move & " = " & (y + move))
                            y += move 'We're on a submarine, so down INCREASES depth.
                        Case "up"
                            If cDebug Then Console.WriteLine("Day 2: line = '" & line & "     ' > y(" & y & ") - " & move & " = " & (y - move))
                            y -= move 'We're on a submarine, so up DECREASES depth
                    End Select
                End With
            Next

            Return x * y
        End Function

        Public Overrides Function PartTWo() As Integer
            Dim x, y, aim As Integer

            For Each line As String In IO.File.ReadAllLines(cInputFile)
                With line.Split(" ")
                    Dim move As Integer = Integer.Parse(.GetValue(1))
                    Select Case .GetValue(0)
                        Case "forward"
                            If cDebug Then Console.WriteLine("Day 2: line = '" & line & "' > x(" & x & ") + " & move & " = " & (x + move))
                            If cDebug Then Console.WriteLine("Day 2: line = '" & line & "' > y(" & y & ") + (" & aim & "*" & move & ") = " & y + (aim * move))
                            x += move
                            y += (aim * move)
                        Case "down"
                            If cDebug Then Console.WriteLine("Day 2: line = '" & line & "   ' > aim(" & aim & ") + " & move & " = " & (aim + move))
                            aim += move
                        Case "up"
                            If cDebug Then Console.WriteLine("Day 2: line = '" & line & "     ' > aim(" & aim & ") - " & move & " = " & (aim - move))
                            aim -= move
                    End Select
                End With
            Next

            Return x * y
        End Function
    End Class
End Namespace
