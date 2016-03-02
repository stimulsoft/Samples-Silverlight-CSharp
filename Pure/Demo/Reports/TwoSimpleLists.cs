using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace Reports
{
    public class TwoSimpleLists : Stimulsoft.Report.StiReport
    {
		public TwoSimpleLists()
        {
            this.InitializeComponent();
        }
        
        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand2;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand1;
        public Stimulsoft.Report.Components.StiText Text25;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text26;
        public Stimulsoft.Report.Components.StiText Text27;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand3;
        public Stimulsoft.Report.Components.StiText Text22;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand1;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiText Text19;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand1;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand4;
        public Stimulsoft.Report.Components.StiText Text21;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand2;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiDataBand DataBand2;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand2;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        public Stimulsoft.Report.StiStyle StyleTitle1;
        public Stimulsoft.Report.StiStyle StyleTitle2;
        public Stimulsoft.Report.StiStyle StyleHeader1;
        public Stimulsoft.Report.StiStyle StyleHeader2;
        public Stimulsoft.Report.StiStyle StyleHeader3;
        public Stimulsoft.Report.StiStyle StyleData1;
        public Stimulsoft.Report.StiStyle StyleData2;
        public Stimulsoft.Report.StiStyle StyleData3;
        public Stimulsoft.Report.StiStyle StyleFooter1;
        public Stimulsoft.Report.StiStyle StyleFooter2;
        public DataBusinessObject Data;
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text5_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }
        
        public void Text25__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stimulsoft";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Two Simple Lists";
        }
        
        public void Text26__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text27__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text27.TextFormat.Format(CheckExcelValue(sender, "Date: " + Today.ToString("Y")));
        }
        
        public void Text22__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Companies";
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Company";
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Address";
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Phone";
        }
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Contact";
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Customers.Address, true);
        }
        
        public void Text19__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Customers.Phone, true);
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Customers.ContactTitle, true);
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Customers.CompanyName, true);
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }
        
        public void Text21__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Products";
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Category";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Product";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Price";
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Categories.Products.ProductName, true);
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Categories.CategoryName, true);
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text3.TextFormat.Format(CheckExcelValue(sender, Data.Categories.Products.UnitsInStock));
        }
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }
        
        public void ReportWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text5.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text5_GetValue_End));
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
            this.ReportAlias = "Two Simple Lists";
            this.ReportAuthor = "Stimulsoft";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 4, 2, 11, 47, 7, 171);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "The sample demonstrates how to create two simple list reports.";
            this.ReportFile = "D:\\001\\For Silverlight(Native)\\TwoSimpleLists.mrt";
            this.ReportGuid = "43aacabb31c5429c85df13cd967b65a2";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.1000";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "468cecb8155a44019d5fe1a8a26a8439";
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
            this.PageFooterBand2.Guid = "acd7c441976e49f2a0610fcd2c91a3ec";
            this.PageFooterBand2.Name = "PageFooterBand2";
            this.PageFooterBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.PageFooterBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 12.2, 0.4);
            this.Text5.ComponentStyle = "Footer1";
            this.Text5.Guid = "c8f19b070a6f4b4facf5b1a643554736";
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text5.Font = new System.Drawing.Font("Arial", 9F);
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooterBand2.Interaction = null;
            // 
            // ReportTitleBand1
            // 
            this.ReportTitleBand1 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 2);
            this.ReportTitleBand1.Guid = "cd54028c38914069a615625c1d597b62";
            this.ReportTitleBand1.Name = "ReportTitleBand1";
            this.ReportTitleBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.ReportTitleBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text25
            // 
            this.Text25 = new Stimulsoft.Report.Components.StiText();
            this.Text25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.4, 0, 9.6, 0.8);
            this.Text25.ComponentStyle = "Title1";
            this.Text25.Guid = "1e9810989ef54290ae71a5c04bf1cc6f";
            this.Text25.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text25.Name = "Text25";
            this.Text25.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text25__GetValue);
            this.Text25.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text25.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text25.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text25.Font = new System.Drawing.Font("Arial", 19F);
            this.Text25.Indicator = null;
            this.Text25.Interaction = null;
            this.Text25.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text25.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text25.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9.4, 0.8);
            this.Text23.ComponentStyle = "Title1";
            this.Text23.Guid = "2c5e846ecae74cd5bc625c2979982187";
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
            // Text26
            // 
            this.Text26 = new Stimulsoft.Report.Components.StiText();
            this.Text26.CanGrow = true;
            this.Text26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1, 14.6, 0.8);
            this.Text26.ComponentStyle = "Title2";
            this.Text26.Guid = "f0b94eeaa11342dc993c7a84de7c04aa";
            this.Text26.Name = "Text26";
            this.Text26.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text26__GetValue);
            this.Text26.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text26.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text26.Font = new System.Drawing.Font("Arial", 9F);
            this.Text26.Indicator = null;
            this.Text26.Interaction = null;
            this.Text26.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text26.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text26.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text27
            // 
            this.Text27 = new Stimulsoft.Report.Components.StiText();
            this.Text27.CanGrow = true;
            this.Text27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14.6, 1, 4.4, 0.8);
            this.Text27.ComponentStyle = "Title2";
            this.Text27.Guid = "828792fd7bea4171aa44efc6c14a9958";
            this.Text27.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text27.Name = "Text27";
            this.Text27.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text27__GetValue);
            this.Text27.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text27.Font = new System.Drawing.Font("Arial", 9F);
            this.Text27.Indicator = null;
            this.Text27.Interaction = null;
            this.Text27.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text27.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text27.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("yyyy, MMMM", " ");
            this.Text27.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand1.Interaction = null;
            // 
            // HeaderBand3
            // 
            this.HeaderBand3 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.2, 19, 0.6);
            this.HeaderBand3.Name = "HeaderBand3";
            this.HeaderBand3.PrintOnAllPages = false;
            this.HeaderBand3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.HeaderBand3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text22
            // 
            this.Text22 = new Stimulsoft.Report.Components.StiText();
            this.Text22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 0.6);
            this.Text22.ComponentStyle = "Header2";
            this.Text22.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text22.Name = "Text22";
            this.Text22.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text22__GetValue);
            this.Text22.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text22.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Text22.Guid = null;
            this.Text22.Indicator = null;
            this.Text22.Interaction = null;
            this.Text22.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text22.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text22.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand3.Guid = null;
            this.HeaderBand3.Interaction = null;
            // 
            // HeaderBand1
            // 
            this.HeaderBand1 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.6, 19, 0.6);
            this.HeaderBand1.ComponentStyle = "Header3";
            this.HeaderBand1.Name = "HeaderBand1";
            this.HeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.HeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.8, 0.6);
            this.Text9.ComponentStyle = "Header3";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            this.Text9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text9.Guid = null;
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 5.2, 0.6);
            this.Text6.ComponentStyle = "Header3";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            this.Text6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text6.Guid = null;
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12, 0, 3, 0.6);
            this.Text14.ComponentStyle = "Header3";
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            this.Text14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text14.Guid = null;
            this.Text14.Indicator = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15, 0, 4, 0.6);
            this.Text15.ComponentStyle = "Header3";
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            this.Text15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text15.Guid = null;
            this.Text15.Indicator = null;
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand1.Guid = null;
            this.HeaderBand1.Interaction = null;
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.BusinessObjectGuid = "bfe4c30cf4a542e0aeb4634e34595ecf";
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6, 19, 0.6);
            this.DataBand1.EvenStyle = "Data2";
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new System.String[0];
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.CanGrow = true;
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 5.2, 0.6);
            this.Text18.ComponentStyle = "Data1";
            this.Text18.GrowToHeight = true;
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text18.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text18.Font = new System.Drawing.Font("Arial", 9F);
            this.Text18.Guid = null;
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text19
            // 
            this.Text19 = new Stimulsoft.Report.Components.StiText();
            this.Text19.CanGrow = true;
            this.Text19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12, 0, 3, 0.6);
            this.Text19.ComponentStyle = "Data1";
            this.Text19.GrowToHeight = true;
            this.Text19.Name = "Text19";
            this.Text19.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text19__GetValue);
            this.Text19.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text19.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text19.Font = new System.Drawing.Font("Arial", 9F);
            this.Text19.Guid = null;
            this.Text19.Indicator = null;
            this.Text19.Interaction = null;
            this.Text19.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text19.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text19.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.CanGrow = true;
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15, 0, 4, 0.6);
            this.Text20.ComponentStyle = "Data1";
            this.Text20.GrowToHeight = true;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text20.Font = new System.Drawing.Font("Arial", 9F);
            this.Text20.Guid = null;
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.CanGrow = true;
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.6, 0, 6.2, 0.6);
            this.Text17.ComponentStyle = "Data1";
            this.Text17.GrowToHeight = true;
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text17.Font = new System.Drawing.Font("Arial", 9F);
            this.Text17.Guid = null;
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.CanGrow = true;
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 0.6, 0.6);
            this.Text8.ComponentStyle = "Data1";
            this.Text8.GrowToHeight = true;
            this.Text8.Guid = "2307d1b5bee5446294ba557791c5857e";
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text8.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text8.Font = new System.Drawing.Font("Arial", 9F);
            this.Text8.Indicator = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand1.DataSourceName = null;
            this.DataBand1.Guid = null;
            this.DataBand1.Interaction = null;
            this.DataBand1.MasterComponent = null;
            // 
            // FooterBand1
            // 
            this.FooterBand1 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 7.4, 19, 0.2);
            this.FooterBand1.Guid = "09c87f803b364478873d7b660bb1803f";
            this.FooterBand1.Name = "FooterBand1";
            this.FooterBand1.PrintIfEmpty = true;
            this.FooterBand1.PrintOnAllPages = true;
            this.FooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.FooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.CanGrow = true;
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 0.2);
            this.Text7.ComponentStyle = "Data1";
            this.Text7.GrowToHeight = true;
            this.Text7.Guid = "ae1ab8c5801347efa18725e4e0619581";
            this.Text7.Name = "Text7";
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Top, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text7.Font = new System.Drawing.Font("Arial", 9F);
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.FooterBand1.Interaction = null;
            // 
            // HeaderBand4
            // 
            this.HeaderBand4 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 8.4, 19, 0.8);
            this.HeaderBand4.Name = "HeaderBand4";
            this.HeaderBand4.PrintOnAllPages = false;
            this.HeaderBand4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.HeaderBand4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text21
            // 
            this.Text21 = new Stimulsoft.Report.Components.StiText();
            this.Text21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.2, 19, 0.6);
            this.Text21.ComponentStyle = "Header2";
            this.Text21.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text21.Name = "Text21";
            this.Text21.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text21__GetValue);
            this.Text21.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Text21.Guid = null;
            this.Text21.Indicator = null;
            this.Text21.Interaction = null;
            this.Text21.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text21.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text21.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand4.Guid = null;
            this.HeaderBand4.Interaction = null;
            // 
            // HeaderBand2
            // 
            this.HeaderBand2 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10, 19, 0.6);
            this.HeaderBand2.Name = "HeaderBand2";
            this.HeaderBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.HeaderBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.4, 0, 6.6, 0.6);
            this.Text11.ComponentStyle = "Header3";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            this.Text11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text11.Guid = null;
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9.4, 0.6);
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
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16, 0, 3, 0.6);
            this.Text12.ComponentStyle = "Header3";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 242, 234, 221));
            this.Text12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text12.Guid = null;
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 193, 152, 89));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand2.Guid = null;
            this.HeaderBand2.Interaction = null;
            // 
            // DataBand2
            // 
            this.DataBand2 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand2.BusinessObjectGuid = "e0c853d0906b47e9bf3521bf757080a5";
            this.DataBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 11.4, 19, 0.6);
            this.DataBand2.EvenStyle = "Data2";
            this.DataBand2.Name = "DataBand2";
            this.DataBand2.Sort = new System.String[] {
                    "ASC",
                    "ProductName"};
            this.DataBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.DataBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.CanGrow = true;
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.6, 0, 8.8, 0.6);
            this.Text1.ComponentStyle = "Data1";
            this.Text1.GrowToHeight = true;
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text1.Font = new System.Drawing.Font("Arial", 9F);
            this.Text1.Guid = null;
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.CanGrow = true;
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.4, 0, 6.6, 0.6);
            this.Text2.ComponentStyle = "Data1";
            this.Text2.GrowToHeight = true;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text2.Font = new System.Drawing.Font("Arial", 9F);
            this.Text2.Guid = null;
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.CanGrow = true;
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16, 0, 3, 0.6);
            this.Text3.ComponentStyle = "Data1";
            this.Text3.GrowToHeight = true;
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text3.Font = new System.Drawing.Font("Arial", 9F);
            this.Text3.Guid = null;
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text3.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCurrencyFormatService(0, 0, ".", 2, ",", 3, "$", true, true, " ");
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.CanGrow = true;
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 0.6, 0.6);
            this.Text13.ComponentStyle = "Data1";
            this.Text13.GrowToHeight = true;
            this.Text13.Guid = "c83873eb71f4408a99c7deefb6ee2aed";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text13.Font = new System.Drawing.Font("Arial", 9F);
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand2.DataSourceName = null;
            this.DataBand2.Guid = null;
            this.DataBand2.Interaction = null;
            this.DataBand2.MasterComponent = null;
            // 
            // FooterBand2
            // 
            this.FooterBand2 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 12.8, 19, 0.2);
            this.FooterBand2.Guid = "1272b297b8984d5ab3360e67c218c6b1";
            this.FooterBand2.Name = "FooterBand2";
            this.FooterBand2.PrintIfEmpty = true;
            this.FooterBand2.PrintOnAllPages = true;
            this.FooterBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.FooterBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.CanGrow = true;
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 0.2);
            this.Text4.ComponentStyle = "Data1";
            this.Text4.GrowToHeight = true;
            this.Text4.Guid = "19359f6cc01b4d0bba16fdab5da0ceab";
            this.Text4.Name = "Text4";
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Top, System.Windows.Media.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text4.Font = new System.Drawing.Font("Arial", 9F);
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 102, 77, 38));
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.FooterBand2.Interaction = null;
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
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.PageFooterBand2.Page = this.Page1;
            this.PageFooterBand2.Parent = this.Page1;
            this.Text5.Page = this.Page1;
            this.Text5.Parent = this.PageFooterBand2;
            this.ReportTitleBand1.Page = this.Page1;
            this.ReportTitleBand1.Parent = this.Page1;
            this.Text25.Page = this.Page1;
            this.Text25.Parent = this.ReportTitleBand1;
            this.Text23.Page = this.Page1;
            this.Text23.Parent = this.ReportTitleBand1;
            this.Text26.Page = this.Page1;
            this.Text26.Parent = this.ReportTitleBand1;
            this.Text27.Page = this.Page1;
            this.Text27.Parent = this.ReportTitleBand1;
            this.HeaderBand3.Page = this.Page1;
            this.HeaderBand3.Parent = this.Page1;
            this.Text22.Page = this.Page1;
            this.Text22.Parent = this.HeaderBand3;
            this.HeaderBand1.Page = this.Page1;
            this.HeaderBand1.Parent = this.Page1;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.HeaderBand1;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.HeaderBand1;
            this.Text14.Page = this.Page1;
            this.Text14.Parent = this.HeaderBand1;
            this.Text15.Page = this.Page1;
            this.Text15.Parent = this.HeaderBand1;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.Text18.Page = this.Page1;
            this.Text18.Parent = this.DataBand1;
            this.Text19.Page = this.Page1;
            this.Text19.Parent = this.DataBand1;
            this.Text20.Page = this.Page1;
            this.Text20.Parent = this.DataBand1;
            this.Text17.Page = this.Page1;
            this.Text17.Parent = this.DataBand1;
            this.Text8.Page = this.Page1;
            this.Text8.Parent = this.DataBand1;
            this.FooterBand1.Page = this.Page1;
            this.FooterBand1.Parent = this.Page1;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.FooterBand1;
            this.HeaderBand4.Page = this.Page1;
            this.HeaderBand4.Parent = this.Page1;
            this.Text21.Page = this.Page1;
            this.Text21.Parent = this.HeaderBand4;
            this.HeaderBand2.Page = this.Page1;
            this.HeaderBand2.Parent = this.Page1;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.HeaderBand2;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.HeaderBand2;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.HeaderBand2;
            this.DataBand2.Page = this.Page1;
            this.DataBand2.Parent = this.Page1;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.DataBand2;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.DataBand2;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.DataBand2;
            this.Text13.Page = this.Page1;
            this.Text13.Parent = this.DataBand2;
            this.FooterBand2.Page = this.Page1;
            this.FooterBand2.Parent = this.Page1;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.FooterBand2;
            this.EndRender += new System.EventHandler(this.ReportWordsToEnd__EndRender);
            // 
            // Add to PageFooterBand2.Components
            // 
            this.PageFooterBand2.Components.Clear();
            this.PageFooterBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text5});
            // 
            // Add to ReportTitleBand1.Components
            // 
            this.ReportTitleBand1.Components.Clear();
            this.ReportTitleBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text25,
                        this.Text23,
                        this.Text26,
                        this.Text27});
            // 
            // Add to HeaderBand3.Components
            // 
            this.HeaderBand3.Components.Clear();
            this.HeaderBand3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text22});
            // 
            // Add to HeaderBand1.Components
            // 
            this.HeaderBand1.Components.Clear();
            this.HeaderBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text9,
                        this.Text6,
                        this.Text14,
                        this.Text15});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text18,
                        this.Text19,
                        this.Text20,
                        this.Text17,
                        this.Text8});
            // 
            // Add to FooterBand1.Components
            // 
            this.FooterBand1.Components.Clear();
            this.FooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text7});
            // 
            // Add to HeaderBand4.Components
            // 
            this.HeaderBand4.Components.Clear();
            this.HeaderBand4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text21});
            // 
            // Add to HeaderBand2.Components
            // 
            this.HeaderBand2.Components.Clear();
            this.HeaderBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text11,
                        this.Text10,
                        this.Text12});
            // 
            // Add to DataBand2.Components
            // 
            this.DataBand2.Components.Clear();
            this.DataBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text1,
                        this.Text2,
                        this.Text3,
                        this.Text13});
            // 
            // Add to FooterBand2.Components
            // 
            this.FooterBand2.Components.Clear();
            this.FooterBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text4});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooterBand2,
                        this.ReportTitleBand1,
                        this.HeaderBand3,
                        this.HeaderBand1,
                        this.DataBand1,
                        this.FooterBand1,
                        this.HeaderBand4,
                        this.HeaderBand2,
                        this.DataBand2,
                        this.FooterBand2});
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