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
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Chart.StiChart Chart1;
        public Stimulsoft.Report.Chart.StiClusteredColumnArea Chart1_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart1_Legend;
        public Stimulsoft.Report.Chart.StiClusteredColumnSeries Item3;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item3_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart1_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart3;
        public Stimulsoft.Report.Chart.StiStackedColumnArea Chart3_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart3_Legend;
        public Stimulsoft.Report.Chart.StiStackedColumnSeries Item5;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item5_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedColumnSeries Item6;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item6_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart3_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart4;
        public Stimulsoft.Report.Chart.StiFullStackedColumnArea Chart4_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart4_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedColumnSeries Item8;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item8_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedColumnSeries Item9;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item9_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart4_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Chart.StiChart Chart2;
        public Stimulsoft.Report.Chart.StiClusteredBarArea Chart2_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart2_Legend;
        public Stimulsoft.Report.Chart.StiClusteredBarSeries Item12;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item12_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart2_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Chart.StiChart Chart5;
        public Stimulsoft.Report.Chart.StiStackedBarArea Chart5_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart5_Legend;
        public Stimulsoft.Report.Chart.StiStackedBarSeries Item15;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item15_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedBarSeries Item16;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item16_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart5_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Chart.StiChart Chart6;
        public Stimulsoft.Report.Chart.StiFullStackedBarArea Chart6_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart6_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedBarSeries Item19;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item19_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedBarSeries Item20;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item20_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart6_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
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
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Column";
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
            e.Value = "Row 1";
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Clustered Bar";
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
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Bar";
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
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
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
            this.Chart1_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Area.ShowShadow = true;
            this.Chart1_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart1_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, true, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart1_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart1_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), true, true);
            this.Chart1_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 1F, false, 2F, 1, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart1_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart1_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(false, 10F, false, 2F, 7, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart1_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart1.Guid = null;
            this.Chart1.Interaction = null;
            this.Chart1_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart1_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart1_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart1_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart1_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart1_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart1.MasterComponent = null;
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
            this.Chart1_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart1_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart1_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart1_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart1_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart1_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart1.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart1.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart3_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart3_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart3_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart3_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart3_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart3_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart3_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 45F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart3_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart3_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart3_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart3.Guid = null;
            this.Chart3.Interaction = null;
            this.Chart3_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart3_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart3_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart3_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart3_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart3_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart3.MasterComponent = null;
            // 
            // Item5
            // 
            this.Item5 = new Stimulsoft.Report.Chart.StiStackedColumnSeries();
            this.Item5.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item5.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfArguments);
            this.Item5.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfValues);
            this.Item5.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item5__GetTitle);
            this.Item5.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 144, 67, 3), System.Windows.Media.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item5.DrillDownPageGuid = null;
            this.Item5_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item5_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item5_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item5_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item5_SeriesLabels.ValueTypeSeparator = "-";
            this.Item5_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item5_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item6
            // 
            this.Item6 = new Stimulsoft.Report.Chart.StiStackedColumnSeries();
            this.Item6.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item6.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item6__GetListOfArguments);
            this.Item6.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item6__GetListOfValues);
            this.Item6.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item6__GetTitle);
            this.Item6.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 181, 90, 15), System.Windows.Media.Color.FromArgb(255, 231, 140, 65), 0, 0.5F, 1F);
            this.Item6.DrillDownPageGuid = null;
            this.Item6_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item6_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item6_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item6_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item6_SeriesLabels.ValueTypeSeparator = "-";
            this.Item6_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item6_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart3_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart3_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart3_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart3_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart3_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart3_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart3.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart3.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart4_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart4_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart4_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart4_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart4_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart4_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart4_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart4_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart4_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart4_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart4.Guid = null;
            this.Chart4.Interaction = null;
            this.Chart4_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart4_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_Legend.Columns = 1;
            this.Chart4_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.Right;
            this.Chart4_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart4_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart4_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart4_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart4_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart4.MasterComponent = null;
            // 
            // Item8
            // 
            this.Item8 = new Stimulsoft.Report.Chart.StiFullStackedColumnSeries();
            this.Item8.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item8.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfArguments);
            this.Item8.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfValues);
            this.Item8.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item8__GetTitle);
            this.Item8.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 144, 67, 3), System.Windows.Media.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item8.DrillDownPageGuid = null;
            this.Item8_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item8_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item8_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item8_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item8_SeriesLabels.ValueTypeSeparator = "-";
            this.Item8_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item8_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item9
            // 
            this.Item9 = new Stimulsoft.Report.Chart.StiFullStackedColumnSeries();
            this.Item9.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item9.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item9__GetListOfArguments);
            this.Item9.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item9__GetListOfValues);
            this.Item9.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item9__GetTitle);
            this.Item9.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 181, 90, 15), System.Windows.Media.Color.FromArgb(255, 231, 140, 65), 0, 0.5F, 1F);
            this.Item9.DrillDownPageGuid = null;
            this.Item9_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item9_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item9_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item9_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item9_SeriesLabels.ValueTypeSeparator = "-";
            this.Item9_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item9_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart4_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart4_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart4_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart4_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart4_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart4_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart4.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart4.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.6, 9.4, 0.6);
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text2.Guid = null;
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart2_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart2_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart2_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart2_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart2_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart2_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart2_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart2_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart2_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart2_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart2.Guid = null;
            this.Chart2.Interaction = null;
            this.Chart2_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart2_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart2_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_Legend.Visible = false;
            this.Chart2_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart2_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart2_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart2.MasterComponent = null;
            // 
            // Item12
            // 
            this.Item12 = new Stimulsoft.Report.Chart.StiClusteredBarSeries();
            this.Item12.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item12.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item12__GetListOfArguments);
            this.Item12.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item12__GetListOfValues);
            this.Item12.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item12__GetTitle);
            this.Item12.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 144, 67, 3), System.Windows.Media.Color.FromArgb(255, 194, 117, 53), 90, 0.5F, 1F);
            this.Item12.DrillDownPageGuid = null;
            this.Item12_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item12_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item12_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item12_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item12_SeriesLabels.ValueTypeSeparator = "-";
            this.Item12_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item12_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart2_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart2_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart2_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart2_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart2_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart2_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart2.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart2.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19.8, 9.4, 0.6);
            this.Text1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text1.Guid = null;
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart5_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart5_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart5_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart5_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart5_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart5_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart5_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart5_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart5_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart5_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart5.Guid = null;
            this.Chart5.Interaction = null;
            this.Chart5_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart5_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.Right;
            this.Chart5_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart5_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.BottomOutside;
            this.Chart5_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart5_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart5_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart5.MasterComponent = null;
            // 
            // Item15
            // 
            this.Item15 = new Stimulsoft.Report.Chart.StiStackedBarSeries();
            this.Item15.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item15.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item15__GetListOfArguments);
            this.Item15.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item15__GetListOfValues);
            this.Item15.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item15__GetTitle);
            this.Item15.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 144, 67, 3), System.Windows.Media.Color.FromArgb(255, 194, 117, 53), 90, 0.5F, 1F);
            this.Item15.DrillDownPageGuid = null;
            this.Item15_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item15_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item15_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item15_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item15_SeriesLabels.ValueTypeSeparator = "-";
            this.Item15_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item15_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item16
            // 
            this.Item16 = new Stimulsoft.Report.Chart.StiStackedBarSeries();
            this.Item16.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item16.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item16__GetListOfArguments);
            this.Item16.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item16__GetListOfValues);
            this.Item16.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item16__GetTitle);
            this.Item16.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 181, 90, 15), System.Windows.Media.Color.FromArgb(255, 231, 140, 65), 90, 0.5F, 1F);
            this.Item16.DrillDownPageGuid = null;
            this.Item16_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item16_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item16_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item16_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item16_SeriesLabels.ValueTypeSeparator = "-";
            this.Item16_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item16_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart5_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart5_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart5_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart5_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart5_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart5_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart5.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart5.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 19.8, 9.4, 0.6);
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text3.Guid = null;
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart6_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart6_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart6_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart6_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart6_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart6_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart6_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart6_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart6_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart6_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart6.Guid = null;
            this.Chart6.Interaction = null;
            this.Chart6_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart6_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_Legend.Columns = 1;
            this.Chart6_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.Right;
            this.Chart6_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart6_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart6_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart6_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart6_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart6.MasterComponent = null;
            // 
            // Item19
            // 
            this.Item19 = new Stimulsoft.Report.Chart.StiFullStackedBarSeries();
            this.Item19.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item19.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item19__GetListOfArguments);
            this.Item19.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item19__GetListOfValues);
            this.Item19.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item19__GetTitle);
            this.Item19.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 144, 67, 3), System.Windows.Media.Color.FromArgb(255, 194, 117, 53), 90, 0.5F, 1F);
            this.Item19.DrillDownPageGuid = null;
            this.Item19_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item19_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item19_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item19_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item19_SeriesLabels.ValueTypeSeparator = "-";
            this.Item19_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item19_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item20
            // 
            this.Item20 = new Stimulsoft.Report.Chart.StiFullStackedBarSeries();
            this.Item20.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item20.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item20__GetListOfArguments);
            this.Item20.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item20__GetListOfValues);
            this.Item20.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item20__GetTitle);
            this.Item20.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 181, 90, 15), System.Windows.Media.Color.FromArgb(255, 231, 140, 65), 90, 0.5F, 1F);
            this.Item20.DrillDownPageGuid = null;
            this.Item20_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item20_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item20_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item20_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item20_SeriesLabels.ValueTypeSeparator = "-";
            this.Item20_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item20_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart6_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart6_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart6_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart6_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart6_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart6_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart6.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart6.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 10.6, 9.4, 0.6);
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text4.Guid = null;
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.2, 9.4, 0.6);
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text7.Guid = null;
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 0.2, 9.4, 0.6);
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text8.Guid = null;
            this.Text8.Indicator = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
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
            this.Item3.Chart = this.Chart1;
            this.Item3.SeriesLabels = this.Item3_SeriesLabels;
            this.Item3_SeriesLabels.Chart = this.Chart1;
            this.Chart1_SeriesLabels.Chart = this.Chart1;
            this.Chart3.Area = this.Chart3_Area;
            this.Chart3.Legend = this.Chart3_Legend;
            this.Chart3.Page = this.Page1;
            this.Chart3.Parent = this.Page1;
            this.Chart3.SeriesLabels = this.Chart3_SeriesLabels;
            this.Chart3_Area.Chart = this.Chart3;
            this.Chart3_Legend.Chart = this.Chart3;
            this.Item5.Chart = this.Chart3;
            this.Item5.SeriesLabels = this.Item5_SeriesLabels;
            this.Item5_SeriesLabels.Chart = this.Chart3;
            this.Item6.Chart = this.Chart3;
            this.Item6.SeriesLabels = this.Item6_SeriesLabels;
            this.Item6_SeriesLabels.Chart = this.Chart3;
            this.Chart3_SeriesLabels.Chart = this.Chart3;
            this.Chart4.Area = this.Chart4_Area;
            this.Chart4.Legend = this.Chart4_Legend;
            this.Chart4.Page = this.Page1;
            this.Chart4.Parent = this.Page1;
            this.Chart4.SeriesLabels = this.Chart4_SeriesLabels;
            this.Chart4_Area.Chart = this.Chart4;
            this.Chart4_Legend.Chart = this.Chart4;
            this.Item8.Chart = this.Chart4;
            this.Item8.SeriesLabels = this.Item8_SeriesLabels;
            this.Item8_SeriesLabels.Chart = this.Chart4;
            this.Item9.Chart = this.Chart4;
            this.Item9.SeriesLabels = this.Item9_SeriesLabels;
            this.Item9_SeriesLabels.Chart = this.Chart4;
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
            this.Item12.Chart = this.Chart2;
            this.Item12.SeriesLabels = this.Item12_SeriesLabels;
            this.Item12_SeriesLabels.Chart = this.Chart2;
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
            this.Item15.Chart = this.Chart5;
            this.Item15.SeriesLabels = this.Item15_SeriesLabels;
            this.Item15_SeriesLabels.Chart = this.Chart5;
            this.Item16.Chart = this.Chart5;
            this.Item16.SeriesLabels = this.Item16_SeriesLabels;
            this.Item16_SeriesLabels.Chart = this.Chart5;
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
            this.Item19.Chart = this.Chart6;
            this.Item19.SeriesLabels = this.Item19_SeriesLabels;
            this.Item19_SeriesLabels.Chart = this.Chart6;
            this.Item20.Chart = this.Chart6;
            this.Item20.SeriesLabels = this.Item20_SeriesLabels;
            this.Item20_SeriesLabels.Chart = this.Chart6;
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
                        this.Item3});
            // 
            // Add to Chart3.Series
            // 
            this.Chart3.Series.Clear();
            this.Chart3.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item5,
                        this.Item6});
            // 
            // Add to Chart4.Series
            // 
            this.Chart4.Series.Clear();
            this.Chart4.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item8,
                        this.Item9});
            // 
            // Add to Chart2.Series
            // 
            this.Chart2.Series.Clear();
            this.Chart2.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item12});
            // 
            // Add to Chart5.Series
            // 
            this.Chart5.Series.Clear();
            this.Chart5.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item15,
                        this.Item16});
            // 
            // Add to Chart6.Series
            // 
            this.Chart6.Series.Clear();
            this.Chart6.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item19,
                        this.Item20});
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
        }
        #endregion StiReport Designer generated code - do not modify
    }
}