<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_carrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_carrera))
        Me.msg_carrera = New AxMSFlexGridLib.AxMSFlexGrid()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_anios = New System.Windows.Forms.TextBox()
        Me.txt_carrera = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.msg_carrera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msg_carrera
        '
        Me.msg_carrera.Location = New System.Drawing.Point(12, 109)
        Me.msg_carrera.Name = "msg_carrera"
        Me.msg_carrera.OcxState = CType(resources.GetObject("msg_carrera.OcxState"), System.Windows.Forms.AxHost.State)
        Me.msg_carrera.Size = New System.Drawing.Size(520, 235)
        Me.msg_carrera.TabIndex = 0
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(316, 65)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_anios
        '
        Me.txt_anios.Location = New System.Drawing.Point(139, 68)
        Me.txt_anios.Name = "txt_anios"
        Me.txt_anios.Size = New System.Drawing.Size(29, 20)
        Me.txt_anios.TabIndex = 2
        '
        'txt_carrera
        '
        Me.txt_carrera.Location = New System.Drawing.Point(139, 42)
        Me.txt_carrera.Name = "txt_carrera"
        Me.txt_carrera.Size = New System.Drawing.Size(100, 20)
        Me.txt_carrera.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Carrera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Duracion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Años"
        '
        'frm_carrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 356)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_carrera)
        Me.Controls.Add(Me.txt_anios)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.msg_carrera)
        Me.Name = "frm_carrera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Carrera"
        CType(Me.msg_carrera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msg_carrera As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents txt_anios As System.Windows.Forms.TextBox
    Friend WithEvents txt_carrera As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
