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
        public Stimulsoft.Report.Components.StiPage Page2;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Chart.StiChart Chart10;
        public Stimulsoft.Report.Chart.StiStackedLineArea Chart10_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart10_Legend;
        public Stimulsoft.Report.Chart.StiStackedLineSeries Item4;
        public Stimulsoft.Report.Chart.StiLineMarker Item4_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item4_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item4_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedLineSeries Item5;
        public Stimulsoft.Report.Chart.StiLineMarker Item5_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item5_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item5_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart10_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Chart.StiChart Chart11;
        public Stimulsoft.Report.Chart.StiLineArea Chart11_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart11_Legend;
        public Stimulsoft.Report.Chart.StiLineSeries Item8;
        public Stimulsoft.Report.Chart.StiLineMarker Item8_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item8_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item8_SeriesLabels;
        public Stimulsoft.Report.Chart.StiLineSeries Item9;
        public Stimulsoft.Report.Chart.StiLineMarker Item9_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item9_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item9_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideAxisLabels Chart11_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart12;
        public Stimulsoft.Report.Chart.StiSplineArea Chart12_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart12_Legend;
        public Stimulsoft.Report.Chart.StiSplineSeries Item11;
        public Stimulsoft.Report.Chart.StiMarker Item11_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item11_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSplineSeries Item12;
        public Stimulsoft.Report.Chart.StiMarker Item12_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item12_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideEndAxisLabels Chart12_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Chart.StiChart Chart7;
        public Stimulsoft.Report.Chart.StiStackedSplineArea Chart7_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart7_Legend;
        public Stimulsoft.Report.Chart.StiStackedSplineSeries Item16;
        public Stimulsoft.Report.Chart.StiMarker Item16_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item16_SeriesLabels;
        public Stimulsoft.Report.Chart.StiStackedSplineSeries Item17;
        public Stimulsoft.Report.Chart.StiMarker Item17_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item17_SeriesLabels;
        public Stimulsoft.Report.Chart.StiOutsideEndAxisLabels Chart7_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Chart.StiChart Chart13;
        public Stimulsoft.Report.Chart.StiFullStackedLineArea Chart13_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart13_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedLineSeries Item20;
        public Stimulsoft.Report.Chart.StiLineMarker Item20_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item20_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item20_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedLineSeries Item21;
        public Stimulsoft.Report.Chart.StiLineMarker Item21_LineMarker;
        public Stimulsoft.Report.Chart.StiMarker Item21_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item21_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart13_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChart Chart8;
        public Stimulsoft.Report.Chart.StiFullStackedSplineArea Chart8_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart8_Legend;
        public Stimulsoft.Report.Chart.StiFullStackedSplineSeries Item23;
        public Stimulsoft.Report.Chart.StiMarker Item23_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item23_SeriesLabels;
        public Stimulsoft.Report.Chart.StiFullStackedSplineSeries Item24;
        public Stimulsoft.Report.Chart.StiMarker Item24_Marker;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item24_SeriesLabels;
        public Stimulsoft.Report.Chart.StiInsideEndAxisLabels Chart8_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiWatermark Page2_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Line";
        }
        
        public void Item4__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item4__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;25;15;15";
        }
        
        public void Item4__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item5__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item5__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;15;25;10";
        }
        
        public void Item5__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stacked Line";
        }
        
        public void Item8__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item8__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;25;15;15";
        }
        
        public void Item8__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item9__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item9__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;15;15;25;10";
        }
        
        public void Item9__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Item11__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item11__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item11__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item12__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item12__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item12__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
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
        
        public void Item16__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item16__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item16__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item17__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item17__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item17__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Line";
        }
        
        public void Item20__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item20__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item20__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item21__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item21__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item21__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Item23__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item23__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;10;30;50;40;60";
        }
        
        public void Item23__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 1";
        }
        
        public void Item24__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5;6;7";
        }
        
        public void Item24__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "60;30;50;30;15;10;25";
        }
        
        public void Item24__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Row 2";
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Full-Stacked Spline";
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
            this.Page2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Page2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.8, 9.4, 0.6);
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text9.Guid = null;
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart10_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart10_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart10_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart10_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart10_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart10_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart10_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart10_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart10_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart10_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart10.Guid = null;
            this.Chart10.Interaction = null;
            this.Chart10_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart10_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart10_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart10_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart10_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart10.MasterComponent = null;
            // 
            // Item4
            // 
            this.Item4 = new Stimulsoft.Report.Chart.StiStackedLineSeries();
            this.Item4.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item4.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item4__GetListOfArguments);
            this.Item4.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item4__GetListOfValues);
            this.Item4.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item4__GetTitle);
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
            this.Item5 = new Stimulsoft.Report.Chart.StiStackedLineSeries();
            this.Item5.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item5.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfArguments);
            this.Item5.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfValues);
            this.Item5.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item5__GetTitle);
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
            this.Chart10_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart10_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart10_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart10_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart10_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart10_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart10.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart10.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 0.8, 9.4, 0.6);
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text10.Guid = null;
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart11_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart11_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart11_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart11_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart11_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart11_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart11_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart11_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart11_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart11_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart11.Guid = null;
            this.Chart11.Interaction = null;
            this.Chart11_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart11_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart11_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart11_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart11_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart11.MasterComponent = null;
            // 
            // Item8
            // 
            this.Item8 = new Stimulsoft.Report.Chart.StiLineSeries();
            this.Item8.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item8.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfArguments);
            this.Item8.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfValues);
            this.Item8.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item8__GetTitle);
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
            this.Item9 = new Stimulsoft.Report.Chart.StiLineSeries();
            this.Item9.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item9.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item9__GetListOfArguments);
            this.Item9.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item9__GetListOfValues);
            this.Item9.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item9__GetTitle);
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
            this.Chart11_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideAxisLabels();
            this.Chart11_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart11_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart11_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart11_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart11_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart11.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart11.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart12_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart12_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart12_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart12_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart12_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart12_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart12_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart12_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart12_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart12_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart12.Guid = null;
            this.Chart12.Interaction = null;
            this.Chart12_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart12_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_Legend.Columns = 1;
            this.Chart12_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart12_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart12_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart12_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart12_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart12.MasterComponent = null;
            // 
            // Item11
            // 
            this.Item11 = new Stimulsoft.Report.Chart.StiSplineSeries();
            this.Item11.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item11.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item11__GetListOfArguments);
            this.Item11.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item11__GetListOfValues);
            this.Item11.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item11__GetTitle);
            this.Item11.DrillDownPageGuid = null;
            this.Item11_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item11_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item11_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
            this.Item11_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item11_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item11_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item11_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item11_SeriesLabels.ValueTypeSeparator = "-";
            this.Item11_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item11_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item12
            // 
            this.Item12 = new Stimulsoft.Report.Chart.StiSplineSeries();
            this.Item12.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item12.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item12__GetListOfArguments);
            this.Item12.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item12__GetListOfValues);
            this.Item12.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item12__GetTitle);
            this.Item12.DrillDownPageGuid = null;
            this.Item12_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item12_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item12_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 240, 165));
            this.Item12_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item12_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item12_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item12_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item12_SeriesLabels.ValueTypeSeparator = "-";
            this.Item12_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item12_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart12_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideEndAxisLabels();
            this.Chart12_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart12_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart12_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart12_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart12_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart12.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart12.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.8, 9.4, 0.6);
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text12.Guid = null;
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 9.8, 9.4, 0.6);
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text5.Guid = null;
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart7_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart7_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart7_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart7_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart7_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart7_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart7_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart7_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart7_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart7_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart7.Guid = null;
            this.Chart7.Interaction = null;
            this.Chart7_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart7_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_Legend.Columns = 1;
            this.Chart7_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart7_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.BottomOutside;
            this.Chart7_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart7_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart7_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart7.MasterComponent = null;
            // 
            // Item16
            // 
            this.Item16 = new Stimulsoft.Report.Chart.StiStackedSplineSeries();
            this.Item16.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item16.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item16__GetListOfArguments);
            this.Item16.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item16__GetListOfValues);
            this.Item16.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item16__GetTitle);
            this.Item16.DrillDownPageGuid = null;
            this.Item16_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item16_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item16_Marker.Type = Stimulsoft.Report.Chart.StiMarkerType.Rectangle;
            this.Item16_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
            this.Item16_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item16_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item16_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item16_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item16_SeriesLabels.ValueTypeSeparator = "-";
            this.Item16_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item16_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item17
            // 
            this.Item17 = new Stimulsoft.Report.Chart.StiStackedSplineSeries();
            this.Item17.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item17.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item17__GetListOfArguments);
            this.Item17.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item17__GetListOfValues);
            this.Item17.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item17__GetTitle);
            this.Item17.DrillDownPageGuid = null;
            this.Item17_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item17_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item17_Marker.Type = Stimulsoft.Report.Chart.StiMarkerType.Rectangle;
            this.Item17_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 240, 165));
            this.Item17_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item17_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item17_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item17_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item17_SeriesLabels.ValueTypeSeparator = "-";
            this.Item17_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item17_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart7_SeriesLabels = new Stimulsoft.Report.Chart.StiOutsideEndAxisLabels();
            this.Chart7_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart7_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart7_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart7_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart7_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart7.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart7.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19, 9.4, 0.6);
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text11.Guid = null;
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
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
            this.Chart13_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart13_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart13_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart13_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart13_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart13_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart13_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart13_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart13_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart13_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart13.Guid = null;
            this.Chart13.Interaction = null;
            this.Chart13_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart13_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.LeftOutside;
            this.Chart13_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart13_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart13_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart13_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart13.MasterComponent = null;
            // 
            // Item20
            // 
            this.Item20 = new Stimulsoft.Report.Chart.StiFullStackedLineSeries();
            this.Item20.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item20.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item20__GetListOfArguments);
            this.Item20.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item20__GetListOfValues);
            this.Item20.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item20__GetTitle);
            this.Item20.DrillDownPageGuid = null;
            this.Item20_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item20_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 44, 0, 0);
            this.Item20_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 244, 167, 103));
            this.Item20_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item20_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item20_Marker.Type = Stimulsoft.Report.Chart.StiMarkerType.Triangle;
            this.Item20_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 217, 153));
            this.Item20_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item20_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item20_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item20_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item20_SeriesLabels.ValueTypeSeparator = "-";
            this.Item20_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item20_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            // 
            // Item21
            // 
            this.Item21 = new Stimulsoft.Report.Chart.StiFullStackedLineSeries();
            this.Item21.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item21.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item21__GetListOfArguments);
            this.Item21.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item21__GetListOfValues);
            this.Item21.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item21__GetTitle);
            this.Item21.DrillDownPageGuid = null;
            this.Item21_LineMarker = new Stimulsoft.Report.Chart.StiLineMarker();
            this.Item21_LineMarker.BorderColor = System.Windows.Media.Color.FromArgb(255, 81, 0, 0);
            this.Item21_LineMarker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 190, 115));
            this.Item21_Marker = new Stimulsoft.Report.Chart.StiMarker();
            this.Item21_Marker.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item21_Marker.Type = Stimulsoft.Report.Chart.StiMarkerType.Triangle;
            this.Item21_Marker.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 240, 165));
            this.Item21_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item21_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item21_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item21_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item21_SeriesLabels.ValueTypeSeparator = "-";
            this.Item21_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item21_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart13_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart13_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart13_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart13_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart13_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart13_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart13.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart13.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
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
            this.Chart8_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart8_Area.GridLinesHor = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart8_Area.GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Windows.Media.Color.FromArgb(255, 192, 192, 192), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(255, 220, 220, 220), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart8_Area.GridLinesVert = new Stimulsoft.Report.Chart.StiGridLinesVert(System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Windows.Media.Color.FromArgb(100, 95, 72, 29), Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true);
            this.Chart8_Area.InterlacingHor = new Stimulsoft.Report.Chart.StiInterlacingHor(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart8_Area.InterlacingVert = new Stimulsoft.Report.Chart.StiInterlacingVert(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(10, 145, 122, 79)), false, true);
            this.Chart8_Area.XAxis = new Stimulsoft.Report.Chart.StiXBottomAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowXAxis.Both, false, true);
            this.Chart8_Area.XTopAxis = new Stimulsoft.Report.Chart.StiXTopAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, false, true);
            this.Chart8_Area.YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true);
            this.Chart8_Area.YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Report.Chart.StiMarkerAlignment.Right, 0F, true), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Windows.Media.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.LeftToRight, true), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Windows.Media.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true);
            this.Chart8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart8.Guid = null;
            this.Chart8.Interaction = null;
            this.Chart8_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart8_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_Legend.HorAlignment = Stimulsoft.Report.Chart.StiLegendHorAlignment.RightOutside;
            this.Chart8_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart8_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart8_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart8_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart8.MasterComponent = null;
            // 
            // Item23
            // 
            this.Item23 = new Stimulsoft.Report.Chart.StiFullStackedSplineSeries();
            this.Item23.LineColor = System.Windows.Media.Color.FromArgb(255, 194, 117, 53);
            this.Item23.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item23__GetListOfArguments);
            this.Item23.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item23__GetListOfValues);
            this.Item23.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item23__GetTitle);
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
            this.Item24 = new Stimulsoft.Report.Chart.StiFullStackedSplineSeries();
            this.Item24.LineColor = System.Windows.Media.Color.FromArgb(255, 231, 140, 65);
            this.Item24.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item24__GetListOfArguments);
            this.Item24.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item24__GetListOfValues);
            this.Item24.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item24__GetTitle);
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
            this.Chart8_SeriesLabels = new Stimulsoft.Report.Chart.StiInsideEndAxisLabels();
            this.Chart8_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart8_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart8_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart8_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart8_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart8.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart8.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.6, 19, 9.4, 0.6);
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text6.Guid = null;
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Page2.ExcelSheetValue = null;
            this.Page2.Interaction = null;
            this.Page2.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page2_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page2_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page2_Watermark.Image = null;
            this.Page2_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
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
            this.Item4.Chart = this.Chart10;
            this.Item4.LineMarker = this.Item4_LineMarker;
            this.Item4.Marker = this.Item4_Marker;
            this.Item4.SeriesLabels = this.Item4_SeriesLabels;
            this.Item4_SeriesLabels.Chart = this.Chart10;
            this.Item5.Chart = this.Chart10;
            this.Item5.LineMarker = this.Item5_LineMarker;
            this.Item5.Marker = this.Item5_Marker;
            this.Item5.SeriesLabels = this.Item5_SeriesLabels;
            this.Item5_SeriesLabels.Chart = this.Chart10;
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
            this.Item8.Chart = this.Chart11;
            this.Item8.LineMarker = this.Item8_LineMarker;
            this.Item8.Marker = this.Item8_Marker;
            this.Item8.SeriesLabels = this.Item8_SeriesLabels;
            this.Item8_SeriesLabels.Chart = this.Chart11;
            this.Item9.Chart = this.Chart11;
            this.Item9.LineMarker = this.Item9_LineMarker;
            this.Item9.Marker = this.Item9_Marker;
            this.Item9.SeriesLabels = this.Item9_SeriesLabels;
            this.Item9_SeriesLabels.Chart = this.Chart11;
            this.Chart11_SeriesLabels.Chart = this.Chart11;
            this.Chart12.Area = this.Chart12_Area;
            this.Chart12.Legend = this.Chart12_Legend;
            this.Chart12.Page = this.Page2;
            this.Chart12.Parent = this.Page2;
            this.Chart12.SeriesLabels = this.Chart12_SeriesLabels;
            this.Chart12_Area.Chart = this.Chart12;
            this.Chart12_Legend.Chart = this.Chart12;
            this.Item11.Chart = this.Chart12;
            this.Item11.Marker = this.Item11_Marker;
            this.Item11.SeriesLabels = this.Item11_SeriesLabels;
            this.Item11_SeriesLabels.Chart = this.Chart12;
            this.Item12.Chart = this.Chart12;
            this.Item12.Marker = this.Item12_Marker;
            this.Item12.SeriesLabels = this.Item12_SeriesLabels;
            this.Item12_SeriesLabels.Chart = this.Chart12;
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
            this.Item16.Chart = this.Chart7;
            this.Item16.Marker = this.Item16_Marker;
            this.Item16.SeriesLabels = this.Item16_SeriesLabels;
            this.Item16_SeriesLabels.Chart = this.Chart7;
            this.Item17.Chart = this.Chart7;
            this.Item17.Marker = this.Item17_Marker;
            this.Item17.SeriesLabels = this.Item17_SeriesLabels;
            this.Item17_SeriesLabels.Chart = this.Chart7;
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
            this.Item20.Chart = this.Chart13;
            this.Item20.LineMarker = this.Item20_LineMarker;
            this.Item20.Marker = this.Item20_Marker;
            this.Item20.SeriesLabels = this.Item20_SeriesLabels;
            this.Item20_SeriesLabels.Chart = this.Chart13;
            this.Item21.Chart = this.Chart13;
            this.Item21.LineMarker = this.Item21_LineMarker;
            this.Item21.Marker = this.Item21_Marker;
            this.Item21.SeriesLabels = this.Item21_SeriesLabels;
            this.Item21_SeriesLabels.Chart = this.Chart13;
            this.Chart13_SeriesLabels.Chart = this.Chart13;
            this.Chart8.Area = this.Chart8_Area;
            this.Chart8.Legend = this.Chart8_Legend;
            this.Chart8.Page = this.Page2;
            this.Chart8.Parent = this.Page2;
            this.Chart8.SeriesLabels = this.Chart8_SeriesLabels;
            this.Chart8_Area.Chart = this.Chart8;
            this.Chart8_Legend.Chart = this.Chart8;
            this.Item23.Chart = this.Chart8;
            this.Item23.Marker = this.Item23_Marker;
            this.Item23.SeriesLabels = this.Item23_SeriesLabels;
            this.Item23_SeriesLabels.Chart = this.Chart8;
            this.Item24.Chart = this.Chart8;
            this.Item24.Marker = this.Item24_Marker;
            this.Item24.SeriesLabels = this.Item24_SeriesLabels;
            this.Item24_SeriesLabels.Chart = this.Chart8;
            this.Chart8_SeriesLabels.Chart = this.Chart8;
            this.Text6.Page = this.Page2;
            this.Text6.Parent = this.Page2;
            // 
            // Add to Chart10.Series
            // 
            this.Chart10.Series.Clear();
            this.Chart10.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item4,
                        this.Item5});
            // 
            // Add to Chart11.Series
            // 
            this.Chart11.Series.Clear();
            this.Chart11.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item8,
                        this.Item9});
            // 
            // Add to Chart12.Series
            // 
            this.Chart12.Series.Clear();
            this.Chart12.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item11,
                        this.Item12});
            // 
            // Add to Chart7.Series
            // 
            this.Chart7.Series.Clear();
            this.Chart7.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item16,
                        this.Item17});
            // 
            // Add to Chart13.Series
            // 
            this.Chart13.Series.Clear();
            this.Chart13.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item20,
                        this.Item21});
            // 
            // Add to Chart8.Series
            // 
            this.Chart8.Series.Clear();
            this.Chart8.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item23,
                        this.Item24});
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
        }
        #endregion StiReport Designer generated code - do not modify
    }
}