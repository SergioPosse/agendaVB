Public Class frm_provincia

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_pais.SelectedIndexChanged

    End Sub

    Private Sub frm_provincia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim llenarcombo As New pais
        llenarcombo.obtenernombre(cbo_pais)
        Dim provincia As New provincia
        provincia.obtenertodo()
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If txt_provincia.Text = "" Then
            txt_provincia.BackColor = Color.Red
            MsgBox("Ingrese un nombre")
            txt_provincia.BackColor = Color.White
            txt_provincia.Focus()
        ElseIf cbo_pais.SelectedIndex = -1 Then
            cbo_pais.BackColor = Color.Red
            MsgBox("Seleccione un pais")
            cbo_pais.BackColor = Color.White
            cbo_pais.Focus()
        Else
            Dim provincia As New provincia
            provincia.agregar()
            provincia.obtenertodo()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_pais.Show()
    End Sub

    Private Sub msg_provincia_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msg_provincia.ClickEvent
        msg_provincia.Col = 0
        pintar_fila(msg_provincia)
        id = Val(msg_provincia.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim provincia As New provincia
        provincia.eliminar()
        provincia.obtenertodo()
    End Sub

    Private Sub txt_provincia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_provincia.KeyPress
        sololetras(e)
    End Sub
End Class