Public Class frm_pais

    Private Sub frm_pais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim paises As New pais
        paises.obtenertodo()

    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If txt_pais.Text = "" Then
            txt_pais.BackColor = Color.Red
            MsgBox("Ingrese un nombre")
            txt_pais.BackColor = Color.White
            txt_pais.Focus()
        Else
            Dim paises As New pais
            paises.agregar()
            paises.obtenertodo()
        End If
    End Sub

    Private Sub frm_pais_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        Dim pais As New pais
        pais.obtenernombre(frm_provincia.cbo_pais)
    End Sub

    Private Sub txt_pais_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pais.KeyPress
        sololetras(e)
    End Sub
End Class