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
        Me.lblteiempo = New System.Windows.Forms.Label()
        Me.lblcapital = New System.Windows.Forms.Label()
        Me.lblinteres = New System.Windows.Forms.Label()
        Me.lblinteresSimple = New System.Windows.Forms.Label()
        Me.lblinterescompuesto = New System.Windows.Forms.Label()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.txtcapital = New System.Windows.Forms.TextBox()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblteiempo
        '
        Me.lblteiempo.AutoSize = True
        Me.lblteiempo.Location = New System.Drawing.Point(291, 85)
        Me.lblteiempo.Name = "lblteiempo"
        Me.lblteiempo.Size = New System.Drawing.Size(78, 13)
        Me.lblteiempo.TabIndex = 0
        Me.lblteiempo.Text = "Tiempo (Años):"
        '
        'lblcapital
        '
        Me.lblcapital.AutoSize = True
        Me.lblcapital.Location = New System.Drawing.Point(12, 85)
        Me.lblcapital.Name = "lblcapital"
        Me.lblcapital.Size = New System.Drawing.Size(42, 13)
        Me.lblcapital.TabIndex = 1
        Me.lblcapital.Text = "Capital:"
        '
        'lblinteres
        '
        Me.lblinteres.AutoSize = True
        Me.lblinteres.Location = New System.Drawing.Point(169, 85)
        Me.lblinteres.Name = "lblinteres"
        Me.lblinteres.Size = New System.Drawing.Size(42, 13)
        Me.lblinteres.TabIndex = 2
        Me.lblinteres.Text = "Interes:"
        '
        'lblinteresSimple
        '
        Me.lblinteresSimple.AutoSize = True
        Me.lblinteresSimple.Location = New System.Drawing.Point(57, 163)
        Me.lblinteresSimple.Name = "lblinteresSimple"
        Me.lblinteresSimple.Size = New System.Drawing.Size(83, 13)
        Me.lblinteresSimple.TabIndex = 3
        Me.lblinteresSimple.Text = "Interes simple: ?"
        '
        'lblinterescompuesto
        '
        Me.lblinterescompuesto.AutoSize = True
        Me.lblinterescompuesto.Location = New System.Drawing.Point(291, 163)
        Me.lblinterescompuesto.Name = "lblinterescompuesto"
        Me.lblinterescompuesto.Size = New System.Drawing.Size(106, 13)
        Me.lblinterescompuesto.TabIndex = 4
        Me.lblinterescompuesto.Text = "Interes compuesto: ?"
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(214, 82)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(57, 20)
        Me.txtinteres.TabIndex = 5
        '
        'txtcapital
        '
        Me.txtcapital.Location = New System.Drawing.Point(60, 82)
        Me.txtcapital.Name = "txtcapital"
        Me.txtcapital.Size = New System.Drawing.Size(100, 20)
        Me.txtcapital.TabIndex = 6
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(375, 82)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(59, 20)
        Me.txtTiempo.TabIndex = 7
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(172, 224)
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
        Me.ClientSize = New System.Drawing.Size(572, 357)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.txtcapital)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.lblinterescompuesto)
        Me.Controls.Add(Me.lblinteresSimple)
        Me.Controls.Add(Me.lblinteres)
        Me.Controls.Add(Me.lblcapital)
        Me.Controls.Add(Me.lblteiempo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblteiempo As Label
    Friend WithEvents lblcapital As Label
    Friend WithEvents lblinteres As Label
    Friend WithEvents lblinteresSimple As Label
    Friend WithEvents lblinterescompuesto As Label
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents txtcapital As TextBox
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents btncalcular As Button
End Class
