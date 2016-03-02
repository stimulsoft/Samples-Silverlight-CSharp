using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Stimulsoft.Report;
using Stimulsoft.Report.WebSL;
using Stimulsoft.Report.WebDesignSL;
using Reports;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        StiWebViewerSL1.ViewerSource = "Source/ViewerSL.xap";
        StiWebViewerSL1.ViewerSplashScreenSource = "Source/SilverlightLogo.xaml";
        StiWebViewerSL1.ViewerSplashScreenProgressChangedMethodName = "onSourceDownloadProgressChanged";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page != null)
        {
            string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);

            // Определяем выбранный отчёт
            string keyValue = Page.Request.QueryString.Get("reportname");
            if (keyValue == null) keyValue = "SimpleList";

            StiReport report = new StiReport();
            string text = string.Empty;
            bool isRender = false;
            switch (keyValue)
            {
                // Basic Reports
                case "SimpleList": report = new SimpleList(); text = "The sample demonstrates how to create a simple list report."; isRender = true; break;
                case "TwoSimpleLists": report = new TwoSimpleLists(); text = "The sample demonstrates how to create two simple list reports."; isRender = true; break;
                case "HighlightCondition": report = new HighlightCondition(); text = "The sample demonstrates how to use highlight condition to create a report."; isRender = true; break;
                case "Shapes": report = new Shapes(); text = "The sample demonstrates how to create a report with shapes."; isRender = true; break;
                case "Images": report = new Images(); text = "The sample demonstrates how to create a report with images."; isRender = true; break;
                case "Watermark": report = new Watermark(); text = "The sample demonstrates how to create a report with watermark."; isRender = true; break;
                case "BarCodes": report = new BarCodes(); text = "The sample demonstrates how to create a report with BarCodes."; isRender = true; break;
                case "Invoice": report = new Invoice(); text = "A simple invoice."; isRender = true; break;
                case "Indicators": report.Load(appDirectory + "\\Reports\\Indicators.mrt"); text = "This sample shows how to use indicators in the report."; break;

                // Reports with Columns
                case "MultiColumnList": report = new MultiColumnList(); text = "The sample demonstrates how to create a report with multiple columns. To create a report with columns set the Columns property of a page in two or more."; isRender = true; break;
                case "MultiColumnBandsAcrossThenDown": report = new MultiColumnBandsAcrossThenDown(); text = "The sample demonstrates how to create a report with multiple columns on the bands. Multicolumn direction - across then down."; isRender = true; break;
                case "MultiColumnBandsDownThenAcross": report = new MultiColumnBandsDownThenAcross(); text = "The sample demonstrates how to create a report with multiple columns on the bands. Multicolumn direction - down then across."; isRender = true; break;
                case "Labels": report = new Labels(); text = "The sample demonstrates how to create a report with labels."; isRender = true; break;

                // Master-Detail Reports
                case "MasterDetail": report = new MasterDetail(); text = "The sample demonstrates how to create a Master-Detail report."; isRender = true; break;
                case "MasterDetailSubdetail": report = new MasterDetailSubdetail(); text = "The sample demonstrates how to create a Master-Detail-Subdetail report."; isRender = true; break;
                case "MasterDetailWithColumns": report = new MasterDetailWithColumns(); text = "The sample demonstrates how to create a Master-Detail report with columns."; isRender = true; break;
                case "TwoMastersOnOneDetail": report = new TwoMastersOnOneDetail(); text = "The sample demonstrates how to create a report with two master-detail links. And detail for both links is the same."; isRender = true; break;
                case "MasterDetailWithZeroHeight": report = new MasterDetailWithZeroHeight(); text = "The sample demonstrates how to create a Master-Detail report in which one of the bands has the zero height."; isRender = true; break;
                case "MasterDetailOnDataBand": report = new MasterDetailOnDataBand(); text = "The sample demonstrates how to create a Master-Detail report in which one of the bands placed on other."; isRender = true; break;

                // Reports with Groups
                case "SimpleGroup": report = new SimpleGroup(); text = "The sample demonstrates how to create a simple group report with one group."; isRender = true; break;
                case "NestedGroups": report = new NestedGroups(); text = "The sample demonstrates how to create a report using several groups."; isRender = true; break;
                case "GroupsTopSales": report = new GroupsTopSales(); text = "This sample demonstrates how to sort group by its totals."; isRender = true; break;
                case "MasterDetailWithGroups": report = new MasterDetailWithGroups(); text = "The sample demonstrates how to create a Master-Detail report with groups."; isRender = true; break;
                case "MultiColumnGroup": report = new MultiColumnGroup(); text = "The sample demonstrates how to create a simple group report with two columns on page."; isRender = true; break;
                case "GroupsWithRanges": report = new GroupsWithRanges(); text = "The sample demonstrates how to create groups with ranges in report."; isRender = true; break;
                case "SimpleGroupWithColumns": report = new SimpleGroupWithColumns(); text = "The sample demonstrates how to create a simple group report with multiple columns on the bands. Multicolumn direction - across then down."; isRender = true; break;
                case "AllGroupFootersAtEnd": report = new AllGroupFootersAtEnd(); text = "This sample shows all group footers at the bottom of Report."; isRender = true; break;
                case "InvoiceWithGroups": report = new InvoiceWithGroups(); text = "An invoice with categories."; isRender = true; break;
                case "SalesInvoice": report = new SalesInvoice(); text = "Sales invoice."; isRender = true; break;

                // Hierarchical Reports
                case "Tree": report = new Tree(); text = "The sample demonstrates how to create hierarchical report."; isRender = true; break;
                case "TreeWithHeadersFooters": report = new TreeWithHeadersFooters(); text = "The sample demonstrates how to create hierarchical wiith headers and footers."; isRender = true; break;
                case "TreeWithTotals": report = new TreeWithTotals(); text = "The sample demonstrates how to create hierarchical report with totals."; isRender = true; break;
                case "TreeWithTotalsAllLevels": report = new TreeWithTotalsAllLevels(); text = "The sample demonstrates how to create hierarchical report with totals which include all sub-levels of tree."; isRender = true; break;
                case "TreeWithLockedComponents": report = new TreeWithLockedComponents(); text = "The sample demonstrates how to create hierarchical report with locked components."; isRender = true; break;

                // Parameters
                case "ParametersDetailedCategories": report.Load(appDirectory + "\\Reports\\ParametersDetailedCategories.mrt"); text = "Detailing by selected category of products."; break;
                case "ParametersDetailedOrders": report.Load(appDirectory + "\\Reports\\ParametersDetailedOrders.mrt"); text = "Detailing of the list of orders by specified number."; break;
                case "ParametersHighlightCondition": report.Load(appDirectory + "\\Reports\\ParametersHighlightCondition.mrt"); text = "Highlighting data rows by selected conditions."; break;
                //case "ParametersSelectingCountry": report.Load(appDirectory + "\\Reports\\ParametersSelectingCountry.mrt"); text = "Showing data only by selected countries."; break;
                //case "ParametersDateRange": report.Load(appDirectory + "\\Reports\\ParametersDateRange.mrt"); text = "Selecting the date range for printing data."; break;
                case "ParametersInvoice": report.Load(appDirectory + "\\Reports\\ParametersInvoice.mrt"); text = "This sample requests parameters for printing an invoice."; break;

                // Interactive Reports
                case "DrillDownListOfProducts": report.Load(appDirectory + "\\Reports\\DrillDownListOfProducts.mrt"); text = "The sample demonstrates how to use drill-down reports."; break;
                case "DrillDownGroupWithCollapsing": report.Load(appDirectory + "\\Reports\\DrillDownGroupWithCollapsing.mrt"); text = "The sample demonstrates how to use GroupHeaderBand without GroupFooterBand."; break;
                case "DrillDownSorting": report.Load(appDirectory + "\\Reports\\DrillDownSorting.mrt"); text = "The sample demonstrates how to use interactive sorting."; break;
                case "DrillDownGroupWithCollapsingWithoutFooter": report.Load(appDirectory + "\\Reports\\DrillDownGroupWithCollapsingWithoutFooter.mrt"); text = "The sample demonstrates how to use GroupHeaderBand without GroupFooterBand."; break;
                case "DrillDownMasterDetailWithCollapsing": report.Load(appDirectory + "\\Reports\\DrillDownMasterDetailWithCollapsing.mrt"); text = "The sample demonstrates how to use Master-Detail report with collapsing."; break;
                case "EditableReport": report.Load(appDirectory + "\\Reports\\EditableReport.mrt"); text = "The sample demonstrates how to edit a rendered report in the Preview Window."; break;
                case "BookmarksHyperlinks": report.Load(appDirectory + "\\Reports\\BookmarksHyperlinks.mrt"); text = "The sample demonstrates how to use bookmarks and hyperlinks."; break;
                case "Anchors": report.Load(appDirectory + "\\Reports\\Anchors.mrt"); text = "The sample demonstrates how to use anchors."; break;

                // Charts
                case "ChartColumnsAndBars": report = new ChartColumnsAndBars(); text = "This sample demonstrates Column and Bar chart types."; isRender = true; break;
                case "ChartLinesAndSplines": report = new ChartLinesAndSplines(); text = "This sample demonstrates Line and Spline chart types."; isRender = true; break;
                case "ChartAreas": report = new ChartAreas(); text = "This sample demonstrates Areas chart types."; isRender = true; break;
                case "ChartPieAndDoughnut": report = new ChartPieAndDoughnut(); text = "This sample demonstrates Pie and Doughnut chart types."; isRender = true; break;
                case "ChartStyles": report = new ChartStyles(); text = "This sample demonstrates different chart styles."; isRender = true; break;
                case "ChartOnDataband": report = new ChartOnDataband(); text = "This sample demonstrates how to use a chart with DataBand."; isRender = true; break;

                // Reports with EmptyBand
                case "SimpleListWithEmptyLines": report = new SimpleListWithEmptyLines(); text = "The sample demonstrates how to create a simple list report with empty lines on the bottom of a page."; isRender = true; break;
                case "MasterDetailWithEmptyLines": report = new MasterDetailWithEmptyLines(); text = "The sample demonstrates how to create a Master-Detail report with empty lines on the bottom of a page."; isRender = true; break;
                case "InvoiceWithEmptyBand": report = new InvoiceWithEmptyBand(); text = "An invoice created using an Empty Band."; isRender = true; break;

                // Containers
                case "SideBySideListWithContainers": report = new SideBySideListWithContainers(); text = "The sample demonstrates how to create a report that contains two side by side lists with containers."; isRender = true; break;
                case "SideBySideGroupWithContainers": report = new SideBySideGroupWithContainers(); text = "The sample demonstrates how to create a report that contains two side by side groups with containers."; isRender = true; break;
                case "MultiColumnListContainers": report = new MultiColumnListContainers(); text = "The sample demonstrates how to create a report with multiple columns using containers."; isRender = true; break;
                case "MasterDetailCards": report = new MasterDetailCards(); text = "The sample demonstrates how to create a Master-Detail report which data are grouped as cards."; isRender = true; break;

                // SubReports
                //case "SideBySideListWithSubReports": report = new SideBySideListWithSubReports(); text = "The sample demonstrates how to create a report that contains two side by side lists with SubReports."; isRender = true; break;
                //case "SideBySideGroupWithSubReports": report = new StiSideBySideGroupWithSubReportsReport(); text = "The sample demonstrates how to create a report that contains two side by side groups with SubReports."; break;
                //case "MasterDetailWithSubReports": report = new StiMasterDetailWithSubReportsReport(); text = "The sample demonstrates how to create a Master-Detail report with SubReports."; break;
            }

            //report = new StiReport();
            //report.Load(appDirectory + "\\Reports\\shapes.mrt");
            LabelText.Text = text;

            RenderReport(report, isRender);
            StiWebViewerSL1.Report = report;
        }
    }

    private void RenderReport(StiReport report, bool isRender)
    {
        string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);
        DataSet data = new DataSet();
        data.ReadXmlSchema(appDirectory + "\\Data\\Demo.xsd");
        data.ReadXml(appDirectory + "\\Data\\Demo.xml");
        report.RegData(data);

        if (isRender) report.Render(false);
    }

    protected void StiWebViewerSL_GetPreviewDataSet(object sender, StiWebViewerSL.StiPreviewDataSetEventArgs e)
    {
        string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);

        DataSet data = new DataSet();
        data.ReadXmlSchema(appDirectory + "\\Data\\Demo.xsd");
        data.ReadXml(appDirectory + "\\Data\\Demo.xml");

        e.PreviewDataSet = data;
    }

    protected void ButtonDesign_Click(object sender, EventArgs e)
    {
        string keyValue = Page.Request.QueryString.Get("reportname");
        if (keyValue == null) keyValue = "SimpleList";

        Page.Response.Redirect(string.Format("Designer.aspx?reportname={0}", keyValue));
    }
}
