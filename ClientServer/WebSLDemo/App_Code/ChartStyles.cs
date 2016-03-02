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
    public class ChartStyles : Stimulsoft.Report.StiReport
    {
        public ChartStyles()
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
        public new Stimulsoft.Report.Components.StiPage Styles;
        public Stimulsoft.Report.Chart.StiChart Chart9;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart9_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart9_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item20;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item20_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart9_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart20;
        public Stimulsoft.Report.Chart.StiStackedColumnArea Chart20_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart20_Legend;
        public Stimulsoft.Report.Chart.StiStackedColumnSeries Item22;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item22_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedColumnSeries Item23;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item23_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart20_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart21;
        public Stimulsoft.Report.Chart.StiFullStackedColumnArea Chart21_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart21_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedColumnSeries Item25;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item25_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedColumnSeries Item26;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item26_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart21_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text19;
        public Stimulsoft.Report.Chart.StiChart Chart22;
        public Stimulsoft.Report.Chart.StiClusteredBarArea Chart22_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart22_Legend;
        public Stimulsoft.Report.Chart.StiClusteredBarSeries Item29;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item29_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart22_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Chart.StiChart Chart27;
        public Stimulsoft.Report.Chart.StiStackedBarArea Chart27_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart27_Legend;
        public Stimulsoft.Report.Chart.StiStackedBarSeries Item32;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item32_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedBarSeries Item33;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item33_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart27_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text21;
        public Stimulsoft.Report.Chart.StiChart Chart28;
        public Stimulsoft.Report.Chart.StiFullStackedBarArea Chart28_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart28_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedBarSeries Item36;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item36_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedBarSeries Item37;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item37_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart28_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text26;
        public Stimulsoft.Report.Components.StiText Text27;
        public Stimulsoft.Report.Components.StiText Text28;
        public Stimulsoft.Report.Components.StiText Text29;
        public Stimulsoft.Report.Chart.StiChart Chart29;
        public Stimulsoft.Report.Chart.StiStackedLineArea Chart29_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart29_Legend;
        public Stimulsoft.Report.Chart.StiStackedLineSeries Item43;
        public Stimulsoft.Report.Chart.StiLineMarker Item43_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item43_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item43_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedLineSeries Item44;
        public Stimulsoft.Report.Chart.StiLineMarker Item44_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item44_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item44_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart29_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text30;
        public Stimulsoft.Report.Chart.StiChart Chart30;
        public Stimulsoft.Report.Chart.StiLineArea Chart30_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart30_Legend;
        public Stimulsoft.Report.Chart.StiLineSeries Item47;
        public Stimulsoft.Report.Chart.StiLineMarker Item47_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item47_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item47_SeriesLabels;
        public Stimulsoft.Report.Chart.StiLineSeries Item48;
        public Stimulsoft.Report.Chart.StiLineMarker Item48_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item48_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item48_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart30_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart31;
        public Stimulsoft.Report.Chart.StiSplineArea Chart31_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart31_Legend;
        public Stimulsoft.Report.Chart.StiSplineSeries Item50;
        public Stimulsoft.Report.Chart.StiMarker Item50_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item50_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSplineSeries Item51;
        public Stimulsoft.Report.Chart.StiMarker Item51_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item51_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart31_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text32;
        public Stimulsoft.Report.Chart.StiChart Chart33;
        public Stimulsoft.Report.Chart.StiFullStackedSplineArea Chart33_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart33_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedSplineSeries Item54;
        public Stimulsoft.Report.Chart.StiMarker Item54_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item54_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedSplineSeries Item55;
        public Stimulsoft.Report.Chart.StiMarker Item55_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item55_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart33_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text33;
        public Stimulsoft.Report.Components.StiText Text34;
        public Stimulsoft.Report.Chart.StiChart Chart34;
        public Stimulsoft.Report.Chart.StiStackedSplineArea Chart34_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart34_Legend;
        public Stimulsoft.Report.Chart.StiStackedSplineSeries Item59;
        public Stimulsoft.Report.Chart.StiMarker Item59_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item59_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedSplineSeries Item60;
        public Stimulsoft.Report.Chart.StiMarker Item60_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item60_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart34_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text35;
        public Stimulsoft.Report.Chart.StiChart Chart35;
        public Stimulsoft.Report.Chart.StiStackedAreaArea Chart35_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart35_Legend;
        public Stimulsoft.Report.Chart.StiStackedAreaSeries Item63;
        public Stimulsoft.Report.Chart.StiLineMarker Item63_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item63_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item63_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedAreaSeries Item64;
        public Stimulsoft.Report.Chart.StiLineMarker Item64_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item64_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item64_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart35_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text36;
        public Stimulsoft.Report.Chart.StiChart Chart36;
        public Stimulsoft.Report.Chart.StiAreaArea Chart36_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart36_Legend;
        public Stimulsoft.Report.Chart.StiAreaSeries Item67;
        public Stimulsoft.Report.Chart.StiLineMarker Item67_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item67_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item67_SeriesLabels;
        public Stimulsoft.Report.Chart.StiAreaSeries Item68;
        public Stimulsoft.Report.Chart.StiLineMarker Item68_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item68_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item68_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart36_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text37;
        public Stimulsoft.Report.Chart.StiChart Chart37;
        public Stimulsoft.Report.Chart.StiDoughnutArea Chart37_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart37_Legend;
        public Stimulsoft.Report.Chart.StiDoughnutSeries Item71;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item71_SeriesLabels;
        public Stimulsoft.Report.Chart.StiDoughnutSeries Item72;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item72_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterPieLabels Chart37_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text38;
        public Stimulsoft.Report.Chart.StiChart Chart38;
        public Stimulsoft.Report.Chart.StiPieArea Chart38_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart38_Legend;
        public Stimulsoft.Report.Chart.StiPieSeries Item75;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item75_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterPieLabels Chart38_SeriesLabels;
        public Stimulsoft.Report.Components.StiWatermark Styles_Watermark;
        public Stimulsoft.Report.Components.StiPage Page5;
        public Stimulsoft.Report.Chart.StiChart Chart32;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart32_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart32_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item78;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item78_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item79;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item79_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart32_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text31;
        public Stimulsoft.Report.Components.StiText Text39;
        public Stimulsoft.Report.Components.StiText Text40;
        public Stimulsoft.Report.Components.StiText Text41;
        public Stimulsoft.Report.Components.StiText Text42;
        public Stimulsoft.Report.Components.StiText Text43;
        public Stimulsoft.Report.Components.StiText Text44;
        public Stimulsoft.Report.Components.StiText Text45;
        public Stimulsoft.Report.Components.StiText Text46;
        public Stimulsoft.Report.Components.StiText Text47;
        public Stimulsoft.Report.Components.StiText Text48;
        public Stimulsoft.Report.Components.StiText Text49;
        public Stimulsoft.Report.Components.StiText Text50;
        public Stimulsoft.Report.Components.StiText Text51;
        public Stimulsoft.Report.Components.StiText Text52;
        public Stimulsoft.Report.Chart.StiChart Chart39;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart39_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart39_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item96;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item96_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item97;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item97_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart39_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart40;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart40_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart40_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item99;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item99_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item100;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item100_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart40_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart41;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart41_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart41_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item102;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item102_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item103;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item103_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart41_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart42;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart42_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart42_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item105;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item105_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item106;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item106_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart42_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart43;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart43_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart43_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item108;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item108_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item109;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item109_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart43_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart44;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart44_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart44_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item111;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item111_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item112;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item112_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart44_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart45;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart45_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart45_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item114;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item114_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item115;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item115_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart45_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart46;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart46_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart46_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item117;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item117_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item118;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item118_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart46_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart47;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart47_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart47_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item120;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item120_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item121;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item121_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart47_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart48;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart48_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart48_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item123;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item123_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item124;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item124_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart48_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart49;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart49_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart49_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item126;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item126_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item127;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item127_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart49_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart50;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart50_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart50_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item129;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item129_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item130;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item130_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart50_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart51;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart51_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart51_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item132;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item132_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item133;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item133_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart51_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart52;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart52_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart52_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item135;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item135_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item136;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item136_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart52_SeriesLabels;
        public Stimulsoft.Report.Components.StiWatermark Page5_Watermark;
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
        
        public void Text19__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Syle 03";
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
            e.Value = "Amount orders per countries";
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 05";
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
        
        public void Text21__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 15";
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
        
        public void Text26__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 04";
        }
        
        public void Text27__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 01";
        }
        
        public void Text28__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 02";
        }
        
        public void Text29__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 07";
        }
        
        public void Item43__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item43__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;25;15;15";
        }
        
        public void Item43__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item44__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item44__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;15;25;10";
        }
        
        public void Item44__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text30__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 09";
        }
        
        public void Item47__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item47__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;25;15;15";
        }
        
        public void Item47__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item48__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item48__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;15;25;10";
        }
        
        public void Item48__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Item50__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item50__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item50__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item51__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item51__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item51__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text32__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 08";
        }
        
        public void Item54__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item54__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item54__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item55__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item55__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item55__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text33__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 10";
        }
        
        public void Text34__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 06";
        }
        
        public void Item59__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item59__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item59__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item60__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item60__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item60__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text35__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 12";
        }
        
        public void Item63__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item63__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;10;30;15;10;20;15;30;10";
        }
        
        public void Item63__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item64__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item64__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;20;20;15;10;15;40;20;10";
        }
        
        public void Item64__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text36__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 11";
        }
        
        public void Item67__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item67__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;10;15;5;15;10;20;15;5;10";
        }
        
        public void Item67__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item68__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item68__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;20;20;15;10;15;40;20;10";
        }
        
        public void Item68__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text37__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 13";
        }
        
        public void Item71__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4";
        }
        
        public void Item71__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;50;30";
        }
        
        public void Item71__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item72__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4";
        }
        
        public void Item72__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;7;13;4";
        }
        
        public void Item72__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 2";
        }
        
        public void Text38__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 14";
        }
        
        public void Item75__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item75__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;30;10;30;25";
        }
        
        public void Item75__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item78__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item78__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item78__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item79__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item79__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item79__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Text31__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 01";
        }
        
        public void Text39__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 02";
        }
        
        public void Text40__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 03";
        }
        
        public void Text41__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 04";
        }
        
        public void Text42__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 05";
        }
        
        public void Text43__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 06";
        }
        
        public void Text44__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 07";
        }
        
        public void Text45__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 08";
        }
        
        public void Text46__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 09";
        }
        
        public void Text47__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 10";
        }
        
        public void Text48__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 11";
        }
        
        public void Text49__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 12";
        }
        
        public void Text50__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 13";
        }
        
        public void Text51__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 14";
        }
        
        public void Text52__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 15";
        }
        
        public void Item96__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item96__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item96__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item97__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item97__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item97__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item99__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item99__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item99__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item100__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item100__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item100__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item102__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item102__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item102__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item103__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item103__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item103__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item105__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item105__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item105__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item106__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item106__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item106__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item108__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item108__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item108__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item109__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item109__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item109__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item111__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item111__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item111__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item112__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item112__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item112__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item114__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item114__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item114__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item115__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item115__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item115__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item117__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item117__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item117__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item118__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item118__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item118__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item120__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item120__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item120__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item121__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item121__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item121__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item123__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item123__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item123__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item124__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item124__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item124__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item126__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item126__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item126__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item127__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item127__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item127__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item129__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item129__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item129__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item130__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item130__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item130__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item132__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item132__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item132__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item133__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item133__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item133__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item135__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item135__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item135__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item136__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item136__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item136__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
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
            this.ReportAlias = "Pie and Doughnut";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2006, 6, 12, 17, 38, 23, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2006, 6, 6, 13, 21, 42, 0);
            this.ReportDescription = "This sample demonstrates different chart styles.";
            this.ReportFile = "E:\\Stimulsoft\\Stimulsoft.Reports\\Demo\\Bin\\Reports\\ChartStyles.mrt";
            this.ReportGuid = "fa1f0c737b39463b87e6dbf56f95f238";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2008.2.291";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Styles
            // 
            this.Styles = new Stimulsoft.Report.Components.StiPage();
            this.Styles.Guid = "8aa140185c1d4edb8a1ededf21dee42b";
            this.Styles.Name = "Styles";
            this.Styles.PageHeight = 29.7;
            this.Styles.PageWidth = 21;
            this.Styles.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Styles.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Chart9
            // 
            this.Chart9 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.6, 6.2, 4.4);
            this.Chart9.CountData = 7;
            this.Chart9.CustomStyleName = "";
            this.Chart9.FilterOn = false;
            this.Chart9.Name = "Chart9";
            this.Chart9.Sort = new System.String[0];
            this.Chart9_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart9_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_Area.ShowShadow = true;
            this.Chart9_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart9_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart9_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart9_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart9_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart9_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart9_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.Triangle, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart9_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart9_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart9_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart9.Guid = null;
            this.Chart9.Interaction = null;
            this.Chart9_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart9_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart9_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_Legend.Visible = false;
            this.Chart9_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart9_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart9_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart9.MasterComponent = null;
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
            this.Chart9_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart9_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart9_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart9_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Chart9_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart9.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart9.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart20
            // 
            this.Chart20 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 0.6, 6.6, 4.4);
            this.Chart20.CountData = 10;
            this.Chart20.CustomStyleName = "";
            this.Chart20.FilterOn = false;
            this.Chart20.Name = "Chart20";
            this.Chart20.Sort = new System.String[0];
            this.Chart20_Area = new Stimulsoft.Report.Chart.StiStackedColumnArea();
            this.Chart20_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart20_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart20_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart20_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart20_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 145, 145)), false, true);
            this.Chart20_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 145, 145)), false, true);
            this.Chart20_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.TwoLines, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart20_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, false, true);
            this.Chart20_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart20_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, true);
            this.Chart20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart20.Guid = null;
            this.Chart20.Interaction = null;
            this.Chart20_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart20_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart20_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart20_Legend.Visible = false;
            this.Chart20_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart20_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart20_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart20.MasterComponent = null;
            // 
            // Item22
            // 
            this.Item22 = new Stimulsoft.Report.Chart.StiStackedColumnSeries();
            this.Item22.BorderColor = System.Drawing.Color.FromArgb(255, 28, 45, 65);
            this.Item22.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item22__GetListOfArguments);
            this.Item22.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item22__GetListOfValues);
            this.Item22.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item22__GetTitle);
            this.Item22.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 128, 145, 165), System.Drawing.Color.FromArgb(255, 178, 195, 215), 0, 0.5F, 1F);
            this.Item22.DrillDownPageGuid = null;
            this.Item22_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item22_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item22_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item22_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item22_SeriesLabels.ValueTypeSeparator = "-";
            this.Item22_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Item22_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item23
            // 
            this.Item23 = new Stimulsoft.Report.Chart.StiStackedColumnSeries();
            this.Item23.BorderColor = System.Drawing.Color.FromArgb(255, 71, 23, 22);
            this.Item23.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item23__GetListOfArguments);
            this.Item23.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item23__GetListOfValues);
            this.Item23.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item23__GetTitle);
            this.Item23.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 171, 123, 122), System.Drawing.Color.FromArgb(255, 221, 173, 172), 0, 0.5F, 1F);
            this.Item23.DrillDownPageGuid = null;
            this.Item23_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item23_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item23_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item23_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item23_SeriesLabels.ValueTypeSeparator = "-";
            this.Item23_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Item23_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart20_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart20_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart20_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart20_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Chart20_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart20.Style = new Stimulsoft.Report.Chart.StiStyle02();
            this.Chart20.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 95, 95)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart21
            // 
            this.Chart21 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0.6, 6.2, 4.4);
            this.Chart21.CountData = 10;
            this.Chart21.CustomStyleName = "";
            this.Chart21.FilterOn = false;
            this.Chart21.Name = "Chart21";
            this.Chart21.Sort = new System.String[0];
            this.Chart21_Area = new Stimulsoft.Report.Chart.StiFullStackedColumnArea();
            this.Chart21_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart21_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart21_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart21_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart21_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 145, 145)), false, true);
            this.Chart21_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 145, 145)), false, true);
            this.Chart21_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart21_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, false, true);
            this.Chart21_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart21_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, true);
            this.Chart21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart21.Guid = null;
            this.Chart21.Interaction = null;
            this.Chart21_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart21_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart21_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_Legend.Visible = false;
            this.Chart21_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart21_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart21_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart21.MasterComponent = null;
            // 
            // Item25
            // 
            this.Item25 = new Stimulsoft.Report.Chart.StiFullStackedColumnSeries();
            this.Item25.BorderColor = System.Drawing.Color.FromArgb(255, 50, 0, 0);
            this.Item25.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item25__GetListOfArguments);
            this.Item25.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item25__GetListOfValues);
            this.Item25.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item25__GetTitle);
            this.Item25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 150, 61, 59));
            this.Item25.DrillDownPageGuid = null;
            this.Item25_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item25_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item25_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item25_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item25_SeriesLabels.ValueTypeSeparator = "-";
            this.Item25_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Item25_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item26
            // 
            this.Item26 = new Stimulsoft.Report.Chart.StiFullStackedColumnSeries();
            this.Item26.BorderColor = System.Drawing.Color.FromArgb(255, 79, 0, 0);
            this.Item26.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfArguments);
            this.Item26.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfValues);
            this.Item26.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item26__GetTitle);
            this.Item26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 179, 74, 71));
            this.Item26.DrillDownPageGuid = null;
            this.Item26_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item26_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item26_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item26_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item26_SeriesLabels.ValueTypeSeparator = "-";
            this.Item26_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Item26_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart21_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart21_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart21_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart21_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Chart21_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart21.Style = new Stimulsoft.Report.Chart.StiStyle03();
            this.Chart21.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 95, 95)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text19
            // 
            this.Text19 = new Stimulsoft.Report.Components.StiText();
            this.Text19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0, 6.2, 0.6);
            this.Text19.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text19.Name = "Text19";
            this.Text19.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text19__GetValue);
            this.Text19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text19.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text19.Guid = null;
            this.Text19.Indicator = null;
            this.Text19.Interaction = null;
            this.Text19.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text19.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text19.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart22
            // 
            this.Chart22 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 5.8, 6.6, 4.4);
            this.Chart22.CountData = 10;
            this.Chart22.CustomStyleName = "";
            this.Chart22.FilterOn = false;
            this.Chart22.Name = "Chart22";
            this.Chart22.Sort = new System.String[0];
            this.Chart22_Area = new Stimulsoft.Report.Chart.StiClusteredBarArea();
            this.Chart22_Area.BorderColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 245), 90);
            this.Chart22_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart22_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart22_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart22_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 150, 105)), false, true);
            this.Chart22_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 150, 105)), false, true);
            this.Chart22_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 100, 55), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart22_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 100, 55), 1F, false, true, false, true);
            this.Chart22_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 100, 55), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart22_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 100, 55), 1F, false, true, true);
            this.Chart22.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart22.Guid = null;
            this.Chart22.Interaction = null;
            this.Chart22_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart22_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart22_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_Legend.Visible = false;
            this.Chart22_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 225), 90);
            this.Chart22_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart22_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart22.MasterComponent = null;
            // 
            // Item29
            // 
            this.Item29 = new Stimulsoft.Report.Chart.StiClusteredBarSeries();
            this.Item29.BorderColor = System.Drawing.Color.FromArgb(255, 124, 69, 0);
            this.Item29.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item29__GetListOfArguments);
            this.Item29.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item29__GetListOfValues);
            this.Item29.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item29__GetTitle);
            this.Item29.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 224, 169, 61), System.Drawing.Color.FromArgb(255, 174, 119, 11), 90);
            this.Item29.DrillDownPageGuid = null;
            this.Item29_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item29_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Item29_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Item29_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item29_SeriesLabels.ValueTypeSeparator = "-";
            this.Item29_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.LemonChiffon);
            this.Item29_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart22_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart22_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart22_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart22_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.LemonChiffon);
            this.Chart22_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart22.Style = new Stimulsoft.Report.Chart.StiStyle05();
            this.Chart22.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 105, 100, 55)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 5.2, 6.6, 0.6);
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text20.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text20.Guid = null;
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart27
            // 
            this.Chart27 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 22.6, 6.2, 5);
            this.Chart27.CountData = 10;
            this.Chart27.CustomStyleName = "";
            this.Chart27.FilterOn = false;
            this.Chart27.Name = "Chart27";
            this.Chart27.Sort = new System.String[0];
            this.Chart27_Area = new Stimulsoft.Report.Chart.StiStackedBarArea();
            this.Chart27_Area.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart27_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart27_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart27_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart27_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 119, 145, 149)), false, true);
            this.Chart27_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 119, 145, 149)), false, true);
            this.Chart27_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 69, 95, 99), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart27_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 69, 95, 99), 1F, false, true, false, true);
            this.Chart27_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 69, 95, 99), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart27_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 69, 95, 99), 1F, false, true, true);
            this.Chart27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart27.Guid = null;
            this.Chart27.Interaction = null;
            this.Chart27_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart27_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart27_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_Legend.Visible = false;
            this.Chart27_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 239, 255, 255), 90);
            this.Chart27_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart27_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart27.MasterComponent = null;
            // 
            // Item32
            // 
            this.Item32 = new Stimulsoft.Report.Chart.StiStackedBarSeries();
            this.Item32.BorderColor = System.Drawing.Color.FromArgb(255, 0, 11, 98);
            this.Item32.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item32__GetListOfArguments);
            this.Item32.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item32__GetListOfValues);
            this.Item32.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item32__GetTitle);
            this.Item32.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 15, 111, 198), System.Drawing.Color.FromArgb(255, 0, 61, 148), 90);
            this.Item32.DrillDownPageGuid = null;
            this.Item32_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item32_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Item32_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Item32_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item32_SeriesLabels.ValueTypeSeparator = "-";
            this.Item32_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 219, 245, 249));
            this.Item32_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item33
            // 
            this.Item33 = new Stimulsoft.Report.Chart.StiStackedBarSeries();
            this.Item33.BorderColor = System.Drawing.Color.FromArgb(255, 0, 57, 117);
            this.Item33.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfArguments);
            this.Item33.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfValues);
            this.Item33.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item33__GetTitle);
            this.Item33.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 0, 157, 217), System.Drawing.Color.FromArgb(255, 0, 107, 167), 90);
            this.Item33.DrillDownPageGuid = null;
            this.Item33_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item33_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Item33_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Item33_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item33_SeriesLabels.ValueTypeSeparator = "-";
            this.Item33_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 219, 245, 249));
            this.Item33_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart27_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart27_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart27_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart27_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 219, 245, 249));
            this.Chart27_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart27.Style = new Stimulsoft.Report.Chart.StiStyle15();
            this.Chart27.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 69, 95, 99)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text21
            // 
            this.Text21 = new Stimulsoft.Report.Components.StiText();
            this.Text21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 22, 6.2, 0.6);
            this.Text21.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text21.Name = "Text21";
            this.Text21.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text21__GetValue);
            this.Text21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text21.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text21.Guid = null;
            this.Text21.Indicator = null;
            this.Text21.Interaction = null;
            this.Text21.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text21.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text21.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart28
            // 
            this.Chart28 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.6, 6.2, 4.6);
            this.Chart28.CountData = 10;
            this.Chart28.CustomStyleName = "";
            this.Chart28.FilterOn = false;
            this.Chart28.Name = "Chart28";
            this.Chart28.Sort = new System.String[0];
            this.Chart28_Area = new Stimulsoft.Report.Chart.StiFullStackedBarArea();
            this.Chart28_Area.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart28_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart28_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart28_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart28_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 155, 155)), false, true);
            this.Chart28_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 155, 155)), false, true);
            this.Chart28_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 105, 105), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart28_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 105, 105), 1F, false, true, false, true);
            this.Chart28_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 105, 105), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart28_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 105, 105), 1F, false, true, true);
            this.Chart28.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart28.Guid = null;
            this.Chart28.Interaction = null;
            this.Chart28_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart28_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart28_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_Legend.Visible = false;
            this.Chart28_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart28_Legend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Chart28_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart28.MasterComponent = null;
            // 
            // Item36
            // 
            this.Item36 = new Stimulsoft.Report.Chart.StiFullStackedBarSeries();
            this.Item36.BorderColor = System.Drawing.Color.FromArgb(255, 117, 151, 68);
            this.Item36.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item36__GetListOfArguments);
            this.Item36.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item36__GetListOfValues);
            this.Item36.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item36__GetTitle);
            this.Item36.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 167, 201, 118), System.Drawing.Color.FromArgb(255, 255, 255, 218), 0);
            this.Item36.DrillDownPageGuid = null;
            this.Item36_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item36_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Item36_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Item36_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item36_SeriesLabels.ValueTypeSeparator = "-";
            this.Item36_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Item36_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item37
            // 
            this.Item37 = new Stimulsoft.Report.Chart.StiFullStackedBarSeries();
            this.Item37.BorderColor = System.Drawing.Color.FromArgb(255, 100, 81, 131);
            this.Item37.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item37__GetListOfArguments);
            this.Item37.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item37__GetListOfValues);
            this.Item37.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item37__GetTitle);
            this.Item37.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 150, 131, 181), System.Drawing.Color.FromArgb(255, 250, 231, 255), 0);
            this.Item37.DrillDownPageGuid = null;
            this.Item37_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item37_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Item37_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Item37_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item37_SeriesLabels.ValueTypeSeparator = "-";
            this.Item37_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Item37_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart28_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart28_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart28_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart28_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Chart28_SeriesLabels.Font = new System.Drawing.Font("Arial", 5F);
            this.Chart28.Style = new Stimulsoft.Report.Chart.StiStyle07();
            this.Chart28.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 105, 105, 105)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text26
            // 
            this.Text26 = new Stimulsoft.Report.Components.StiText();
            this.Text26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5.2, 6.2, 0.6);
            this.Text26.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text26.Name = "Text26";
            this.Text26.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text26__GetValue);
            this.Text26.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text26.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.Text26.Guid = null;
            this.Text26.Indicator = null;
            this.Text26.Interaction = null;
            this.Text26.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text26.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text26.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text27
            // 
            this.Text27 = new Stimulsoft.Report.Components.StiText();
            this.Text27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.2, 0.6);
            this.Text27.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text27.Name = "Text27";
            this.Text27.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text27__GetValue);
            this.Text27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text27.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text27.Guid = null;
            this.Text27.Indicator = null;
            this.Text27.Interaction = null;
            this.Text27.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text27.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text27.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text28
            // 
            this.Text28 = new Stimulsoft.Report.Components.StiText();
            this.Text28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 0, 6.6, 0.6);
            this.Text28.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text28.Name = "Text28";
            this.Text28.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text28__GetValue);
            this.Text28.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text28.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text28.Guid = null;
            this.Text28.Indicator = null;
            this.Text28.Interaction = null;
            this.Text28.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text28.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text28.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text29
            // 
            this.Text29 = new Stimulsoft.Report.Components.StiText();
            this.Text29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.2, 6.2, 0.6);
            this.Text29.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text29.Name = "Text29";
            this.Text29.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text29__GetValue);
            this.Text29.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text29.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text29.Guid = null;
            this.Text29.Indicator = null;
            this.Text29.Interaction = null;
            this.Text29.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text29.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text29.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart29
            // 
            this.Chart29 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 10.8, 6.6, 4.4);
            this.Chart29.CountData = 10;
            this.Chart29.CustomStyleName = "";
            this.Chart29.FilterOn = false;
            this.Chart29.Name = "Chart29";
            this.Chart29.Sort = new System.String[0];
            this.Chart29_Area = new Stimulsoft.Report.Chart.StiStackedLineArea();
            this.Chart29_Area.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart29_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart29_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart29_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart29_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 138, 136, 125)), false, true);
            this.Chart29_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 138, 136, 125)), false, true);
            this.Chart29_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 88, 86, 75), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart29_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 88, 86, 75), 1F, false, true, false, true);
            this.Chart29_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 88, 86, 75), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart29_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 88, 86, 75), 1F, false, true, true);
            this.Chart29.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart29.Guid = null;
            this.Chart29.Interaction = null;
            this.Chart29_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart29_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart29_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 245), 90);
            this.Chart29_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart29_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart29.MasterComponent = null;
            // 
            // Item43
            // 
            this.Item43 = new Stimulsoft.Report.Chart.StiStackedLineSeries();
            this.Item43.LineColor = System.Drawing.Color.FromArgb(255, 79, 129, 189);
            this.Item43.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item43__GetListOfArguments);
            this.Item43.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item43__GetListOfValues);
            this.Item43.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item43__GetTitle);
            this.Item43.DrillDownPageGuid = null;
            this.Item43_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item43_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0, 39);
            this.Item43_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 129, 179, 239));
            this.Item43_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item43_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 0, 29, 89);
            this.Item43_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 179, 229, 255));
            this.Item43_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item43_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Item43_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Item43_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item43_SeriesLabels.ValueTypeSeparator = "-";
            this.Item43_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 238, 236, 225));
            this.Item43_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item44
            // 
            this.Item44 = new Stimulsoft.Report.Chart.StiStackedLineSeries();
            this.Item44.LineColor = System.Drawing.Color.FromArgb(255, 192, 80, 77);
            this.Item44.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item44__GetListOfArguments);
            this.Item44.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item44__GetListOfValues);
            this.Item44.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item44__GetTitle);
            this.Item44.DrillDownPageGuid = null;
            this.Item44_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item44_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 42, 0, 0);
            this.Item44_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 130, 127));
            this.Item44_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item44_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 92, 0, 0);
            this.Item44_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 180, 177));
            this.Item44_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item44_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Item44_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Item44_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item44_SeriesLabels.ValueTypeSeparator = "-";
            this.Item44_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 238, 236, 225));
            this.Item44_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart29_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart29_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart29_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart29_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 238, 236, 225));
            this.Chart29_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart29.Style = new Stimulsoft.Report.Chart.StiStyle09();
            this.Chart29.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 88, 86, 75)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text30
            // 
            this.Text30 = new Stimulsoft.Report.Components.StiText();
            this.Text30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 10.2, 6.6, 0.6);
            this.Text30.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text30.Name = "Text30";
            this.Text30.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text30__GetValue);
            this.Text30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text30.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text30.Guid = null;
            this.Text30.Indicator = null;
            this.Text30.Interaction = null;
            this.Text30.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text30.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text30.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart30
            // 
            this.Chart30 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5.8, 6.2, 4.4);
            this.Chart30.CustomStyleName = "";
            this.Chart30.Name = "Chart30";
            this.Chart30.Sort = new System.String[0];
            this.Chart30_Area = new Stimulsoft.Report.Chart.StiLineArea();
            this.Chart30_Area.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 246, 255), System.Drawing.Color.FromArgb(255, 221, 206, 240), 90);
            this.Chart30_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart30_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart30_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart30_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 81, 66, 100)), false, true);
            this.Chart30_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 81, 66, 100)), false, true);
            this.Chart30_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 31, 16, 50), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart30_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 31, 16, 50), 1F, false, true, false, true);
            this.Chart30_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 31, 16, 50), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart30_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 31, 16, 50), 1F, false, true, true);
            this.Chart30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart30.Guid = null;
            this.Chart30.Interaction = null;
            this.Chart30_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart30_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart30_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 246, 255), System.Drawing.Color.FromArgb(255, 201, 186, 220), 90);
            this.Chart30_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart30_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart30.MasterComponent = null;
            // 
            // Item47
            // 
            this.Item47 = new Stimulsoft.Report.Chart.StiLineSeries();
            this.Item47.LineColor = System.Drawing.Color.FromArgb(255, 72, 57, 90);
            this.Item47.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item47__GetListOfArguments);
            this.Item47.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item47__GetListOfValues);
            this.Item47.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item47__GetTitle);
            this.Item47.DrillDownPageGuid = null;
            this.Item47_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item47_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            this.Item47_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 122, 107, 140));
            this.Item47_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item47_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            this.Item47_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 172, 157, 190));
            this.Item47_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item47_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Item47_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Item47_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item47_SeriesLabels.ValueTypeSeparator = "-";
            this.Item47_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 181, 166, 200));
            this.Item47_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item48
            // 
            this.Item48 = new Stimulsoft.Report.Chart.StiLineSeries();
            this.Item48.LineColor = System.Drawing.Color.FromArgb(255, 109, 87, 137);
            this.Item48.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item48__GetListOfArguments);
            this.Item48.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item48__GetListOfValues);
            this.Item48.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item48__GetTitle);
            this.Item48.DrillDownPageGuid = null;
            this.Item48_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item48_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            this.Item48_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 159, 137, 187));
            this.Item48_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item48_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 9, 0, 37);
            this.Item48_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 209, 187, 237));
            this.Item48_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item48_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Item48_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Item48_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item48_SeriesLabels.ValueTypeSeparator = "-";
            this.Item48_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 181, 166, 200));
            this.Item48_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart30_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart30_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart30_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart30_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 181, 166, 200));
            this.Chart30_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart30.Style = new Stimulsoft.Report.Chart.StiStyle04();
            this.Chart30.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 31, 16, 50)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart31
            // 
            this.Chart31 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 10.8, 6.6, 4.4);
            this.Chart31.CountData = 10;
            this.Chart31.CustomStyleName = "";
            this.Chart31.FilterOn = false;
            this.Chart31.Name = "Chart31";
            this.Chart31.Sort = new System.String[0];
            this.Chart31_Area = new Stimulsoft.Report.Chart.StiSplineArea();
            this.Chart31_Area.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 222, 235, 255), 90);
            this.Chart31_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart31_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart31_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart31_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 82, 95, 120)), false, true);
            this.Chart31_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 82, 95, 120)), false, true);
            this.Chart31_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 32, 45, 70), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart31_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 32, 45, 70), 1F, false, true, false, true);
            this.Chart31_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 32, 45, 70), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart31_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 32, 45, 70), 1F, false, true, true);
            this.Chart31.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart31.Guid = null;
            this.Chart31.Interaction = null;
            this.Chart31_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart31_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart31_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_Legend.Visible = false;
            this.Chart31_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 202, 215, 240), 90);
            this.Chart31_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart31_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart31.MasterComponent = null;
            // 
            // Item50
            // 
            this.Item50 = new Stimulsoft.Report.Chart.StiSplineSeries();
            this.Item50.LineColor = System.Drawing.Color.FromArgb(255, 60, 100, 148);
            this.Item50.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item50__GetListOfArguments);
            this.Item50.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item50__GetListOfValues);
            this.Item50.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item50__GetTitle);
            this.Item50.DrillDownPageGuid = null;
            this.Item50_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item50_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0, 48);
            this.Item50_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 160, 200, 248));
            this.Item50_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item50_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Item50_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Item50_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item50_SeriesLabels.ValueTypeSeparator = "-";
            this.Item50_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 182, 195, 220));
            this.Item50_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item51
            // 
            this.Item51 = new Stimulsoft.Report.Chart.StiSplineSeries();
            this.Item51.LineColor = System.Drawing.Color.FromArgb(255, 73, 120, 177);
            this.Item51.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item51__GetListOfArguments);
            this.Item51.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item51__GetListOfValues);
            this.Item51.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item51__GetTitle);
            this.Item51.DrillDownPageGuid = null;
            this.Item51_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item51_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 0, 20, 77);
            this.Item51_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 173, 220, 255));
            this.Item51_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item51_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Item51_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Item51_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item51_SeriesLabels.ValueTypeSeparator = "-";
            this.Item51_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 182, 195, 220));
            this.Item51_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart31_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart31_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart31_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart31_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 182, 195, 220));
            this.Chart31_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart31.Style = new Stimulsoft.Report.Chart.StiStyle08();
            this.Chart31.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 32, 45, 70)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text32
            // 
            this.Text32 = new Stimulsoft.Report.Components.StiText();
            this.Text32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 10.2, 6.6, 0.6);
            this.Text32.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text32.Name = "Text32";
            this.Text32.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text32__GetValue);
            this.Text32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text32.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text32.Guid = null;
            this.Text32.Indicator = null;
            this.Text32.Interaction = null;
            this.Text32.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text32.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text32.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart33
            // 
            this.Chart33 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart33.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 16.2, 6.2, 5.4);
            this.Chart33.CountData = 10;
            this.Chart33.CustomStyleName = "";
            this.Chart33.FilterOn = false;
            this.Chart33.Name = "Chart33";
            this.Chart33.Sort = new System.String[0];
            this.Chart33_Area = new Stimulsoft.Report.Chart.StiFullStackedSplineArea();
            this.Chart33_Area.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 249, 255, 255), 90);
            this.Chart33_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart33_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart33_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart33_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 109, 125, 127)), false, true);
            this.Chart33_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 109, 125, 127)), false, true);
            this.Chart33_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 59, 75, 77), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart33_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 59, 75, 77), 1F, false, true, false, true);
            this.Chart33_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 59, 75, 77), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart33_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 59, 75, 77), 1F, false, true, true);
            this.Chart33.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart33.Guid = null;
            this.Chart33.Interaction = null;
            this.Chart33_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart33_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart33_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 229, 245, 247), 90);
            this.Chart33_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart33_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart33.MasterComponent = null;
            // 
            // Item54
            // 
            this.Item54 = new Stimulsoft.Report.Chart.StiFullStackedSplineSeries();
            this.Item54.LineColor = System.Drawing.Color.FromArgb(255, 121, 181, 176);
            this.Item54.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item54__GetListOfArguments);
            this.Item54.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item54__GetListOfValues);
            this.Item54.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item54__GetTitle);
            this.Item54.DrillDownPageGuid = null;
            this.Item54_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item54_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 21, 81, 76);
            this.Item54_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 221, 255, 255));
            this.Item54_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item54_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Item54_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Item54_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item54_SeriesLabels.ValueTypeSeparator = "-";
            this.Item54_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 209, 225, 227));
            this.Item54_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item55
            // 
            this.Item55 = new Stimulsoft.Report.Chart.StiFullStackedSplineSeries();
            this.Item55.LineColor = System.Drawing.Color.FromArgb(255, 180, 188, 76);
            this.Item55.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item55__GetListOfArguments);
            this.Item55.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item55__GetListOfValues);
            this.Item55.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item55__GetTitle);
            this.Item55.DrillDownPageGuid = null;
            this.Item55_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item55_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 80, 88, 0);
            this.Item55_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 176));
            this.Item55_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item55_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Item55_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Item55_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item55_SeriesLabels.ValueTypeSeparator = "-";
            this.Item55_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 209, 225, 227));
            this.Item55_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart33_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart33_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart33_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart33_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 209, 225, 227));
            this.Chart33_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart33.Style = new Stimulsoft.Report.Chart.StiStyle10();
            this.Chart33.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 59, 75, 77)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text33
            // 
            this.Text33 = new Stimulsoft.Report.Components.StiText();
            this.Text33.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 15.6, 6.2, 0.6);
            this.Text33.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text33.Name = "Text33";
            this.Text33.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text33__GetValue);
            this.Text33.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text33.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text33.Guid = null;
            this.Text33.Indicator = null;
            this.Text33.Interaction = null;
            this.Text33.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text33.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text33.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text34
            this.InitializeComponent2();
        }
        
        public void InitializeComponent2()
        {
            // 
            this.Text34 = new Stimulsoft.Report.Components.StiText();
            this.Text34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 5.2, 6.2, 0.6);
            this.Text34.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text34.Name = "Text34";
            this.Text34.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text34__GetValue);
            this.Text34.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text34.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text34.Guid = null;
            this.Text34.Indicator = null;
            this.Text34.Interaction = null;
            this.Text34.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text34.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text34.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart34
            // 
            this.Chart34 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 5.8, 6.2, 4.4);
            this.Chart34.CustomStyleName = "";
            this.Chart34.Name = "Chart34";
            this.Chart34.Sort = new System.String[0];
            this.Chart34_Area = new Stimulsoft.Report.Chart.StiStackedSplineArea();
            this.Chart34_Area.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 242, 238, 246), 90);
            this.Chart34_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart34_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart34_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart34_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 102, 98, 106)), false, true);
            this.Chart34_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 102, 98, 106)), false, true);
            this.Chart34_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 52, 48, 56), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart34_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 52, 48, 56), 1F, false, true, false, true);
            this.Chart34_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 52, 48, 56), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart34_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 52, 48, 56), 1F, false, true, true);
            this.Chart34.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart34.Guid = null;
            this.Chart34.Interaction = null;
            this.Chart34_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart34_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart34_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 222, 218, 226), 90);
            this.Chart34_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart34_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart34.MasterComponent = null;
            // 
            // Item59
            // 
            this.Item59 = new Stimulsoft.Report.Chart.StiStackedSplineSeries();
            this.Item59.LineColor = System.Drawing.Color.FromArgb(255, 206, 185, 102);
            this.Item59.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item59__GetListOfArguments);
            this.Item59.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item59__GetListOfValues);
            this.Item59.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item59__GetTitle);
            this.Item59.DrillDownPageGuid = null;
            this.Item59_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item59_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 106, 85, 2);
            this.Item59_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 202));
            this.Item59_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item59_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Item59_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Item59_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item59_SeriesLabels.ValueTypeSeparator = "-";
            this.Item59_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 202, 198, 206));
            this.Item59_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item60
            // 
            this.Item60 = new Stimulsoft.Report.Chart.StiStackedSplineSeries();
            this.Item60.LineColor = System.Drawing.Color.FromArgb(255, 156, 176, 132);
            this.Item60.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item60__GetListOfArguments);
            this.Item60.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item60__GetListOfValues);
            this.Item60.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item60__GetTitle);
            this.Item60.DrillDownPageGuid = null;
            this.Item60_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item60_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 56, 76, 32);
            this.Item60_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 232));
            this.Item60_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item60_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Item60_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Item60_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item60_SeriesLabels.ValueTypeSeparator = "-";
            this.Item60_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 202, 198, 206));
            this.Item60_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart34_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart34_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart34_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart34_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 202, 198, 206));
            this.Chart34_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart34.Style = new Stimulsoft.Report.Chart.StiStyle06();
            this.Chart34.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 52, 48, 56)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text35
            // 
            this.Text35 = new Stimulsoft.Report.Components.StiText();
            this.Text35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 15.6, 6.6, 0.6);
            this.Text35.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text35.Name = "Text35";
            this.Text35.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text35__GetValue);
            this.Text35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text35.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text35.Guid = null;
            this.Text35.Indicator = null;
            this.Text35.Interaction = null;
            this.Text35.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text35.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text35.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart35
            // 
            this.Chart35 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 16.2, 6.6, 5.4);
            this.Chart35.CountData = 10;
            this.Chart35.CustomStyleName = "";
            this.Chart35.FilterOn = false;
            this.Chart35.Name = "Chart35";
            this.Chart35.Sort = new System.String[0];
            this.Chart35_Area = new Stimulsoft.Report.Chart.StiStackedAreaArea();
            this.Chart35_Area.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 221), 90);
            this.Chart35_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart35_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart35_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart35_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 128, 81)), false, true);
            this.Chart35_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 128, 81)), false, true);
            this.Chart35_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 78, 31), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart35_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 78, 31), 1F, false, true, false, true);
            this.Chart35_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 78, 31), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart35_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 78, 31), 1F, false, true, true);
            this.Chart35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart35.Guid = null;
            this.Chart35.Interaction = null;
            this.Chart35_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart35_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart35_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 248, 201), 90);
            this.Chart35_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart35_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart35.MasterComponent = null;
            // 
            // Item63
            // 
            this.Item63 = new Stimulsoft.Report.Chart.StiStackedAreaSeries();
            this.Item63.LineColor = System.Drawing.Color.Goldenrod;
            this.Item63.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item63__GetListOfArguments);
            this.Item63.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item63__GetListOfValues);
            this.Item63.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item63__GetTitle);
            this.Item63.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 218, 165, 32));
            this.Item63.DrillDownPageGuid = null;
            this.Item63_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item63_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 68, 15, 0);
            this.Item63_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 215, 82));
            this.Item63_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item63_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 118, 65, 0);
            this.Item63_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 132));
            this.Item63_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item63_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Item63_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Item63_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item63_SeriesLabels.ValueTypeSeparator = "-";
            this.Item63_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Moccasin);
            this.Item63_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item64
            // 
            this.Item64 = new Stimulsoft.Report.Chart.StiStackedAreaSeries();
            this.Item64.LineColor = System.Drawing.Color.Khaki;
            this.Item64.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item64__GetListOfArguments);
            this.Item64.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item64__GetListOfValues);
            this.Item64.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item64__GetTitle);
            this.Item64.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 240, 230, 140));
            this.Item64.DrillDownPageGuid = null;
            this.Item64_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item64_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 90, 80, 0);
            this.Item64_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 190));
            this.Item64_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item64_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 140, 130, 40);
            this.Item64_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 240));
            this.Item64_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item64_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Item64_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Item64_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item64_SeriesLabels.ValueTypeSeparator = "-";
            this.Item64_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Moccasin);
            this.Item64_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart35_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart35_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart35_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart35_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Moccasin);
            this.Chart35_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart35.Style = new Stimulsoft.Report.Chart.StiStyle12();
            this.Chart35.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 105, 78, 31)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text36
            // 
            this.Text36 = new Stimulsoft.Report.Components.StiText();
            this.Text36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 15.6, 6.6, 0.6);
            this.Text36.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text36.Name = "Text36";
            this.Text36.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text36__GetValue);
            this.Text36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text36.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text36.Guid = null;
            this.Text36.Indicator = null;
            this.Text36.Interaction = null;
            this.Text36.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text36.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text36.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart36
            // 
            this.Chart36 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 16.2, 6.6, 5.4);
            this.Chart36.CustomStyleName = "";
            this.Chart36.Name = "Chart36";
            this.Chart36.Sort = new System.String[0];
            this.Chart36_Area = new Stimulsoft.Report.Chart.StiAreaArea();
            this.Chart36_Area.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 223), System.Drawing.Color.FromArgb(255, 255, 232, 183), 90);
            this.Chart36_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart36_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart36_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart36_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 125, 92, 43)), false, true);
            this.Chart36_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 125, 92, 43)), false, true);
            this.Chart36_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 75, 42, 0), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart36_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 75, 42, 0), 1F, false, true, false, true);
            this.Chart36_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 75, 42, 0), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart36_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 75, 42, 0), 1F, false, true, true);
            this.Chart36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 243));
            this.Chart36.Guid = null;
            this.Chart36.Interaction = null;
            this.Chart36_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart36_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart36_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 223), System.Drawing.Color.FromArgb(255, 245, 212, 163), 90);
            this.Chart36_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart36_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart36.MasterComponent = null;
            // 
            // Item67
            // 
            this.Item67 = new Stimulsoft.Report.Chart.StiAreaSeries();
            this.Item67.LineColor = System.Drawing.Color.FromArgb(255, 204, 77, 92);
            this.Item67.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item67__GetListOfArguments);
            this.Item67.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item67__GetListOfValues);
            this.Item67.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item67__GetTitle);
            this.Item67.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 204, 77, 92));
            this.Item67.DrillDownPageGuid = null;
            this.Item67_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item67_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 54, 0, 0);
            this.Item67_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 254, 127, 142));
            this.Item67_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item67_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 104, 0, 0);
            this.Item67_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 177, 192));
            this.Item67_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item67_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Item67_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Item67_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item67_SeriesLabels.ValueTypeSeparator = "-";
            this.Item67_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 225, 192, 143));
            this.Item67_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item68
            // 
            this.Item68 = new Stimulsoft.Report.Chart.StiAreaSeries();
            this.Item68.LineColor = System.Drawing.Color.FromArgb(255, 255, 111, 97);
            this.Item68.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item68__GetListOfArguments);
            this.Item68.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item68__GetListOfValues);
            this.Item68.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item68__GetTitle);
            this.Item68.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(200, 255, 111, 97));
            this.Item68.DrillDownPageGuid = null;
            this.Item68_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item68_LineMarker.BorderColor = System.Drawing.Color.FromArgb(255, 105, 0, 0);
            this.Item68_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 161, 147));
            this.Item68_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item68_Marker.BorderColor = System.Drawing.Color.FromArgb(255, 155, 11, 0);
            this.Item68_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 211, 197));
            this.Item68_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item68_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Item68_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Item68_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item68_SeriesLabels.ValueTypeSeparator = "-";
            this.Item68_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 225, 192, 143));
            this.Item68_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart36_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart36_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart36_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart36_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 225, 192, 143));
            this.Chart36_SeriesLabels.Font = new System.Drawing.Font("Arial", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Chart36.Style = new Stimulsoft.Report.Chart.StiStyle11();
            this.Chart36.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 75, 42, 0)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text37
            // 
            this.Text37 = new Stimulsoft.Report.Components.StiText();
            this.Text37.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 22, 6.2, 0.6);
            this.Text37.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text37.Name = "Text37";
            this.Text37.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text37__GetValue);
            this.Text37.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text37.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text37.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text37.Guid = null;
            this.Text37.Indicator = null;
            this.Text37.Interaction = null;
            this.Text37.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text37.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text37.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart37
            // 
            this.Chart37 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart37.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 22.6, 6.2, 5);
            this.Chart37.CountData = 10;
            this.Chart37.CustomStyleName = "";
            this.Chart37.FilterOn = false;
            this.Chart37.Name = "Chart37";
            this.Chart37.Sort = new System.String[0];
            this.Chart37_Area = new Stimulsoft.Report.Chart.StiDoughnutArea();
            this.Chart37_Area.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 241), 90);
            this.Chart37.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart37.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart37.Guid = null;
            this.Chart37.Interaction = null;
            this.Chart37_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart37_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_Legend.Columns = 8;
            this.Chart37_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.LeftOutside;
            this.Chart37_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart37_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 221), 90);
            this.Chart37_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart37_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart37.MasterComponent = null;
            // 
            // Item71
            // 
            this.Item71 = new Stimulsoft.Report.Chart.StiDoughnutSeries();
            this.Item71.BorderColor = System.Drawing.Color.FromArgb(255, 140, 62, 0);
            this.Item71.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item71__GetListOfArguments);
            this.Item71.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item71__GetListOfValues);
            this.Item71.ShowShadow = false;
            this.Item71.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item71__GetTitle);
            this.Item71.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 240, 162, 46), System.Drawing.Color.FromArgb(255, 190, 112, 0), 0);
            this.Item71.DrillDownPageGuid = null;
            this.Item71_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item71_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Item71_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Item71_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item71_SeriesLabels.ValueTypeSeparator = "-";
            this.Item71_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 251, 238, 201));
            this.Item71_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item72
            // 
            this.Item72 = new Stimulsoft.Report.Chart.StiDoughnutSeries();
            this.Item72.BorderColor = System.Drawing.Color.FromArgb(255, 65, 0, 0);
            this.Item72.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item72__GetListOfArguments);
            this.Item72.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item72__GetListOfValues);
            this.Item72.ShowShadow = false;
            this.Item72.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item72__GetTitle);
            this.Item72.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 165, 100, 78), System.Drawing.Color.FromArgb(255, 115, 50, 28), 0);
            this.Item72.DrillDownPageGuid = null;
            this.Item72_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item72_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Item72_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Item72_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item72_SeriesLabels.ValueTypeSeparator = "-";
            this.Item72_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 251, 238, 201));
            this.Item72_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart37_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterPieLabels();
            this.Chart37_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart37_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart37_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 251, 238, 201));
            this.Chart37_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart37.Style = new Stimulsoft.Report.Chart.StiStyle14();
            this.Chart37.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 101, 88, 51)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text38
            // 
            this.Text38 = new Stimulsoft.Report.Components.StiText();
            this.Text38.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 22, 6.2, 0.6);
            this.Text38.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text38.Name = "Text38";
            this.Text38.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text38__GetValue);
            this.Text38.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text38.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text38.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text38.Guid = null;
            this.Text38.Indicator = null;
            this.Text38.Interaction = null;
            this.Text38.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text38.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text38.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart38
            // 
            this.Chart38 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart38.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 22.6, 6.2, 5);
            this.Chart38.CustomStyleName = "";
            this.Chart38.Name = "Chart38";
            this.Chart38.Sort = new System.String[0];
            this.Chart38_Area = new Stimulsoft.Report.Chart.StiPieArea();
            this.Chart38_Area.BorderColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 252, 250, 248), 90);
            this.Chart38.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart38.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart38.Guid = null;
            this.Chart38.Interaction = null;
            this.Chart38_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart38_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_Legend.Columns = 5;
            this.Chart38_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.LeftOutside;
            this.Chart38_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart38_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 232, 230, 228), 90);
            this.Chart38_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart38_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart38.MasterComponent = null;
            // 
            // Item75
            // 
            this.Item75 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item75.BorderColor = System.Drawing.Color.FromArgb(255, 51, 58, 68);
            this.Item75.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item75__GetListOfArguments);
            this.Item75.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item75__GetListOfValues);
            this.Item75.ShowShadow = false;
            this.Item75.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item75__GetTitle);
            this.Item75.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 151, 158, 168), System.Drawing.Color.FromArgb(255, 101, 108, 118), 0);
            this.Item75.DrillDownPageGuid = null;
            this.Item75_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item75_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Item75_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Item75_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item75_SeriesLabels.ValueTypeSeparator = "-";
            this.Item75_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 212, 210, 208));
            this.Item75_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart38_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterPieLabels();
            this.Chart38_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart38_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart38_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 212, 210, 208));
            this.Chart38_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart38.Style = new Stimulsoft.Report.Chart.StiStyle13();
            this.Chart38.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 62, 60, 58)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            this.Styles.ExcelSheetValue = null;
            this.Styles.Interaction = null;
            this.Styles.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Styles_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Styles_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Styles_Watermark.Image = null;
            this.Styles_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            // 
            // Page5
            // 
            this.Page5 = new Stimulsoft.Report.Components.StiPage();
            this.Page5.Guid = "4d9587631e1146f394b3b07b72e9d024";
            this.Page5.Name = "Page5";
            this.Page5.PageHeight = 29.7;
            this.Page5.PageWidth = 21;
            this.Page5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Chart32
            // 
            this.Chart32 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.6, 6.2, 4.4);
            this.Chart32.CountData = 7;
            this.Chart32.CustomStyleName = "";
            this.Chart32.FilterOn = false;
            this.Chart32.Name = "Chart32";
            this.Chart32.Sort = new System.String[0];
            this.Chart32_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart32_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart32_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart32_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart32_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart32_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart32_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart32_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart32_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart32_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart32_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart32_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart32.Guid = null;
            this.Chart32.Interaction = null;
            this.Chart32_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart32_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart32_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart32_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart32_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Chart32_Legend.Visible = false;
            this.Chart32_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart32_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart32_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart32.MasterComponent = null;
            // 
            // Item78
            // 
            this.Item78 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item78.BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0);
            this.Item78.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item78__GetListOfArguments);
            this.Item78.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item78__GetListOfValues);
            this.Item78.ShowShadow = false;
            this.Item78.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item78__GetTitle);
            this.Item78.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 144, 67, 3), System.Drawing.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item78.DrillDownPageGuid = null;
            this.Item78_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item78_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item78_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item78_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item78_SeriesLabels.ValueTypeSeparator = "-";
            this.Item78_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item78_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item79
            // 
            this.Item79 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item79.BorderColor = System.Drawing.Color.FromArgb(255, 131, 40, 0);
            this.Item79.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item79__GetListOfArguments);
            this.Item79.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item79__GetListOfValues);
            this.Item79.ShowShadow = false;
            this.Item79.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item79__GetTitle);
            this.Item79.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 181, 90, 15), System.Drawing.Color.FromArgb(255, 231, 140, 65), 0, 0.5F, 1F);
            this.Item79.DrillDownPageGuid = null;
            this.Item79_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item79_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item79_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29);
            this.Item79_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item79_SeriesLabels.ValueTypeSeparator = "-";
            this.Item79_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Item79_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart32_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart32_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart32_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart32.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart32.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text31
            // 
            this.Text31 = new Stimulsoft.Report.Components.StiText();
            this.Text31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.2, 0.6);
            this.Text31.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text31.Name = "Text31";
            this.Text31.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text31__GetValue);
            this.Text31.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text31.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text31.Guid = null;
            this.Text31.Indicator = null;
            this.Text31.Interaction = null;
            this.Text31.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text31.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text31.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text39
            // 
            this.Text39 = new Stimulsoft.Report.Components.StiText();
            this.Text39.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 0, 6.2, 0.6);
            this.Text39.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text39.Name = "Text39";
            this.Text39.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text39__GetValue);
            this.Text39.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text39.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text39.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text39.Guid = null;
            this.Text39.Indicator = null;
            this.Text39.Interaction = null;
            this.Text39.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text39.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text39.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text40
            // 
            this.Text40 = new Stimulsoft.Report.Components.StiText();
            this.Text40.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0, 6.2, 0.6);
            this.Text40.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text40.Name = "Text40";
            this.Text40.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text40__GetValue);
            this.Text40.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text40.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text40.Guid = null;
            this.Text40.Indicator = null;
            this.Text40.Interaction = null;
            this.Text40.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text40.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text40.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text41
            // 
            this.Text41 = new Stimulsoft.Report.Components.StiText();
            this.Text41.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5, 6.2, 0.6);
            this.Text41.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text41.Name = "Text41";
            this.Text41.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text41__GetValue);
            this.Text41.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text41.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text41.Guid = null;
            this.Text41.Indicator = null;
            this.Text41.Interaction = null;
            this.Text41.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text41.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text41.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text42
            // 
            this.Text42 = new Stimulsoft.Report.Components.StiText();
            this.Text42.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 5, 6.2, 0.6);
            this.Text42.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text42.Name = "Text42";
            this.Text42.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text42__GetValue);
            this.Text42.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text42.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text42.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text42.Guid = null;
            this.Text42.Indicator = null;
            this.Text42.Interaction = null;
            this.Text42.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text42.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text42.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text43
            // 
            this.Text43 = new Stimulsoft.Report.Components.StiText();
            this.Text43.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 5, 6.2, 0.6);
            this.Text43.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text43.Name = "Text43";
            this.Text43.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text43__GetValue);
            this.Text43.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text43.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text43.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text43.Guid = null;
            this.Text43.Indicator = null;
            this.Text43.Interaction = null;
            this.Text43.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text43.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text43.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text44
            // 
            this.Text44 = new Stimulsoft.Report.Components.StiText();
            this.Text44.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10, 6.2, 0.6);
            this.Text44.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text44.Name = "Text44";
            this.Text44.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text44__GetValue);
            this.Text44.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text44.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text44.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text44.Guid = null;
            this.Text44.Indicator = null;
            this.Text44.Interaction = null;
            this.Text44.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text44.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text44.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text45
            // 
            this.Text45 = new Stimulsoft.Report.Components.StiText();
            this.Text45.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 10, 6.2, 0.6);
            this.Text45.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text45.Name = "Text45";
            this.Text45.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text45__GetValue);
            this.Text45.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text45.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text45.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text45.Guid = null;
            this.Text45.Indicator = null;
            this.Text45.Interaction = null;
            this.Text45.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text45.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text45.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text46
            // 
            this.Text46 = new Stimulsoft.Report.Components.StiText();
            this.Text46.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 10, 6.2, 0.6);
            this.Text46.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text46.Name = "Text46";
            this.Text46.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text46__GetValue);
            this.Text46.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text46.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text46.Guid = null;
            this.Text46.Indicator = null;
            this.Text46.Interaction = null;
            this.Text46.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text46.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text46.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text47
            // 
            this.Text47 = new Stimulsoft.Report.Components.StiText();
            this.Text47.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 15, 6.2, 0.6);
            this.Text47.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text47.Name = "Text47";
            this.Text47.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text47__GetValue);
            this.Text47.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text47.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text47.Guid = null;
            this.Text47.Indicator = null;
            this.Text47.Interaction = null;
            this.Text47.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text47.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text47.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text48
            // 
            this.Text48 = new Stimulsoft.Report.Components.StiText();
            this.Text48.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 15, 6.2, 0.6);
            this.Text48.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text48.Name = "Text48";
            this.Text48.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text48__GetValue);
            this.Text48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text48.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text48.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text48.Guid = null;
            this.Text48.Indicator = null;
            this.Text48.Interaction = null;
            this.Text48.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text48.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text48.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text49
            // 
            this.Text49 = new Stimulsoft.Report.Components.StiText();
            this.Text49.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 15, 6.2, 0.6);
            this.Text49.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text49.Name = "Text49";
            this.Text49.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text49__GetValue);
            this.Text49.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text49.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text49.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text49.Guid = null;
            this.Text49.Indicator = null;
            this.Text49.Interaction = null;
            this.Text49.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text49.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text49.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text50
            // 
            this.Text50 = new Stimulsoft.Report.Components.StiText();
            this.Text50.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20, 6.2, 0.6);
            this.Text50.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text50.Name = "Text50";
            this.Text50.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text50__GetValue);
            this.Text50.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text50.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text50.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text50.Guid = null;
            this.Text50.Indicator = null;
            this.Text50.Interaction = null;
            this.Text50.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text50.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text50.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text51
            // 
            this.Text51 = new Stimulsoft.Report.Components.StiText();
            this.Text51.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 20, 6.2, 0.6);
            this.Text51.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text51.Name = "Text51";
            this.Text51.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text51__GetValue);
            this.Text51.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text51.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text51.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text51.Guid = null;
            this.Text51.Indicator = null;
            this.Text51.Interaction = null;
            this.Text51.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text51.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text51.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text52
            // 
            this.Text52 = new Stimulsoft.Report.Components.StiText();
            this.Text52.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 20, 6.2, 0.6);
            this.Text52.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text52.Name = "Text52";
            this.Text52.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text52__GetValue);
            this.Text52.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Text52.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text52.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text52.Guid = null;
            this.Text52.Indicator = null;
            this.Text52.Interaction = null;
            this.Text52.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text52.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text52.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart39
            // 
            this.Chart39 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart39.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 0.6, 6.6, 4.4);
            this.Chart39.CountData = 7;
            this.Chart39.CustomStyleName = "";
            this.Chart39.FilterOn = false;
            this.Chart39.Name = "Chart39";
            this.Chart39.Sort = new System.String[0];
            this.Chart39_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart39_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart39_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart39_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart39_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart39_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart39_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 145, 145)), true, true);
            this.Chart39_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 145, 145)), true, true);
            this.Chart39_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart39_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, false, true);
            this.Chart39_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart39_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, true);
            this.Chart39.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart39.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart39.Guid = null;
            this.Chart39.Interaction = null;
            this.Chart39_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart39_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart39_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart39_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart39_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart39_Legend.Visible = false;
            this.Chart39_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart39_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart39_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart39.MasterComponent = null;
            // 
            // Item96
            // 
            this.Item96 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item96.BorderColor = System.Drawing.Color.FromArgb(255, 28, 45, 65);
            this.Item96.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item96__GetListOfArguments);
            this.Item96.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item96__GetListOfValues);
            this.Item96.ShowShadow = false;
            this.Item96.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item96__GetTitle);
            this.Item96.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 128, 145, 165), System.Drawing.Color.FromArgb(255, 178, 195, 215), 0, 0.5F, 1F);
            this.Item96.DrillDownPageGuid = null;
            this.Item96_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item96_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item96_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item96_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item96_SeriesLabels.ValueTypeSeparator = "-";
            this.Item96_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Item96_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item97
            // 
            this.Item97 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item97.BorderColor = System.Drawing.Color.FromArgb(255, 71, 23, 22);
            this.Item97.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item97__GetListOfArguments);
            this.Item97.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item97__GetListOfValues);
            this.Item97.ShowShadow = false;
            this.Item97.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item97__GetTitle);
            this.Item97.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Drawing.Color.FromArgb(255, 171, 123, 122), System.Drawing.Color.FromArgb(255, 221, 173, 172), 0, 0.5F, 1F);
            this.Item97.DrillDownPageGuid = null;
            this.Item97_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item97_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item97_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item97_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item97_SeriesLabels.ValueTypeSeparator = "-";
            this.Item97_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Item97_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart39_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart39_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart39_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart39.Style = new Stimulsoft.Report.Chart.StiStyle02();
            this.Chart39.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 95, 95)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart40
            // 
            this.Chart40 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart40.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0.6, 6.2, 4.4);
            this.Chart40.CountData = 7;
            this.Chart40.CustomStyleName = "";
            this.Chart40.FilterOn = false;
            this.Chart40.Name = "Chart40";
            this.Chart40.Sort = new System.String[0];
            this.Chart40_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart40_Area.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart40_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart40_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart40_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart40_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart40_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 145, 145)), true, true);
            this.Chart40_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 145, 145, 145)), true, true);
            this.Chart40_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart40_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, false, true);
            this.Chart40_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart40_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 95, 95), 1F, false, true, true);
            this.Chart40.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart40.Guid = null;
            this.Chart40.Interaction = null;
            this.Chart40_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart40_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart40_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart40_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart40_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Chart40_Legend.Visible = false;
            this.Chart40_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart40_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart40_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart40.MasterComponent = null;
            // 
            // Item99
            // 
            this.Item99 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item99.BorderColor = System.Drawing.Color.FromArgb(255, 50, 0, 0);
            this.Item99.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item99__GetListOfArguments);
            this.Item99.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item99__GetListOfValues);
            this.Item99.ShowShadow = false;
            this.Item99.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item99__GetTitle);
            this.Item99.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 150, 61, 59));
            this.Item99.DrillDownPageGuid = null;
            this.Item99_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item99_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item99_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item99_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item99_SeriesLabels.ValueTypeSeparator = "-";
            this.Item99_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Item99_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item100
            // 
            this.Item100 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item100.BorderColor = System.Drawing.Color.FromArgb(255, 79, 0, 0);
            this.Item100.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item100__GetListOfArguments);
            this.Item100.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item100__GetListOfValues);
            this.Item100.ShowShadow = false;
            this.Item100.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item100__GetTitle);
            this.Item100.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 179, 74, 71));
            this.Item100.DrillDownPageGuid = null;
            this.Item100_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item100_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item100_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 95, 95, 95);
            this.Item100_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item100_SeriesLabels.ValueTypeSeparator = "-";
            this.Item100_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.WhiteSmoke);
            this.Item100_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart40_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart40_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart40_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart40.Style = new Stimulsoft.Report.Chart.StiStyle03();
            this.Chart40.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 95, 95, 95)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart41
            // 
            this.Chart41 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart41.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5.6, 6.2, 4.4);
            this.Chart41.CountData = 7;
            this.Chart41.CustomStyleName = "";
            this.Chart41.FilterOn = false;
            this.Chart41.Name = "Chart41";
            this.Chart41.Sort = new System.String[0];
            this.Chart41_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart41_Area.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart41_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 246, 255), System.Drawing.Color.FromArgb(255, 221, 206, 240), 90);
            this.Chart41_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart41_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart41_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart41_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 81, 66, 100)), true, true);
            this.Chart41_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 81, 66, 100)), true, true);
            this.Chart41_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 31, 16, 50), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart41_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 31, 16, 50), 1F, false, true, false, true);
            this.Chart41_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 31, 16, 50), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart41_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 31, 16, 50), 1F, false, true, true);
            this.Chart41.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart41.Guid = null;
            this.Chart41.Interaction = null;
            this.Chart41_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart41_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart41_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart41_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.InitializeComponent3();
        }
        
        public void InitializeComponent3()
        {
            this.Chart41_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Chart41_Legend.Visible = false;
            this.Chart41_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 246, 255), System.Drawing.Color.FromArgb(255, 201, 186, 220), 90);
            this.Chart41_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart41_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart41.MasterComponent = null;
            // 
            // Item102
            // 
            this.Item102 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item102.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            this.Item102.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item102__GetListOfArguments);
            this.Item102.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item102__GetListOfValues);
            this.Item102.ShowShadow = false;
            this.Item102.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item102__GetTitle);
            this.Item102.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 72, 57, 90), System.Drawing.Color.FromArgb(255, 22, 7, 40), 0);
            this.Item102.DrillDownPageGuid = null;
            this.Item102_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item102_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Item102_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Item102_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item102_SeriesLabels.ValueTypeSeparator = "-";
            this.Item102_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 181, 166, 200));
            this.Item102_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item103
            // 
            this.Item103 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item103.BorderColor = System.Drawing.Color.FromArgb(255, 9, 0, 37);
            this.Item103.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item103__GetListOfArguments);
            this.Item103.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item103__GetListOfValues);
            this.Item103.ShowShadow = false;
            this.Item103.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item103__GetTitle);
            this.Item103.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 109, 87, 137), System.Drawing.Color.FromArgb(255, 59, 37, 87), 0);
            this.Item103.DrillDownPageGuid = null;
            this.Item103_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item103_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Item103_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 31, 16, 50);
            this.Item103_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item103_SeriesLabels.ValueTypeSeparator = "-";
            this.Item103_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 181, 166, 200));
            this.Item103_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart41_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart41_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart41_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart41.Style = new Stimulsoft.Report.Chart.StiStyle04();
            this.Chart41.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 31, 16, 50)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart42
            // 
            this.Chart42 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart42.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 5.6, 6.6, 4.4);
            this.Chart42.CountData = 7;
            this.Chart42.CustomStyleName = "";
            this.Chart42.FilterOn = false;
            this.Chart42.Name = "Chart42";
            this.Chart42.Sort = new System.String[0];
            this.Chart42_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart42_Area.BorderColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart42_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 245), 90);
            this.Chart42_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart42_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart42_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart42_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 150, 105)), true, true);
            this.Chart42_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 150, 105)), true, true);
            this.Chart42_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 100, 55), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart42_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 100, 55), 1F, false, true, false, true);
            this.Chart42_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 100, 55), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart42_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 100, 55), 1F, false, true, true);
            this.Chart42.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart42.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart42.Guid = null;
            this.Chart42.Interaction = null;
            this.Chart42_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart42_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart42_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart42_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart42_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Chart42_Legend.Visible = false;
            this.Chart42_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 225), 90);
            this.Chart42_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart42_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart42.MasterComponent = null;
            // 
            // Item105
            // 
            this.Item105 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item105.BorderColor = System.Drawing.Color.FromArgb(255, 124, 69, 0);
            this.Item105.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item105__GetListOfArguments);
            this.Item105.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item105__GetListOfValues);
            this.Item105.ShowShadow = false;
            this.Item105.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item105__GetTitle);
            this.Item105.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 224, 169, 61), System.Drawing.Color.FromArgb(255, 174, 119, 11), 0);
            this.Item105.DrillDownPageGuid = null;
            this.Item105_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item105_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Item105_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Item105_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item105_SeriesLabels.ValueTypeSeparator = "-";
            this.Item105_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.LemonChiffon);
            this.Item105_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item106
            // 
            this.Item106 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item106.BorderColor = System.Drawing.Color.FromArgb(255, 80, 81, 0);
            this.Item106.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item106__GetListOfArguments);
            this.Item106.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item106__GetListOfValues);
            this.Item106.ShowShadow = false;
            this.Item106.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item106__GetTitle);
            this.Item106.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 180, 181, 0), System.Drawing.Color.FromArgb(255, 130, 131, 0), 0);
            this.Item106.DrillDownPageGuid = null;
            this.Item106_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item106_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Item106_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 100, 55);
            this.Item106_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item106_SeriesLabels.ValueTypeSeparator = "-";
            this.Item106_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.LemonChiffon);
            this.Item106_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart42_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart42_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart42_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart42.Style = new Stimulsoft.Report.Chart.StiStyle05();
            this.Chart42.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 105, 100, 55)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart43
            // 
            this.Chart43 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart43.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 5.6, 6.2, 4.4);
            this.Chart43.CountData = 7;
            this.Chart43.CustomStyleName = "";
            this.Chart43.FilterOn = false;
            this.Chart43.Name = "Chart43";
            this.Chart43.Sort = new System.String[0];
            this.Chart43_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart43_Area.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart43_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 242, 238, 246), 90);
            this.Chart43_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart43_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart43_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart43_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 102, 98, 106)), true, true);
            this.Chart43_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 102, 98, 106)), true, true);
            this.Chart43_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 52, 48, 56), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart43_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 52, 48, 56), 1F, false, true, false, true);
            this.Chart43_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 52, 48, 56), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart43_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 52, 48, 56), 1F, false, true, true);
            this.Chart43.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart43.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart43.Guid = null;
            this.Chart43.Interaction = null;
            this.Chart43_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart43_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart43_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart43_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart43_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Chart43_Legend.Visible = false;
            this.Chart43_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 222, 218, 226), 90);
            this.Chart43_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart43_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart43.MasterComponent = null;
            // 
            // Item108
            // 
            this.Item108 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item108.BorderColor = System.Drawing.Color.FromArgb(255, 106, 85, 2);
            this.Item108.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item108__GetListOfArguments);
            this.Item108.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item108__GetListOfValues);
            this.Item108.ShowShadow = false;
            this.Item108.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item108__GetTitle);
            this.Item108.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 206, 185, 102));
            this.Item108.DrillDownPageGuid = null;
            this.Item108_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item108_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Item108_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Item108_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item108_SeriesLabels.ValueTypeSeparator = "-";
            this.Item108_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 202, 198, 206));
            this.Item108_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item109
            // 
            this.Item109 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item109.BorderColor = System.Drawing.Color.FromArgb(255, 56, 76, 32);
            this.Item109.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item109__GetListOfArguments);
            this.Item109.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item109__GetListOfValues);
            this.Item109.ShowShadow = false;
            this.Item109.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item109__GetTitle);
            this.Item109.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 156, 176, 132));
            this.Item109.DrillDownPageGuid = null;
            this.Item109_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item109_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Item109_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 52, 48, 56);
            this.Item109_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item109_SeriesLabels.ValueTypeSeparator = "-";
            this.Item109_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 202, 198, 206));
            this.Item109_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart43_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart43_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart43_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart43.Style = new Stimulsoft.Report.Chart.StiStyle06();
            this.Chart43.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 52, 48, 56)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart44
            // 
            this.Chart44 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart44.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.6, 6.2, 4.4);
            this.Chart44.CountData = 7;
            this.Chart44.CustomStyleName = "";
            this.Chart44.FilterOn = false;
            this.Chart44.Name = "Chart44";
            this.Chart44.Sort = new System.String[0];
            this.Chart44_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart44_Area.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart44_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart44_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart44_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart44_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart44_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 155, 155)), true, true);
            this.Chart44_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 155, 155)), true, true);
            this.Chart44_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 105, 105), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart44_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 105, 105), 1F, false, true, false, true);
            this.Chart44_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 105, 105), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart44_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 105, 105), 1F, false, true, true);
            this.Chart44.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart44.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart44.Guid = null;
            this.Chart44.Interaction = null;
            this.Chart44_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart44_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart44_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart44_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart44_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Chart44_Legend.Visible = false;
            this.Chart44_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart44_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart44_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart44.MasterComponent = null;
            // 
            // Item111
            // 
            this.Item111 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item111.BorderColor = System.Drawing.Color.FromArgb(255, 117, 151, 68);
            this.Item111.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item111__GetListOfArguments);
            this.Item111.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item111__GetListOfValues);
            this.Item111.ShowShadow = false;
            this.Item111.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item111__GetTitle);
            this.Item111.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 167, 201, 118), System.Drawing.Color.FromArgb(255, 255, 255, 218), -90);
            this.Item111.DrillDownPageGuid = null;
            this.Item111_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item111_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Item111_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Item111_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item111_SeriesLabels.ValueTypeSeparator = "-";
            this.Item111_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Item111_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item112
            // 
            this.Item112 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item112.BorderColor = System.Drawing.Color.FromArgb(255, 100, 81, 131);
            this.Item112.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item112__GetListOfArguments);
            this.Item112.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item112__GetListOfValues);
            this.Item112.ShowShadow = false;
            this.Item112.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item112__GetTitle);
            this.Item112.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 150, 131, 181), System.Drawing.Color.FromArgb(255, 250, 231, 255), -90);
            this.Item112.DrillDownPageGuid = null;
            this.Item112_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item112_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Item112_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 105, 105);
            this.Item112_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item112_SeriesLabels.ValueTypeSeparator = "-";
            this.Item112_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Item112_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart44_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart44_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart44_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart44.Style = new Stimulsoft.Report.Chart.StiStyle07();
            this.Chart44.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 105, 105, 105)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart45
            // 
            this.Chart45 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart45.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 10.6, 6.6, 4.4);
            this.Chart45.CountData = 7;
            this.Chart45.CustomStyleName = "";
            this.Chart45.FilterOn = false;
            this.Chart45.Name = "Chart45";
            this.Chart45.Sort = new System.String[0];
            this.Chart45_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart45_Area.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart45_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 222, 235, 255), 90);
            this.Chart45_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart45_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart45_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart45_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 82, 95, 120)), true, true);
            this.Chart45_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 82, 95, 120)), true, true);
            this.Chart45_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 32, 45, 70), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart45_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 32, 45, 70), 1F, false, true, false, true);
            this.Chart45_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 32, 45, 70), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart45_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 32, 45, 70), 1F, false, true, true);
            this.Chart45.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart45.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart45.Guid = null;
            this.Chart45.Interaction = null;
            this.Chart45_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart45_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart45_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart45_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart45_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Chart45_Legend.Visible = false;
            this.Chart45_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 202, 215, 240), 90);
            this.Chart45_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart45_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart45.MasterComponent = null;
            // 
            // Item114
            // 
            this.Item114 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item114.BorderColor = System.Drawing.Color.FromArgb(255, 0, 0, 48);
            this.Item114.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item114__GetListOfArguments);
            this.Item114.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item114__GetListOfValues);
            this.Item114.ShowShadow = false;
            this.Item114.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item114__GetTitle);
            this.Item114.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 60, 100, 148));
            this.Item114.DrillDownPageGuid = null;
            this.Item114_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item114_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Item114_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Item114_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item114_SeriesLabels.ValueTypeSeparator = "-";
            this.Item114_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 182, 195, 220));
            this.Item114_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item115
            // 
            this.Item115 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item115.BorderColor = System.Drawing.Color.FromArgb(255, 0, 20, 77);
            this.Item115.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item115__GetListOfArguments);
            this.Item115.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item115__GetListOfValues);
            this.Item115.ShowShadow = false;
            this.Item115.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item115__GetTitle);
            this.Item115.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 73, 120, 177));
            this.Item115.DrillDownPageGuid = null;
            this.Item115_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item115_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Item115_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 32, 45, 70);
            this.Item115_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item115_SeriesLabels.ValueTypeSeparator = "-";
            this.Item115_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 182, 195, 220));
            this.Item115_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart45_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart45_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart45_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart45.Style = new Stimulsoft.Report.Chart.StiStyle08();
            this.Chart45.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 32, 45, 70)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart46
            // 
            this.Chart46 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart46.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 10.6, 6.2, 4.4);
            this.Chart46.CountData = 7;
            this.Chart46.CustomStyleName = "";
            this.Chart46.FilterOn = false;
            this.Chart46.Name = "Chart46";
            this.Chart46.Sort = new System.String[0];
            this.Chart46_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart46_Area.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart46_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart46_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart46_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart46_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart46_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 138, 136, 125)), true, true);
            this.Chart46_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 138, 136, 125)), true, true);
            this.Chart46_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 88, 86, 75), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart46_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 88, 86, 75), 1F, false, true, false, true);
            this.Chart46_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 88, 86, 75), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart46_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 88, 86, 75), 1F, false, true, true);
            this.Chart46.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart46.Guid = null;
            this.Chart46.Interaction = null;
            this.Chart46_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart46_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart46_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart46_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart46_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Chart46_Legend.Visible = false;
            this.Chart46_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 245), 90);
            this.Chart46_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart46_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart46.MasterComponent = null;
            // 
            // Item117
            // 
            this.Item117 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item117.BorderColor = System.Drawing.Color.FromArgb(255, 0, 29, 89);
            this.Item117.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item117__GetListOfArguments);
            this.Item117.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item117__GetListOfValues);
            this.Item117.ShowShadow = false;
            this.Item117.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item117__GetTitle);
            this.Item117.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 79, 129, 189), System.Drawing.Color.FromArgb(255, 29, 79, 139), 0);
            this.Item117.DrillDownPageGuid = null;
            this.Item117_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item117_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Item117_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Item117_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item117_SeriesLabels.ValueTypeSeparator = "-";
            this.Item117_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 238, 236, 225));
            this.Item117_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item118
            // 
            this.Item118 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item118.BorderColor = System.Drawing.Color.FromArgb(255, 92, 0, 0);
            this.Item118.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item118__GetListOfArguments);
            this.Item118.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item118__GetListOfValues);
            this.Item118.ShowShadow = false;
            this.Item118.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item118__GetTitle);
            this.Item118.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 192, 80, 77), System.Drawing.Color.FromArgb(255, 142, 30, 27), 0);
            this.Item118.DrillDownPageGuid = null;
            this.Item118_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item118_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Item118_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 88, 86, 75);
            this.Item118_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item118_SeriesLabels.ValueTypeSeparator = "-";
            this.Item118_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(238, 238, 236, 225));
            this.Item118_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart46_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart46_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart46_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart46.Style = new Stimulsoft.Report.Chart.StiStyle09();
            this.Chart46.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 88, 86, 75)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart47
            // 
            this.Chart47 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart47.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 15.6, 6.2, 4.4);
            this.Chart47.CountData = 7;
            this.Chart47.CustomStyleName = "";
            this.Chart47.FilterOn = false;
            this.Chart47.Name = "Chart47";
            this.Chart47.Sort = new System.String[0];
            this.Chart47_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart47_Area.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart47_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 249, 255, 255), 90);
            this.Chart47_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart47_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart47_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart47_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 109, 125, 127)), true, true);
            this.Chart47_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 109, 125, 127)), true, true);
            this.Chart47_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 59, 75, 77), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart47_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 59, 75, 77), 1F, false, true, false, true);
            this.Chart47_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 59, 75, 77), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart47_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 59, 75, 77), 1F, false, true, true);
            this.Chart47.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart47.Guid = null;
            this.Chart47.Interaction = null;
            this.Chart47_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart47_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart47_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart47_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart47_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Chart47_Legend.Visible = false;
            this.Chart47_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 229, 245, 247), 90);
            this.Chart47_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart47_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart47.MasterComponent = null;
            // 
            // Item120
            // 
            this.Item120 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item120.BorderColor = System.Drawing.Color.FromArgb(255, 21, 81, 76);
            this.Item120.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item120__GetListOfArguments);
            this.Item120.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item120__GetListOfValues);
            this.Item120.ShowShadow = false;
            this.Item120.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item120__GetTitle);
            this.Item120.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 121, 181, 176), System.Drawing.Color.FromArgb(255, 71, 131, 126), 0);
            this.Item120.DrillDownPageGuid = null;
            this.Item120_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item120_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Item120_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Item120_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item120_SeriesLabels.ValueTypeSeparator = "-";
            this.Item120_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 209, 225, 227));
            this.Item120_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item121
            // 
            this.Item121 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item121.BorderColor = System.Drawing.Color.FromArgb(255, 80, 88, 0);
            this.Item121.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item121__GetListOfArguments);
            this.Item121.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item121__GetListOfValues);
            this.Item121.ShowShadow = false;
            this.Item121.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item121__GetTitle);
            this.Item121.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 180, 188, 76), System.Drawing.Color.FromArgb(255, 130, 138, 26), 0);
            this.Item121.DrillDownPageGuid = null;
            this.Item121_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item121_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Item121_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 59, 75, 77);
            this.Item121_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item121_SeriesLabels.ValueTypeSeparator = "-";
            this.Item121_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 209, 225, 227));
            this.Item121_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart47_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart47_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart47_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart47.Style = new Stimulsoft.Report.Chart.StiStyle10();
            this.Chart47.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 59, 75, 77)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart48
            // 
            this.Chart48 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart48.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 15.6, 6.6, 4.4);
            this.Chart48.CountData = 7;
            this.Chart48.CustomStyleName = "";
            this.Chart48.FilterOn = false;
            this.Chart48.Name = "Chart48";
            this.Chart48.Sort = new System.String[0];
            this.Chart48_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart48_Area.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart48_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 223), System.Drawing.Color.FromArgb(255, 255, 232, 183), 90);
            this.Chart48_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart48_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart48_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart48_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 125, 92, 43)), true, true);
            this.Chart48_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 125, 92, 43)), true, true);
            this.Chart48_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 75, 42, 0), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart48_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 75, 42, 0), 1F, false, true, false, true);
            this.Chart48_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 75, 42, 0), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart48_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 75, 42, 0), 1F, false, true, true);
            this.Chart48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart48.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 243));
            this.Chart48.Guid = null;
            this.Chart48.Interaction = null;
            this.Chart48_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart48_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart48_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart48_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart48_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Chart48_Legend.Visible = false;
            this.Chart48_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 223), System.Drawing.Color.FromArgb(255, 245, 212, 163), 90);
            this.Chart48_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart48_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart48.MasterComponent = null;
            // 
            // Item123
            // 
            this.Item123 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item123.BorderColor = System.Drawing.Color.FromArgb(255, 104, 0, 0);
            this.Item123.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item123__GetListOfArguments);
            this.Item123.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item123__GetListOfValues);
            this.Item123.ShowShadow = false;
            this.Item123.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item123__GetTitle);
            this.Item123.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 204, 77, 92), System.Drawing.Color.FromArgb(255, 154, 27, 42), 0);
            this.Item123.DrillDownPageGuid = null;
            this.Item123_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item123_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Item123_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Item123_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item123_SeriesLabels.ValueTypeSeparator = "-";
            this.Item123_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 225, 192, 143));
            this.Item123_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item124
            // 
            this.Item124 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item124.BorderColor = System.Drawing.Color.FromArgb(255, 155, 11, 0);
            this.Item124.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item124__GetListOfArguments);
            this.Item124.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item124__GetListOfValues);
            this.Item124.ShowShadow = false;
            this.Item124.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item124__GetTitle);
            this.Item124.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 111, 97), System.Drawing.Color.FromArgb(255, 205, 61, 47), 0);
            this.Item124.DrillDownPageGuid = null;
            this.Item124_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item124_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Item124_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 75, 42, 0);
            this.Item124_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item124_SeriesLabels.ValueTypeSeparator = "-";
            this.Item124_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 225, 192, 143));
            this.Item124_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart48_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart48_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart48_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart48.Style = new Stimulsoft.Report.Chart.StiStyle11();
            this.Chart48.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 75, 42, 0)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart49
            // 
            this.Chart49 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart49.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 15.6, 6.2, 4.4);
            this.Chart49.CountData = 7;
            this.Chart49.CustomStyleName = "";
            this.Chart49.FilterOn = false;
            this.Chart49.Name = "Chart49";
            this.Chart49.Sort = new System.String[0];
            this.Chart49_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart49_Area.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart49_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 221), 90);
            this.Chart49_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart49_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart49_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart49_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 128, 81)), true, true);
            this.Chart49_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 155, 128, 81)), true, true);
            this.Chart49_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 78, 31), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart49_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 78, 31), 1F, false, true, false, true);
            this.Chart49_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 78, 31), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart49_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 105, 78, 31), 1F, false, true, true);
            this.Chart49.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart49.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart49.Guid = null;
            this.Chart49.Interaction = null;
            this.Chart49_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart49_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart49_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart49_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart49_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Chart49_Legend.Visible = false;
            this.Chart49_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 248, 201), 90);
            this.Chart49_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart49_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart49.MasterComponent = null;
            // 
            // Item126
            // 
            this.Item126 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item126.BorderColor = System.Drawing.Color.FromArgb(255, 118, 65, 0);
            this.Item126.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item126__GetListOfArguments);
            this.Item126.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item126__GetListOfValues);
            this.Item126.ShowShadow = false;
            this.Item126.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item126__GetTitle);
            this.Item126.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.Goldenrod, System.Drawing.Color.FromArgb(255, 168, 115, 0), 0);
            this.Item126.DrillDownPageGuid = null;
            this.Item126_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item126_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Item126_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Item126_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item126_SeriesLabels.ValueTypeSeparator = "-";
            this.Item126_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Moccasin);
            this.Item126_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item127
            // 
            this.Item127 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item127.BorderColor = System.Drawing.Color.FromArgb(255, 140, 130, 40);
            this.Item127.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item127__GetListOfArguments);
            this.Item127.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item127__GetListOfValues);
            this.Item127.ShowShadow = false;
            this.Item127.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item127__GetTitle);
            this.Item127.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.Khaki, System.Drawing.Color.FromArgb(255, 190, 180, 90), 0);
            this.Item127.DrillDownPageGuid = null;
            this.Item127_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item127_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Item127_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 105, 78, 31);
            this.Item127_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item127_SeriesLabels.ValueTypeSeparator = "-";
            this.Item127_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Moccasin);
            this.Item127_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart49_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart49_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart49_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart49.Style = new Stimulsoft.Report.Chart.StiStyle12();
            this.Chart49.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 105, 78, 31)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart50
            // 
            this.Chart50 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart50.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20.6, 6.2, 4.4);
            this.Chart50.CountData = 7;
            this.Chart50.CustomStyleName = "";
            this.Chart50.FilterOn = false;
            this.Chart50.Name = "Chart50";
            this.Chart50.Sort = new System.String[0];
            this.Chart50_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart50_Area.BorderColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart50_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 252, 250, 248), 90);
            this.Chart50_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 62, 60, 58), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 62, 60, 58), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart50_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart50_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 62, 60, 58), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 62, 60, 58), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart50_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 112, 110, 108)), true, true);
            this.Chart50_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 112, 110, 108)), true, true);
            this.Chart50_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 62, 60, 58), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 62, 60, 58), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 62, 60, 58), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart50_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 62, 60, 58), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 62, 60, 58), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 62, 60, 58), 1F, false, true, false, true);
            this.Chart50_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 62, 60, 58), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 62, 60, 58), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 62, 60, 58), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart50_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 62, 60, 58), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 62, 60, 58), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 62, 60, 58), 1F, false, true, true);
            this.Chart50.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart50.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart50.Guid = null;
            this.Chart50.Interaction = null;
            this.Chart50_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart50_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart50_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart50_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart50_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Chart50_Legend.Visible = false;
            this.Chart50_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 232, 230, 228), 90);
            this.Chart50_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart50_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart50.MasterComponent = null;
            // 
            // Item129
            // 
            this.Item129 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item129.BorderColor = System.Drawing.Color.FromArgb(255, 51, 58, 68);
            this.Item129.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item129__GetListOfArguments);
            this.Item129.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item129__GetListOfValues);
            this.Item129.ShowShadow = false;
            this.Item129.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item129__GetTitle);
            this.Item129.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 151, 158, 168), System.Drawing.Color.FromArgb(255, 101, 108, 118), 0);
            this.Item129.DrillDownPageGuid = null;
            this.Item129_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item129_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Item129_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Item129_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item129_SeriesLabels.ValueTypeSeparator = "-";
            this.Item129_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 212, 210, 208));
            this.Item129_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item130
            // 
            this.Item130 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item130.BorderColor = System.Drawing.Color.FromArgb(255, 89, 74, 37);
            this.Item130.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item130__GetListOfArguments);
            this.Item130.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item130__GetListOfValues);
            this.Item130.ShowShadow = false;
            this.Item130.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item130__GetTitle);
            this.Item130.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 189, 174, 137), System.Drawing.Color.FromArgb(255, 139, 124, 87), 0);
            this.Item130.DrillDownPageGuid = null;
            this.Item130_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item130_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Item130_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 62, 60, 58);
            this.Item130_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item130_SeriesLabels.ValueTypeSeparator = "-";
            this.Item130_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 212, 210, 208));
            this.Item130_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart50_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart50_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart50_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart50.Style = new Stimulsoft.Report.Chart.StiStyle13();
            this.Chart50.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 62, 60, 58)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart51
            // 
            this.Chart51 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart51.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 20.6, 6.6, 4.4);
            this.Chart51.CountData = 7;
            this.Chart51.CustomStyleName = "";
            this.Chart51.FilterOn = false;
            this.Chart51.Name = "Chart51";
            this.Chart51.Sort = new System.String[0];
            this.Chart51_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart51_Area.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart51_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 241), 90);
            this.Chart51_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 101, 88, 51), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 101, 88, 51), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart51_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart51_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 101, 88, 51), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 101, 88, 51), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart51_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 151, 138, 101)), true, true);
            this.Chart51_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 151, 138, 101)), true, true);
            this.Chart51_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 101, 88, 51), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 101, 88, 51), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 101, 88, 51), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart51_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 101, 88, 51), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 101, 88, 51), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 101, 88, 51), 1F, false, true, false, true);
            this.Chart51_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 101, 88, 51), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 101, 88, 51), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 101, 88, 51), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart51_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 101, 88, 51), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 101, 88, 51), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 101, 88, 51), 1F, false, true, true);
            this.Chart51.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart51.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart51.Guid = null;
            this.Chart51.Interaction = null;
            this.Chart51_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart51_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart51_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart51_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart51_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Chart51_Legend.Visible = false;
            this.Chart51_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 221), 90);
            this.Chart51_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart51_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart51.MasterComponent = null;
            // 
            // Item132
            // 
            this.Item132 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item132.BorderColor = System.Drawing.Color.FromArgb(255, 140, 62, 0);
            this.Item132.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item132__GetListOfArguments);
            this.Item132.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item132__GetListOfValues);
            this.Item132.ShowShadow = false;
            this.Item132.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item132__GetTitle);
            this.Item132.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 240, 162, 46), System.Drawing.Color.FromArgb(255, 190, 112, 0), 0);
            this.Item132.DrillDownPageGuid = null;
            this.Item132_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item132_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Item132_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Item132_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item132_SeriesLabels.ValueTypeSeparator = "-";
            this.Item132_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 251, 238, 201));
            this.Item132_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item133
            // 
            this.Item133 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item133.BorderColor = System.Drawing.Color.FromArgb(255, 65, 0, 0);
            this.Item133.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item133__GetListOfArguments);
            this.Item133.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item133__GetListOfValues);
            this.Item133.ShowShadow = false;
            this.Item133.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item133__GetTitle);
            this.Item133.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 165, 100, 78), System.Drawing.Color.FromArgb(255, 115, 50, 28), 0);
            this.Item133.DrillDownPageGuid = null;
            this.Item133_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item133_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Item133_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 101, 88, 51);
            this.Item133_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item133_SeriesLabels.ValueTypeSeparator = "-";
            this.Item133_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 251, 238, 201));
            this.Item133_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart51_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart51_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart51_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart51.Style = new Stimulsoft.Report.Chart.StiStyle14();
            this.Chart51.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 101, 88, 51)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Chart52
            // 
            this.Chart52 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart52.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 20.6, 6.2, 4.4);
            this.Chart52.CountData = 7;
            this.Chart52.CustomStyleName = "";
            this.Chart52.FilterOn = false;
            this.Chart52.Name = "Chart52";
            this.Chart52.Sort = new System.String[0];
            this.Chart52_Area = new Stimulsoft.Report.Chart.StiClusteredColumnArea();
            this.Chart52_Area.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart52_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart52_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart52_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart52_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Drawing.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Drawing.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart52_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 119, 145, 149)), true, true);
            this.Chart52_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(10, 119, 145, 149)), true, true);
            this.Chart52_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 69, 95, 99), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart52_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 69, 95, 99), 1F, false, true, false, true);
            this.Chart52_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 69, 95, 99), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart52_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 69, 95, 99), 1F, false, true, true);
            this.Chart52.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.DimGray, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.DarkGray, System.Drawing.Color.DimGray, 0), false);
            this.Chart52.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart52.Guid = null;
            this.Chart52.Interaction = null;
            this.Chart52_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart52_Legend.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart52_Legend.LabelsColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart52_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart52_Legend.TitleColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Chart52_Legend.Visible = false;
            this.Chart52_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 239, 255, 255), 90);
            this.Chart52_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart52_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart52.MasterComponent = null;
            // 
            // Item135
            // 
            this.Item135 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item135.BorderColor = System.Drawing.Color.FromArgb(255, 0, 11, 98);
            this.Item135.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item135__GetListOfArguments);
            this.Item135.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item135__GetListOfValues);
            this.Item135.ShowShadow = false;
            this.Item135.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item135__GetTitle);
            this.Item135.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 15, 111, 198), System.Drawing.Color.FromArgb(255, 0, 61, 148), 0);
            this.Item135.DrillDownPageGuid = null;
            this.Item135_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item135_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Item135_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Item135_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item135_SeriesLabels.ValueTypeSeparator = "-";
            this.Item135_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 219, 245, 249));
            this.Item135_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item136
            // 
            this.Item136 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item136.BorderColor = System.Drawing.Color.FromArgb(255, 0, 57, 117);
            this.Item136.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item136__GetListOfArguments);
            this.Item136.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item136__GetListOfValues);
            this.Item136.ShowShadow = false;
            this.Item136.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item136__GetTitle);
            this.Item136.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 0, 157, 217), System.Drawing.Color.FromArgb(255, 0, 107, 167), 0);
            this.Item136.DrillDownPageGuid = null;
            this.Item136_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item136_SeriesLabels.BorderColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Item136_SeriesLabels.LabelColor = System.Drawing.Color.FromArgb(255, 69, 95, 99);
            this.Item136_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item136_SeriesLabels.ValueTypeSeparator = "-";
            this.Item136_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 219, 245, 249));
            this.Item136_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart52_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart52_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart52_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart52.Style = new Stimulsoft.Report.Chart.StiStyle15();
            this.Chart52.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 69, 95, 99)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            this.Page5.ExcelSheetValue = null;
            this.Page5.Interaction = null;
            this.Page5.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page5_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page5_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page5_Watermark.Image = null;
            this.Page5_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Styles.Report = this;
            this.Styles.Watermark = this.Styles_Watermark;
            this.Chart9.Area = this.Chart9_Area;
            this.Chart9.Legend = this.Chart9_Legend;
            this.Chart9.Page = this.Styles;
            this.Chart9.Parent = this.Styles;
            this.Chart9.SeriesLabels = this.Chart9_SeriesLabels;
            this.Chart9_Area.Chart = this.Chart9;
            this.Chart9_Legend.Chart = this.Chart9;
            this.Item20.Chart = this.Chart9;
            this.Item20.SeriesLabels = this.Item20_SeriesLabels;
            this.Item20_SeriesLabels.Chart = this.Chart9;
            this.Chart9_SeriesLabels.Chart = this.Chart9;
            this.Chart20.Area = this.Chart20_Area;
            this.Chart20.Legend = this.Chart20_Legend;
            this.Chart20.Page = this.Styles;
            this.Chart20.Parent = this.Styles;
            this.Chart20.SeriesLabels = this.Chart20_SeriesLabels;
            this.Chart20_Area.Chart = this.Chart20;
            this.Chart20_Legend.Chart = this.Chart20;
            this.Item22.Chart = this.Chart20;
            this.Item22.SeriesLabels = this.Item22_SeriesLabels;
            this.Item22_SeriesLabels.Chart = this.Chart20;
            this.Item23.Chart = this.Chart20;
            this.Item23.SeriesLabels = this.Item23_SeriesLabels;
            this.Item23_SeriesLabels.Chart = this.Chart20;
            this.Chart20_SeriesLabels.Chart = this.Chart20;
            this.Chart21.Area = this.Chart21_Area;
            this.Chart21.Legend = this.Chart21_Legend;
            this.Chart21.Page = this.Styles;
            this.Chart21.Parent = this.Styles;
            this.Chart21.SeriesLabels = this.Chart21_SeriesLabels;
            this.Chart21_Area.Chart = this.Chart21;
            this.Chart21_Legend.Chart = this.Chart21;
            this.Item25.Chart = this.Chart21;
            this.Item25.SeriesLabels = this.Item25_SeriesLabels;
            this.Item25_SeriesLabels.Chart = this.Chart21;
            this.Item26.Chart = this.Chart21;
            this.Item26.SeriesLabels = this.Item26_SeriesLabels;
            this.Item26_SeriesLabels.Chart = this.Chart21;
            this.Chart21_SeriesLabels.Chart = this.Chart21;
            this.Text19.Page = this.Styles;
            this.Text19.Parent = this.Styles;
            this.Chart22.Area = this.Chart22_Area;
            this.Chart22.Legend = this.Chart22_Legend;
            this.Chart22.Page = this.Styles;
            this.Chart22.Parent = this.Styles;
            this.Chart22.SeriesLabels = this.Chart22_SeriesLabels;
            this.Chart22_Area.Chart = this.Chart22;
            this.Chart22_Legend.Chart = this.Chart22;
            this.Item29.Chart = this.Chart22;
            this.Item29.SeriesLabels = this.Item29_SeriesLabels;
            this.Item29_SeriesLabels.Chart = this.Chart22;
            this.Chart22_SeriesLabels.Chart = this.Chart22;
            this.Text20.Page = this.Styles;
            this.Text20.Parent = this.Styles;
            this.Chart27.Area = this.Chart27_Area;
            this.Chart27.Legend = this.Chart27_Legend;
            this.Chart27.Page = this.Styles;
            this.Chart27.Parent = this.Styles;
            this.Chart27.SeriesLabels = this.Chart27_SeriesLabels;
            this.Chart27_Area.Chart = this.Chart27;
            this.Chart27_Legend.Chart = this.Chart27;
            this.Item32.Chart = this.Chart27;
            this.Item32.SeriesLabels = this.Item32_SeriesLabels;
            this.Item32_SeriesLabels.Chart = this.Chart27;
            this.Item33.Chart = this.Chart27;
            this.Item33.SeriesLabels = this.Item33_SeriesLabels;
            this.Item33_SeriesLabels.Chart = this.Chart27;
            this.Chart27_SeriesLabels.Chart = this.Chart27;
            this.Text21.Page = this.Styles;
            this.Text21.Parent = this.Styles;
            this.Chart28.Area = this.Chart28_Area;
            this.Chart28.Legend = this.Chart28_Legend;
            this.Chart28.Page = this.Styles;
            this.Chart28.Parent = this.Styles;
            this.Chart28.SeriesLabels = this.Chart28_SeriesLabels;
            this.Chart28_Area.Chart = this.Chart28;
            this.Chart28_Legend.Chart = this.Chart28;
            this.Item36.Chart = this.Chart28;
            this.Item36.SeriesLabels = this.Item36_SeriesLabels;
            this.Item36_SeriesLabels.Chart = this.Chart28;
            this.Item37.Chart = this.Chart28;
            this.Item37.SeriesLabels = this.Item37_SeriesLabels;
            this.Item37_SeriesLabels.Chart = this.Chart28;
            this.Chart28_SeriesLabels.Chart = this.Chart28;
            this.Text26.Page = this.Styles;
            this.Text26.Parent = this.Styles;
            this.Text27.Page = this.Styles;
            this.Text27.Parent = this.Styles;
            this.Text28.Page = this.Styles;
            this.Text28.Parent = this.Styles;
            this.Text29.Page = this.Styles;
            this.Text29.Parent = this.Styles;
            this.Chart29.Area = this.Chart29_Area;
            this.Chart29.Legend = this.Chart29_Legend;
            this.InitializeComponent4();
        }
        
        public void InitializeComponent4()
        {
            this.Chart29.Page = this.Styles;
            this.Chart29.Parent = this.Styles;
            this.Chart29.SeriesLabels = this.Chart29_SeriesLabels;
            this.Chart29_Area.Chart = this.Chart29;
            this.Chart29_Legend.Chart = this.Chart29;
            this.Item43.Chart = this.Chart29;
            this.Item43.LineMarker = this.Item43_LineMarker;
            this.Item43.Marker = this.Item43_Marker;
            this.Item43.SeriesLabels = this.Item43_SeriesLabels;
            this.Item43_SeriesLabels.Chart = this.Chart29;
            this.Item44.Chart = this.Chart29;
            this.Item44.LineMarker = this.Item44_LineMarker;
            this.Item44.Marker = this.Item44_Marker;
            this.Item44.SeriesLabels = this.Item44_SeriesLabels;
            this.Item44_SeriesLabels.Chart = this.Chart29;
            this.Chart29_SeriesLabels.Chart = this.Chart29;
            this.Text30.Page = this.Styles;
            this.Text30.Parent = this.Styles;
            this.Chart30.Area = this.Chart30_Area;
            this.Chart30.Legend = this.Chart30_Legend;
            this.Chart30.Page = this.Styles;
            this.Chart30.Parent = this.Styles;
            this.Chart30.SeriesLabels = this.Chart30_SeriesLabels;
            this.Chart30_Area.Chart = this.Chart30;
            this.Chart30_Legend.Chart = this.Chart30;
            this.Item47.Chart = this.Chart30;
            this.Item47.LineMarker = this.Item47_LineMarker;
            this.Item47.Marker = this.Item47_Marker;
            this.Item47.SeriesLabels = this.Item47_SeriesLabels;
            this.Item47_SeriesLabels.Chart = this.Chart30;
            this.Item48.Chart = this.Chart30;
            this.Item48.LineMarker = this.Item48_LineMarker;
            this.Item48.Marker = this.Item48_Marker;
            this.Item48.SeriesLabels = this.Item48_SeriesLabels;
            this.Item48_SeriesLabels.Chart = this.Chart30;
            this.Chart30_SeriesLabels.Chart = this.Chart30;
            this.Chart31.Area = this.Chart31_Area;
            this.Chart31.Legend = this.Chart31_Legend;
            this.Chart31.Page = this.Styles;
            this.Chart31.Parent = this.Styles;
            this.Chart31.SeriesLabels = this.Chart31_SeriesLabels;
            this.Chart31_Area.Chart = this.Chart31;
            this.Chart31_Legend.Chart = this.Chart31;
            this.Item50.Chart = this.Chart31;
            this.Item50.Marker = this.Item50_Marker;
            this.Item50.SeriesLabels = this.Item50_SeriesLabels;
            this.Item50_SeriesLabels.Chart = this.Chart31;
            this.Item51.Chart = this.Chart31;
            this.Item51.Marker = this.Item51_Marker;
            this.Item51.SeriesLabels = this.Item51_SeriesLabels;
            this.Item51_SeriesLabels.Chart = this.Chart31;
            this.Chart31_SeriesLabels.Chart = this.Chart31;
            this.Text32.Page = this.Styles;
            this.Text32.Parent = this.Styles;
            this.Chart33.Area = this.Chart33_Area;
            this.Chart33.Legend = this.Chart33_Legend;
            this.Chart33.Page = this.Styles;
            this.Chart33.Parent = this.Styles;
            this.Chart33.SeriesLabels = this.Chart33_SeriesLabels;
            this.Chart33_Area.Chart = this.Chart33;
            this.Chart33_Legend.Chart = this.Chart33;
            this.Item54.Chart = this.Chart33;
            this.Item54.Marker = this.Item54_Marker;
            this.Item54.SeriesLabels = this.Item54_SeriesLabels;
            this.Item54_SeriesLabels.Chart = this.Chart33;
            this.Item55.Chart = this.Chart33;
            this.Item55.Marker = this.Item55_Marker;
            this.Item55.SeriesLabels = this.Item55_SeriesLabels;
            this.Item55_SeriesLabels.Chart = this.Chart33;
            this.Chart33_SeriesLabels.Chart = this.Chart33;
            this.Text33.Page = this.Styles;
            this.Text33.Parent = this.Styles;
            this.Text34.Page = this.Styles;
            this.Text34.Parent = this.Styles;
            this.Chart34.Area = this.Chart34_Area;
            this.Chart34.Legend = this.Chart34_Legend;
            this.Chart34.Page = this.Styles;
            this.Chart34.Parent = this.Styles;
            this.Chart34.SeriesLabels = this.Chart34_SeriesLabels;
            this.Chart34_Area.Chart = this.Chart34;
            this.Chart34_Legend.Chart = this.Chart34;
            this.Item59.Chart = this.Chart34;
            this.Item59.Marker = this.Item59_Marker;
            this.Item59.SeriesLabels = this.Item59_SeriesLabels;
            this.Item59_SeriesLabels.Chart = this.Chart34;
            this.Item60.Chart = this.Chart34;
            this.Item60.Marker = this.Item60_Marker;
            this.Item60.SeriesLabels = this.Item60_SeriesLabels;
            this.Item60_SeriesLabels.Chart = this.Chart34;
            this.Chart34_SeriesLabels.Chart = this.Chart34;
            this.Text35.Page = this.Styles;
            this.Text35.Parent = this.Styles;
            this.Chart35.Area = this.Chart35_Area;
            this.Chart35.Legend = this.Chart35_Legend;
            this.Chart35.Page = this.Styles;
            this.Chart35.Parent = this.Styles;
            this.Chart35.SeriesLabels = this.Chart35_SeriesLabels;
            this.Chart35_Area.Chart = this.Chart35;
            this.Chart35_Legend.Chart = this.Chart35;
            this.Item63.Chart = this.Chart35;
            this.Item63.LineMarker = this.Item63_LineMarker;
            this.Item63.Marker = this.Item63_Marker;
            this.Item63.SeriesLabels = this.Item63_SeriesLabels;
            this.Item63_SeriesLabels.Chart = this.Chart35;
            this.Item64.Chart = this.Chart35;
            this.Item64.LineMarker = this.Item64_LineMarker;
            this.Item64.Marker = this.Item64_Marker;
            this.Item64.SeriesLabels = this.Item64_SeriesLabels;
            this.Item64_SeriesLabels.Chart = this.Chart35;
            this.Chart35_SeriesLabels.Chart = this.Chart35;
            this.Text36.Page = this.Styles;
            this.Text36.Parent = this.Styles;
            this.Chart36.Area = this.Chart36_Area;
            this.Chart36.Legend = this.Chart36_Legend;
            this.Chart36.Page = this.Styles;
            this.Chart36.Parent = this.Styles;
            this.Chart36.SeriesLabels = this.Chart36_SeriesLabels;
            this.Chart36_Area.Chart = this.Chart36;
            this.Chart36_Legend.Chart = this.Chart36;
            this.Item67.Chart = this.Chart36;
            this.Item67.LineMarker = this.Item67_LineMarker;
            this.Item67.Marker = this.Item67_Marker;
            this.Item67.SeriesLabels = this.Item67_SeriesLabels;
            this.Item67_SeriesLabels.Chart = this.Chart36;
            this.Item68.Chart = this.Chart36;
            this.Item68.LineMarker = this.Item68_LineMarker;
            this.Item68.Marker = this.Item68_Marker;
            this.Item68.SeriesLabels = this.Item68_SeriesLabels;
            this.Item68_SeriesLabels.Chart = this.Chart36;
            this.Chart36_SeriesLabels.Chart = this.Chart36;
            this.Text37.Page = this.Styles;
            this.Text37.Parent = this.Styles;
            this.Chart37.Area = this.Chart37_Area;
            this.Chart37.Legend = this.Chart37_Legend;
            this.Chart37.Page = this.Styles;
            this.Chart37.Parent = this.Styles;
            this.Chart37.SeriesLabels = this.Chart37_SeriesLabels;
            this.Chart37_Area.Chart = this.Chart37;
            this.Chart37_Legend.Chart = this.Chart37;
            this.Item71.Chart = this.Chart37;
            this.Item71.SeriesLabels = this.Item71_SeriesLabels;
            this.Item71_SeriesLabels.Chart = this.Chart37;
            this.Item72.Chart = this.Chart37;
            this.Item72.SeriesLabels = this.Item72_SeriesLabels;
            this.Item72_SeriesLabels.Chart = this.Chart37;
            this.Chart37_SeriesLabels.Chart = this.Chart37;
            this.Text38.Page = this.Styles;
            this.Text38.Parent = this.Styles;
            this.Chart38.Area = this.Chart38_Area;
            this.Chart38.Legend = this.Chart38_Legend;
            this.Chart38.Page = this.Styles;
            this.Chart38.Parent = this.Styles;
            this.Chart38.SeriesLabels = this.Chart38_SeriesLabels;
            this.Chart38_Area.Chart = this.Chart38;
            this.Chart38_Legend.Chart = this.Chart38;
            this.Item75.Chart = this.Chart38;
            this.Item75.SeriesLabels = this.Item75_SeriesLabels;
            this.Item75_SeriesLabels.Chart = this.Chart38;
            this.Chart38_SeriesLabels.Chart = this.Chart38;
            this.Page5.Report = this;
            this.Page5.Watermark = this.Page5_Watermark;
            this.Chart32.Area = this.Chart32_Area;
            this.Chart32.Legend = this.Chart32_Legend;
            this.Chart32.Page = this.Page5;
            this.Chart32.Parent = this.Page5;
            this.Chart32.SeriesLabels = this.Chart32_SeriesLabels;
            this.Chart32_Area.Chart = this.Chart32;
            this.Chart32_Legend.Chart = this.Chart32;
            this.Item78.Chart = this.Chart32;
            this.Item78.SeriesLabels = this.Item78_SeriesLabels;
            this.Item78_SeriesLabels.Chart = this.Chart32;
            this.Item79.Chart = this.Chart32;
            this.Item79.SeriesLabels = this.Item79_SeriesLabels;
            this.Item79_SeriesLabels.Chart = this.Chart32;
            this.Chart32_SeriesLabels.Chart = this.Chart32;
            this.Text31.Page = this.Page5;
            this.Text31.Parent = this.Page5;
            this.Text39.Page = this.Page5;
            this.Text39.Parent = this.Page5;
            this.Text40.Page = this.Page5;
            this.Text40.Parent = this.Page5;
            this.Text41.Page = this.Page5;
            this.Text41.Parent = this.Page5;
            this.Text42.Page = this.Page5;
            this.Text42.Parent = this.Page5;
            this.Text43.Page = this.Page5;
            this.Text43.Parent = this.Page5;
            this.Text44.Page = this.Page5;
            this.Text44.Parent = this.Page5;
            this.Text45.Page = this.Page5;
            this.Text45.Parent = this.Page5;
            this.Text46.Page = this.Page5;
            this.Text46.Parent = this.Page5;
            this.Text47.Page = this.Page5;
            this.Text47.Parent = this.Page5;
            this.Text48.Page = this.Page5;
            this.Text48.Parent = this.Page5;
            this.Text49.Page = this.Page5;
            this.Text49.Parent = this.Page5;
            this.Text50.Page = this.Page5;
            this.Text50.Parent = this.Page5;
            this.Text51.Page = this.Page5;
            this.Text51.Parent = this.Page5;
            this.Text52.Page = this.Page5;
            this.Text52.Parent = this.Page5;
            this.Chart39.Area = this.Chart39_Area;
            this.Chart39.Legend = this.Chart39_Legend;
            this.Chart39.Page = this.Page5;
            this.Chart39.Parent = this.Page5;
            this.Chart39.SeriesLabels = this.Chart39_SeriesLabels;
            this.Chart39_Area.Chart = this.Chart39;
            this.Chart39_Legend.Chart = this.Chart39;
            this.Item96.Chart = this.Chart39;
            this.Item96.SeriesLabels = this.Item96_SeriesLabels;
            this.Item96_SeriesLabels.Chart = this.Chart39;
            this.Item97.Chart = this.Chart39;
            this.Item97.SeriesLabels = this.Item97_SeriesLabels;
            this.Item97_SeriesLabels.Chart = this.Chart39;
            this.Chart39_SeriesLabels.Chart = this.Chart39;
            this.Chart40.Area = this.Chart40_Area;
            this.Chart40.Legend = this.Chart40_Legend;
            this.Chart40.Page = this.Page5;
            this.Chart40.Parent = this.Page5;
            this.Chart40.SeriesLabels = this.Chart40_SeriesLabels;
            this.Chart40_Area.Chart = this.Chart40;
            this.Chart40_Legend.Chart = this.Chart40;
            this.Item99.Chart = this.Chart40;
            this.Item99.SeriesLabels = this.Item99_SeriesLabels;
            this.Item99_SeriesLabels.Chart = this.Chart40;
            this.Item100.Chart = this.Chart40;
            this.Item100.SeriesLabels = this.Item100_SeriesLabels;
            this.Item100_SeriesLabels.Chart = this.Chart40;
            this.Chart40_SeriesLabels.Chart = this.Chart40;
            this.Chart41.Area = this.Chart41_Area;
            this.Chart41.Legend = this.Chart41_Legend;
            this.Chart41.Page = this.Page5;
            this.Chart41.Parent = this.Page5;
            this.Chart41.SeriesLabels = this.Chart41_SeriesLabels;
            this.Chart41_Area.Chart = this.Chart41;
            this.Chart41_Legend.Chart = this.Chart41;
            this.Item102.Chart = this.Chart41;
            this.Item102.SeriesLabels = this.Item102_SeriesLabels;
            this.Item102_SeriesLabels.Chart = this.Chart41;
            this.Item103.Chart = this.Chart41;
            this.Item103.SeriesLabels = this.Item103_SeriesLabels;
            this.Item103_SeriesLabels.Chart = this.Chart41;
            this.Chart41_SeriesLabels.Chart = this.Chart41;
            this.Chart42.Area = this.Chart42_Area;
            this.Chart42.Legend = this.Chart42_Legend;
            this.Chart42.Page = this.Page5;
            this.Chart42.Parent = this.Page5;
            this.Chart42.SeriesLabels = this.Chart42_SeriesLabels;
            this.Chart42_Area.Chart = this.Chart42;
            this.Chart42_Legend.Chart = this.Chart42;
            this.Item105.Chart = this.Chart42;
            this.Item105.SeriesLabels = this.Item105_SeriesLabels;
            this.Item105_SeriesLabels.Chart = this.Chart42;
            this.Item106.Chart = this.Chart42;
            this.Item106.SeriesLabels = this.Item106_SeriesLabels;
            this.Item106_SeriesLabels.Chart = this.Chart42;
            this.Chart42_SeriesLabels.Chart = this.Chart42;
            this.Chart43.Area = this.Chart43_Area;
            this.Chart43.Legend = this.Chart43_Legend;
            this.Chart43.Page = this.Page5;
            this.Chart43.Parent = this.Page5;
            this.Chart43.SeriesLabels = this.Chart43_SeriesLabels;
            this.Chart43_Area.Chart = this.Chart43;
            this.Chart43_Legend.Chart = this.Chart43;
            this.Item108.Chart = this.Chart43;
            this.Item108.SeriesLabels = this.Item108_SeriesLabels;
            this.Item108_SeriesLabels.Chart = this.Chart43;
            this.Item109.Chart = this.Chart43;
            this.Item109.SeriesLabels = this.Item109_SeriesLabels;
            this.Item109_SeriesLabels.Chart = this.Chart43;
            this.Chart43_SeriesLabels.Chart = this.Chart43;
            this.Chart44.Area = this.Chart44_Area;
            this.Chart44.Legend = this.Chart44_Legend;
            this.Chart44.Page = this.Page5;
            this.Chart44.Parent = this.Page5;
            this.Chart44.SeriesLabels = this.Chart44_SeriesLabels;
            this.Chart44_Area.Chart = this.Chart44;
            this.Chart44_Legend.Chart = this.Chart44;
            this.Item111.Chart = this.Chart44;
            this.Item111.SeriesLabels = this.Item111_SeriesLabels;
            this.Item111_SeriesLabels.Chart = this.Chart44;
            this.Item112.Chart = this.Chart44;
            this.Item112.SeriesLabels = this.Item112_SeriesLabels;
            this.Item112_SeriesLabels.Chart = this.Chart44;
            this.Chart44_SeriesLabels.Chart = this.Chart44;
            this.Chart45.Area = this.Chart45_Area;
            this.Chart45.Legend = this.Chart45_Legend;
            this.Chart45.Page = this.Page5;
            this.Chart45.Parent = this.Page5;
            this.Chart45.SeriesLabels = this.Chart45_SeriesLabels;
            this.Chart45_Area.Chart = this.Chart45;
            this.Chart45_Legend.Chart = this.Chart45;
            this.Item114.Chart = this.Chart45;
            this.Item114.SeriesLabels = this.Item114_SeriesLabels;
            this.Item114_SeriesLabels.Chart = this.Chart45;
            this.Item115.Chart = this.Chart45;
            this.Item115.SeriesLabels = this.Item115_SeriesLabels;
            this.Item115_SeriesLabels.Chart = this.Chart45;
            this.Chart45_SeriesLabels.Chart = this.Chart45;
            this.Chart46.Area = this.Chart46_Area;
            this.Chart46.Legend = this.Chart46_Legend;
            this.Chart46.Page = this.Page5;
            this.Chart46.Parent = this.Page5;
            this.Chart46.SeriesLabels = this.Chart46_SeriesLabels;
            this.Chart46_Area.Chart = this.Chart46;
            this.Chart46_Legend.Chart = this.Chart46;
            this.Item117.Chart = this.Chart46;
            this.Item117.SeriesLabels = this.Item117_SeriesLabels;
            this.Item117_SeriesLabels.Chart = this.Chart46;
            this.Item118.Chart = this.Chart46;
            this.Item118.SeriesLabels = this.Item118_SeriesLabels;
            this.Item118_SeriesLabels.Chart = this.Chart46;
            this.Chart46_SeriesLabels.Chart = this.Chart46;
            this.Chart47.Area = this.Chart47_Area;
            this.Chart47.Legend = this.Chart47_Legend;
            this.Chart47.Page = this.Page5;
            this.Chart47.Parent = this.Page5;
            this.Chart47.SeriesLabels = this.Chart47_SeriesLabels;
            this.Chart47_Area.Chart = this.Chart47;
            this.Chart47_Legend.Chart = this.Chart47;
            this.Item120.Chart = this.Chart47;
            this.Item120.SeriesLabels = this.Item120_SeriesLabels;
            this.Item120_SeriesLabels.Chart = this.Chart47;
            this.Item121.Chart = this.Chart47;
            this.Item121.SeriesLabels = this.Item121_SeriesLabels;
            this.Item121_SeriesLabels.Chart = this.Chart47;
            this.Chart47_SeriesLabels.Chart = this.Chart47;
            this.Chart48.Area = this.Chart48_Area;
            this.Chart48.Legend = this.Chart48_Legend;
            this.Chart48.Page = this.Page5;
            this.Chart48.Parent = this.Page5;
            this.Chart48.SeriesLabels = this.Chart48_SeriesLabels;
            this.Chart48_Area.Chart = this.Chart48;
            this.Chart48_Legend.Chart = this.Chart48;
            this.Item123.Chart = this.Chart48;
            this.Item123.SeriesLabels = this.Item123_SeriesLabels;
            this.Item123_SeriesLabels.Chart = this.Chart48;
            this.Item124.Chart = this.Chart48;
            this.Item124.SeriesLabels = this.Item124_SeriesLabels;
            this.Item124_SeriesLabels.Chart = this.Chart48;
            this.Chart48_SeriesLabels.Chart = this.Chart48;
            this.Chart49.Area = this.Chart49_Area;
            this.Chart49.Legend = this.Chart49_Legend;
            this.Chart49.Page = this.Page5;
            this.Chart49.Parent = this.Page5;
            this.Chart49.SeriesLabels = this.Chart49_SeriesLabels;
            this.Chart49_Area.Chart = this.Chart49;
            this.Chart49_Legend.Chart = this.Chart49;
            this.Item126.Chart = this.Chart49;
            this.Item126.SeriesLabels = this.Item126_SeriesLabels;
            this.Item126_SeriesLabels.Chart = this.Chart49;
            this.Item127.Chart = this.Chart49;
            this.Item127.SeriesLabels = this.Item127_SeriesLabels;
            this.Item127_SeriesLabels.Chart = this.Chart49;
            this.Chart49_SeriesLabels.Chart = this.Chart49;
            this.Chart50.Area = this.Chart50_Area;
            this.Chart50.Legend = this.Chart50_Legend;
            this.Chart50.Page = this.Page5;
            this.Chart50.Parent = this.Page5;
            this.Chart50.SeriesLabels = this.Chart50_SeriesLabels;
            this.Chart50_Area.Chart = this.Chart50;
            this.Chart50_Legend.Chart = this.Chart50;
            this.Item129.Chart = this.Chart50;
            this.Item129.SeriesLabels = this.Item129_SeriesLabels;
            this.Item129_SeriesLabels.Chart = this.Chart50;
            this.Item130.Chart = this.Chart50;
            this.Item130.SeriesLabels = this.Item130_SeriesLabels;
            this.Item130_SeriesLabels.Chart = this.Chart50;
            this.Chart50_SeriesLabels.Chart = this.Chart50;
            this.Chart51.Area = this.Chart51_Area;
            this.Chart51.Legend = this.Chart51_Legend;
            this.Chart51.Page = this.Page5;
            this.Chart51.Parent = this.Page5;
            this.Chart51.SeriesLabels = this.Chart51_SeriesLabels;
            this.Chart51_Area.Chart = this.Chart51;
            this.Chart51_Legend.Chart = this.Chart51;
            this.Item132.Chart = this.Chart51;
            this.Item132.SeriesLabels = this.Item132_SeriesLabels;
            this.Item132_SeriesLabels.Chart = this.Chart51;
            this.Item133.Chart = this.Chart51;
            this.Item133.SeriesLabels = this.Item133_SeriesLabels;
            this.Item133_SeriesLabels.Chart = this.Chart51;
            this.Chart51_SeriesLabels.Chart = this.Chart51;
            this.Chart52.Area = this.Chart52_Area;
            this.Chart52.Legend = this.Chart52_Legend;
            this.Chart52.Page = this.Page5;
            this.Chart52.Parent = this.Page5;
            this.Chart52.SeriesLabels = this.Chart52_SeriesLabels;
            this.Chart52_Area.Chart = this.Chart52;
            this.Chart52_Legend.Chart = this.Chart52;
            this.Item135.Chart = this.Chart52;
            this.Item135.SeriesLabels = this.Item135_SeriesLabels;
            this.Item135_SeriesLabels.Chart = this.Chart52;
            this.Item136.Chart = this.Chart52;
            this.Item136.SeriesLabels = this.Item136_SeriesLabels;
            this.Item136_SeriesLabels.Chart = this.Chart52;
            this.Chart52_SeriesLabels.Chart = this.Chart52;
            // 
            // Add to Chart9.Series
            // 
            this.Chart9.Series.Clear();
            this.Chart9.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item20});
            // 
            // Add to Chart20.Series
            // 
            this.Chart20.Series.Clear();
            this.Chart20.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item22,
                        this.Item23});
            // 
            // Add to Chart21.Series
            // 
            this.Chart21.Series.Clear();
            this.Chart21.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item25,
                        this.Item26});
            // 
            // Add to Chart22.Series
            // 
            this.Chart22.Series.Clear();
            this.Chart22.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item29});
            // 
            // Add to Chart27.Series
            // 
            this.Chart27.Series.Clear();
            this.Chart27.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item32,
                        this.Item33});
            // 
            // Add to Chart28.Series
            // 
            this.Chart28.Series.Clear();
            this.Chart28.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item36,
                        this.Item37});
            // 
            // Add to Chart29.Series
            // 
            this.Chart29.Series.Clear();
            this.Chart29.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item43,
                        this.Item44});
            // 
            // Add to Chart30.Series
            // 
            this.Chart30.Series.Clear();
            this.Chart30.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item47,
                        this.Item48});
            // 
            // Add to Chart31.Series
            // 
            this.Chart31.Series.Clear();
            this.Chart31.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item50,
                        this.Item51});
            // 
            // Add to Chart33.Series
            // 
            this.Chart33.Series.Clear();
            this.Chart33.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item54,
                        this.Item55});
            // 
            // Add to Chart34.Series
            // 
            this.Chart34.Series.Clear();
            this.Chart34.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item59,
                        this.Item60});
            // 
            // Add to Chart35.Series
            // 
            this.Chart35.Series.Clear();
            this.Chart35.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item63,
                        this.Item64});
            // 
            // Add to Chart36.Series
            // 
            this.Chart36.Series.Clear();
            this.Chart36.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item67,
                        this.Item68});
            // 
            // Add to Chart37.Series
            // 
            this.Chart37.Series.Clear();
            this.Chart37.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item71,
                        this.Item72});
            // 
            // Add to Chart38.Series
            // 
            this.Chart38.Series.Clear();
            this.Chart38.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item75});
            // 
            // Add to Styles.Components
            // 
            this.Styles.Components.Clear();
            this.Styles.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Chart9,
                        this.Chart20,
                        this.Chart21,
                        this.Text19,
                        this.Chart22,
                        this.Text20,
                        this.Chart27,
                        this.Text21,
                        this.Chart28,
                        this.Text26,
                        this.Text27,
                        this.Text28,
                        this.Text29,
                        this.Chart29,
                        this.Text30,
                        this.Chart30,
                        this.Chart31,
                        this.Text32,
                        this.Chart33,
                        this.Text33,
                        this.Text34,
                        this.Chart34,
                        this.Text35,
                        this.Chart35,
                        this.Text36,
                        this.Chart36,
                        this.Text37,
                        this.Chart37,
                        this.Text38,
                        this.Chart38});
            // 
            // Add to Chart32.Series
            // 
            this.Chart32.Series.Clear();
            this.Chart32.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item78,
                        this.Item79});
            // 
            // Add to Chart39.Series
            // 
            this.Chart39.Series.Clear();
            this.Chart39.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item96,
                        this.Item97});
            // 
            // Add to Chart40.Series
            // 
            this.Chart40.Series.Clear();
            this.Chart40.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item99,
                        this.Item100});
            // 
            // Add to Chart41.Series
            // 
            this.Chart41.Series.Clear();
            this.Chart41.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item102,
                        this.Item103});
            // 
            // Add to Chart42.Series
            // 
            this.Chart42.Series.Clear();
            this.Chart42.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item105,
                        this.Item106});
            // 
            // Add to Chart43.Series
            // 
            this.Chart43.Series.Clear();
            this.Chart43.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item108,
                        this.Item109});
            // 
            // Add to Chart44.Series
            // 
            this.Chart44.Series.Clear();
            this.Chart44.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item111,
                        this.Item112});
            // 
            // Add to Chart45.Series
            // 
            this.Chart45.Series.Clear();
            this.Chart45.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item114,
                        this.Item115});
            // 
            // Add to Chart46.Series
            // 
            this.Chart46.Series.Clear();
            this.Chart46.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item117,
                        this.Item118});
            // 
            // Add to Chart47.Series
            // 
            this.Chart47.Series.Clear();
            this.Chart47.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item120,
                        this.Item121});
            // 
            // Add to Chart48.Series
            // 
            this.Chart48.Series.Clear();
            this.Chart48.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item123,
                        this.Item124});
            // 
            // Add to Chart49.Series
            // 
            this.Chart49.Series.Clear();
            this.Chart49.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item126,
                        this.Item127});
            // 
            // Add to Chart50.Series
            // 
            this.Chart50.Series.Clear();
            this.Chart50.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item129,
                        this.Item130});
            // 
            // Add to Chart51.Series
            // 
            this.Chart51.Series.Clear();
            this.Chart51.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item132,
                        this.Item133});
            // 
            // Add to Chart52.Series
            // 
            this.Chart52.Series.Clear();
            this.Chart52.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item135,
                        this.Item136});
            // 
            // Add to Page5.Components
            // 
            this.Page5.Components.Clear();
            this.Page5.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Chart32,
                        this.Text31,
                        this.Text39,
                        this.Text40,
                        this.Text41,
                        this.Text42,
                        this.Text43,
                        this.Text44,
                        this.Text45,
                        this.Text46,
                        this.Text47,
                        this.Text48,
                        this.Text49,
                        this.Text50,
                        this.Text51,
                        this.Text52,
                        this.Chart39,
                        this.Chart40,
                        this.Chart41,
                        this.Chart42,
                        this.Chart43,
                        this.Chart44,
                        this.Chart45,
                        this.Chart46,
                        this.Chart47,
                        this.Chart48,
                        this.Chart49,
                        this.Chart50,
                        this.Chart51,
                        this.Chart52});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Styles,
                        this.Page5});
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