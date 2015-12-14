Public Class frm2
    Public a As Double, b As Double, c As Double, resulraiz As Double, solreal1 As Double, solreal2 As Double



    Private Sub txtb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtb.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub frm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb.Click



    End Sub

    Private Sub btm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btm.Click
        lbm1.Text = txtb.Text
        lbm2.Text = txtb2.Text
        lbm3.Text = txtb3.Text
        Label63.Visible = True
        Label64.Visible = True
        Label65.Visible = True
        Label66.Visible = True
        a = Val(txtb.Text)
        b = Val(txtb2.Text)
        c = Val(txtb3.Text)
        resulraiz = ((b * b) - (4 * a * c))
        If resulraiz >= 0 Then
            solreal1 = ((-b + Math.Sqrt(resulraiz)) / (2 * a))
            solreal2 = ((-b - Math.Sqrt(resulraiz)) / (2 * a))
            lb.Text = solreal1
            lb2.Text = solreal2
            lb.Visible = True
            lb2.Visible = True
            Label12.Visible = True
            If solreal1 = solreal2 Then
                Label21.Visible = True
                Label24.Text = solreal1
                Label25.Text = solreal2
                Label52.Text = solreal1
                Label58.Text = solreal2
                Label22.Visible = True
                Label24.Visible = True
                Label26.Visible = True
                Label22.Visible = True
                Label20.Visible = True
                Label27.Visible = True
                Label25.Visible = True
                Label23.Visible = True
                Label19.Visible = True
                Label44.Visible = True
                Label45.Visible = True
                Label46.Visible = True
                Label47.Visible = True
                Label48.Visible = True
                Label49.Visible = True
                Label54.Visible = True
                Label52.Visible = True
                Label50.Visible = True
                Label53.Visible = True
                Label51.Visible = True
                Label58.Visible = True
                Label59.Visible = True

            Else
                Label24.Text = solreal1
                Label25.Text = solreal2
                Label52.Text = solreal1
                Label58.Text = solreal2
                Label22.Visible = True
                Label24.Visible = True
                Label26.Visible = True
                Label22.Visible = True
                Label20.Visible = True
                Label27.Visible = True
                Label25.Visible = True
                Label23.Visible = True
                Label19.Visible = True
                Label52.Visible = True
                Label50.Visible = True
                Label53.Visible = True
                Label51.Visible = True
                Label58.Visible = True
                Label59.Visible = True
                Label44.Visible = True
                Label45.Visible = True
                Label46.Visible = True
                Label47.Visible = True
                Label48.Visible = True
                Label49.Visible = True

            End If
        Else
            resulraiz = resulraiz * -1
            Label14.Text = Val(txtb2.Text) / (2 * a)
            Label14.Text = Math.Round(Val(Label14.Text), 2)
            Label15.Text = Math.Sqrt(resulraiz) / (2 * a)
            Label15.Text = Math.Round(Val(Label15.Text), 2)
            Label30.Text = Math.Round(Val(Label14.Text), 2)
            Label40.Text = Math.Round(Val(Label14.Text), 2)
            Label34.Text = Math.Round(Val(Label15.Text), 2)
            Label36.Text = Math.Round(Val(Label15.Text), 2)
            Label55.Text = Label15.Text
            Label60.Text = Label15.Text
            Label52.Text = Label14.Text
            Label58.Text = Label14.Text
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label29.Visible = True
            Label42.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label40.Visible = True
            Label41.Visible = True
            Label28.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            Label35.Visible = True
            Label39.Visible = True
            Label43.Visible = True
            Label38.Visible = True
            Label36.Visible = True
            Label37.Visible = True
            Label44.Visible = True
            Label45.Visible = True
            Label46.Visible = True
            Label47.Visible = True
            Label48.Visible = True
            Label49.Visible = True
            Label49.Visible = True
            Label57.Visible = True
            Label55.Visible = True
            Label56.Visible = True
            Label62.Visible = True
            Label60.Visible = True
            Label61.Visible = True
            Label52.Visible = True
            Label50.Visible = True
            Label53.Visible = True
            Label51.Visible = True
            Label58.Visible = True
            Label59.Visible = True
            If b = 0 Then
                Label55.Text = Label15.Text
                Label60.Text = Label15.Text
                Label29.Visible = False
                Label42.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label40.Visible = False
                Label41.Visible = False
                Label28.Visible = True
                Label32.Visible = True
                Label33.Visible = True
                Label34.Visible = True
                Label35.Visible = True
                Label39.Visible = True
                Label43.Visible = True
                Label38.Visible = True
                Label36.Visible = True
                Label37.Visible = True
                Label44.Visible = True
                Label45.Visible = True
                Label46.Visible = True
                Label47.Visible = True
                Label48.Visible = True
                Label49.Visible = True
                Label57.Visible = True
                Label55.Visible = True
                Label56.Visible = True
                Label62.Visible = True
                Label60.Visible = True
                Label61.Visible = True
                Label52.Visible = False
                Label50.Visible = False
                Label53.Visible = False
                Label51.Visible = False
                Label58.Visible = False
                Label59.Visible = False
            End If

        End If



        lbm1.Visible = True
        lbm2.Visible = True
        lbm3.Visible = True
        lb1.Visible = True
        Label11.Visible = True
        Label6.Visible = True
        Label10.Visible = True
        Label7.Visible = True
        Label9.Visible = True



    End Sub

    Private Sub lbm1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbm1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm.Show()

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label29.Visible = False
        Label42.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label28.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False
        Label39.Visible = False
        Label43.Visible = False
        Label38.Visible = False
        Label36.Visible = False
        Label37.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False
        Label49.Visible = False
        Label49.Visible = False
        Label57.Visible = False
        Label55.Visible = False
        Label56.Visible = False
        Label62.Visible = False
        Label60.Visible = False
        Label61.Visible = False
        Label52.Visible = False
        Label50.Visible = False
        Label53.Visible = False
        Label51.Visible = False
        Label58.Visible = False
        Label59.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label29.Visible = False
        Label42.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label28.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False
        Label39.Visible = False
        Label43.Visible = False
        Label38.Visible = False
        Label36.Visible = False
        Label37.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False
        Label49.Visible = False
        Label49.Visible = False
        Label57.Visible = False
        Label55.Visible = False
        Label56.Visible = False
        Label62.Visible = False
        Label60.Visible = False
        Label61.Visible = False
        Label52.Visible = False
        Label50.Visible = False
        Label53.Visible = False
        Label51.Visible = False
        Label58.Visible = False
        Label59.Visible = False
        Label22.Visible = False
        Label24.Visible = False
        Label26.Visible = False
        Label22.Visible = False
        Label20.Visible = False
        Label27.Visible = False
        Label25.Visible = False
        Label23.Visible = False
        Label19.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False
        Label49.Visible = False
        Label54.Visible = False
        Label52.Visible = False
        Label50.Visible = False
        Label53.Visible = False
        Label51.Visible = False
        Label58.Visible = False
        Label59.Visible = False
        Label21.Visible = False
        Label63.Visible = False
        Label64.Visible = False
        Label65.Visible = False
        Label66.Visible = False
        lb.Visible = False
        lb2.Visible = False
        Label12.Visible = False
        lbm1.Visible = False
        lbm2.Visible = False
        lbm3.Visible = False
        lb1.Visible = False
        Label11.Visible = False
        Label6.Visible = False
        Label10.Visible = False
        Label7.Visible = False
        Label9.Visible = False
    End Sub
End Class