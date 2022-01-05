Imports System
Imports System.Linq
Imports System.Collections.Generic

Namespace AdventOfCode2021
    Public Class Day3
        Inherits DayBase

        Public Overrides ReadOnly Property DayNumber As Integer = 3

        Public Overrides Function PartOne() As Integer
            Dim bits As New List(Of Integer)
            Dim total As Integer = ComputeTotalDigits(GetInput(), bits)

            Dim g As String = ""
            For Each bit As Integer In bits
                If bit >= (total / 2) Then
                    g &= "1" 'most (== more than half) of the bits at this place are 1's
                Else
                    g &= "0"
                End If
            Next
            Dim e = g.Replace("0", "x").Replace("1", "0").Replace("x", "1") 'e = !g, basically.

            Dim gamma, epsilon As Integer
            gamma = Convert.ToInt32(g, 2) 'Convert string from Base # to integer. 
            epsilon = Convert.ToInt32(e, 2) 'Convert string from Base # to integer. 

            If cDebug Then Console.WriteLine("Day 3: g = (" & g & ") = " & gamma & ", e = (" & e & ") = " & epsilon)

            Return gamma * epsilon
        End Function

        Public Overrides Function PartTWo() As Integer
            Dim o As List(Of String) = GetInput
            Dim c As List(Of String) = GetInput
            Dim index As Integer = 0

            While o.Count > 1
                Dim bits As New List(Of Integer)
                cDebug = False
                Dim total As Integer = ComputeTotalDigits(o, bits)
                cDebug = True

                If bits(index) >= (total / 2) Then 'Most Common bit at index = 1
                    o = GetItemsWithBitAtIndex(o, index, 1)
                Else 'Most Common bit at index = 0
                    o = GetItemsWithBitAtIndex(o, index, 0)
                End If
                index += 1
            End While

            index = 0
            While c.Count > 1
                Dim bits As New List(Of Integer)
                cDebug = False
                Dim total As Integer = ComputeTotalDigits(c, bits)
                cDebug = True

                If bits(index) < (total / 2) Then 'Least Common bit at index = 1
                    c = GetItemsWithBitAtIndex(c, index, 1)
                Else 'Least Common bit at index = 0
                    c = GetItemsWithBitAtIndex(c, index, 0)
                End If
                index += 1
            End While

            Dim oxygen, co2 As Integer
            oxygen = Convert.ToInt32(o.First, 2)
            co2 = Convert.ToInt32(c.First, 2)
            If cDebug Then Console.WriteLine("Day 3: o = (" & o.First & ") = " & oxygen & ", c = (" & c.First & ") = " & co2)

            Return oxygen * co2
        End Function

        Private Function ComputeTotalDigits(items As List(Of String), ByRef bits As List(Of Integer)) As Integer
            Dim total As Integer = 0
            For Each line As String In items
                If cDebug Then Console.WriteLine("Day 3: line = " & line)
                For i As Integer = 0 To line.Length - 1
                    If bits.Count = i Then bits.Add(0)

                    bits.Item(i) += If(line.Substring(i, 1) = "1", 1, 0)
                    If cDebug Then Console.WriteLine("Day 3: bits = (" & String.Join(",", bits) & "), i=" & i & ", bit(i)=" & line.Substring(i, 1))
                Next
                total += 1
            Next
            If cDebug Then Console.WriteLine("Day 3: bits = (" & String.Join(",", bits) & "), total = " & total)

            Return total
        End Function

        Private Function GetItemsWithBitAtIndex(items As List(Of String), index As Integer, bit As Integer) As List(Of String)
            If items.Count = 1 Then Return items

            Dim result As New List(Of String)
            For Each item As String In items
                If item.Substring(index, 1).Equals(bit.ToString) Then
                    result.Add(item)
                End If
            Next
            If cDebug Then Console.WriteLine("Day 3: scanning for " & bit & " at index " & index & ". Found: " & String.Join(",", result))
            Return result
        End Function

    End Class
End Namespace
