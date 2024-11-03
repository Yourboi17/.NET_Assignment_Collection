<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGenerateSeries = New System.Windows.Forms.Button()
        Me.lstSeries = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGenerateSeries
        '
        Me.btnGenerateSeries.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnGenerateSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateSeries.Location = New System.Drawing.Point(76, 66)
        Me.btnGenerateSeries.Name = "btnGenerateSeries"
        Me.btnGenerateSeries.Size = New System.Drawing.Size(112, 64)
        Me.btnGenerateSeries.TabIndex = 0
        Me.btnGenerateSeries.Text = "Generate Series"
        Me.btnGenerateSeries.UseVisualStyleBackColor = False
        '
        'lstSeries
        '
        Me.lstSeries.BackColor = System.Drawing.Color.Beige
        Me.lstSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSeries.FormattingEnabled = True
        Me.lstSeries.ItemHeight = 18
        Me.lstSeries.Location = New System.Drawing.Point(76, 169)
        Me.lstSeries.Name = "lstSeries"
        Me.lstSeries.Size = New System.Drawing.Size(357, 166)
        Me.lstSeries.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstSeries)
        Me.Controls.Add(Me.btnGenerateSeries)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerateSeries As Button
    Friend WithEvents lstSeries As ListBox
End Class
