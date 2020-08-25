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
        Me.grdestadisticas = New System.Windows.Forms.DataGridView()
        Me.lbltotalf1 = New System.Windows.Forms.Label()
        Me.lbltotalx1xf1 = New System.Windows.Forms.Label()
        Me.lbltotalx21f1 = New System.Windows.Forms.Label()
        Me.X1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X1xF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X21xF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdestadisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnmediaaritmetica
        '
        Me.Btnmediaaritmetica.Location = New System.Drawing.Point(58, 408)
        Me.Btnmediaaritmetica.Name = "Btnmediaaritmetica"
        Me.Btnmediaaritmetica.Size = New System.Drawing.Size(120, 51)
        Me.Btnmediaaritmetica.TabIndex = 0
        Me.Btnmediaaritmetica.Text = "Calculos estadisticos"
        Me.Btnmediaaritmetica.UseVisualStyleBackColor = True
        '
        'lblseries
        '
        Me.lblseries.AutoSize = True
        Me.lblseries.Location = New System.Drawing.Point(33, 26)
        Me.lblseries.Name = "lblseries"
        Me.lblseries.Size = New System.Drawing.Size(39, 13)
        Me.lblseries.TabIndex = 1
        Me.lblseries.Text = "Series:"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(93, 26)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(163, 20)
        Me.txtserie.TabIndex = 2
        '
        'lblrespuestamedia
        '
        Me.lblrespuestamedia.AutoSize = True
        Me.lblrespuestamedia.Location = New System.Drawing.Point(106, 72)
        Me.lblrespuestamedia.Name = "lblrespuestamedia"
        Me.lblrespuestamedia.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestamedia.TabIndex = 3
        Me.lblrespuestamedia.Text = "?"
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.Location = New System.Drawing.Point(33, 72)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(39, 13)
        Me.lblmedia.TabIndex = 4
        Me.lblmedia.Text = "Media:"
        '
        'lblvarianza
        '
        Me.lblvarianza.AutoSize = True
        Me.lblvarianza.Location = New System.Drawing.Point(21, 100)
        Me.lblvarianza.Name = "lblvarianza"
        Me.lblvarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblvarianza.TabIndex = 5
        Me.lblvarianza.Text = "Varianza:"
        '
        'lblrespuestavarianza
        '
        Me.lblrespuestavarianza.AutoSize = True
        Me.lblrespuestavarianza.Location = New System.Drawing.Point(106, 100)
        Me.lblrespuestavarianza.Name = "lblrespuestavarianza"
        Me.lblrespuestavarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestavarianza.TabIndex = 7
        Me.lblrespuestavarianza.Text = "?"
        '
        'lbldesviaciontipica
        '
        Me.lbldesviaciontipica.AutoSize = True
        Me.lbldesviaciontipica.Location = New System.Drawing.Point(5, 140)
        Me.lbldesviaciontipica.Name = "lbldesviaciontipica"
        Me.lbldesviaciontipica.Size = New System.Drawing.Size(70, 13)
        Me.lbldesviaciontipica.TabIndex = 8
        Me.lbldesviaciontipica.Text = "Desv. Tipica:"
        '
        'lblrespuestadesviacion
        '
        Me.lblrespuestadesviacion.AutoSize = True
        Me.lblrespuestadesviacion.Location = New System.Drawing.Point(106, 140)
        Me.lblrespuestadesviacion.Name = "lblrespuestadesviacion"
        Me.lblrespuestadesviacion.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestadesviacion.TabIndex = 9
        Me.lblrespuestadesviacion.Text = "?"
        '
        'grdestadisticas
        '
        Me.grdestadisticas.AllowUserToDeleteRows = False
        Me.grdestadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdestadisticas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.X1, Me.F1, Me.N1, Me.X1xF1, Me.X21xF1})
        Me.grdestadisticas.Location = New System.Drawing.Point(280, 26)
        Me.grdestadisticas.Name = "grdestadisticas"
        Me.grdestadisticas.Size = New System.Drawing.Size(556, 433)
        Me.grdestadisticas.TabIndex = 10
        '
        'lbltotalf1
        '
        Me.lbltotalf1.AutoSize = True
        Me.lbltotalf1.Location = New System.Drawing.Point(466, 462)
        Me.lbltotalf1.Name = "lbltotalf1"
        Me.lbltotalf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalf1.TabIndex = 11
        Me.lbltotalf1.Text = "0.0"
        '
        'lbltotalx1xf1
        '
        Me.lbltotalx1xf1.AutoSize = True
        Me.lbltotalx1xf1.Location = New System.Drawing.Point(684, 462)
        Me.lbltotalx1xf1.Name = "lbltotalx1xf1"
        Me.lbltotalx1xf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalx1xf1.TabIndex = 12
        Me.lbltotalx1xf1.Text = "0.0"
        '
        'lbltotalx21f1
        '
        Me.lbltotalx21f1.AutoSize = True
        Me.lbltotalx21f1.Location = New System.Drawing.Point(776, 462)
        Me.lbltotalx21f1.Name = "lbltotalx21f1"
        Me.lbltotalx21f1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalx21f1.TabIndex = 13
        Me.lbltotalx21f1.Text = "0.0"
        '
        'X1
        '
        Me.X1.HeaderText = "x1"
        Me.X1.Name = "X1"
        '
        'F1
        '
        Me.F1.HeaderText = "f1"
        Me.F1.Name = "F1"
        '
        'N1
        '
        Me.N1.HeaderText = "n1"
        Me.N1.Name = "N1"
        '
        'X1xF1
        '
        Me.X1xF1.HeaderText = "x1xf1"
        Me.X1xF1.Name = "X1xF1"
        '
        'X21xF1
        '
        Me.X21xF1.HeaderText = "x21xf1"
        Me.X21xF1.Name = "X21xF1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(875, 501)
        Me.Controls.Add(Me.lbltotalx21f1)
        Me.Controls.Add(Me.lbltotalx1xf1)
        Me.Controls.Add(Me.lbltotalf1)
        Me.Controls.Add(Me.grdestadisticas)
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
        CType(Me.grdestadisticas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grdestadisticas As DataGridView
    Friend WithEvents lbltotalf1 As Label
    Friend WithEvents lbltotalx1xf1 As Label
    Friend WithEvents lbltotalx21f1 As Label
    Friend WithEvents X1 As DataGridViewTextBoxColumn
    Friend WithEvents F1 As DataGridViewTextBoxColumn
    Friend WithEvents N1 As DataGridViewTextBoxColumn
    Friend WithEvents X1xF1 As DataGridViewTextBoxColumn
    Friend WithEvents X21xF1 As DataGridViewTextBoxColumn
End Class
