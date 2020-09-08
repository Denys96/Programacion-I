<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbldepto = New System.Windows.Forms.Label()
        Me.lblmun = New System.Windows.Forms.Label()
        Me.cbodepto = New System.Windows.Forms.ComboBox()
        Me.cbomun = New System.Windows.Forms.ComboBox()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.cboarea = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbldepto
        '
        Me.lbldepto.AutoSize = True
        Me.lbldepto.Location = New System.Drawing.Point(10, 48)
        Me.lbldepto.Name = "lbldepto"
        Me.lbldepto.Size = New System.Drawing.Size(39, 13)
        Me.lbldepto.TabIndex = 1
        Me.lbldepto.Text = "Depto:"
        '
        'lblmun
        '
        Me.lblmun.AutoSize = True
        Me.lblmun.Location = New System.Drawing.Point(185, 48)
        Me.lblmun.Name = "lblmun"
        Me.lblmun.Size = New System.Drawing.Size(31, 13)
        Me.lblmun.TabIndex = 3
        Me.lblmun.Text = "Mun:"
        '
        'cbodepto
        '
        Me.cbodepto.FormattingEnabled = True
        Me.cbodepto.Location = New System.Drawing.Point(58, 45)
        Me.cbodepto.Name = "cbodepto"
        Me.cbodepto.Size = New System.Drawing.Size(121, 21)
        Me.cbodepto.TabIndex = 9
        '
        'cbomun
        '
        Me.cbomun.FormattingEnabled = True
        Me.cbomun.Location = New System.Drawing.Point(222, 45)
        Me.cbomun.Name = "cbomun"
        Me.cbomun.Size = New System.Drawing.Size(121, 21)
        Me.cbomun.TabIndex = 10
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Location = New System.Drawing.Point(349, 48)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(32, 13)
        Me.lblarea.TabIndex = 11
        Me.lblarea.Text = "Area:"
        '
        'cboarea
        '
        Me.cboarea.FormattingEnabled = True
        Me.cboarea.Location = New System.Drawing.Point(386, 45)
        Me.cboarea.Name = "cboarea"
        Me.cboarea.Size = New System.Drawing.Size(136, 21)
        Me.cboarea.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(534, 253)
        Me.Controls.Add(Me.cboarea)
        Me.Controls.Add(Me.lblarea)
        Me.Controls.Add(Me.cbomun)
        Me.Controls.Add(Me.cbodepto)
        Me.Controls.Add(Me.lblmun)
        Me.Controls.Add(Me.lbldepto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "combox dinamicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldepto As Label
    Friend WithEvents lblmun As Label
    Friend WithEvents cbodepto As ComboBox
    Friend WithEvents cbomun As ComboBox
    Friend WithEvents lblarea As Label
    Friend WithEvents cboarea As ComboBox
End Class
