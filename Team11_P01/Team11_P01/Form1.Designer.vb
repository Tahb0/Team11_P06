<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiseaseMonitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GrdDiseaseMonitor = New UJGrid.UJGrid()
        Me.SuspendLayout()
        '
        'GrdDiseaseMonitor
        '
        Me.GrdDiseaseMonitor.FixedCols = 1
        Me.GrdDiseaseMonitor.FixedRows = 1
        Me.GrdDiseaseMonitor.Location = New System.Drawing.Point(237, 117)
        Me.GrdDiseaseMonitor.Name = "GrdDiseaseMonitor"
        Me.GrdDiseaseMonitor.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.GrdDiseaseMonitor.Size = New System.Drawing.Size(229, 150)
        Me.GrdDiseaseMonitor.TabIndex = 0
        '
        'frmDiseaseMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GrdDiseaseMonitor)
        Me.Name = "frmDiseaseMonitor"
        Me.Text = "Disease Monitor "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrdDiseaseMonitor As UJGrid.UJGrid
End Class
