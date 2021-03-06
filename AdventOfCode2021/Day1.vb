Namespace AdventOfCode2021

    Public Class Day1
        Inherits DayBase

        Public Overrides ReadOnly Property DayNumber As Integer = 1

        Overrides Function PartOne() As Integer
            Dim currentDepth As Integer = -1
            Dim answer As Integer = -1

            For Each line As String In IO.File.ReadAllLines(cInputFile)
                Dim depth = Integer.Parse(line)

                If answer < 0 Then
                    answer = 0
                    If cDebug Then Console.WriteLine("Day1: depth = " & depth & ", answer = N/A")
                ElseIf currentDepth < depth Then
                    answer += 1
                    If cDebug Then Console.WriteLine("Day1: depth = " & depth & ", answer = inc. " & answer)
                Else
                    If cDebug Then Console.WriteLine("Day1: depth = " & depth & ", answer = dec. " & answer)
                End If

                currentDepth = depth
            Next

            Return answer
        End Function

        Overrides Function PartTwo() As Integer
            Dim inputFile As String = cInputFolder & "day1.txt"
            Dim answer As Integer = 0
            Dim depths As New List(Of Integer)

            For Each line As String In IO.File.ReadAllLines(inputFile)
                Dim depth = Integer.Parse(line)

                depths.Add(depth)
                If depths.Count = 4 Then
                    Dim previousDepth As Integer = (depths(0) + depths(1) + depths(2))
                    Dim thisDepth As Integer = (depths(1) + depths(2) + depths(3))

                    If previousDepth < thisDepth Then
                        answer += 1
                        If cDebug Then Console.WriteLine("Day1Part2: depths = " & String.Join(",", depths) & ", A = " & previousDepth & ", B = " & thisDepth & ", inc")
                    Else

                        If cDebug Then Console.WriteLine("Day1Part2: depths = " & String.Join(",", depths) & ", A = " & previousDepth & ", B = " & thisDepth & ", dec")
                    End If

                    depths.RemoveAt(0) 'drop the oldest depth
                End If
            Next

            Return answer
        End Function


    End Class
End Namespace
