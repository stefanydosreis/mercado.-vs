Public Class Form1
    Dim posicao As Integer = 1
    Dim quantprod As Integer = 5
    Dim codigo(quantprod) As String
    Dim descricao(quantprod) As String
    Dim preco(quantprod) As String
    Dim achou As Boolean
    Private Sub atualizatela()
        TBposicao.Text = posicao
        TBcodigo.Text = codigo(posicao)
        TBdescricao.Text = descricao(posicao)
        TBpreco.Text = preco(posicao)
    End Sub

    Private Sub Travatela(ByVal ordem As Boolean)
        TBcodigo.Enabled = Not (ordem)
        TBdescricao.Enabled = Not (ordem)
        TBpreco.Enabled = Not (ordem)
        BTsalva.Enabled = Not (ordem)
        BTanterior.Enabled = ordem
        BTproximo.Enabled = ordem
        BTedita.Enabled = ordem
        BTdeleta.Enabled = ordem
        BTnovo.Enabled = ordem
    End Sub
    Private Sub BTedita_Click(sender As Object, e As EventArgs) Handles BTedita.Click
        Travatela(False)
    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTanterior.Click
        If posicao = 1 Then
            posicao = quantprod
        Else
            posicao = posicao - 1
        End If
        atualizatela()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TBcodigo.MaskInputRejected

    End Sub

    Private Sub BTdeleta_Click(sender As Object, e As EventArgs) Handles BTdeleta.Click
        If MsgBox("Tem certeza?", MsgBoxStyle.YesNo) =
MsgBoxResult.Yes Then
            TBcodigo.Text = ""
            TBdescricao.Text = ""
            TBpreco.Text = ""
            codigo(posicao) = ""
            descricao(posicao) = ""
            preco(posicao) = ""
        End If
    End Sub

    Private Sub BTsalva_Click(sender As Object, e As EventArgs) Handles BTsalva.Click
        codigo(posicao) = TBcodigo.Text
        descricao(posicao) = TBdescricao.Text
        preco(posicao) = TBpreco.Text
        Travatela(True)
    End Sub

    Private Sub BTproximo_Click(sender As Object, e As EventArgs) Handles BTproximo.Click
        If posicao = 5 Then
            posicao = 1
        Else
            posicao = posicao + 1
        End If
        atualizatela()
    End Sub

    Private Sub BTnovo_Click(sender As Object, e As EventArgs) Handles BTnovo.Click
        For cont As Integer = 1 To quantprod
            If achou = False Then
                If codigo(cont) = "" Then
                    achou = True
                    posicao = cont
                End If
            End If
        Next
        If achou = False Then
            MsgBox("Não há espaço em memória.")
        Else
            atualizatela()
            Travatela(False)
        End If
        achou = False
    End Sub

    Private Sub TBcodProc_TextChanged(sender As Object, e As EventArgs) Handles TBcodProc.TextChanged
        If Len(TBcodProc.Text) = 13 Then
            For cont As Integer = 1 To quantprod
                If TBcodProc.Text = codigo(cont) Then
                    achou = True
                    TBdescProc.Text = descricao(cont)
                    TBprecoProc.Text = preco(cont)
                End If
            Next
            If achou = False Then
                TBdescProc.Text = "Produto não cadastrado"
                TBprecoProc.Text = ""
            End If
            achou = False
            TBcodProc.Text = ""
        End If
    End Sub
End Class