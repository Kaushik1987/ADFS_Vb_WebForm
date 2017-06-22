Imports System
Imports System.Web.UI
Imports System.Security.Claims
Imports System.Threading
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim claimPrincipal As ClaimsPrincipal = TryCast(Thread.CurrentPrincipal, ClaimsPrincipal)
        If Not claimPrincipal Is Nothing Then
            'Parse value and show in page
            signedIn.Text = "You are signed in.(VB.net App )"
            For Each claim As Claim In claimPrincipal.Claims

                Dim literal1 = New Literal()
                literal1.Text += "<tr>"
                literal1.Text += "<td>" + claim.Type + "</td>"
                literal1.Text += "<td>" + claim.Value + "</td>"
                literal1.Text += "<td>" + claim.ValueType + "</td>"
                literal1.Text += "<td>" + claim.Subject.Name + "</td>"
                literal1.Text += "<td>" + claim.Issuer + "</td>"
                literal1.Text += "</tr>"

                Dim tr As New HtmlTableRow()
                Dim td As New HtmlTableCell()

                td.Controls.Add(literal1)
                tr.Controls.Add(td)
                sometabkle.Controls.Add(tr)
            Next


        End If


    End Sub
End Class