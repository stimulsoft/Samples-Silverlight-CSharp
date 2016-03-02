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
    public class ChartColumnsAndBars : Stimulsoft.Report.StiReport
    {
        public ChartColumnsAndBars()
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
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentProducts;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentEmployees;
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Chart.StiChart Chart1;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart1_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart1_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item20;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item20_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart1_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart3;
        public Stimulsoft.Report.Chart.StiStackedColumnArea Chart3_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart3_Legend;
        public Stimulsoft.Report.Chart.StiStackedColumnSeries Item22;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item22_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedColumnSeries Item23;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item23_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart3_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart4;
        public Stimulsoft.Report.Chart.StiFullStackedColumnArea Chart4_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart4_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedColumnSeries Item25;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item25_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedColumnSeries Item26;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item26_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart4_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Chart.StiChart Chart2;
        public Stimulsoft.Report.Chart.StiClusteredBarArea Chart2_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart2_Legend;
        public Stimulsoft.Report.Chart.StiClusteredBarSeries Item29;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item29_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart2_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Chart.StiChart Chart5;
        public Stimulsoft.Report.Chart.StiStackedBarArea Chart5_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart5_Legend;
        public Stimulsoft.Report.Chart.StiStackedBarSeries Item32;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item32_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedBarSeries Item33;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item33_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart5_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Chart.StiChart Chart6;
        public Stimulsoft.Report.Chart.StiFullStackedBarArea Chart6_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart6_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedBarSeries Item36;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item36_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedBarSeries Item37;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item37_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart6_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        public CategoriesDataSource Categories;
        public CustomersDataSource Customers;
        public EmployeesDataSource Employees;
        public Order_DetailsDataSource Order_Details;
        public OrdersDataSource Orders;
        public ProductsDataSource Products;
        public ShippersDataSource Shippers;
        public SuppliersDataSource Suppliers;
        public CountriesDataSource Countries;
        
        public void Item20__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item20__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item20__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item22__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item22__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item22__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries January 2005";
        }
        
        public void Item23__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item23__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;55;60;20;70;31;24";
        }
        
        public void Item23__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries February 2005";
        }
        
        public void Item25__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item25__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;50;60;5;86;21;14";
        }
        
        public void Item25__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item26__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item26__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;40;40;15;70;31;54";
        }
        
        public void Item26__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 2";
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Column";
        }
        
        public void Item29__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item29__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;50;60;5;86;21;14";
        }
        
        public void Item29__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Clustered Bar";
        }
        
        public void Item32__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item32__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;50;60;5;86;21;14";
        }
        
        public void Item32__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item33__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item33__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;25;60;10;5;7";
        }
        
        public void Item33__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Bar";
        }
        
        public void Item36__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item36__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;50;60;5;86;21;14";
        }
        
        public void Item36__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item37__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item37__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;50;12;40;10;10";
        }
        
        public void Item37__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Bar";
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Clustered Column";
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Column";
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
            this.ParentProducts = new Stimulsoft.Report.Dictionary.StiDataRelation("ProductsOrder_Details", "Products", "Products", this.Products, this.Order_Details, new System.String[] {
                        "ProductID"}, new System.String[] {
                        "ProductID"});
            this.ParentEmployees = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesEmployees", "Employees", "Employees", this.Employees, this.Employees, new System.String[] {
                        "EmployeeID"}, new System.String[] {
                        "ReportsTo"});
            this.NeedsCompiling = false;
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
            this.ReportAlias = "ChartColumnsAndBars";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 2, 11, 20, 55, 48, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2006, 6, 6, 13, 21, 42, 0);
            this.ReportDescription = "This sample demonstrates Column and Bar chart types.";
            this.ReportFile = "E:\\Stimulsoft\\Stimulsoft.Reports\\Demo\\Bin\\Reports\\ChartColumnsAndBars.mrt";
            this.ReportGuid = "dab5fb00986f437080cea42a66e9f4cc";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.911";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "51f936b5480e4c998034de2eecdd5208";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 29.7;
            this.Page1.PageWidth = 21;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Chart1
            // 
            this.Chart1 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.2, 9.4, 8.4);
            this.Chart1.CountData = 7;
            this.Chart1.CustomStyleName = "";
            this.Chart1.FilterOn = false;
            this.Chart1.Name = "Chart1";
            this.Chart1.Sort = new System.String[0];
            this.Chart1_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart1_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Area.ShowShadow = true;
            this.Chart1_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart1_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart1_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart1_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart1_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart1_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart1_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart1.Guid = null;
            this.Chart1.Interaction = null;
            this.Chart1_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart1_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart1_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart1_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart1_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart1_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart1.MasterComponent = null;
            // 
            // Item20
            // 
            this.Item20 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item20.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item20.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item20__GetListOfArguments);
            this.Item20.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item20__GetListOfValues);
            this.Item20.ShowShadow = false;
            this.Item20.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item20__GetTitle);
            this.Item20.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 144, 67, 3), System.Drawing.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item20.DrillDownPageGuid = null;
            this.Item20_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item20_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item20_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item20_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item20_SeriesLabels.ValueTypeSeparator = "-";
            this.Item20_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item20_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart1_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart1_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart1_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart1_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart1_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart1.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart1.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart3
            // 
            this.Chart3 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 1.2, 9.4, 8.4);
            this.Chart3.CountData = 10;
            this.Chart3.CustomStyleName = "";
            this.Chart3.FilterOn = false;
            this.Chart3.Name = "Chart3";
            this.Chart3.Sort = new System.String[0];
            this.Chart3_Area = new Stimulsoft.Report.Chart.StiStackedColumnArea();
            this.Chart3_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart3_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart3_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart3_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart3_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart3_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart3_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart3_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart3_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart3_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart3.Guid = null;
            this.Chart3.Interaction = null;
            this.Chart3_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart3_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart3_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart3_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart3_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart3_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart3.MasterComponent = null;
            // 
            // Item22
            // 
            this.Item22 = new Stimulsoft.Report.Chart.StiStackedColumnSeries();
            this.Item22.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item22.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item22__GetListOfArguments);
            this.Item22.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item22__GetListOfValues);
            this.Item22.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item22__GetTitle);
            this.Item22.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 144, 67, 3), System.Drawing.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item22.DrillDownPageGuid = null;
            this.Item22_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item22_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item22_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item22_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item22_SeriesLabels.ValueTypeSeparator = "-";
            this.Item22_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item22_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item23
            // 
            this.Item23 = new Stimulsoft.Report.Chart.StiStackedColumnSeries();
            this.Item23.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item23.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item23__GetListOfArguments);
            this.Item23.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item23__GetListOfValues);
            this.Item23.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item23__GetTitle);
            this.Item23.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 181, 90, 15), System.Drawing.Color.FromArgb(255, 231, 140, 65), 0, 0.5F, 1F);
            this.Item23.DrillDownPageGuid = null;
            this.Item23_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item23_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item23_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item23_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item23_SeriesLabels.ValueTypeSeparator = "-";
            this.Item23_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item23_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart3_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart3_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart3_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart3_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart3_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart3.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart3.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart4
            // 
            this.Chart4 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 11.4, 9.4, 7.2);
            this.Chart4.CountData = 10;
            this.Chart4.CustomStyleName = "";
            this.Chart4.FilterOn = false;
            this.Chart4.Name = "Chart4";
            this.Chart4.Sort = new System.String[0];
            this.Chart4_Area = new Stimulsoft.Report.Chart.StiFullStackedColumnArea();
            this.Chart4_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart4_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart4_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart4_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart4_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart4_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart4_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart4_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart4_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart4_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart4.Guid = null;
            this.Chart4.Interaction = null;
            this.Chart4_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart4_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_Legend.Columns = 1;
            this.Chart4_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.Right;
            this.Chart4_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart4_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart4_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart4_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart4_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart4.MasterComponent = null;
            // 
            // Item25
            // 
            this.Item25 = new Stimulsoft.Report.Chart.StiFullStackedColumnSeries();
            this.Item25.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item25.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item25__GetListOfArguments);
            this.Item25.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item25__GetListOfValues);
            this.Item25.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item25__GetTitle);
            this.Item25.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 144, 67, 3), System.Drawing.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item25.DrillDownPageGuid = null;
            this.Item25_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item25_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item25_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item25_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item25_SeriesLabels.ValueTypeSeparator = "-";
            this.Item25_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item25_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item26
            // 
            this.Item26 = new Stimulsoft.Report.Chart.StiFullStackedColumnSeries();
            this.Item26.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item26.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfArguments);
            this.Item26.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfValues);
            this.Item26.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item26__GetTitle);
            this.Item26.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 181, 90, 15), System.Drawing.Color.FromArgb(255, 231, 140, 65), 0, 0.5F, 1F);
            this.Item26.DrillDownPageGuid = null;
            this.Item26_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item26_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item26_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item26_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item26_SeriesLabels.ValueTypeSeparator = "-";
            this.Item26_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item26_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart4_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart4_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart4_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart4_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart4_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart4.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart4.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.6, 9.4, 0.6);
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text2.Guid = null;
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart2
            // 
            this.Chart2 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20.4, 9.4, 7.4);
            this.Chart2.CountData = 10;
            this.Chart2.CustomStyleName = "";
            this.Chart2.FilterOn = false;
            this.Chart2.Name = "Chart2";
            this.Chart2.Sort = new System.String[0];
            this.Chart2_Area = new Stimulsoft.Report.Chart.StiClusteredBarArea();
            this.Chart2_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart2_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart2_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart2_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart2_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart2_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart2_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart2_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart2_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart2_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart2.Guid = null;
            this.Chart2.Interaction = null;
            this.Chart2_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart2_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart2_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_Legend.Visible = false;
            this.Chart2_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart2_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart2_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart2.MasterComponent = null;
            // 
            // Item29
            // 
            this.Item29 = new Stimulsoft.Report.Chart.StiClusteredBarSeries();
            this.Item29.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item29.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item29__GetListOfArguments);
            this.Item29.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item29__GetListOfValues);
            this.Item29.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item29__GetTitle);
            this.Item29.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 144, 67, 3), System.Drawing.Color.FromArgb(255, 194, 117, 53), 90, 0.5F, 1F);
            this.Item29.DrillDownPageGuid = null;
            this.Item29_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item29_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item29_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item29_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item29_SeriesLabels.ValueTypeSeparator = "-";
            this.Item29_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item29_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart2_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart2_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart2_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart2_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart2_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart2.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart2.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19.8, 9.4, 0.6);
            this.Text1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text1.Guid = null;
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart5
            // 
            this.Chart5 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 20.4, 9.4, 7.4);
            this.Chart5.CountData = 10;
            this.Chart5.CustomStyleName = "";
            this.Chart5.FilterOn = false;
            this.Chart5.Name = "Chart5";
            this.Chart5.Sort = new System.String[0];
            this.Chart5_Area = new Stimulsoft.Report.Chart.StiStackedBarArea();
            this.Chart5_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart5_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart5_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart5_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart5_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart5_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart5_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart5_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart5_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart5_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart5.Guid = null;
            this.Chart5.Interaction = null;
            this.Chart5_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart5_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.Right;
            this.Chart5_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart5_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.BottomOutside;
            this.Chart5_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart5_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart5_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart5.MasterComponent = null;
            // 
            // Item32
            // 
            this.Item32 = new Stimulsoft.Report.Chart.StiStackedBarSeries();
            this.Item32.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item32.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item32__GetListOfArguments);
            this.Item32.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item32__GetListOfValues);
            this.Item32.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item32__GetTitle);
            this.Item32.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 144, 67, 3), System.Drawing.Color.FromArgb(255, 194, 117, 53), 90, 0.5F, 1F);
            this.Item32.DrillDownPageGuid = null;
            this.Item32_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item32_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item32_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item32_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item32_SeriesLabels.ValueTypeSeparator = "-";
            this.Item32_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item32_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item33
            // 
            this.Item33 = new Stimulsoft.Report.Chart.StiStackedBarSeries();
            this.Item33.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item33.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfArguments);
            this.Item33.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfValues);
            this.Item33.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item33__GetTitle);
            this.Item33.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 181, 90, 15), System.Drawing.Color.FromArgb(255, 231, 140, 65), 90, 0.5F, 1F);
            this.Item33.DrillDownPageGuid = null;
            this.Item33_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item33_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item33_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item33_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item33_SeriesLabels.ValueTypeSeparator = "-";
            this.Item33_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item33_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart5_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart5_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart5_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart5_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart5_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart5.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart5.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 19.8, 9.4, 0.6);
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text3.Guid = null;
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart6
            // 
            this.Chart6 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 11.2, 9.4, 7.4);
            this.Chart6.CountData = 10;
            this.Chart6.CustomStyleName = "";
            this.Chart6.FilterOn = false;
            this.Chart6.Name = "Chart6";
            this.Chart6.Sort = new System.String[0];
            this.Chart6_Area = new Stimulsoft.Report.Chart.StiFullStackedBarArea();
            this.Chart6_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart6_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart6_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart6_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart6_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart6_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart6_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart6_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart6_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart6_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart6.Guid = null;
            this.Chart6.Interaction = null;
            this.Chart6_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart6_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_Legend.Columns = 1;
            this.Chart6_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.Right;
            this.Chart6_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart6_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart6_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart6_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart6_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart6.MasterComponent = null;
            // 
            // Item36
            // 
            this.Item36 = new Stimulsoft.Report.Chart.StiFullStackedBarSeries();
            this.Item36.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item36.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item36__GetListOfArguments);
            this.Item36.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item36__GetListOfValues);
            this.Item36.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item36__GetTitle);
            this.Item36.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 144, 67, 3), System.Drawing.Color.FromArgb(255, 194, 117, 53), 90, 0.5F, 1F);
            this.Item36.DrillDownPageGuid = null;
            this.Item36_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item36_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item36_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item36_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item36_SeriesLabels.ValueTypeSeparator = "-";
            this.Item36_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item36_SeriesLabels.Chart = null;
            this.Item36_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item37
            // 
            this.Item37 = new Stimulsoft.Report.Chart.StiFullStackedBarSeries();
            this.Item37.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item37.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item37__GetListOfArguments);
            this.Item37.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item37__GetListOfValues);
            this.Item37.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item37__GetTitle);
            this.Item37.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 181, 90, 15), System.Drawing.Color.FromArgb(255, 231, 140, 65), 90, 0.5F, 1F);
            this.Item37.DrillDownPageGuid = null;
            this.Item37_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item37_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item37_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item37_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item37_SeriesLabels.ValueTypeSeparator = "-";
            this.Item37_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item37_SeriesLabels.Chart = null;
            this.Item37_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart6_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart6_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart6_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart6_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart6_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart6.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart6.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 10.6, 9.4, 0.6);
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text4.Guid = null;
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.2, 9.4, 0.6);
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text7.Guid = null;
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 0.2, 9.4, 0.6);
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text8.Guid = null;
            this.Text8.Indicator = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.Chart1.Area = this.Chart1_Area;
            this.Chart1.Legend = this.Chart1_Legend;
            this.Chart1.Page = this.Page1;
            this.Chart1.Parent = this.Page1;
            this.Chart1.SeriesLabels = this.Chart1_SeriesLabels;
            this.Chart1_Area.Chart = this.Chart1;
            this.Chart1_Legend.Chart = this.Chart1;
            this.Item20.Chart = this.Chart1;
            this.Item20.SeriesLabels = this.Item20_SeriesLabels;
            this.Item20_SeriesLabels.Chart = this.Chart1;
            this.Chart1_SeriesLabels.Chart = this.Chart1;
            this.Chart3.Area = this.Chart3_Area;
            this.Chart3.Legend = this.Chart3_Legend;
            this.Chart3.Page = this.Page1;
            this.Chart3.Parent = this.Page1;
            this.Chart3.SeriesLabels = this.Chart3_SeriesLabels;
            this.Chart3_Area.Chart = this.Chart3;
            this.Chart3_Legend.Chart = this.Chart3;
            this.Item22.Chart = this.Chart3;
            this.Item22.SeriesLabels = this.Item22_SeriesLabels;
            this.Item22_SeriesLabels.Chart = this.Chart3;
            this.Item23.Chart = this.Chart3;
            this.Item23.SeriesLabels = this.Item23_SeriesLabels;
            this.Item23_SeriesLabels.Chart = this.Chart3;
            this.Chart3_SeriesLabels.Chart = this.Chart3;
            this.Chart4.Area = this.Chart4_Area;
            this.Chart4.Legend = this.Chart4_Legend;
            this.Chart4.Page = this.Page1;
            this.Chart4.Parent = this.Page1;
            this.Chart4.SeriesLabels = this.Chart4_SeriesLabels;
            this.Chart4_Area.Chart = this.Chart4;
            this.Chart4_Legend.Chart = this.Chart4;
            this.Item25.Chart = this.Chart4;
            this.Item25.SeriesLabels = this.Item25_SeriesLabels;
            this.Item25_SeriesLabels.Chart = this.Chart4;
            this.Item26.Chart = this.Chart4;
            this.Item26.SeriesLabels = this.Item26_SeriesLabels;
            this.Item26_SeriesLabels.Chart = this.Chart4;
            this.Chart4_SeriesLabels.Chart = this.Chart4;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.Page1;
            this.Chart2.Area = this.Chart2_Area;
            this.Chart2.Legend = this.Chart2_Legend;
            this.Chart2.Page = this.Page1;
            this.Chart2.Parent = this.Page1;
            this.Chart2.SeriesLabels = this.Chart2_SeriesLabels;
            this.Chart2_Area.Chart = this.Chart2;
            this.Chart2_Legend.Chart = this.Chart2;
            this.Item29.Chart = this.Chart2;
            this.Item29.SeriesLabels = this.Item29_SeriesLabels;
            this.Item29_SeriesLabels.Chart = this.Chart2;
            this.Chart2_SeriesLabels.Chart = this.Chart2;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.Page1;
            this.Chart5.Area = this.Chart5_Area;
            this.Chart5.Legend = this.Chart5_Legend;
            this.Chart5.Page = this.Page1;
            this.Chart5.Parent = this.Page1;
            this.Chart5.SeriesLabels = this.Chart5_SeriesLabels;
            this.Chart5_Area.Chart = this.Chart5;
            this.Chart5_Legend.Chart = this.Chart5;
            this.Item32.Chart = this.Chart5;
            this.Item32.SeriesLabels = this.Item32_SeriesLabels;
            this.Item32_SeriesLabels.Chart = this.Chart5;
            this.Item33.Chart = this.Chart5;
            this.Item33.SeriesLabels = this.Item33_SeriesLabels;
            this.Item33_SeriesLabels.Chart = this.Chart5;
            this.Chart5_SeriesLabels.Chart = this.Chart5;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.Page1;
            this.Chart6.Area = this.Chart6_Area;
            this.Chart6.Legend = this.Chart6_Legend;
            this.Chart6.Page = this.Page1;
            this.Chart6.Parent = this.Page1;
            this.Chart6.SeriesLabels = this.Chart6_SeriesLabels;
            this.Chart6_Area.Chart = this.Chart6;
            this.Chart6_Legend.Chart = this.Chart6;
            this.Item36.Chart = this.Chart6;
            this.Item36.SeriesLabels = this.Item36_SeriesLabels;
            this.Item37.Chart = this.Chart6;
            this.Item37.SeriesLabels = this.Item37_SeriesLabels;
            this.Chart6_SeriesLabels.Chart = this.Chart6;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.Page1;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.Page1;
            this.Text8.Page = this.Page1;
            this.Text8.Parent = this.Page1;
            // 
            // Add to Chart1.Series
            // 
            this.Chart1.Series.Clear();
            this.Chart1.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item20});
            // 
            // Add to Chart3.Series
            // 
            this.Chart3.Series.Clear();
            this.Chart3.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item22,
                        this.Item23});
            // 
            // Add to Chart4.Series
            // 
            this.Chart4.Series.Clear();
            this.Chart4.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item25,
                        this.Item26});
            // 
            // Add to Chart2.Series
            // 
            this.Chart2.Series.Clear();
            this.Chart2.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item29});
            // 
            // Add to Chart5.Series
            // 
            this.Chart5.Series.Clear();
            this.Chart5.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item32,
                        this.Item33});
            // 
            // Add to Chart6.Series
            // 
            this.Chart6.Series.Clear();
            this.Chart6.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item36,
                        this.Item37});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Chart1,
                        this.Chart3,
                        this.Chart4,
                        this.Text2,
                        this.Chart2,
                        this.Text1,
                        this.Chart5,
                        this.Text3,
                        this.Chart6,
                        this.Text4,
                        this.Text7,
                        this.Text8});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            this.Dictionary.Relations.Add(this.ParentEmployees);
            this.Dictionary.Relations.Add(this.ParentProducts);
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
        
        #region Relation ParentProducts
        public class ParentProductsRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentProductsRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
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
        #endregion Relation ParentProducts
        
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
            
            public virtual ParentProductsRelation Products
            {
                get
                {
                    return new ParentProductsRelation(this.GetParentData("ProductsOrder_Details"));
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