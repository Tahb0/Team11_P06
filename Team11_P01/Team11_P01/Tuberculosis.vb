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

    Private _Treatment As String

    ' Constructor 
    Public Sub New()

    End Sub

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
            If value < 1 Then
                value = 0
            Else
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

        If _Stage = 1 And _Vaccinated = True Then
            _Treatment = "Four months of taking Isoniazid and Rifapentine as combination, in an Isolation."
        End If
        If _Stage = 1 And _Vaccinated = False Then
            _Treatment = "Nine months of taking Isoniazid and Rifapentine as combination, in an Isolation." & Environment.NewLine & "After getting cured, Patient must get vaccinated."
        End If
        If _Stage = 2 And _Vaccinated = True Then
            _Treatment = "Patient Must take combination of Rifampicin and Rifapentine."
        End If
        If _Stage = 2 And _Vaccinated = False Then
            _Treatment = "Patient must take combination of Isoniazid, Rifampicin and Rifapentine." & Environment.NewLine & "After getting cured, Patient must get vaccinated."
        End If
        If _Stage = 3 And _Vaccinated = True Then
            _Treatment = "Patient must take combination of Pyrazinamide, Rifampicin and Rifapentine."
        End If
        If _Stage = 3 And _Vaccinated = False Then
            _Treatment = "Patient must take combiantion of Pyrazinamide, Ethambutol and Rifapentine." & Environment.NewLine & "After getting cured, Patient must get vaccinated."
        End If
        Return _Treatment
    End Function


End Class
