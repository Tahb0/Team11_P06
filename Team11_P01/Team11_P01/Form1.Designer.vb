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
        Me.grdPatientMonitor.Location = New System.Drawing.Point(174, 12)
        Me.grdPatientMonitor.Name = "grdPatientMonitor"
        Me.grdPatientMonitor.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdPatientMonitor.Size = New System.Drawing.Size(229, 150)
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
        'frmDiseaseMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSetUp)
        Me.Controls.Add(Me.grdPatientMonitor)
        Me.Controls.Add(Me.btnCaputure)
        Me.Name = "frmDiseaseMonitor"
        Me.Text = "Patients Records "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCaputure As Button
    Friend WithEvents grdPatientMonitor As UJGrid.UJGrid
    Friend WithEvents btnSetUp As Button
End Class
