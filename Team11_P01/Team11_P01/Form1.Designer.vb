<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiseaseMonitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCaputure = New System.Windows.Forms.Button()
        Me.grdPatientMonitor = New UJGrid.UJGrid()
        Me.btnSetUp = New System.Windows.Forms.Button()
        Me.btnAvailPatients = New System.Windows.Forms.Button()
        Me.btnChooseP = New System.Windows.Forms.Button()
        Me.txtAveWeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCaputure
        '
        Me.btnCaputure.Location = New System.Drawing.Point(24, 64)
        Me.btnCaputure.Name = "btnCaputure"
        Me.btnCaputure.Size = New System.Drawing.Size(119, 41)
        Me.btnCaputure.TabIndex = 0
        Me.btnCaputure.Text = "Capture Input"
        Me.btnCaputure.UseVisualStyleBackColor = True
        '
        'grdPatientMonitor
        '
        Me.grdPatientMonitor.FixedCols = 1
        Me.grdPatientMonitor.FixedRows = 1
        Me.grdPatientMonitor.Location = New System.Drawing.Point(149, 12)
        Me.grdPatientMonitor.Name = "grdPatientMonitor"
        Me.grdPatientMonitor.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdPatientMonitor.Size = New System.Drawing.Size(535, 187)
        Me.grdPatientMonitor.TabIndex = 1
        '
        'btnSetUp
        '
        Me.btnSetUp.Location = New System.Drawing.Point(24, 17)
        Me.btnSetUp.Name = "btnSetUp"
        Me.btnSetUp.Size = New System.Drawing.Size(119, 41)
        Me.btnSetUp.TabIndex = 2
        Me.btnSetUp.Text = "Set Up"
        Me.btnSetUp.UseVisualStyleBackColor = True
        '
        'btnAvailPatients
        '
        Me.btnAvailPatients.Location = New System.Drawing.Point(24, 111)
        Me.btnAvailPatients.Name = "btnAvailPatients"
        Me.btnAvailPatients.Size = New System.Drawing.Size(119, 41)
        Me.btnAvailPatients.TabIndex = 3
        Me.btnAvailPatients.Text = "View Available Patients"
        Me.btnAvailPatients.UseVisualStyleBackColor = True
        '
        'btnChooseP
        '
        Me.btnChooseP.Location = New System.Drawing.Point(24, 158)
        Me.btnChooseP.Name = "btnChooseP"
        Me.btnChooseP.Size = New System.Drawing.Size(119, 41)
        Me.btnChooseP.TabIndex = 4
        Me.btnChooseP.Text = "Choose Patient"
        Me.btnChooseP.UseVisualStyleBackColor = True
        '
        'txtAveWeight
        '
        Me.txtAveWeight.Location = New System.Drawing.Point(236, 210)
        Me.txtAveWeight.Name = "txtAveWeight"
        Me.txtAveWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtAveWeight.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Average Weight"
        '
        'frmDiseaseMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 427)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAveWeight)
        Me.Controls.Add(Me.btnChooseP)
        Me.Controls.Add(Me.btnAvailPatients)
        Me.Controls.Add(Me.btnSetUp)
        Me.Controls.Add(Me.grdPatientMonitor)
        Me.Controls.Add(Me.btnCaputure)
        Me.Name = "frmDiseaseMonitor"
        Me.Text = "Patients Records "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCaputure As Button
    Friend WithEvents grdPatientMonitor As UJGrid.UJGrid
    Friend WithEvents btnSetUp As Button
    Friend WithEvents btnAvailPatients As Button
    Friend WithEvents btnChooseP As Button
    Friend WithEvents txtAveWeight As TextBox
    Friend WithEvents Label1 As Label
End Class
