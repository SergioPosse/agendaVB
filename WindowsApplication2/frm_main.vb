Public Class frm_main

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PaisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaisToolStripMenuItem.Click
        frm_pais.Show()
    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnoToolStripMenuItem.Click
        frm_alumno.Text = "Agregar Alumno"
        frm_alumno.Button1.Enabled = True
        frm_alumno.Button2.Enabled = False
        frm_alumno.Show()
    End Sub

    Private Sub ProvinciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProvinciaToolStripMenuItem.Click
        frm_provincia.Show()
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_buscoeliminomodifico.Show()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        frm_localidad.Show()
    End Sub

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        todo = False
    End Sub

    Private Sub CarreraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarreraToolStripMenuItem.Click
        frm_carrera.Show()
    End Sub

    Private Sub RegularesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegularesToolStripMenuItem.Click
        frm_buscoeliminomodifico.Text = "Lista De Alumnos"
        frm_buscoeliminomodifico.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        frm_buscoeliminomodifico.Text = "Modificar Alumno"
        frm_buscoeliminomodifico.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        frm_buscoeliminomodifico.Text = "Eliminar Alumno"
        frm_buscoeliminomodifico.Show()
    End Sub
End Class