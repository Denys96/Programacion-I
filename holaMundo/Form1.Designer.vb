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
        Me.Btnmediaaritmetica = New System.Windows.Forms.Button()
        Me.lblseries = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.lblrespuestamedia = New System.Windows.Forms.Label()
        Me.lblmedia = New System.Windows.Forms.Label()
        Me.lblvarianza = New System.Windows.Forms.Label()
        Me.lblrespuestavarianza = New System.Windows.Forms.Label()
        Me.lbldesviaciontipica = New System.Windows.Forms.Label()
        Me.lblrespuestadesviacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btnmediaaritmetica
        '
        Me.Btnmediaaritmetica.Location = New System.Drawing.Point(134, 229)
        Me.Btnmediaaritmetica.Name = "Btnmediaaritmetica"
        Me.Btnmediaaritmetica.Size = New System.Drawing.Size(120, 51)
        Me.Btnmediaaritmetica.TabIndex = 0
        Me.Btnmediaaritmetica.Text = "Calculos estadisticos"
        Me.Btnmediaaritmetica.UseVisualStyleBackColor = True
        '
        'lblseries
        '
        Me.lblseries.AutoSize = True
        Me.lblseries.Location = New System.Drawing.Point(49, 57)
        Me.lblseries.Name = "lblseries"
        Me.lblseries.Size = New System.Drawing.Size(39, 13)
        Me.lblseries.TabIndex = 1
        Me.lblseries.Text = "Series:"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(109, 57)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(163, 20)
        Me.txtserie.TabIndex = 2
        '
        'lblrespuestamedia
        '
        Me.lblrespuestamedia.AutoSize = True
        Me.lblrespuestamedia.Location = New System.Drawing.Point(122, 103)
        Me.lblrespuestamedia.Name = "lblrespuestamedia"
        Me.lblrespuestamedia.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestamedia.TabIndex = 3
        Me.lblrespuestamedia.Text = "?"
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.Location = New System.Drawing.Point(49, 103)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(39, 13)
        Me.lblmedia.TabIndex = 4
        Me.lblmedia.Text = "Media:"
        '
        'lblvarianza
        '
        Me.lblvarianza.AutoSize = True
        Me.lblvarianza.Location = New System.Drawing.Point(37, 131)
        Me.lblvarianza.Name = "lblvarianza"
        Me.lblvarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblvarianza.TabIndex = 5
        Me.lblvarianza.Text = "Varianza:"
        '
        'lblrespuestavarianza
        '
        Me.lblrespuestavarianza.AutoSize = True
        Me.lblrespuestavarianza.Location = New System.Drawing.Point(122, 131)
        Me.lblrespuestavarianza.Name = "lblrespuestavarianza"
        Me.lblrespuestavarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestavarianza.TabIndex = 7
        Me.lblrespuestavarianza.Text = "?"
        '
        'lbldesviaciontipica
        '
        Me.lbldesviaciontipica.AutoSize = True
        Me.lbldesviaciontipica.Location = New System.Drawing.Point(21, 171)
        Me.lbldesviaciontipica.Name = "lbldesviaciontipica"
        Me.lbldesviaciontipica.Size = New System.Drawing.Size(70, 13)
        Me.lbldesviaciontipica.TabIndex = 8
        Me.lbldesviaciontipica.Text = "Desv. Tipica:"
        '
        'lblrespuestadesviacion
        '
        Me.lblrespuestadesviacion.AutoSize = True
        Me.lblrespuestadesviacion.Location = New System.Drawing.Point(122, 171)
        Me.lblrespuestadesviacion.Name = "lblrespuestadesviacion"
        Me.lblrespuestadesviacion.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestadesviacion.TabIndex = 9
        Me.lblrespuestadesviacion.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(522, 312)
        Me.Controls.Add(Me.lblrespuestadesviacion)
        Me.Controls.Add(Me.lbldesviaciontipica)
        Me.Controls.Add(Me.lblrespuestavarianza)
        Me.Controls.Add(Me.lblvarianza)
        Me.Controls.Add(Me.lblmedia)
        Me.Controls.Add(Me.lblrespuestamedia)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.lblseries)
        Me.Controls.Add(Me.Btnmediaaritmetica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Matricez y poo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnmediaaritmetica As Button
    Friend WithEvents lblseries As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents lblrespuestamedia As Label
    Friend WithEvents lblmedia As Label
    Friend WithEvents lblvarianza As Label
    Friend WithEvents lblrespuestavarianza As Label
    Friend WithEvents lbldesviaciontipica As Label
    Friend WithEvents lblrespuestadesviacion As Label
End Class
