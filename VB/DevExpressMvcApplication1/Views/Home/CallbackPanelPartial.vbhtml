@Html.DevExpress().CallbackPanel( _
         Sub(settings)
                 settings.Name = "callbackPanel"
                 settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "CallbackPanelPartial"}
                 settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                 settings.Height = 300
                 settings.SetContent( _
                      Sub()
                              Html.RenderPartial("ReportViewerPartial")
                      End Sub)
               
         End Sub).GetHtml()
