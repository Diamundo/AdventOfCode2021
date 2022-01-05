Imports System
Imports System.Collections.Generic

Namespace AdventOfCode2021

    Public MustInherit Class DayBase

        Public ReadOnly cInputFolder As String = "../../../../input/"

        Public ReadOnly Property cInputFile As String
            Get
                Return cInputFolder & "day" & DayNumber & If(cDebug, "-example", "") & ".txt"
            End Get
        End Property

        Private items As List(Of String)
        Public ReadOnly Property GetInput As List(Of String)
            Get
                If items Is Nothing Then
                    items = New List(Of String)
                    For Each item As String In IO.File.ReadAllLines(cInputFile)
                        items.add(item)
                    Next
                End If
                Return items
            End Get
        End Property

        Public MustOverride ReadOnly Property DayNumber() As Integer

        Public MustOverride Function PartOne() As Integer

        Public MustOverride Function PartTWo() As Integer

    End Class

End Namespace

'Namespace AdventOfCode2021
'    Public Class Day
'        Inherits DayBase

'        Public Overrides ReadOnly Property DayNumber As Integer = 

'        Public Overrides Function PartOne() As Integer
'            For Each line As String In IO.File.ReadAllLines(cInputFile)
'            Next

'            Return -1
'        End Function

'        Public Overrides Function PartTWo() As Integer
'            For Each line As String In IO.File.ReadAllLines(cInputFile)
'            Next

'            Return -1
'        End Function
'    End Class
'End Namespace
