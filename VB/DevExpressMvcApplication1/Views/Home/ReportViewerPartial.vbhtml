@Html.DevExpress().ReportViewer( _
    Sub(settings)
            settings.Name = "reportViewer1"
            settings.Report = CType(ViewData("Report"), DevExpress.XtraReports.UI.XtraReport)
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "ReportViewerPartial"}
            settings.ExportRouteValues = New With {Key .Controller = "Home", Key .Action = "ExportReportViewerPartial"}
            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"
    End Sub).GetHtml()
