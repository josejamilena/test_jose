<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPrincipal))
        Me.pBTest = New System.Windows.Forms.Button()
        Me.pTBPort = New System.Windows.Forms.TextBox()
        Me.pImageBox = New System.Windows.Forms.PictureBox()
        CType(Me.pImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pBTest
        '
        Me.pBTest.Location = New System.Drawing.Point(197, 12)
        Me.pBTest.Name = "pBTest"
        Me.pBTest.Size = New System.Drawing.Size(75, 23)
        Me.pBTest.TabIndex = 0
        Me.pBTest.Text = "Test"
        Me.pBTest.UseVisualStyleBackColor = True
        '
        'pTBPort
        '
        Me.pTBPort.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pTBPort.Location = New System.Drawing.Point(13, 15)
        Me.pTBPort.Name = "pTBPort"
        Me.pTBPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pTBPort.Size = New System.Drawing.Size(100, 20)
        Me.pTBPort.TabIndex = 2
        Me.pTBPort.Text = "8000"
        '
        'pImageBox
        '
        Me.pImageBox.Image = Global.TestNaca.My.Resources.Resources.th
        Me.pImageBox.Location = New System.Drawing.Point(13, 41)
        Me.pImageBox.Name = "pImageBox"
        Me.pImageBox.Size = New System.Drawing.Size(259, 208)
        Me.pImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pImageBox.TabIndex = 1
        Me.pImageBox.TabStop = False
        Me.pImageBox.Visible = False
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pTBPort)
        Me.Controls.Add(Me.pImageBox)
        Me.Controls.Add(Me.pBTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormularioPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test de Jose"
        CType(Me.pImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pBTest As System.Windows.Forms.Button
    Friend WithEvents pImageBox As System.Windows.Forms.PictureBox
    Friend WithEvents pTBPort As System.Windows.Forms.TextBox

End Class
