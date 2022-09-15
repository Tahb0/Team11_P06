' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338)
' Team Member 3 Details: Chaza, MC (222004099)
' Team Member 4 Details: e.g. Smith, J (202000001) 
' Practical: Team Project 
' Class name: (Tuberculosis) 
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off

Public Class Tuberculosis
    'Attributes of TB
    Inherits Disease

    Private _Vaccinated As Boolean 'To get weather the person is vaccinated or not.

    Private _Treatment As String

    ' Constructor 
    Public Sub New()
        _Treatment = ""
    End Sub

    Public Sub New(stage As Integer)
        MyBase.New(stage)
    End Sub

    Public Property Vaccinated() As Boolean
        Get
            Return _Vaccinated
        End Get
        Set(value As Boolean)
            _Vaccinated = value
        End Set
    End Property

    Public Property Treatment() As String
        Get
            Return _Treatment
        End Get
        Set(value As String)
            _Treatment = value
        End Set
    End Property

    ' methods 
    Public Overrides Function DetermineTreatment() As String

        If Stage = 1 And Vaccinated = True Then
            Treatment = "INH"
        End If
        If Stage = 1 And Vaccinated = False Then
            Treatment = "INH, RPT & Isol"
        End If
        If Stage = 2 And Vaccinated = True Then
            _Treatment = "RIF & RPT"
        End If
        If Stage = 2 And Vaccinated = False Then
            Treatment = "INH, RIF & RPT"
        End If
        If Stage = 3 And Vaccinated = True Then
            Treatment = "PZA, RIF & RPT"
        End If
        If Stage = 3 And Vaccinated = False Then
            Treatment = "PZA, EMB & RPT"
        End If
        Return Treatment
    End Function
    'This method will calculate the number o people who are not vaccinated.
    Public Function CalcNonVaccinated() As Integer

        Dim NumPpl As Integer ' Number of people who are not vaccinated 
        NumPpl = 0
        If Vaccinated = False Then
            NumPpl += 1
        End If
        Return NumPpl
    End Function
End Class
