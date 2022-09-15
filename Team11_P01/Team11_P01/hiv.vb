' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338) 
' Team Member 3 Details: Chaza, MC (222004099) 
' Team Member 4 Details: MAHLALELA LO(222221642) 
' Practical: Team Project 
' Class name: (HIV) 
' *****************************************************************
'option  statements
Option Strict On
Option Explicit On
Option Infer Off

Public Class HIV

    'derived class  inheriting attributes and methods from the abstract class
    Inherits Disease

    'attributes 
    Private _CD4_COUNT As Integer
    Private _typeofHIV As Integer
    Private _answer As String

    ' Constructor 
    Public Sub New(type As Integer)
        MyBase.New(type)
    End Sub

    'Property methods 



    Public Property cd4_count As Integer
        Get
            Return _CD4_COUNT
        End Get
        Set(value As Integer)
            _CD4_COUNT = value
        End Set
    End Property

    Public Property typeofhiv As Integer
        Get
            Return _typeofHIV
        End Get
        Set(value As Integer)
            _typeofHIV = value
        End Set
    End Property
    Public Property answer() As String
        Get
            Return _answer
        End Get
        Set(value As String)
            _answer = value
        End Set
    End Property

    ' function to determine type of treatment 
    Public Overrides Function DetermineTreatment() As String



        If cd4_count < 500 Then
            answer = "ANTIRETROVIRAL THERAPY"
        Else
            If cd4_count >= 500 And cd4_count < 1500 Then
                answer = "SHOTS"
            End If
        End If

        Return answer
    End Function

    'function to calculate average cd4count of patient
    Public Function Calcaverage() As Double
        Dim numhiv As Integer  ' people with hiv 
        Dim average_count As Double
        Dim total As Integer = 0 ' initialising toltal to 0
        For h As Integer = 1 To numhiv
            total += numhiv
            average_count = _CD4_COUNT / numhiv
        Next
        Return average_count
    End Function

End Class
