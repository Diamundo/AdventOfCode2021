Namespace AdventOfCode2021

    Public MustInherit Class DayBase

        Public ReadOnly cInputFolder As String = "../../../../input/"

        Public ReadOnly Property cInputFile As String
            Get
                Return cInputFolder & "day" & DayNumber & If(cDebug, "-example", "") & ".txt"
            End Get
        End Property

        Public MustOverride ReadOnly Property DayNumber() As Integer

        Public MustOverride Function PartOne() As Integer

        Public MustOverride Function PartTWo() As Integer

    End Class

End Namespace

'Namespace AdventOfCode2021
'    Public Class Day2
'        Inherits DayBase

'        Public Overrides ReadOnly Property DayNumber As Integer = 2

'        Public Overrides Function PartOne() As Integer

'            Return -1
'        End Function

'        Public Overrides Function PartTWo() As Integer

'            Return -1
'        End Function
'    End Class
'End Namespace
