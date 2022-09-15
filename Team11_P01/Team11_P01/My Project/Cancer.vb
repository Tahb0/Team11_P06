' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338) 
' Team Member 3 Details: Chaza, MC (222004099) 
' Team Member 4 Details: MAHLALELA LO (222221642) 
' Practical: Team Project 
' Class name: (Cancer) 
'

Option Strict On
Option Explicit On
Option Infer Off


Public Class cancer
    Inherits Disease
    'attribute
    Private _TypeOfCancer As String


    Public ReadOnly Property typeOfCancer As String
        Get
            Return _TypeOfCancer
        End Get
    End Property

    'constructor
    Public Sub New()

    End Sub


    Public Sub New(stage As Integer)
        MyBase.New(stage)
    End Sub


    'overriding function to get the type of treatment
    Public Overrides Function DetermineTreatment() As String
        Dim response As String
        response = ""
        If Stage = 1 Then
            response = "Radition & Meds"
        ElseIf Stage = 2 Then
            response = "Chemotherapy"
        ElseIf Stage <= 4 Then
            response = "Targeted therapy & Immunotherapy"

        End If
        Return response
    End Function
    '
    'this function calculates the number of people that need urgent treatment
    Public Function urgentTreatment() As Integer

        Dim counter As Integer = 0
        If Stage > 3 And Stage < 4 Then
            counter += 1
        End If
        Return counter

    End Function

    'this function calculates and displays the number of people that need medication and radiation
    Public Function addNeedMeds() As Integer
        Dim counter As Integer = 0
        If Stage < 2 Then
            counter += 1
        End If
        Return counter
    End Function

End Class
