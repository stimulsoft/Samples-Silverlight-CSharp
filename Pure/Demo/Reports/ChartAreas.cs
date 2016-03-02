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
        public Stimulsoft.Report.Components.StiPage Page3;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Chart.StiChart Chart16;
        public Stimulsoft.Report.Chart.StiStackedAreaArea Chart16_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart16_Legend;
        public Stimulsoft.Report.Chart.StiStackedAreaSeries Item4;
        public Stimulsoft.Report.Chart.StiLineMarker Item4_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item4_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item4_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedAreaSeries Item5;
        public Stimulsoft.Report.Chart.StiLineMarker Item5_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item5_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item5_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideEndAxisLabels Chart16_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text16;
        public Stimulsoft.Report.Chart.StiChart Chart17;
        public Stimulsoft.Report.Chart.StiAreaArea Chart17_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart17_Legend;
        public Stimulsoft.Report.Chart.StiAreaSeries Item8;
        public Stimulsoft.Report.Chart.StiLineMarker Item8_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item8_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item8_SeriesLabels;
        public Stimulsoft.Report.Chart.StiAreaSeries Item9;
        public Stimulsoft.Report.Chart.StiLineMarker Item9_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item9_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item9_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideEndAxisLabels Chart17_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Chart.StiChart Chart19;
        public Stimulsoft.Report.Chart.StiFullStackedAreaArea Chart19_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart19_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedAreaSeries Item12;
        public Stimulsoft.Report.Chart.StiLineMarker Item12_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item12_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item12_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedAreaSeries Item13;
        public Stimulsoft.Report.Chart.StiLineMarker Item13_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item13_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item13_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart19_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart23;
        public Stimulsoft.Report.Chart.StiFullStackedSplineAreaArea Chart23_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart23_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedSplineAreaSeries Item15;
        public Stimulsoft.Report.Chart.StiMarker Item15_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item15_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedSplineAreaSeries Item16;
        public Stimulsoft.Report.Chart.StiMarker Item16_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item16_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart23_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text24;
        public Stimulsoft.Report.Chart.StiChart Chart18;
        public Stimulsoft.Report.Chart.StiSplineAreaArea Chart18_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart18_Legend;
        public Stimulsoft.Report.Chart.StiSplineAreaSeries Item19;
        public Stimulsoft.Report.Chart.StiMarker Item19_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item19_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart18_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Chart.StiChart Chart24;
        public Stimulsoft.Report.Chart.StiStackedSplineAreaArea Chart24_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart24_Legend;
        public Stimulsoft.Report.Chart.StiStackedSplineAreaSeries Item23;
        public Stimulsoft.Report.Chart.StiMarker Item23_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item23_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedSplineAreaSeries Item24;
        public Stimulsoft.Report.Chart.StiMarker Item24_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item24_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideAxisLabels Chart24_SeriesLabels;
        public Stimulsoft.Report.Components.StiWatermark Page3_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Area";
        }
        
        public void Item4__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item4__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;10;30;15;10;20;15;30;10";
        }
        
        public void Item4__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item5__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item5__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;15;20;20;15;10;15;40;20;10";
        }
        
        public void Item5__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text16__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Area";
        }
        
        public void Item8__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item8__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;10;15;5;15;5;2;15;5;2";
        }
        
        public void Item8__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item9__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item9__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "25;15;20;20;25;10;15;40;20;10";
        }
        
        public void Item9__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Area";
        }
        
        public void Item12__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item12__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;25;20;15;15;15;25;20;15";
        }
        
        public void Item12__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item13__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item13__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "25;15;10;20;5;15;25;20;15;10";
        }
        
        public void Item13__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Item15__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item15__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;25;20;15;15;15;25;20;15";
        }
        
        public void Item15__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item16__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8;9;10";
        }
        
        public void Item16__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "25;15;10;20;5;15;25;20;15;10";
        }
        
        public void Item16__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text24__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Spline Area";
        }
        
        public void Item19__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8";
        }
        
        public void Item19__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "30;20;10;25;15;40;20;10";
        }
        
        public void Item19__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
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
        
        public void Item23__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8";
        }
        
        public void Item23__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;50;40;10;40;10;15";
        }
        
        public void Item23__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item24__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7;8";
        }
        
        public void Item24__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;10;40;30;20;40;15;5";
        }
        
        public void Item24__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
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
            this.Page3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Page3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.8, 9.4, 0.6);
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text15.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text15.Guid = null;
            this.Text15.Indicator = null;
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart16_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart16_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart16_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart16_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart16_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart16_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart16_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart16_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart16_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart16_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart16.Guid = null;
            this.Chart16.Interaction = null;
            this.Chart16_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart16_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart16_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart16_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart16_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart16.MasterComponent = null;
            // 
            // Item4
            // 
            this.Item4 = new Stimulsoft.Report.Chart.StiStackedAreaSeries();
            this.Item4.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item4.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item4__GetListOfArguments);
            this.Item4.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item4__GetListOfValues);
            this.Item4.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item4__GetTitle);
            this.Item4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 194, 117, 53));
            this.Item4.DrillDownPageGuid = null;
            this.Item4_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item4_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 44, 0, 0);
            this.Item4_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 244, 167, 103));
            this.Item4_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item4_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item4_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
            this.Item4_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item4_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item4_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item4_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item4_SeriesLabels.ValueTypeSeparator = "-";
            this.Item4_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item4_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item5
            // 
            this.Item5 = new Stimulsoft.Report.Chart.StiStackedAreaSeries();
            this.Item5.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item5.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfArguments);
            this.Item5.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfValues);
            this.Item5.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item5__GetTitle);
            this.Item5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 231, 140, 65));
            this.Item5.DrillDownPageGuid = null;
            this.Item5_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item5_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 81, 0, 0);
            this.Item5_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 190, 115));
            this.Item5_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item5_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item5_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 240, 165));
            this.Item5_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item5_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item5_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item5_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item5_SeriesLabels.ValueTypeSeparator = "-";
            this.Item5_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item5_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart16_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideEndAxisLabels();
            this.Chart16_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart16_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart16_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart16_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart16_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart16.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart16.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text16
            // 
            this.Text16 = new Stimulsoft.Report.Components.StiText();
            this.Text16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 0.8, 9.4, 0.6);
            this.Text16.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text16.Name = "Text16";
            this.Text16.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text16__GetValue);
            this.Text16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text16.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text16.Guid = null;
            this.Text16.Indicator = null;
            this.Text16.Interaction = null;
            this.Text16.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text16.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart17_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart17_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart17_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart17_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart17_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart17_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart17_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart17_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart17_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart17_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart17.Guid = null;
            this.Chart17.Interaction = null;
            this.Chart17_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart17_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart17_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart17_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart17_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart17.MasterComponent = null;
            // 
            // Item8
            // 
            this.Item8 = new Stimulsoft.Report.Chart.StiAreaSeries();
            this.Item8.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item8.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfArguments);
            this.Item8.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfValues);
            this.Item8.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item8__GetTitle);
            this.Item8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 194, 117, 53));
            this.Item8.DrillDownPageGuid = null;
            this.Item8_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item8_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 44, 0, 0);
            this.Item8_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 244, 167, 103));
            this.Item8_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item8_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item8_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
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
            this.Item9 = new Stimulsoft.Report.Chart.StiAreaSeries();
            this.Item9.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item9.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item9__GetListOfArguments);
            this.Item9.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item9__GetListOfValues);
            this.Item9.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item9__GetTitle);
            this.Item9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 231, 140, 65));
            this.Item9.DrillDownPageGuid = null;
            this.Item9_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item9_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 81, 0, 0);
            this.Item9_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 190, 115));
            this.Item9_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item9_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item9_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 240, 165));
            this.Item9_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item9_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item9_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item9_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item9_SeriesLabels.ValueTypeSeparator = "-";
            this.Item9_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item9_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart17_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideEndAxisLabels();
            this.Chart17_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart17_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart17_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart17_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart17_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart17.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart17.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19.2, 9.4, 0.6);
            this.Text17.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text17.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text17.Guid = null;
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart19_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart19_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart19_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart19_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart19_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart19_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart19_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart19_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart19_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart19_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart19.Guid = null;
            this.Chart19.Interaction = null;
            this.Chart19_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart19_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_Legend.Columns = 1;
            this.Chart19_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart19_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart19_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart19_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart19_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart19.MasterComponent = null;
            // 
            // Item12
            // 
            this.Item12 = new Stimulsoft.Report.Chart.StiFullStackedAreaSeries();
            this.Item12.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item12.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item12__GetListOfArguments);
            this.Item12.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item12__GetListOfValues);
            this.Item12.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item12__GetTitle);
            this.Item12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 194, 117, 53));
            this.Item12.DrillDownPageGuid = null;
            this.Item12_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item12_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 44, 0, 0);
            this.Item12_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 244, 167, 103));
            this.Item12_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item12_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item12_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
            this.Item12_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item12_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item12_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item12_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item12_SeriesLabels.ValueTypeSeparator = "-";
            this.Item12_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item12_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item13
            // 
            this.Item13 = new Stimulsoft.Report.Chart.StiFullStackedAreaSeries();
            this.Item13.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item13.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item13__GetListOfArguments);
            this.Item13.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item13__GetListOfValues);
            this.Item13.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item13__GetTitle);
            this.Item13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 231, 140, 65));
            this.Item13.DrillDownPageGuid = null;
            this.Item13_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item13_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 81, 0, 0);
            this.Item13_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 190, 115));
            this.Item13_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item13_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item13_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 240, 165));
            this.Item13_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item13_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item13_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item13_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item13_SeriesLabels.ValueTypeSeparator = "-";
            this.Item13_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item13_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart19_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart19_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart19_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart19_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart19_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart19_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart19.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart19.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart23_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart23_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart23_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart23_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart23_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart23_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart23_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart23_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart23_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart23_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart23.Guid = null;
            this.Chart23.Interaction = null;
            this.Chart23_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart23_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_Legend.Columns = 1;
            this.Chart23_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart23_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart23_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart23_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart23_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart23.MasterComponent = null;
            // 
            // Item15
            // 
            this.Item15 = new Stimulsoft.Report.Chart.StiFullStackedSplineAreaSeries();
            this.Item15.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item15.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item15__GetListOfArguments);
            this.Item15.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item15__GetListOfValues);
            this.Item15.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item15__GetTitle);
            this.Item15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 194, 117, 53));
            this.Item15.DrillDownPageGuid = null;
            this.Item15_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item15_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item15_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
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
            this.Item16 = new Stimulsoft.Report.Chart.StiFullStackedSplineAreaSeries();
            this.Item16.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item16.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item16__GetListOfArguments);
            this.Item16.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item16__GetListOfValues);
            this.Item16.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item16__GetTitle);
            this.Item16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 231, 140, 65));
            this.Item16.DrillDownPageGuid = null;
            this.Item16_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item16_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item16_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 240, 165));
            this.Item16_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item16_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item16_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item16_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item16_SeriesLabels.ValueTypeSeparator = "-";
            this.Item16_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item16_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart23_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart23_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart23_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart23_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart23_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart23_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart23.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart23.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text24
            // 
            this.Text24 = new Stimulsoft.Report.Components.StiText();
            this.Text24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 19.2, 9.4, 0.6);
            this.Text24.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text24.Name = "Text24";
            this.Text24.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text24__GetValue);
            this.Text24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text24.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text24.Guid = null;
            this.Text24.Indicator = null;
            this.Text24.Interaction = null;
            this.Text24.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text24.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart18_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart18_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart18_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart18_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart18_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart18_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart18_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart18_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart18_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart18_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart18.Guid = null;
            this.Chart18.Interaction = null;
            this.Chart18_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart18_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart18_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_Legend.Visible = false;
            this.Chart18_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart18_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart18_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart18.MasterComponent = null;
            // 
            // Item19
            // 
            this.Item19 = new Stimulsoft.Report.Chart.StiSplineAreaSeries();
            this.Item19.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item19.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item19__GetListOfArguments);
            this.Item19.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item19__GetListOfValues);
            this.Item19.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item19__GetTitle);
            this.Item19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 194, 117, 53));
            this.Item19.DrillDownPageGuid = null;
            this.Item19_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item19_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item19_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
            this.Item19_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item19_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item19_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item19_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item19_SeriesLabels.ValueTypeSeparator = "-";
            this.Item19_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item19_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart18_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart18_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart18_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart18_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart18_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart18_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart18.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart18.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.8, 9.4, 0.6);
            this.Text18.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text18.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text18.Guid = null;
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 9.8, 9.4, 0.6);
            this.Text23.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text23.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text23.Guid = null;
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart24_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart24_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart24_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart24_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart24_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart24_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart24_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart24_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart24_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart24_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart24.Guid = null;
            this.Chart24.Interaction = null;
            this.Chart24_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart24_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart24_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart24_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart24_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart24.MasterComponent = null;
            // 
            // Item23
            // 
            this.Item23 = new Stimulsoft.Report.Chart.StiStackedSplineAreaSeries();
            this.Item23.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item23.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item23__GetListOfArguments);
            this.Item23.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item23__GetListOfValues);
            this.Item23.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item23__GetTitle);
            this.Item23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 194, 117, 53));
            this.Item23.DrillDownPageGuid = null;
            this.Item23_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item23_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item23_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
            this.Item23_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item23_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item23_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item23_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item23_SeriesLabels.ValueTypeSeparator = "-";
            this.Item23_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item23_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item24
            // 
            this.Item24 = new Stimulsoft.Report.Chart.StiStackedSplineAreaSeries();
            this.Item24.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item24.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item24__GetListOfArguments);
            this.Item24.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item24__GetListOfValues);
            this.Item24.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item24__GetTitle);
            this.Item24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(200, 231, 140, 65));
            this.Item24.DrillDownPageGuid = null;
            this.Item24_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item24_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item24_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 240, 165));
            this.Item24_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item24_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item24_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item24_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item24_SeriesLabels.ValueTypeSeparator = "-";
            this.Item24_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item24_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart24_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideAxisLabels();
            this.Chart24_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart24_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart24_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart24_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart24_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart24.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart24.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            this.Page3.ExcelSheetValue = null;
            this.Page3.Interaction = null;
            this.Page3.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page3_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page3_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page3_Watermark.Image = null;
            this.Page3_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
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
            this.Item4.Chart = this.Chart16;
            this.Item4.LineMarker = this.Item4_LineMarker;
            this.Item4.Marker = this.Item4_Marker;
            this.Item4.SeriesLabels = this.Item4_SeriesLabels;
            this.Item4_SeriesLabels.Chart = this.Chart16;
            this.Item5.Chart = this.Chart16;
            this.Item5.LineMarker = this.Item5_LineMarker;
            this.Item5.Marker = this.Item5_Marker;
            this.Item5.SeriesLabels = this.Item5_SeriesLabels;
            this.Item5_SeriesLabels.Chart = this.Chart16;
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
            this.Item8.Chart = this.Chart17;
            this.Item8.LineMarker = this.Item8_LineMarker;
            this.Item8.Marker = this.Item8_Marker;
            this.Item8.SeriesLabels = this.Item8_SeriesLabels;
            this.Item8_SeriesLabels.Chart = this.Chart17;
            this.Item9.Chart = this.Chart17;
            this.Item9.LineMarker = this.Item9_LineMarker;
            this.Item9.Marker = this.Item9_Marker;
            this.Item9.SeriesLabels = this.Item9_SeriesLabels;
            this.Item9_SeriesLabels.Chart = this.Chart17;
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
            this.Item12.Chart = this.Chart19;
            this.Item12.LineMarker = this.Item12_LineMarker;
            this.Item12.Marker = this.Item12_Marker;
            this.Item12.SeriesLabels = this.Item12_SeriesLabels;
            this.Item12_SeriesLabels.Chart = this.Chart19;
            this.Item13.Chart = this.Chart19;
            this.Item13.LineMarker = this.Item13_LineMarker;
            this.Item13.Marker = this.Item13_Marker;
            this.Item13.SeriesLabels = this.Item13_SeriesLabels;
            this.Item13_SeriesLabels.Chart = this.Chart19;
            this.Chart19_SeriesLabels.Chart = this.Chart19;
            this.Chart23.Area = this.Chart23_Area;
            this.Chart23.Legend = this.Chart23_Legend;
            this.Chart23.Page = this.Page3;
            this.Chart23.Parent = this.Page3;
            this.Chart23.SeriesLabels = this.Chart23_SeriesLabels;
            this.Chart23_Area.Chart = this.Chart23;
            this.Chart23_Legend.Chart = this.Chart23;
            this.Item15.Chart = this.Chart23;
            this.Item15.Marker = this.Item15_Marker;
            this.Item15.SeriesLabels = this.Item15_SeriesLabels;
            this.Item15_SeriesLabels.Chart = this.Chart23;
            this.Item16.Chart = this.Chart23;
            this.Item16.Marker = this.Item16_Marker;
            this.Item16.SeriesLabels = this.Item16_SeriesLabels;
            this.Item16_SeriesLabels.Chart = this.Chart23;
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
            this.Item19.Chart = this.Chart18;
            this.Item19.Marker = this.Item19_Marker;
            this.Item19.SeriesLabels = this.Item19_SeriesLabels;
            this.Item19_SeriesLabels.Chart = this.Chart18;
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
            this.Item23.Chart = this.Chart24;
            this.Item23.Marker = this.Item23_Marker;
            this.Item23.SeriesLabels = this.Item23_SeriesLabels;
            this.Item23_SeriesLabels.Chart = this.Chart24;
            this.Item24.Chart = this.Chart24;
            this.Item24.Marker = this.Item24_Marker;
            this.Item24.SeriesLabels = this.Item24_SeriesLabels;
            this.Item24_SeriesLabels.Chart = this.Chart24;
            this.Chart24_SeriesLabels.Chart = this.Chart24;
            // 
            // Add to Chart16.Series
            // 
            this.Chart16.Series.Clear();
            this.Chart16.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item4,
                        this.Item5});
            // 
            // Add to Chart17.Series
            // 
            this.Chart17.Series.Clear();
            this.Chart17.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item8,
                        this.Item9});
            // 
            // Add to Chart19.Series
            // 
            this.Chart19.Series.Clear();
            this.Chart19.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item12,
                        this.Item13});
            // 
            // Add to Chart23.Series
            // 
            this.Chart23.Series.Clear();
            this.Chart23.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item15,
                        this.Item16});
            // 
            // Add to Chart18.Series
            // 
            this.Chart18.Series.Clear();
            this.Chart18.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item19});
            // 
            // Add to Chart24.Series
            // 
            this.Chart24.Series.Clear();
            this.Chart24.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item23,
                        this.Item24});
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
        }
        #endregion StiReport Designer generated code - do not modify
    }
}