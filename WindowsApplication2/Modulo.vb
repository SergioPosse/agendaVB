Imports System.Data
Imports MySql.Data.MySqlClient
Module Modulo
    Public id As Integer
    Public todo As Boolean
    Public conex As New MySqlConnection("server=localhost;user id=root;password=;database=sergioposse")
    Public Class alumno
        Public Sub agregar()
            conex.Open()
            Using conex
                Dim prm_loc_nom As New MySqlParameter("@loc_nom", MySqlDbType.Text)
                prm_loc_nom.Value = frm_alumno.cbo_localidad.Text
                Dim buscar_id_loc As New MySqlCommand("SELECT loc_id FROM localidad WHERE loc_nom=@loc_nom", conex)
                buscar_id_loc.Parameters.Add(prm_loc_nom)
                Dim loc_id = buscar_id_loc.ExecuteScalar()

                Dim prm_car_nom As New MySqlParameter("@car_nom", MySqlDbType.Text)
                prm_car_nom.Value = frm_alumno.cbo_carrera.Text
                Dim buscar_id_car As New MySqlCommand("SELECT car_id FROM carrera WHERE car_nom=@car_nom", conex)
                buscar_id_car.Parameters.Add(prm_car_nom)
                Dim car_id = buscar_id_car.ExecuteScalar()

                Dim prm_id As New MySqlParameter("@id", MySqlDbType.Int32)
                Dim prm_ape As New MySqlParameter("@ape", MySqlDbType.Text)
                Dim prm_nom As New MySqlParameter("@nom", MySqlDbType.Text)
                Dim prm_tel As New MySqlParameter("@tel", MySqlDbType.Text)
                Dim prm_dom As New MySqlParameter("@dom", MySqlDbType.Text)
                Dim prm_dni As New MySqlParameter("@dni", MySqlDbType.Int32)

                Dim prm_cod_loc As New MySqlParameter("@cod_loc", MySqlDbType.Int32)
                Dim prm_est As New MySqlParameter("@est", MySqlDbType.Text)
                Dim prm_cod_car As New MySqlParameter("@cod_car", MySqlDbType.Int32)

                Dim prm_fec_ini As New MySqlParameter("@fec_ini", MySqlDbType.DateTime)
                Dim prm_foto As New MySqlParameter("@foto", MySqlDbType.Text)

                Dim insertar As New MySqlCommand("INSERT INTO alumno (alu_id,alu_ape,alu_nom,alu_dni,alu_tel,alu_cod_loc,alu_dom,alu_cod_car,alu_fec_ini,alu_est,alu_foto) values (@id,@ape , @nom, @dni ,@tel,@cod_loc,@dom,@cod_car,@fec_ini,@est,@foto)", conex)

                With frm_alumno
                    prm_nom.Value = StrConv(.txt_nombre.Text, 3)
                    prm_ape.Value = StrConv(.txt_apellido.Text, 3)
                    prm_tel.Value = .txt_telefono.Text
                    prm_dom.Value = StrConv(.txt_domicilio.Text, 3)
                    prm_fec_ini.Value = frm_alumno.dtp_fecha.Value
                    prm_dni.Value = Val(.txt_dni.Text)
                    prm_est.Value = .cbo_estado.SelectedItem
                    prm_cod_loc.Value = CType(loc_id, Integer)
                    prm_cod_car.Value = CType(car_id, Integer)
                    prm_foto.Value = ""

                End With
                insertar.Parameters.Add(prm_id)
                insertar.Parameters.Add(prm_nom)
                insertar.Parameters.Add(prm_ape)
                insertar.Parameters.Add(prm_tel)
                insertar.Parameters.Add(prm_dom)
                insertar.Parameters.Add(prm_dni)
                insertar.Parameters.Add(prm_est)
                insertar.Parameters.Add(prm_cod_car)
                insertar.Parameters.Add(prm_cod_loc)
                insertar.Parameters.Add(prm_fec_ini)
                insertar.Parameters.Add(prm_foto)
                insertar.ExecuteNonQuery()

                Dim saber_id As New MySqlCommand("SELECT LAST_INSERT_iD()", conex)
                Dim nombre_foto As String = saber_id.ExecuteScalar.ToString
                Dim foto As New Bitmap(New Bitmap(frm_alumno.PictureBox1.Image), frm_alumno.PictureBox1.Width, frm_alumno.PictureBox1.Height)
                foto.Save(Application.StartupPath & "/imagenes/" & nombre_foto & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim ruta_foto As String = "/imagenes/" & nombre_foto & ".jpg"
                Dim update As New MySqlCommand("UPDATE alumno SET alu_foto='" & ruta_foto & "' WHERE alu_id=" & nombre_foto, conex)
                update.ExecuteNonQuery()
                conex.Close()
                MessageBox.Show("registro agregado")
            End Using

        End Sub
        Public Sub modificar()
            Dim prm_nom_car As New MySqlParameter("@nom_car", MySqlDbType.Text)
            Dim prm_nom_loc As New MySqlParameter("@nom_loc", MySqlDbType.Text)
            prm_nom_loc.Value = frm_alumno.cbo_localidad.Text
            prm_nom_car.Value = frm_alumno.cbo_carrera.Text
            Dim buscar_id_loc As New MySqlCommand("SELECT loc_id FROM localidad WHERE loc_nom=@nom_loc", conex)
            Dim buscar_id_car As New MySqlCommand("SELECT car_id FROM carrera WHERE car_nom=@nom_car", conex)
            buscar_id_car.Parameters.Add(prm_nom_car)
            buscar_id_loc.Parameters.Add(prm_nom_loc)
            conex.Open()
            Dim carrera = buscar_id_car.ExecuteScalar
            Dim localidad As Integer = buscar_id_loc.ExecuteScalar

            With frm_alumno
                Dim nombre As String = .txt_nombre.Text
                Dim apellido As String = .txt_apellido.Text
                Dim domicilio As String = .txt_domicilio.Text
                Dim dni As Integer = Val(.txt_dni.Text)
                Dim fecha As Date = .dtp_fecha.Value
                Dim estado As String = .cbo_estado.Text
                Dim telefono As String = .txt_telefono.Text
                Dim ruta_foto As String = ""
                If .PictureBox1.ImageLocation = "" Then

                Else
                    Dim foto As New Bitmap(New Bitmap(frm_alumno.PictureBox1.Image), frm_alumno.PictureBox1.Width, frm_alumno.PictureBox1.Height)
                    foto.Save(Application.StartupPath & "/imagenes/" & id & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    ruta_foto = "/imagenes/" & id & ".jpg"
                End If
                Dim modificar As New MySqlCommand("UPDATE alumno SET alu_nom='" & nombre & "',alu_ape='" & apellido & "',alu_dni='" & dni & "',alu_tel='" & telefono & "',alu_cod_loc='" & localidad & "',alu_cod_car='" & carrera & "',alu_dom='" & domicilio & "',alu_est='" & estado & "',alu_foto='" & ruta_foto & "',alu_fec_ini='" & fecha & "' WHERE alu_id=" & id, conex)
                modificar.ExecuteNonQuery()
                conex.Close()
                MsgBox("Modificado")
                id = 0
            End With
        End Sub

        Public Function obtenertodo() 'me devuelve la tabla con alumnos'
            'creo el table adapter para guardar toda la tabla'
            Dim todo As New MySqlDataAdapter("SELECT * FROM alumno", conex)
            'creo el data set para poder usar esos datos de la tabla que guarde'
            Dim dataset As New DataSet

            conex.Open() 'abro coneccion'
            todo.Fill(dataset, "alumno") 'lleno el data set con el contenido de "persona"(tabla)'
            conex.Close() 'cierro coneccion'

            Dim tabla As New DataTable 'creo una tabla'
            tabla = dataset.Tables("alumno") 'le asigno todo el contenido del data set a esa tabla'
            Return tabla
        End Function
        Public Sub eliminar()
            Try
                conex.Open()
                Using conex
                    Dim borrar As New MySqlCommand("delete from alumno where alu_id = " & id, conex)
                    borrar.ExecuteNonQuery()
                End Using
                MsgBox("Eliminado")
            Catch ex As Exception
                MsgBox("ERROR")
            End Try
            id = 0
        End Sub
        Public Sub dar_baja()
            conex.Open()
            Dim baja As New MySqlCommand("UPDATE alumno SET alu_est='P'WHERE alu_id=" & id, conex)
            baja.ExecuteNonQuery()
            conex.Close()
            MsgBox("Dado de baja")
        End Sub
        Public Function buscar_apellido(ByVal text As TextBox) 
            Dim buscar As New MySqlDataAdapter("SELECT * FROM alumno WHERE alu_ape like'" & text.Text & "%" & "'", conex)
            conex.Open()
            Dim dataset As New DataSet
            buscar.Fill(dataset, "alumno")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("alumno")
            Return tabla
        End Function
        Public Function buscar_carrera()
            Dim id_car As New MySqlParameter("@id_car", MySqlDbType.Int32)
            If frm_buscoeliminomodifico.cbo_carrera.SelectedIndex = -1 Then
                id_car.Value = Nothing
            Else
                Dim prm_nom_car As New MySqlParameter("@nom_car", MySqlDbType.Text)
                prm_nom_car.Value = frm_buscoeliminomodifico.cbo_carrera.SelectedItem
                Dim buscar_cod_car As New MySqlCommand("SELECT car_id FROM carrera WHERE car_nom=@nom_car", conex)
                buscar_cod_car.Parameters.Add(prm_nom_car)
                conex.Open()
                id_car.Value = buscar_cod_car.ExecuteScalar
                conex.Close()
            End If
            Dim buscar As New MySqlCommand("SELECT * FROM alumno WHERE alu_cod_car=@id_car", conex)
            buscar.Parameters.Add(id_car)
            Dim adapter As New MySqlDataAdapter(buscar)
            conex.Open()
            Dim dataset As New DataSet
            adapter.Fill(dataset, "alumno")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("alumno")
            Return tabla
        End Function
        Public Function buscar_localidad()
            Dim id_loc As New MySqlParameter("@id_loc", MySqlDbType.Int32)
            If frm_buscoeliminomodifico.cbo_localidad.SelectedIndex = -1 Then
                id_loc.Value = Nothing
            Else
                Dim prm_nom_loc As New MySqlParameter("@nom_loc", MySqlDbType.Text)
                prm_nom_loc.Value = frm_buscoeliminomodifico.cbo_localidad.SelectedItem
                Dim buscar_cod_loc As New MySqlCommand("SELECT loc_id FROM localidad WHERE loc_nom=@nom_loc", conex)
                buscar_cod_loc.Parameters.Add(prm_nom_loc)
                conex.Open()
                id_loc.Value = buscar_cod_loc.ExecuteScalar
                conex.Close()
            End If
            Dim buscar As New MySqlCommand("SELECT * FROM alumno WHERE alu_cod_loc=@id_loc", conex)
            buscar.Parameters.Add(id_loc)
            Dim adapter As New MySqlDataAdapter(buscar)
            conex.Open()
            Dim dataset As New DataSet
            adapter.Fill(dataset, "alumno")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("alumno")
            Return tabla
        End Function
        Public Function buscar_todo(ByVal text As TextBox)
            Dim id_loc As New MySqlParameter("@id_loc", MySqlDbType.Int32)
            Dim id_car As New MySqlParameter("@id_car", MySqlDbType.Int32)
            If frm_buscoeliminomodifico.cbo_localidad.SelectedIndex = -1 Then
                id_loc.Value = Nothing
            Else
                Dim prm_nom_loc As New MySqlParameter("@nom_loc", MySqlDbType.Text)
                prm_nom_loc.Value = frm_buscoeliminomodifico.cbo_localidad.SelectedItem
                Dim buscar_cod_loc As New MySqlCommand("SELECT loc_id FROM localidad WHERE loc_nom=@nom_loc", conex)
                buscar_cod_loc.Parameters.Add(prm_nom_loc)
                conex.Open()
                id_loc.Value = buscar_cod_loc.ExecuteScalar
                conex.Close()
            End If
            If frm_buscoeliminomodifico.cbo_carrera.SelectedIndex = -1 Then
                id_car.Value = Nothing
            Else
                Dim prm_nom_car As New MySqlParameter("@nom_car", MySqlDbType.Text)
                prm_nom_car.Value = frm_buscoeliminomodifico.cbo_carrera.SelectedItem
                Dim buscar_cod_car As New MySqlCommand("SELECT car_id FROM carrera WHERE car_nom=@nom_car", conex)
                buscar_cod_car.Parameters.Add(prm_nom_car)
                conex.Open()
                id_car.Value = buscar_cod_car.ExecuteScalar
                conex.Close()
            End If
            Dim buscar_alumnos As New MySqlCommand("SELECT * FROM alumno WHERE (alu_ape like'" & text.Text & "%" & "') and (alu_cod_loc=@id_loc) and (alu_cod_car=@id_car)", conex)
            buscar_alumnos.Parameters.Add(id_loc)
            buscar_alumnos.Parameters.Add(id_car)
            Dim adapter As New MySqlDataAdapter(buscar_alumnos)
            conex.Open()
            Dim dataset As New DataSet
            adapter.Fill(dataset, "alumno")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("alumno")
            Return tabla
        End Function
    End Class
    Public Class localidades
        Public Sub agregar()
            conex.Open()
            Using conex
                Dim prm_pro_nom As New MySqlParameter("@pro_nom", MySqlDbType.Text)
                prm_pro_nom.Value = frm_localidad.cbo_provincia.Text
                Dim buscar_id_pro As New MySqlCommand("SELECT pro_id FROM provincia WHERE pro_nom=@pro_nom", conex)
                buscar_id_pro.Parameters.Add(prm_pro_nom)
                Dim pro_id = buscar_id_pro.ExecuteScalar()

                Dim prm_nom As New MySqlParameter("@nom", MySqlDbType.Text)
                Dim prm_cod_pro As New MySqlParameter("@cod_pro", MySqlDbType.Int32)
                Dim prm_cod_pos As New MySqlParameter("@cod_pos", MySqlDbType.Int32)

                Dim insertar As New MySqlCommand("INSERT INTO localidad (loc_nom,loc_cod_pro,loc_cod_pos) values (@nom,@cod_pro , @cod_pos)", conex)

                prm_nom.Value = StrConv(frm_localidad.txt_nombre.Text, 3)
                prm_cod_pro.Value = pro_id
                prm_cod_pos.Value = frm_localidad.txt_cod_pos.text

                insertar.Parameters.Add(prm_nom)
                insertar.Parameters.Add(prm_cod_pro)
                insertar.Parameters.Add(prm_cod_pos)
                insertar.ExecuteNonQuery()
                conex.Close()
                MessageBox.Show("registro agregado")
            End Using
        End Sub
        Public Sub obtenertodo()
            Dim buscar_loc As New MySqlDataAdapter("SELECT * FROM localidad", conex)
            Dim dataset As New DataSet
            Dim tabla As New DataTable
            conex.Open()
            buscar_loc.Fill(dataset, "localidad")
            conex.Close()
            tabla = dataset.Tables("localidad")

            With frm_localidad.msg_localidad
                .Cols = 4
                .Rows = 2
                .Col = 0
                .Text = "ID"
                .set_ColWidth(0, 1500)
                .Col = 1
                .set_ColWidth(1, 1500)
                .Text = "Nombre"
                .Col = 2
                .set_ColWidth(2, 1500)
                .Text = "Provincia"
                .Col = 3
                .set_ColWidth(3, 1500)
                .Text = "Codigo Postal"

            End With

            Dim fila As DataRow
            For Each fila In tabla.Rows
                Dim pro_id As Integer = fila.Item("loc_cod_pro")
                conex.Open()
                Dim busca_nom_pro As New MySqlCommand("SELECT pro_nom FROM provincia WHERE pro_id=" & pro_id, conex)
                Dim provincia As String
                provincia = busca_nom_pro.ExecuteScalar
                conex.Close()
                frm_localidad.msg_localidad.AddItem(fila.Item("loc_id").ToString + Chr(9) + fila.Item("loc_nom") + Chr(9) + provincia + Chr(9) + fila.Item("loc_cod_pos").ToString)
            Next
            frm_localidad.msg_localidad.RemoveItem(1)
        End Sub
        Public Sub obtener_nombres_loc(ByVal combobox As ComboBox)
            Dim buscar_nombre_loc As New MySqlDataAdapter("SELECT loc_nom FROM localidad", conex)

            Dim dataset As New DataSet
            combobox.Items.Clear()
            conex.Open()
            buscar_nombre_loc.Fill(dataset, "localidad")
            conex.Close()

            Dim tabla As New DataTable
            tabla = dataset.Tables("localidad")

            Dim fila As DataRow

            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("loc_nom"))
            Next
        End Sub
    End Class
    Public Class carrera
        Public Sub obtener_todo()
            Dim buscar_carrera As New MySqlDataAdapter("SELECT * FROM carrera", conex)
            Dim dataset As New DataSet
            Dim tabla As New DataTable

            conex.Open()
            buscar_carrera.Fill(dataset, "carrera")
            conex.Close()
            tabla = dataset.Tables("carrera")

            With frm_carrera.msg_carrera
                .Cols = 3
                .Rows = 2
                .Col = 0
                .Text = "ID"
                .set_ColWidth(0, 1500)
                .Col = 1
                .set_ColWidth(1, 1500)

                .Text = "Nombre"
                .Col = 2
                .set_ColWidth(2, 1500)

                .Text = "Duracion"
            End With

            Dim fila As DataRow
            For Each fila In tabla.Rows
                frm_carrera.msg_carrera.AddItem(fila.Item("car_id").ToString + Chr(9) + fila.Item("car_nom") + Chr(9) + fila.Item("car_dur").ToString)
            Next
            If frm_carrera.msg_carrera.Rows > 2 Then
                frm_carrera.msg_carrera.RemoveItem(1)
            End If
        End Sub
        Public Sub agregar()
            Dim agregar As New MySqlCommand("INSERT INTO carrera (car_nom,car_dur) values(@nom,@dur)", conex)
            Dim prm_nom As New MySqlParameter("@nom", MySqlDbType.Text)
            Dim prm_dur As New MySqlParameter("@dur", MySqlDbType.Int32)
            prm_nom.Value = frm_carrera.txt_carrera.Text
            prm_dur.Value = Val(frm_carrera.txt_anios.Text)
            Try
                conex.Open()
                agregar.Parameters.Add(prm_dur)
                agregar.Parameters.Add(prm_nom)
                agregar.ExecuteNonQuery()
                conex.Close()
                MsgBox("Carrera Agregada")
            Catch ex As Exception
                MsgBox("ERROR")
            End Try
        End Sub

        Public Sub obtener_nombres_car(ByVal combobox As ComboBox)
            Dim buscar_nombre_car As New MySqlDataAdapter("SELECT car_nom FROM carrera", conex)
            Dim dataset As New DataSet
            combobox.Items.Clear()
            conex.Open()
            buscar_nombre_car.Fill(dataset, "carrera")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("carrera")

            Dim fila As DataRow

            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("car_nom"))
            Next
        End Sub
    End Class
    Public Class pais
        Public Sub agregar()
            conex.Open()
            Using conex
                Try
                    Dim prm_nom As New MySqlParameter("@pai_nom", MySqlDbType.Text)
                    prm_nom.Value = frm_pais.txt_pais.Text
                    Dim insertar As New MySqlCommand("INSERT into pais (pai_nom) values(@pai_nom)", conex)
                    insertar.Parameters.Add(prm_nom)
                    insertar.ExecuteNonQuery()
                    MsgBox("Pais Agregado")
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End Using
        End Sub
        Public Sub obtenertodo()
            Dim buscar_pais As New MySqlDataAdapter("SELECT * FROM pais", conex)
            Dim dataset As New DataSet
            Dim tabla As New DataTable
            conex.Open()
            buscar_pais.Fill(dataset, "pais")
            conex.Close()
            tabla = dataset.Tables("pais")

            With frm_pais.msg_pais
                .Cols = 2
                .Rows = 2
                .Col = 0
                .Text = "ID"
                .set_ColWidth(0, 1500)
                .Col = 1
                .set_ColWidth(1, 1500)

                .Text = "Nombre"

            End With

            Dim fila As DataRow
            For Each fila In tabla.Rows
                frm_pais.msg_pais.AddItem(fila.Item("pai_id").ToString + Chr(9) + fila.Item("pai_nom"))
            Next
            frm_pais.msg_pais.RemoveItem(1)
        End Sub
        Public Sub obtenernombre(ByVal combobox As ComboBox)
            Dim dataset As New DataSet
            Dim buscar As New MySqlDataAdapter("SELECT pai_Nom FROM pais", conex)
            conex.Open()
            buscar.Fill(dataset, "pais")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("pais")
            combobox.Items.Clear()
            Dim fila As DataRow
            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("pai_nom"))
            Next
        End Sub
    End Class
    Public Class provincia
        Public Sub agregar()
            conex.Open()
            Using conex
                Try
                    Dim prm_nom As New MySqlParameter("@pro_nom", MySqlDbType.Text)
                    Dim prm_cod_pai As New MySqlParameter("@pro_cod_pai", MySqlDbType.Int32)
                    Dim prm_id As New MySqlParameter("@pro_Id", MySqlDbType.Int32)
                    prm_nom.Value = frm_provincia.txt_provincia.Text
                    prm_cod_pai.Value = CType(frm_provincia.cbo_pais.SelectedIndex, Integer) + 1


                    Dim insertar As New MySqlCommand("INSERT INTO provincia (pro_id,pro_nom,pro_cod_pai) values(@pro_id,@pro_nom,@pro_cod_pai)", conex)

                    insertar.Parameters.Add(prm_nom)
                    insertar.Parameters.Add(prm_cod_pai)
                    insertar.Parameters.Add(prm_id)

                    insertar.ExecuteNonQuery()
                    MsgBox("Provincia agregada")
                Catch ex As Exception
                    MsgBox("error")
                End Try
            End Using
        End Sub
        Public Sub eliminar()
            Try
                conex.Open()
                Dim eliminar As New MySqlCommand("DELETE FROM provincia WHERE pro_id=" & id, conex)
                eliminar.ExecuteNonQuery()
                conex.Close()
                id = 0
            Catch ex As Exception
                MsgBox("ERROR")
            End Try
        End Sub
        Public Sub obtenertodo()
            Dim buscar_provincia As New MySqlDataAdapter("SELECT * FROM provincia", conex)
            Dim dataset As New DataSet
            Dim tabla As New DataTable

            conex.Open()
            buscar_provincia.Fill(dataset, "provincia")
            conex.Close()
            tabla = dataset.Tables("provincia")

            With frm_provincia.msg_provincia
                .Cols = 3
                .Rows = 2
                .Col = 0
                .Text = "ID"
                .set_ColWidth(0, 1500)
                .Col = 1
                .set_ColWidth(1, 1500)

                .Text = "Nombre"
                .Col = 2
                .set_ColWidth(2, 1500)

                .Text = "Pais"
            End With

            Dim fila As DataRow
            For Each fila In tabla.Rows
                conex.Open()
                Dim pai_id As Integer = fila.Item("pro_cod_pai")
                Dim buscar_pais_nom As New MySqlCommand("SELECT pai_nom FROM pais WHERE pai_id=" & pai_id, conex)
                Dim pais As String = buscar_pais_nom.ExecuteScalar
                conex.Close()
                frm_provincia.msg_provincia.AddItem(fila.Item("pro_id").ToString + Chr(9) + fila.Item("pro_nom") + Chr(9) + pais)
            Next
            If frm_provincia.msg_provincia.Rows > 2 Then
                frm_provincia.msg_provincia.RemoveItem(1)
            End If
        End Sub
        Public Sub obtenernombre(ByVal combo As ComboBox)
            Dim dataset As New DataSet
            Dim buscar As New MySqlDataAdapter("SELECT pro_Nom FROM provincia", conex)
            conex.Open()
            buscar.Fill(dataset, "provincia")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("provincia")
            combo.Items.Clear()
            Dim fila As DataRow
            For Each fila In tabla.Rows
                combo.Items.Add(fila.Item("pro_nom"))
            Next
        End Sub
    End Class
    Public Sub pintar_fila(ByRef listado As AxMSFlexGridLib.AxMSFlexGrid)
        listado.SelectionMode = MSFlexGridLib.SelectionModeSettings.flexSelectionByRow
        listado.HighLight = MSFlexGridLib.HighLightSettings.flexHighlightAlways
        listado.Col = 0
        listado.ColSel = listado.Cols - 1
    End Sub
    Public Sub actualizargrid(ByVal tabla As DataTable, ByVal grilla As AxMSFlexGridLib.AxMSFlexGrid)
        Dim fila As DataRow
        With grilla
            .Clear()
            .Cols = 10
            .Rows = 2
            .FixedRows = 1
            .Row = 0
            .Col = 0
            .set_ColWidth(0, 500)
            .Text = "ID"
            .Col = 1
            .set_ColWidth(1, 1500)
            .Text = "Apellido"
            .Col = 2
            .set_ColWidth(2, 1500)
            .Text = "Nombre"
            .Col = 3
            .set_ColWidth(3, 1500)
            .Text = "DNI"
            .Col = 4
            .set_ColWidth(4, 1500)
            .Text = "Telefono"
            .Col = 5
            .set_ColWidth(5, 1500)
            .Text = "Localidad"
            .Col = 6
            .set_ColWidth(6, 1500)
            .Text = "Domicilio"
            .Col = 7
            .set_ColWidth(7, 1500)
            .Text = "Carrera"
            .Col = 8
            .set_ColWidth(8, 1500)
            .Text = "Fecha De Inicio"
            .Col = 9
            .set_ColWidth(9, 1500)
            .Text = "Estado"
        End With
        Dim contador As Integer = 0
        For Each fila In tabla.Rows
            contador = contador + 1
        Next
        If contador > 0 Then
            Dim cant_filas As Integer
            cant_filas = 0
            For Each fila In tabla.Rows
                'el not funciona de una forma logica solo entra el 
                'if si una de las dos proposiciones es falsa
                '( p^q solo es falso cuando uno de los dos es falso)'
                If Not (fila.Item("alu_est") = "P" And todo = False) Then

                    cant_filas = cant_filas + 1
                    Dim localidad As String
                    Dim carrera As String
                    Dim busca_nom_loc As New MySqlCommand("SELECT loc_nom FROM localidad WHERE loc_Id=" & fila.Item("alu_cod_loc"), conex)
                    Dim busca_nom_car As New MySqlCommand("SELECT car_nom FROM carrera Where car_Id=" & fila.Item("alu_cod_car"), conex)
                    conex.Open()
                    localidad = busca_nom_loc.ExecuteScalar
                    carrera = busca_nom_car.ExecuteScalar
                    conex.Close()
                    Dim fecha As String = fila.Item("alu_fec_ini").ToString
                    Dim idd As String = fila.Item("alu_id").ToString
                    Dim dni As String = fila.Item("alu_dni").ToString
                    Dim telefono As String = fila.Item("alu_tel").ToString
                    Dim domicilio As String = fila.Item("alu_dom").ToString
                    Dim estado As String = fila.Item("alu_est").ToString

                    grilla.AddItem(idd + Chr(9) + fila.Item("alu_ape") + Chr(9) + fila.Item("alu_nom") + Chr(9) + dni + Chr(9) + telefono + Chr(9) + localidad + Chr(9) + domicilio + Chr(9) + carrera + Chr(9) + fecha + Chr(9) + estado)
                    If fila.Item("alu_est") = "P" Then
                        grilla.Row = cant_filas + 1
                        grilla.Col = 0
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 1
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 2
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 3
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 4
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 5
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 6
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 7
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 8
                        grilla.CellBackColor = Color.LightCoral
                        grilla.Col = 9
                        grilla.CellBackColor = Color.LightCoral
                    End If
                    If fila.Item("alu_est") = "E" Then
                        grilla.Row = cant_filas + 1
                        grilla.Col = 0
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 1
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 2
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 3
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 4
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 5
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 6
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 7
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 8
                        grilla.CellBackColor = Color.LightSeaGreen
                        grilla.Col = 9
                        grilla.CellBackColor = Color.LightSeaGreen
                    End If
                    If fila.Item("alu_est") = "A" Then
                        grilla.Row = cant_filas + 1
                        grilla.Col = 0
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 1
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 2
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 3
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 4
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 5
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 6
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 7
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 8
                        grilla.CellBackColor = Color.LightBlue
                        grilla.Col = 9
                        grilla.CellBackColor = Color.LightBlue
                    End If
                End If
            Next
            grilla.RemoveItem(1)
        End If
    End Sub
    Public Sub solonumeros(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsNumber(caracter.KeyChar) Or caracter.KeyChar = Chr(8)) Then
            caracter.Handled = True
        End If
    End Sub
    Public Sub sololetras(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsLetter(caracter.KeyChar) Or caracter.KeyChar = Chr(8) Or
        caracter.KeyChar = Chr(32)) Then
            caracter.Handled = True
        End If
    End Sub
    Public Sub alfanumerico(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsLetter(caracter.KeyChar) Or Char.IsNumber(caracter.KeyChar) Or
        caracter.KeyChar = Chr(8) Or caracter.KeyChar = Chr(32)) Then
            caracter.Handled = True
        End If
    End Sub
End Module
