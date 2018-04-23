Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Web.Mvc
Imports DevExpress.XtraPrinting.InternalAccess
Imports DevExpress.XtraReports.UI
Imports DevExpressMvcApplication1.Reports
Imports System.Linq
Imports System
Imports NorthwindModel

' ...

Namespace DevExpressMvcApplication1.Controllers
    Public Class HomeController
        Inherits Controller
        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
            ViewData("Categories") = New NorthwindEntities().Categories
            Return View()
        End Function

        Public Function CallbackPanelPartial() As ActionResult
            Return PartialView("CallbackPanelPartial")
        End Function

        Public Function ReportViewerPartial() As ActionResult
            Dim categoryId = If(Request.Params("CategoryID").ToString() <> "null", Request.Params("CategoryID"), Nothing)
            ViewData("Report") = GetReport(categoryId)
            Return PartialView("ReportViewerPartial")
        End Function

        Public Function ExportReportViewerPartial() As ActionResult
            Return DevExpress.Web.Mvc.ReportViewerExtension.ExportTo(GetReport(Session("CategoryID").ToString()))
        End Function

        Private Function GetReport(ByVal categoryID As Object) As XtraReport
            Dim report As New XtraReport1()

            If categoryID IsNot Nothing Then
                report.CatId.Value = Convert.ToInt32(categoryID)
            Else
                report.FilterString = String.Empty
            End If

            AddHandler report.DataSourceDemanded, AddressOf DataSourceDemandedEventHandler
            Return report
        End Function

        Private Sub DataSourceDemandedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
            CType(sender, XtraReport).DataSource = New NorthwindEntities().Products
        End Sub
    End Class
End Namespace
