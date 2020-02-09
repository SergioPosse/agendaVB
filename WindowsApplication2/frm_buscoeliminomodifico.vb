Imports MySql.Data.MySqlClient
Public Class frm_buscoeliminomodifico
    Private Sub frm_buscoeliminomodifico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim alumno As New alumno
        actualizargrid(alumno.obtenertodo, (msg_lista))
        Dim carrera As New carrera
        carrera.obtener_nombres_car(cbo_carrera)
        Dim localidad As New localidades
        localidad.obtener_nombres_loc(cbo_localidad)
        rbt_activos.checked = True
        rbt_todo.checked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim resultado = MsgBox("Realmente desea dar de baja al alumno?", vbOKCancel, "CONFIRMACION")

        If resultado = vbOK Then
            Dim alumno As New alumno
            If id = 0 Then
                MessageBox.Show("Seleccione un registro")
            Else
                alumno.dar_baja()
                actualizargrid(alumno.obtenertodo, (msg_lista))
            End If
            PictureBox1.Image = PictureBox1.InitialImage
        Else
            Exit Sub
        End If
        
    End Sub

    Private Sub txt_buscar_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_buscar.KeyUp
        Dim alumno As New alumno
        If chk_todo.Checked Then
            actualizargrid(alumno.buscar_todo(txt_buscar), msg_lista)
        Else
            cbo_carrera.Text = ""
            cbo_localidad.Text = ""
            actualizargrid(alumno.buscar_apellido(txt_buscar), msg_lista)
        End If
    End Sub

    Private Sub cbo_localidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_localidad.SelectedIndexChanged
        Dim alumno As New alumno
        If chk_todo.Checked Then
            actualizargrid(alumno.buscar_todo(txt_buscar), msg_lista)
        Else
            cbo_carrera.Text = ""
            txt_buscar.Text = ""
            actualizargrid(alumno.buscar_localidad(), msg_lista)
        End If
    End Sub

    Private Sub cbo_carrera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_carrera.SelectedIndexChanged
        Dim alumno As New alumno
        If chk_todo.Checked Then
            actualizargrid(alumno.buscar_todo(txt_buscar), msg_lista)
        Else
            cbo_localidad.Text = ""
            txt_buscar.Text = ""
            actualizargrid(alumno.buscar_carrera(), msg_lista)
        End If
    End Sub

    Private Sub chk_todo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_todo.CheckedChanged
        Dim alumno As New alumno
        If chk_todo.Checked Then
            actualizargrid(alumno.buscar_todo(txt_buscar), msg_lista)
        Else
            txt_buscar.Text = ""
            cbo_localidad.SelectedIndex = -1
            cbo_carrera.SelectedIndex = -1
            actualizargrid(alumno.obtenertodo, msg_lista)
        End If

    End Sub

    Private Sub msg_lista_DblClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msg_lista.DblClick
        With frm_alumno
            msg_lista.Col = 0
            id = (msg_lista.Text)
            msg_lista.Col = 2
            .txt_nombre.Text = msg_lista.Text
            msg_lista.Col = 1
            .txt_apellido.Text = msg_lista.Text
            msg_lista.Col = 6
            .txt_domicilio.Text = msg_lista.Text
            msg_lista.Col = 3
            .txt_dni.Text = msg_lista.Text
            msg_lista.Col = 4
            .txt_telefono.Text = msg_lista.Text
            msg_lista.Col = 8
            .dtp_fecha.Text = msg_lista.Text
            msg_lista.Col = 9
            .cbo_estado.SelectedItem = msg_lista.Text

            Dim llenarcombo As New localidades
            llenarcombo.obtener_nombres_loc(frm_alumno.cbo_localidad)

            Dim llenarcombo2 As New carrera
            llenarcombo2.obtener_nombres_car(frm_alumno.cbo_carrera)

            Dim conex As New MySqlConnection("server=localhost;user id=root;password=root;database=sergioposse")
            conex.Open()
            Dim buscar_localidad As New MySqlCommand("SELECT alu_cod_loc FROM alumno WHERE alu_id=" & id, conex)
            Dim cod_loc = buscar_localidad.ExecuteScalar
            Dim buscar_nombre_localidad As New MySqlCommand("SELECT loc_nom FROM localidad WHERE loc_id=" & cod_loc, conex)
            Dim nombre_localidad = buscar_nombre_localidad.ExecuteScalar

            Dim buscar_carrera As New MySqlCommand("SELECT alu_cod_car FROM alumno WHERE alu_id=" & id, conex)
            Dim cod_car = buscar_carrera.ExecuteScalar
            Dim buscar_nombre_carrera As New MySqlCommand("SELECT car_nom FROM carrera WHERE car_id=" & cod_car, conex)
            Dim nombre_carrera = buscar_nombre_carrera.ExecuteScalar

            Dim buscar_foto As New MySqlCommand("SELECT alu_foto FROM alumno WHERE alu_id=" & id, conex)
            Dim cod_foto = buscar_foto.ExecuteScalar
            conex.Close()
            .PictureBox1.ImageLocation = Application.StartupPath + cod_foto
            .cbo_localidad.SelectedItem = nombre_localidad
            .cbo_carrera.SelectedItem = nombre_carrera
        End With
        frm_alumno.Text = "Modificar Alumno"
        frm_alumno.Button1.Enabled = False
        frm_alumno.Show()
    End Sub

    Private Sub msg_lista_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msg_lista.ClickEvent
        msg_lista.Col = 0
        id = Val(msg_lista.Text)
        pintar_fila(msg_lista)
        Dim conex As New MySqlConnection("server=localhost;user id=root;password=;database=sergioposse")
        Dim buscar_ruta As New MySqlCommand("SELECT alu_foto FROM alumno WHERE alu_id=" & id, conex)
        conex.Open()
        Dim ruta = buscar_ruta.ExecuteScalar
        conex.Close()
        PictureBox1.ImageLocation = Application.StartupPath + ruta
    End Sub

    Private Sub rbt_todo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_todo.CheckedChanged
        If rbt_todo.Checked = True Then
            todo = True
            rbt_activos.Checked = False
            Dim alumno As New alumno
            actualizargrid(alumno.obtenertodo, (msg_lista))

        End If
        If rbt_todo.Checked = False Then
            rbt_activos.Checked = True
            todo = False
            Dim alumno As New alumno
            actualizargrid(alumno.obtenertodo, (msg_lista))
        End If
    End Sub

    Private Sub rbt_activos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_activos.CheckedChanged
        If rbt_activos.Checked = True Then
            todo = False
            rbt_todo.Checked = False
            Dim alumno As New alumno
            actualizargrid(alumno.obtenertodo, (msg_lista))

        End If
        If rbt_activos.Checked = False Then
            rbt_todo.Checked = True
            todo = True
            Dim alumno As New alumno
            actualizargrid(alumno.obtenertodo, (msg_lista))
        End If
    End Sub

    Private Sub txt_buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        sololetras(e)
    End Sub
End Class