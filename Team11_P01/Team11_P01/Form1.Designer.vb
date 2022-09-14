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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UjGrid1 = New UJGrid.UJGrid()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UjGrid1
        '
        Me.UjGrid1.FixedCols = 1
        Me.UjGrid1.FixedRows = 1
        Me.UjGrid1.Location = New System.Drawing.Point(174, 12)
        Me.UjGrid1.Name = "UjGrid1"
        Me.UjGrid1.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.UjGrid1.Size = New System.Drawing.Size(229, 150)
        Me.UjGrid1.TabIndex = 1
        '
        'frmDiseaseMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UjGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmDiseaseMonitor"
        Me.Text = "Patients Records "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents UjGrid1 As UJGrid.UJGrid
End Class
