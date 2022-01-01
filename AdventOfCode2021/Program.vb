Imports System

Module Program

    Const cInputFolder As String = "../../../../input/"
    Const cDebug As Boolean = False

    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Console.WriteLine("The answer to Day 1 = " & Day1())

    End Sub

    Function Day1() As Integer
        Dim inputFile As String = cInputFolder & "day1.txt"
        Dim day1Input As New List(Of Integer)
        Dim currentDepth As Integer = -1
        Dim answer As Integer = -1

        For Each line As String In IO.File.ReadAllLines(inputFile)
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



End Module

