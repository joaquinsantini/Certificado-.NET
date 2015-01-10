Imports Datos

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oPrv As Datos.Proveedores = New Datos.Proveedores

        Dim arl As ArrayList = oPrv.TraerTodos()

        GrillaPr.DataSource = arl
        GrillaPr.DataBind()

    End Sub


End Class