' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338)
' Team Member 3 Details: Surname, Initials (Student #) 
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

    Private _Stage As Integer
    Private _Vaccinated As Boolean 'To get weather the person is vaccinated or not.

    ' Constructor 
    Public Sub New(numIll As Integer, numCured As Integer,
                   numDied As Integer)
        MyBase.New(numIll, numCured, numDied)
    End Sub

    ' Property methods 

    Public Property Stage() As Integer
        Get
            Return _Stage
        End Get
        Set(value As Integer)
            If value >= 1 Then
                _Stage = value
            End If
        End Set
    End Property

    Public Property Vaccinated() As Boolean
        Get
            Return _Vaccinated
        End Get
        Set(value As Boolean)
            _Vaccinated = value
        End Set
    End Property
    Public Overrides Function DetermineTreatment() As String
        Throw New NotImplementedException()
    End Function
End Class
