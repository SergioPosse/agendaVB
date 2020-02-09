<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pais
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pais))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.msg_pais = New AxMSFlexGridLib.AxMSFlexGrid()
        CType(Me.msg_pais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(353, 52)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(158, 52)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(156, 20)
        Me.txt_pais.TabIndex = 4
        '
        'msg_pais
        '
        Me.msg_pais.Location = New System.Drawing.Point(12, 81)
        Me.msg_pais.Name = "msg_pais"
        Me.msg_pais.OcxState = CType(resources.GetObject("msg_pais.OcxState"), System.Windows.Forms.AxHost.State)
        Me.msg_pais.Size = New System.Drawing.Size(528, 265)
        Me.msg_pais.TabIndex = 7
        '
        'frm_pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 356)
        Me.Controls.Add(Me.msg_pais)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txt_pais)
        Me.Name = "frm_pais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Pais"
        CType(Me.msg_pais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents txt_pais As System.Windows.Forms.TextBox
    Friend WithEvents msg_pais As AxMSFlexGridLib.AxMSFlexGrid
End Class
