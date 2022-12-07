Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Drawing

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub pb_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		Dim progressBar As ASPxProgressBar = CType(sender, ASPxProgressBar)

		If progressBar.Position > 100 Then
			progressBar.Position = 100
		End If

		If progressBar.Position < 40 Then
			progressBar.IndicatorStyle.BackColor = Color.LightGreen
		ElseIf progressBar.Position >= 40 AndAlso progressBar.Position < 75 Then
			progressBar.IndicatorStyle.BackColor = Color.Yellow
		ElseIf progressBar.Position >= 75 Then
			progressBar.IndicatorStyle.BackColor = Color.Red
		End If
	End Sub
End Class