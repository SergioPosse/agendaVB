Public Class frm_localidad

    Private Sub frm_localidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim llenarprovincia As New provincia
        llenarprovincia.obtenernombre(cbo_provincia)
        Dim localidad As New localidades
        localidad.obtenertodo()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_nombre.Text = "" Then
            txt_nombre.BackColor = Color.Red
            MsgBox("Ingrese un nombre")
            txt_nombre.BackColor = Color.White
            txt_nombre.Focus()
        ElseIf txt_cod_pos.Text = "" Then
            txt_cod_pos.BackColor = Color.Red
            MsgBox("Ingrese un codigo postal")
            txt_cod_pos.BackColor = Color.White
            txt_cod_pos.Focus()
        ElseIf cbo_provincia.SelectedIndex = -1 Then
            cbo_provincia.BackColor = Color.Red
            MsgBox("Seleccione una provincia")
            cbo_provincia.BackColor = Color.White
            cbo_provincia.Focus()
        Else
            Dim localidad As New localidades
            localidad.agregar()
            localidad.obtenertodo()
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        sololetras(e)
    End Sub

    Private Sub txt_cod_pos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod_pos.KeyPress
        solonumeros(e)
    End Sub
End Class