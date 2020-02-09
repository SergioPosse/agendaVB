<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscoeliminomodifico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_buscoeliminomodifico))
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.cbo_localidad = New System.Windows.Forms.ComboBox()
        Me.cbo_carrera = New System.Windows.Forms.ComboBox()
        Me.chk_todo = New System.Windows.Forms.CheckBox()
        Me.msg_lista = New AxMSFlexGridLib.AxMSFlexGrid()
        Me.rbt_activos = New System.Windows.Forms.RadioButton()
        Me.rbt_todo = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msg_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(442, 68)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 1
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.profile_photo
        Me.PictureBox1.InitialImage = Global.WindowsApplication2.My.Resources.Resources.profile_photo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(116, 57)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(132, 20)
        Me.txt_buscar.TabIndex = 3
        '
        'cbo_localidad
        '
        Me.cbo_localidad.FormattingEnabled = True
        Me.cbo_localidad.Location = New System.Drawing.Point(116, 3)
        Me.cbo_localidad.Name = "cbo_localidad"
        Me.cbo_localidad.Size = New System.Drawing.Size(132, 21)
        Me.cbo_localidad.TabIndex = 5
        '
        'cbo_carrera
        '
        Me.cbo_carrera.FormattingEnabled = True
        Me.cbo_carrera.Location = New System.Drawing.Point(116, 30)
        Me.cbo_carrera.Name = "cbo_carrera"
        Me.cbo_carrera.Size = New System.Drawing.Size(132, 21)
        Me.cbo_carrera.TabIndex = 6
        '
        'chk_todo
        '
        Me.chk_todo.AutoSize = True
        Me.chk_todo.Location = New System.Drawing.Point(254, 30)
        Me.chk_todo.Name = "chk_todo"
        Me.chk_todo.Size = New System.Drawing.Size(141, 17)
        Me.chk_todo.TabIndex = 7
        Me.chk_todo.Text = "Aplicar Todos Los Filtros"
        Me.chk_todo.UseVisualStyleBackColor = True
        '
        'msg_lista
        '
        Me.msg_lista.Location = New System.Drawing.Point(12, 97)
        Me.msg_lista.Name = "msg_lista"
        Me.msg_lista.OcxState = CType(resources.GetObject("msg_lista.OcxState"), System.Windows.Forms.AxHost.State)
        Me.msg_lista.Size = New System.Drawing.Size(520, 232)
        Me.msg_lista.TabIndex = 8
        '
        'rbt_activos
        '
        Me.rbt_activos.AutoSize = True
        Me.rbt_activos.Location = New System.Drawing.Point(254, 335)
        Me.rbt_activos.Name = "rbt_activos"
        Me.rbt_activos.Size = New System.Drawing.Size(79, 17)
        Me.rbt_activos.TabIndex = 9
        Me.rbt_activos.TabStop = True
        Me.rbt_activos.Text = "Ver Activos"
        Me.rbt_activos.UseVisualStyleBackColor = True
        '
        'rbt_todo
        '
        Me.rbt_todo.AutoSize = True
        Me.rbt_todo.Location = New System.Drawing.Point(174, 335)
        Me.rbt_todo.Name = "rbt_todo"
        Me.rbt_todo.Size = New System.Drawing.Size(74, 17)
        Me.rbt_todo.TabIndex = 10
        Me.rbt_todo.TabStop = True
        Me.rbt_todo.Text = "Ver Todos"
        Me.rbt_todo.UseVisualStyleBackColor = True
        '
        'frm_buscoeliminomodifico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(544, 356)
        Me.Controls.Add(Me.rbt_todo)
        Me.Controls.Add(Me.rbt_activos)
        Me.Controls.Add(Me.msg_lista)
        Me.Controls.Add(Me.chk_todo)
        Me.Controls.Add(Me.cbo_carrera)
        Me.Controls.Add(Me.cbo_localidad)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Name = "frm_buscoeliminomodifico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "buscoeliminomodifico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msg_lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents cbo_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_carrera As System.Windows.Forms.ComboBox
    Friend WithEvents chk_todo As System.Windows.Forms.CheckBox
    Friend WithEvents msg_lista As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents rbt_activos As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_todo As System.Windows.Forms.RadioButton
End Class
