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
    public class ChartLinesAndSplines : Stimulsoft.Report.StiReport
    {
        public ChartLinesAndSplines()
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
        public Stimulsoft.Report.Components.StiPage Page2;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Chart.StiChart Chart10;
        public Stimulsoft.Report.Chart.StiStackedLineArea Chart10_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart10_Legend;
        public Stimulsoft.Report.Chart.StiStackedLineSeries Item21;
        public Stimulsoft.Report.Chart.StiLineMarker Item21_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item21_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item21_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedLineSeries Item22;
        public Stimulsoft.Report.Chart.StiLineMarker Item22_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item22_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item22_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart10_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Chart.StiChart Chart11;
        public Stimulsoft.Report.Chart.StiLineArea Chart11_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart11_Legend;
        public Stimulsoft.Report.Chart.StiLineSeries Item25;
        public Stimulsoft.Report.Chart.StiLineMarker Item25_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item25_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item25_SeriesLabels;
        public Stimulsoft.Report.Chart.StiLineSeries Item26;
        public Stimulsoft.Report.Chart.StiLineMarker Item26_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item26_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item26_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideAxisLabels Chart11_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart12;
        public Stimulsoft.Report.Chart.StiSplineArea Chart12_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart12_Legend;
        public Stimulsoft.Report.Chart.StiSplineSeries Item28;
        public Stimulsoft.Report.Chart.StiMarker Item28_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item28_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSplineSeries Item29;
        public Stimulsoft.Report.Chart.StiMarker Item29_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item29_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideEndAxisLabels Chart12_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Chart.StiChart Chart7;
        public Stimulsoft.Report.Chart.StiStackedSplineArea Chart7_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart7_Legend;
        public Stimulsoft.Report.Chart.StiStackedSplineSeries Item33;
        public Stimulsoft.Report.Chart.StiMarker Item33_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item33_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedSplineSeries Item34;
        public Stimulsoft.Report.Chart.StiMarker Item34_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item34_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideEndAxisLabels Chart7_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Chart.StiChart Chart13;
        public Stimulsoft.Report.Chart.StiFullStackedLineArea Chart13_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart13_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedLineSeries Item37;
        public Stimulsoft.Report.Chart.StiLineMarker Item37_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item37_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item37_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedLineSeries Item38;
        public Stimulsoft.Report.Chart.StiLineMarker Item38_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item38_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item38_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart13_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart8;
        public Stimulsoft.Report.Chart.StiFullStackedSplineArea Chart8_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart8_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedSplineSeries Item40;
        public Stimulsoft.Report.Chart.StiMarker Item40_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item40_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedSplineSeries Item41;
        public Stimulsoft.Report.Chart.StiMarker Item41_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item41_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart8_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiWatermark Page2_Watermark;
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
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Line";
        }
        
        public void Item21__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item21__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;25;15;15";
        }
        
        public void Item21__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item22__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item22__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;15;25;10";
        }
        
        public void Item22__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Line";
        }
        
        public void Item25__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item25__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;25;15;15";
        }
        
        public void Item25__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item26__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item26__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;15;25;10";
        }
        
        public void Item26__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Item28__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item28__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item28__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item29__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item29__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item29__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Spline";
        }
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Spline";
        }
        
        public void Item33__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item33__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item33__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item34__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item34__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item34__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Line";
        }
        
        public void Item37__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item37__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item37__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item38__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item38__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item38__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Item40__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item40__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item40__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item41__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item41__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item41__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Spline";
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
            this.ReportAlias = "Charts Lines And Splines";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2006, 6, 12, 17, 3, 44, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2006, 6, 6, 13, 21, 42, 0);
            this.ReportDescription = "This sample demonstrates Line and Spline chart types.";
            this.ReportFile = "E:\\Stimulsoft\\Stimulsoft.Reports\\Demo\\Bin\\Reports\\ChartLinesAndSplines.mrt";
            this.ReportGuid = "eea7bf243b3b4ab38faf24cf15191c13";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2008.2.291";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page2
            // 
            this.Page2 = new Stimulsoft.Report.Components.StiPage();
            this.Page2.Guid = "4d1b810cfe494f048b522af53ebd2a66";
            this.Page2.Name = "Page2";
            this.Page2.PageHeight = 29.7;
            this.Page2.PageWidth = 21;
            this.Page2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.8, 9.4, 0.6);
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text9.Guid = null;
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart10
            // 
            this.Chart10 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 1.4, 9.4, 7.2);
            this.Chart10.CountData = 10;
            this.Chart10.CustomStyleName = "";
            this.Chart10.FilterOn = false;
            this.Chart10.Name = "Chart10";
            this.Chart10.Sort = new System.String[0];
            this.Chart10_Area = new Stimulsoft.Report.Chart.StiStackedLineArea();
            this.Chart10_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart10_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart10_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart10_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart10_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart10_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart10_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart10_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart10_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart10_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart10.Guid = null;
            this.Chart10.Interaction = null;
            this.Chart10_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart10_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart10_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart10_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart10_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart10.MasterComponent = null;
            // 
            // Item21
            // 
            this.Item21 = new Stimulsoft.Report.Chart.StiStackedLineSeries();
            this.Item21.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item21.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item21__GetListOfArguments);
            this.Item21.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item21__GetListOfValues);
            this.Item21.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item21__GetTitle);
            this.Item21.DrillDownPageGuid = null;
            this.Item21_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item21_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 44, 0, 0);
            this.Item21_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 244, 167, 103));
            this.Item21_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item21_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item21_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
            this.Item21_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item21_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item21_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item21_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item21_SeriesLabels.ValueTypeSeparator = "-";
            this.Item21_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item21_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item22
            // 
            this.Item22 = new Stimulsoft.Report.Chart.StiStackedLineSeries();
            this.Item22.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item22.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item22__GetListOfArguments);
            this.Item22.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item22__GetListOfValues);
            this.Item22.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item22__GetTitle);
            this.Item22.DrillDownPageGuid = null;
            this.Item22_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item22_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 81, 0, 0);
            this.Item22_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 190, 115));
            this.Item22_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item22_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item22_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 240, 165));
            this.Item22_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item22_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item22_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item22_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item22_SeriesLabels.ValueTypeSeparator = "-";
            this.Item22_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item22_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart10_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart10_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart10_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart10_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart10_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart10.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart10.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 0.8, 9.4, 0.6);
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text10.Guid = null;
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart11
            // 
            this.Chart11 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.4, 9.4, 7.2);
            this.Chart11.CustomStyleName = "";
            this.Chart11.Name = "Chart11";
            this.Chart11.Sort = new System.String[0];
            this.Chart11_Area = new Stimulsoft.Report.Chart.StiLineArea();
            this.Chart11_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart11_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart11_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart11_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart11_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart11_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart11_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart11_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart11_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart11_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart11.Guid = null;
            this.Chart11.Interaction = null;
            this.Chart11_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart11_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart11_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart11_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart11_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart11.MasterComponent = null;
            // 
            // Item25
            // 
            this.Item25 = new Stimulsoft.Report.Chart.StiLineSeries();
            this.Item25.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item25.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item25__GetListOfArguments);
            this.Item25.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item25__GetListOfValues);
            this.Item25.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item25__GetTitle);
            this.Item25.DrillDownPageGuid = null;
            this.Item25_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item25_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 44, 0, 0);
            this.Item25_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 244, 167, 103));
            this.Item25_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item25_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item25_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
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
            this.Item26 = new Stimulsoft.Report.Chart.StiLineSeries();
            this.Item26.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item26.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfArguments);
            this.Item26.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfValues);
            this.Item26.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item26__GetTitle);
            this.Item26.DrillDownPageGuid = null;
            this.Item26_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item26_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 81, 0, 0);
            this.Item26_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 190, 115));
            this.Item26_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item26_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item26_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 240, 165));
            this.Item26_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item26_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item26_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item26_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item26_SeriesLabels.ValueTypeSeparator = "-";
            this.Item26_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item26_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart11_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideAxisLabels();
            this.Chart11_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart11_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart11_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart11_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart11.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart11.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart12
            // 
            this.Chart12 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.4, 9.4, 7.4);
            this.Chart12.CountData = 10;
            this.Chart12.CustomStyleName = "";
            this.Chart12.FilterOn = false;
            this.Chart12.Name = "Chart12";
            this.Chart12.Sort = new System.String[0];
            this.Chart12_Area = new Stimulsoft.Report.Chart.StiSplineArea();
            this.Chart12_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart12_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart12_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart12_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart12_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart12_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart12_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart12_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart12_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart12_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart12.Guid = null;
            this.Chart12.Interaction = null;
            this.Chart12_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart12_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_Legend.Columns = 1;
            this.Chart12_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart12_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart12_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart12_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart12_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart12.MasterComponent = null;
            // 
            // Item28
            // 
            this.Item28 = new Stimulsoft.Report.Chart.StiSplineSeries();
            this.Item28.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item28.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item28__GetListOfArguments);
            this.Item28.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item28__GetListOfValues);
            this.Item28.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item28__GetTitle);
            this.Item28.DrillDownPageGuid = null;
            this.Item28_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item28_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item28_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
            this.Item28_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item28_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item28_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item28_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item28_SeriesLabels.ValueTypeSeparator = "-";
            this.Item28_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item28_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item29
            // 
            this.Item29 = new Stimulsoft.Report.Chart.StiSplineSeries();
            this.Item29.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item29.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item29__GetListOfArguments);
            this.Item29.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item29__GetListOfValues);
            this.Item29.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item29__GetTitle);
            this.Item29.DrillDownPageGuid = null;
            this.Item29_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item29_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item29_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 240, 165));
            this.Item29_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item29_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item29_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item29_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item29_SeriesLabels.ValueTypeSeparator = "-";
            this.Item29_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item29_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart12_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideEndAxisLabels();
            this.Chart12_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart12_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart12_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart12_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart12.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart12.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.8, 9.4, 0.6);
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text12.Guid = null;
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 9.8, 9.4, 0.6);
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text5.Guid = null;
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart7
            // 
            this.Chart7 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 10.4, 9.4, 7.4);
            this.Chart7.CustomStyleName = "";
            this.Chart7.Name = "Chart7";
            this.Chart7.Sort = new System.String[0];
            this.Chart7_Area = new Stimulsoft.Report.Chart.StiStackedSplineArea();
            this.Chart7_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart7_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart7_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart7_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart7_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart7_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart7_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart7_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart7_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart7_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart7.Guid = null;
            this.Chart7.Interaction = null;
            this.Chart7_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart7_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_Legend.Columns = 1;
            this.Chart7_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart7_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.BottomOutside;
            this.Chart7_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart7_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart7_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart7.MasterComponent = null;
            // 
            // Item33
            // 
            this.Item33 = new Stimulsoft.Report.Chart.StiStackedSplineSeries();
            this.Item33.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item33.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfArguments);
            this.Item33.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfValues);
            this.Item33.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item33__GetTitle);
            this.Item33.DrillDownPageGuid = null;
            this.Item33_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item33_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item33_Marker.Type = Stimulsoft.Report.Chart.StiMarkerType.Rectangle;
            this.Item33_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
            this.Item33_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item33_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item33_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item33_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item33_SeriesLabels.ValueTypeSeparator = "-";
            this.Item33_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item33_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item34
            // 
            this.Item34 = new Stimulsoft.Report.Chart.StiStackedSplineSeries();
            this.Item34.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item34.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item34__GetListOfArguments);
            this.Item34.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item34__GetListOfValues);
            this.Item34.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item34__GetTitle);
            this.Item34.DrillDownPageGuid = null;
            this.Item34_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item34_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item34_Marker.Type = Stimulsoft.Report.Chart.StiMarkerType.Rectangle;
            this.Item34_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 240, 165));
            this.Item34_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item34_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item34_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item34_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item34_SeriesLabels.ValueTypeSeparator = "-";
            this.Item34_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item34_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart7_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideEndAxisLabels();
            this.Chart7_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart7_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart7_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart7_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart7.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart7.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19, 9.4, 0.6);
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text11.Guid = null;
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart13
            // 
            this.Chart13 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19.6, 9.4, 7.2);
            this.Chart13.CustomStyleName = "";
            this.Chart13.FilterOn = false;
            this.Chart13.Name = "Chart13";
            this.Chart13.Sort = new System.String[0];
            this.Chart13_Area = new Stimulsoft.Report.Chart.StiFullStackedLineArea();
            this.Chart13_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart13_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart13_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart13_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart13_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart13_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart13_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart13_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart13_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart13_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart13.Guid = null;
            this.Chart13.Interaction = null;
            this.Chart13_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart13_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.LeftOutside;
            this.Chart13_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart13_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart13_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart13_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart13.MasterComponent = null;
            // 
            // Item37
            // 
            this.Item37 = new Stimulsoft.Report.Chart.StiFullStackedLineSeries();
            this.Item37.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item37.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item37__GetListOfArguments);
            this.Item37.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item37__GetListOfValues);
            this.Item37.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item37__GetTitle);
            this.Item37.DrillDownPageGuid = null;
            this.Item37_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item37_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 44, 0, 0);
            this.Item37_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 244, 167, 103));
            this.Item37_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item37_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item37_Marker.Type = Stimulsoft.Report.Chart.StiMarkerType.Triangle;
            this.Item37_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
            this.Item37_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item37_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item37_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item37_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item37_SeriesLabels.ValueTypeSeparator = "-";
            this.Item37_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item37_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item38
            // 
            this.Item38 = new Stimulsoft.Report.Chart.StiFullStackedLineSeries();
            this.Item38.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item38.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item38__GetListOfArguments);
            this.Item38.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item38__GetListOfValues);
            this.Item38.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item38__GetTitle);
            this.Item38.DrillDownPageGuid = null;
            this.Item38_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item38_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 81, 0, 0);
            this.Item38_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 190, 115));
            this.Item38_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item38_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item38_Marker.Type = Stimulsoft.Report.Chart.StiMarkerType.Triangle;
            this.Item38_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 240, 165));
            this.Item38_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item38_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item38_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item38_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item38_SeriesLabels.ValueTypeSeparator = "-";
            this.Item38_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item38_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart13_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart13_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart13_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart13_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart13_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart13.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart13.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart8
            // 
            this.Chart8 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 19.6, 9.4, 7.2);
            this.Chart8.CountData = 10;
            this.Chart8.CustomStyleName = "";
            this.Chart8.FilterOn = false;
            this.Chart8.Name = "Chart8";
            this.Chart8.Sort = new System.String[0];
            this.Chart8_Area = new Stimulsoft.Report.Chart.StiFullStackedSplineArea();
            this.Chart8_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart8_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart8_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart8_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart8_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart8_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart8_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart8_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart8_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart8_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart8.Guid = null;
            this.Chart8.Interaction = null;
            this.Chart8_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart8_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.RightOutside;
            this.Chart8_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart8_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart8_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart8_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart8.MasterComponent = null;
            // 
            // Item40
            // 
            this.Item40 = new Stimulsoft.Report.Chart.StiFullStackedSplineSeries();
            this.Item40.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item40.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item40__GetListOfArguments);
            this.Item40.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item40__GetListOfValues);
            this.Item40.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item40__GetTitle);
            this.Item40.DrillDownPageGuid = null;
            this.Item40_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item40_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item40_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
            this.Item40_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item40_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item40_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item40_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item40_SeriesLabels.ValueTypeSeparator = "-";
            this.Item40_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item40_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item41
            // 
            this.Item41 = new Stimulsoft.Report.Chart.StiFullStackedSplineSeries();
            this.Item41.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item41.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item41__GetListOfArguments);
            this.Item41.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item41__GetListOfValues);
            this.Item41.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item41__GetTitle);
            this.Item41.DrillDownPageGuid = null;
            this.Item41_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item41_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item41_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 240, 165));
            this.Item41_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item41_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item41_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item41_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item41_SeriesLabels.ValueTypeSeparator = "-";
            this.Item41_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item41_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart8_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart8_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart8_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart8_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart8_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart8.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart8.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 19, 9.4, 0.6);
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text6.Guid = null;
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Page2.ExcelSheetValue = null;
            this.Page2.Interaction = null;
            this.Page2.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page2_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page2_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page2_Watermark.Image = null;
            this.Page2_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page2.Report = this;
            this.Page2.Watermark = this.Page2_Watermark;
            this.Text9.Page = this.Page2;
            this.Text9.Parent = this.Page2;
            this.Chart10.Area = this.Chart10_Area;
            this.Chart10.Legend = this.Chart10_Legend;
            this.Chart10.Page = this.Page2;
            this.Chart10.Parent = this.Page2;
            this.Chart10.SeriesLabels = this.Chart10_SeriesLabels;
            this.Chart10_Area.Chart = this.Chart10;
            this.Chart10_Legend.Chart = this.Chart10;
            this.Item21.Chart = this.Chart10;
            this.Item21.LineMarker = this.Item21_LineMarker;
            this.Item21.Marker = this.Item21_Marker;
            this.Item21.SeriesLabels = this.Item21_SeriesLabels;
            this.Item21_SeriesLabels.Chart = this.Chart10;
            this.Item22.Chart = this.Chart10;
            this.Item22.LineMarker = this.Item22_LineMarker;
            this.Item22.Marker = this.Item22_Marker;
            this.Item22.SeriesLabels = this.Item22_SeriesLabels;
            this.Item22_SeriesLabels.Chart = this.Chart10;
            this.Chart10_SeriesLabels.Chart = this.Chart10;
            this.Text10.Page = this.Page2;
            this.Text10.Parent = this.Page2;
            this.Chart11.Area = this.Chart11_Area;
            this.Chart11.Legend = this.Chart11_Legend;
            this.Chart11.Page = this.Page2;
            this.Chart11.Parent = this.Page2;
            this.Chart11.SeriesLabels = this.Chart11_SeriesLabels;
            this.Chart11_Area.Chart = this.Chart11;
            this.Chart11_Legend.Chart = this.Chart11;
            this.Item25.Chart = this.Chart11;
            this.Item25.LineMarker = this.Item25_LineMarker;
            this.Item25.Marker = this.Item25_Marker;
            this.Item25.SeriesLabels = this.Item25_SeriesLabels;
            this.Item25_SeriesLabels.Chart = this.Chart11;
            this.Item26.Chart = this.Chart11;
            this.Item26.LineMarker = this.Item26_LineMarker;
            this.Item26.Marker = this.Item26_Marker;
            this.Item26.SeriesLabels = this.Item26_SeriesLabels;
            this.Item26_SeriesLabels.Chart = this.Chart11;
            this.Chart11_SeriesLabels.Chart = this.Chart11;
            this.Chart12.Area = this.Chart12_Area;
            this.Chart12.Legend = this.Chart12_Legend;
            this.Chart12.Page = this.Page2;
            this.Chart12.Parent = this.Page2;
            this.Chart12.SeriesLabels = this.Chart12_SeriesLabels;
            this.Chart12_Area.Chart = this.Chart12;
            this.Chart12_Legend.Chart = this.Chart12;
            this.Item28.Chart = this.Chart12;
            this.Item28.Marker = this.Item28_Marker;
            this.Item28.SeriesLabels = this.Item28_SeriesLabels;
            this.Item28_SeriesLabels.Chart = this.Chart12;
            this.Item29.Chart = this.Chart12;
            this.Item29.Marker = this.Item29_Marker;
            this.Item29.SeriesLabels = this.Item29_SeriesLabels;
            this.Item29_SeriesLabels.Chart = this.Chart12;
            this.Chart12_SeriesLabels.Chart = this.Chart12;
            this.Text12.Page = this.Page2;
            this.Text12.Parent = this.Page2;
            this.Text5.Page = this.Page2;
            this.Text5.Parent = this.Page2;
            this.Chart7.Area = this.Chart7_Area;
            this.Chart7.Legend = this.Chart7_Legend;
            this.Chart7.Page = this.Page2;
            this.Chart7.Parent = this.Page2;
            this.Chart7.SeriesLabels = this.Chart7_SeriesLabels;
            this.Chart7_Area.Chart = this.Chart7;
            this.Chart7_Legend.Chart = this.Chart7;
            this.Item33.Chart = this.Chart7;
            this.Item33.Marker = this.Item33_Marker;
            this.Item33.SeriesLabels = this.Item33_SeriesLabels;
            this.Item33_SeriesLabels.Chart = this.Chart7;
            this.Item34.Chart = this.Chart7;
            this.Item34.Marker = this.Item34_Marker;
            this.Item34.SeriesLabels = this.Item34_SeriesLabels;
            this.Item34_SeriesLabels.Chart = this.Chart7;
            this.Chart7_SeriesLabels.Chart = this.Chart7;
            this.Text11.Page = this.Page2;
            this.Text11.Parent = this.Page2;
            this.Chart13.Area = this.Chart13_Area;
            this.Chart13.Legend = this.Chart13_Legend;
            this.Chart13.Page = this.Page2;
            this.Chart13.Parent = this.Page2;
            this.Chart13.SeriesLabels = this.Chart13_SeriesLabels;
            this.Chart13_Area.Chart = this.Chart13;
            this.Chart13_Legend.Chart = this.Chart13;
            this.Item37.Chart = this.Chart13;
            this.Item37.LineMarker = this.Item37_LineMarker;
            this.Item37.Marker = this.Item37_Marker;
            this.Item37.SeriesLabels = this.Item37_SeriesLabels;
            this.Item37_SeriesLabels.Chart = this.Chart13;
            this.Item38.Chart = this.Chart13;
            this.Item38.LineMarker = this.Item38_LineMarker;
            this.Item38.Marker = this.Item38_Marker;
            this.Item38.SeriesLabels = this.Item38_SeriesLabels;
            this.Item38_SeriesLabels.Chart = this.Chart13;
            this.Chart13_SeriesLabels.Chart = this.Chart13;
            this.Chart8.Area = this.Chart8_Area;
            this.Chart8.Legend = this.Chart8_Legend;
            this.Chart8.Page = this.Page2;
            this.Chart8.Parent = this.Page2;
            this.Chart8.SeriesLabels = this.Chart8_SeriesLabels;
            this.Chart8_Area.Chart = this.Chart8;
            this.Chart8_Legend.Chart = this.Chart8;
            this.Item40.Chart = this.Chart8;
            this.Item40.Marker = this.Item40_Marker;
            this.Item40.SeriesLabels = this.Item40_SeriesLabels;
            this.Item40_SeriesLabels.Chart = this.Chart8;
            this.Item41.Chart = this.Chart8;
            this.Item41.Marker = this.Item41_Marker;
            this.Item41.SeriesLabels = this.Item41_SeriesLabels;
            this.Item41_SeriesLabels.Chart = this.Chart8;
            this.Chart8_SeriesLabels.Chart = this.Chart8;
            this.Text6.Page = this.Page2;
            this.Text6.Parent = this.Page2;
            // 
            // Add to Chart10.Series
            // 
            this.Chart10.Series.Clear();
            this.Chart10.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item21,
                        this.Item22});
            // 
            // Add to Chart11.Series
            // 
            this.Chart11.Series.Clear();
            this.Chart11.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item25,
                        this.Item26});
            // 
            // Add to Chart12.Series
            // 
            this.Chart12.Series.Clear();
            this.Chart12.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item28,
                        this.Item29});
            // 
            // Add to Chart7.Series
            // 
            this.Chart7.Series.Clear();
            this.Chart7.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item33,
                        this.Item34});
            // 
            // Add to Chart13.Series
            // 
            this.Chart13.Series.Clear();
            this.Chart13.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item37,
                        this.Item38});
            // 
            // Add to Chart8.Series
            // 
            this.Chart8.Series.Clear();
            this.Chart8.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item40,
                        this.Item41});
            // 
            // Add to Page2.Components
            // 
            this.Page2.Components.Clear();
            this.Page2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text9,
                        this.Chart10,
                        this.Text10,
                        this.Chart11,
                        this.Chart12,
                        this.Text12,
                        this.Text5,
                        this.Chart7,
                        this.Text11,
                        this.Chart13,
                        this.Chart8,
                        this.Text6});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page2});
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