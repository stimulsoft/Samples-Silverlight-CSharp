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
    public class ChartAreas : Stimulsoft.Report.StiReport
    {
        public ChartAreas()
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
        public Stimulsoft.Report.Components.StiPage Page3;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Chart.StiChart Chart16;
        public Stimulsoft.Report.Chart.StiStackedAreaArea Chart16_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart16_Legend;
        public Stimulsoft.Report.Chart.StiStackedAreaSeries Item21;
        public Stimulsoft.Report.Chart.StiLineMarker Item21_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item21_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item21_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedAreaSeries Item22;
        public Stimulsoft.Report.Chart.StiLineMarker Item22_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item22_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item22_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideEndAxisLabels Chart16_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text16;
        public Stimulsoft.Report.Chart.StiChart Chart17;
        public Stimulsoft.Report.Chart.StiAreaArea Chart17_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart17_Legend;
        public Stimulsoft.Report.Chart.StiAreaSeries Item25;
        public Stimulsoft.Report.Chart.StiLineMarker Item25_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item25_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item25_SeriesLabels;
        public Stimulsoft.Report.Chart.StiAreaSeries Item26;
        public Stimulsoft.Report.Chart.StiLineMarker Item26_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item26_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item26_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideEndAxisLabels Chart17_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Chart.StiChart Chart19;
        public Stimulsoft.Report.Chart.StiFullStackedAreaArea Chart19_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart19_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedAreaSeries Item29;
        public Stimulsoft.Report.Chart.StiLineMarker Item29_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item29_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item29_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedAreaSeries Item30;
        public Stimulsoft.Report.Chart.StiLineMarker Item30_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item30_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item30_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart19_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart23;
        public Stimulsoft.Report.Chart.StiFullStackedSplineAreaArea Chart23_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart23_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedSplineAreaSeries Item32;
        public Stimulsoft.Report.Chart.StiMarker Item32_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item32_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedSplineAreaSeries Item33;
        public Stimulsoft.Report.Chart.StiMarker Item33_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item33_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart23_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text24;
        public Stimulsoft.Report.Chart.StiChart Chart18;
        public Stimulsoft.Report.Chart.StiSplineAreaArea Chart18_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart18_Legend;
        public Stimulsoft.Report.Chart.StiSplineAreaSeries Item36;
        public Stimulsoft.Report.Chart.StiMarker Item36_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item36_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart18_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Chart.StiChart Chart24;
        public Stimulsoft.Report.Chart.StiStackedSplineAreaArea Chart24_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart24_Legend;
        public Stimulsoft.Report.Chart.StiStackedSplineAreaSeries Item40;
        public Stimulsoft.Report.Chart.StiMarker Item40_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item40_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedSplineAreaSeries Item41;
        public Stimulsoft.Report.Chart.StiMarker Item41_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item41_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideAxisLabels Chart24_SeriesLabels;
        public Stimulsoft.Report.Components.StiWatermark Page3_Watermark;
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
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Area";
        }
        
        public void Item21__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item21__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;10;30;15;10;20;15;30;10";
        }
        
        public void Item21__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item22__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item22__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;20;20;15;10;15;40;20;10";
        }
        
        public void Item22__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text16__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Area";
        }
        
        public void Item25__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item25__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;10;15;5;15;5;2;15;5;2";
        }
        
        public void Item25__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item26__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item26__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "25;15;20;20;25;10;15;40;20;10";
        }
        
        public void Item26__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Area";
        }
        
        public void Item29__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item29__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;25;20;15;15;15;25;20;15";
        }
        
        public void Item29__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item30__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item30__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "25;15;10;20;5;15;25;20;15;10";
        }
        
        public void Item30__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Item32__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item32__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;25;20;15;15;15;25;20;15";
        }
        
        public void Item32__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item33__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item33__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "25;15;10;20;5;15;25;20;15;10";
        }
        
        public void Item33__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text24__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Spline Area";
        }
        
        public void Item36__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8";
        }
        
        public void Item36__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "30;20;10;25;15;40;20;10";
        }
        
        public void Item36__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Spline Area";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Spline Area";
        }
        
        public void Item40__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8";
        }
        
        public void Item40__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;50;40;10;40;10;15";
        }
        
        public void Item40__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item41__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8";
        }
        
        public void Item41__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;10;40;30;20;40;15;5";
        }
        
        public void Item41__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
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
            this.ReportAlias = "Chart Areas";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2006, 6, 12, 17, 15, 25, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2006, 6, 6, 13, 21, 42, 0);
            this.ReportDescription = "This sample demonstrates Areas chart types.";
            this.ReportFile = "E:\\Stimulsoft\\Stimulsoft.Reports\\Demo\\Bin\\Reports\\ChartAreas.mrt";
            this.ReportGuid = "8ace8ed69f53452680564b1e25ffab0f";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2008.2.291";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page3
            // 
            this.Page3 = new Stimulsoft.Report.Components.StiPage();
            this.Page3.Guid = "b76f6873030f45ebace181794c9ae93d";
            this.Page3.Name = "Page3";
            this.Page3.PageHeight = 29.7;
            this.Page3.PageWidth = 21;
            this.Page3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.8, 9.4, 0.6);
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text15.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text15.Guid = null;
            this.Text15.Indicator = null;
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart16
            // 
            this.Chart16 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 1.4, 9.4, 7.2);
            this.Chart16.CountData = 10;
            this.Chart16.CustomStyleName = "";
            this.Chart16.FilterOn = false;
            this.Chart16.Name = "Chart16";
            this.Chart16.Sort = new System.String[0];
            this.Chart16_Area = new Stimulsoft.Report.Chart.StiStackedAreaArea();
            this.Chart16_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart16_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart16_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart16_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart16_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart16_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart16_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart16_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart16_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart16_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart16.Guid = null;
            this.Chart16.Interaction = null;
            this.Chart16_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart16_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart16_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart16_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart16_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart16.MasterComponent = null;
            // 
            // Item21
            // 
            this.Item21 = new Stimulsoft.Report.Chart.StiStackedAreaSeries();
            this.Item21.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item21.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item21__GetListOfArguments);
            this.Item21.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item21__GetListOfValues);
            this.Item21.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item21__GetTitle);
            this.Item21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 194, 117, 53));
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
            this.Item22 = new Stimulsoft.Report.Chart.StiStackedAreaSeries();
            this.Item22.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item22.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item22__GetListOfArguments);
            this.Item22.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item22__GetListOfValues);
            this.Item22.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item22__GetTitle);
            this.Item22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 231, 140, 65));
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
            this.Chart16_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideEndAxisLabels();
            this.Chart16_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart16_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart16_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart16_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart16.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart16.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text16
            // 
            this.Text16 = new Stimulsoft.Report.Components.StiText();
            this.Text16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 0.8, 9.4, 0.6);
            this.Text16.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text16.Name = "Text16";
            this.Text16.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text16__GetValue);
            this.Text16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text16.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text16.Guid = null;
            this.Text16.Indicator = null;
            this.Text16.Interaction = null;
            this.Text16.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text16.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text16.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart17
            // 
            this.Chart17 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.4, 9.4, 7.2);
            this.Chart17.CustomStyleName = "";
            this.Chart17.Name = "Chart17";
            this.Chart17.Sort = new System.String[0];
            this.Chart17_Area = new Stimulsoft.Report.Chart.StiAreaArea();
            this.Chart17_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart17_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart17_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart17_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart17_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart17_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart17_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart17_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart17_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart17_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart17.Guid = null;
            this.Chart17.Interaction = null;
            this.Chart17_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart17_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart17_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart17_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart17_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart17.MasterComponent = null;
            // 
            // Item25
            // 
            this.Item25 = new Stimulsoft.Report.Chart.StiAreaSeries();
            this.Item25.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item25.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item25__GetListOfArguments);
            this.Item25.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item25__GetListOfValues);
            this.Item25.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item25__GetTitle);
            this.Item25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 194, 117, 53));
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
            this.Item26 = new Stimulsoft.Report.Chart.StiAreaSeries();
            this.Item26.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item26.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfArguments);
            this.Item26.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfValues);
            this.Item26.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item26__GetTitle);
            this.Item26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 231, 140, 65));
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
            this.Chart17_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideEndAxisLabels();
            this.Chart17_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart17_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart17_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart17_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart17.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart17.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19.2, 9.4, 0.6);
            this.Text17.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text17.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text17.Guid = null;
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart19
            // 
            this.Chart19 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19.8, 9.4, 7.2);
            this.Chart19.CustomStyleName = "";
            this.Chart19.FilterOn = false;
            this.Chart19.Name = "Chart19";
            this.Chart19.Sort = new System.String[0];
            this.Chart19_Area = new Stimulsoft.Report.Chart.StiFullStackedAreaArea();
            this.Chart19_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart19_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart19_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart19_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart19_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart19_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart19_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart19_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart19_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart19_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart19.Guid = null;
            this.Chart19.Interaction = null;
            this.Chart19_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart19_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_Legend.Columns = 1;
            this.Chart19_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart19_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart19_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart19_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart19_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart19.MasterComponent = null;
            // 
            // Item29
            // 
            this.Item29 = new Stimulsoft.Report.Chart.StiFullStackedAreaSeries();
            this.Item29.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item29.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item29__GetListOfArguments);
            this.Item29.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item29__GetListOfValues);
            this.Item29.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item29__GetTitle);
            this.Item29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 194, 117, 53));
            this.Item29.DrillDownPageGuid = null;
            this.Item29_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item29_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 44, 0, 0);
            this.Item29_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 244, 167, 103));
            this.Item29_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item29_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item29_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
            this.Item29_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item29_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item29_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item29_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item29_SeriesLabels.ValueTypeSeparator = "-";
            this.Item29_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item29_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item30
            // 
            this.Item30 = new Stimulsoft.Report.Chart.StiFullStackedAreaSeries();
            this.Item30.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item30.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item30__GetListOfArguments);
            this.Item30.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item30__GetListOfValues);
            this.Item30.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item30__GetTitle);
            this.Item30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 231, 140, 65));
            this.Item30.DrillDownPageGuid = null;
            this.Item30_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item30_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 81, 0, 0);
            this.Item30_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 190, 115));
            this.Item30_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item30_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item30_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 240, 165));
            this.Item30_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item30_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item30_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item30_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item30_SeriesLabels.ValueTypeSeparator = "-";
            this.Item30_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item30_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart19_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart19_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart19_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart19_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart19_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart19.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart19.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart23
            // 
            this.Chart23 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 20, 9.4, 7);
            this.Chart23.CountData = 10;
            this.Chart23.CustomStyleName = "";
            this.Chart23.FilterOn = false;
            this.Chart23.Name = "Chart23";
            this.Chart23.Sort = new System.String[0];
            this.Chart23_Area = new Stimulsoft.Report.Chart.StiFullStackedSplineAreaArea();
            this.Chart23_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart23_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart23_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart23_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart23_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart23_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart23_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart23_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart23_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart23_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart23.Guid = null;
            this.Chart23.Interaction = null;
            this.Chart23_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart23_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_Legend.Columns = 1;
            this.Chart23_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart23_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart23_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart23_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart23_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart23.MasterComponent = null;
            // 
            // Item32
            // 
            this.Item32 = new Stimulsoft.Report.Chart.StiFullStackedSplineAreaSeries();
            this.Item32.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item32.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item32__GetListOfArguments);
            this.Item32.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item32__GetListOfValues);
            this.Item32.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item32__GetTitle);
            this.Item32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 194, 117, 53));
            this.Item32.DrillDownPageGuid = null;
            this.Item32_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item32_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item32_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
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
            this.Item33 = new Stimulsoft.Report.Chart.StiFullStackedSplineAreaSeries();
            this.Item33.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item33.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfArguments);
            this.Item33.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfValues);
            this.Item33.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item33__GetTitle);
            this.Item33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 231, 140, 65));
            this.Item33.DrillDownPageGuid = null;
            this.Item33_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item33_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item33_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 240, 165));
            this.Item33_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item33_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item33_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item33_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item33_SeriesLabels.ValueTypeSeparator = "-";
            this.Item33_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item33_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart23_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart23_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart23_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart23_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart23_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart23.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart23.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text24
            // 
            this.Text24 = new Stimulsoft.Report.Components.StiText();
            this.Text24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 19.2, 9.4, 0.6);
            this.Text24.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text24.Name = "Text24";
            this.Text24.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text24__GetValue);
            this.Text24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text24.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text24.Guid = null;
            this.Text24.Indicator = null;
            this.Text24.Interaction = null;
            this.Text24.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text24.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text24.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart18
            // 
            this.Chart18 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.4, 9.4, 7.4);
            this.Chart18.CountData = 10;
            this.Chart18.CustomStyleName = "";
            this.Chart18.FilterOn = false;
            this.Chart18.Name = "Chart18";
            this.Chart18.Sort = new System.String[0];
            this.Chart18_Area = new Stimulsoft.Report.Chart.StiSplineAreaArea();
            this.Chart18_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart18_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart18_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart18_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart18_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart18_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart18_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart18_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart18_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart18_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart18.Guid = null;
            this.Chart18.Interaction = null;
            this.Chart18_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart18_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart18_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_Legend.Visible = false;
            this.Chart18_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart18_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart18_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart18.MasterComponent = null;
            // 
            // Item36
            // 
            this.Item36 = new Stimulsoft.Report.Chart.StiSplineAreaSeries();
            this.Item36.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item36.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item36__GetListOfArguments);
            this.Item36.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item36__GetListOfValues);
            this.Item36.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item36__GetTitle);
            this.Item36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 194, 117, 53));
            this.Item36.DrillDownPageGuid = null;
            this.Item36_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item36_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item36_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 217, 153));
            this.Item36_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item36_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item36_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item36_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item36_SeriesLabels.ValueTypeSeparator = "-";
            this.Item36_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item36_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart18_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart18_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart18_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart18_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart18_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart18.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart18.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.8, 9.4, 0.6);
            this.Text18.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text18.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text18.Guid = null;
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 9.8, 9.4, 0.6);
            this.Text23.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text23.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text23.Guid = null;
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart24
            // 
            this.Chart24 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 10.6, 9.4, 7.2);
            this.Chart24.CustomStyleName = "";
            this.Chart24.Name = "Chart24";
            this.Chart24.Sort = new System.String[0];
            this.Chart24_Area = new Stimulsoft.Report.Chart.StiStackedSplineAreaArea();
            this.Chart24_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart24_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart24_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart24_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart24_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart24_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart24_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart24_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart24_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart24_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart24.Guid = null;
            this.Chart24.Interaction = null;
            this.Chart24_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart24_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart24_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart24_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart24_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart24.MasterComponent = null;
            // 
            // Item40
            // 
            this.Item40 = new Stimulsoft.Report.Chart.StiStackedSplineAreaSeries();
            this.Item40.LineColor = System.Drawing.Color.FromArgb(255, 194, 117, 53);
            this.Item40.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item40__GetListOfArguments);
            this.Item40.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item40__GetListOfValues);
            this.Item40.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item40__GetTitle);
            this.Item40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 194, 117, 53));
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
            this.Item41 = new Stimulsoft.Report.Chart.StiStackedSplineAreaSeries();
            this.Item41.LineColor = System.Drawing.Color.FromArgb(255, 231, 140, 65);
            this.Item41.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item41__GetListOfArguments);
            this.Item41.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item41__GetListOfValues);
            this.Item41.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item41__GetTitle);
            this.Item41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 231, 140, 65));
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
            this.Chart24_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideAxisLabels();
            this.Chart24_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart24_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart24_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart24_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart24.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart24.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            this.Page3.ExcelSheetValue = null;
            this.Page3.Interaction = null;
            this.Page3.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page3_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page3_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page3_Watermark.Image = null;
            this.Page3_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page3.Report = this;
            this.Page3.Watermark = this.Page3_Watermark;
            this.Text15.Page = this.Page3;
            this.Text15.Parent = this.Page3;
            this.Chart16.Area = this.Chart16_Area;
            this.Chart16.Legend = this.Chart16_Legend;
            this.Chart16.Page = this.Page3;
            this.Chart16.Parent = this.Page3;
            this.Chart16.SeriesLabels = this.Chart16_SeriesLabels;
            this.Chart16_Area.Chart = this.Chart16;
            this.Chart16_Legend.Chart = this.Chart16;
            this.Item21.Chart = this.Chart16;
            this.Item21.LineMarker = this.Item21_LineMarker;
            this.Item21.Marker = this.Item21_Marker;
            this.Item21.SeriesLabels = this.Item21_SeriesLabels;
            this.Item21_SeriesLabels.Chart = this.Chart16;
            this.Item22.Chart = this.Chart16;
            this.Item22.LineMarker = this.Item22_LineMarker;
            this.Item22.Marker = this.Item22_Marker;
            this.Item22.SeriesLabels = this.Item22_SeriesLabels;
            this.Item22_SeriesLabels.Chart = this.Chart16;
            this.Chart16_SeriesLabels.Chart = this.Chart16;
            this.Text16.Page = this.Page3;
            this.Text16.Parent = this.Page3;
            this.Chart17.Area = this.Chart17_Area;
            this.Chart17.Legend = this.Chart17_Legend;
            this.Chart17.Page = this.Page3;
            this.Chart17.Parent = this.Page3;
            this.Chart17.SeriesLabels = this.Chart17_SeriesLabels;
            this.Chart17_Area.Chart = this.Chart17;
            this.Chart17_Legend.Chart = this.Chart17;
            this.Item25.Chart = this.Chart17;
            this.Item25.LineMarker = this.Item25_LineMarker;
            this.Item25.Marker = this.Item25_Marker;
            this.Item25.SeriesLabels = this.Item25_SeriesLabels;
            this.Item25_SeriesLabels.Chart = this.Chart17;
            this.Item26.Chart = this.Chart17;
            this.Item26.LineMarker = this.Item26_LineMarker;
            this.Item26.Marker = this.Item26_Marker;
            this.Item26.SeriesLabels = this.Item26_SeriesLabels;
            this.Item26_SeriesLabels.Chart = this.Chart17;
            this.Chart17_SeriesLabels.Chart = this.Chart17;
            this.Text17.Page = this.Page3;
            this.Text17.Parent = this.Page3;
            this.Chart19.Area = this.Chart19_Area;
            this.Chart19.Legend = this.Chart19_Legend;
            this.Chart19.Page = this.Page3;
            this.Chart19.Parent = this.Page3;
            this.Chart19.SeriesLabels = this.Chart19_SeriesLabels;
            this.Chart19_Area.Chart = this.Chart19;
            this.Chart19_Legend.Chart = this.Chart19;
            this.Item29.Chart = this.Chart19;
            this.Item29.LineMarker = this.Item29_LineMarker;
            this.Item29.Marker = this.Item29_Marker;
            this.Item29.SeriesLabels = this.Item29_SeriesLabels;
            this.Item29_SeriesLabels.Chart = this.Chart19;
            this.Item30.Chart = this.Chart19;
            this.Item30.LineMarker = this.Item30_LineMarker;
            this.Item30.Marker = this.Item30_Marker;
            this.Item30.SeriesLabels = this.Item30_SeriesLabels;
            this.Item30_SeriesLabels.Chart = this.Chart19;
            this.Chart19_SeriesLabels.Chart = this.Chart19;
            this.Chart23.Area = this.Chart23_Area;
            this.Chart23.Legend = this.Chart23_Legend;
            this.Chart23.Page = this.Page3;
            this.Chart23.Parent = this.Page3;
            this.Chart23.SeriesLabels = this.Chart23_SeriesLabels;
            this.Chart23_Area.Chart = this.Chart23;
            this.Chart23_Legend.Chart = this.Chart23;
            this.Item32.Chart = this.Chart23;
            this.Item32.Marker = this.Item32_Marker;
            this.Item32.SeriesLabels = this.Item32_SeriesLabels;
            this.Item32_SeriesLabels.Chart = this.Chart23;
            this.Item33.Chart = this.Chart23;
            this.Item33.Marker = this.Item33_Marker;
            this.Item33.SeriesLabels = this.Item33_SeriesLabels;
            this.Item33_SeriesLabels.Chart = this.Chart23;
            this.Chart23_SeriesLabels.Chart = this.Chart23;
            this.Text24.Page = this.Page3;
            this.Text24.Parent = this.Page3;
            this.Chart18.Area = this.Chart18_Area;
            this.Chart18.Legend = this.Chart18_Legend;
            this.Chart18.Page = this.Page3;
            this.Chart18.Parent = this.Page3;
            this.Chart18.SeriesLabels = this.Chart18_SeriesLabels;
            this.Chart18_Area.Chart = this.Chart18;
            this.Chart18_Legend.Chart = this.Chart18;
            this.Item36.Chart = this.Chart18;
            this.Item36.Marker = this.Item36_Marker;
            this.Item36.SeriesLabels = this.Item36_SeriesLabels;
            this.Item36_SeriesLabels.Chart = this.Chart18;
            this.Chart18_SeriesLabels.Chart = this.Chart18;
            this.Text18.Page = this.Page3;
            this.Text18.Parent = this.Page3;
            this.Text23.Page = this.Page3;
            this.Text23.Parent = this.Page3;
            this.Chart24.Area = this.Chart24_Area;
            this.Chart24.Legend = this.Chart24_Legend;
            this.Chart24.Page = this.Page3;
            this.Chart24.Parent = this.Page3;
            this.Chart24.SeriesLabels = this.Chart24_SeriesLabels;
            this.Chart24_Area.Chart = this.Chart24;
            this.Chart24_Legend.Chart = this.Chart24;
            this.Item40.Chart = this.Chart24;
            this.Item40.Marker = this.Item40_Marker;
            this.Item40.SeriesLabels = this.Item40_SeriesLabels;
            this.Item40_SeriesLabels.Chart = this.Chart24;
            this.Item41.Chart = this.Chart24;
            this.Item41.Marker = this.Item41_Marker;
            this.Item41.SeriesLabels = this.Item41_SeriesLabels;
            this.Item41_SeriesLabels.Chart = this.Chart24;
            this.Chart24_SeriesLabels.Chart = this.Chart24;
            // 
            // Add to Chart16.Series
            // 
            this.Chart16.Series.Clear();
            this.Chart16.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item21,
                        this.Item22});
            // 
            // Add to Chart17.Series
            // 
            this.Chart17.Series.Clear();
            this.Chart17.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item25,
                        this.Item26});
            // 
            // Add to Chart19.Series
            // 
            this.Chart19.Series.Clear();
            this.Chart19.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item29,
                        this.Item30});
            // 
            // Add to Chart23.Series
            // 
            this.Chart23.Series.Clear();
            this.Chart23.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item32,
                        this.Item33});
            // 
            // Add to Chart18.Series
            // 
            this.Chart18.Series.Clear();
            this.Chart18.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item36});
            // 
            // Add to Chart24.Series
            // 
            this.Chart24.Series.Clear();
            this.Chart24.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item40,
                        this.Item41});
            // 
            // Add to Page3.Components
            // 
            this.Page3.Components.Clear();
            this.Page3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text15,
                        this.Chart16,
                        this.Text16,
                        this.Chart17,
                        this.Text17,
                        this.Chart19,
                        this.Chart23,
                        this.Text24,
                        this.Chart18,
                        this.Text18,
                        this.Text23,
                        this.Chart24});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page3});
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