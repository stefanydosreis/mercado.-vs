<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TBcodigo = New System.Windows.Forms.MaskedTextBox()
        Me.TBpreco = New System.Windows.Forms.TextBox()
        Me.TBdescricao = New System.Windows.Forms.TextBox()
        Me.TBposicao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTdeleta = New System.Windows.Forms.Button()
        Me.BTedita = New System.Windows.Forms.Button()
        Me.BTsalva = New System.Windows.Forms.Button()
        Me.BTnovo = New System.Windows.Forms.Button()
        Me.BTproximo = New System.Windows.Forms.Button()
        Me.BTanterior = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TBcodProc = New System.Windows.Forms.MaskedTextBox()
        Me.TBprecoProc = New System.Windows.Forms.TextBox()
        Me.TBdescProc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(112, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(583, 506)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TBcodigo)
        Me.TabPage1.Controls.Add(Me.TBpreco)
        Me.TabPage1.Controls.Add(Me.TBdescricao)
        Me.TabPage1.Controls.Add(Me.TBposicao)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.BTdeleta)
        Me.TabPage1.Controls.Add(Me.BTedita)
        Me.TabPage1.Controls.Add(Me.BTsalva)
        Me.TabPage1.Controls.Add(Me.BTnovo)
        Me.TabPage1.Controls.Add(Me.BTproximo)
        Me.TabPage1.Controls.Add(Me.BTanterior)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(575, 480)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modo Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TBcodigo
        '
        Me.TBcodigo.Enabled = False
        Me.TBcodigo.Location = New System.Drawing.Point(218, 257)
        Me.TBcodigo.Mask = "0000000000000"
        Me.TBcodigo.Name = "TBcodigo"
        Me.TBcodigo.Size = New System.Drawing.Size(221, 20)
        Me.TBcodigo.TabIndex = 14
        '
        'TBpreco
        '
        Me.TBpreco.Enabled = False
        Me.TBpreco.Location = New System.Drawing.Point(218, 318)
        Me.TBpreco.Name = "TBpreco"
        Me.TBpreco.Size = New System.Drawing.Size(221, 20)
        Me.TBpreco.TabIndex = 13
        '
        'TBdescricao
        '
        Me.TBdescricao.Enabled = False
        Me.TBdescricao.Location = New System.Drawing.Point(218, 292)
        Me.TBdescricao.Name = "TBdescricao"
        Me.TBdescricao.Size = New System.Drawing.Size(221, 20)
        Me.TBdescricao.TabIndex = 12
        '
        'TBposicao
        '
        Me.TBposicao.Enabled = False
        Me.TBposicao.Location = New System.Drawing.Point(218, 229)
        Me.TBposicao.Name = "TBposicao"
        Me.TBposicao.Size = New System.Drawing.Size(221, 20)
        Me.TBposicao.TabIndex = 10
        Me.TBposicao.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Preço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Descrição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Código:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Posição:"
        '
        'BTdeleta
        '
        Me.BTdeleta.BackgroundImage = CType(resources.GetObject("BTdeleta.BackgroundImage"), System.Drawing.Image)
        Me.BTdeleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTdeleta.Location = New System.Drawing.Point(424, 24)
        Me.BTdeleta.Name = "BTdeleta"
        Me.BTdeleta.Size = New System.Drawing.Size(94, 101)
        Me.BTdeleta.TabIndex = 5
        Me.BTdeleta.UseVisualStyleBackColor = True
        '
        'BTedita
        '
        Me.BTedita.BackgroundImage = CType(resources.GetObject("BTedita.BackgroundImage"), System.Drawing.Image)
        Me.BTedita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTedita.Location = New System.Drawing.Point(305, 24)
        Me.BTedita.Name = "BTedita"
        Me.BTedita.Size = New System.Drawing.Size(94, 101)
        Me.BTedita.TabIndex = 4
        Me.BTedita.UseVisualStyleBackColor = True
        '
        'BTsalva
        '
        Me.BTsalva.BackgroundImage = CType(resources.GetObject("BTsalva.BackgroundImage"), System.Drawing.Image)
        Me.BTsalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTsalva.Enabled = False
        Me.BTsalva.Location = New System.Drawing.Point(186, 24)
        Me.BTsalva.Name = "BTsalva"
        Me.BTsalva.Size = New System.Drawing.Size(94, 101)
        Me.BTsalva.TabIndex = 3
        Me.BTsalva.UseVisualStyleBackColor = True
        '
        'BTnovo
        '
        Me.BTnovo.BackgroundImage = CType(resources.GetObject("BTnovo.BackgroundImage"), System.Drawing.Image)
        Me.BTnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTnovo.Location = New System.Drawing.Point(72, 24)
        Me.BTnovo.Name = "BTnovo"
        Me.BTnovo.Size = New System.Drawing.Size(94, 101)
        Me.BTnovo.TabIndex = 2
        Me.BTnovo.UseVisualStyleBackColor = True
        '
        'BTproximo
        '
        Me.BTproximo.BackgroundImage = CType(resources.GetObject("BTproximo.BackgroundImage"), System.Drawing.Image)
        Me.BTproximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTproximo.Location = New System.Drawing.Point(470, 232)
        Me.BTproximo.Name = "BTproximo"
        Me.BTproximo.Size = New System.Drawing.Size(94, 101)
        Me.BTproximo.TabIndex = 1
        Me.BTproximo.UseVisualStyleBackColor = True
        '
        'BTanterior
        '
        Me.BTanterior.BackgroundImage = CType(resources.GetObject("BTanterior.BackgroundImage"), System.Drawing.Image)
        Me.BTanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTanterior.Location = New System.Drawing.Point(31, 232)
        Me.BTanterior.Name = "BTanterior"
        Me.BTanterior.Size = New System.Drawing.Size(94, 101)
        Me.BTanterior.TabIndex = 0
        Me.BTanterior.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TBcodProc)
        Me.TabPage2.Controls.Add(Me.TBprecoProc)
        Me.TabPage2.Controls.Add(Me.TBdescProc)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(575, 480)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modo Procura"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TBcodProc
        '
        Me.TBcodProc.Location = New System.Drawing.Point(209, 200)
        Me.TBcodProc.Mask = "0000000000000"
        Me.TBcodProc.Name = "TBcodProc"
        Me.TBcodProc.Size = New System.Drawing.Size(221, 20)
        Me.TBcodProc.TabIndex = 20
        '
        'TBprecoProc
        '
        Me.TBprecoProc.Enabled = False
        Me.TBprecoProc.Location = New System.Drawing.Point(209, 261)
        Me.TBprecoProc.Name = "TBprecoProc"
        Me.TBprecoProc.Size = New System.Drawing.Size(221, 20)
        Me.TBprecoProc.TabIndex = 19
        '
        'TBdescProc
        '
        Me.TBdescProc.Enabled = False
        Me.TBdescProc.Location = New System.Drawing.Point(209, 235)
        Me.TBdescProc.Name = "TBdescProc"
        Me.TBdescProc.Size = New System.Drawing.Size(221, 20)
        Me.TBdescProc.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Preço"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Descrição:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Código:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mercado.My.Resources.Resources._6362234
        Me.PictureBox1.Location = New System.Drawing.Point(4, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 524)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BTproximo As Button
    Friend WithEvents BTanterior As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BTdeleta As Button
    Friend WithEvents BTedita As Button
    Friend WithEvents BTsalva As Button
    Friend WithEvents BTnovo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBpreco As TextBox
    Friend WithEvents TBdescricao As TextBox
    Friend WithEvents TBposicao As TextBox
    Friend WithEvents TBcodigo As MaskedTextBox
    Friend WithEvents TBcodProc As MaskedTextBox
    Friend WithEvents TBprecoProc As TextBox
    Friend WithEvents TBdescProc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
