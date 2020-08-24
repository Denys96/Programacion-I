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
        Me.btnparesoimpares = New System.Windows.Forms.Button()
        Me.lstejercicios = New System.Windows.Forms.ListBox()
        Me.btnparoimpar = New System.Windows.Forms.Button()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.btnprimo = New System.Windows.Forms.Button()
        Me.btncajero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnparesoimpares
        '
        Me.btnparesoimpares.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnparesoimpares.Location = New System.Drawing.Point(363, 290)
        Me.btnparesoimpares.Name = "btnparesoimpares"
        Me.btnparesoimpares.Size = New System.Drawing.Size(195, 44)
        Me.btnparesoimpares.TabIndex = 0
        Me.btnparesoimpares.Text = "Mostrar pares e impares"
        Me.btnparesoimpares.UseVisualStyleBackColor = True
        '
        'lstejercicios
        '
        Me.lstejercicios.FormattingEnabled = True
        Me.lstejercicios.Location = New System.Drawing.Point(342, 27)
        Me.lstejercicios.Name = "lstejercicios"
        Me.lstejercicios.Size = New System.Drawing.Size(216, 251)
        Me.lstejercicios.TabIndex = 1
        '
        'btnparoimpar
        '
        Me.btnparoimpar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnparoimpar.Location = New System.Drawing.Point(118, 295)
        Me.btnparoimpar.Name = "btnparoimpar"
        Me.btnparoimpar.Size = New System.Drawing.Size(100, 34)
        Me.btnparoimpar.TabIndex = 2
        Me.btnparoimpar.Text = "Par o Impar?"
        Me.btnparoimpar.UseVisualStyleBackColor = True
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(62, 57)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(100, 20)
        Me.txtnum.TabIndex = 3
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(12, 60)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(44, 13)
        Me.lblnum.TabIndex = 4
        Me.lblnum.Text = "Numero"
        '
        'btnprimo
        '
        Me.btnprimo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprimo.Location = New System.Drawing.Point(12, 295)
        Me.btnprimo.Name = "btnprimo"
        Me.btnprimo.Size = New System.Drawing.Size(100, 34)
        Me.btnprimo.TabIndex = 5
        Me.btnprimo.Text = "Primo"
        Me.btnprimo.UseVisualStyleBackColor = True
        '
        'btncajero
        '
        Me.btncajero.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncajero.Location = New System.Drawing.Point(224, 295)
        Me.btncajero.Name = "btncajero"
        Me.btncajero.Size = New System.Drawing.Size(88, 38)
        Me.btncajero.TabIndex = 6
        Me.btncajero.Text = "Cajero"
        Me.btncajero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(570, 394)
        Me.Controls.Add(Me.btncajero)
        Me.Controls.Add(Me.btnprimo)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btnparoimpar)
        Me.Controls.Add(Me.lstejercicios)
        Me.Controls.Add(Me.btnparesoimpares)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejercicio con estructura de control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnparesoimpares As Button
    Friend WithEvents lstejercicios As ListBox
    Friend WithEvents btnparoimpar As Button
    Friend WithEvents txtnum As TextBox
    Friend WithEvents lblnum As Label
    Friend WithEvents btnprimo As Button
    Friend WithEvents btncajero As Button
End Class
