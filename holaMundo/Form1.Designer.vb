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
        Me.cbo2 = New System.Windows.Forms.ComboBox()
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbllongitud = New System.Windows.Forms.Label()
        Me.txtentrada = New System.Windows.Forms.TextBox()
        Me.txtrespuesta = New System.Windows.Forms.TextBox()
        Me.lblalmacenamiento = New System.Windows.Forms.Label()
        Me.cboalmacenamientoentrada = New System.Windows.Forms.ComboBox()
        Me.cboalmacenamientosalida = New System.Windows.Forms.ComboBox()
        Me.lblalmacenamientode = New System.Windows.Forms.Label()
        Me.lblalamacenamientoa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbo2
        '
        Me.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo2.Location = New System.Drawing.Point(317, 108)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(121, 21)
        Me.cbo2.TabIndex = 0
        '
        'cbo1
        '
        Me.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo1.Location = New System.Drawing.Point(70, 108)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(121, 21)
        Me.cbo1.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(12, 108)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(26, 16)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "De:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(247, 108)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(21, 16)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "A:"
        '
        'lbllongitud
        '
        Me.lbllongitud.AutoSize = True
        Me.lbllongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllongitud.Location = New System.Drawing.Point(12, 74)
        Me.lbllongitud.Name = "lbllongitud"
        Me.lbllongitud.Size = New System.Drawing.Size(67, 16)
        Me.lbllongitud.TabIndex = 4
        Me.lbllongitud.Text = "Longitud"
        '
        'txtentrada
        '
        Me.txtentrada.Location = New System.Drawing.Point(186, 42)
        Me.txtentrada.Name = "txtentrada"
        Me.txtentrada.Size = New System.Drawing.Size(100, 20)
        Me.txtentrada.TabIndex = 6
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(186, 212)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtrespuesta.TabIndex = 9
        '
        'lblalmacenamiento
        '
        Me.lblalmacenamiento.AutoSize = True
        Me.lblalmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalmacenamiento.Location = New System.Drawing.Point(12, 148)
        Me.lblalmacenamiento.Name = "lblalmacenamiento"
        Me.lblalmacenamiento.Size = New System.Drawing.Size(102, 16)
        Me.lblalmacenamiento.TabIndex = 10
        Me.lblalmacenamiento.Text = "Alcemaniento"
        '
        'cboalmacenamientoentrada
        '
        Me.cboalmacenamientoentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacenamientoentrada.FormattingEnabled = True
        Me.cboalmacenamientoentrada.Items.AddRange(New Object() {"Bit", "Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Petabyte"})
        Me.cboalmacenamientoentrada.Location = New System.Drawing.Point(70, 171)
        Me.cboalmacenamientoentrada.Name = "cboalmacenamientoentrada"
        Me.cboalmacenamientoentrada.Size = New System.Drawing.Size(121, 21)
        Me.cboalmacenamientoentrada.TabIndex = 11
        '
        'cboalmacenamientosalida
        '
        Me.cboalmacenamientosalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacenamientosalida.FormattingEnabled = True
        Me.cboalmacenamientosalida.Items.AddRange(New Object() {"Bit", "Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Petabyte"})
        Me.cboalmacenamientosalida.Location = New System.Drawing.Point(317, 171)
        Me.cboalmacenamientosalida.Name = "cboalmacenamientosalida"
        Me.cboalmacenamientosalida.Size = New System.Drawing.Size(121, 21)
        Me.cboalmacenamientosalida.TabIndex = 12
        '
        'lblalmacenamientode
        '
        Me.lblalmacenamientode.AutoSize = True
        Me.lblalmacenamientode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalmacenamientode.Location = New System.Drawing.Point(12, 171)
        Me.lblalmacenamientode.Name = "lblalmacenamientode"
        Me.lblalmacenamientode.Size = New System.Drawing.Size(29, 16)
        Me.lblalmacenamientode.TabIndex = 13
        Me.lblalmacenamientode.Text = "De:"
        '
        'lblalamacenamientoa
        '
        Me.lblalamacenamientoa.AutoSize = True
        Me.lblalamacenamientoa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalamacenamientoa.Location = New System.Drawing.Point(247, 175)
        Me.lblalamacenamientoa.Name = "lblalamacenamientoa"
        Me.lblalamacenamientoa.Size = New System.Drawing.Size(21, 16)
        Me.lblalamacenamientoa.TabIndex = 14
        Me.lblalamacenamientoa.Text = "A:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 350)
        Me.Controls.Add(Me.lblalamacenamientoa)
        Me.Controls.Add(Me.lblalmacenamientode)
        Me.Controls.Add(Me.cboalmacenamientosalida)
        Me.Controls.Add(Me.cboalmacenamientoentrada)
        Me.Controls.Add(Me.lblalmacenamiento)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.txtentrada)
        Me.Controls.Add(Me.lbllongitud)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.cbo2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Conversor de unidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbo2 As ComboBox
    Friend WithEvents cbo1 As ComboBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbllongitud As Label
    Friend WithEvents txtentrada As TextBox
    Friend WithEvents txtrespuesta As TextBox
    Friend WithEvents lblalmacenamiento As Label
    Friend WithEvents cboalmacenamientoentrada As ComboBox
    Friend WithEvents cboalmacenamientosalida As ComboBox
    Friend WithEvents lblalmacenamientode As Label
    Friend WithEvents lblalamacenamientoa As Label
End Class
