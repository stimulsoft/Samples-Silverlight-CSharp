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
        public new Stimulsoft.Report.Components.StiPage Styles;
        public Stimulsoft.Report.Chart.StiChart Chart9;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart9_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart9_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item3;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item3_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart9_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart20;
        public Stimulsoft.Report.Chart.StiStackedColumnArea Chart20_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart20_Legend;
        public Stimulsoft.Report.Chart.StiStackedColumnSeries Item5;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item5_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedColumnSeries Item6;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item6_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart20_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart21;
        public Stimulsoft.Report.Chart.StiFullStackedColumnArea Chart21_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart21_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedColumnSeries Item8;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item8_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedColumnSeries Item9;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item9_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart21_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text19;
        public Stimulsoft.Report.Chart.StiChart Chart22;
        public Stimulsoft.Report.Chart.StiClusteredBarArea Chart22_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart22_Legend;
        public Stimulsoft.Report.Chart.StiClusteredBarSeries Item12;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item12_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart22_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Chart.StiChart Chart27;
        public Stimulsoft.Report.Chart.StiStackedBarArea Chart27_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart27_Legend;
        public Stimulsoft.Report.Chart.StiStackedBarSeries Item15;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item15_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedBarSeries Item16;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item16_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart27_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text21;
        public Stimulsoft.Report.Chart.StiChart Chart28;
        public Stimulsoft.Report.Chart.StiFullStackedBarArea Chart28_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart28_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedBarSeries Item19;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item19_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedBarSeries Item20;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item20_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart28_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text26;
        public Stimulsoft.Report.Components.StiText Text27;
        public Stimulsoft.Report.Components.StiText Text28;
        public Stimulsoft.Report.Components.StiText Text29;
        public Stimulsoft.Report.Chart.StiChart Chart29;
        public Stimulsoft.Report.Chart.StiStackedLineArea Chart29_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart29_Legend;
        public Stimulsoft.Report.Chart.StiStackedLineSeries Item26;
        public Stimulsoft.Report.Chart.StiLineMarker Item26_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item26_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item26_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedLineSeries Item27;
        public Stimulsoft.Report.Chart.StiLineMarker Item27_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item27_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item27_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart29_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text30;
        public Stimulsoft.Report.Chart.StiChart Chart30;
        public Stimulsoft.Report.Chart.StiLineArea Chart30_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart30_Legend;
        public Stimulsoft.Report.Chart.StiLineSeries Item30;
        public Stimulsoft.Report.Chart.StiLineMarker Item30_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item30_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item30_SeriesLabels;
        public Stimulsoft.Report.Chart.StiLineSeries Item31;
        public Stimulsoft.Report.Chart.StiLineMarker Item31_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item31_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item31_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart30_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart31;
        public Stimulsoft.Report.Chart.StiSplineArea Chart31_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart31_Legend;
        public Stimulsoft.Report.Chart.StiSplineSeries Item33;
        public Stimulsoft.Report.Chart.StiMarker Item33_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item33_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSplineSeries Item34;
        public Stimulsoft.Report.Chart.StiMarker Item34_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item34_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart31_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text32;
        public Stimulsoft.Report.Chart.StiChart Chart33;
        public Stimulsoft.Report.Chart.StiFullStackedSplineArea Chart33_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart33_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedSplineSeries Item37;
        public Stimulsoft.Report.Chart.StiMarker Item37_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item37_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedSplineSeries Item38;
        public Stimulsoft.Report.Chart.StiMarker Item38_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item38_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart33_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text33;
        public Stimulsoft.Report.Components.StiText Text34;
        public Stimulsoft.Report.Chart.StiChart Chart34;
        public Stimulsoft.Report.Chart.StiStackedSplineArea Chart34_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart34_Legend;
        public Stimulsoft.Report.Chart.StiStackedSplineSeries Item42;
        public Stimulsoft.Report.Chart.StiMarker Item42_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item42_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedSplineSeries Item43;
        public Stimulsoft.Report.Chart.StiMarker Item43_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item43_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart34_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text35;
        public Stimulsoft.Report.Chart.StiChart Chart35;
        public Stimulsoft.Report.Chart.StiStackedAreaArea Chart35_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart35_Legend;
        public Stimulsoft.Report.Chart.StiStackedAreaSeries Item46;
        public Stimulsoft.Report.Chart.StiLineMarker Item46_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item46_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item46_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedAreaSeries Item47;
        public Stimulsoft.Report.Chart.StiLineMarker Item47_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item47_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item47_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart35_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text36;
        public Stimulsoft.Report.Chart.StiChart Chart36;
        public Stimulsoft.Report.Chart.StiAreaArea Chart36_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart36_Legend;
        public Stimulsoft.Report.Chart.StiAreaSeries Item50;
        public Stimulsoft.Report.Chart.StiLineMarker Item50_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item50_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item50_SeriesLabels;
        public Stimulsoft.Report.Chart.StiAreaSeries Item51;
        public Stimulsoft.Report.Chart.StiLineMarker Item51_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item51_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item51_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart36_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text37;
        public Stimulsoft.Report.Chart.StiChart Chart37;
        public Stimulsoft.Report.Chart.StiDoughnutArea Chart37_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart37_Legend;
        public Stimulsoft.Report.Chart.StiDoughnutSeries Item54;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item54_SeriesLabels;
        public Stimulsoft.Report.Chart.StiDoughnutSeries Item55;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item55_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterPieLabels Chart37_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text38;
        public Stimulsoft.Report.Chart.StiChart Chart38;
        public Stimulsoft.Report.Chart.StiPieArea Chart38_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart38_Legend;
        public Stimulsoft.Report.Chart.StiPieSeries Item58;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item58_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterPieLabels Chart38_SeriesLabels;
        public Stimulsoft.Report.Components.StiWatermark Styles_Watermark;
        public Stimulsoft.Report.Components.StiPage Page5;
        public Stimulsoft.Report.Chart.StiChart Chart32;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart32_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart32_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item61;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item61_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item62;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item62_SeriesLabels;
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
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item79;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item79_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item80;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item80_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart39_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart40;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart40_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart40_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item82;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item82_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item83;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item83_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart40_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart41;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart41_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart41_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item85;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item85_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item86;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item86_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart41_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart42;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart42_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart42_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item88;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item88_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item89;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item89_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart42_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart43;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart43_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart43_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item91;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item91_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item92;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item92_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart43_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart44;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart44_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart44_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item94;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item94_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item95;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item95_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart44_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart45;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart45_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart45_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item97;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item97_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item98;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item98_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart45_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart46;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart46_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart46_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item100;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item100_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item101;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item101_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart46_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart47;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart47_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart47_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item103;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item103_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item104;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item104_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart47_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart48;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart48_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart48_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item106;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item106_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item107;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item107_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart48_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart49;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart49_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart49_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item109;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item109_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item110;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item110_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart49_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart50;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart50_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart50_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item112;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item112_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item113;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item113_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart50_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart51;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart51_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart51_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item115;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item115_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item116;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item116_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart51_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart52;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart52_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart52_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item118;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item118_SeriesLabels;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item119;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item119_SeriesLabels;
        public Stimulsoft.Report.Chart.StiNoneLabels Chart52_SeriesLabels;
        public Stimulsoft.Report.Components.StiWatermark Page5_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        
        public void Item3__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item3__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item3__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item5__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item5__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item5__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries January 2005";
        }
        
        public void Item6__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item6__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;55;60;20;70;31;24";
        }
        
        public void Item6__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries February 2005";
        }
        
        public void Item8__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item8__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;50;60;5;86;21;14";
        }
        
        public void Item8__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item9__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item9__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;40;40;15;70;31;54";
        }
        
        public void Item9__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 2";
        }
        
        public void Text19__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Syle 03";
        }
        
        public void Item12__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item12__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;50;60;5;86;21;14";
        }
        
        public void Item12__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 05";
        }
        
        public void Item15__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item15__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;50;60;5;86;21;14";
        }
        
        public void Item15__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item16__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item16__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;25;60;10;5;7";
        }
        
        public void Item16__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text21__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 15";
        }
        
        public void Item19__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item19__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "80;50;60;5;86;21;14";
        }
        
        public void Item19__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item20__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item20__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;50;12;40;10;10";
        }
        
        public void Item20__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
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
        
        public void Item26__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item26__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;25;15;15";
        }
        
        public void Item26__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item27__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item27__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;15;25;10";
        }
        
        public void Item27__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text30__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 09";
        }
        
        public void Item30__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item30__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;25;15;15";
        }
        
        public void Item30__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item31__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item31__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;15;25;10";
        }
        
        public void Item31__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
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
        
        public void Text32__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 08";
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
        
        public void Text33__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 10";
        }
        
        public void Text34__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 06";
        }
        
        public void Item42__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item42__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item42__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item43__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item43__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item43__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text35__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 12";
        }
        
        public void Item46__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item46__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;10;30;15;10;20;15;30;10";
        }
        
        public void Item46__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item47__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item47__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;20;20;15;10;15;40;20;10";
        }
        
        public void Item47__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text36__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 11";
        }
        
        public void Item50__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item50__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;10;15;5;15;10;20;15;5;10";
        }
        
        public void Item50__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item51__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item51__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;20;20;15;10;15;40;20;10";
        }
        
        public void Item51__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text37__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 13";
        }
        
        public void Item54__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4";
        }
        
        public void Item54__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;50;30";
        }
        
        public void Item54__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item55__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4";
        }
        
        public void Item55__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;7;13;4";
        }
        
        public void Item55__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 2";
        }
        
        public void Text38__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Style 14";
        }
        
        public void Item58__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item58__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;30;10;30;25";
        }
        
        public void Item58__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item61__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item61__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item61__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item62__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item62__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item62__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
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
        
        public void Item79__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item79__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item79__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item80__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item80__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item80__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item82__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item82__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item82__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item83__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item83__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item83__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item85__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item85__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item85__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item86__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item86__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item86__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item88__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item88__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item88__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item89__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item89__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item89__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item91__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item91__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item91__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item92__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item92__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item92__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item94__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item94__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item94__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item95__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item95__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item95__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item97__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item97__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item97__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item98__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item98__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item98__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item100__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item100__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item100__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item101__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item101__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item101__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item103__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item103__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item103__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item104__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item104__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item104__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item106__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item106__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item106__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item107__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item107__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item107__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item109__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item109__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item109__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item110__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item110__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item110__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item112__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item112__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item112__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item113__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item113__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item113__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item115__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item115__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item115__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item116__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item116__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item116__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item118__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item118__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "70;60;55;15;65;21;14";
        }
        
        public void Item118__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Amount orders per countries";
        }
        
        public void Item119__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "USA;England;Brasil;Poland;Germany;Russia;Turckey";
        }
        
        public void Item119__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;50;50;10;35;10;25";
        }
        
        public void Item119__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        private void InitializeComponent()
        {
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
            this.Styles.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Styles.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
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
            this.Chart9_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_Area.ShowShadow = true;
            this.Chart9_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart9_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart9_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart9_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart9_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart9_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart9_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.Triangle, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart9_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart9_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart9_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart9.Guid = null;
            this.Chart9.Interaction = null;
            this.Chart9_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart9_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart9_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_Legend.Visible = false;
            this.Chart9_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart9_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart9_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart9.MasterComponent = null;
            // 
            // Item3
            // 
            this.Item3 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item3.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item3.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item3__GetListOfArguments);
            this.Item3.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item3__GetListOfValues);
            this.Item3.ShowShadow = false;
            this.Item3.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item3__GetTitle);
            this.Item3.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 144, 67, 3), System.Windows.Media.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item3.DrillDownPageGuid = null;
            this.Item3_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item3_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item3_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item3_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item3_SeriesLabels.ValueTypeSeparator = "-";
            this.Item3_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item3_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart9_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart9_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart9_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart9_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart9_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart9_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart9.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart9.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart20_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart20_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart20_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart20_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart20_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 145, 145)), false, true);
            this.Chart20_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 145, 145)), false, true);
            this.Chart20_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.TwoLines, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart20_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, false, true);
            this.Chart20_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart20_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, true);
            this.Chart20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart20.Guid = null;
            this.Chart20.Interaction = null;
            this.Chart20_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart20_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart20_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart20_Legend.Visible = false;
            this.Chart20_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart20_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart20_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart20.MasterComponent = null;
            // 
            // Item5
            // 
            this.Item5 = new Stimulsoft.Report.Chart.StiStackedColumnSeries();
            this.Item5.BorderColor = System.Windows.Media.Color.FromArgb(255, 28, 45, 65);
            this.Item5.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfArguments);
            this.Item5.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfValues);
            this.Item5.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item5__GetTitle);
            this.Item5.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 128, 145, 165), System.Windows.Media.Color.FromArgb(255, 178, 195, 215), 0, 0.5F, 1F);
            this.Item5.DrillDownPageGuid = null;
            this.Item5_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item5_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item5_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item5_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item5_SeriesLabels.ValueTypeSeparator = "-";
            this.Item5_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Item5_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item6
            // 
            this.Item6 = new Stimulsoft.Report.Chart.StiStackedColumnSeries();
            this.Item6.BorderColor = System.Windows.Media.Color.FromArgb(255, 71, 23, 22);
            this.Item6.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item6__GetListOfArguments);
            this.Item6.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item6__GetListOfValues);
            this.Item6.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item6__GetTitle);
            this.Item6.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 171, 123, 122), System.Windows.Media.Color.FromArgb(255, 221, 173, 172), 0, 0.5F, 1F);
            this.Item6.DrillDownPageGuid = null;
            this.Item6_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item6_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item6_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item6_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item6_SeriesLabels.ValueTypeSeparator = "-";
            this.Item6_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Item6_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart20_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart20_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart20_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart20_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart20_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Chart20_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart20.Style = new Stimulsoft.Report.Chart.StiStyle02();
            this.Chart20.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 95, 95)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart21_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart21_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart21_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart21_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart21_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 145, 145)), false, true);
            this.Chart21_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 145, 145)), false, true);
            this.Chart21_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart21_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, false, true);
            this.Chart21_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart21_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, true);
            this.Chart21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart21.Guid = null;
            this.Chart21.Interaction = null;
            this.Chart21_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart21_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart21_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_Legend.Visible = false;
            this.Chart21_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart21_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart21_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart21.MasterComponent = null;
            // 
            // Item8
            // 
            this.Item8 = new Stimulsoft.Report.Chart.StiFullStackedColumnSeries();
            this.Item8.BorderColor = System.Windows.Media.Color.FromArgb(255, 50, 0, 0);
            this.Item8.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfArguments);
            this.Item8.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfValues);
            this.Item8.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item8__GetTitle);
            this.Item8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 150, 61, 59));
            this.Item8.DrillDownPageGuid = null;
            this.Item8_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item8_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item8_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item8_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item8_SeriesLabels.ValueTypeSeparator = "-";
            this.Item8_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Item8_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item9
            // 
            this.Item9 = new Stimulsoft.Report.Chart.StiFullStackedColumnSeries();
            this.Item9.BorderColor = System.Windows.Media.Color.FromArgb(255, 79, 0, 0);
            this.Item9.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item9__GetListOfArguments);
            this.Item9.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item9__GetListOfValues);
            this.Item9.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item9__GetTitle);
            this.Item9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 179, 74, 71));
            this.Item9.DrillDownPageGuid = null;
            this.Item9_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item9_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item9_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item9_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item9_SeriesLabels.ValueTypeSeparator = "-";
            this.Item9_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Item9_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart21_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart21_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart21_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart21_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart21_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Chart21_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart21.Style = new Stimulsoft.Report.Chart.StiStyle03();
            this.Chart21.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 95, 95)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text19
            // 
            this.Text19 = new Stimulsoft.Report.Components.StiText();
            this.Text19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0, 6.2, 0.6);
            this.Text19.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text19.Name = "Text19";
            this.Text19.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text19__GetValue);
            this.Text19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text19.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text19.Guid = null;
            this.Text19.Indicator = null;
            this.Text19.Interaction = null;
            this.Text19.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text19.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart22_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 245), 90);
            this.Chart22_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart22_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart22_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart22_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 150, 105)), false, true);
            this.Chart22_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 150, 105)), false, true);
            this.Chart22_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart22_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 1F, false, true, false, true);
            this.Chart22_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart22_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 1F, false, true, true);
            this.Chart22.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart22.Guid = null;
            this.Chart22.Interaction = null;
            this.Chart22_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart22_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart22_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_Legend.Visible = false;
            this.Chart22_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 225), 90);
            this.Chart22_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart22_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart22.MasterComponent = null;
            // 
            // Item12
            // 
            this.Item12 = new Stimulsoft.Report.Chart.StiClusteredBarSeries();
            this.Item12.BorderColor = System.Windows.Media.Color.FromArgb(255, 124, 69, 0);
            this.Item12.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item12__GetListOfArguments);
            this.Item12.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item12__GetListOfValues);
            this.Item12.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item12__GetTitle);
            this.Item12.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 224, 169, 61), System.Windows.Media.Color.FromArgb(255, 174, 119, 11), 90);
            this.Item12.DrillDownPageGuid = null;
            this.Item12_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item12_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Item12_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Item12_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item12_SeriesLabels.ValueTypeSeparator = "-";
            this.Item12_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 250, 205));
            this.Item12_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart22_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart22_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart22_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart22_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart22_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 250, 205));
            this.Chart22_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart22.Style = new Stimulsoft.Report.Chart.StiStyle05();
            this.Chart22.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 105, 100, 55)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 5.2, 6.6, 0.6);
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text20.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text20.Guid = null;
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart27_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart27_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart27_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart27_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart27_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 119, 145, 149)), false, true);
            this.Chart27_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 119, 145, 149)), false, true);
            this.Chart27_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart27_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 1F, false, true, false, true);
            this.Chart27_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart27_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 1F, false, true, true);
            this.Chart27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart27.Guid = null;
            this.Chart27.Interaction = null;
            this.Chart27_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart27_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart27_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_Legend.Visible = false;
            this.Chart27_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 239, 255, 255), 90);
            this.Chart27_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart27_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart27.MasterComponent = null;
            // 
            // Item15
            // 
            this.Item15 = new Stimulsoft.Report.Chart.StiStackedBarSeries();
            this.Item15.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 11, 98);
            this.Item15.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item15__GetListOfArguments);
            this.Item15.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item15__GetListOfValues);
            this.Item15.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item15__GetTitle);
            this.Item15.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 15, 111, 198), System.Windows.Media.Color.FromArgb(255, 0, 61, 148), 90);
            this.Item15.DrillDownPageGuid = null;
            this.Item15_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item15_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Item15_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Item15_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item15_SeriesLabels.ValueTypeSeparator = "-";
            this.Item15_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 219, 245, 249));
            this.Item15_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item16
            // 
            this.Item16 = new Stimulsoft.Report.Chart.StiStackedBarSeries();
            this.Item16.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 57, 117);
            this.Item16.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item16__GetListOfArguments);
            this.Item16.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item16__GetListOfValues);
            this.Item16.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item16__GetTitle);
            this.Item16.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 0, 157, 217), System.Windows.Media.Color.FromArgb(255, 0, 107, 167), 90);
            this.Item16.DrillDownPageGuid = null;
            this.Item16_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item16_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Item16_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Item16_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item16_SeriesLabels.ValueTypeSeparator = "-";
            this.Item16_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 219, 245, 249));
            this.Item16_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart27_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart27_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart27_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart27_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart27_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 219, 245, 249));
            this.Chart27_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart27.Style = new Stimulsoft.Report.Chart.StiStyle15();
            this.Chart27.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 69, 95, 99)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text21
            // 
            this.Text21 = new Stimulsoft.Report.Components.StiText();
            this.Text21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 22, 6.2, 0.6);
            this.Text21.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text21.Name = "Text21";
            this.Text21.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text21__GetValue);
            this.Text21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text21.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text21.Guid = null;
            this.Text21.Indicator = null;
            this.Text21.Interaction = null;
            this.Text21.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text21.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart28_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart28_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart28_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart28_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart28_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 155, 155)), false, true);
            this.Chart28_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 155, 155)), false, true);
            this.Chart28_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart28_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1F, false, true, false, true);
            this.Chart28_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart28_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1F, false, true, true);
            this.Chart28.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart28.Guid = null;
            this.Chart28.Interaction = null;
            this.Chart28_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart28_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart28_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_Legend.Visible = false;
            this.Chart28_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart28_Legend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Chart28_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart28.MasterComponent = null;
            // 
            // Item19
            // 
            this.Item19 = new Stimulsoft.Report.Chart.StiFullStackedBarSeries();
            this.Item19.BorderColor = System.Windows.Media.Color.FromArgb(255, 117, 151, 68);
            this.Item19.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item19__GetListOfArguments);
            this.Item19.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item19__GetListOfValues);
            this.Item19.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item19__GetTitle);
            this.Item19.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 167, 201, 118), System.Windows.Media.Color.FromArgb(255, 255, 255, 218), 0);
            this.Item19.DrillDownPageGuid = null;
            this.Item19_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item19_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Item19_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Item19_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item19_SeriesLabels.ValueTypeSeparator = "-";
            this.Item19_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Item19_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item20
            // 
            this.Item20 = new Stimulsoft.Report.Chart.StiFullStackedBarSeries();
            this.Item20.BorderColor = System.Windows.Media.Color.FromArgb(255, 100, 81, 131);
            this.Item20.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item20__GetListOfArguments);
            this.Item20.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item20__GetListOfValues);
            this.Item20.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item20__GetTitle);
            this.Item20.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 150, 131, 181), System.Windows.Media.Color.FromArgb(255, 250, 231, 255), 0);
            this.Item20.DrillDownPageGuid = null;
            this.Item20_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item20_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Item20_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Item20_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item20_SeriesLabels.ValueTypeSeparator = "-";
            this.Item20_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Item20_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart28_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart28_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart28_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart28_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart28_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart28_SeriesLabels.Font = new System.Drawing.Font("Arial", 5F);
            this.Chart28.Style = new Stimulsoft.Report.Chart.StiStyle07();
            this.Chart28.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 105, 105, 105)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text26
            // 
            this.Text26 = new Stimulsoft.Report.Components.StiText();
            this.Text26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5.2, 6.2, 0.6);
            this.Text26.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text26.Name = "Text26";
            this.Text26.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text26__GetValue);
            this.Text26.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text26.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.Text26.Guid = null;
            this.Text26.Indicator = null;
            this.Text26.Interaction = null;
            this.Text26.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text26.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text26.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text27
            // 
            this.Text27 = new Stimulsoft.Report.Components.StiText();
            this.Text27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.2, 0.6);
            this.Text27.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text27.Name = "Text27";
            this.Text27.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text27__GetValue);
            this.Text27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text27.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text27.Guid = null;
            this.Text27.Indicator = null;
            this.Text27.Interaction = null;
            this.Text27.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text27.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text27.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text28
            // 
            this.Text28 = new Stimulsoft.Report.Components.StiText();
            this.Text28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 0, 6.6, 0.6);
            this.Text28.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text28.Name = "Text28";
            this.Text28.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text28__GetValue);
            this.Text28.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text28.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text28.Guid = null;
            this.Text28.Indicator = null;
            this.Text28.Interaction = null;
            this.Text28.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text28.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text28.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text29
            // 
            this.Text29 = new Stimulsoft.Report.Components.StiText();
            this.Text29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.2, 6.2, 0.6);
            this.Text29.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text29.Name = "Text29";
            this.Text29.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text29__GetValue);
            this.Text29.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text29.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text29.Guid = null;
            this.Text29.Indicator = null;
            this.Text29.Interaction = null;
            this.Text29.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text29.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart29_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart29_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart29_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart29_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart29_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 138, 136, 125)), false, true);
            this.Chart29_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 138, 136, 125)), false, true);
            this.Chart29_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart29_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 1F, false, true, false, true);
            this.Chart29_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart29_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 1F, false, true, true);
            this.Chart29.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart29.Guid = null;
            this.Chart29.Interaction = null;
            this.Chart29_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart29_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart29_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 245), 90);
            this.Chart29_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart29_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart29.MasterComponent = null;
            // 
            // Item26
            // 
            this.Item26 = new Stimulsoft.Report.Chart.StiStackedLineSeries();
            this.Item26.LineColor = System.Windows.Media.Color.FromArgb(255, 79, 129, 189);
            this.Item26.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfArguments);
            this.Item26.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item26__GetListOfValues);
            this.Item26.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item26__GetTitle);
            this.Item26.DrillDownPageGuid = null;
            this.Item26_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item26_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 0, 39);
            this.Item26_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 129, 179, 239));
            this.Item26_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item26_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 29, 89);
            this.Item26_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 179, 229, 255));
            this.Item26_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item26_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Item26_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Item26_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item26_SeriesLabels.ValueTypeSeparator = "-";
            this.Item26_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 238, 236, 225));
            this.Item26_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item27
            // 
            this.Item27 = new Stimulsoft.Report.Chart.StiStackedLineSeries();
            this.Item27.LineColor = System.Windows.Media.Color.FromArgb(255, 192, 80, 77);
            this.Item27.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item27__GetListOfArguments);
            this.Item27.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item27__GetListOfValues);
            this.Item27.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item27__GetTitle);
            this.Item27.DrillDownPageGuid = null;
            this.Item27_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item27_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 42, 0, 0);
            this.Item27_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 130, 127));
            this.Item27_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item27_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 92, 0, 0);
            this.Item27_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 180, 177));
            this.Item27_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item27_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Item27_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Item27_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item27_SeriesLabels.ValueTypeSeparator = "-";
            this.Item27_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 238, 236, 225));
            this.Item27_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart29_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart29_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart29_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart29_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart29_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 238, 236, 225));
            this.Chart29_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart29.Style = new Stimulsoft.Report.Chart.StiStyle09();
            this.Chart29.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 88, 86, 75)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text30
            // 
            this.Text30 = new Stimulsoft.Report.Components.StiText();
            this.Text30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 10.2, 6.6, 0.6);
            this.Text30.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text30.Name = "Text30";
            this.Text30.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text30__GetValue);
            this.Text30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text30.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text30.Guid = null;
            this.Text30.Indicator = null;
            this.Text30.Interaction = null;
            this.Text30.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text30.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart30_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 246, 255), System.Windows.Media.Color.FromArgb(255, 221, 206, 240), 90);
            this.Chart30_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart30_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart30_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart30_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 81, 66, 100)), false, true);
            this.Chart30_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 81, 66, 100)), false, true);
            this.Chart30_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart30_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 1F, false, true, false, true);
            this.Chart30_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart30_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 1F, false, true, true);
            this.Chart30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart30.Guid = null;
            this.Chart30.Interaction = null;
            this.Chart30_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart30_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart30_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 246, 255), System.Windows.Media.Color.FromArgb(255, 201, 186, 220), 90);
            this.Chart30_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart30_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart30.MasterComponent = null;
            // 
            // Item30
            // 
            this.Item30 = new Stimulsoft.Report.Chart.StiLineSeries();
            this.Item30.LineColor = System.Windows.Media.Color.FromArgb(255, 72, 57, 90);
            this.Item30.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item30__GetListOfArguments);
            this.Item30.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item30__GetListOfValues);
            this.Item30.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item30__GetTitle);
            this.Item30.DrillDownPageGuid = null;
            this.Item30_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item30_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 0, 0);
            this.Item30_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 122, 107, 140));
            this.Item30_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item30_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 0, 0);
            this.Item30_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 172, 157, 190));
            this.Item30_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item30_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Item30_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Item30_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item30_SeriesLabels.ValueTypeSeparator = "-";
            this.Item30_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 181, 166, 200));
            this.Item30_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item31
            // 
            this.Item31 = new Stimulsoft.Report.Chart.StiLineSeries();
            this.Item31.LineColor = System.Windows.Media.Color.FromArgb(255, 109, 87, 137);
            this.Item31.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item31__GetListOfArguments);
            this.Item31.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item31__GetListOfValues);
            this.Item31.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item31__GetTitle);
            this.Item31.DrillDownPageGuid = null;
            this.Item31_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item31_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 0, 0);
            this.Item31_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 159, 137, 187));
            this.Item31_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item31_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 9, 0, 37);
            this.Item31_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 209, 187, 237));
            this.Item31_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item31_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Item31_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Item31_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item31_SeriesLabels.ValueTypeSeparator = "-";
            this.Item31_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 181, 166, 200));
            this.Item31_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart30_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart30_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart30_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart30_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart30_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 181, 166, 200));
            this.Chart30_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart30.Style = new Stimulsoft.Report.Chart.StiStyle04();
            this.Chart30.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 31, 16, 50)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart31_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 222, 235, 255), 90);
            this.Chart31_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart31_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart31_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart31_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 82, 95, 120)), false, true);
            this.Chart31_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 82, 95, 120)), false, true);
            this.Chart31_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart31_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 1F, false, true, false, true);
            this.Chart31_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart31_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 1F, false, true, true);
            this.Chart31.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart31.Guid = null;
            this.Chart31.Interaction = null;
            this.Chart31_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart31_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart31_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_Legend.Visible = false;
            this.Chart31_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 202, 215, 240), 90);
            this.Chart31_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart31_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart31.MasterComponent = null;
            // 
            // Item33
            // 
            this.Item33 = new Stimulsoft.Report.Chart.StiSplineSeries();
            this.Item33.LineColor = System.Windows.Media.Color.FromArgb(255, 60, 100, 148);
            this.Item33.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfArguments);
            this.Item33.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item33__GetListOfValues);
            this.Item33.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item33__GetTitle);
            this.Item33.DrillDownPageGuid = null;
            this.Item33_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item33_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 0, 48);
            this.Item33_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 160, 200, 248));
            this.Item33_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item33_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Item33_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Item33_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item33_SeriesLabels.ValueTypeSeparator = "-";
            this.Item33_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 182, 195, 220));
            this.Item33_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item34
            // 
            this.Item34 = new Stimulsoft.Report.Chart.StiSplineSeries();
            this.Item34.LineColor = System.Windows.Media.Color.FromArgb(255, 73, 120, 177);
            this.Item34.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item34__GetListOfArguments);
            this.Item34.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item34__GetListOfValues);
            this.Item34.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item34__GetTitle);
            this.Item34.DrillDownPageGuid = null;
            this.Item34_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item34_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 20, 77);
            this.Item34_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 173, 220, 255));
            this.Item34_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item34_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Item34_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Item34_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item34_SeriesLabels.ValueTypeSeparator = "-";
            this.Item34_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 182, 195, 220));
            this.Item34_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart31_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart31_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart31_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart31_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart31_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 182, 195, 220));
            this.Chart31_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart31.Style = new Stimulsoft.Report.Chart.StiStyle08();
            this.Chart31.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 32, 45, 70)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text32
            // 
            this.Text32 = new Stimulsoft.Report.Components.StiText();
            this.Text32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 10.2, 6.6, 0.6);
            this.Text32.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text32.Name = "Text32";
            this.Text32.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text32__GetValue);
            this.Text32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text32.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text32.Guid = null;
            this.Text32.Indicator = null;
            this.Text32.Interaction = null;
            this.Text32.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text32.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart33_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 249, 255, 255), 90);
            this.Chart33_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart33_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart33_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart33_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 109, 125, 127)), false, true);
            this.Chart33_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 109, 125, 127)), false, true);
            this.Chart33_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart33_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 1F, false, true, false, true);
            this.Chart33_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart33_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 1F, false, true, true);
            this.Chart33.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart33.Guid = null;
            this.Chart33.Interaction = null;
            this.Chart33_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart33_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart33_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 229, 245, 247), 90);
            this.Chart33_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart33_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart33.MasterComponent = null;
            // 
            // Item37
            // 
            this.Item37 = new Stimulsoft.Report.Chart.StiFullStackedSplineSeries();
            this.Item37.LineColor = System.Windows.Media.Color.FromArgb(255, 121, 181, 176);
            this.Item37.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item37__GetListOfArguments);
            this.Item37.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item37__GetListOfValues);
            this.Item37.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item37__GetTitle);
            this.Item37.DrillDownPageGuid = null;
            this.Item37_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item37_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 21, 81, 76);
            this.Item37_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 221, 255, 255));
            this.Item37_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item37_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Item37_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Item37_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item37_SeriesLabels.ValueTypeSeparator = "-";
            this.Item37_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 209, 225, 227));
            this.Item37_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item38
            // 
            this.Item38 = new Stimulsoft.Report.Chart.StiFullStackedSplineSeries();
            this.Item38.LineColor = System.Windows.Media.Color.FromArgb(255, 180, 188, 76);
            this.Item38.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item38__GetListOfArguments);
            this.Item38.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item38__GetListOfValues);
            this.Item38.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item38__GetTitle);
            this.Item38.DrillDownPageGuid = null;
            this.Item38_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item38_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 80, 88, 0);
            this.Item38_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 176));
            this.Item38_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item38_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Item38_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Item38_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item38_SeriesLabels.ValueTypeSeparator = "-";
            this.Item38_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 209, 225, 227));
            this.Item38_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart33_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart33_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart33_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart33_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart33_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 209, 225, 227));
            this.Chart33_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart33.Style = new Stimulsoft.Report.Chart.StiStyle10();
            this.Chart33.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 59, 75, 77)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text33
            // 
            this.Text33 = new Stimulsoft.Report.Components.StiText();
            this.Text33.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 15.6, 6.2, 0.6);
            this.Text33.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text33.Name = "Text33";
            this.Text33.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text33__GetValue);
            this.Text33.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text33.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text33.Guid = null;
            this.Text33.Indicator = null;
            this.Text33.Interaction = null;
            this.Text33.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text33.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text33.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text34
            // 
            this.Text34 = new Stimulsoft.Report.Components.StiText();
            this.Text34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 5.2, 6.2, 0.6);
            this.Text34.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text34.Name = "Text34";
            this.Text34.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text34__GetValue);
            this.Text34.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text34.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text34.Guid = null;
            this.Text34.Indicator = null;
            this.Text34.Interaction = null;
            this.Text34.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text34.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text34.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart34
            this.InitializeComponent2();
        }
        
        public void InitializeComponent2()
        {
            // 
            this.Chart34 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 5.8, 6.2, 4.4);
            this.Chart34.CustomStyleName = "";
            this.Chart34.Name = "Chart34";
            this.Chart34.Sort = new System.String[0];
            this.Chart34_Area = new Stimulsoft.Report.Chart.StiStackedSplineArea();
            this.Chart34_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 242, 238, 246), 90);
            this.Chart34_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart34_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart34_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart34_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 102, 98, 106)), false, true);
            this.Chart34_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 102, 98, 106)), false, true);
            this.Chart34_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart34_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 1F, false, true, false, true);
            this.Chart34_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart34_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 1F, false, true, true);
            this.Chart34.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart34.Guid = null;
            this.Chart34.Interaction = null;
            this.Chart34_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart34_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart34_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 222, 218, 226), 90);
            this.Chart34_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart34_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart34.MasterComponent = null;
            // 
            // Item42
            // 
            this.Item42 = new Stimulsoft.Report.Chart.StiStackedSplineSeries();
            this.Item42.LineColor = System.Windows.Media.Color.FromArgb(255, 206, 185, 102);
            this.Item42.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item42__GetListOfArguments);
            this.Item42.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item42__GetListOfValues);
            this.Item42.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item42__GetTitle);
            this.Item42.DrillDownPageGuid = null;
            this.Item42_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item42_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 106, 85, 2);
            this.Item42_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 202));
            this.Item42_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item42_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Item42_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Item42_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item42_SeriesLabels.ValueTypeSeparator = "-";
            this.Item42_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 202, 198, 206));
            this.Item42_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item43
            // 
            this.Item43 = new Stimulsoft.Report.Chart.StiStackedSplineSeries();
            this.Item43.LineColor = System.Windows.Media.Color.FromArgb(255, 156, 176, 132);
            this.Item43.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item43__GetListOfArguments);
            this.Item43.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item43__GetListOfValues);
            this.Item43.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item43__GetTitle);
            this.Item43.DrillDownPageGuid = null;
            this.Item43_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item43_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 56, 76, 32);
            this.Item43_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 232));
            this.Item43_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item43_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Item43_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Item43_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item43_SeriesLabels.ValueTypeSeparator = "-";
            this.Item43_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 202, 198, 206));
            this.Item43_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart34_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart34_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart34_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart34_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart34_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 202, 198, 206));
            this.Chart34_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart34.Style = new Stimulsoft.Report.Chart.StiStyle06();
            this.Chart34.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 52, 48, 56)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text35
            // 
            this.Text35 = new Stimulsoft.Report.Components.StiText();
            this.Text35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 15.6, 6.6, 0.6);
            this.Text35.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text35.Name = "Text35";
            this.Text35.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text35__GetValue);
            this.Text35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text35.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text35.Guid = null;
            this.Text35.Indicator = null;
            this.Text35.Interaction = null;
            this.Text35.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text35.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart35_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 221), 90);
            this.Chart35_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart35_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart35_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart35_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 128, 81)), false, true);
            this.Chart35_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 128, 81)), false, true);
            this.Chart35_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart35_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 1F, false, true, false, true);
            this.Chart35_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart35_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 1F, false, true, true);
            this.Chart35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart35.Guid = null;
            this.Chart35.Interaction = null;
            this.Chart35_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart35_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart35_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 248, 201), 90);
            this.Chart35_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart35_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart35.MasterComponent = null;
            // 
            // Item46
            // 
            this.Item46 = new Stimulsoft.Report.Chart.StiStackedAreaSeries();
            this.Item46.LineColor = System.Windows.Media.Color.FromArgb(255, 218, 165, 32);
            this.Item46.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item46__GetListOfArguments);
            this.Item46.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item46__GetListOfValues);
            this.Item46.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item46__GetTitle);
            this.Item46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 218, 165, 32));
            this.Item46.DrillDownPageGuid = null;
            this.Item46_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item46_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 68, 15, 0);
            this.Item46_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 215, 82));
            this.Item46_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item46_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 118, 65, 0);
            this.Item46_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 132));
            this.Item46_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item46_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Item46_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Item46_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item46_SeriesLabels.ValueTypeSeparator = "-";
            this.Item46_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 228, 181));
            this.Item46_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item47
            // 
            this.Item47 = new Stimulsoft.Report.Chart.StiStackedAreaSeries();
            this.Item47.LineColor = System.Windows.Media.Color.FromArgb(255, 240, 230, 140);
            this.Item47.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item47__GetListOfArguments);
            this.Item47.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item47__GetListOfValues);
            this.Item47.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item47__GetTitle);
            this.Item47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 240, 230, 140));
            this.Item47.DrillDownPageGuid = null;
            this.Item47_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item47_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 90, 80, 0);
            this.Item47_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 190));
            this.Item47_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item47_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 140, 130, 40);
            this.Item47_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 240));
            this.Item47_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item47_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Item47_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Item47_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item47_SeriesLabels.ValueTypeSeparator = "-";
            this.Item47_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 228, 181));
            this.Item47_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart35_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart35_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart35_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart35_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart35_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 228, 181));
            this.Chart35_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart35.Style = new Stimulsoft.Report.Chart.StiStyle12();
            this.Chart35.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 105, 78, 31)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text36
            // 
            this.Text36 = new Stimulsoft.Report.Components.StiText();
            this.Text36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 15.6, 6.6, 0.6);
            this.Text36.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text36.Name = "Text36";
            this.Text36.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text36__GetValue);
            this.Text36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text36.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text36.Guid = null;
            this.Text36.Indicator = null;
            this.Text36.Interaction = null;
            this.Text36.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text36.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart36_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 223), System.Windows.Media.Color.FromArgb(255, 255, 232, 183), 90);
            this.Chart36_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart36_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart36_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart36_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 125, 92, 43)), false, true);
            this.Chart36_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 125, 92, 43)), false, true);
            this.Chart36_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart36_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 1F, false, true, false, true);
            this.Chart36_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart36_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 1F, false, true, true);
            this.Chart36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 243));
            this.Chart36.Guid = null;
            this.Chart36.Interaction = null;
            this.Chart36_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart36_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart36_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 223), System.Windows.Media.Color.FromArgb(255, 245, 212, 163), 90);
            this.Chart36_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart36_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart36.MasterComponent = null;
            // 
            // Item50
            // 
            this.Item50 = new Stimulsoft.Report.Chart.StiAreaSeries();
            this.Item50.LineColor = System.Windows.Media.Color.FromArgb(255, 204, 77, 92);
            this.Item50.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item50__GetListOfArguments);
            this.Item50.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item50__GetListOfValues);
            this.Item50.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item50__GetTitle);
            this.Item50.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 204, 77, 92));
            this.Item50.DrillDownPageGuid = null;
            this.Item50_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item50_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 54, 0, 0);
            this.Item50_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 254, 127, 142));
            this.Item50_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item50_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 104, 0, 0);
            this.Item50_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 177, 192));
            this.Item50_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item50_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Item50_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Item50_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item50_SeriesLabels.ValueTypeSeparator = "-";
            this.Item50_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 225, 192, 143));
            this.Item50_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item51
            // 
            this.Item51 = new Stimulsoft.Report.Chart.StiAreaSeries();
            this.Item51.LineColor = System.Windows.Media.Color.FromArgb(255, 255, 111, 97);
            this.Item51.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item51__GetListOfArguments);
            this.Item51.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item51__GetListOfValues);
            this.Item51.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item51__GetTitle);
            this.Item51.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 255, 111, 97));
            this.Item51.DrillDownPageGuid = null;
            this.Item51_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item51_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 0, 0);
            this.Item51_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 161, 147));
            this.Item51_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item51_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 155, 11, 0);
            this.Item51_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 211, 197));
            this.Item51_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item51_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Item51_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Item51_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item51_SeriesLabels.ValueTypeSeparator = "-";
            this.Item51_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 225, 192, 143));
            this.Item51_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart36_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart36_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart36_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart36_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart36_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 225, 192, 143));
            this.Chart36_SeriesLabels.Font = new System.Drawing.Font("Arial", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.Chart36.Style = new Stimulsoft.Report.Chart.StiStyle11();
            this.Chart36.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 75, 42, 0)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text37
            // 
            this.Text37 = new Stimulsoft.Report.Components.StiText();
            this.Text37.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 22, 6.2, 0.6);
            this.Text37.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text37.Name = "Text37";
            this.Text37.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text37__GetValue);
            this.Text37.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text37.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text37.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text37.Guid = null;
            this.Text37.Indicator = null;
            this.Text37.Interaction = null;
            this.Text37.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text37.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart37_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 241), 90);
            this.Chart37.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart37.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart37.Guid = null;
            this.Chart37.Interaction = null;
            this.Chart37_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart37_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_Legend.Columns = 8;
            this.Chart37_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.LeftOutside;
            this.Chart37_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart37_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 221), 90);
            this.Chart37_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart37_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart37.MasterComponent = null;
            // 
            // Item54
            // 
            this.Item54 = new Stimulsoft.Report.Chart.StiDoughnutSeries();
            this.Item54.BorderColor = System.Windows.Media.Color.FromArgb(255, 140, 62, 0);
            this.Item54.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item54__GetListOfArguments);
            this.Item54.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item54__GetListOfValues);
            this.Item54.ShowShadow = false;
            this.Item54.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item54__GetTitle);
            this.Item54.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 240, 162, 46), System.Windows.Media.Color.FromArgb(255, 190, 112, 0), 0);
            this.Item54.DrillDownPageGuid = null;
            this.Item54_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item54_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Item54_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Item54_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item54_SeriesLabels.ValueTypeSeparator = "-";
            this.Item54_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 251, 238, 201));
            this.Item54_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item55
            // 
            this.Item55 = new Stimulsoft.Report.Chart.StiDoughnutSeries();
            this.Item55.BorderColor = System.Windows.Media.Color.FromArgb(255, 65, 0, 0);
            this.Item55.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item55__GetListOfArguments);
            this.Item55.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item55__GetListOfValues);
            this.Item55.ShowShadow = false;
            this.Item55.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item55__GetTitle);
            this.Item55.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 165, 100, 78), System.Windows.Media.Color.FromArgb(255, 115, 50, 28), 0);
            this.Item55.DrillDownPageGuid = null;
            this.Item55_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item55_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Item55_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Item55_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item55_SeriesLabels.ValueTypeSeparator = "-";
            this.Item55_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 251, 238, 201));
            this.Item55_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart37_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterPieLabels();
            this.Chart37_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart37_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart37_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart37_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 251, 238, 201));
            this.Chart37_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart37.Style = new Stimulsoft.Report.Chart.StiStyle14();
            this.Chart37.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 101, 88, 51)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text38
            // 
            this.Text38 = new Stimulsoft.Report.Components.StiText();
            this.Text38.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.2, 22, 6.2, 0.6);
            this.Text38.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text38.Name = "Text38";
            this.Text38.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text38__GetValue);
            this.Text38.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text38.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text38.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text38.Guid = null;
            this.Text38.Indicator = null;
            this.Text38.Interaction = null;
            this.Text38.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text38.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart38_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 252, 250, 248), 90);
            this.Chart38.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart38.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart38.Guid = null;
            this.Chart38.Interaction = null;
            this.Chart38_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart38_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_Legend.Columns = 5;
            this.Chart38_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.LeftOutside;
            this.Chart38_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart38_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 232, 230, 228), 90);
            this.Chart38_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart38_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart38.MasterComponent = null;
            // 
            // Item58
            // 
            this.Item58 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item58.BorderColor = System.Windows.Media.Color.FromArgb(255, 51, 58, 68);
            this.Item58.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item58__GetListOfArguments);
            this.Item58.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item58__GetListOfValues);
            this.Item58.ShowShadow = false;
            this.Item58.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item58__GetTitle);
            this.Item58.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 151, 158, 168), System.Windows.Media.Color.FromArgb(255, 101, 108, 118), 0);
            this.Item58.DrillDownPageGuid = null;
            this.Item58_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item58_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Item58_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Item58_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item58_SeriesLabels.ValueTypeSeparator = "-";
            this.Item58_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 212, 210, 208));
            this.Item58_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart38_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterPieLabels();
            this.Chart38_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart38_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart38_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart38_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 212, 210, 208));
            this.Chart38_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart38.Style = new Stimulsoft.Report.Chart.StiStyle13();
            this.Chart38.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 62, 60, 58)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            this.Styles.ExcelSheetValue = null;
            this.Styles.Interaction = null;
            this.Styles.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Styles_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Styles_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Styles_Watermark.Image = null;
            this.Styles_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
            // 
            // Page5
            // 
            this.Page5 = new Stimulsoft.Report.Components.StiPage();
            this.Page5.Guid = "4d9587631e1146f394b3b07b72e9d024";
            this.Page5.Name = "Page5";
            this.Page5.PageHeight = 29.7;
            this.Page5.PageWidth = 21;
            this.Page5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Page5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
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
            this.Chart32_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart32_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart32_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart32_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart32_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart32_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart32_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart32_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart32_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart32_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart32_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart32.Guid = null;
            this.Chart32.Interaction = null;
            this.Chart32_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart32_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart32_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart32_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart32_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart32_Legend.Visible = false;
            this.Chart32_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart32_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart32_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart32.MasterComponent = null;
            // 
            // Item61
            // 
            this.Item61 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item61.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item61.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item61__GetListOfArguments);
            this.Item61.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item61__GetListOfValues);
            this.Item61.ShowShadow = false;
            this.Item61.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item61__GetTitle);
            this.Item61.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 144, 67, 3), System.Windows.Media.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item61.DrillDownPageGuid = null;
            this.Item61_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item61_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item61_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item61_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item61_SeriesLabels.ValueTypeSeparator = "-";
            this.Item61_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item61_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item62
            // 
            this.Item62 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item62.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item62.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item62__GetListOfArguments);
            this.Item62.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item62__GetListOfValues);
            this.Item62.ShowShadow = false;
            this.Item62.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item62__GetTitle);
            this.Item62.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 181, 90, 15), System.Windows.Media.Color.FromArgb(255, 231, 140, 65), 0, 0.5F, 1F);
            this.Item62.DrillDownPageGuid = null;
            this.Item62_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item62_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item62_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item62_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item62_SeriesLabels.ValueTypeSeparator = "-";
            this.Item62_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item62_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart32_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart32_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart32_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart32.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart32.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text31
            // 
            this.Text31 = new Stimulsoft.Report.Components.StiText();
            this.Text31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.2, 0.6);
            this.Text31.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text31.Name = "Text31";
            this.Text31.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text31__GetValue);
            this.Text31.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text31.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text31.Guid = null;
            this.Text31.Indicator = null;
            this.Text31.Interaction = null;
            this.Text31.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text31.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text31.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text39
            // 
            this.Text39 = new Stimulsoft.Report.Components.StiText();
            this.Text39.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 0, 6.2, 0.6);
            this.Text39.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text39.Name = "Text39";
            this.Text39.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text39__GetValue);
            this.Text39.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text39.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text39.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text39.Guid = null;
            this.Text39.Indicator = null;
            this.Text39.Interaction = null;
            this.Text39.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text39.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text39.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text40
            // 
            this.Text40 = new Stimulsoft.Report.Components.StiText();
            this.Text40.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0, 6.2, 0.6);
            this.Text40.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text40.Name = "Text40";
            this.Text40.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text40__GetValue);
            this.Text40.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text40.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text40.Guid = null;
            this.Text40.Indicator = null;
            this.Text40.Interaction = null;
            this.Text40.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text40.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text40.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text41
            // 
            this.Text41 = new Stimulsoft.Report.Components.StiText();
            this.Text41.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5, 6.2, 0.6);
            this.Text41.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text41.Name = "Text41";
            this.Text41.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text41__GetValue);
            this.Text41.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text41.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text41.Guid = null;
            this.Text41.Indicator = null;
            this.Text41.Interaction = null;
            this.Text41.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text41.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text41.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text42
            // 
            this.Text42 = new Stimulsoft.Report.Components.StiText();
            this.Text42.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 5, 6.2, 0.6);
            this.Text42.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text42.Name = "Text42";
            this.Text42.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text42__GetValue);
            this.Text42.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text42.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text42.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text42.Guid = null;
            this.Text42.Indicator = null;
            this.Text42.Interaction = null;
            this.Text42.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text42.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text42.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text43
            // 
            this.Text43 = new Stimulsoft.Report.Components.StiText();
            this.Text43.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 5, 6.2, 0.6);
            this.Text43.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text43.Name = "Text43";
            this.Text43.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text43__GetValue);
            this.Text43.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text43.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text43.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text43.Guid = null;
            this.Text43.Indicator = null;
            this.Text43.Interaction = null;
            this.Text43.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text43.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text43.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text44
            // 
            this.Text44 = new Stimulsoft.Report.Components.StiText();
            this.Text44.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10, 6.2, 0.6);
            this.Text44.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text44.Name = "Text44";
            this.Text44.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text44__GetValue);
            this.Text44.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text44.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text44.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text44.Guid = null;
            this.Text44.Indicator = null;
            this.Text44.Interaction = null;
            this.Text44.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text44.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text44.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text45
            // 
            this.Text45 = new Stimulsoft.Report.Components.StiText();
            this.Text45.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 10, 6.2, 0.6);
            this.Text45.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text45.Name = "Text45";
            this.Text45.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text45__GetValue);
            this.Text45.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text45.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text45.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text45.Guid = null;
            this.Text45.Indicator = null;
            this.Text45.Interaction = null;
            this.Text45.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text45.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text45.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text46
            // 
            this.Text46 = new Stimulsoft.Report.Components.StiText();
            this.Text46.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 10, 6.2, 0.6);
            this.Text46.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text46.Name = "Text46";
            this.Text46.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text46__GetValue);
            this.Text46.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text46.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text46.Guid = null;
            this.Text46.Indicator = null;
            this.Text46.Interaction = null;
            this.Text46.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text46.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text46.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text47
            // 
            this.Text47 = new Stimulsoft.Report.Components.StiText();
            this.Text47.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 15, 6.2, 0.6);
            this.Text47.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text47.Name = "Text47";
            this.Text47.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text47__GetValue);
            this.Text47.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text47.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text47.Guid = null;
            this.Text47.Indicator = null;
            this.Text47.Interaction = null;
            this.Text47.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text47.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text47.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text48
            // 
            this.Text48 = new Stimulsoft.Report.Components.StiText();
            this.Text48.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 15, 6.2, 0.6);
            this.Text48.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text48.Name = "Text48";
            this.Text48.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text48__GetValue);
            this.Text48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text48.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text48.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text48.Guid = null;
            this.Text48.Indicator = null;
            this.Text48.Interaction = null;
            this.Text48.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text48.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text48.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text49
            // 
            this.Text49 = new Stimulsoft.Report.Components.StiText();
            this.Text49.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 15, 6.2, 0.6);
            this.Text49.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text49.Name = "Text49";
            this.Text49.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text49__GetValue);
            this.Text49.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text49.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text49.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text49.Guid = null;
            this.Text49.Indicator = null;
            this.Text49.Interaction = null;
            this.Text49.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text49.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text49.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text50
            // 
            this.Text50 = new Stimulsoft.Report.Components.StiText();
            this.Text50.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20, 6.2, 0.6);
            this.Text50.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text50.Name = "Text50";
            this.Text50.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text50__GetValue);
            this.Text50.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text50.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text50.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text50.Guid = null;
            this.Text50.Indicator = null;
            this.Text50.Interaction = null;
            this.Text50.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text50.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text50.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text51
            // 
            this.Text51 = new Stimulsoft.Report.Components.StiText();
            this.Text51.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 20, 6.2, 0.6);
            this.Text51.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text51.Name = "Text51";
            this.Text51.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text51__GetValue);
            this.Text51.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text51.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text51.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text51.Guid = null;
            this.Text51.Indicator = null;
            this.Text51.Interaction = null;
            this.Text51.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text51.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text51.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text52
            // 
            this.Text52 = new Stimulsoft.Report.Components.StiText();
            this.Text52.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 20, 6.2, 0.6);
            this.Text52.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text52.Name = "Text52";
            this.Text52.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text52__GetValue);
            this.Text52.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text52.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text52.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text52.Guid = null;
            this.Text52.Indicator = null;
            this.Text52.Interaction = null;
            this.Text52.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text52.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart39_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart39_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart39_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart39_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart39_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart39_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 145, 145)), true, true);
            this.Chart39_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 145, 145)), true, true);
            this.Chart39_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart39_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, false, true);
            this.Chart39_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart39_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, true);
            this.Chart39.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart39.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart39.Guid = null;
            this.Chart39.Interaction = null;
            this.Chart39_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart39_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart39_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart39_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart39_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart39_Legend.Visible = false;
            this.Chart39_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart39_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart39_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart39.MasterComponent = null;
            // 
            // Item79
            // 
            this.Item79 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item79.BorderColor = System.Windows.Media.Color.FromArgb(255, 28, 45, 65);
            this.Item79.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item79__GetListOfArguments);
            this.Item79.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item79__GetListOfValues);
            this.Item79.ShowShadow = false;
            this.Item79.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item79__GetTitle);
            this.Item79.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 128, 145, 165), System.Windows.Media.Color.FromArgb(255, 178, 195, 215), 0, 0.5F, 1F);
            this.Item79.DrillDownPageGuid = null;
            this.Item79_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item79_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item79_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item79_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item79_SeriesLabels.ValueTypeSeparator = "-";
            this.Item79_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Item79_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item80
            // 
            this.Item80 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item80.BorderColor = System.Windows.Media.Color.FromArgb(255, 71, 23, 22);
            this.Item80.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item80__GetListOfArguments);
            this.Item80.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item80__GetListOfValues);
            this.Item80.ShowShadow = false;
            this.Item80.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item80__GetTitle);
            this.Item80.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 171, 123, 122), System.Windows.Media.Color.FromArgb(255, 221, 173, 172), 0, 0.5F, 1F);
            this.Item80.DrillDownPageGuid = null;
            this.Item80_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item80_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item80_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item80_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item80_SeriesLabels.ValueTypeSeparator = "-";
            this.Item80_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Item80_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart39_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart39_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart39_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart39.Style = new Stimulsoft.Report.Chart.StiStyle02();
            this.Chart39.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 95, 95)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart40_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart40_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart40_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart40_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart40_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 95, 95), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart40_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 145, 145)), true, true);
            this.Chart40_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 145, 145)), true, true);
            this.Chart40_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart40_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, false, true);
            this.Chart40_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart40_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 95, 95), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 95, 95), 1F, false, true, true);
            this.Chart40.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart40.Guid = null;
            this.Chart40.Interaction = null;
            this.Chart40_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart40_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart40_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart40_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart40_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Chart40_Legend.Visible = false;
            this.Chart40_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart40_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart40_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart40.MasterComponent = null;
            // 
            // Item82
            // 
            this.Item82 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item82.BorderColor = System.Windows.Media.Color.FromArgb(255, 50, 0, 0);
            this.Item82.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item82__GetListOfArguments);
            this.Item82.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item82__GetListOfValues);
            this.Item82.ShowShadow = false;
            this.Item82.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item82__GetTitle);
            this.Item82.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 150, 61, 59));
            this.Item82.DrillDownPageGuid = null;
            this.Item82_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item82_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item82_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item82_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item82_SeriesLabels.ValueTypeSeparator = "-";
            this.Item82_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Item82_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item83
            // 
            this.Item83 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item83.BorderColor = System.Windows.Media.Color.FromArgb(255, 79, 0, 0);
            this.Item83.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item83__GetListOfArguments);
            this.Item83.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item83__GetListOfValues);
            this.Item83.ShowShadow = false;
            this.Item83.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item83__GetTitle);
            this.Item83.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 179, 74, 71));
            this.Item83.DrillDownPageGuid = null;
            this.Item83_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item83_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item83_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 95, 95);
            this.Item83_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item83_SeriesLabels.ValueTypeSeparator = "-";
            this.Item83_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 245, 245));
            this.Item83_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart40_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart40_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart40_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart40.Style = new Stimulsoft.Report.Chart.StiStyle03();
            this.Chart40.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 95, 95)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart41_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart41_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 246, 255), System.Windows.Media.Color.FromArgb(255, 221, 206, 240), 90);
            this.Chart41_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart41_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart41_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 31, 16, 50), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart41_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 81, 66, 100)), true, true);
            this.Chart41_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 81, 66, 100)), true, true);
            this.Chart41_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart41_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 1F, false, true, false, true);
            this.Chart41_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart41_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 31, 16, 50), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 31, 16, 50), 1F, false, true, true);
            this.Chart41.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart41.Guid = null;
            this.Chart41.Interaction = null;
            this.Chart41_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart41_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart41_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart41_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart41_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Chart41_Legend.Visible = false;
            this.Chart41_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 246, 255), System.Windows.Media.Color.FromArgb(255, 201, 186, 220), 90);
            this.Chart41_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart41_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart41.MasterComponent = null;
            // 
            // Item85
            // 
            this.Item85 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item85.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 0, 0);
            this.Item85.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item85__GetListOfArguments);
            this.Item85.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item85__GetListOfValues);
            this.Item85.ShowShadow = false;
            this.Item85.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item85__GetTitle);
            this.Item85.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 72, 57, 90), System.Windows.Media.Color.FromArgb(255, 22, 7, 40), 0);
            this.Item85.DrillDownPageGuid = null;
            this.InitializeComponent3();
        }
        
        public void InitializeComponent3()
        {
            this.Item85_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item85_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Item85_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Item85_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item85_SeriesLabels.ValueTypeSeparator = "-";
            this.Item85_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 181, 166, 200));
            this.Item85_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item86
            // 
            this.Item86 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item86.BorderColor = System.Windows.Media.Color.FromArgb(255, 9, 0, 37);
            this.Item86.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item86__GetListOfArguments);
            this.Item86.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item86__GetListOfValues);
            this.Item86.ShowShadow = false;
            this.Item86.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item86__GetTitle);
            this.Item86.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 109, 87, 137), System.Windows.Media.Color.FromArgb(255, 59, 37, 87), 0);
            this.Item86.DrillDownPageGuid = null;
            this.Item86_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item86_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Item86_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 31, 16, 50);
            this.Item86_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item86_SeriesLabels.ValueTypeSeparator = "-";
            this.Item86_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 181, 166, 200));
            this.Item86_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart41_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart41_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart41_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart41.Style = new Stimulsoft.Report.Chart.StiStyle04();
            this.Chart41.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 31, 16, 50)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart42_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart42_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 245), 90);
            this.Chart42_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart42_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart42_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 105, 100, 55), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart42_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 150, 105)), true, true);
            this.Chart42_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 150, 105)), true, true);
            this.Chart42_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart42_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 1F, false, true, false, true);
            this.Chart42_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart42_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 100, 55), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 100, 55), 1F, false, true, true);
            this.Chart42.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart42.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart42.Guid = null;
            this.Chart42.Interaction = null;
            this.Chart42_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart42_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart42_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart42_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart42_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Chart42_Legend.Visible = false;
            this.Chart42_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 225), 90);
            this.Chart42_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart42_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart42.MasterComponent = null;
            // 
            // Item88
            // 
            this.Item88 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item88.BorderColor = System.Windows.Media.Color.FromArgb(255, 124, 69, 0);
            this.Item88.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item88__GetListOfArguments);
            this.Item88.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item88__GetListOfValues);
            this.Item88.ShowShadow = false;
            this.Item88.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item88__GetTitle);
            this.Item88.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 224, 169, 61), System.Windows.Media.Color.FromArgb(255, 174, 119, 11), 0);
            this.Item88.DrillDownPageGuid = null;
            this.Item88_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item88_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Item88_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Item88_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item88_SeriesLabels.ValueTypeSeparator = "-";
            this.Item88_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 250, 205));
            this.Item88_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item89
            // 
            this.Item89 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item89.BorderColor = System.Windows.Media.Color.FromArgb(255, 80, 81, 0);
            this.Item89.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item89__GetListOfArguments);
            this.Item89.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item89__GetListOfValues);
            this.Item89.ShowShadow = false;
            this.Item89.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item89__GetTitle);
            this.Item89.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 180, 181, 0), System.Windows.Media.Color.FromArgb(255, 130, 131, 0), 0);
            this.Item89.DrillDownPageGuid = null;
            this.Item89_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item89_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Item89_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 100, 55);
            this.Item89_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item89_SeriesLabels.ValueTypeSeparator = "-";
            this.Item89_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 250, 205));
            this.Item89_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart42_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart42_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart42_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart42.Style = new Stimulsoft.Report.Chart.StiStyle05();
            this.Chart42.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 105, 100, 55)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart43_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart43_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 242, 238, 246), 90);
            this.Chart43_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart43_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart43_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 52, 48, 56), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart43_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 102, 98, 106)), true, true);
            this.Chart43_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 102, 98, 106)), true, true);
            this.Chart43_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart43_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 1F, false, true, false, true);
            this.Chart43_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart43_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 52, 48, 56), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 52, 48, 56), 1F, false, true, true);
            this.Chart43.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart43.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart43.Guid = null;
            this.Chart43.Interaction = null;
            this.Chart43_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart43_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart43_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart43_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart43_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Chart43_Legend.Visible = false;
            this.Chart43_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 222, 218, 226), 90);
            this.Chart43_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart43_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart43.MasterComponent = null;
            // 
            // Item91
            // 
            this.Item91 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item91.BorderColor = System.Windows.Media.Color.FromArgb(255, 106, 85, 2);
            this.Item91.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item91__GetListOfArguments);
            this.Item91.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item91__GetListOfValues);
            this.Item91.ShowShadow = false;
            this.Item91.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item91__GetTitle);
            this.Item91.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 206, 185, 102));
            this.Item91.DrillDownPageGuid = null;
            this.Item91_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item91_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Item91_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Item91_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item91_SeriesLabels.ValueTypeSeparator = "-";
            this.Item91_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 202, 198, 206));
            this.Item91_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item92
            // 
            this.Item92 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item92.BorderColor = System.Windows.Media.Color.FromArgb(255, 56, 76, 32);
            this.Item92.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item92__GetListOfArguments);
            this.Item92.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item92__GetListOfValues);
            this.Item92.ShowShadow = false;
            this.Item92.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item92__GetTitle);
            this.Item92.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 156, 176, 132));
            this.Item92.DrillDownPageGuid = null;
            this.Item92_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item92_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Item92_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 52, 48, 56);
            this.Item92_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item92_SeriesLabels.ValueTypeSeparator = "-";
            this.Item92_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 202, 198, 206));
            this.Item92_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart43_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart43_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart43_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart43.Style = new Stimulsoft.Report.Chart.StiStyle06();
            this.Chart43.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 52, 48, 56)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart44_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart44_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart44_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart44_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart44_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 105, 105, 105), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart44_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 155, 155)), true, true);
            this.Chart44_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 155, 155)), true, true);
            this.Chart44_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart44_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1F, false, true, false, true);
            this.Chart44_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart44_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 105, 105), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1F, false, true, true);
            this.Chart44.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart44.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart44.Guid = null;
            this.Chart44.Interaction = null;
            this.Chart44_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart44_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart44_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart44_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart44_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Chart44_Legend.Visible = false;
            this.Chart44_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart44_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart44_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart44.MasterComponent = null;
            // 
            // Item94
            // 
            this.Item94 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item94.BorderColor = System.Windows.Media.Color.FromArgb(255, 117, 151, 68);
            this.Item94.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item94__GetListOfArguments);
            this.Item94.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item94__GetListOfValues);
            this.Item94.ShowShadow = false;
            this.Item94.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item94__GetTitle);
            this.Item94.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 167, 201, 118), System.Windows.Media.Color.FromArgb(255, 255, 255, 218), -90);
            this.Item94.DrillDownPageGuid = null;
            this.Item94_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item94_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Item94_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Item94_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item94_SeriesLabels.ValueTypeSeparator = "-";
            this.Item94_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Item94_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item95
            // 
            this.Item95 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item95.BorderColor = System.Windows.Media.Color.FromArgb(255, 100, 81, 131);
            this.Item95.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item95__GetListOfArguments);
            this.Item95.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item95__GetListOfValues);
            this.Item95.ShowShadow = false;
            this.Item95.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item95__GetTitle);
            this.Item95.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 150, 131, 181), System.Windows.Media.Color.FromArgb(255, 250, 231, 255), -90);
            this.Item95.DrillDownPageGuid = null;
            this.Item95_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item95_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Item95_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 105, 105);
            this.Item95_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item95_SeriesLabels.ValueTypeSeparator = "-";
            this.Item95_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Item95_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart44_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart44_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart44_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart44.Style = new Stimulsoft.Report.Chart.StiStyle07();
            this.Chart44.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 105, 105, 105)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart45_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart45_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 222, 235, 255), 90);
            this.Chart45_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart45_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart45_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 32, 45, 70), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart45_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 82, 95, 120)), true, true);
            this.Chart45_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 82, 95, 120)), true, true);
            this.Chart45_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart45_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 1F, false, true, false, true);
            this.Chart45_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart45_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 32, 45, 70), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 32, 45, 70), 1F, false, true, true);
            this.Chart45.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart45.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart45.Guid = null;
            this.Chart45.Interaction = null;
            this.Chart45_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart45_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart45_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart45_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart45_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Chart45_Legend.Visible = false;
            this.Chart45_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 202, 215, 240), 90);
            this.Chart45_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart45_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart45.MasterComponent = null;
            // 
            // Item97
            // 
            this.Item97 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item97.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 0, 48);
            this.Item97.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item97__GetListOfArguments);
            this.Item97.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item97__GetListOfValues);
            this.Item97.ShowShadow = false;
            this.Item97.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item97__GetTitle);
            this.Item97.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 60, 100, 148));
            this.Item97.DrillDownPageGuid = null;
            this.Item97_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item97_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Item97_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Item97_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item97_SeriesLabels.ValueTypeSeparator = "-";
            this.Item97_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 182, 195, 220));
            this.Item97_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item98
            // 
            this.Item98 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item98.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 20, 77);
            this.Item98.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item98__GetListOfArguments);
            this.Item98.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item98__GetListOfValues);
            this.Item98.ShowShadow = false;
            this.Item98.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item98__GetTitle);
            this.Item98.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 73, 120, 177));
            this.Item98.DrillDownPageGuid = null;
            this.Item98_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item98_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Item98_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 32, 45, 70);
            this.Item98_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item98_SeriesLabels.ValueTypeSeparator = "-";
            this.Item98_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 182, 195, 220));
            this.Item98_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart45_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart45_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart45_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart45.Style = new Stimulsoft.Report.Chart.StiStyle08();
            this.Chart45.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 32, 45, 70)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart46_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart46_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart46_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart46_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart46_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 88, 86, 75), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart46_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 138, 136, 125)), true, true);
            this.Chart46_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 138, 136, 125)), true, true);
            this.Chart46_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart46_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 1F, false, true, false, true);
            this.Chart46_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart46_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 88, 86, 75), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 88, 86, 75), 1F, false, true, true);
            this.Chart46.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart46.Guid = null;
            this.Chart46.Interaction = null;
            this.Chart46_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart46_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart46_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart46_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart46_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Chart46_Legend.Visible = false;
            this.Chart46_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 245), 90);
            this.Chart46_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart46_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart46.MasterComponent = null;
            // 
            // Item100
            // 
            this.Item100 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item100.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 29, 89);
            this.Item100.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item100__GetListOfArguments);
            this.Item100.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item100__GetListOfValues);
            this.Item100.ShowShadow = false;
            this.Item100.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item100__GetTitle);
            this.Item100.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 79, 129, 189), System.Windows.Media.Color.FromArgb(255, 29, 79, 139), 0);
            this.Item100.DrillDownPageGuid = null;
            this.Item100_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item100_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Item100_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Item100_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item100_SeriesLabels.ValueTypeSeparator = "-";
            this.Item100_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 238, 236, 225));
            this.Item100_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item101
            // 
            this.Item101 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item101.BorderColor = System.Windows.Media.Color.FromArgb(255, 92, 0, 0);
            this.Item101.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item101__GetListOfArguments);
            this.Item101.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item101__GetListOfValues);
            this.Item101.ShowShadow = false;
            this.Item101.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item101__GetTitle);
            this.Item101.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 192, 80, 77), System.Windows.Media.Color.FromArgb(255, 142, 30, 27), 0);
            this.Item101.DrillDownPageGuid = null;
            this.Item101_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item101_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Item101_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 88, 86, 75);
            this.Item101_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item101_SeriesLabels.ValueTypeSeparator = "-";
            this.Item101_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(238, 238, 236, 225));
            this.Item101_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart46_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart46_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart46_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart46.Style = new Stimulsoft.Report.Chart.StiStyle09();
            this.Chart46.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 88, 86, 75)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart47_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart47_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 249, 255, 255), 90);
            this.Chart47_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart47_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart47_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 59, 75, 77), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart47_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 109, 125, 127)), true, true);
            this.Chart47_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 109, 125, 127)), true, true);
            this.Chart47_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart47_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 1F, false, true, false, true);
            this.Chart47_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart47_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 59, 75, 77), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 59, 75, 77), 1F, false, true, true);
            this.Chart47.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart47.Guid = null;
            this.Chart47.Interaction = null;
            this.Chart47_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart47_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart47_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart47_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart47_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Chart47_Legend.Visible = false;
            this.Chart47_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 229, 245, 247), 90);
            this.Chart47_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart47_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart47.MasterComponent = null;
            // 
            // Item103
            // 
            this.Item103 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item103.BorderColor = System.Windows.Media.Color.FromArgb(255, 21, 81, 76);
            this.Item103.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item103__GetListOfArguments);
            this.Item103.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item103__GetListOfValues);
            this.Item103.ShowShadow = false;
            this.Item103.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item103__GetTitle);
            this.Item103.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 121, 181, 176), System.Windows.Media.Color.FromArgb(255, 71, 131, 126), 0);
            this.Item103.DrillDownPageGuid = null;
            this.Item103_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item103_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Item103_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Item103_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item103_SeriesLabels.ValueTypeSeparator = "-";
            this.Item103_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 209, 225, 227));
            this.Item103_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item104
            // 
            this.Item104 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item104.BorderColor = System.Windows.Media.Color.FromArgb(255, 80, 88, 0);
            this.Item104.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item104__GetListOfArguments);
            this.Item104.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item104__GetListOfValues);
            this.Item104.ShowShadow = false;
            this.Item104.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item104__GetTitle);
            this.Item104.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 180, 188, 76), System.Windows.Media.Color.FromArgb(255, 130, 138, 26), 0);
            this.Item104.DrillDownPageGuid = null;
            this.Item104_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item104_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Item104_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 59, 75, 77);
            this.Item104_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item104_SeriesLabels.ValueTypeSeparator = "-";
            this.Item104_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 209, 225, 227));
            this.Item104_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart47_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart47_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart47_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart47.Style = new Stimulsoft.Report.Chart.StiStyle10();
            this.Chart47.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 59, 75, 77)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart48_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart48_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 223), System.Windows.Media.Color.FromArgb(255, 255, 232, 183), 90);
            this.Chart48_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart48_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart48_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 75, 42, 0), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart48_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 125, 92, 43)), true, true);
            this.Chart48_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 125, 92, 43)), true, true);
            this.Chart48_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart48_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 1F, false, true, false, true);
            this.Chart48_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart48_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 75, 42, 0), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 75, 42, 0), 1F, false, true, true);
            this.Chart48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart48.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 243));
            this.Chart48.Guid = null;
            this.Chart48.Interaction = null;
            this.Chart48_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart48_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart48_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart48_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart48_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Chart48_Legend.Visible = false;
            this.Chart48_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 223), System.Windows.Media.Color.FromArgb(255, 245, 212, 163), 90);
            this.Chart48_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart48_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart48.MasterComponent = null;
            // 
            // Item106
            // 
            this.Item106 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item106.BorderColor = System.Windows.Media.Color.FromArgb(255, 104, 0, 0);
            this.Item106.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item106__GetListOfArguments);
            this.Item106.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item106__GetListOfValues);
            this.Item106.ShowShadow = false;
            this.Item106.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item106__GetTitle);
            this.Item106.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 204, 77, 92), System.Windows.Media.Color.FromArgb(255, 154, 27, 42), 0);
            this.Item106.DrillDownPageGuid = null;
            this.Item106_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item106_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Item106_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Item106_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item106_SeriesLabels.ValueTypeSeparator = "-";
            this.Item106_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 225, 192, 143));
            this.Item106_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item107
            // 
            this.Item107 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item107.BorderColor = System.Windows.Media.Color.FromArgb(255, 155, 11, 0);
            this.Item107.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item107__GetListOfArguments);
            this.Item107.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item107__GetListOfValues);
            this.Item107.ShowShadow = false;
            this.Item107.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item107__GetTitle);
            this.Item107.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 111, 97), System.Windows.Media.Color.FromArgb(255, 205, 61, 47), 0);
            this.Item107.DrillDownPageGuid = null;
            this.Item107_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item107_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Item107_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 75, 42, 0);
            this.Item107_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item107_SeriesLabels.ValueTypeSeparator = "-";
            this.Item107_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 225, 192, 143));
            this.Item107_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart48_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart48_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart48_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart48.Style = new Stimulsoft.Report.Chart.StiStyle11();
            this.Chart48.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 75, 42, 0)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart49_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart49_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 221), 90);
            this.Chart49_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart49_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart49_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 105, 78, 31), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart49_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 128, 81)), true, true);
            this.Chart49_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 155, 128, 81)), true, true);
            this.Chart49_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart49_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 1F, false, true, false, true);
            this.Chart49_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart49_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 105, 78, 31), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 105, 78, 31), 1F, false, true, true);
            this.Chart49.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart49.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart49.Guid = null;
            this.Chart49.Interaction = null;
            this.Chart49_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart49_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart49_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart49_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart49_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Chart49_Legend.Visible = false;
            this.Chart49_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 248, 201), 90);
            this.Chart49_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart49_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart49.MasterComponent = null;
            // 
            // Item109
            // 
            this.Item109 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item109.BorderColor = System.Windows.Media.Color.FromArgb(255, 118, 65, 0);
            this.Item109.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item109__GetListOfArguments);
            this.Item109.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item109__GetListOfValues);
            this.Item109.ShowShadow = false;
            this.Item109.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item109__GetTitle);
            this.Item109.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 218, 165, 32), System.Windows.Media.Color.FromArgb(255, 168, 115, 0), 0);
            this.Item109.DrillDownPageGuid = null;
            this.Item109_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item109_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Item109_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Item109_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item109_SeriesLabels.ValueTypeSeparator = "-";
            this.Item109_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 228, 181));
            this.Item109_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item110
            // 
            this.Item110 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item110.BorderColor = System.Windows.Media.Color.FromArgb(255, 140, 130, 40);
            this.Item110.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item110__GetListOfArguments);
            this.Item110.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item110__GetListOfValues);
            this.Item110.ShowShadow = false;
            this.Item110.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item110__GetTitle);
            this.Item110.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 240, 230, 140), System.Windows.Media.Color.FromArgb(255, 190, 180, 90), 0);
            this.Item110.DrillDownPageGuid = null;
            this.Item110_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item110_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Item110_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 105, 78, 31);
            this.Item110_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item110_SeriesLabels.ValueTypeSeparator = "-";
            this.Item110_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 228, 181));
            this.Item110_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart49_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart49_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart49_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart49.Style = new Stimulsoft.Report.Chart.StiStyle12();
            this.Chart49.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 105, 78, 31)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart50_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart50_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 252, 250, 248), 90);
            this.Chart50_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 62, 60, 58), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 62, 60, 58), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart50_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart50_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 62, 60, 58), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 62, 60, 58), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart50_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 112, 110, 108)), true, true);
            this.Chart50_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 112, 110, 108)), true, true);
            this.Chart50_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 62, 60, 58), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 62, 60, 58), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 62, 60, 58), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart50_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 62, 60, 58), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 62, 60, 58), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 62, 60, 58), 1F, false, true, false, true);
            this.Chart50_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 62, 60, 58), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 62, 60, 58), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 62, 60, 58), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart50_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 62, 60, 58), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 62, 60, 58), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 62, 60, 58), 1F, false, true, true);
            this.Chart50.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart50.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart50.Guid = null;
            this.Chart50.Interaction = null;
            this.Chart50_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart50_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart50_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart50_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart50_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Chart50_Legend.Visible = false;
            this.Chart50_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 232, 230, 228), 90);
            this.Chart50_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart50_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart50.MasterComponent = null;
            // 
            // Item112
            // 
            this.Item112 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item112.BorderColor = System.Windows.Media.Color.FromArgb(255, 51, 58, 68);
            this.Item112.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item112__GetListOfArguments);
            this.Item112.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item112__GetListOfValues);
            this.Item112.ShowShadow = false;
            this.Item112.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item112__GetTitle);
            this.Item112.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 151, 158, 168), System.Windows.Media.Color.FromArgb(255, 101, 108, 118), 0);
            this.Item112.DrillDownPageGuid = null;
            this.Item112_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item112_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Item112_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Item112_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item112_SeriesLabels.ValueTypeSeparator = "-";
            this.Item112_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 212, 210, 208));
            this.Item112_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item113
            // 
            this.Item113 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item113.BorderColor = System.Windows.Media.Color.FromArgb(255, 89, 74, 37);
            this.Item113.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item113__GetListOfArguments);
            this.Item113.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item113__GetListOfValues);
            this.Item113.ShowShadow = false;
            this.Item113.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item113__GetTitle);
            this.Item113.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 189, 174, 137), System.Windows.Media.Color.FromArgb(255, 139, 124, 87), 0);
            this.Item113.DrillDownPageGuid = null;
            this.Item113_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item113_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Item113_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 62, 60, 58);
            this.Item113_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item113_SeriesLabels.ValueTypeSeparator = "-";
            this.Item113_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 212, 210, 208));
            this.Item113_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart50_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart50_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart50_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart50.Style = new Stimulsoft.Report.Chart.StiStyle13();
            this.Chart50.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 62, 60, 58)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart51_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart51_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 241), 90);
            this.Chart51_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 101, 88, 51), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 101, 88, 51), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart51_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart51_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 101, 88, 51), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 101, 88, 51), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart51_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 151, 138, 101)), true, true);
            this.Chart51_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 151, 138, 101)), true, true);
            this.Chart51_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 101, 88, 51), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 101, 88, 51), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 101, 88, 51), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart51_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 101, 88, 51), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 101, 88, 51), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 101, 88, 51), 1F, false, true, false, true);
            this.Chart51_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 101, 88, 51), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 101, 88, 51), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 101, 88, 51), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart51_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 101, 88, 51), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 101, 88, 51), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 101, 88, 51), 1F, false, true, true);
            this.Chart51.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart51.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart51.Guid = null;
            this.Chart51.Interaction = null;
            this.Chart51_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart51_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart51_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart51_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart51_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Chart51_Legend.Visible = false;
            this.Chart51_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 221), 90);
            this.Chart51_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart51_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart51.MasterComponent = null;
            // 
            // Item115
            // 
            this.Item115 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item115.BorderColor = System.Windows.Media.Color.FromArgb(255, 140, 62, 0);
            this.Item115.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item115__GetListOfArguments);
            this.Item115.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item115__GetListOfValues);
            this.Item115.ShowShadow = false;
            this.Item115.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item115__GetTitle);
            this.Item115.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 240, 162, 46), System.Windows.Media.Color.FromArgb(255, 190, 112, 0), 0);
            this.Item115.DrillDownPageGuid = null;
            this.Item115_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item115_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Item115_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Item115_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item115_SeriesLabels.ValueTypeSeparator = "-";
            this.Item115_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 251, 238, 201));
            this.Item115_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item116
            // 
            this.Item116 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item116.BorderColor = System.Windows.Media.Color.FromArgb(255, 65, 0, 0);
            this.Item116.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item116__GetListOfArguments);
            this.Item116.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item116__GetListOfValues);
            this.Item116.ShowShadow = false;
            this.Item116.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item116__GetTitle);
            this.Item116.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 165, 100, 78), System.Windows.Media.Color.FromArgb(255, 115, 50, 28), 0);
            this.Item116.DrillDownPageGuid = null;
            this.Item116_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item116_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Item116_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 101, 88, 51);
            this.Item116_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item116_SeriesLabels.ValueTypeSeparator = "-";
            this.Item116_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 251, 238, 201));
            this.Item116_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart51_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart51_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart51_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart51.Style = new Stimulsoft.Report.Chart.StiStyle14();
            this.Chart51.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 101, 88, 51)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart52_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart52_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart52_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart52_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart52_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 69, 95, 99), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart52_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 119, 145, 149)), true, true);
            this.Chart52_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 119, 145, 149)), true, true);
            this.Chart52_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 1F, false, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart52_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 1F, false, true, false, true);
            this.Chart52_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 1F, false, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart52_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 69, 95, 99), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 69, 95, 99), 1F, false, true, true);
            this.Chart52.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart52.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart52.Guid = null;
            this.Chart52.Interaction = null;
            this.Chart52_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart52_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart52_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart52_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart52_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Chart52_Legend.Visible = false;
            this.Chart52_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 239, 255, 255), 90);
            this.Chart52_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart52_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart52.MasterComponent = null;
            // 
            // Item118
            // 
            this.Item118 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item118.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 11, 98);
            this.Item118.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item118__GetListOfArguments);
            this.Item118.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item118__GetListOfValues);
            this.Item118.ShowShadow = false;
            this.Item118.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item118__GetTitle);
            this.Item118.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 15, 111, 198), System.Windows.Media.Color.FromArgb(255, 0, 61, 148), 0);
            this.Item118.DrillDownPageGuid = null;
            this.Item118_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item118_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Item118_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Item118_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item118_SeriesLabels.ValueTypeSeparator = "-";
            this.Item118_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 219, 245, 249));
            this.Item118_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item119
            // 
            this.Item119 = new Stimulsoft.Report.Chart.StiClusteredColumnSeries();
            this.Item119.BorderColor = System.Windows.Media.Color.FromArgb(255, 0, 57, 117);
            this.Item119.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item119__GetListOfArguments);
            this.Item119.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item119__GetListOfValues);
            this.Item119.ShowShadow = false;
            this.Item119.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item119__GetTitle);
            this.Item119.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 0, 157, 217), System.Windows.Media.Color.FromArgb(255, 0, 107, 167), 0);
            this.Item119.DrillDownPageGuid = null;
            this.Item119_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item119_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Item119_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 69, 95, 99);
            this.Item119_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item119_SeriesLabels.ValueTypeSeparator = "-";
            this.Item119_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 219, 245, 249));
            this.Item119_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart52_SeriesLabels = new Stimulsoft.Report.Chart.StiNoneLabels();
            this.Chart52_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart52_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart52.Style = new Stimulsoft.Report.Chart.StiStyle15();
            this.Chart52.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 69, 95, 99)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            this.Page5.ExcelSheetValue = null;
            this.Page5.Interaction = null;
            this.Page5.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page5_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page5_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page5_Watermark.Image = null;
            this.Page5_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
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
            this.Item3.Chart = this.Chart9;
            this.Item3.SeriesLabels = this.Item3_SeriesLabels;
            this.Item3_SeriesLabels.Chart = this.Chart9;
            this.Chart9_SeriesLabels.Chart = this.Chart9;
            this.Chart20.Area = this.Chart20_Area;
            this.Chart20.Legend = this.Chart20_Legend;
            this.Chart20.Page = this.Styles;
            this.Chart20.Parent = this.Styles;
            this.Chart20.SeriesLabels = this.Chart20_SeriesLabels;
            this.Chart20_Area.Chart = this.Chart20;
            this.Chart20_Legend.Chart = this.Chart20;
            this.Item5.Chart = this.Chart20;
            this.Item5.SeriesLabels = this.Item5_SeriesLabels;
            this.Item5_SeriesLabels.Chart = this.Chart20;
            this.Item6.Chart = this.Chart20;
            this.Item6.SeriesLabels = this.Item6_SeriesLabels;
            this.Item6_SeriesLabels.Chart = this.Chart20;
            this.Chart20_SeriesLabels.Chart = this.Chart20;
            this.Chart21.Area = this.Chart21_Area;
            this.Chart21.Legend = this.Chart21_Legend;
            this.Chart21.Page = this.Styles;
            this.Chart21.Parent = this.Styles;
            this.Chart21.SeriesLabels = this.Chart21_SeriesLabels;
            this.Chart21_Area.Chart = this.Chart21;
            this.Chart21_Legend.Chart = this.Chart21;
            this.Item8.Chart = this.Chart21;
            this.Item8.SeriesLabels = this.Item8_SeriesLabels;
            this.Item8_SeriesLabels.Chart = this.Chart21;
            this.Item9.Chart = this.Chart21;
            this.Item9.SeriesLabels = this.Item9_SeriesLabels;
            this.Item9_SeriesLabels.Chart = this.Chart21;
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
            this.Item12.Chart = this.Chart22;
            this.Item12.SeriesLabels = this.Item12_SeriesLabels;
            this.Item12_SeriesLabels.Chart = this.Chart22;
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
            this.Item15.Chart = this.Chart27;
            this.Item15.SeriesLabels = this.Item15_SeriesLabels;
            this.Item15_SeriesLabels.Chart = this.Chart27;
            this.Item16.Chart = this.Chart27;
            this.Item16.SeriesLabels = this.Item16_SeriesLabels;
            this.Item16_SeriesLabels.Chart = this.Chart27;
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
            this.Item19.Chart = this.Chart28;
            this.Item19.SeriesLabels = this.Item19_SeriesLabels;
            this.Item19_SeriesLabels.Chart = this.Chart28;
            this.Item20.Chart = this.Chart28;
            this.Item20.SeriesLabels = this.Item20_SeriesLabels;
            this.Item20_SeriesLabels.Chart = this.Chart28;
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
            this.Chart29.Page = this.Styles;
            this.Chart29.Parent = this.Styles;
            this.Chart29.SeriesLabels = this.Chart29_SeriesLabels;
            this.Chart29_Area.Chart = this.Chart29;
            this.Chart29_Legend.Chart = this.Chart29;
            this.Item26.Chart = this.Chart29;
            this.Item26.LineMarker = this.Item26_LineMarker;
            this.Item26.Marker = this.Item26_Marker;
            this.Item26.SeriesLabels = this.Item26_SeriesLabels;
            this.Item26_SeriesLabels.Chart = this.Chart29;
            this.Item27.Chart = this.Chart29;
            this.Item27.LineMarker = this.Item27_LineMarker;
            this.Item27.Marker = this.Item27_Marker;
            this.Item27.SeriesLabels = this.Item27_SeriesLabels;
            this.Item27_SeriesLabels.Chart = this.Chart29;
            this.Chart29_SeriesLabels.Chart = this.Chart29;
            this.Text30.Page = this.Styles;
            this.InitializeComponent4();
        }
        
        public void InitializeComponent4()
        {
            this.Text30.Parent = this.Styles;
            this.Chart30.Area = this.Chart30_Area;
            this.Chart30.Legend = this.Chart30_Legend;
            this.Chart30.Page = this.Styles;
            this.Chart30.Parent = this.Styles;
            this.Chart30.SeriesLabels = this.Chart30_SeriesLabels;
            this.Chart30_Area.Chart = this.Chart30;
            this.Chart30_Legend.Chart = this.Chart30;
            this.Item30.Chart = this.Chart30;
            this.Item30.LineMarker = this.Item30_LineMarker;
            this.Item30.Marker = this.Item30_Marker;
            this.Item30.SeriesLabels = this.Item30_SeriesLabels;
            this.Item30_SeriesLabels.Chart = this.Chart30;
            this.Item31.Chart = this.Chart30;
            this.Item31.LineMarker = this.Item31_LineMarker;
            this.Item31.Marker = this.Item31_Marker;
            this.Item31.SeriesLabels = this.Item31_SeriesLabels;
            this.Item31_SeriesLabels.Chart = this.Chart30;
            this.Chart30_SeriesLabels.Chart = this.Chart30;
            this.Chart31.Area = this.Chart31_Area;
            this.Chart31.Legend = this.Chart31_Legend;
            this.Chart31.Page = this.Styles;
            this.Chart31.Parent = this.Styles;
            this.Chart31.SeriesLabels = this.Chart31_SeriesLabels;
            this.Chart31_Area.Chart = this.Chart31;
            this.Chart31_Legend.Chart = this.Chart31;
            this.Item33.Chart = this.Chart31;
            this.Item33.Marker = this.Item33_Marker;
            this.Item33.SeriesLabels = this.Item33_SeriesLabels;
            this.Item33_SeriesLabels.Chart = this.Chart31;
            this.Item34.Chart = this.Chart31;
            this.Item34.Marker = this.Item34_Marker;
            this.Item34.SeriesLabels = this.Item34_SeriesLabels;
            this.Item34_SeriesLabels.Chart = this.Chart31;
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
            this.Item37.Chart = this.Chart33;
            this.Item37.Marker = this.Item37_Marker;
            this.Item37.SeriesLabels = this.Item37_SeriesLabels;
            this.Item37_SeriesLabels.Chart = this.Chart33;
            this.Item38.Chart = this.Chart33;
            this.Item38.Marker = this.Item38_Marker;
            this.Item38.SeriesLabels = this.Item38_SeriesLabels;
            this.Item38_SeriesLabels.Chart = this.Chart33;
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
            this.Item42.Chart = this.Chart34;
            this.Item42.Marker = this.Item42_Marker;
            this.Item42.SeriesLabels = this.Item42_SeriesLabels;
            this.Item42_SeriesLabels.Chart = this.Chart34;
            this.Item43.Chart = this.Chart34;
            this.Item43.Marker = this.Item43_Marker;
            this.Item43.SeriesLabels = this.Item43_SeriesLabels;
            this.Item43_SeriesLabels.Chart = this.Chart34;
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
            this.Item46.Chart = this.Chart35;
            this.Item46.LineMarker = this.Item46_LineMarker;
            this.Item46.Marker = this.Item46_Marker;
            this.Item46.SeriesLabels = this.Item46_SeriesLabels;
            this.Item46_SeriesLabels.Chart = this.Chart35;
            this.Item47.Chart = this.Chart35;
            this.Item47.LineMarker = this.Item47_LineMarker;
            this.Item47.Marker = this.Item47_Marker;
            this.Item47.SeriesLabels = this.Item47_SeriesLabels;
            this.Item47_SeriesLabels.Chart = this.Chart35;
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
            this.Item50.Chart = this.Chart36;
            this.Item50.LineMarker = this.Item50_LineMarker;
            this.Item50.Marker = this.Item50_Marker;
            this.Item50.SeriesLabels = this.Item50_SeriesLabels;
            this.Item50_SeriesLabels.Chart = this.Chart36;
            this.Item51.Chart = this.Chart36;
            this.Item51.LineMarker = this.Item51_LineMarker;
            this.Item51.Marker = this.Item51_Marker;
            this.Item51.SeriesLabels = this.Item51_SeriesLabels;
            this.Item51_SeriesLabels.Chart = this.Chart36;
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
            this.Item54.Chart = this.Chart37;
            this.Item54.SeriesLabels = this.Item54_SeriesLabels;
            this.Item54_SeriesLabels.Chart = this.Chart37;
            this.Item55.Chart = this.Chart37;
            this.Item55.SeriesLabels = this.Item55_SeriesLabels;
            this.Item55_SeriesLabels.Chart = this.Chart37;
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
            this.Item58.Chart = this.Chart38;
            this.Item58.SeriesLabels = this.Item58_SeriesLabels;
            this.Item58_SeriesLabels.Chart = this.Chart38;
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
            this.Item61.Chart = this.Chart32;
            this.Item61.SeriesLabels = this.Item61_SeriesLabels;
            this.Item61_SeriesLabels.Chart = this.Chart32;
            this.Item62.Chart = this.Chart32;
            this.Item62.SeriesLabels = this.Item62_SeriesLabels;
            this.Item62_SeriesLabels.Chart = this.Chart32;
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
            this.Item79.Chart = this.Chart39;
            this.Item79.SeriesLabels = this.Item79_SeriesLabels;
            this.Item79_SeriesLabels.Chart = this.Chart39;
            this.Item80.Chart = this.Chart39;
            this.Item80.SeriesLabels = this.Item80_SeriesLabels;
            this.Item80_SeriesLabels.Chart = this.Chart39;
            this.Chart39_SeriesLabels.Chart = this.Chart39;
            this.Chart40.Area = this.Chart40_Area;
            this.Chart40.Legend = this.Chart40_Legend;
            this.Chart40.Page = this.Page5;
            this.Chart40.Parent = this.Page5;
            this.Chart40.SeriesLabels = this.Chart40_SeriesLabels;
            this.Chart40_Area.Chart = this.Chart40;
            this.Chart40_Legend.Chart = this.Chart40;
            this.Item82.Chart = this.Chart40;
            this.Item82.SeriesLabels = this.Item82_SeriesLabels;
            this.Item82_SeriesLabels.Chart = this.Chart40;
            this.Item83.Chart = this.Chart40;
            this.Item83.SeriesLabels = this.Item83_SeriesLabels;
            this.Item83_SeriesLabels.Chart = this.Chart40;
            this.Chart40_SeriesLabels.Chart = this.Chart40;
            this.Chart41.Area = this.Chart41_Area;
            this.Chart41.Legend = this.Chart41_Legend;
            this.Chart41.Page = this.Page5;
            this.Chart41.Parent = this.Page5;
            this.Chart41.SeriesLabels = this.Chart41_SeriesLabels;
            this.Chart41_Area.Chart = this.Chart41;
            this.Chart41_Legend.Chart = this.Chart41;
            this.Item85.Chart = this.Chart41;
            this.Item85.SeriesLabels = this.Item85_SeriesLabels;
            this.Item85_SeriesLabels.Chart = this.Chart41;
            this.Item86.Chart = this.Chart41;
            this.Item86.SeriesLabels = this.Item86_SeriesLabels;
            this.Item86_SeriesLabels.Chart = this.Chart41;
            this.Chart41_SeriesLabels.Chart = this.Chart41;
            this.Chart42.Area = this.Chart42_Area;
            this.Chart42.Legend = this.Chart42_Legend;
            this.Chart42.Page = this.Page5;
            this.Chart42.Parent = this.Page5;
            this.Chart42.SeriesLabels = this.Chart42_SeriesLabels;
            this.Chart42_Area.Chart = this.Chart42;
            this.Chart42_Legend.Chart = this.Chart42;
            this.Item88.Chart = this.Chart42;
            this.Item88.SeriesLabels = this.Item88_SeriesLabels;
            this.Item88_SeriesLabels.Chart = this.Chart42;
            this.Item89.Chart = this.Chart42;
            this.Item89.SeriesLabels = this.Item89_SeriesLabels;
            this.Item89_SeriesLabels.Chart = this.Chart42;
            this.Chart42_SeriesLabels.Chart = this.Chart42;
            this.Chart43.Area = this.Chart43_Area;
            this.Chart43.Legend = this.Chart43_Legend;
            this.Chart43.Page = this.Page5;
            this.Chart43.Parent = this.Page5;
            this.Chart43.SeriesLabels = this.Chart43_SeriesLabels;
            this.Chart43_Area.Chart = this.Chart43;
            this.Chart43_Legend.Chart = this.Chart43;
            this.Item91.Chart = this.Chart43;
            this.Item91.SeriesLabels = this.Item91_SeriesLabels;
            this.Item91_SeriesLabels.Chart = this.Chart43;
            this.Item92.Chart = this.Chart43;
            this.Item92.SeriesLabels = this.Item92_SeriesLabels;
            this.Item92_SeriesLabels.Chart = this.Chart43;
            this.Chart43_SeriesLabels.Chart = this.Chart43;
            this.Chart44.Area = this.Chart44_Area;
            this.Chart44.Legend = this.Chart44_Legend;
            this.Chart44.Page = this.Page5;
            this.Chart44.Parent = this.Page5;
            this.Chart44.SeriesLabels = this.Chart44_SeriesLabels;
            this.Chart44_Area.Chart = this.Chart44;
            this.Chart44_Legend.Chart = this.Chart44;
            this.Item94.Chart = this.Chart44;
            this.Item94.SeriesLabels = this.Item94_SeriesLabels;
            this.Item94_SeriesLabels.Chart = this.Chart44;
            this.Item95.Chart = this.Chart44;
            this.Item95.SeriesLabels = this.Item95_SeriesLabels;
            this.Item95_SeriesLabels.Chart = this.Chart44;
            this.Chart44_SeriesLabels.Chart = this.Chart44;
            this.Chart45.Area = this.Chart45_Area;
            this.Chart45.Legend = this.Chart45_Legend;
            this.Chart45.Page = this.Page5;
            this.Chart45.Parent = this.Page5;
            this.Chart45.SeriesLabels = this.Chart45_SeriesLabels;
            this.Chart45_Area.Chart = this.Chart45;
            this.Chart45_Legend.Chart = this.Chart45;
            this.Item97.Chart = this.Chart45;
            this.Item97.SeriesLabels = this.Item97_SeriesLabels;
            this.Item97_SeriesLabels.Chart = this.Chart45;
            this.Item98.Chart = this.Chart45;
            this.Item98.SeriesLabels = this.Item98_SeriesLabels;
            this.Item98_SeriesLabels.Chart = this.Chart45;
            this.Chart45_SeriesLabels.Chart = this.Chart45;
            this.Chart46.Area = this.Chart46_Area;
            this.Chart46.Legend = this.Chart46_Legend;
            this.Chart46.Page = this.Page5;
            this.Chart46.Parent = this.Page5;
            this.Chart46.SeriesLabels = this.Chart46_SeriesLabels;
            this.Chart46_Area.Chart = this.Chart46;
            this.Chart46_Legend.Chart = this.Chart46;
            this.Item100.Chart = this.Chart46;
            this.Item100.SeriesLabels = this.Item100_SeriesLabels;
            this.Item100_SeriesLabels.Chart = this.Chart46;
            this.Item101.Chart = this.Chart46;
            this.Item101.SeriesLabels = this.Item101_SeriesLabels;
            this.Item101_SeriesLabels.Chart = this.Chart46;
            this.Chart46_SeriesLabels.Chart = this.Chart46;
            this.Chart47.Area = this.Chart47_Area;
            this.Chart47.Legend = this.Chart47_Legend;
            this.Chart47.Page = this.Page5;
            this.Chart47.Parent = this.Page5;
            this.Chart47.SeriesLabels = this.Chart47_SeriesLabels;
            this.Chart47_Area.Chart = this.Chart47;
            this.Chart47_Legend.Chart = this.Chart47;
            this.Item103.Chart = this.Chart47;
            this.Item103.SeriesLabels = this.Item103_SeriesLabels;
            this.Item103_SeriesLabels.Chart = this.Chart47;
            this.Item104.Chart = this.Chart47;
            this.Item104.SeriesLabels = this.Item104_SeriesLabels;
            this.Item104_SeriesLabels.Chart = this.Chart47;
            this.Chart47_SeriesLabels.Chart = this.Chart47;
            this.Chart48.Area = this.Chart48_Area;
            this.Chart48.Legend = this.Chart48_Legend;
            this.Chart48.Page = this.Page5;
            this.Chart48.Parent = this.Page5;
            this.Chart48.SeriesLabels = this.Chart48_SeriesLabels;
            this.Chart48_Area.Chart = this.Chart48;
            this.Chart48_Legend.Chart = this.Chart48;
            this.Item106.Chart = this.Chart48;
            this.Item106.SeriesLabels = this.Item106_SeriesLabels;
            this.Item106_SeriesLabels.Chart = this.Chart48;
            this.Item107.Chart = this.Chart48;
            this.Item107.SeriesLabels = this.Item107_SeriesLabels;
            this.Item107_SeriesLabels.Chart = this.Chart48;
            this.Chart48_SeriesLabels.Chart = this.Chart48;
            this.Chart49.Area = this.Chart49_Area;
            this.Chart49.Legend = this.Chart49_Legend;
            this.Chart49.Page = this.Page5;
            this.Chart49.Parent = this.Page5;
            this.Chart49.SeriesLabels = this.Chart49_SeriesLabels;
            this.Chart49_Area.Chart = this.Chart49;
            this.Chart49_Legend.Chart = this.Chart49;
            this.Item109.Chart = this.Chart49;
            this.Item109.SeriesLabels = this.Item109_SeriesLabels;
            this.Item109_SeriesLabels.Chart = this.Chart49;
            this.Item110.Chart = this.Chart49;
            this.Item110.SeriesLabels = this.Item110_SeriesLabels;
            this.Item110_SeriesLabels.Chart = this.Chart49;
            this.Chart49_SeriesLabels.Chart = this.Chart49;
            this.Chart50.Area = this.Chart50_Area;
            this.Chart50.Legend = this.Chart50_Legend;
            this.Chart50.Page = this.Page5;
            this.Chart50.Parent = this.Page5;
            this.Chart50.SeriesLabels = this.Chart50_SeriesLabels;
            this.Chart50_Area.Chart = this.Chart50;
            this.Chart50_Legend.Chart = this.Chart50;
            this.Item112.Chart = this.Chart50;
            this.Item112.SeriesLabels = this.Item112_SeriesLabels;
            this.Item112_SeriesLabels.Chart = this.Chart50;
            this.Item113.Chart = this.Chart50;
            this.Item113.SeriesLabels = this.Item113_SeriesLabels;
            this.Item113_SeriesLabels.Chart = this.Chart50;
            this.Chart50_SeriesLabels.Chart = this.Chart50;
            this.Chart51.Area = this.Chart51_Area;
            this.Chart51.Legend = this.Chart51_Legend;
            this.Chart51.Page = this.Page5;
            this.Chart51.Parent = this.Page5;
            this.Chart51.SeriesLabels = this.Chart51_SeriesLabels;
            this.Chart51_Area.Chart = this.Chart51;
            this.Chart51_Legend.Chart = this.Chart51;
            this.Item115.Chart = this.Chart51;
            this.Item115.SeriesLabels = this.Item115_SeriesLabels;
            this.Item115_SeriesLabels.Chart = this.Chart51;
            this.Item116.Chart = this.Chart51;
            this.Item116.SeriesLabels = this.Item116_SeriesLabels;
            this.Item116_SeriesLabels.Chart = this.Chart51;
            this.Chart51_SeriesLabels.Chart = this.Chart51;
            this.Chart52.Area = this.Chart52_Area;
            this.Chart52.Legend = this.Chart52_Legend;
            this.Chart52.Page = this.Page5;
            this.Chart52.Parent = this.Page5;
            this.Chart52.SeriesLabels = this.Chart52_SeriesLabels;
            this.Chart52_Area.Chart = this.Chart52;
            this.Chart52_Legend.Chart = this.Chart52;
            this.Item118.Chart = this.Chart52;
            this.Item118.SeriesLabels = this.Item118_SeriesLabels;
            this.Item118_SeriesLabels.Chart = this.Chart52;
            this.Item119.Chart = this.Chart52;
            this.Item119.SeriesLabels = this.Item119_SeriesLabels;
            this.Item119_SeriesLabels.Chart = this.Chart52;
            this.Chart52_SeriesLabels.Chart = this.Chart52;
            // 
            // Add to Chart9.Series
            // 
            this.Chart9.Series.Clear();
            this.Chart9.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item3});
            // 
            // Add to Chart20.Series
            // 
            this.Chart20.Series.Clear();
            this.Chart20.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item5,
                        this.Item6});
            // 
            // Add to Chart21.Series
            // 
            this.Chart21.Series.Clear();
            this.Chart21.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item8,
                        this.Item9});
            // 
            // Add to Chart22.Series
            // 
            this.Chart22.Series.Clear();
            this.Chart22.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item12});
            // 
            // Add to Chart27.Series
            // 
            this.Chart27.Series.Clear();
            this.Chart27.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item15,
                        this.Item16});
            // 
            // Add to Chart28.Series
            // 
            this.Chart28.Series.Clear();
            this.Chart28.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item19,
                        this.Item20});
            // 
            // Add to Chart29.Series
            // 
            this.Chart29.Series.Clear();
            this.Chart29.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item26,
                        this.Item27});
            // 
            // Add to Chart30.Series
            // 
            this.Chart30.Series.Clear();
            this.Chart30.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item30,
                        this.Item31});
            // 
            // Add to Chart31.Series
            // 
            this.Chart31.Series.Clear();
            this.Chart31.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item33,
                        this.Item34});
            // 
            // Add to Chart33.Series
            // 
            this.Chart33.Series.Clear();
            this.Chart33.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item37,
                        this.Item38});
            // 
            // Add to Chart34.Series
            // 
            this.Chart34.Series.Clear();
            this.Chart34.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item42,
                        this.Item43});
            // 
            // Add to Chart35.Series
            // 
            this.Chart35.Series.Clear();
            this.Chart35.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item46,
                        this.Item47});
            // 
            // Add to Chart36.Series
            // 
            this.Chart36.Series.Clear();
            this.Chart36.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item50,
                        this.Item51});
            // 
            // Add to Chart37.Series
            // 
            this.Chart37.Series.Clear();
            this.Chart37.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item54,
                        this.Item55});
            // 
            // Add to Chart38.Series
            // 
            this.Chart38.Series.Clear();
            this.Chart38.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item58});
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
                        this.Item61,
                        this.Item62});
            // 
            // Add to Chart39.Series
            // 
            this.Chart39.Series.Clear();
            this.Chart39.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item79,
                        this.Item80});
            // 
            // Add to Chart40.Series
            // 
            this.Chart40.Series.Clear();
            this.Chart40.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item82,
                        this.Item83});
            // 
            // Add to Chart41.Series
            // 
            this.Chart41.Series.Clear();
            this.Chart41.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item85,
                        this.Item86});
            // 
            // Add to Chart42.Series
            // 
            this.Chart42.Series.Clear();
            this.Chart42.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item88,
                        this.Item89});
            // 
            // Add to Chart43.Series
            // 
            this.Chart43.Series.Clear();
            this.Chart43.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item91,
                        this.Item92});
            // 
            // Add to Chart44.Series
            // 
            this.Chart44.Series.Clear();
            this.Chart44.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item94,
                        this.Item95});
            // 
            // Add to Chart45.Series
            // 
            this.Chart45.Series.Clear();
            this.Chart45.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item97,
                        this.Item98});
            // 
            // Add to Chart46.Series
            // 
            this.Chart46.Series.Clear();
            this.Chart46.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item100,
                        this.Item101});
            // 
            // Add to Chart47.Series
            // 
            this.Chart47.Series.Clear();
            this.Chart47.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item103,
                        this.Item104});
            // 
            // Add to Chart48.Series
            // 
            this.Chart48.Series.Clear();
            this.Chart48.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item106,
                        this.Item107});
            // 
            // Add to Chart49.Series
            // 
            this.Chart49.Series.Clear();
            this.Chart49.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item109,
                        this.Item110});
            // 
            // Add to Chart50.Series
            // 
            this.Chart50.Series.Clear();
            this.Chart50.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item112,
                        this.Item113});
            // 
            // Add to Chart51.Series
            // 
            this.Chart51.Series.Clear();
            this.Chart51.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item115,
                        this.Item116});
            // 
            // Add to Chart52.Series
            // 
            this.Chart52.Series.Clear();
            this.Chart52.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item118,
                        this.Item119});
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
        }
        #endregion StiReport Designer generated code - do not modify
    }
}