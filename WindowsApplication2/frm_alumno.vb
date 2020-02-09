Public Class frm_alumno
    Private Sub frm_alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_nombre.Focus()
        Dim llenarcombo As New localidades
        llenarcombo.obtener_nombres_loc(cbo_localidad)

        Dim llenarcombo2 As New carrera
        llenarcombo2.obtener_nombres_car(cbo_carrera)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_nombre.Text = "" Then
            txt_nombre.BackColor = Color.Red
            MsgBox("Escriba un nombre")
            txt_nombre.Focus()
            txt_nombre.BackColor = Color.White
        ElseIf txt_apellido.Text = "" Then
            txt_apellido.BackColor = Color.Red
            MsgBox("Escriba un apellido")
            txt_apellido.Focus()
            txt_apellido.BackColor = Color.White
        ElseIf txt_dni.Text = "" Then
            txt_dni.BackColor = Color.Red
            MsgBox("Escriba un nombre")
            txt_dni.Focus()
            txt_dni.BackColor = Color.White
        ElseIf txt_telefono.Text = "" Then
            txt_telefono.BackColor = Color.Red
            MsgBox("Escriba un nombre")
            txt_telefono.Focus()
            txt_telefono.BackColor = Color.White
        ElseIf txt_domicilio.Text = "" Then
            txt_domicilio.BackColor = Color.Red
            MsgBox("Escriba un nombre")
            txt_domicilio.Focus()
            txt_domicilio.BackColor = Color.White

        ElseIf DateDiff("yyyy", dtp_fecha.Value, Now) < 18 Then
            dtp_fecha.BackColor = Color.Red
            MsgBox("Debe ser mayor de edad")
            dtp_fecha.Focus()
            dtp_fecha.BackColor = Color.White
        ElseIf cbo_localidad.SelectedIndex = -1 Then
            cbo_localidad.BackColor = Color.Red
            MsgBox("Seleccione una localidad")
            cbo_localidad.Focus()
            cbo_localidad.BackColor = Color.White
        ElseIf cbo_carrera.SelectedIndex = -1 Then
            cbo_carrera.BackColor = Color.Red
            MsgBox("Seleccione una carrera")
            cbo_carrera.Focus()
            cbo_carrera.BackColor = Color.White
        ElseIf cbo_estado.SelectedIndex = -1 Then
            cbo_estado.BackColor = Color.Red
            MsgBox("Seleccione un Estado")
            cbo_estado.Focus()
            cbo_estado.BackColor = Color.White
        Else
            Dim nuevo As New alumno
            nuevo.agregar()
            Me.Close()
        End If
    End Sub

    Private Sub cbo_estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_estado.SelectedIndexChanged

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        id = 0
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        abrir.Title = "Seleccione su Imagen" 'Título de la ventana que se abrirá para seleccionar el archivo.
        abrir.Filter = "Jpg|*.jpg|Png|*.png|Gif|*.gif|Todos los archivos|*.*" 'Tipo de extensiones soportadas, fijaros como en la primera parte se pone el nombre, el que se quiera, después ponemos una barra vertical a modo de separación y ponemos *."extensión", el asterisco significa que nos permitirá cualquier nombre de archivo, la extensión hay que ponerla IGUAL que las que queramos abrir, lo de todos los archivos es opcional..
        abrir.FilterIndex = 0 'Elegimos que se quede por defecto la primera extensión a la vista.
        abrir.InitialDirectory = "C:\Documents and Settings\" & My.User.Name & "\Escritorio" 'Con esto haremos que el directorio inicial sea nuestro escritorio, podemos modificarlo a nuestro antojo si quisieramos abrirlo en mis documentos o en algún otro lugar lo ponemos y ya está.
        abrir.RestoreDirectory = True 'De esta forma, mientras no cerremos la aplicación se "guardará" el último directorio seleccionado para no tener que elegirlo cada vez.
        abrir.FileName = "" 'Con esto hacemos que al abrir la ventana no haya un nombre escrito, de la manera contraria en la ventana ya pondria "abre", además que esto nos viene bien para otra cosa que explicaré luego.

        If abrir.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Si pulsamos aceptar en la ventanita.
            PictureBox1.ImageLocation = abrir.FileName 'La ruta de la imagen que contiene el picturebox es el nombre de archivo del OpenFileDialog.
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PictureBox1.Image = PictureBox1.InitialImage
        abrir.FileName = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim alumno As New alumno
        alumno.modificar()
        actualizargrid(alumno.obtenertodo, (frm_buscoeliminomodifico.msg_lista))
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim alumno As New alumno
        alumno.eliminar()
        actualizargrid(alumno.obtenertodo, (frm_buscoeliminomodifico.msg_lista))
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        sololetras(e)
    End Sub

    Private Sub txt_apellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress
        sololetras(e)
    End Sub

    Private Sub txt_dni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_dni.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_domicilio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_domicilio.KeyPress
        alfanumerico(e)
    End Sub
End Class