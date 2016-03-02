using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace Reports
{
    public class Shapes : Stimulsoft.Report.StiReport
    {
        public Shapes()
        {
            this.InitializeComponent();
        }
        
        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiShape Shape1;
        public Stimulsoft.Report.Components.StiShape Shape3;
        public Stimulsoft.Report.Components.StiShape Shape2;
        public Stimulsoft.Report.Components.StiShape Shape4;
        public Stimulsoft.Report.Components.StiShape Shape19;
        public Stimulsoft.Report.Components.StiShape Shape5;
        public Stimulsoft.Report.Components.StiShape Shape6;
        public Stimulsoft.Report.Components.StiShape Shape7;
        public Stimulsoft.Report.Components.StiShape Shape8;
        public Stimulsoft.Report.Components.StiShape Shape9;
        public Stimulsoft.Report.Components.StiShape Shape10;
        public Stimulsoft.Report.Components.StiShape Shape11;
        public Stimulsoft.Report.Components.StiShape Shape12;
        public Stimulsoft.Report.Components.StiShape Shape13;
        public Stimulsoft.Report.Components.StiShape Shape14;
        public Stimulsoft.Report.Components.StiShape Shape15;
        public Stimulsoft.Report.Components.StiShape Shape16;
        public Stimulsoft.Report.Components.StiShape Shape17;
        public Stimulsoft.Report.Components.StiShape Shape18;
        public Stimulsoft.Report.Components.StiShape Shape20;
        public Stimulsoft.Report.Components.StiShape Shape21;
        public Stimulsoft.Report.Components.StiShape Shape22;
        public Stimulsoft.Report.Components.StiShape Shape24;
        public Stimulsoft.Report.Components.StiShape Shape25;
        public Stimulsoft.Report.Components.StiShape Shape26;
        public Stimulsoft.Report.Components.StiShape Shape27;
        public Stimulsoft.Report.Components.StiShape Shape28;
        public Stimulsoft.Report.Components.StiShape Shape29;
        public Stimulsoft.Report.Components.StiShape Shape30;
        public Stimulsoft.Report.Components.StiShape Shape31;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand2;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stimulsoft";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Shapes";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text18.TextFormat.Format(CheckExcelValue(sender, "Date: " + Today.ToString("Y")));
        }
        
        private void InitializeComponent()
        {
            this.NeedsCompiling = false;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.PreviewMode = Stimulsoft.Report.StiPreviewMode.StandardAndDotMatrix;
            this.PreviewSettings = 33538047;
            this.ReferencedAssemblies = new System.String[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Shapes";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 4, 2, 11, 33, 33, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "This sample demonstrates how to create a report with shapes.";
            this.ReportFile = "D:\\002\\Shapes.mrt";
            this.ReportGuid = "ef45c8c927f94451b175b7551d430869";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.1000";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "6f2b2cabb01546738f4e441fd2de86dc";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 29.7;
            this.Page1.PageWidth = 21;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Shape1
            // 
            this.Shape1 = new Stimulsoft.Report.Components.StiShape();
            this.Shape1.BorderColor = System.Drawing.Color.Transparent;
            this.Shape1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.2, 3.2, 2.6, 2.6);
            this.Shape1.Name = "Shape1";
            this.Shape1.Size = 3F;
            this.Shape1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 199, 209, 222));
            this.Shape1.Guid = null;
            this.Shape1.Interaction = null;
            this.Shape1.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiRectangleShapeType();
            // 
            // Shape3
            // 
            this.Shape3 = new Stimulsoft.Report.Components.StiShape();
            this.Shape3.BorderColor = System.Drawing.Color.Transparent;
            this.Shape3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.4, 3.2, 2.6, 2.6);
            this.Shape3.Name = "Shape3";
            this.Shape3.Size = 3F;
            this.Shape3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 199, 209, 222));
            this.Shape3.Guid = null;
            this.Shape3.Interaction = null;
            this.Shape3.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiRoundedRectangleShapeType(0.2F);
            // 
            // Shape2
            // 
            this.Shape2 = new Stimulsoft.Report.Components.StiShape();
            this.Shape2.BorderColor = System.Drawing.Color.Transparent;
            this.Shape2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.6, 3.2, 2.6, 2.6);
            this.Shape2.Name = "Shape2";
            this.Shape2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 173, 193, 217));
            this.Shape2.Guid = null;
            this.Shape2.Interaction = null;
            this.Shape2.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiSnipSameSideCornerRectangleShapeType();
            // 
            // Shape4
            // 
            this.Shape4 = new Stimulsoft.Report.Components.StiShape();
            this.Shape4.BorderColor = System.Drawing.Color.Transparent;
            this.Shape4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.8, 3.2, 2.6, 2.6);
            this.Shape4.Name = "Shape4";
            this.Shape4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 173, 193, 217));
            this.Shape4.Guid = null;
            this.Shape4.Interaction = null;
            this.Shape4.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiFlowchartCardShapeType();
            // 
            // Shape19
            // 
            this.Shape19 = new Stimulsoft.Report.Components.StiShape();
            this.Shape19.BorderColor = System.Drawing.Color.Transparent;
            this.Shape19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13, 3.2, 2.6, 2.6);
            this.Shape19.Name = "Shape19";
            this.Shape19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 87, 118, 157));
            this.Shape19.Guid = null;
            this.Shape19.Interaction = null;
            this.Shape19.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiSnipDiagonalSideCornerRectangleShapeType();
            // 
            // Shape5
            // 
            this.Shape5 = new Stimulsoft.Report.Components.StiShape();
            this.Shape5.BorderColor = System.Drawing.Color.Transparent;
            this.Shape5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.2, 6.6, 2.6, 2.6);
            this.Shape5.Name = "Shape5";
            this.Shape5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 144, 60, 57));
            this.Shape5.Guid = null;
            this.Shape5.Interaction = null;
            this.Shape5.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiOvalShapeType();
            // 
            // Shape6
            // 
            this.Shape6 = new Stimulsoft.Report.Components.StiShape();
            this.Shape6.BorderColor = System.Drawing.Color.Transparent;
            this.Shape6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.4, 6.6, 2.6, 2.6);
            this.Shape6.Name = "Shape6";
            this.Shape6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 144, 60, 57));
            this.Shape6.Guid = null;
            this.Shape6.Interaction = null;
            this.Shape6.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiTriangleShapeType(Stimulsoft.Report.Components.ShapeTypes.StiShapeDirection.Up);
            // 
            // Shape7
            // 
            this.Shape7 = new Stimulsoft.Report.Components.StiShape();
            this.Shape7.BorderColor = System.Drawing.Color.Transparent;
            this.Shape7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.6, 6.6, 2.6, 2.6);
            this.Shape7.Name = "Shape7";
            this.Shape7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 207, 123, 121));
            this.Shape7.Guid = null;
            this.Shape7.Interaction = null;
            this.Shape7.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiFlowchartDecisionShapeType();
            // 
            // Shape8
            // 
            this.Shape8 = new Stimulsoft.Report.Components.StiShape();
            this.Shape8.BorderColor = System.Drawing.Color.Transparent;
            this.Shape8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16.2, 3.2, 2.6, 2.6);
            this.Shape8.Name = "Shape8";
            this.Shape8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 87, 118, 157));
            this.Shape8.Guid = null;
            this.Shape8.Interaction = null;
            this.Shape8.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiFlowchartManualInputShapeType();
            // 
            // Shape9
            // 
            this.Shape9 = new Stimulsoft.Report.Components.StiShape();
            this.Shape9.BorderColor = System.Drawing.Color.Transparent;
            this.Shape9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.8, 6.6, 2.6, 2.6);
            this.Shape9.Name = "Shape9";
            this.Shape9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 207, 123, 121));
            this.Shape9.Guid = null;
            this.Shape9.Interaction = null;
            this.Shape9.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiTriangleShapeType(Stimulsoft.Report.Components.ShapeTypes.StiShapeDirection.Down);
            // 
            // Shape10
            // 
            this.Shape10 = new Stimulsoft.Report.Components.StiShape();
            this.Shape10.BorderColor = System.Drawing.Color.Transparent;
            this.Shape10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.2, 10, 2.6, 2.6);
            this.Shape10.Name = "Shape10";
            this.Shape10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 206, 221, 176));
            this.Shape10.Guid = null;
            this.Shape10.Interaction = null;
            this.Shape10.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiFlowchartOffPageConnectorShapeType();
            // 
            // Shape11
            // 
            this.Shape11 = new Stimulsoft.Report.Components.StiShape();
            this.Shape11.BorderColor = System.Drawing.Color.Transparent;
            this.Shape11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.4, 10, 2.6, 2.6);
            this.Shape11.Name = "Shape11";
            this.Shape11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 206, 221, 176));
            this.Shape11.Guid = null;
            this.Shape11.Interaction = null;
            this.Shape11.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiFlowchartPreparationShapeType();
            // 
            // Shape12
            // 
            this.Shape12 = new Stimulsoft.Report.Components.StiShape();
            this.Shape12.BorderColor = System.Drawing.Color.Transparent;
            this.Shape12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.6, 10, 2.6, 2.6);
            this.Shape12.Name = "Shape12";
            this.Shape12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 181, 204, 136));
            this.Shape12.Guid = null;
            this.Shape12.Interaction = null;
            this.Shape12.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiRegularPentagonShapeType();
            // 
            // Shape13
            // 
            this.Shape13 = new Stimulsoft.Report.Components.StiShape();
            this.Shape13.BorderColor = System.Drawing.Color.Transparent;
            this.Shape13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.8, 10, 2.6, 2.6);
            this.Shape13.Name = "Shape13";
            this.Shape13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 181, 204, 136));
            this.Shape13.Guid = null;
            this.Shape13.Interaction = null;
            this.Shape13.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiTrapezoidShapeType();
            // 
            // Shape14
            // 
            this.Shape14 = new Stimulsoft.Report.Components.StiShape();
            this.Shape14.BorderColor = System.Drawing.Color.Transparent;
            this.Shape14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13, 10, 2.6, 2.6);
            this.Shape14.Name = "Shape14";
            this.Shape14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 117, 140, 72));
            this.Shape14.Guid = null;
            this.Shape14.Interaction = null;
            this.Shape14.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiFlowchartSortShapeType();
            // 
            // Shape15
            // 
            this.Shape15 = new Stimulsoft.Report.Components.StiShape();
            this.Shape15.BorderColor = System.Drawing.Color.Transparent;
            this.Shape15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16.2, 6.6, 2.6, 2.6);
            this.Shape15.Name = "Shape15";
            this.Shape15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 223, 167, 166));
            this.Shape15.Guid = null;
            this.Shape15.Interaction = null;
            this.Shape15.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiFrameShapeType();
            // 
            // Shape16
            // 
            this.Shape16 = new Stimulsoft.Report.Components.StiShape();
            this.Shape16.BorderColor = System.Drawing.Color.Transparent;
            this.Shape16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13, 6.6, 2.6, 2.6);
            this.Shape16.Name = "Shape16";
            this.Shape16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 223, 167, 166));
            this.Shape16.Guid = null;
            this.Shape16.Interaction = null;
            this.Shape16.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiParallelogramShapeType();
            // 
            // Shape17
            // 
            this.Shape17 = new Stimulsoft.Report.Components.StiShape();
            this.Shape17.BorderColor = System.Drawing.Color.Transparent;
            this.Shape17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16.2, 10, 2.6, 2.6);
            this.Shape17.Name = "Shape17";
            this.Shape17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 117, 140, 72));
            this.Shape17.Guid = null;
            this.Shape17.Interaction = null;
            this.Shape17.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiFlowchartCollateShapeType();
            // 
            // Shape18
            // 
            this.Shape18 = new Stimulsoft.Report.Components.StiShape();
            this.Shape18.BorderColor = System.Drawing.Color.Transparent;
            this.Shape18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.2, 13.4, 2.6, 2.6);
            this.Shape18.Name = "Shape18";
            this.Shape18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 56, 129, 148));
            this.Shape18.Guid = null;
            this.Shape18.Interaction = null;
            this.Shape18.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiArrowShapeType(Stimulsoft.Report.Components.ShapeTypes.StiShapeDirection.Left, 0.3F, 0.4F);
            // 
            // Shape20
            // 
            this.Shape20 = new Stimulsoft.Report.Components.StiShape();
            this.Shape20.BorderColor = System.Drawing.Color.Transparent;
            this.Shape20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.4, 13.4, 2.6, 2.6);
            this.Shape20.Name = "Shape20";
            this.Shape20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 56, 129, 148));
            this.Shape20.Guid = null;
            this.Shape20.Interaction = null;
            this.Shape20.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiArrowShapeType(Stimulsoft.Report.Components.ShapeTypes.StiShapeDirection.Up, 0.3F, 0.4F);
            // 
            // Shape21
            // 
            this.Shape21 = new Stimulsoft.Report.Components.StiShape();
            this.Shape21.BorderColor = System.Drawing.Color.Transparent;
            this.Shape21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.6, 13.4, 2.6, 2.6);
            this.Shape21.Name = "Shape21";
            this.Shape21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 120, 192, 212));
            this.Shape21.Guid = null;
            this.Shape21.Interaction = null;
            this.Shape21.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiArrowShapeType(Stimulsoft.Report.Components.ShapeTypes.StiShapeDirection.Right, 0.3F, 0.4F);
            // 
            // Shape22
            // 
            this.Shape22 = new Stimulsoft.Report.Components.StiShape();
            this.Shape22.BorderColor = System.Drawing.Color.Transparent;
            this.Shape22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.8, 13.4, 2.6, 2.6);
            this.Shape22.Name = "Shape22";
            this.Shape22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 120, 192, 212));
            this.Shape22.Guid = null;
            this.Shape22.Interaction = null;
            this.Shape22.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiArrowShapeType(Stimulsoft.Report.Components.ShapeTypes.StiShapeDirection.Down, 0.3F, 0.4F);
            // 
            // Shape24
            // 
            this.Shape24 = new Stimulsoft.Report.Components.StiShape();
            this.Shape24.BorderColor = System.Drawing.Color.Transparent;
            this.Shape24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16.2, 13.4, 2.6, 2.6);
            this.Shape24.Name = "Shape24";
            this.Shape24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 165, 213, 226));
            this.Shape24.Guid = null;
            this.Shape24.Interaction = null;
            this.Shape24.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiComplexArrowShapeType();
            // 
            // Shape25
            // 
            this.Shape25 = new Stimulsoft.Report.Components.StiShape();
            this.Shape25.BorderColor = System.Drawing.Color.Transparent;
            this.Shape25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.2, 16.8, 2.6, 2.6);
            this.Shape25.Name = "Shape25";
            this.Shape25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 250, 206, 170));
            this.Shape25.Guid = null;
            this.Shape25.Interaction = null;
            this.Shape25.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiPlusShapeType();
            // 
            // Shape26
            // 
            this.Shape26 = new Stimulsoft.Report.Components.StiShape();
            this.Shape26.BorderColor = System.Drawing.Color.Transparent;
            this.Shape26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.4, 16.8, 2.6, 2.6);
            this.Shape26.Name = "Shape26";
            this.Shape26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 250, 206, 170));
            this.Shape26.Guid = null;
            this.Shape26.Interaction = null;
            this.Shape26.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiMinusShapeType();
            // 
            // Shape27
            // 
            this.Shape27 = new Stimulsoft.Report.Components.StiShape();
            this.Shape27.BorderColor = System.Drawing.Color.Transparent;
            this.Shape27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.6, 16.8, 2.6, 2.6);
            this.Shape27.Name = "Shape27";
            this.Shape27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 247, 181, 128));
            this.Shape27.Guid = null;
            this.Shape27.Interaction = null;
            this.Shape27.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiMultiplyShapeType();
            // 
            // Shape28
            // 
            this.Shape28 = new Stimulsoft.Report.Components.StiShape();
            this.Shape28.BorderColor = System.Drawing.Color.Transparent;
            this.Shape28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.8, 16.8, 2.6, 2.6);
            this.Shape28.Name = "Shape28";
            this.Shape28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 247, 181, 128));
            this.Shape28.Guid = null;
            this.Shape28.Interaction = null;
            this.Shape28.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiDivisionShapeType();
            // 
            // Shape29
            // 
            this.Shape29 = new Stimulsoft.Report.Components.StiShape();
            this.Shape29.BorderColor = System.Drawing.Color.Transparent;
            this.Shape29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13, 16.8, 2.6, 2.6);
            this.Shape29.Name = "Shape29";
            this.Shape29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 183, 117, 64));
            this.Shape29.Guid = null;
            this.Shape29.Interaction = null;
            this.Shape29.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiEqualShapeType();
            // 
            // Shape30
            // 
            this.Shape30 = new Stimulsoft.Report.Components.StiShape();
            this.Shape30.BorderColor = System.Drawing.Color.Transparent;
            this.Shape30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16.2, 16.8, 2.6, 2.6);
            this.Shape30.Name = "Shape30";
            this.Shape30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 183, 117, 64));
            this.Shape30.Guid = null;
            this.Shape30.Interaction = null;
            this.Shape30.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiBentArrowShapeType();
            // 
            // Shape31
            // 
            this.Shape31 = new Stimulsoft.Report.Components.StiShape();
            this.Shape31.BorderColor = System.Drawing.Color.Transparent;
            this.Shape31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13, 13.4, 2.6, 2.6);
            this.Shape31.Name = "Shape31";
            this.Shape31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 165, 213, 226));
            this.Shape31.Guid = null;
            this.Shape31.Interaction = null;
            this.Shape31.ShapeType = new Stimulsoft.Report.Components.ShapeTypes.StiChevronShapeType();
            // 
            // ReportTitleBand2
            // 
            this.ReportTitleBand2 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 2);
            this.ReportTitleBand2.Guid = "1127d071d9be434e80a3ea6e1dbf542e";
            this.ReportTitleBand2.Name = "ReportTitleBand2";
            this.ReportTitleBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.ReportTitleBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.4, 0, 9.6, 0.8);
            this.Text20.Guid = "c5e150d59a81471788ac67e868919bde";
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
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
            this.Text23.Guid = "df68c258ca7841dc8a0ac5641b5a28b9";
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text23.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
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
            this.Text17.Guid = "18d08c97bc274503bc727e82e0814fae";
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
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
            this.Text18.Guid = "8499eda182e74a5ab2015fdf8af8b4a7";
            this.Text18.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text18.Font = new System.Drawing.Font("Arial", 9F);
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text18.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("yyyy, MMMM", " ");
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand2.Interaction = null;
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
            this.DataBandsUsedInPageTotals = new System.String[] {
                    "DataBand2"};
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.Shape1.Page = this.Page1;
            this.Shape1.Parent = this.Page1;
            this.Shape3.Page = this.Page1;
            this.Shape3.Parent = this.Page1;
            this.Shape2.Page = this.Page1;
            this.Shape2.Parent = this.Page1;
            this.Shape4.Page = this.Page1;
            this.Shape4.Parent = this.Page1;
            this.Shape19.Page = this.Page1;
            this.Shape19.Parent = this.Page1;
            this.Shape5.Page = this.Page1;
            this.Shape5.Parent = this.Page1;
            this.Shape6.Page = this.Page1;
            this.Shape6.Parent = this.Page1;
            this.Shape7.Page = this.Page1;
            this.Shape7.Parent = this.Page1;
            this.Shape8.Page = this.Page1;
            this.Shape8.Parent = this.Page1;
            this.Shape9.Page = this.Page1;
            this.Shape9.Parent = this.Page1;
            this.Shape10.Page = this.Page1;
            this.Shape10.Parent = this.Page1;
            this.Shape11.Page = this.Page1;
            this.Shape11.Parent = this.Page1;
            this.Shape12.Page = this.Page1;
            this.Shape12.Parent = this.Page1;
            this.Shape13.Page = this.Page1;
            this.Shape13.Parent = this.Page1;
            this.Shape14.Page = this.Page1;
            this.Shape14.Parent = this.Page1;
            this.Shape15.Page = this.Page1;
            this.Shape15.Parent = this.Page1;
            this.Shape16.Page = this.Page1;
            this.Shape16.Parent = this.Page1;
            this.Shape17.Page = this.Page1;
            this.Shape17.Parent = this.Page1;
            this.Shape18.Page = this.Page1;
            this.Shape18.Parent = this.Page1;
            this.Shape20.Page = this.Page1;
            this.Shape20.Parent = this.Page1;
            this.Shape21.Page = this.Page1;
            this.Shape21.Parent = this.Page1;
            this.Shape22.Page = this.Page1;
            this.Shape22.Parent = this.Page1;
            this.Shape24.Page = this.Page1;
            this.Shape24.Parent = this.Page1;
            this.Shape25.Page = this.Page1;
            this.Shape25.Parent = this.Page1;
            this.Shape26.Page = this.Page1;
            this.Shape26.Parent = this.Page1;
            this.Shape27.Page = this.Page1;
            this.Shape27.Parent = this.Page1;
            this.Shape28.Page = this.Page1;
            this.Shape28.Parent = this.Page1;
            this.Shape29.Page = this.Page1;
            this.Shape29.Parent = this.Page1;
            this.Shape30.Page = this.Page1;
            this.Shape30.Parent = this.Page1;
            this.Shape31.Page = this.Page1;
            this.Shape31.Parent = this.Page1;
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
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Shape1,
                        this.Shape3,
                        this.Shape2,
                        this.Shape4,
                        this.Shape19,
                        this.Shape5,
                        this.Shape6,
                        this.Shape7,
                        this.Shape8,
                        this.Shape9,
                        this.Shape10,
                        this.Shape11,
                        this.Shape12,
                        this.Shape13,
                        this.Shape14,
                        this.Shape15,
                        this.Shape16,
                        this.Shape17,
                        this.Shape18,
                        this.Shape20,
                        this.Shape21,
                        this.Shape22,
                        this.Shape24,
                        this.Shape25,
                        this.Shape26,
                        this.Shape27,
                        this.Shape28,
                        this.Shape29,
                        this.Shape30,
                        this.Shape31,
                        this.ReportTitleBand2});
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