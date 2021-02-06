Imports System.Web.Services

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim confirmValue As String = Request.Form("confirm_value")
        Dim JoiAcc As String
        JoiAcc = "I"
        If JoiAcc = "I" And confirmValue <> "Yes" Then
            ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "Confirm();", True)
        ElseIf JoiAcc = "I" And confirmValue = "Yes" Then
            ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "alert('JoiAcc = I and confirmValue = Yes');", True)
        End If

    End Sub
End Class