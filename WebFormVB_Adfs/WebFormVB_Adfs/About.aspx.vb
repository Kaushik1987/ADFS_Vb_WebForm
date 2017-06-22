Imports System.Threading
Imports System.Security.Claims

Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub CheckClaim(sender As Object, e As EventArgs)
        Dim claimname = claimkey.Text
        Dim claimvalue = txtclaimvalue.Text
        Dim userClaims = Thread.CurrentPrincipal.Identity
        Dim claimsIdentity = TryCast(userClaims, ClaimsIdentity)

        ' Access claim
        Try
            If claimsIdentity IsNot Nothing Then
                Dim isValid = claimsIdentity.Claims.FirstOrDefault(Function(x) x.Type = claimname AndAlso x.Value = claimvalue)

                lbl.Text = If(isValid IsNot Nothing, "Claim matched ", "Claim data mismatched ")
            End If
            ' Log error
        Catch ex As Exception
        End Try
    End Sub
End Class