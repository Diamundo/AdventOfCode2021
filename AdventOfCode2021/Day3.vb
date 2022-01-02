Namespace AdventOfCode2021
    Public Class Day3
        Inherits DayBase

        Public Overrides ReadOnly Property DayNumber As Integer = 3

        Public Overrides Function PartOne() As Integer

            Dim bits As New List(Of Integer)
            Dim total As Integer = 0
            For Each line As String In IO.File.ReadAllLines(cInputFile)
                If cDebug Then Console.WriteLine("Day 3: line = " & line)
                For i As Integer = 0 To line.Length - 1
                    If bits.Count = i Then bits.Add(0)

                    bits.Item(i) += If(line.Substring(i, 1) = "1", 1, 0)
                    If cDebug Then Console.WriteLine("Day 3: bits = (" & String.Join(",", bits) & "), i=" & i & ", bit(i)=" & line.Substring(i, 1))
                Next
                total += 1
            Next
            If cDebug Then Console.WriteLine("Day 3: bits = (" & String.Join(",", bits) & "), total = " & total)

            Dim g, e As String
            For Each bit As Integer In bits
                If bit > (total / 2) Then
                    g &= "1" 'most (== more than half) of the bits at this place are 1's
                    e &= "0"
                Else
                    g &= "0"
                    e &= "1"
                End If
            Next

            Dim gamma, epsilon As Integer
            gamma = Convert.ToInt32(g, 2) 'Convert string from Base # to integer. 
            epsilon = Convert.ToInt32(e, 2) 'Convert string from Base # to integer. 

            If cDebug Then Console.WriteLine("Day 3: g = (" & g & ") = " & gamma & ", e = (" & e & ") = " & epsilon)

            Return gamma * epsilon
        End Function

        Public Overrides Function PartTWo() As Integer
            For Each line As String In IO.File.ReadAllLines(cInputFile)
            Next

            Return -1
        End Function
    End Class
End Namespace
