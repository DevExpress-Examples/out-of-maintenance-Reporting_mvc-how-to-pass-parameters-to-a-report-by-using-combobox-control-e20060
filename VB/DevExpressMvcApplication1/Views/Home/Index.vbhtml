@Code 
    ViewBag.Title = "Home Page"
End Code

<h2>@ViewBag.Message</h2>
<p>
    To learn more about DevExpress Extensions for ASP.NET MVC visit <a href="http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/"
        title="ASP.NET MVC Website">http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/</a>.
</p>
<table>
    <tr>
        <td>
            @Html.DevExpress().ComboBox( _
           Sub(settings)
                   settings.Name = "comboBox1"
                   settings.Width = 300
                   settings.Properties.TextField = "CategoryName"
                   settings.Properties.ValueField = "CategoryID"
                   settings.Properties.ValueType = GetType(Integer)
                   settings.Properties.DropDownStyle = DropDownStyle.DropDownList
           End Sub).BindList(ViewData("Categories")).GetHtml()
        </td>
        <td>
            @Html.DevExpress().Button( _
           Sub(settings)
                   settings.Name = "buton1"
                   settings.ClientSideEvents.Click = "OnButtonClick"
                   settings.Width = 100
                   settings.Text = "Submit"
           End Sub).GetHtml()
        </td>
    </tr>
</table>

@Html.DevExpress().ReportToolbar( _
    Sub(settings)
            settings.Name = "ReportToolbar"
            settings.ReportViewerName = "reportViewer1"
    End Sub).GetHtml()

@Html.Partial("CallbackPanelPartial")