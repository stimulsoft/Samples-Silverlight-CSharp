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
    public class ChartPieAndDoughnut : Stimulsoft.Report.StiReport
    {
        public ChartPieAndDoughnut()
        {
            this.InitializeComponent();
        }

        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Components.StiPage Page4;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Chart.StiChart Chart14;
        public Stimulsoft.Report.Chart.StiDoughnutArea Chart14_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart14_Legend;
        public Stimulsoft.Report.Chart.StiDoughnutSeries Item4;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item4_SeriesLabels;
        public Stimulsoft.Report.Chart.StiDoughnutSeries Item5;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item5_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterPieLabels Chart14_SeriesLabels;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Chart.StiChart Chart15;
        public Stimulsoft.Report.Chart.StiPieArea Chart15_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart15_Legend;
        public Stimulsoft.Report.Chart.StiPieSeries Item8;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item8_SeriesLabels;
        public Stimulsoft.Report.Chart.StiCenterPieLabels Chart15_SeriesLabels;
        public Stimulsoft.Report.Components.StiWatermark Page4_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Pie";
        }
        
        public void Item4__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4";
        }
        
        public void Item4__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "10;20;50;30";
        }
        
        public void Item4__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
        
        public void Item5__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4";
        }
        
        public void Item5__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;7;13;4";
        }
        
        public void Item5__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 2";
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Doughnut";
        }
        
        public void Item8__GetListOfArguments(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "1;2;3;4;5";
        }
        
        public void Item8__GetListOfValues(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "20;30;10;30;25";
        }
        
        public void Item8__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
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
            this.ReportChanged = new DateTime(2007, 6, 18, 16, 35, 54, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2006, 6, 6, 13, 21, 42, 0);
            this.ReportDescription = "This sample demonstrates Pie and Doughnut chart types.";
            this.ReportFile = "E:\\Stimulsoft\\Stimulsoft.Reports\\Demo\\Bin\\Reports\\ChartPieAndDoughnut.mrt";
            this.ReportGuid = "65f2954927174faba70e6bebab79fd7e";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2010.3.900";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page4
            // 
            this.Page4 = new Stimulsoft.Report.Components.StiPage();
            this.Page4.Guid = "ddc4d878138648f48f653dad5e751f48";
            this.Page4.Name = "Page4";
            this.Page4.PageHeight = 29.7;
            this.Page4.PageWidth = 21;
            this.Page4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Page4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.8, 14.2, 12.2, 0.6);
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text13.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text13.Guid = null;
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart14
            // 
            this.Chart14 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.8, 1.4, 12.2, 11.8);
            this.Chart14.CountData = 10;
            this.Chart14.CustomStyleName = "";
            this.Chart14.FilterOn = false;
            this.Chart14.Name = "Chart14";
            this.Chart14.Sort = new System.String[0];
            this.Chart14_Area = new Stimulsoft.Report.Chart.StiDoughnutArea();
            this.Chart14_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart14_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Chart14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart14.Guid = null;
            this.Chart14.Interaction = null;
            this.Chart14_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart14_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart14_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart14_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart14_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart14_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart14_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart14_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart14_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart14.MasterComponent = null;
            // 
            // Item4
            // 
            this.Item4 = new Stimulsoft.Report.Chart.StiDoughnutSeries();
            this.Item4.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item4.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item4__GetListOfArguments);
            this.Item4.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item4__GetListOfValues);
            this.Item4.ShowShadow = false;
            this.Item4.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item4__GetTitle);
            this.Item4.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 144, 67, 3), System.Windows.Media.Color.FromArgb(255, 194, 117, 53), 0, 0.5F, 1F);
            this.Item4.DrillDownPageGuid = null;
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
            this.Item5 = new Stimulsoft.Report.Chart.StiDoughnutSeries();
            this.Item5.BorderColor = System.Windows.Media.Color.FromArgb(255, 131, 40, 0);
            this.Item5.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfArguments);
            this.Item5.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item5__GetListOfValues);
            this.Item5.ShowShadow = false;
            this.Item5.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item5__GetTitle);
            this.Item5.Brush = new Stimulsoft.Base.Drawing.StiGlareBrush(System.Windows.Media.Color.FromArgb(255, 181, 90, 15), System.Windows.Media.Color.FromArgb(255, 231, 140, 65), 0, 0.5F, 1F);
            this.Item5.DrillDownPageGuid = null;
            this.Item5_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item5_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item5_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Item5_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item5_SeriesLabels.ValueTypeSeparator = "-";
            this.Item5_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Item5_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart14_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterPieLabels();
            this.Chart14_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart14_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart14_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart14_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart14_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart14_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart14.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart14.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.8, 0.8, 12.2, 0.6);
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 169, 169, 169), System.Windows.Media.Color.FromArgb(255, 105, 105, 105), 0), false);
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text14.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text14.Guid = null;
            this.Text14.Indicator = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Chart15
            // 
            this.Chart15 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.8, 14.8, 12.2, 10.8);
            this.Chart15.CustomStyleName = "";
            this.Chart15.Name = "Chart15";
            this.Chart15.Sort = new System.String[0];
            this.Chart15_Area = new Stimulsoft.Report.Chart.StiPieArea();
            this.Chart15_Area.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart15_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 255, 219), 90);
            this.Chart15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)), false);
            this.Chart15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Chart15.Guid = null;
            this.Chart15.Interaction = null;
            this.Chart15_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart15_Legend.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart15_Legend.LabelsColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart15_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart15_Legend.TitleColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart15_Legend.VertAlignment = Stimulsoft.Report.Chart.StiLegendVertAlignment.TopOutside;
            this.Chart15_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255), System.Windows.Media.Color.FromArgb(255, 255, 242, 199), 90);
            this.Chart15_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart15_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart15.MasterComponent = null;
            // 
            // Item8
            // 
            this.Item8 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item8.BorderColor = System.Windows.Media.Color.FromArgb(255, 94, 17, 0);
            this.Item8.GetListOfArguments += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfArguments);
            this.Item8.GetListOfValues += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Item8__GetListOfValues);
            this.Item8.ShowShadow = false;
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
            this.Chart15_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterPieLabels();
            this.Chart15_SeriesLabels.BorderColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart15_SeriesLabels.LabelColor = System.Windows.Media.Color.FromArgb(255, 95, 72, 29);
            this.Chart15_SeriesLabels.LegendValueType = Stimulsoft.Report.Chart.StiSeriesLabelsValueType.ValueArgument;
            this.Chart15_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart15_SeriesLabels.ValueType = Stimulsoft.Report.Chart.StiSeriesLabelsValueType.ValueArgument;
            this.Chart15_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart15_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 245, 222, 179));
            this.Chart15_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart15.Style = new Stimulsoft.Report.Chart.StiStyle01();
            this.Chart15.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 95, 72, 29)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            this.Page4.ExcelSheetValue = null;
            this.Page4.Interaction = null;
            this.Page4.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page4_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page4_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page4_Watermark.Image = null;
            this.Page4_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page4.Report = this;
            this.Page4.Watermark = this.Page4_Watermark;
            this.Text13.Page = this.Page4;
            this.Text13.Parent = this.Page4;
            this.Chart14.Area = this.Chart14_Area;
            this.Chart14.Legend = this.Chart14_Legend;
            this.Chart14.Page = this.Page4;
            this.Chart14.Parent = this.Page4;
            this.Chart14.SeriesLabels = this.Chart14_SeriesLabels;
            this.Chart14_Area.Chart = this.Chart14;
            this.Chart14_Legend.Chart = this.Chart14;
            this.Item4.Chart = this.Chart14;
            this.Item4.SeriesLabels = this.Item4_SeriesLabels;
            this.Item4_SeriesLabels.Chart = this.Chart14;
            this.Item5.Chart = this.Chart14;
            this.Item5.SeriesLabels = this.Item5_SeriesLabels;
            this.Item5_SeriesLabels.Chart = this.Chart14;
            this.Chart14_SeriesLabels.Chart = this.Chart14;
            this.Text14.Page = this.Page4;
            this.Text14.Parent = this.Page4;
            this.Chart15.Area = this.Chart15_Area;
            this.Chart15.Legend = this.Chart15_Legend;
            this.Chart15.Page = this.Page4;
            this.Chart15.Parent = this.Page4;
            this.Chart15.SeriesLabels = this.Chart15_SeriesLabels;
            this.Chart15_Area.Chart = this.Chart15;
            this.Chart15_Legend.Chart = this.Chart15;
            this.Item8.Chart = this.Chart15;
            this.Item8.SeriesLabels = this.Item8_SeriesLabels;
            this.Item8_SeriesLabels.Chart = this.Chart15;
            this.Chart15_SeriesLabels.Chart = this.Chart15;
            // 
            // Add to Chart14.Series
            // 
            this.Chart14.Series.Clear();
            this.Chart14.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item4,
                        this.Item5});
            // 
            // Add to Chart15.Series
            // 
            this.Chart15.Series.Clear();
            this.Chart15.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item8});
            // 
            // Add to Page4.Components
            // 
            this.Page4.Components.Clear();
            this.Page4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text13,
                        this.Chart14,
                        this.Text14,
                        this.Chart15});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page4});
        }
        #endregion StiReport Designer generated code - do not modify
    }
}