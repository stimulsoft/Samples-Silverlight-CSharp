using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace Reports
{
    public class DrillDownListOfProducts : Stimulsoft.Report.StiReport
    {
        public DrillDownListOfProducts()
        {
            this.InitializeComponent();
        }
        
        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Components.StiPage CatalogPage;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand1;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand1;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiDataBand DataProducts;
        public Stimulsoft.Report.Components.StiText DataProducts_ProductName;
        public Stimulsoft.Report.Components.StiInteraction DataProducts_ProductName_Interaction;
        public Stimulsoft.Report.Components.StiWatermark CatalogPage_Watermark;
        public Stimulsoft.Report.Components.StiPage DetailPage;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooter1;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitle1;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiHeaderBand Header1;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiDataBand Data1;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Components.StiText Text16;
        public Stimulsoft.Report.Components.StiWatermark DetailPage_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        public Stimulsoft.Report.StiStyle StyleOdd;
        public DataBusinessObject Data;
        
        public void Text7__GetHyperlink(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "http://www.stimulsoft.com";
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "(c) 2003-" + ToString(sender, Today.Year, true) + " Stimulsoft";
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text4_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Two Simple Lists";
        }
        
        public void DataProducts_ProductName__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Categories.CategoryName, true);
        }
        
        public void DataProducts_ProductName_FillDrillDownParameters(object sender, System.EventArgs e)
        {
            StiComponent comp = sender as StiComponent;
            comp.DrillDownParameters = new System.Collections.Generic.Dictionary<string, object>();
            comp.DrillDownParameters.Add("Category", Data.Categories.CategoryName);
            comp.DrillDownParameters.Add("ReportAlias", Data.Categories.CategoryName);
        }
        
        public void Text1__GetHyperlink(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "http://www.stimulsoft.com";
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "(c) 2003-" + ToString(sender, Today.Year, true) + " Stimulsoft";
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text2_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "List of Products in Category \"" + ToString(sender, this["Category"], true) + "\"";
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Product";
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Price";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Units in Stock";
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Quantity Per Unit";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Products.ProductName, true);
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Products.UnitPrice, true);
        }
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Products.UnitsInStock, true);
        }
        
        public void Text16__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Data.Products.QuantityPerUnit, true);
        }
        
        public void ReportWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text4.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text4_GetValue_End));
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
            this.ReportAlias = "List of Products";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 1, 23, 20, 16, 57, 693);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportFile = "H:\\DrillDownListOfProducts.mrt";
            this.ReportGuid = "f5041e146a0d4cee8a2731ae47bd6d36";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.907";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // CatalogPage
            // 
            this.CatalogPage = new Stimulsoft.Report.Components.StiPage();
            this.CatalogPage.Alias = "Catalog";
            this.CatalogPage.Guid = "468cecb8155a44019d5fe1a8a26a8439";
            this.CatalogPage.Name = "CatalogPage";
            this.CatalogPage.PageHeight = 29.7;
            this.CatalogPage.PageWidth = 21;
            this.CatalogPage.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.CatalogPage.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // PageFooterBand1
            // 
            this.PageFooterBand1 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 26.9, 19, 0.8);
            this.PageFooterBand1.Name = "PageFooterBand1";
            this.PageFooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.PageFooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.8, 0.8);
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.GetHyperlink += new Stimulsoft.Report.Events.StiValueEventHandler(this.Text7__GetHyperlink);
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text7.Guid = null;
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 139, 69, 19));
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7, 0, 12, 0.8);
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text4.Guid = null;
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 139, 69, 19));
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooterBand1.Guid = null;
            this.PageFooterBand1.Interaction = null;
            // 
            // ReportTitleBand1
            // 
            this.ReportTitleBand1 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 1.6);
            this.ReportTitleBand1.Name = "ReportTitleBand1";
            this.ReportTitleBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.ReportTitleBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 1.6);
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.Text5.Guid = null;
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 139, 69, 19));
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand1.Guid = null;
            this.ReportTitleBand1.Interaction = null;
            // 
            // DataProducts
            // 
            this.DataProducts = new Stimulsoft.Report.Components.StiDataBand();
            this.DataProducts.BusinessObjectGuid = "327867a860f341d68bb10fa62b6394df";
            this.DataProducts.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 2.8, 19, 1.4);
            this.DataProducts.Name = "DataProducts";
            this.DataProducts.Sort = new System.String[] {
                    "ASC",
                    "ProductName"};
            this.DataProducts.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.DataProducts.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // DataProducts_ProductName
            // 
            this.DataProducts_ProductName = new Stimulsoft.Report.Components.StiText();
            this.DataProducts_ProductName.CanGrow = true;
            this.DataProducts_ProductName.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 1.4);
            this.DataProducts_ProductName.Name = "DataProducts_ProductName";
            this.DataProducts_ProductName.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.DataProducts_ProductName__GetValue);
            this.DataProducts_ProductName.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.DataProducts_ProductName.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.DataProducts_ProductName.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.DataProducts_ProductName.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.DataProducts_ProductName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.DataProducts_ProductName.Guid = null;
            this.DataProducts_ProductName.Indicator = null;
            this.DataProducts_ProductName_Interaction = new Stimulsoft.Report.Components.StiInteraction();
            this.DataProducts_ProductName_Interaction.DrillDownEnabled = true;
            this.DataProducts_ProductName_Interaction.DrillDownPageGuid = "4b6c7b3c5758414f9695185ef64b99c8";
            this.DataProducts_ProductName_Interaction.DrillDownParameter2 = new Stimulsoft.Report.Components.StiDrillDownParameter();
            this.DataProducts_ProductName.BeforePrint += new System.EventHandler(this.DataProducts_ProductName_FillDrillDownParameters);
            this.DataProducts_ProductName.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.DataProducts_ProductName.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 183, 117, 64));
            this.DataProducts_ProductName.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataProducts.DataRelationName = null;
            this.DataProducts.DataSourceName = null;
            this.DataProducts.Guid = null;
            this.DataProducts.Interaction = null;
            this.DataProducts.MasterComponent = null;
            this.CatalogPage.ExcelSheetValue = null;
            this.CatalogPage.Interaction = null;
            this.CatalogPage.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.CatalogPage_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.CatalogPage_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.CatalogPage_Watermark.Image = null;
            this.CatalogPage_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
            // 
            // DetailPage
            // 
            this.DetailPage = new Stimulsoft.Report.Components.StiPage();
            this.DetailPage.Alias = "List of Products";
            this.DetailPage.Guid = "4b6c7b3c5758414f9695185ef64b99c8";
            this.DetailPage.Name = "DetailPage";
            this.DetailPage.PageHeight = 29.7;
            this.DetailPage.PageWidth = 21;
            this.DetailPage.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.DetailPage.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // PageFooter1
            // 
            this.PageFooter1 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooter1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 26.9, 19, 0.8);
            this.PageFooter1.Guid = "e69d5802c77e469f8697dcda16b6fa8a";
            this.PageFooter1.Name = "PageFooter1";
            this.PageFooter1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.PageFooter1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.8, 0.8);
            this.Text1.Guid = "caf75096dc2e433d9e67b8561e48c8eb";
            this.Text1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text1.GetHyperlink += new Stimulsoft.Report.Events.StiValueEventHandler(this.Text1__GetHyperlink);
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 139, 69, 19));
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7, 0, 12, 0.8);
            this.Text2.Guid = "dcdfc83abfbc4c7ebc6d7cdb3db3cafc";
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 139, 69, 19));
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooter1.Interaction = null;
            // 
            // ReportTitle1
            // 
            this.ReportTitle1 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitle1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 2.2);
            this.ReportTitle1.Guid = "fedc62f66ce44ab48c4f2290fd5502b8";
            this.ReportTitle1.Name = "ReportTitle1";
            this.ReportTitle1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.ReportTitle1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 2.2);
            this.Text3.Guid = "127be65e18d44d52beed2c5297073b2b";
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text3.Font = new System.Drawing.Font("Arial", 27F, System.Drawing.FontStyle.Bold);
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 139, 69, 19));
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitle1.Interaction = null;
            // 
            // Header1
            // 
            this.Header1 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.Header1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.4, 19, 0.6);
            this.Header1.Guid = "41558965588945ad9092d411e175c640";
            this.Header1.Name = "Header1";
            this.Header1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Header1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 7.2, 0.6);
            this.Text6.Guid = "7c14a25f7ebb43fca5ba192fbe4ff416";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 205, 133, 63));
            this.Text6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.4, 0, 3.4, 0.6);
            this.Text9.Guid = "5b6c0466396d495bafedee090a543656";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 205, 133, 63));
            this.Text9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15.8, 0, 3.2, 0.6);
            this.Text10.Guid = "bda4ae1b57d3401fb27306cc4969f5cf";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 205, 133, 63));
            this.Text10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 0, 5.2, 0.6);
            this.Text11.Guid = "f76a9a57fa7b4ef38efa9c5526105829";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 205, 133, 63));
            this.Text11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Header1.Interaction = null;
            // 
            // Data1
            // 
            this.Data1 = new Stimulsoft.Report.Components.StiDataBand();
            this.Data1.BusinessObjectGuid = "4ac9f6a9f56e4186829225a42e77057d";
            this.Data1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.8, 19, 0.6);
            this.Data1.Guid = "620b5efa7d5a407e97a658effa22b739";
            this.Data1.Name = "Data1";
            this.Data1.OddStyle = "Odd";
            this.Data1.Sort = new System.String[] {
                    "ASC",
                    "ProductName"};
            this.Data1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Data1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.CanGrow = true;
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 7.2, 0.6);
            this.Text12.Guid = "d7f89108df784c4bace9528b9317436c";
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text12.Font = new System.Drawing.Font("Arial", 8F);
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.CanGrow = true;
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.4, 0, 3.4, 0.6);
            this.Text14.Guid = "43e4f7a2b1d945a2b8f90592963846d8";
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text14.Font = new System.Drawing.Font("Arial", 8F);
            this.Text14.Indicator = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.CanGrow = true;
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15.8, 0, 3.2, 0.6);
            this.Text15.Guid = "db496dba06b047e7afbcfe7057f58d08";
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text15.Font = new System.Drawing.Font("Arial", 8F);
            this.Text15.Indicator = null;
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text16
            // 
            this.Text16 = new Stimulsoft.Report.Components.StiText();
            this.Text16.CanGrow = true;
            this.Text16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 0, 5.2, 0.6);
            this.Text16.Guid = "589839782de94589924bbc10fb3effbb";
            this.Text16.Name = "Text16";
            this.Text16.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text16__GetValue);
            this.Text16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.Text16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            this.Text16.Font = new System.Drawing.Font("Arial", 8F);
            this.Text16.Indicator = null;
            this.Text16.Interaction = null;
            this.Text16.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text16.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.Text16.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Data1.DataRelationName = null;
            this.Data1.DataSourceName = null;
            this.Data1.Interaction = null;
            this.Data1.MasterComponent = null;
            this.DetailPage.ExcelSheetValue = null;
            this.DetailPage.Interaction = null;
            this.DetailPage.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.DetailPage_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.DetailPage_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.DetailPage_Watermark.Image = null;
            this.DetailPage_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
            this.ReportDescription = null;
            // 
            // StyleOdd
            // 
            this.StyleOdd = new Stimulsoft.Report.StiStyle();
            this.StyleOdd.Name = "Odd";
            this.StyleOdd.StyleCode = Stimulsoft.Report.StiStyleCode.None;
            this.StyleOdd.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Windows.Media.Color.FromArgb(255, 0, 0, 0), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)));
            this.StyleOdd.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 255, 239, 213));
            this.StyleOdd.Font = new System.Drawing.Font("Arial", 8F);
            this.StyleOdd.Image = null;
            this.StyleOdd.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            this.PrinterSettings = this.Report_PrinterSettings;
            this.CatalogPage.Report = this;
            this.CatalogPage.Watermark = this.CatalogPage_Watermark;
            this.PageFooterBand1.Page = this.CatalogPage;
            this.PageFooterBand1.Parent = this.CatalogPage;
            this.Text7.Page = this.CatalogPage;
            this.Text7.Parent = this.PageFooterBand1;
            this.Text4.Page = this.CatalogPage;
            this.Text4.Parent = this.PageFooterBand1;
            this.ReportTitleBand1.Page = this.CatalogPage;
            this.ReportTitleBand1.Parent = this.CatalogPage;
            this.Text5.Page = this.CatalogPage;
            this.Text5.Parent = this.ReportTitleBand1;
            this.DataProducts.Page = this.CatalogPage;
            this.DataProducts.Parent = this.CatalogPage;
            this.DataProducts_ProductName.Interaction = this.DataProducts_ProductName_Interaction;
            this.DataProducts_ProductName.Page = this.CatalogPage;
            this.DataProducts_ProductName.Parent = this.DataProducts;
            this.DetailPage.Report = this;
            this.DetailPage.Watermark = this.DetailPage_Watermark;
            this.PageFooter1.Page = this.DetailPage;
            this.PageFooter1.Parent = this.DetailPage;
            this.Text1.Page = this.DetailPage;
            this.Text1.Parent = this.PageFooter1;
            this.Text2.Page = this.DetailPage;
            this.Text2.Parent = this.PageFooter1;
            this.ReportTitle1.Page = this.DetailPage;
            this.ReportTitle1.Parent = this.DetailPage;
            this.Text3.Page = this.DetailPage;
            this.Text3.Parent = this.ReportTitle1;
            this.Header1.Page = this.DetailPage;
            this.Header1.Parent = this.DetailPage;
            this.Text6.Page = this.DetailPage;
            this.Text6.Parent = this.Header1;
            this.Text9.Page = this.DetailPage;
            this.Text9.Parent = this.Header1;
            this.Text10.Page = this.DetailPage;
            this.Text10.Parent = this.Header1;
            this.Text11.Page = this.DetailPage;
            this.Text11.Parent = this.Header1;
            this.Data1.Page = this.DetailPage;
            this.Data1.Parent = this.DetailPage;
            this.Text12.Page = this.DetailPage;
            this.Text12.Parent = this.Data1;
            this.Text14.Page = this.DetailPage;
            this.Text14.Parent = this.Data1;
            this.Text15.Page = this.DetailPage;
            this.Text15.Parent = this.Data1;
            this.Text16.Page = this.DetailPage;
            this.Text16.Parent = this.Data1;
            this.EndRender += new System.EventHandler(this.ReportWordsToEnd__EndRender);
            // 
            // Add to PageFooterBand1.Components
            // 
            this.PageFooterBand1.Components.Clear();
            this.PageFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text7,
                        this.Text4});
            // 
            // Add to ReportTitleBand1.Components
            // 
            this.ReportTitleBand1.Components.Clear();
            this.ReportTitleBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text5});
            // 
            // Add to DataProducts.Components
            // 
            this.DataProducts.Components.Clear();
            this.DataProducts.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.DataProducts_ProductName});
            // 
            // Add to CatalogPage.Components
            // 
            this.CatalogPage.Components.Clear();
            this.CatalogPage.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooterBand1,
                        this.ReportTitleBand1,
                        this.DataProducts});
            // 
            // Add to PageFooter1.Components
            // 
            this.PageFooter1.Components.Clear();
            this.PageFooter1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text1,
                        this.Text2});
            // 
            // Add to ReportTitle1.Components
            // 
            this.ReportTitle1.Components.Clear();
            this.ReportTitle1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text3});
            // 
            // Add to Header1.Components
            // 
            this.Header1.Components.Clear();
            this.Header1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text6,
                        this.Text9,
                        this.Text10,
                        this.Text11});
            // 
            // Add to Data1.Components
            // 
            this.Data1.Components.Clear();
            this.Data1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text12,
                        this.Text14,
                        this.Text15,
                        this.Text16});
            // 
            // Add to DetailPage.Components
            // 
            this.DetailPage.Components.Clear();
            this.DetailPage.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooter1,
                        this.ReportTitle1,
                        this.Header1,
                        this.Data1});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.CatalogPage,
                        this.DetailPage});
            // 
            // Add to Styles
            // 
            this.Styles.Clear();
            this.Styles.AddRange(new Stimulsoft.Report.StiBaseStyle[] {
                        this.StyleOdd});
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