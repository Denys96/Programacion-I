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
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.lblRespuestaRomano = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(12, 85)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(42, 13)
        Me.lblnumero.TabIndex = 1
        Me.lblnumero.Text = "Capital:"
        '
        'lblRespuestaRomano
        '
        Me.lblRespuestaRomano.AutoSize = True
        Me.lblRespuestaRomano.Location = New System.Drawing.Point(169, 85)
        Me.lblRespuestaRomano.Name = "lblRespuestaRomano"
        Me.lblRespuestaRomano.Size = New System.Drawing.Size(99, 13)
        Me.lblRespuestaRomano.TabIndex = 3
        Me.lblRespuestaRomano.Text = "Numero Romano: ?"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(60, 82)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 6
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(73, 159)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(109, 29)
        Me.btncalcular.TabIndex = 8
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(296, 257)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblRespuestaRomano)
        Me.Controls.Add(Me.lblnumero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnumero As Label
    Friend WithEvents lblRespuestaRomano As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents btncalcular As Button
End Class
