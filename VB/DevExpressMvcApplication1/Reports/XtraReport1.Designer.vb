' Developer Express Code Central Example:
' How to use XtraReports in an ASP.NET MVC application
' 
' This sample demonstrates a simple ASP.NET MVC application that contains a static
' report and shows its print preview on the Web page.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3248


Imports Microsoft.VisualBasic
Imports System
Imports DevExpressMvcApplication1.Models
Imports NorthwindModel

Namespace DevExpressMvcApplication1.Reports
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.CatId = New DevExpress.XtraReports.Parameters.Parameter()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.HeightF = 25.0F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(102.0834F, 0.0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(547.9166F, 25.0F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell5, Me.xrTableCell9})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ProductName")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 1.0350098089635726R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "UnitPrice")})
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Text = "xrTableCell9"
            Me.xrTableCell9.Weight = 0.39151868470321749R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' CatId
            ' 
            Me.CatId.Description = "Category ID"
            Me.CatId.Name = "CatId"
            Me.CatId.Type = GetType(Integer)
            Me.CatId.Value = 0
            Me.CatId.Visible = False
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
            Me.GroupHeader1.HeightF = 23.0F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.Bisque
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryID")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0F, 0.0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(101.0417F, 23.0F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = GetType(Product)
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
            Me.DataSource = Me.bindingSource1
            Me.FilterString = "[CategoryID] = ?CatId"
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.CatId})
            Me.Version = "12.1"
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Public CatId As DevExpress.XtraReports.Parameters.Parameter
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
