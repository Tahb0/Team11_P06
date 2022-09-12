Public Class Cancer
    Inherits Disease

    'attribute
    Private _TypeOfCancer As String
    Private _Stage As Integer

    'properties
    Public ReadOnly Property typeOfCancer As String
        Get
            Return _TypeOfCancer
        End Get
    End Property

    Public Property Stage As Integer
        Get
            Return _Stage

        End Get
        Set(value As Integer)
            _Stage = value
        End Set
    End Property

    'constructor
    Public Sub New()

    End Sub

    Public Sub New(numIll As Integer, numCured As Integer,
                   numDied As Integer, s As Integer)
        MyBase.New(numIll, numDied, numCured)

        Stage = s
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
