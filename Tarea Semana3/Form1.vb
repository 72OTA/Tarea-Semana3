Imports Semana2 = Control2.Form1
Public Class frMDI
	Private Sub btnJueves_Click(sender As Object, e As EventArgs) Handles btnJueves.Click
		cbDias.Items.Insert(0, "Jueves")
	End Sub

	Private Sub btnViernes_Click(sender As Object, e As EventArgs) Handles btnViernes.Click
		cbDias.Items.Insert(0, "Viernes")
	End Sub

	Private Sub btnSabado_Click(sender As Object, e As EventArgs) Handles btnSabado.Click
		cbDias.Items.Insert(0, "Sabado")
	End Sub

	Private Sub btnDomingo_Click(sender As Object, e As EventArgs) Handles btnDomingo.Click
		cbDias.Items.Insert(0, "Domingo")
	End Sub

	Private Sub btnEnsamblado_Click(sender As Object, e As EventArgs) Handles btnEnsamblado.Click
		Dim fEnsamble As New Semana2
		fEnsamble.MdiParent = Me
		fEnsamble.Show()
	End Sub
End Class
