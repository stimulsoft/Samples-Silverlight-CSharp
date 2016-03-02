using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.ReportControls;
using Stimulsoft.Report.Components;

namespace Reports
{
    public class ChartOnDataband : Stimulsoft.Report.StiReport
    {
        public ChartOnDataband()
        {
            this.InitializeComponent();
        }

        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentSuppliers;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentCategories;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentEmployees1;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentShippers;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentCustomers;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentOrders;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentProducts2;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentEmployees;
        public string LastEmployeeName;
        public string LastCountryName;
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand1;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand2;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Chart.StiChart Chart1;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart1_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart1_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item28;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item28_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart1_SeriesLabels;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        public Stimulsoft.Report.StiStyle StyleOdd;
        public CategoriesDataSource Categories;
        public CustomersDataSource Customers;
        public EmployeesDataSource Employees;
        public Order_DetailsDataSource Order_Details;
        public OrdersDataSource Orders;
        public ProductsDataSource Products;
        public ShippersDataSource Shippers;
        public SuppliersDataSource Suppliers;
        public CountriesDataSource Countries;
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text6_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stimulsoft";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Chart on Databand";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text18.TextFormat.Format(CheckExcelValue(sender, "Date: " + Today.ToString("Y")));
        }
        
        public void Item28__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row";
        }
        
        public void ReportWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text6.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text6_GetValue_End));
        }
        
        private void InitializeComponent()
        {
            this.Countries = new CountriesDataSource();
            this.Suppliers = new SuppliersDataSource();
            this.Shippers = new ShippersDataSource();
            this.Products = new ProductsDataSource();
            this.Orders = new OrdersDataSource();
            this.Order_Details = new Order_DetailsDataSource();
            this.Employees = new EmployeesDataSource();
            this.Customers = new CustomersDataSource();
            this.Categories = new CategoriesDataSource();
            this.ParentSuppliers = new Stimulsoft.Report.Dictionary.StiDataRelation("SuppliersProducts", "Suppliers", "Suppliers", this.Suppliers, this.Products, new System.String[] {
                        "SupplierID"}, new System.String[] {
                        "SupplierID"});
            this.ParentCategories = new Stimulsoft.Report.Dictionary.StiDataRelation("CategoriesProducts", "Categories", "Categories", this.Categories, this.Products, new System.String[] {
                        "CategoryID"}, new System.String[] {
                        "CategoryID"});
            this.ParentEmployees1 = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesOrders", "Employees", "Employees", this.Employees, this.Orders, new System.String[] {
                        "EmployeeID"}, new System.String[] {
                        "EmployeeID"});
            this.ParentShippers = new Stimulsoft.Report.Dictionary.StiDataRelation("ShippersOrders", "Shippers", "Shippers", this.Shippers, this.Orders, new System.String[] {
                        "ShipperID"}, new System.String[] {
                        "ShipVia"});
            this.ParentCustomers = new Stimulsoft.Report.Dictionary.StiDataRelation("CustomersOrders", "Customers", "Customers", this.Customers, this.Orders, new System.String[] {
                        "CustomerID"}, new System.String[] {
                        "CustomerID"});
            this.ParentOrders = new Stimulsoft.Report.Dictionary.StiDataRelation("OrdersOrder_Details", "Orders", "Orders", this.Orders, this.Order_Details, new System.String[] {
                        "OrderID"}, new System.String[] {
                        "OrderID"});
            this.ParentProducts2 = new Stimulsoft.Report.Dictionary.StiDataRelation("ProductsOrder_Details", "Products2", "Products2", this.Products, this.Order_Details, new System.String[] {
                        "ProductID"}, new System.String[] {
                        "ProductID"});
            this.ParentEmployees = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesEmployees", "Employees", "Employees", this.Employees, this.Employees, new System.String[] {
                        "EmployeeID"}, new System.String[] {
                        "ReportsTo"});
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "LastEmployeeName", "LastEmployeeName", "", typeof(string), "", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "LastCountryName", "LastCountryName", "", typeof(string), "", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, false));
            this.NeedsCompiling = false;
            // 
            // Variables init
            // 
            this.LastEmployeeName = "";
            this.LastCountryName = "";
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ReferencedAssemblies = new System.String[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Chart on Databand";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 3, 24, 16, 35, 16, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2006, 6, 1, 11, 13, 9, 0);
            this.ReportDescription = "This sample demonstrates how to use a chart with DataBand.";
            this.ReportFile = "E:\\Stimulsoft\\Stimulsoft.Reports\\Demo\\Bin\\Reports\\ChartOnDataband.mrt";
            this.ReportGuid = "af0ce6835f884c868162780a34a671cf";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.923";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "9c908c2b32a048c4a1d606e2b31ec424";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 29.7;
            this.Page1.PageWidth = 21;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageFooterBand1
            // 
            this.PageFooterBand1 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 27.3, 19, 0.4);
            this.PageFooterBand1.Guid = "cfc0da23f77940589d85270459b79ab2";
            this.PageFooterBand1.Name = "PageFooterBand1";
            this.PageFooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.PageFooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 12.2, 0.4);
            this.Text6.ComponentStyle = "Footer1";
            this.Text6.Guid = "35c92789ba9b44799f5568855351567c";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text6.Font = new System.Drawing.Font("Arial", 9F);
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooterBand1.Interaction = null;
            // 
            // ReportTitleBand2
            // 
            this.ReportTitleBand2 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 2);
            this.ReportTitleBand2.Guid = "6565f28ca68f45a3a5824db5ff2dba66";
            this.ReportTitleBand2.Name = "ReportTitleBand2";
            this.ReportTitleBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.ReportTitleBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.4, 0, 9.6, 0.8);
            this.Text20.ComponentStyle = "Title1";
            this.Text20.Guid = "364d6fc6251f4cef951ba38b87087284";
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text20.Font = new System.Drawing.Font("Arial", 19F);
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9.4, 0.8);
            this.Text23.ComponentStyle = "Title1";
            this.Text23.Guid = "cdd1d88975ce43e4b47c10de07c1a91c";
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text23.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text23.Font = new System.Drawing.Font("Arial", 19F);
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.CanGrow = true;
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1, 14.6, 0.8);
            this.Text17.ComponentStyle = "Title2";
            this.Text17.Guid = "42722b0aaa7c4265a93a670a11f7e1cd";
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text17.Font = new System.Drawing.Font("Arial", 9F);
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.CanGrow = true;
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14.6, 1, 4.4, 0.8);
            this.Text18.ComponentStyle = "Title2";
            this.Text18.Guid = "1e99a37036cd4beeba4fbddb04fe507b";
            this.Text18.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text18.Font = new System.Drawing.Font("Arial", 9F);
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text18.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("yyyy, MMMM", " ");
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand2.Interaction = null;
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.2, 19, 12);
            this.DataBand1.DataSourceName = "Categories";
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new System.String[] {
                    "ASC",
                    "CategoryName"};
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand1.BusinessObjectGuid = null;
            // 
            // Chart1
            // 
            this.Chart1 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 11.6);
            this.Chart1.CustomStyleName = "";
            this.Chart1.DataRelationName = "CategoriesProducts";
            this.Chart1.DataSourceName = "Products";
            this.Chart1.Name = "Chart1";
            this.Chart1.Sort = new System.String[0];
            this.Chart1_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart1_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart1_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart1_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart1_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart1_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart1_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart1_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart1.Guid = null;
            this.Chart1.Interaction = null;
            this.Chart1_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart1_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart1_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart1_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart1_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart1.MasterComponent = null;
            // 
            // Item28
            // 
            this.Item28 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item28.ArgumentDataColumn = "Products.ProductName";
            this.Item28.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item28.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item28__GetTitle);
            this.Item28.ValueDataColumn = "Products.UnitPrice";
            this.Item28.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 144, 67, 3), System.Drawing.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item28.DrillDownPageGuid = null;
            this.Item28_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item28_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item28_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item28_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item28_SeriesLabels.ValueTypeSeparator = "-";
            this.Item28_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item28_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart1_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart1_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart1_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart1_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart1_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart1.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart1.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            this.DataBand1.Guid = null;
            this.DataBand1.Interaction = null;
            this.DataBand1.MasterComponent = null;
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
            // 
            // StyleOdd
            // 
            this.StyleOdd = new Stimulsoft.Report.StiStyle();
            this.StyleOdd.Name = "Odd";
            this.StyleOdd.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleOdd.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.PapayaWhip);
            this.StyleOdd.Font = new System.Drawing.Font("Arial", 8F);
            this.StyleOdd.Image = null;
            this.StyleOdd.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.PageFooterBand1.Page = this.Page1;
            this.PageFooterBand1.Parent = this.Page1;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.PageFooterBand1;
            this.ReportTitleBand2.Page = this.Page1;
            this.ReportTitleBand2.Parent = this.Page1;
            this.Text20.Page = this.Page1;
            this.Text20.Parent = this.ReportTitleBand2;
            this.Text23.Page = this.Page1;
            this.Text23.Parent = this.ReportTitleBand2;
            this.Text17.Page = this.Page1;
            this.Text17.Parent = this.ReportTitleBand2;
            this.Text18.Page = this.Page1;
            this.Text18.Parent = this.ReportTitleBand2;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.Chart1.Area = this.Chart1_Area;
            this.Chart1.Legend = this.Chart1_Legend;
            this.Chart1.Page = this.Page1;
            this.Chart1.Parent = this.DataBand1;
            this.Chart1.SeriesLabels = this.Chart1_SeriesLabels;
            this.Chart1_Area.Chart = this.Chart1;
            this.Chart1_Legend.Chart = this.Chart1;
            this.Item28.Chart = this.Chart1;
            this.Item28.SeriesLabels = this.Item28_SeriesLabels;
            this.Item28_SeriesLabels.Chart = this.Chart1;
            this.Chart1_SeriesLabels.Chart = this.Chart1;
            this.EndRender += new System.EventHandler(this.ReportWordsToEnd__EndRender);
            // 
            // Add to PageFooterBand1.Components
            // 
            this.PageFooterBand1.Components.Clear();
            this.PageFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text6});
            // 
            // Add to ReportTitleBand2.Components
            // 
            this.ReportTitleBand2.Components.Clear();
            this.ReportTitleBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text20,
                        this.Text23,
                        this.Text17,
                        this.Text18});
            // 
            // Add to Chart1.Series
            // 
            this.Chart1.Series.Clear();
            this.Chart1.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item28});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Chart1});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooterBand1,
                        this.ReportTitleBand2,
                        this.DataBand1});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            // 
            // Add to Styles
            // 
            this.Styles.Clear();
            this.Styles.AddRange(new Stimulsoft.Report.StiBaseStyle[] {
                        this.StyleOdd});
            this.Dictionary.Relations.Add(this.ParentEmployees);
            this.Dictionary.Relations.Add(this.ParentProducts2);
            this.Dictionary.Relations.Add(this.ParentOrders);
            this.Dictionary.Relations.Add(this.ParentCustomers);
            this.Dictionary.Relations.Add(this.ParentShippers);
            this.Dictionary.Relations.Add(this.ParentEmployees1);
            this.Dictionary.Relations.Add(this.ParentCategories);
            this.Dictionary.Relations.Add(this.ParentSuppliers);
            this.Categories.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryName", "CategoryName", "CategoryName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Description", "Description", "Description", typeof(string))});
            this.DataSources.Add(this.Categories);
            this.Customers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactName", "ContactName", "ContactName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactTitle", "ContactTitle", "ContactTitle", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Fax", "Fax", "Fax", typeof(string))});
            this.DataSources.Add(this.Customers);
            this.Employees.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", "EmployeeID", "EmployeeID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("LastName", "LastName", "LastName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("FirstName", "FirstName", "FirstName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Title", "Title", "Title", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BirthDate", "BirthDate", "BirthDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HireDate", "HireDate", "HireDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HomePhone", "HomePhone", "HomePhone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Notes", "Notes", "Notes", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ReportsTo", "ReportsTo", "ReportsTo", typeof(int))});
            this.DataSources.Add(this.Employees);
            this.Order_Details.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", "OrderID", "OrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Quantity", "Quantity", "Quantity", typeof(short)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Discount", "Discount", "Discount", typeof(float))});
            this.DataSources.Add(this.Order_Details);
            this.Orders.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", "OrderID", "OrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", "EmployeeID", "EmployeeID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("RequiredDate", "RequiredDate", "RequiredDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShippedDate", "ShippedDate", "ShippedDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipVia", "ShipVia", "ShipVia", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Freight", "Freight", "Freight", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipName", "ShipName", "ShipName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipAddress", "ShipAddress", "ShipAddress", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCity", "ShipCity", "ShipCity", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipRegion", "ShipRegion", "ShipRegion", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipPostalCode", "ShipPostalCode", "ShipPostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCountry", "ShipCountry", "ShipCountry", typeof(string))});
            this.DataSources.Add(this.Orders);
            this.Products.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductName", "ProductName", "ProductName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("QuantityPerUnit", "QuantityPerUnit", "QuantityPerUnit", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short))});
            this.DataSources.Add(this.Products);
            this.Shippers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipperID", "ShipperID", "ShipperID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string))});
            this.DataSources.Add(this.Shippers);
            this.Suppliers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactName", "ContactName", "ContactName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactTitle", "ContactTitle", "ContactTitle", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Fax", "Fax", "Fax", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HomePage", "HomePage", "HomePage", typeof(string))});
            this.DataSources.Add(this.Suppliers);
            this.Countries.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountriesID", "CountriesID", "CountriesID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Flag", "Flag", "Flag", typeof(byte[])),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string))});
            this.DataSources.Add(this.Countries);
        }
        
        #region Relation ParentEmployees
        public class ParentEmployeesRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentEmployeesRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual string LastName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["LastName"], typeof(string), true)));
                }
            }
            
            public virtual string FirstName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["FirstName"], typeof(string), true)));
                }
            }
            
            public virtual string Title
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Title"], typeof(string), true)));
                }
            }
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string HomePhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["HomePhone"], typeof(string), true)));
                }
            }
            
            public virtual string Notes
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Notes"], typeof(string), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesEmployees"));
                }
            }
        }
        #endregion Relation ParentEmployees
        
        #region Relation ParentProducts2
        public class ParentProducts2Relation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentProducts2Relation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int ProductID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ProductID"], typeof(int), true)));
                }
            }
            
            public virtual string ProductName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ProductName"], typeof(string), true)));
                }
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual string QuantityPerUnit
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
                }
            }
            
            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }
            
            public virtual short UnitsInStock
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["UnitsInStock"], typeof(short), true)));
                }
            }
            
            public virtual ParentCategoriesRelation Categories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("CategoriesProducts"));
                }
            }
            
            public virtual ParentSuppliersRelation Suppliers
            {
                get
                {
                    return new ParentSuppliersRelation(this.GetParentData("SuppliersProducts"));
                }
            }
        }
        #endregion Relation ParentProducts2
        
        #region Relation ParentOrders
        public class ParentOrdersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentOrdersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
            }
            
            public virtual string CustomerID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerID"], typeof(string), true)));
                }
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime RequiredDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["RequiredDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime ShippedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ShippedDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual int ShipVia
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipVia"], typeof(int), true)));
                }
            }
            
            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }
            
            public virtual string ShipName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipName"], typeof(string), true)));
                }
            }
            
            public virtual string ShipAddress
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipAddress"], typeof(string), true)));
                }
            }
            
            public virtual string ShipCity
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipCity"], typeof(string), true)));
                }
            }
            
            public virtual string ShipRegion
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipRegion"], typeof(string), true)));
                }
            }
            
            public virtual string ShipPostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipPostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string ShipCountry
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipCountry"], typeof(string), true)));
                }
            }
            
            public virtual ParentCustomersRelation Customers
            {
                get
                {
                    return new ParentCustomersRelation(this.GetParentData("CustomersOrders"));
                }
            }
            
            public virtual ParentShippersRelation Shippers
            {
                get
                {
                    return new ParentShippersRelation(this.GetParentData("ShippersOrders"));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesOrders"));
                }
            }
        }
        #endregion Relation ParentOrders
        
        #region Relation ParentCustomers
        public class ParentCustomersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentCustomersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual string CustomerID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerID"], typeof(string), true)));
                }
            }
            
            public virtual string CompanyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CompanyName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactTitle
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactTitle"], typeof(string), true)));
                }
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string Fax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Fax"], typeof(string), true)));
                }
            }
        }
        #endregion Relation ParentCustomers
        
        #region Relation ParentShippers
        public class ParentShippersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentShippersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int ShipperID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipperID"], typeof(int), true)));
                }
            }
            
            public virtual string CompanyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CompanyName"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
        }
        #endregion Relation ParentShippers
        
        #region Relation ParentEmployees1
        public class ParentEmployees1Relation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentEmployees1Relation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual string LastName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["LastName"], typeof(string), true)));
                }
            }
            
            public virtual string FirstName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["FirstName"], typeof(string), true)));
                }
            }
            
            public virtual string Title
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Title"], typeof(string), true)));
                }
            }
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string HomePhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["HomePhone"], typeof(string), true)));
                }
            }
            
            public virtual string Notes
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Notes"], typeof(string), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesEmployees"));
                }
            }
        }
        #endregion Relation ParentEmployees1
        
        #region Relation ParentCategories
        public class ParentCategoriesRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentCategoriesRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual string CategoryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CategoryName"], typeof(string), true)));
                }
            }
            
            public virtual string Description
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Description"], typeof(string), true)));
                }
            }
        }
        #endregion Relation ParentCategories
        
        #region Relation ParentSuppliers
        public class ParentSuppliersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentSuppliersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual string CompanyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CompanyName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactTitle
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactTitle"], typeof(string), true)));
                }
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string Fax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Fax"], typeof(string), true)));
                }
            }
            
            public virtual string HomePage
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["HomePage"], typeof(string), true)));
                }
            }
        }
        #endregion Relation ParentSuppliers
        
        #region DataSource Categories
        public class CategoriesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CategoriesDataSource() : 
                    base("Demo.Categories", "Categories")
            {
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual string CategoryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CategoryName"], typeof(string), true)));
                }
            }
            
            public virtual string Description
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Description"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Categories
        
        #region DataSource Customers
        public class CustomersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CustomersDataSource() : 
                    base("Demo.Customers", "Customers")
            {
            }
            
            public virtual string CustomerID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerID"], typeof(string), true)));
                }
            }
            
            public virtual string CompanyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CompanyName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactTitle
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactTitle"], typeof(string), true)));
                }
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string Fax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Fax"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Customers
        
        #region DataSource Employees
        public class EmployeesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public EmployeesDataSource() : 
                    base("Demo.Employees", "Employees")
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual string LastName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["LastName"], typeof(string), true)));
                }
            }
            
            public virtual string FirstName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["FirstName"], typeof(string), true)));
                }
            }
            
            public virtual string Title
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Title"], typeof(string), true)));
                }
            }
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string HomePhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["HomePhone"], typeof(string), true)));
                }
            }
            
            public virtual string Notes
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Notes"], typeof(string), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesEmployees"));
                }
            }
        }
        #endregion DataSource Employees
        
        #region DataSource Order_Details
        public class Order_DetailsDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public Order_DetailsDataSource() : 
                    base("Demo.Order Details", "Order Details")
            {
            }
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
            }
            
            public virtual int ProductID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ProductID"], typeof(int), true)));
                }
            }
            
            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }
            
            public virtual short Quantity
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["Quantity"], typeof(short), true)));
                }
            }
            
            public virtual float Discount
            {
                get
                {
                    return ((float)(StiReport.ChangeType(this["Discount"], typeof(float), true)));
                }
            }
            
            public virtual ParentProducts2Relation Products2
            {
                get
                {
                    return new ParentProducts2Relation(this.GetParentData("ProductsOrder_Details"));
                }
            }
            
            public virtual ParentOrdersRelation Orders
            {
                get
                {
                    return new ParentOrdersRelation(this.GetParentData("OrdersOrder_Details"));
                }
            }
        }
        #endregion DataSource Order_Details
        
        #region DataSource Orders
        public class OrdersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public OrdersDataSource() : 
                    base("Demo.Orders", "Orders")
            {
            }
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
            }
            
            public virtual string CustomerID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerID"], typeof(string), true)));
                }
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime RequiredDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["RequiredDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime ShippedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ShippedDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual int ShipVia
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipVia"], typeof(int), true)));
                }
            }
            
            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }
            
            public virtual string ShipName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipName"], typeof(string), true)));
                }
            }
            
            public virtual string ShipAddress
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipAddress"], typeof(string), true)));
                }
            }
            
            public virtual string ShipCity
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipCity"], typeof(string), true)));
                }
            }
            
            public virtual string ShipRegion
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipRegion"], typeof(string), true)));
                }
            }
            
            public virtual string ShipPostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipPostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string ShipCountry
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipCountry"], typeof(string), true)));
                }
            }
            
            public virtual ParentCustomersRelation Customers
            {
                get
                {
                    return new ParentCustomersRelation(this.GetParentData("CustomersOrders"));
                }
            }
            
            public virtual ParentShippersRelation Shippers
            {
                get
                {
                    return new ParentShippersRelation(this.GetParentData("ShippersOrders"));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesOrders"));
                }
            }
        }
        #endregion DataSource Orders
        
        #region DataSource Products
        public class ProductsDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public ProductsDataSource() : 
                    base("Demo.Products", "Products")
            {
            }
            
            public virtual int ProductID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ProductID"], typeof(int), true)));
                }
            }
            
            public virtual string ProductName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ProductName"], typeof(string), true)));
                }
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual string QuantityPerUnit
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
                }
            }
            
            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }
            
            public virtual short UnitsInStock
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["UnitsInStock"], typeof(short), true)));
                }
            }
            
            public virtual ParentCategoriesRelation Categories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("CategoriesProducts"));
                }
            }
            
            public virtual ParentSuppliersRelation Suppliers
            {
                get
                {
                    return new ParentSuppliersRelation(this.GetParentData("SuppliersProducts"));
                }
            }
        }
        #endregion DataSource Products
        
        #region DataSource Shippers
        public class ShippersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public ShippersDataSource() : 
                    base("Demo.Shippers", "Shippers")
            {
            }
            
            public virtual int ShipperID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipperID"], typeof(int), true)));
                }
            }
            
            public virtual string CompanyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CompanyName"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Shippers
        
        #region DataSource Suppliers
        public class SuppliersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public SuppliersDataSource() : 
                    base("Demo.Suppliers", "Suppliers")
            {
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual string CompanyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CompanyName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactTitle
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactTitle"], typeof(string), true)));
                }
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string Fax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Fax"], typeof(string), true)));
                }
            }
            
            public virtual string HomePage
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["HomePage"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Suppliers
        
        #region DataSource Countries
        public class CountriesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CountriesDataSource() : 
                    base("Demo.Countries", "Countries")
            {
            }
            
            public virtual int CountriesID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CountriesID"], typeof(int), true)));
                }
            }
            
            public virtual byte[] Flag
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["Flag"], typeof(byte[]), true)));
                }
            }
            
            public virtual string CountryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CountryName"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Countries
        #endregion StiReport Designer generated code - do not modify
    }
}