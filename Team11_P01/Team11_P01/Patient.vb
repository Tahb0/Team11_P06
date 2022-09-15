' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338) 
' Team Member 3 Details: Chaza, MC (222004099) 
' Team Member 4 Details:MAHLALELA LO (222221642)
' Practical: Team Project 
' Class name: (Patient) 
' *****************************************************************

'option statements
Option Explicit On
Option Strict On
Option Infer Off

Public Class Patient

    'member variables
    Private _pName As String
    Private _pWeight As Double
    Private _pDisease() As Disease
    Private _nDiseases As Integer
    Private _HospitalId As Integer

    Private Shared HospitalId As Integer = 0


    Public Shared shrdTotWeight As Double = 0.0

    Public Sub New()
        givePatientId() 'each new patient gets a unique id

    End Sub

    Public Sub New(nDiseases As Integer)
        givePatientId()

        _nDiseases = nDiseases

        ReDim _pDisease(nDiseases) 'if a patient has more than 1 disease

    End Sub
    Public Sub New(patientName As String, patientWeight As Double, nDiseases As Integer)
        givePatientId() 'each new patient gets a unique id

        _pName = patientName
        _pWeight = patientWeight
        _nDiseases = nDiseases
    End Sub

    Public Property PName() As String
        Get
            Return _pName
        End Get
        Set(value As String)
            _pName = value
        End Set
    End Property

    Public Property PWeight() As Double
        Get
            Return _pWeight
        End Get
        Set(value As Double)

            'add to the total weight
            shrdTotWeight += value
            _pWeight = value
        End Set
    End Property

    'to get the diseases/ disease
    Public Property PDisease(index As Integer) As Disease
        Get
            Return _pDisease(index)
        End Get
        Set(value As Disease)
            _pDisease(index) = value
        End Set
    End Property
    Public ReadOnly Property patientId() As Integer
        Get
            Return _HospitalId 'to get the hospital id
        End Get
    End Property

    Public ReadOnly Property numDiseases() As Integer
        Get
            Return _nDiseases 'to get how many diseases a patient has
        End Get
    End Property



    'utility method to give each new patient a unique id
    Private Sub givePatientId()
        HospitalId += 1
        _HospitalId = HospitalId 'gives each patient an id
    End Sub


End Class
