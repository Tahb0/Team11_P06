' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338) 
' Team Member 3 Details: Chaza, MC (222004099) 
' Team Member 4 Details: MAHLALELA LO (222221642) 
' Practical: Team Project 
' Class name: (Disease) 
' *****************************************************************

'option statements
Option Explicit On
Option Strict On
Option Infer Off
Public MustInherit Class Disease

    '       member variables 
    Private _stage As Integer
    Private _name As String

    '       >>> constructors  <<<
    Public Sub New()

    End Sub

    Public Sub New(stage As Integer)

        'make sure the stage is between 1 and 4
        _stage = EnforceStageVal(stage)

    End Sub

    '       >>> Property <<<
    Public Property DName() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Stage() As Integer
        Get
            Return _stage
        End Get
        Set(value As Integer)

            _stage = EnforceStageVal(value)

        End Set
    End Property

    '       >>> Methods <<<
    '           >> Utility  <<
    Private Function EnforceStageVal(ByRef Stage As Integer) As Integer
        If Stage < 1 Then
            Stage = 1
        Else
            If Stage > 4 Then
                Stage = 4
            End If

        End If

        Return Stage
    End Function

    '   >>> MustOverrideMethod <<<
    Public MustOverride Function DetermineTreatment() As String


End Class
