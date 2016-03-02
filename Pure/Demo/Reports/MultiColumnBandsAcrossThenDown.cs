using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace Reports
{
    public class MultiColumnBandsAcrossThenDown : Stimulsoft.Report.StiReport
    {
        public MultiColumnBandsAcrossThenDown()
        {
            this.InitializeComponent();
        }
        
        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand2;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand2;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiColumnHeaderBand ColumnHeaderBand1;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive1;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive2;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive3;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive4;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive5;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiColumnFooterBand ColumnFooterBand1;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive1;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive2;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive3;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive4;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive5;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive1;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive2;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive3;
        public Stimulsoft.Report.Components.StiVerticalLinePrimitive VerticalLinePrimitive1;
        public Stimulsoft.Report.Components.StiVerticalLinePrimitive VerticalLinePrimitive2;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        public Stimulsoft.Report.StiStyle StyleTitle1;
        public Stimulsoft.Report.StiStyle StyleTitle2;
        public Stimulsoft.Report.StiStyle StyleHeader1;
        public Stimulsoft.Report.StiStyle StyleHeader2;
        public Stimulsoft.Report.StiStyle StyleHeader3;
        public Stimulsoft.Report.StiStyle StyleHeader4;
        public Stimulsoft.Report.StiStyle StyleData1;
        public Stimulsoft.Report.StiStyle StyleData2;
        public Stimulsoft.Report.StiStyle StyleData3;
        public Stimulsoft.Report.StiStyle StyleFooter1;
        public Stimulsoft.Report.StiStyle StyleFooter2;
        public DataBusinessObject Data;
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text2_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stimulsoft";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Multi Column Bands, Across then Down";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text18.TextFormat.Format(CheckExcelValue(sender, "Date: " + Today.ToString("Y")));
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Company";
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Customers.CompanyName, true);
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }
        
        public void ReportWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text2.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text2_GetValue_End));
        }
        
        private void InitializeComponent()
        {
            this.Data = new DataBusinessObject();
            this.NeedsCompiling = false;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ReferencedAssemblies = new System.String[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Multi-Column Bands, Across-Down";
            this.ReportAuthor = "Stimulsoft";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 4, 2, 12, 0, 8, 740);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "The sample demonstrates how to create a report with multiple columns on the bands" +
". Multicolumn direction - across then down.";
            this.ReportFile = "D:\\001\\For Silverlight(Native)\\1\\MultiColumnBandsAcrossThenDown.mrt";
            this.ReportGuid = "73d757709bde4d2b93918838ec7051fb";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.1000";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.ColumnWidth = 9.5;
            this.Page1.Guid = "a61b4e8dcf78499cb588966663d0c325";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 29.7;
            this.Page1.PageWidth = 21;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // PageFooterBand2
            // 
            this.PageFooterBand2 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 27.3, 19, 0.4);
            this.PageFooterBand2.Guid = "df6867d65e7f4b0687c56590e5c146a4";
            this.PageFooterBand2.Name = "PageFooterBand2";
            this.PageFooterBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.PageFooterBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 12.2, 0.4);
            this.Text2.ComponentStyle = "Footer1";
            this.Text2.Guid = "869fc4536cfe4696a395acb998fe2e1d";
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text2.Font = new System.Drawing.Font("Arial", 9F);
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooterBand2.Interaction = null;
            // 
            // ReportTitleBand2
            // 
            this.ReportTitleBand2 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 2);
            this.ReportTitleBand2.Guid = "f2172a68fa7d42a6895ebe63567c4b5b";
            this.ReportTitleBand2.Name = "ReportTitleBand2";
            this.ReportTitleBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.ReportTitleBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14.6, 0, 4.4, 0.8);
            this.Text20.ComponentStyle = "Title1";
            this.Text20.Guid = "68bb7be656cb49bd90bb1c607a7816bb";
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text20.Font = new System.Drawing.Font("Arial", 19F);
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 14.6, 0.8);
            this.Text23.ComponentStyle = "Title1";
            this.Text23.Guid = "52d5379a42804973a88ed9962eeb89ee";
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text23.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text23.Font = new System.Drawing.Font("Arial", 19F);
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.CanGrow = true;
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1, 14.6, 0.8);
            this.Text17.ComponentStyle = "Title2";
            this.Text17.Guid = "fe8b389ea5d24628bf99be634a390587";
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text17.Font = new System.Drawing.Font("Arial", 9F);
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.CanGrow = true;
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14.6, 1, 4.4, 0.8);
            this.Text18.ComponentStyle = "Title2";
            this.Text18.Guid = "651c5660732d47cb9c6f31b9b06fd531";
            this.Text18.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text18.Font = new System.Drawing.Font("Arial", 9F);
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text18.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("yyyy, MMMM", " ");
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand2.Interaction = null;
            // 
            // ColumnHeaderBand1
            // 
            this.ColumnHeaderBand1 = new Stimulsoft.Report.Components.StiColumnHeaderBand();
            this.ColumnHeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.2, 19, 0.6);
            this.ColumnHeaderBand1.Name = "ColumnHeaderBand1";
            this.ColumnHeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.ColumnHeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6, 0.6);
            this.Text10.ComponentStyle = "Header3";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            this.Text10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text10.Guid = null;
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // StartPointPrimitive1
            // 
            this.StartPointPrimitive1 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 0, 0);
            this.StartPointPrimitive1.Name = "StartPointPrimitive1";
            this.StartPointPrimitive1.ReferenceToGuid = "9cf9c110d64842e59988ffb7cd15229f";
            this.StartPointPrimitive1.Guid = null;
            this.StartPointPrimitive1.Interaction = null;
            // 
            // StartPointPrimitive2
            // 
            this.StartPointPrimitive2 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 0, 0, 0);
            this.StartPointPrimitive2.Name = "StartPointPrimitive2";
            this.StartPointPrimitive2.ReferenceToGuid = "be740a908d124fce835de0ffaae094e1";
            this.StartPointPrimitive2.Guid = null;
            this.StartPointPrimitive2.Interaction = null;
            // 
            // StartPointPrimitive3
            // 
            this.StartPointPrimitive3 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0, 0, 0);
            this.StartPointPrimitive3.Name = "StartPointPrimitive3";
            this.StartPointPrimitive3.ReferenceToGuid = "bd21eb2d390c49a6be2ffaeedb02745b";
            this.StartPointPrimitive3.Guid = null;
            this.StartPointPrimitive3.Interaction = null;
            // 
            // StartPointPrimitive4
            // 
            this.StartPointPrimitive4 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7, 0.6, 0, 0);
            this.StartPointPrimitive4.Name = "StartPointPrimitive4";
            this.StartPointPrimitive4.ReferenceToGuid = "a46da3fd1d1647528842a600ad6a8dfe";
            this.StartPointPrimitive4.Guid = null;
            this.StartPointPrimitive4.Interaction = null;
            // 
            // StartPointPrimitive5
            // 
            this.StartPointPrimitive5 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13.4, 0.6, 0, 0);
            this.StartPointPrimitive5.Name = "StartPointPrimitive5";
            this.StartPointPrimitive5.ReferenceToGuid = "e421b149c65c43ad90fa1061cae51338";
            this.StartPointPrimitive5.Guid = null;
            this.StartPointPrimitive5.Interaction = null;
            this.ColumnHeaderBand1.Guid = null;
            this.ColumnHeaderBand1.Interaction = null;
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.BusinessObjectGuid = "bfe4c30cf4a542e0aeb4634e34595ecf";
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.6, 19, 0.6);
            this.DataBand1.ColumnGaps = 0.4;
            this.DataBand1.Columns = 3;
            this.DataBand1.ColumnWidth = 6;
            this.DataBand1.EvenStyle = "Data2";
            this.DataBand1.MinRowsInColumn = 15;
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new System.String[] {
                    "ASC",
                    "CompanyName"};
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.6, 0, 5.4, 0.6);
            this.Text1.ComponentStyle = "Data1";
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text1.Font = new System.Drawing.Font("Arial", 9F);
            this.Text1.Guid = null;
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.CanGrow = true;
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 0.6, 0.6);
            this.Text7.ComponentStyle = "Data1";
            this.Text7.GrowToHeight = true;
            this.Text7.Guid = "42dbd0158ca04e1eacaba4b4594fd6f8";
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text7.Font = new System.Drawing.Font("Arial", 9F);
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand1.DataSourceName = null;
            this.DataBand1.Guid = null;
            this.DataBand1.Interaction = null;
            this.DataBand1.MasterComponent = null;
            // 
            // ColumnFooterBand1
            // 
            this.ColumnFooterBand1 = new Stimulsoft.Report.Components.StiColumnFooterBand();
            this.ColumnFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6, 19, 0.6);
            this.ColumnFooterBand1.Name = "ColumnFooterBand1";
            this.ColumnFooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.ColumnFooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // EndPointPrimitive1
            // 
            this.EndPointPrimitive1 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6, 0, 0, 0);
            this.EndPointPrimitive1.Name = "EndPointPrimitive1";
            this.EndPointPrimitive1.ReferenceToGuid = "9cf9c110d64842e59988ffb7cd15229f";
            this.EndPointPrimitive1.Guid = null;
            this.EndPointPrimitive1.Interaction = null;
            // 
            // EndPointPrimitive2
            // 
            this.EndPointPrimitive2 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.4, 0, 0, 0);
            this.EndPointPrimitive2.Name = "EndPointPrimitive2";
            this.EndPointPrimitive2.ReferenceToGuid = "be740a908d124fce835de0ffaae094e1";
            this.EndPointPrimitive2.Guid = null;
            this.EndPointPrimitive2.Interaction = null;
            // 
            // EndPointPrimitive3
            // 
            this.EndPointPrimitive3 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(18.8, 0, 0, 0);
            this.EndPointPrimitive3.Name = "EndPointPrimitive3";
            this.EndPointPrimitive3.ReferenceToGuid = "bd21eb2d390c49a6be2ffaeedb02745b";
            this.EndPointPrimitive3.Guid = null;
            this.EndPointPrimitive3.Interaction = null;
            // 
            // EndPointPrimitive4
            // 
            this.EndPointPrimitive4 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7, 0, 0, 0);
            this.EndPointPrimitive4.Name = "EndPointPrimitive4";
            this.EndPointPrimitive4.ReferenceToGuid = "a46da3fd1d1647528842a600ad6a8dfe";
            this.EndPointPrimitive4.Guid = null;
            this.EndPointPrimitive4.Interaction = null;
            // 
            // EndPointPrimitive5
            // 
            this.EndPointPrimitive5 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13.4, 0, 0, 0);
            this.EndPointPrimitive5.Name = "EndPointPrimitive5";
            this.EndPointPrimitive5.ReferenceToGuid = "e421b149c65c43ad90fa1061cae51338";
            this.EndPointPrimitive5.Guid = null;
            this.EndPointPrimitive5.Interaction = null;
            this.ColumnFooterBand1.Guid = null;
            this.ColumnFooterBand1.Interaction = null;
            // 
            // RectanglePrimitive1
            // 
            this.RectanglePrimitive1 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.2, 6, 2.8);
            this.RectanglePrimitive1.Color = System.Windows.Media.Color.FromArgb(255, 193, 152, 89);
            this.RectanglePrimitive1.Guid = "9cf9c110d64842e59988ffb7cd15229f";
            this.RectanglePrimitive1.Name = "RectanglePrimitive1";
            this.RectanglePrimitive1.Interaction = null;
            // 
            // RectanglePrimitive2
            // 
            this.RectanglePrimitive2 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.4, 3.2, 6, 2.8);
            this.RectanglePrimitive2.Color = System.Windows.Media.Color.FromArgb(255, 193, 152, 89);
            this.RectanglePrimitive2.Guid = "be740a908d124fce835de0ffaae094e1";
            this.RectanglePrimitive2.Name = "RectanglePrimitive2";
            this.RectanglePrimitive2.Interaction = null;
            // 
            // RectanglePrimitive3
            // 
            this.RectanglePrimitive3 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 3.2, 6, 2.8);
            this.RectanglePrimitive3.Color = System.Windows.Media.Color.FromArgb(255, 193, 152, 89);
            this.RectanglePrimitive3.Guid = "bd21eb2d390c49a6be2ffaeedb02745b";
            this.RectanglePrimitive3.Name = "RectanglePrimitive3";
            this.RectanglePrimitive3.Interaction = null;
            // 
            // VerticalLinePrimitive1
            // 
            this.VerticalLinePrimitive1 = new Stimulsoft.Report.Components.StiVerticalLinePrimitive();
            this.VerticalLinePrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7, 3.8, 0.0254, 2.2);
            this.VerticalLinePrimitive1.Color = System.Windows.Media.Color.FromArgb(255, 193, 152, 89);
            this.VerticalLinePrimitive1.Guid = "a46da3fd1d1647528842a600ad6a8dfe";
            this.VerticalLinePrimitive1.Name = "VerticalLinePrimitive1";
            this.VerticalLinePrimitive1.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.VerticalLinePrimitive1.Interaction = null;
            this.VerticalLinePrimitive1.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            // 
            // VerticalLinePrimitive2
            // 
            this.VerticalLinePrimitive2 = new Stimulsoft.Report.Components.StiVerticalLinePrimitive();
            this.VerticalLinePrimitive2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13.4, 3.8, 0.0254, 2.2);
            this.VerticalLinePrimitive2.Color = System.Windows.Media.Color.FromArgb(255, 193, 152, 89);
            this.VerticalLinePrimitive2.Guid = "e421b149c65c43ad90fa1061cae51338";
            this.VerticalLinePrimitive2.Name = "VerticalLinePrimitive2";
            this.VerticalLinePrimitive2.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.VerticalLinePrimitive2.Interaction = null;
            this.VerticalLinePrimitive2.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            // 
            // StyleTitle1
            // 
            this.StyleTitle1 = new Stimulsoft.Report.StiStyle();
            this.StyleTitle1.AllowUseBorderSides = false;
            this.StyleTitle1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleTitle1.Name = "Title1";
            this.StyleTitle1.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleTitle1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleTitle1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleTitle1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.StyleTitle1.Font = new System.Drawing.Font("Arial", 19F);
            this.StyleTitle1.Image = null;
            this.StyleTitle1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleTitle2
            // 
            this.StyleTitle2 = new Stimulsoft.Report.StiStyle();
            this.StyleTitle2.AllowUseBorderSides = false;
            this.StyleTitle2.Name = "Title2";
            this.StyleTitle2.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleTitle2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleTitle2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleTitle2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.StyleTitle2.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleTitle2.Image = null;
            this.StyleTitle2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            // 
            // StyleHeader1
            // 
            this.StyleHeader1 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader1.AllowUseBorderSides = false;
            this.StyleHeader1.Name = "Header1";
            this.StyleHeader1.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleHeader1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleHeader1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.StyleHeader1.Font = new System.Drawing.Font("Arial", 19F);
            this.StyleHeader1.Image = null;
            this.StyleHeader1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleHeader2
            // 
            this.StyleHeader2 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader2.AllowUseBorderSides = false;
            this.StyleHeader2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader2.Name = "Header2";
            this.StyleHeader2.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleHeader2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleHeader2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.StyleHeader2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.StyleHeader2.Image = null;
            this.StyleHeader2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleHeader3
            // 
            this.StyleHeader3 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader3.AllowUseBorderSides = false;
            this.StyleHeader3.AllowUseHorAlignment = true;
            this.StyleHeader3.AllowUseVertAlignment = true;
            this.StyleHeader3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader3.Name = "Header3";
            this.StyleHeader3.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleHeader3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleHeader3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            this.StyleHeader3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.StyleHeader3.Image = null;
            this.StyleHeader3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleHeader4
            // 
            this.StyleHeader4 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader4.AllowUseBorderSides = false;
            this.StyleHeader4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader4.Name = "Header4";
            this.StyleHeader4.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleHeader4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleHeader4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.StyleHeader4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.StyleHeader4.Image = null;
            this.StyleHeader4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleData1
            // 
            this.StyleData1 = new Stimulsoft.Report.StiStyle();
            this.StyleData1.AllowUseBorderSides = false;
            this.StyleData1.Name = "Data1";
            this.StyleData1.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleData1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleData1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleData1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.StyleData1.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleData1.Image = null;
            this.StyleData1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            // 
            // StyleData2
            // 
            this.StyleData2 = new Stimulsoft.Report.StiStyle();
            this.StyleData2.AllowUseBorderFormatting = false;
            this.StyleData2.AllowUseBorderSides = false;
            this.StyleData2.AllowUseFont = false;
            this.StyleData2.AllowUseTextBrush = false;
            this.StyleData2.AllowUseTextOptions = false;
            this.StyleData2.Name = "Data2";
            this.StyleData2.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleData2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleData2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 240, 237, 232));
            this.StyleData2.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleData2.Image = null;
            this.StyleData2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            // 
            // StyleData3
            // 
            this.StyleData3 = new Stimulsoft.Report.StiStyle();
            this.StyleData3.AllowUseBorderSides = false;
            this.StyleData3.Name = "Data3";
            this.StyleData3.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleData3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleData3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleData3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 240, 237, 232));
            this.StyleData3.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleData3.Image = null;
            this.StyleData3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            // 
            // StyleFooter1
            // 
            this.StyleFooter1 = new Stimulsoft.Report.StiStyle();
            this.StyleFooter1.AllowUseBorderSides = false;
            this.StyleFooter1.Name = "Footer1";
            this.StyleFooter1.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleFooter1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleFooter1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Top, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleFooter1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.StyleFooter1.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleFooter1.Image = null;
            this.StyleFooter1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            // 
            // StyleFooter2
            // 
            this.StyleFooter2 = new Stimulsoft.Report.StiStyle();
            this.StyleFooter2.AllowUseBorderSides = false;
            this.StyleFooter2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleFooter2.Name = "Footer2";
            this.StyleFooter2.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleFooter2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleFooter2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleFooter2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.StyleFooter2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.StyleFooter2.Image = null;
            this.StyleFooter2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.DataBandsUsedInPageTotals = new System.String[] {
                    "DataBand1"};
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.PageFooterBand2.Page = this.Page1;
            this.PageFooterBand2.Parent = this.Page1;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.PageFooterBand2;
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
            this.ColumnHeaderBand1.Page = this.Page1;
            this.ColumnHeaderBand1.Parent = this.Page1;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.ColumnHeaderBand1;
            this.StartPointPrimitive1.Page = this.Page1;
            this.StartPointPrimitive1.Parent = this.ColumnHeaderBand1;
            this.StartPointPrimitive2.Page = this.Page1;
            this.StartPointPrimitive2.Parent = this.ColumnHeaderBand1;
            this.StartPointPrimitive3.Page = this.Page1;
            this.StartPointPrimitive3.Parent = this.ColumnHeaderBand1;
            this.StartPointPrimitive4.Page = this.Page1;
            this.StartPointPrimitive4.Parent = this.ColumnHeaderBand1;
            this.StartPointPrimitive5.Page = this.Page1;
            this.StartPointPrimitive5.Parent = this.ColumnHeaderBand1;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.DataBand1;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.DataBand1;
            this.ColumnFooterBand1.Page = this.Page1;
            this.ColumnFooterBand1.Parent = this.Page1;
            this.EndPointPrimitive1.Page = this.Page1;
            this.EndPointPrimitive1.Parent = this.ColumnFooterBand1;
            this.EndPointPrimitive2.Page = this.Page1;
            this.EndPointPrimitive2.Parent = this.ColumnFooterBand1;
            this.EndPointPrimitive3.Page = this.Page1;
            this.EndPointPrimitive3.Parent = this.ColumnFooterBand1;
            this.EndPointPrimitive4.Page = this.Page1;
            this.EndPointPrimitive4.Parent = this.ColumnFooterBand1;
            this.EndPointPrimitive5.Page = this.Page1;
            this.EndPointPrimitive5.Parent = this.ColumnFooterBand1;
            this.RectanglePrimitive1.Page = this.Page1;
            this.RectanglePrimitive1.Parent = this.Page1;
            this.RectanglePrimitive2.Page = this.Page1;
            this.RectanglePrimitive2.Parent = this.Page1;
            this.RectanglePrimitive3.Page = this.Page1;
            this.RectanglePrimitive3.Parent = this.Page1;
            this.VerticalLinePrimitive1.Page = this.Page1;
            this.VerticalLinePrimitive1.Parent = this.Page1;
            this.VerticalLinePrimitive2.Page = this.Page1;
            this.VerticalLinePrimitive2.Parent = this.Page1;
            this.EndRender += new System.EventHandler(this.ReportWordsToEnd__EndRender);
            // 
            // Add to PageFooterBand2.Components
            // 
            this.PageFooterBand2.Components.Clear();
            this.PageFooterBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text2});
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
            // Add to ColumnHeaderBand1.Components
            // 
            this.ColumnHeaderBand1.Components.Clear();
            this.ColumnHeaderBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text10,
                        this.StartPointPrimitive1,
                        this.StartPointPrimitive2,
                        this.StartPointPrimitive3,
                        this.StartPointPrimitive4,
                        this.StartPointPrimitive5});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text1,
                        this.Text7});
            // 
            // Add to ColumnFooterBand1.Components
            // 
            this.ColumnFooterBand1.Components.Clear();
            this.ColumnFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.EndPointPrimitive1,
                        this.EndPointPrimitive2,
                        this.EndPointPrimitive3,
                        this.EndPointPrimitive4,
                        this.EndPointPrimitive5});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooterBand2,
                        this.ReportTitleBand2,
                        this.ColumnHeaderBand1,
                        this.DataBand1,
                        this.ColumnFooterBand1,
                        this.RectanglePrimitive1,
                        this.RectanglePrimitive2,
                        this.RectanglePrimitive3,
                        this.VerticalLinePrimitive1,
                        this.VerticalLinePrimitive2});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            // 
            // Add to Styles
            // 
            this.Styles.Clear();
            this.Styles.AddRange(new Stimulsoft.Report.StiBaseStyle[] {
                        this.StyleTitle1,
                        this.StyleTitle2,
                        this.StyleHeader1,
                        this.StyleHeader2,
                        this.StyleHeader3,
                        this.StyleHeader4,
                        this.StyleData1,
                        this.StyleData2,
                        this.StyleData3,
                        this.StyleFooter1,
                        this.StyleFooter2});
            this.Dictionary.BusinessObjects.Add(this.Data);
        }
        
        #region BusinessObject Data
        public class DataBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
        {
            
            public DataBusinessObject() : 
                    base("", "Data", "Data", "d361460f368e4fd58a038e3fcf271903")
            {
                this.Categories = new CategoriesBusinessObject();
                this.Categories.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                            new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryName", "CategoryName", "CategoryName", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Description", "Description", "Description", typeof(string))});
                this.BusinessObjects.Add(this.Categories);
                this.Customers = new CustomersBusinessObject();
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
                this.BusinessObjects.Add(this.Customers);
                this.Employees = new EmployeesBusinessObject();
                this.Employees.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                            new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", "EmployeeID", "EmployeeID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("LastName", "LastName", "LastName", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("FirstName", "FirstName", "FirstName", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Title", "Title", "Title", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("BirthDate", "BirthDate", "BirthDate", typeof(DateTime?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("HireDate", "HireDate", "HireDate", typeof(DateTime?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("HomePhone", "HomePhone", "HomePhone", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Notes", "Notes", "Notes", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ReportsTo", "ReportsTo", "ReportsTo", typeof(int?))});
                this.BusinessObjects.Add(this.Employees);
                this.Order_Details = new Order_DetailsBusinessObject();
                this.Order_Details.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                            new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", "OrderID", "OrderID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Quantity", "Quantity", "Quantity", typeof(short?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Discount", "Discount", "Discount", typeof(float?))});
                this.BusinessObjects.Add(this.Order_Details);
                this.Orders = new OrdersBusinessObject();
                this.Orders.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                            new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", "OrderID", "OrderID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", "EmployeeID", "EmployeeID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("RequiredDate", "RequiredDate", "RequiredDate", typeof(DateTime?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShippedDate", "ShippedDate", "ShippedDate", typeof(DateTime?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShipVia", "ShipVia", "ShipVia", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Freight", "Freight", "Freight", typeof(decimal?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShipName", "ShipName", "ShipName", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShipAddress", "ShipAddress", "ShipAddress", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCity", "ShipCity", "ShipCity", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShipRegion", "ShipRegion", "ShipRegion", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShipPostalCode", "ShipPostalCode", "ShipPostalCode", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCountry", "ShipCountry", "ShipCountry", typeof(string))});
                this.BusinessObjects.Add(this.Orders);
                this.Products = new ProductsBusinessObject();
                this.Products.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ProductName", "ProductName", "ProductName", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("QuantityPerUnit", "QuantityPerUnit", "QuantityPerUnit", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short?))});
                this.BusinessObjects.Add(this.Products);
                this.Shippers = new ShippersBusinessObject();
                this.Shippers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                            new Stimulsoft.Report.Dictionary.StiDataColumn("ShipperID", "ShipperID", "ShipperID", typeof(int?)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string)),
                            new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string))});
                this.BusinessObjects.Add(this.Shippers);
                this.Suppliers = new SuppliersBusinessObject();
                this.Suppliers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                            new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int?)),
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
                this.BusinessObjects.Add(this.Suppliers);
            }
            public CategoriesBusinessObject Categories;
            public CustomersBusinessObject Customers;
            public EmployeesBusinessObject Employees;
            public Order_DetailsBusinessObject Order_Details;
            public OrdersBusinessObject Orders;
            public ProductsBusinessObject Products;
            public ShippersBusinessObject Shippers;
            public SuppliersBusinessObject Suppliers;
            
            #region BusinessObject Categories
            public class CategoriesBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
            {
                
                public CategoriesBusinessObject() : 
                        base("", "Categories", "Categories", "327867a860f341d68bb10fa62b6394df")
                {
                    this.Products = new ProductsBusinessObject();
                    this.Products.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                                new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int?)),
                                new Stimulsoft.Report.Dictionary.StiDataColumn("ProductName", "ProductName", "ProductName", typeof(string)),
                                new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int?)),
                                new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(int?)),
                                new Stimulsoft.Report.Dictionary.StiDataColumn("QuantityPerUnit", "QuantityPerUnit", "QuantityPerUnit", typeof(string)),
                                new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal?)),
                                new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short?))});
                    this.BusinessObjects.Add(this.Products);
                }
                public ProductsBusinessObject Products;
                
                public virtual int? CategoryID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["CategoryID"], typeof(int?), true)));
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
                
                #region BusinessObject Products
                public class ProductsBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
                {
                    
                    public ProductsBusinessObject() : 
                            base("", "Products", "Products", "e0c853d0906b47e9bf3521bf757080a5")
                    {
                    }
                    
                    public virtual int? ProductID
                    {
                        get
                        {
                            return ((int?)(StiReport.ChangeType(this["ProductID"], typeof(int?), true)));
                        }
                    }
                    
                    public virtual string ProductName
                    {
                        get
                        {
                            return ((string)(StiReport.ChangeType(this["ProductName"], typeof(string), true)));
                        }
                    }
                    
                    public virtual int? SupplierID
                    {
                        get
                        {
                            return ((int?)(StiReport.ChangeType(this["SupplierID"], typeof(int?), true)));
                        }
                    }
                    
                    public virtual int? CategoryID
                    {
                        get
                        {
                            return ((int?)(StiReport.ChangeType(this["CategoryID"], typeof(int?), true)));
                        }
                    }
                    
                    public virtual string QuantityPerUnit
                    {
                        get
                        {
                            return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
                        }
                    }
                    
                    public virtual decimal? UnitPrice
                    {
                        get
                        {
                            return ((decimal?)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal?), true)));
                        }
                    }
                    
                    public virtual short? UnitsInStock
                    {
                        get
                        {
                            return ((short?)(StiReport.ChangeType(this["UnitsInStock"], typeof(short?), true)));
                        }
                    }
                }
                #endregion BusinessObject Products
            }
            #endregion BusinessObject Categories
            
            #region BusinessObject Customers
            public class CustomersBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
            {
                
                public CustomersBusinessObject() : 
                        base("", "Customers", "Customers", "bfe4c30cf4a542e0aeb4634e34595ecf")
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
            #endregion BusinessObject Customers
            
            #region BusinessObject Employees
            public class EmployeesBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
            {
                
                public EmployeesBusinessObject() : 
                        base("", "Employees", "Employees", "09da033db3fb46ca8a3b988bd5b5b947")
                {
                }
                
                public virtual int? EmployeeID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["EmployeeID"], typeof(int?), true)));
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
                
                public virtual DateTime? BirthDate
                {
                    get
                    {
                        return ((DateTime?)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime?), true)));
                    }
                }
                
                public virtual DateTime? HireDate
                {
                    get
                    {
                        return ((DateTime?)(StiReport.ChangeType(this["HireDate"], typeof(DateTime?), true)));
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
                
                public virtual int? ReportsTo
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["ReportsTo"], typeof(int?), true)));
                    }
                }
            }
            #endregion BusinessObject Employees
            
            #region BusinessObject Order_Details
            public class Order_DetailsBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
            {
                
                public Order_DetailsBusinessObject() : 
                        base("", "Order_Details", "Order_Details", "c371410ffb8a4b0abb373d0fc6df867a")
                {
                }
                
                public virtual int? OrderID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["OrderID"], typeof(int?), true)));
                    }
                }
                
                public virtual int? ProductID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["ProductID"], typeof(int?), true)));
                    }
                }
                
                public virtual decimal? UnitPrice
                {
                    get
                    {
                        return ((decimal?)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal?), true)));
                    }
                }
                
                public virtual short? Quantity
                {
                    get
                    {
                        return ((short?)(StiReport.ChangeType(this["Quantity"], typeof(short?), true)));
                    }
                }
                
                public virtual float? Discount
                {
                    get
                    {
                        return ((float?)(StiReport.ChangeType(this["Discount"], typeof(float?), true)));
                    }
                }
            }
            #endregion BusinessObject Order_Details
            
            #region BusinessObject Orders
            public class OrdersBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
            {
                
                public OrdersBusinessObject() : 
                        base("", "Orders", "Orders", "4452f95add09456681e7ef8fc7709d1d")
                {
                }
                
                public virtual int? OrderID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["OrderID"], typeof(int?), true)));
                    }
                }
                
                public virtual string CustomerID
                {
                    get
                    {
                        return ((string)(StiReport.ChangeType(this["CustomerID"], typeof(string), true)));
                    }
                }
                
                public virtual int? EmployeeID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["EmployeeID"], typeof(int?), true)));
                    }
                }
                
                public virtual DateTime? OrderDate
                {
                    get
                    {
                        return ((DateTime?)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime?), true)));
                    }
                }
                
                public virtual DateTime? RequiredDate
                {
                    get
                    {
                        return ((DateTime?)(StiReport.ChangeType(this["RequiredDate"], typeof(DateTime?), true)));
                    }
                }
                
                public virtual DateTime? ShippedDate
                {
                    get
                    {
                        return ((DateTime?)(StiReport.ChangeType(this["ShippedDate"], typeof(DateTime?), true)));
                    }
                }
                
                public virtual int? ShipVia
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["ShipVia"], typeof(int?), true)));
                    }
                }
                
                public virtual decimal? Freight
                {
                    get
                    {
                        return ((decimal?)(StiReport.ChangeType(this["Freight"], typeof(decimal?), true)));
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
            }
            #endregion BusinessObject Orders
            
            #region BusinessObject Products
            public class ProductsBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
            {
                
                public ProductsBusinessObject() : 
                        base("", "Products", "Products", "4ac9f6a9f56e4186829225a42e77057d")
                {
                }
                
                public virtual int? ProductID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["ProductID"], typeof(int?), true)));
                    }
                }
                
                public virtual string ProductName
                {
                    get
                    {
                        return ((string)(StiReport.ChangeType(this["ProductName"], typeof(string), true)));
                    }
                }
                
                public virtual int? SupplierID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["SupplierID"], typeof(int?), true)));
                    }
                }
                
                public virtual int? CategoryID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["CategoryID"], typeof(int?), true)));
                    }
                }
                
                public virtual string QuantityPerUnit
                {
                    get
                    {
                        return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
                    }
                }
                
                public virtual decimal? UnitPrice
                {
                    get
                    {
                        return ((decimal?)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal?), true)));
                    }
                }
                
                public virtual short? UnitsInStock
                {
                    get
                    {
                        return ((short?)(StiReport.ChangeType(this["UnitsInStock"], typeof(short?), true)));
                    }
                }
            }
            #endregion BusinessObject Products
            
            #region BusinessObject Shippers
            public class ShippersBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
            {
                
                public ShippersBusinessObject() : 
                        base("", "Shippers", "Shippers", "7b13034841b349f8ae4b9122ccd28d33")
                {
                }
                
                public virtual int? ShipperID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["ShipperID"], typeof(int?), true)));
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
            #endregion BusinessObject Shippers
            
            #region BusinessObject Suppliers
            public class SuppliersBusinessObject : Stimulsoft.Report.Dictionary.StiBusinessObject
            {
                
                public SuppliersBusinessObject() : 
                        base("", "Suppliers", "Suppliers", "719fc6985d844484b407c838b2b6923a")
                {
                }
                
                public virtual int? SupplierID
                {
                    get
                    {
                        return ((int?)(StiReport.ChangeType(this["SupplierID"], typeof(int?), true)));
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
            #endregion BusinessObject Suppliers
        }
        #endregion BusinessObject Data
        #endregion StiReport Designer generated code - do not modify
    }
}