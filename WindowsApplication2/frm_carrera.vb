Public Class frm_carrera

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If txt_carrera.Text = "" Then
            txt_carrera.BackColor = Color.Red
            MsgBox("Eliga un nombre")
            txt_carrera.BackColor = Color.White
            txt_carrera.Focus()
        ElseIf txt_anios.Text = "" Then
            txt_anios.BackColor = Color.Red
            MsgBox("Eliga la duracion de la carrera")
            txt_anios.BackColor = Color.White
            txt_anios.Focus()
        Else
            Dim carrera As New carrera
            carrera.agregar()
            carrera.obtener_todo()
        End If
    End Sub

    Private Sub frm_carrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim carrera As New carrera
        carrera.obtener_todo()
    End Sub

    Private Sub txt_carrera_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_carrera.KeyPress
        sololetras(e)
    End Sub

    Private Sub txt_anios_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_anios.KeyPress
        solonumeros(e)
    End Sub
End Class