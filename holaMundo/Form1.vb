Public Class Form1
    Dim objdirecciones = New direcciones()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbodepto.Items.AddRange(objdirecciones.depto)

    End Sub

    Private Sub cboDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodepto.SelectedIndexChanged
        cbomun.Items.Clear()
        cbomun.Text = ""
        cbomun.Items.AddRange(objdirecciones.mun(cbodepto.SelectedIndex))
    End Sub

    Private Sub cbomun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomun.SelectedIndexChanged
        cboarea.Items.Clear()
        cboarea.Text = ""
        cboarea.Items.AddRange(objdirecciones.area(cbomun.SelectedIndex))
    End Sub
End Class

Class direcciones
    Public depto() As String = {"Seleccione un depto.", "Usulutan", "San Miguel", "La Union", "Morazan", "San Salvador", "La Libertad", "Chalatenango", "San Vicente"}
    Public mun()() As String = {
        New String() {"Seleccione un depto."},
        New String() {"Seleccione un municipio", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria"},    '0->Usulutan
        New String() {"Seleccione un municipio", "San Miguel", "El Transito", "San Rafael Ote", "San Jorge"},'1->San Miguel
        New String() {"Seleccione un municipio", "La Union", "SRL", "Anamoros", "Bolivar"},                  '2->La Union
        New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Cacaopera"},              '3->Morazan
        New String() {"Seleccione un municipio", "San Salvador", "Apopa", "Aguilares", "Ilopango", "El Paisnal"}, '4->San Salvador
        New String() {"Seleccione un municipio", "Santa Tecla", "Antiguo Cuscatlan", "Cuidad Arce", "Colón", "Comasagua"}, '5->La libertad
        New String() {"Seleccione un municipio", "Agua Caliente", "Arcatao", "Chalatenango", "Dulce Nombre de Maria", "Concepción Quezaltepeque"}, '6->Chalatenango
        New String() {"Seleccione un municipio", "San Vicente", "Apastepeque", "Guadalupe", "San Sebastián", "Santo Domingo"} '7->San Vicente
    }
    Public area()() As String = {
      New String() {"Selecione un area"},
      New String() {"selecione un area", "Canton Buena Vista", "canton El Cerrito", "Caton El Ojo de Agua", "Canton el Trillo"},
      New String() {"selecione un area", "Canton San Marcos Lempa", "Canton el Zamorano", "canton Terra Blanca", "Canton Salinas de Sisiguayo"},
      New String() {"Selecione un area", "Canton El Cerro el Nansal", "Canton El Nizperal", "Canton El Rebalse", "Canton El Volcan"},
      New String() {"Selecione un area", "Canton Mejicalpa", "Canton San Francisco", "Colonia Santa Maria", "Colonia Las Flores"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"},
      New String() {"selecione un area"},
      New String() {"Selecione un area"},
      New String() {"Selecione un area"}
    }

End Class

