' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: Surname, Initials (Student #) 
' Team Member 3 Details: Surname, Initials (Student #) 
' Team Member 4 Details: e.g. Smith, J (202000001) 
' Practical: Team Project 
' Class name: (Disease) 
' *****************************************************************

'option statements
Option Explicit On
Option Strict On
Option Infer Off
Public MustInherit Class Disease

    '       member variables 
    Private _nIll As Integer 'num ill people
    Private _nCured As Integer 'per year?
    Private _nDied As Integer

    Private _nAvailableMeds As Integer
    Private _nMedsInShortage As Integer

    '       >>> shared variables  <<<
    Public Shared shrdTotIll As Integer 'total ill from all diseases
    Public Shared shrdTotCured As Integer
    Public Shared shrdTodDied As Integer

    '       >>> constructors  <<<
    Public Sub New()

    End Sub

    Public Sub New(numIll As Integer, numCured As Integer,
                   numDied As Integer)

        _nIll = numIll
        _nCured = numCured
        _nDied = numDied

    End Sub

    '       >>> Property <<<
    Public ReadOnly Property NumIll As Integer
        Get
            Return _nIll
        End Get
    End Property

    Public ReadOnly Property NumCured As Integer
        Get
            Return _nCured
        End Get
    End Property

    Public ReadOnly Property NumDied As Integer
        Get
            Return _nDied
        End Get
    End Property

    Public Property AvailableMeds As Integer
        Get
            Return _nAvailableMeds
        End Get
        Set(value As Integer)
            'validate the input
            If (value < 0) Then
                _nAvailableMeds = 0
            Else
                _nAvailableMeds = value
            End If
        End Set
    End Property

    '       >>> Methods <<<
    Private Sub CalcNumShortOfMeds()  'utility Method
        If _nAvailableMeds < _nIll Then
            _nMedsInShortage = -(_nIll - _nAvailableMeds) 'to make the number +

        Else
            _nMedsInShortage = _nIll - _nAvailableMeds
        End If

    End Sub

    'a function to get the number of meds in shortage
    Public Function getNumMedsInShortage() As Integer
        'first calculate
        CalcNumShortOfMeds()

        Return _nMedsInShortage
    End Function

    '   >>> MustOverrideMethod <<<
    Public MustOverride Function DetermineTreatment() As String

End Class
