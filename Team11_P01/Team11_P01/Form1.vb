' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338)
' Team Member 3 Details: Chaza, MC (222004099) 
' Team Member 4 Details:MAHLALELA LO (222221642)
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

    'array to hold disease names 
    Private DiseaseName() As String = {"Tuberculosis",
                                       "Cancer",
                                       "HIV/Aids"}

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
            objPatient(p).PName = InputBox("Patient " & CStr(p) & " name: ")
            objPatient(p).PWeight = CDbl(InputBox("Patient " & CStr(p) & " weight(kg): "))

            For d As Integer = 1 To objPatient(p).numDiseases

                'prompt the user for the number disease 
                Dim diseaseInput As Integer = CInt(InputBox("Disease " & d & " is: " & vbNewLine &
                                                            "TB = 1" & vbNewLine &
                                                            "Cancer = 2" & vbNewLine &
                                                            "HIV/Aids = 3"))

                If diseaseInput = DiseaseRepresentation.Tb Then
                    'create a tb obj for the patient
                    Dim objTb As New Tuberculosis

                    'set the disease name 
                    objTb.DName = DiseaseName(DiseaseRepresentation.Tb - 1)

                    Dim isVaccinated As Char = CChar(InputBox("Is the patient Vaccinated?" & vbNewLine &
                                                          "Enter Y = Yes" & vbNewLine &
                                                          "N = No"))

                    If isVaccinated = "Y" Or isVaccinated = "y" Then
                        objTb.Vaccinated = True

                    Else
                        objTb.Vaccinated = False
                    End If

                    objTb.Stage = CInt(InputBox("What stage of TB(1-3):"))

                    'make sure the stage is between 1 and 3
                    If (objTb.Stage > 3) Then
                        objTb.Stage = 3
                    End If

                    'upcasting
                    objPatient(p).PDisease(d) = objTb

                Else
                    If diseaseInput = DiseaseRepresentation.Cancer Then
                        'create a cancer obj for the patient
                        Dim objCancer As New cancer

                        'set the disease name
                        objCancer.DName = DiseaseName(DiseaseRepresentation.Cancer - 1)

                        objCancer.Stage = CInt(InputBox("What stage of Cancer(1-4):"))

                        'upcasting
                        objPatient(p).PDisease(d) = objCancer
                    Else
                        If diseaseInput = DiseaseRepresentation.Aids Then
                            'create an HIV obj for the patient
                            Dim objHiv As New HIV

                            'set the disease name
                            objHiv.DName = DiseaseName(DiseaseRepresentation.Aids - 1)

                            objHiv.cd4_count = CInt(InputBox("What is the patient's CD4 " &
                                                         "count? (1 - 1500)"))
                            objHiv.Stage = CInt(InputBox("What is the stage? (1 - 3)"))

                            'upcast the hiv disease
                            objPatient(p).PDisease(d) = objHiv
                        End If
                    End If
                End If
            Next d

        Next p

        'display the average weight
        Dim aveW As Double = Patient.shrdTotWeight / nP
        txtAveWeight.Text = Format(aveW, "0.##")
    End Sub

    Private Sub btnAvailPatients_Click(sender As Object, e As EventArgs) Handles btnAvailPatients.Click

        'resize the grid
        grdPatientMonitor.Rows = 1
        grdPatientMonitor.Cols = nP + 1 'to number of patients

        PIG(0, 0, "ID, Name")

        'display the patient id and their name:
        For p As Integer = 1 To nP
            PIG(0, p, CStr(objPatient(p).patientId) & ", " & objPatient(p).PName)
        Next

    End Sub

    'a method to display patient info
    Private Sub DisplayP(objPatient As Patient)

        'resize and clear the grid
        PIG(0, 0, "")
        For p As Integer = 1 To nP
            PIG(0, p, "")
        Next

        grdPatientMonitor.Rows = 1 + 1 'upper row plus name row
        grdPatientMonitor.Cols = 1 + 1 + objPatient.numDiseases

        'rename grid and place the weight
        PIG(0, objPatient.numDiseases + 1, "Weight")
        PIG(1, objPatient.numDiseases + 1, Format(objPatient.PWeight, "0.##"))

        'place the name and id of patient in grid
        PIG(1, 0, objPatient.PName)

        'place the patient's information
        For d As Integer = 1 To objPatient.numDiseases

            PIG(0, d, objPatient.PDisease(d).DName & " Treatment")
            PIG(1, d, objPatient.PDisease(d).DetermineTreatment) 'polymorphism

        Next

    End Sub

    Private Sub btnChooseP_Click(sender As Object, e As EventArgs) Handles btnChooseP.Click
        Dim patientChoice As Integer

        patientChoice = CInt(InputBox("What is the Patient ID?"))

        For p As Integer = 1 To nP
            If patientChoice = objPatient(p).patientId Then
                'display the patient information
                DisplayP(objPatient(p))
            End If
        Next

    End Sub
End Class
