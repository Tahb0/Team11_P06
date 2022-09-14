' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338)
' Team Member 3 Details: Chaza, MC (222004099) 
' Team Member 4 Details: e.g. Smith, J (202000001) 
' Practical: Team Project 
' Class name: (Form) 
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off

Enum DiseaseRepresentation
    Tb = 1
    Cancer
    Aids
End Enum

Public Class frmDiseaseMonitor

    Private nP As Integer
    Private objPatient() As Patient

    'a sub to place text in grid
    Private Sub PIG(r As Integer, c As Integer, t As String)

        grdPatientMonitor.Row = r
        grdPatientMonitor.Col = c
        grdPatientMonitor.Text = t

    End Sub

    Private Sub btnSetUp_Click(sender As Object, e As EventArgs) Handles btnSetUp.Click
        'prompt the user for the number of patients:
        nP = CInt(InputBox("The number of Patients: "))

        ReDim objPatient(nP)

        For p As Integer = 1 To nP

            'prompt the user for the number of diseases the patient has
            Dim nD As Integer = CInt(InputBox("The number of Diseases for patient " &
                                              p & ":"))

            objPatient(p) = New Patient(nD) 'redims the disease array/abs-class

        Next
    End Sub

    Private Sub btnCaputure_Click(sender As Object, e As EventArgs) Handles btnCaputure.Click

        'prompt the user for infomation about the patient
        For p As Integer = 1 To nP
            objPatient(p).PName = InputBox("Patient " & p & "name: ")
            objPatient(p).PWeight = CDbl("Patient " & p & "weight(kg): ")

            For d As Integer = 1 To objPatient(p).numDiseases

                'prompt the user for the number disease 
                Dim diseaseInput As Integer = CInt(InputBox("Disease " & d & " is: " & vbNewLine &
                                                            "TB = 1" & vbNewLine &
                                                            "Cancer = 2" & vbNewLine &
                                                            "HIV/Aids = 3"))

                If diseaseInput = DiseaseRepresentation.Tb Then
                    'create a tb obj for the patient
                    Dim objTb As New Tuberculosis
                    objTb.Stage = CInt(InputBox("What stage of tb(1-4):"))

                    'upcasting
                    objPatient(p).PDisease(d) = objTb

                Else
                    If diseaseInput = DiseaseRepresentation.Cancer Then
                        'create a cancer obj for the patient
                        Dim objCancer As New Cancer
                        objCancer.Stage = CInt(InputBox("What stage of Cancer(1-4):"))

                        'upcasting
                        objPatient(p).PDisease(d) = objCancer
                    Else
                        If diseaseInput = DiseaseRepresentation.Aids Then
                            'create a cancer obj for the patient

                        End If
                    End If
                End If
            Next d

        Next p
    End Sub


End Class
