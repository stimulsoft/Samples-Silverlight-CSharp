using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace Reports
{
    public class BarCodes : Stimulsoft.Report.StiReport
    {
        public BarCodes()
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
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand2;
        public Stimulsoft.Report.Components.StiText Text24;
        public Stimulsoft.Report.Components.StiText Text25;
        public Stimulsoft.Report.Components.StiText Text95;
        public Stimulsoft.Report.Components.StiText Text96;
        public Stimulsoft.Report.Components.StiPageHeaderBand PageHeaderBand1;
        public Stimulsoft.Report.Components.StiText Text46;
        public Stimulsoft.Report.Components.StiText Text47;
        public Stimulsoft.Report.Components.StiText Text48;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode6;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiText Text45;
        public Stimulsoft.Report.Components.StiDataBand DataBand2;
        public Stimulsoft.Report.Components.StiText Text49;
        public Stimulsoft.Report.Components.StiText Text50;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode44;
        public Stimulsoft.Report.Components.StiDataBand DataBand3;
        public Stimulsoft.Report.Components.StiText Text51;
        public Stimulsoft.Report.Components.StiText Text52;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode14;
        public Stimulsoft.Report.Components.StiDataBand DataBand4;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text53;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode45;
        public Stimulsoft.Report.Components.StiDataBand DataBand9;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode8;
        public Stimulsoft.Report.Components.StiDataBand DataBand10;
        public Stimulsoft.Report.Components.StiText Text58;
        public Stimulsoft.Report.Components.StiText Text59;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode9;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Components.StiPage Page2;
        public Stimulsoft.Report.Components.StiPageHeaderBand PageHeaderBand2;
        public Stimulsoft.Report.Components.StiText Text77;
        public Stimulsoft.Report.Components.StiText Text78;
        public Stimulsoft.Report.Components.StiText Text79;
        public Stimulsoft.Report.Components.StiDataBand DataBand5;
        public Stimulsoft.Report.Components.StiText Text54;
        public Stimulsoft.Report.Components.StiText Text55;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode20;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode46;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode47;
        public Stimulsoft.Report.Components.StiText Text60;
        public Stimulsoft.Report.Components.StiText Text61;
        public Stimulsoft.Report.Components.StiDataBand DataBand6;
        public Stimulsoft.Report.Components.StiText Text21;
        public Stimulsoft.Report.Components.StiText Text22;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode21;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode48;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode49;
        public Stimulsoft.Report.Components.StiText Text62;
        public Stimulsoft.Report.Components.StiText Text63;
        public Stimulsoft.Report.Components.StiDataBand DataBand12;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiText Text41;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode7;
        public Stimulsoft.Report.Components.StiDataBand DataBand13;
        public Stimulsoft.Report.Components.StiText Text30;
        public Stimulsoft.Report.Components.StiText Text42;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode11;
        public Stimulsoft.Report.Components.StiWatermark Page2_Watermark;
        public Stimulsoft.Report.Components.StiPage Page3;
        public Stimulsoft.Report.Components.StiPageHeaderBand PageHeaderBand3;
        public Stimulsoft.Report.Components.StiText Text80;
        public Stimulsoft.Report.Components.StiText Text81;
        public Stimulsoft.Report.Components.StiText Text82;
        public Stimulsoft.Report.Components.StiDataBand DataBand7;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode1;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode41;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode42;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiDataBand DataBand8;
        public Stimulsoft.Report.Components.StiText Text56;
        public Stimulsoft.Report.Components.StiText Text57;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode2;
        public Stimulsoft.Report.Components.StiDataBand DataBand14;
        public Stimulsoft.Report.Components.StiText Text32;
        public Stimulsoft.Report.Components.StiText Text43;
        public Stimulsoft.Report.Components.StiText Text64;
        public Stimulsoft.Report.Components.StiText Text65;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode29;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode31;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode38;
        public Stimulsoft.Report.Components.StiWatermark Page3_Watermark;
        public Stimulsoft.Report.Components.StiPage Page4;
        public Stimulsoft.Report.Components.StiPageHeaderBand PageHeaderBand4;
        public Stimulsoft.Report.Components.StiText Text83;
        public Stimulsoft.Report.Components.StiText Text84;
        public Stimulsoft.Report.Components.StiText Text85;
        public Stimulsoft.Report.Components.StiDataBand DataBand15;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiText Text66;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode3;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode4;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode5;
        public Stimulsoft.Report.Components.StiDataBand DataBand16;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiText Text19;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode15;
        public Stimulsoft.Report.Components.StiDataBand DataBand17;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text67;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode16;
        public Stimulsoft.Report.Components.StiDataBand DataBand18;
        public Stimulsoft.Report.Components.StiText Text35;
        public Stimulsoft.Report.Components.StiText Text36;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode17;
        public Stimulsoft.Report.Components.StiDataBand DataBand19;
        public Stimulsoft.Report.Components.StiText Text68;
        public Stimulsoft.Report.Components.StiText Text69;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode34;
        public Stimulsoft.Report.Components.StiDataBand DataBand11;
        public Stimulsoft.Report.Components.StiText Text39;
        public Stimulsoft.Report.Components.StiText Text40;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode10;
        public Stimulsoft.Report.Components.StiWatermark Page4_Watermark;
        public Stimulsoft.Report.Components.StiPage Page5;
        public Stimulsoft.Report.Components.StiPageHeaderBand PageHeaderBand5;
        public Stimulsoft.Report.Components.StiText Text86;
        public Stimulsoft.Report.Components.StiText Text87;
        public Stimulsoft.Report.Components.StiText Text88;
        public Stimulsoft.Report.Components.StiDataBand DataBand21;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiText Text70;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode18;
        public Stimulsoft.Report.Components.StiDataBand DataBand22;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiText Text71;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode19;
        public Stimulsoft.Report.Components.StiDataBand DataBand23;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiText Text72;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode36;
        public Stimulsoft.Report.Components.StiDataBand DataBand20;
        public Stimulsoft.Report.Components.StiText Text37;
        public Stimulsoft.Report.Components.StiText Text38;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode35;
        public Stimulsoft.Report.Components.StiDataBand DataBand24;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Components.StiText Text16;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode12;
        public Stimulsoft.Report.Components.StiDataBand DataBand25;
        public Stimulsoft.Report.Components.StiText Text73;
        public Stimulsoft.Report.Components.StiText Text74;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode13;
        public Stimulsoft.Report.Components.StiDataBand DataBand26;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text28;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode22;
        public Stimulsoft.Report.Components.StiDataBand DataBand27;
        public Stimulsoft.Report.Components.StiText Text31;
        public Stimulsoft.Report.Components.StiText Text75;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode27;
        public Stimulsoft.Report.Components.StiWatermark Page5_Watermark;
        public Stimulsoft.Report.Components.StiPage Page6;
        public Stimulsoft.Report.Components.StiPageHeaderBand PageHeaderBand6;
        public Stimulsoft.Report.Components.StiText Text97;
        public Stimulsoft.Report.Components.StiText Text98;
        public Stimulsoft.Report.Components.StiText Text99;
        public Stimulsoft.Report.Components.StiDataBand DataBand28;
        public Stimulsoft.Report.Components.StiText Text44;
        public Stimulsoft.Report.Components.StiText Text76;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode30;
        public Stimulsoft.Report.Components.StiDataBand DataBand29;
        public Stimulsoft.Report.Components.StiText Text29;
        public Stimulsoft.Report.Components.StiText Text89;
        public Stimulsoft.Report.Components.StiText Text90;
        public Stimulsoft.Report.Components.StiText Text91;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode28;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode37;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode39;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode40;
        public Stimulsoft.Report.Components.StiText Text92;
        public Stimulsoft.Report.Components.StiDataBand DataBand30;
        public Stimulsoft.Report.Components.StiText Text26;
        public Stimulsoft.Report.Components.StiText Text27;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode25;
        public Stimulsoft.Report.Components.StiDataBand DataBand31;
        public Stimulsoft.Report.Components.StiText Text33;
        public Stimulsoft.Report.Components.StiText Text34;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode26;
        public Stimulsoft.Report.Components.StiDataBand DataBand32;
        public Stimulsoft.Report.Components.StiText Text93;
        public Stimulsoft.Report.Components.StiText Text94;
        public Stimulsoft.Report.BarCodes.StiBarCode BarCode32;
        public Stimulsoft.Report.Components.StiWatermark Page6_Watermark;
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
        public Stimulsoft.Report.StiCrossTabStyle StyleCrossTab;
        public CategoriesDataSource Categories;
        public CountriesDataSource Countries;
        public CustomersDataSource Customers;
        public EmployeesDataSource Employees;
        public Order_DetailsDataSource Order_Details;
        public OrdersDataSource Orders;
        public ProductsDataSource Products;
        public ShippersDataSource Shippers;
        public new StatesDataSource States;
        public SuppliersDataSource Suppliers;
        
        public void Text24__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stimulsoft";
        }
        
        public void Text25__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Bar-Codes";
        }
        
        public void Text95__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text96__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text96.TextFormat.Format(CheckExcelValue(sender, "Date: " + Today.ToString("Y")));
        }
        
        public void Text46__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Symbology";
        }
        
        public void Text47__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Example";
        }
        
        public void Text48__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Description";
        }
        
        public void BarCode6__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "ABC123";
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 39";
        }
        
        public void Text45__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 39 is a variable length symbology that can encode 44 characters. Code 39 is " +
"the most popular symbology in the non-retail world and is used extensively in ma" +
"nufacturing, military, and medicine applications. Each Code 39 bar code has a st" +
"art/stop character represented by an asterisk (*).The bar-code code does not con" +
"tain the check character but can be added programmatically. Each character start" +
"s with a \'dark bar\' that consists of 5 dark and 4 blank bars. The ratio between " +
"narrow and wide bars may range from 2.2:1 to 3:1. The Code 39 barcode has low da" +
"ta density. It requires more free space than Code 128, but the Code 39 barcode c" +
"an be identified by any barcode scanner.\r\n";
        }
        
        public void Text49__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 39 Extended";
        }
        
        public void Text50__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 39 extended is the version of the Code 39 bar-code which also supports the A" +
"SCII set of characters. The 0-9, A-Z, \".\" and \"-\" characters are encoded the sam" +
"e as of the Code 39 bar-code. ";
        }
        
        public void BarCode44__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "Abc123";
        }
        
        public void Text51__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 93";
        }
        
        public void Text52__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The Code 93 is a variable length symbology that can encode the complete 128 ASCII" +
" character set. This barcode was developed as an enhanced version of the Code 39" +
" barcode. It has a higher density than either the Code 39 or the Code 128 bar-co" +
"de. The Code 93 barcode may encode Latin letters (from A to Z), digits (from 0 t" +
"o 9) and a group of special characters. The barcode always contains two check ch" +
"aracters. Each characters consist of nine modules which are joined in 3 groups. " +
"Each group has one black bar and one white bar.";
        }
        
        public void BarCode14__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "ABC123";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 93 Extended";
        }
        
        public void Text53__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 93 extended is a version of the Code 93 barcode that supports a set of ASCII" +
" characters. All additional symbols are encoded as a sequence of two Code 93 cha" +
"racters. The first character is always one of four special characters. Therefore" +
", scanners can always identify the different versions of the bar-code.";
        }
        
        public void BarCode45__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "Abc123";
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "UPC-Sup2";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Add-on Symbols (barcodes) can be used in some applications together with the EAN-" +
"13, UPC-A, and UPC-E bar-codes. Add-on Symbols may contain 2 or 5 additional dig" +
"its and are usually placed to the right of the barcode.";
        }
        
        public void BarCode8__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "02";
        }
        
        public void Text58__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "UPC-Sup5";
        }
        
        public void Text59__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Add-on Symbols (barcodes) can be used in some applications together with the EAN-" +
"13, UPC-A, and UPC-E bar-codes. Add-on Symbols may contain 2 or 5 additional dig" +
"its and are usually placed to the right of the barcode.";
        }
        
        public void BarCode9__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "00321";
        }
        
        public void Text77__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Symbology";
        }
        
        public void Text78__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Example";
        }
        
        public void Text79__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Description";
        }
        
        public void Text54__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-8";
        }
        
        public void Text55__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The EAN-8 bar-code was developed for use on small packages. It is used instead of" +
" the EAN-13 bar-code where an EAN-13 barcode would be too large, for example on " +
"packets of gum. The structure of the EAN-8 bar-code is in the same as the struct" +
"ure of the EAN-13 bar-code. The check digit is calculated automatically irrespec" +
"tive of input data. This bar-code does not contain the code of the producer and " +
"has only 4 digits. As a result there can only be 10000 specimen products per  or" +
"ganization, so the EAN-8 bar-code is provided only to those organizations which " +
"really need it.";
        }
        
        public void BarCode20__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "12345678";
        }
        
        public void BarCode46__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "4523456789012";
        }
        
        public void BarCode47__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "4523456789012";
        }
        
        public void Text60__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-8 + Sup2";
        }
        
        public void Text61__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-8 + Sup5";
        }
        
        public void Text21__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-13";
        }
        
        public void Text22__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The EAN-13 barcode was created based on the UPC-A barcode as an extension of the " +
"EAN.UCC system used outside the USA. EAN-13 is the European version of UPC-A. Th" +
"e structure of EAN-13 barcode is the same as UPC-A. Each bar-code character cons" +
"ist of 2 bars and 2 spaces, which may have a width from 1 to 4 modules. The firs" +
"t digit is always placed outside the symbol, additionally the right quiet zone i" +
"ndicator (>) is used to indicate the Quiet Zones that are necessary for barcode " +
"scanners to work properly.";
        }
        
        public void BarCode21__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "0123456789012";
        }
        
        public void BarCode48__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "4523456789012";
        }
        
        public void BarCode49__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "4523456789012";
        }
        
        public void Text62__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-13 + Sup2";
        }
        
        public void Text63__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-13 + Sup5";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "JAN-8";
        }
        
        public void Text41__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "A JAN-8 barcode is another name for an EAN-8 barcode dedicated for use only in Ja" +
"pan. The first two digits of the barcode should be 45 or 49 to indicate Japan. N" +
"ote the \'human readable\' digits at the foot which can be used by operators if th" +
"e label becomes damaged or will not scan for some reason - \"49123456\" is a numbe" +
"r encoded in the barcode.\r\n\r\n";
        }
        
        public void BarCode7__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "4523456789012";
        }
        
        public void Text30__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "JAN-13";
        }
        
        public void Text42__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "A JAN-13 barcode is another name for an EAN-13 barcode dedicated for use only in " +
"Japan. The first two digits should be 45 or 49 which indicate Japan. Note the \'h" +
"uman readable\' digits at the foot which can be used by operators if the label be" +
"comes damaged or will not scan for some reason - \"4901234567894\" is the number e" +
"ncoded in the barcode.\r\n\r\n";
        }
        
        public void BarCode11__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "4523456789012";
        }
        
        public void Text80__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Symbology";
        }
        
        public void Text81__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Example";
        }
        
        public void Text82__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Description";
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "UPC-A";
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "UPC-A was the first barcode, created by Uniform Code Council, Inc. in 1973. The U" +
"PC-A barcode is an unbroken code with a fixed length and high density. It is use" +
"d for tracking trade items in stores, and otherwise marking goods. UPC-A barcode" +
"s consist of 11 data digits and one check digit. The first digit is a number sys" +
"tem digit that normally represents the type of product being identified. The fol" +
"lowing 5 digits are a manufacturers code and the next 5 digits are used to ident" +
"ify a specific product. The barcode does not contain any information about chara" +
"cteristics of a product, but only a unique number relating to an entry in the In" +
"ternational data base where all information about the particular product is stor" +
"ed.\r\n";
        }
        
        public void BarCode1__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "1234567890123";
        }
        
        public void BarCode41__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "4523456789012";
        }
        
        public void BarCode42__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "4523456789012";
        }
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "UPC-A + Sup2";
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "UPC-A + Sup5";
        }
        
        public void Text56__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "UPC-E";
        }
        
        public void Text57__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "A UPC-E is a smaller seven digit UPC symbology for number system 0. For UPC-E bar" +
"codes, normally 6 digits are specified and the barcode calculates the seventh ch" +
"eck digit. Before the Middle guard bars, a binary 1 is indicated by a bar, while" +
" a 0 is indicated by a space. After the Middle guard bars, however, the patterns" +
" are optically inverted. In other words, a 1 is now indicated by a space, and a " +
"0 is now indicated by a bar. It has the same basic structure as the UPC-A barcod" +
"e. Note the \'human readable\' digits at the foot which can be used by operators i" +
"f the label becomes damaged or will not scan for some reason - \"1234567\" is the " +
"number encoded in the barcode.";
        }
        
        public void BarCode2__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "01234567";
        }
        
        public void Text32__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 128a";
        }
        
        public void Text43__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The Code128 barcode was developed in 1981. It is a variable length, high density," +
" alphanumeric symbology. It allows the output of 128 characters of ASCII and is " +
"effective for digits. There are actually three subcodes, which can be mixed with" +
"in a single barcode: Code128a, Code128b, Code128c. The barcode consist of three " +
"bars and three spaces. Bars and spaces have module construction and their width " +
"consist of one or four modules. The width of an element consist of eleven module" +
"s. The \"Stop\" sign consist of 13 modules and has four bars and three spaces. The" +
" check sum is calculated automatically.";
        }
        
        public void Text64__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 128b";
        }
        
        public void Text65__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 128c";
        }
        
        public void BarCode29__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "ABC123";
        }
        
        public void BarCode31__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "ABCabc123";
        }
        
        public void BarCode38__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "0123456789012345";
        }
        
        public void Text83__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Symbology";
        }
        
        public void Text84__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Example";
        }
        
        public void Text85__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Description";
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-128a";
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The EAN-128 bar-code is a subset of the Code128 barcode which uses a variable len" +
"gth, high density, alphanumeric symbology. It allows the output of 128 character" +
"s of ASCII and is effective for digits. There are actually three subcodes, which" +
" can be mixed within a single barcode: EAN-128a, EAN-128b, EAN-128c. The structu" +
"re of the EAN-128 bar-code is the same as for the Code128 bar-code. Elements of " +
"the bar-code consist of three bars and three spaces. Bars and spaces have module" +
" construction and their width consists of either one or four modules. The width " +
"of an element consists of eleven modules. To difference between the EAN-128 bar-" +
"code and the Code128 bar-code is that the FNC1 is placed after the start charact" +
"er. This character is reserved for the EAN.UCC system.";
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-128b";
        }
        
        public void Text66__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "EAN-128c";
        }
        
        public void BarCode3__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "ABC123";
        }
        
        public void BarCode4__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "ABCabc123";
        }
        
        public void BarCode5__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "0123456789012345";
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Code 11";
        }
        
        public void Text19__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The Code 11 bar-code weas developed by Intermec in 1977. It is used in telecommun" +
"ications. This barcode has high density and can encode any length string consist" +
"ing of the digits 0-9 and the dash character. The Code 11 uses one or two check " +
"digits and two check symbols. Usually, if the length of the string is less than " +
"10 symbols then only one check symbol is used. If the the length of the string i" +
"s 10 symbols and more then 2 check symbols are used. The value of the check symb" +
"ol is calculated by the modulo-10 algorithm.";
        }
        
        public void BarCode15__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "A12345678B";
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Pharmacode";
        }
        
        public void Text67__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "A Pharmacode barcode is used in the pharmaceutical industry as a packing control " +
"system. The Pharmacode barcode is placed on the package. A Pharmacode barcode ca" +
"n represent only a single integer from 3 to 131070. All digits in the specified " +
"range make correct barcodes, but some of these barcodes can be unreadable becaus" +
"e all barcodes are identical.";
        }
        
        public void BarCode16__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "1256";
        }
        
        public void Text35__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ISBN-10";
        }
        
        public void Text36__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ISBN is the abbreviation of International Standard Book Number - a unique, numeri" +
"c commercial book identifier. Based upon the 9-digit Standard Book Numbering (SB" +
"N) code introduced in 1966,  10-digit ISBN format was developed in 1970 and beca" +
"me the international standard. Note the \'human readable\' digits at the foot whic" +
"h can be used by operators if the label becomes damaged or will not scan for som" +
"e reason - \"80-902734-1-6\" is the number encoded in the barcode.\r\n\r\n";
        }
        
        public void BarCode17__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "0-7356-2153-5";
        }
        
        public void Text68__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ISBN-13";
        }
        
        public void Text69__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ISBN is the abbreviation of International Standard Book Number - a unique, numeri" +
"c commercial book identifier.  The ISBN-13 specification was Issued from January" +
" 2007, and describes how the 13-digit ISBN check digit is calculated. Note the \'" +
"human readable\' digits at the foot which can be used by operators if the label b" +
"ecomes damaged or will not scan for some reason - \"978-0-306-40615-7\" is a numbe" +
"r encoded in the barcode.\r\n\r\n";
        }
        
        public void BarCode34__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "978-0-7356-2153-4";
        }
        
        public void Text39__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Codabar";
        }
        
        public void Text40__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The Codabar is a linear barcode symbology developed in 1972. It can be called as " +
"NW-7, USD-4, Code 2 of 7 (2 values of a bar length, 7 elements). It is frequentl" +
"y used in medicine (for example, blood bank forms). Two bars and three spaces ar" +
"e used for encoding. The bar-code has four different sets of start/stop characte" +
"rs: A, B, C, D. These characters are used only as start/stop characters and shou" +
"ld not be appeared in the bar-code.";
        }
        
        public void BarCode10__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "A12345678B";
        }
        
        public void Text86__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Symbology";
        }
        
        public void Text87__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Example";
        }
        
        public void Text88__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Description";
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Msi";
        }
        
        public void Text70__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The Msi bar-code developed by the MSI Data Corporation. It is based on the origin" +
"al Plessey symbology. Sometimes the Msi bar-code is called the Modified Plessey." +
" The basic implementation of the Msi bar-code is used for warehouse shelves and " +
"inventory. Msi is a variable length, numeric-only symbology and allows to output" +
" digits 0..9. One or two check digits calculated by modulo-10 or modulo-11 can b" +
"e used. Each character of the bar-code consist of 4 elements. If the element is " +
"the binary 0 then the bar-code has the 1 module width and a space has 2 modules." +
" If the element is the binary 1 the the bar the 2 module width and a space has  " +
"1 modules. So, each character has 12 modules length. Therefore, this bar-code ha" +
"s very low data density.";
        }
        
        public void BarCode18__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "1234567";
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "2 of 5 Standard";
        }
        
        public void Text71__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The 2of5 bar-code was developed 40 years ago. This is a low density variable leng" +
"th numeric. This barcode is used in manufacture and is known as Code 25, Code 25" +
" Standard or Code 25 Industrial. It is very seldom used these days.\r\n";
        }
        
        public void BarCode19__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "12345678";
        }
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "2 of 5 Interleaved";
        }
        
        public void Text72__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The 2of5 Interleaved barcode is a high density variable length numeric only symbo" +
"logy that encodes digit pairs in an interleaved manner. This bar-code is develop" +
"ed of the Code 25 Standard. It is usually used in the industrial.";
        }
        
        public void BarCode36__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "12345678";
        }
        
        public void Text37__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Plessey";
        }
        
        public void Text38__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "A Plessey barcode was created by Plessey company in England on March 1971. The Pl" +
"essey barcode is widely used in libraries, supermarkets, and production environm" +
"ents. A variant of the barcode known as Anker Code and appropriate scanners were" +
" provided by the ADS company. Encoding technology of the Plessey barcode was use" +
"d by MSE Data Corporation. This company used it to create an MSI barcode that so" +
"metimes is called \'modified Plessey\'. This bar-code is now obsolete and new scan" +
"ners cannot read it.\r\n\r\n";
        }
        
        public void BarCode35__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "1234567";
        }
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Postnet";
        }
        
        public void Text16__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The POSTNET (POSTal Numeric Encoding Technique) bar-code was developed by the Uni" +
"ted States Postal Service for encoding ZIP-codes and correct sorting using BCSs." +
" It can encode ZIP, ZIP+4, and ZIP+4+2 postal codes.\r\nThe Postnet bar-code can e" +
"ncode 0-9 digits. The bar-code consist of short and long bars. Each symbol of da" +
"ta is encoded using five bars. This bar-code contains only one check symbol, tha" +
"t is calculated by the modulo-10 algorithm.";
        }
        
        public void BarCode12__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "12345";
        }
        
        public void Text73__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Australia Post 4 State";
        }
        
        public void Text74__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The Australia Post 4-Stage bar-code is used in Australia for the purposes of sort" +
"ing and directing mail. The barcode consists of 4 elements (4 conditions), each " +
"has its own name, value. Each element consists of two bars and two spaces. Each " +
"barcode contains 4 check symbols, calculated by the ReedSolomon algorithm. The v" +
"alue of these symbols are usually printed after the text of the barcode.";
        }
        
        public void BarCode13__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "1139987520";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Royal Mail 4 State";
        }
        
        public void Text28__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The Royal Mail 4-state Customer Code(RM4SCC) is a height-modulated barcode symbol" +
"ogy for use in automated mail sort process.";
        }
        
        public void BarCode22__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "529508A";
        }
        
        public void Text31__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Royal TPG Post KIX 4-State";
        }
        
        public void Text75__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "This symbology is used by Royal Dutch TPG Post (Netherlands) for Postal code and " +
"automatic mail sorting. It provides information about the address of the receive" +
"r. This symbology encodes alpha-numeric characters (0-9, A-Z).";
        }
        
        public void BarCode27__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "2500GG30250";
        }
        
        public void Text97__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Symbology";
        }
        
        public void Text98__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Example";
        }
        
        public void Text99__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Description";
        }
        
        public void Text44__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ITF 14";
        }
        
        public void Text76__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The ITF-14 bar-code was developed to encode a Global Trade Item Number. The ITF b" +
"ar-code has the nominal size of  (152*44mm) and low requirements to the printing" +
" surface. Therefore, it can be printed not only on a label but directly onto a p" +
"acking carton.";
        }
        
        public void BarCode30__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "15400141288763";
        }
        
        public void Text29__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "FIM A";
        }
        
        public void Text89__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Facing Identification Mark (FIM) is the type of postal bar code used in automated" +
" mail processing by the U.S. Postal Service. FIM is a set of vertical bars. FIM " +
"patterns are placed in the upper right corner along the top edge and two inches " +
"in from the right edge of letters and cards.";
        }
        
        public void Text90__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "FIM B";
        }
        
        public void Text91__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "FIM C";
        }
        
        public void BarCode28__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "A";
        }
        
        public void BarCode37__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "B";
        }
        
        public void BarCode39__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "C";
        }
        
        public void BarCode40__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "D";
        }
        
        public void Text92__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "FIM D";
        }
        
        public void Text26__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "DataMatrix";
        }
        
        public void Text27__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The DataMatrix barcode was created by the CiMatrix company. Every DataMatrix is c" +
"omposed of two solid adjacent borders in an \"L\" shape (called the \"finder patter" +
"n\") and two other borders consisting of alternating dark and light \"cells\" or mo" +
"dules (called the \"timing pattern\"). Symbol sizes vary from 8×8 to 144×144. The " +
"DataMatrix is used to mark small products. Data Matrix symbols are rectangular i" +
"n shape and usually square, they are made of cells: little elements that represe" +
"nt individual bits.";
        }
        
        public void BarCode25__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "12345678901";
        }
        
        public void Text33__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "PDF417";
        }
        
        public void Text34__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "The PDF417 barcode was developed by Symbol Technologies in 1991. The name of the " +
"barcode consist of 2 parts. The PDF comes from Portable Data File. The 417 comes" +
" from the structure of the bar-code: each bar-code character consists of 17 modu" +
"les, each of which consists of 4 bars and 1 space. PDF417 is a high density 2 di" +
"mensional bar code symbology that consists of a stacked set of smaller bar codes" +
". Any ASCII characters can be encoded in this bar-code. The length of data depen" +
"ds on the encoding mode and can reach 1100 bytes, or 1800 text characters, or 26" +
"00 digits.";
        }
        
        public void BarCode26__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "12345678901";
        }
        
        public void Text93__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "QR Code";
        }
        
        public void Text94__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "A QR Code (QR is the abbreviation for Quick Response) is a two-dimensional code, " +
"readable by QR scanners, mobile phones with a camera, and smartphones. It was cr" +
"eated by Toyota subsidiary Denso-Wave in 1994.";
        }
        
        public void BarCode32__GetBarCode(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "12345678901";
        }
        
        private void InitializeComponent()
        {
            this.Suppliers = new SuppliersDataSource();
            this.States = new StatesDataSource();
            this.Shippers = new ShippersDataSource();
            this.Products = new ProductsDataSource();
            this.Orders = new OrdersDataSource();
            this.Order_Details = new Order_DetailsDataSource();
            this.Employees = new EmployeesDataSource();
            this.Customers = new CustomersDataSource();
            this.Countries = new CountriesDataSource();
            this.Categories = new CategoriesDataSource();
            this.ParentSuppliers = new Stimulsoft.Report.Dictionary.StiDataRelation("SuppliersProducts", "ParentSuppliers", "Suppliers", this.Suppliers, this.Products, new System.String[] {
                        "SupplierID"}, new System.String[] {
                        "SupplierID"});
            this.ParentCategories = new Stimulsoft.Report.Dictionary.StiDataRelation("CategoriesProducts", "ParentCategories", "Categories", this.Categories, this.Products, new System.String[] {
                        "CategoryID"}, new System.String[] {
                        "CategoryID"});
            this.ParentEmployees1 = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesOrders", "ParentEmployees", "Employees", this.Employees, this.Orders, new System.String[] {
                        "EmployeeID"}, new System.String[] {
                        "EmployeeID"});
            this.ParentShippers = new Stimulsoft.Report.Dictionary.StiDataRelation("ShippersOrders", "ParentShippers", "Shippers", this.Shippers, this.Orders, new System.String[] {
                        "ShipperID"}, new System.String[] {
                        "ShipVia"});
            this.ParentCustomers = new Stimulsoft.Report.Dictionary.StiDataRelation("CustomersOrders", "ParentCustomers", "Customers", this.Customers, this.Orders, new System.String[] {
                        "CustomerID"}, new System.String[] {
                        "CustomerID"});
            this.ParentOrders = new Stimulsoft.Report.Dictionary.StiDataRelation("OrdersOrder_Details", "ParentOrders", "Orders", this.Orders, this.Order_Details, new System.String[] {
                        "OrderID"}, new System.String[] {
                        "OrderID"});
            this.ParentProducts = new Stimulsoft.Report.Dictionary.StiDataRelation("ProductsOrder_Details", "ParentProducts", "Products", this.Products, this.Order_Details, new System.String[] {
                        "ProductID"}, new System.String[] {
                        "ProductID"});
            this.ParentEmployees = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesEmployees", "ParentEmployees", "Employees", this.Employees, this.Employees, new System.String[] {
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
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "BarCodes";
            this.ReportAuthor = "Stimulsoft";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 4, 4, 8, 29, 5, 401);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "This sample demonstrates how to create a report with Barcodes.";
            this.ReportFile = "E:\\002\\BarCodes.mrt";
            this.ReportGuid = "c650269bd9b7430ebd82feef7d07306c";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.1000";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "8764d9723d5c4e8a9a396f493b4fa40b";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 29.7;
            this.Page1.PageWidth = 21;
            this.Page1.TitleBeforeHeader = true;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // ReportTitleBand2
            // 
            this.ReportTitleBand2 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 2);
            this.ReportTitleBand2.Guid = "34839448fd6242af8ad23f8514aed14e";
            this.ReportTitleBand2.Name = "ReportTitleBand2";
            this.ReportTitleBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.ReportTitleBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text24
            // 
            this.Text24 = new Stimulsoft.Report.Components.StiText();
            this.Text24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.4, 0, 9.6, 0.8);
            this.Text24.ComponentStyle = "Title1";
            this.Text24.Guid = "87f467faa05c4e6488c7d802dbd6f39f";
            this.Text24.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text24.Name = "Text24";
            this.Text24.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text24__GetValue);
            this.Text24.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text24.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text24.Font = new System.Drawing.Font("Arial", 19F);
            this.Text24.Indicator = null;
            this.Text24.Interaction = null;
            this.Text24.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text24.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text24.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text25
            // 
            this.Text25 = new Stimulsoft.Report.Components.StiText();
            this.Text25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9.4, 0.8);
            this.Text25.ComponentStyle = "Title1";
            this.Text25.Guid = "d9874c36a6354a53bda30eb2c4d1f3a1";
            this.Text25.Name = "Text25";
            this.Text25.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text25__GetValue);
            this.Text25.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text25.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text25.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text25.Font = new System.Drawing.Font("Arial", 19F);
            this.Text25.Indicator = null;
            this.Text25.Interaction = null;
            this.Text25.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text25.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text25.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text95
            // 
            this.Text95 = new Stimulsoft.Report.Components.StiText();
            this.Text95.CanGrow = true;
            this.Text95.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1, 14.6, 0.8);
            this.Text95.ComponentStyle = "Title2";
            this.Text95.Guid = "8cd0a4fab927479eb202f77fd5c5ea00";
            this.Text95.Name = "Text95";
            this.Text95.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text95__GetValue);
            this.Text95.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text95.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text95.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text95.Font = new System.Drawing.Font("Arial", 9F);
            this.Text95.Indicator = null;
            this.Text95.Interaction = null;
            this.Text95.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text95.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text95.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text96
            // 
            this.Text96 = new Stimulsoft.Report.Components.StiText();
            this.Text96.CanGrow = true;
            this.Text96.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14.6, 1, 4.4, 0.8);
            this.Text96.ComponentStyle = "Title2";
            this.Text96.Guid = "b9813368ad1e42d386d9c6236ea74552";
            this.Text96.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text96.Name = "Text96";
            this.Text96.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text96__GetValue);
            this.Text96.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text96.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text96.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text96.Font = new System.Drawing.Font("Arial", 9F);
            this.Text96.Indicator = null;
            this.Text96.Interaction = null;
            this.Text96.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text96.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text96.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("yyyy, MMMM", " ");
            this.Text96.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand2.Interaction = null;
            // 
            // PageHeaderBand1
            // 
            this.PageHeaderBand1 = new Stimulsoft.Report.Components.StiPageHeaderBand();
            this.PageHeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.2, 19, 0.6);
            this.PageHeaderBand1.Name = "PageHeaderBand1";
            this.PageHeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageHeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text46
            // 
            this.Text46 = new Stimulsoft.Report.Components.StiText();
            this.Text46.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 0.6);
            this.Text46.ComponentStyle = "Header3";
            this.Text46.Guid = "e4f5664f55354a8da88d4d3083ba58ae";
            this.Text46.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text46.Name = "Text46";
            this.Text46.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text46__GetValue);
            this.Text46.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text46.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text46.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text46.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text46.Indicator = null;
            this.Text46.Interaction = null;
            this.Text46.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text46.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text46.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text47
            // 
            this.Text47 = new Stimulsoft.Report.Components.StiText();
            this.Text47.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 0.6);
            this.Text47.ComponentStyle = "Header3";
            this.Text47.Guid = "9641c5f9d9ce42029fbb54f0673e9828";
            this.Text47.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text47.Name = "Text47";
            this.Text47.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text47__GetValue);
            this.Text47.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text47.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text47.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text47.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text47.Indicator = null;
            this.Text47.Interaction = null;
            this.Text47.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text47.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text47.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text48
            // 
            this.Text48 = new Stimulsoft.Report.Components.StiText();
            this.Text48.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 0.6);
            this.Text48.ComponentStyle = "Header3";
            this.Text48.Guid = "4226776896ca4742af2c4e08614e2083";
            this.Text48.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text48.Name = "Text48";
            this.Text48.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text48__GetValue);
            this.Text48.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text48.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text48.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text48.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text48.Indicator = null;
            this.Text48.Interaction = null;
            this.Text48.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text48.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text48.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageHeaderBand1.Guid = null;
            this.PageHeaderBand1.Interaction = null;
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.6, 19, 3.4);
            this.DataBand1.ComponentStyle = "Data1";
            this.DataBand1.CountData = 1;
            this.DataBand1.EvenStyle = "Data2";
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new System.String[0];
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // BarCode6
            // 
            this.BarCode6 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode6.BackColor = System.Drawing.Color.Transparent;
            this.BarCode6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.4);
            this.BarCode6.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode6__GetBarCode);
            this.BarCode6.ForeColor = System.Drawing.Color.Black;
            this.BarCode6.GrowToHeight = true;
            this.BarCode6.Guid = "bc4b62b60fd94d2f82b49dca3a5b6254";
            this.BarCode6.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode6.Name = "BarCode6";
            this.BarCode6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode6.BarCodeType = new Stimulsoft.Report.BarCodes.StiCode39BarCodeType(13F, 1F, 2.2F, Stimulsoft.Report.BarCodes.StiCheckSum.Yes);
            this.BarCode6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode6.Interaction = null;
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.CanGrow = true;
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.4);
            this.Text9.ComponentStyle = "Header4";
            this.Text9.GrowToHeight = true;
            this.Text9.Guid = "f1df50c103ed499a8a817c5cec3438fa";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text45
            // 
            this.Text45 = new Stimulsoft.Report.Components.StiText();
            this.Text45.CanGrow = true;
            this.Text45.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3.4);
            this.Text45.ComponentStyle = "Data1";
            this.Text45.GrowToHeight = true;
            this.Text45.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text45.Name = "Text45";
            this.Text45.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text45__GetValue);
            this.Text45.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text45.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text45.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text45.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text45.Font = new System.Drawing.Font("Arial", 9F);
            this.Text45.Guid = null;
            this.Text45.Indicator = null;
            this.Text45.Interaction = null;
            this.Text45.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text45.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text45.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand1.DataRelationName = null;
            this.DataBand1.Guid = null;
            this.DataBand1.Interaction = null;
            this.DataBand1.MasterComponent = null;
            // 
            // DataBand2
            // 
            this.DataBand2 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 8.8, 19, 2.6);
            this.DataBand2.ComponentStyle = "Data2";
            this.DataBand2.CountData = 1;
            this.DataBand2.EvenStyle = "Data2";
            this.DataBand2.Guid = "93d783f9448f48c38d7252becb993b0a";
            this.DataBand2.Name = "DataBand2";
            this.DataBand2.Sort = new System.String[0];
            this.DataBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text49
            // 
            this.Text49 = new Stimulsoft.Report.Components.StiText();
            this.Text49.CanGrow = true;
            this.Text49.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.6);
            this.Text49.ComponentStyle = "Header4";
            this.Text49.GrowToHeight = true;
            this.Text49.Guid = "f68b33392e8b46df870e43a282c3ac39";
            this.Text49.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text49.Name = "Text49";
            this.Text49.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text49__GetValue);
            this.Text49.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text49.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text49.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text49.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text49.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text49.Indicator = null;
            this.Text49.Interaction = null;
            this.Text49.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text49.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text49.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text50
            // 
            this.Text50 = new Stimulsoft.Report.Components.StiText();
            this.Text50.CanGrow = true;
            this.Text50.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.6);
            this.Text50.ComponentStyle = "Data1";
            this.Text50.GrowToHeight = true;
            this.Text50.Guid = "37a6066df6174b04a285d19a4c338d21";
            this.Text50.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text50.Name = "Text50";
            this.Text50.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text50__GetValue);
            this.Text50.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text50.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text50.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text50.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text50.Font = new System.Drawing.Font("Arial", 9F);
            this.Text50.Indicator = null;
            this.Text50.Interaction = null;
            this.Text50.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text50.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text50.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode44
            // 
            this.BarCode44 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode44.BackColor = System.Drawing.Color.Transparent;
            this.BarCode44.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.6);
            this.BarCode44.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode44__GetBarCode);
            this.BarCode44.ForeColor = System.Drawing.Color.Black;
            this.BarCode44.GrowToHeight = true;
            this.BarCode44.Guid = "45b3c03e14594bf9812d1fd0a76c265d";
            this.BarCode44.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode44.Name = "BarCode44";
            this.BarCode44.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode44.BarCodeType = new Stimulsoft.Report.BarCodes.StiCode39ExtBarCodeType(13F, 1F, 2.2F, Stimulsoft.Report.BarCodes.StiCheckSum.Yes);
            this.BarCode44.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode44.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode44.Interaction = null;
            this.DataBand2.DataRelationName = null;
            this.DataBand2.Interaction = null;
            this.DataBand2.MasterComponent = null;
            // 
            // DataBand3
            // 
            this.DataBand3 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 12.2, 19, 3.4);
            this.DataBand3.ComponentStyle = "Data1";
            this.DataBand3.CountData = 1;
            this.DataBand3.EvenStyle = "Data2";
            this.DataBand3.Guid = "5d1e47b8e250498ba09aebdcc1792276";
            this.DataBand3.Name = "DataBand3";
            this.DataBand3.Sort = new System.String[0];
            this.DataBand3.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text51
            // 
            this.Text51 = new Stimulsoft.Report.Components.StiText();
            this.Text51.CanGrow = true;
            this.Text51.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.4);
            this.Text51.ComponentStyle = "Header4";
            this.Text51.GrowToHeight = true;
            this.Text51.Guid = "a5bd5688647243629518657d029d6984";
            this.Text51.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text51.Name = "Text51";
            this.Text51.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text51__GetValue);
            this.Text51.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text51.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text51.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text51.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text51.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text51.Indicator = null;
            this.Text51.Interaction = null;
            this.Text51.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text51.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text51.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text52
            // 
            this.Text52 = new Stimulsoft.Report.Components.StiText();
            this.Text52.CanGrow = true;
            this.Text52.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3.4);
            this.Text52.ComponentStyle = "Data1";
            this.Text52.GrowToHeight = true;
            this.Text52.Guid = "4c5c487ef4134a88b9ec203c2b15668d";
            this.Text52.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text52.Name = "Text52";
            this.Text52.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text52__GetValue);
            this.Text52.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text52.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text52.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text52.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text52.Font = new System.Drawing.Font("Arial", 9F);
            this.Text52.Indicator = null;
            this.Text52.Interaction = null;
            this.Text52.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text52.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text52.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode14
            // 
            this.BarCode14 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode14.BackColor = System.Drawing.Color.Transparent;
            this.BarCode14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.4);
            this.BarCode14.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode14__GetBarCode);
            this.BarCode14.ForeColor = System.Drawing.Color.Black;
            this.BarCode14.GrowToHeight = true;
            this.BarCode14.Guid = "cc377af3cc2043debf108abec942fa3a";
            this.BarCode14.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode14.Name = "BarCode14";
            this.BarCode14.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode14.BarCodeType = new Stimulsoft.Report.BarCodes.StiCode93BarCodeType(13F, 1F, 2.2F);
            this.BarCode14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode14.Interaction = null;
            this.DataBand3.DataRelationName = null;
            this.DataBand3.Interaction = null;
            this.DataBand3.MasterComponent = null;
            // 
            // DataBand4
            // 
            this.DataBand4 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 16.4, 19, 2.6);
            this.DataBand4.ComponentStyle = "Data2";
            this.DataBand4.CountData = 1;
            this.DataBand4.EvenStyle = "Data2";
            this.DataBand4.Guid = "6d40bdc4c5244b48b3657bfae8913433";
            this.DataBand4.Name = "DataBand4";
            this.DataBand4.Sort = new System.String[0];
            this.DataBand4.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.CanGrow = true;
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.6);
            this.Text17.ComponentStyle = "Header4";
            this.Text17.GrowToHeight = true;
            this.Text17.Guid = "b1f006ed9c7d46ce96a9038988f86f55";
            this.Text17.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text53
            // 
            this.Text53 = new Stimulsoft.Report.Components.StiText();
            this.Text53.CanGrow = true;
            this.Text53.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.6);
            this.Text53.ComponentStyle = "Data1";
            this.Text53.GrowToHeight = true;
            this.Text53.Guid = "167202641c29484383185dda4aab76ce";
            this.Text53.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text53.Name = "Text53";
            this.Text53.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text53__GetValue);
            this.Text53.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text53.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text53.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text53.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text53.Font = new System.Drawing.Font("Arial", 9F);
            this.Text53.Indicator = null;
            this.Text53.Interaction = null;
            this.Text53.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text53.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text53.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode45
            // 
            this.BarCode45 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode45.BackColor = System.Drawing.Color.Transparent;
            this.BarCode45.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.6);
            this.BarCode45.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode45__GetBarCode);
            this.BarCode45.ForeColor = System.Drawing.Color.Black;
            this.BarCode45.GrowToHeight = true;
            this.BarCode45.Guid = "be1224b9023c482192c0b4f2e59a9205";
            this.BarCode45.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode45.Name = "BarCode45";
            this.BarCode45.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode45.BarCodeType = new Stimulsoft.Report.BarCodes.StiCode93ExtBarCodeType(13F, 1F, 2.2F);
            this.BarCode45.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode45.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode45.Interaction = null;
            this.DataBand4.DataRelationName = null;
            this.DataBand4.Interaction = null;
            this.DataBand4.MasterComponent = null;
            // 
            // DataBand9
            // 
            this.DataBand9 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19.8, 19, 2.8);
            this.DataBand9.ComponentStyle = "Data1";
            this.DataBand9.CountData = 1;
            this.DataBand9.EvenStyle = "Data2";
            this.DataBand9.Guid = "1cffc206ccbd4ad6bc2c091bc464e97e";
            this.DataBand9.Name = "DataBand9";
            this.DataBand9.Sort = new System.String[0];
            this.DataBand9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.CanGrow = true;
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.8);
            this.Text11.ComponentStyle = "Header4";
            this.Text11.GrowToHeight = true;
            this.Text11.Guid = "236d91f38bac427f840cfc2375c6b3e9";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.CanGrow = true;
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.8);
            this.Text12.ComponentStyle = "Data1";
            this.Text12.Guid = "68f859e1d0b44ed182aa6c2991f03fb6";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text12.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text12.Font = new System.Drawing.Font("Arial", 9F);
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode8
            // 
            this.BarCode8 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode8.BackColor = System.Drawing.Color.Transparent;
            this.BarCode8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.8);
            this.BarCode8.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode8__GetBarCode);
            this.BarCode8.ForeColor = System.Drawing.Color.Black;
            this.BarCode8.GrowToHeight = true;
            this.BarCode8.Guid = "935eb7b0f7d7456d8e5c79a0c3501e13";
            this.BarCode8.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode8.Name = "BarCode8";
            this.BarCode8.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode8.BarCodeType = new Stimulsoft.Report.BarCodes.StiUpcSup2BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, false);
            this.BarCode8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode8.Interaction = null;
            this.DataBand9.DataRelationName = null;
            this.DataBand9.Interaction = null;
            this.DataBand9.MasterComponent = null;
            // 
            // DataBand10
            // 
            this.DataBand10 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 23.4, 19, 3);
            this.DataBand10.ComponentStyle = "Data2";
            this.DataBand10.CountData = 1;
            this.DataBand10.Guid = "e60c79d9ff13483b9eeb3bd154c16ed6";
            this.DataBand10.Name = "DataBand10";
            this.DataBand10.Sort = new System.String[0];
            this.DataBand10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text58
            // 
            this.Text58 = new Stimulsoft.Report.Components.StiText();
            this.Text58.CanGrow = true;
            this.Text58.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3);
            this.Text58.ComponentStyle = "Header4";
            this.Text58.GrowToHeight = true;
            this.Text58.Guid = "c052ca64c88f414bade17052cb3c5e1b";
            this.Text58.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text58.Name = "Text58";
            this.Text58.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text58__GetValue);
            this.Text58.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text58.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text58.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text58.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text58.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text58.Indicator = null;
            this.Text58.Interaction = null;
            this.Text58.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text58.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text58.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text59
            // 
            this.Text59 = new Stimulsoft.Report.Components.StiText();
            this.Text59.CanGrow = true;
            this.Text59.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3);
            this.Text59.ComponentStyle = "Data1";
            this.Text59.Guid = "46e27a27dfec455bbb302c3e838b9181";
            this.Text59.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text59.Name = "Text59";
            this.Text59.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text59__GetValue);
            this.Text59.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text59.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text59.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text59.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text59.Font = new System.Drawing.Font("Arial", 9F);
            this.Text59.Indicator = null;
            this.Text59.Interaction = null;
            this.Text59.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text59.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text59.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode9
            // 
            this.BarCode9 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode9.BackColor = System.Drawing.Color.Transparent;
            this.BarCode9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3);
            this.BarCode9.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode9__GetBarCode);
            this.BarCode9.ForeColor = System.Drawing.Color.Black;
            this.BarCode9.GrowToHeight = true;
            this.BarCode9.Guid = "db195fe2196d4297aeb577ea7bcb0826";
            this.BarCode9.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode9.Name = "BarCode9";
            this.BarCode9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode9.BarCodeType = new Stimulsoft.Report.BarCodes.StiUpcSup5BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, false);
            this.BarCode9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode9.Interaction = null;
            this.DataBand10.DataRelationName = null;
            this.DataBand10.Interaction = null;
            this.DataBand10.MasterComponent = null;
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            // 
            // Page2
            // 
            this.Page2 = new Stimulsoft.Report.Components.StiPage();
            this.Page2.Guid = "4d3371d91f814f02a331c99b54ecf20a";
            this.Page2.Name = "Page2";
            this.Page2.PageHeight = 29.7;
            this.Page2.PageWidth = 21;
            this.Page2.PrintOnPreviousPage = true;
            this.Page2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageHeaderBand2
            // 
            this.PageHeaderBand2 = new Stimulsoft.Report.Components.StiPageHeaderBand();
            this.PageHeaderBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 0.6);
            this.PageHeaderBand2.Guid = "c9c9a16de9164754a40121db7fcdd22f";
            this.PageHeaderBand2.Name = "PageHeaderBand2";
            this.PageHeaderBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageHeaderBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text77
            // 
            this.Text77 = new Stimulsoft.Report.Components.StiText();
            this.Text77.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 0.6);
            this.Text77.ComponentStyle = "Header3";
            this.Text77.Guid = "ce348690aa1c435f809a7d031f654b8a";
            this.Text77.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text77.Name = "Text77";
            this.Text77.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text77__GetValue);
            this.Text77.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text77.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text77.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text77.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text77.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text77.Indicator = null;
            this.Text77.Interaction = null;
            this.Text77.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text77.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text77.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text78
            // 
            this.Text78 = new Stimulsoft.Report.Components.StiText();
            this.Text78.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 0.6);
            this.Text78.ComponentStyle = "Header3";
            this.Text78.Guid = "f1e3ea1f99584ec18281e6382bb5f268";
            this.Text78.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text78.Name = "Text78";
            this.Text78.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text78__GetValue);
            this.Text78.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text78.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text78.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text78.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text78.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text78.Indicator = null;
            this.Text78.Interaction = null;
            this.Text78.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text78.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text78.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text79
            // 
            this.Text79 = new Stimulsoft.Report.Components.StiText();
            this.Text79.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 0.6);
            this.Text79.ComponentStyle = "Header3";
            this.Text79.Guid = "febb421d6b9f45bfa4e9a71e9a79053a";
            this.Text79.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text79.Name = "Text79";
            this.Text79.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text79__GetValue);
            this.Text79.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text79.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text79.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text79.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text79.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text79.Indicator = null;
            this.Text79.Interaction = null;
            this.Text79.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text79.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text79.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageHeaderBand2.Interaction = null;
            // 
            // DataBand5
            // 
            this.DataBand5 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.8, 19, 8.4);
            this.DataBand5.ComponentStyle = "Data1";
            this.DataBand5.CountData = 1;
            this.DataBand5.Guid = "4253746f63354780a70c6b38a2163c61";
            this.DataBand5.Name = "DataBand5";
            this.DataBand5.Sort = new System.String[0];
            this.DataBand5.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text54
            // 
            this.Text54 = new Stimulsoft.Report.Components.StiText();
            this.Text54.CanGrow = true;
            this.Text54.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.6);
            this.Text54.ComponentStyle = "Header4";
            this.Text54.Guid = "1fbea62956a44f048c9eed8393d1ef5d";
            this.Text54.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text54.Name = "Text54";
            this.Text54.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text54__GetValue);
            this.Text54.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text54.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text54.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text54.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text54.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text54.Indicator = null;
            this.Text54.Interaction = null;
            this.Text54.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text54.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text54.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text55
            // 
            this.Text55 = new Stimulsoft.Report.Components.StiText();
            this.Text55.CanGrow = true;
            this.Text55.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 8.4);
            this.Text55.ComponentStyle = "Data1";
            this.Text55.GrowToHeight = true;
            this.Text55.Guid = "97f210ebeb8c432f9ac2ffe415a0ccef";
            this.Text55.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text55.Name = "Text55";
            this.Text55.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text55__GetValue);
            this.Text55.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text55.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text55.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text55.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text55.Font = new System.Drawing.Font("Arial", 9F);
            this.Text55.Indicator = null;
            this.Text55.Interaction = null;
            this.Text55.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text55.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text55.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode20
            // 
            this.BarCode20 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode20.BackColor = System.Drawing.Color.Transparent;
            this.BarCode20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.6);
            this.BarCode20.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode20__GetBarCode);
            this.BarCode20.ForeColor = System.Drawing.Color.Black;
            this.BarCode20.Guid = "5547daed85024d67ada2ef17dc0e6172";
            this.BarCode20.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode20.Name = "BarCode20";
            this.BarCode20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode20.BarCodeType = new Stimulsoft.Report.BarCodes.StiEAN8BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, true);
            this.BarCode20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode20.Interaction = null;
            // 
            // BarCode46
            // 
            this.BarCode46 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode46.BackColor = System.Drawing.Color.Transparent;
            this.BarCode46.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 2.6, 6, 3);
            this.BarCode46.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode46__GetBarCode);
            this.BarCode46.ForeColor = System.Drawing.Color.Black;
            this.BarCode46.Guid = "8a7f7caf126c4d62ac655fa4f388cff8";
            this.BarCode46.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode46.Name = "BarCode46";
            this.BarCode46.BarCodeType = new Stimulsoft.Report.BarCodes.StiEAN8BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.TwoDigit, "12", true);
            this.BarCode46.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode46.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode46.Interaction = null;
            // 
            // BarCode47
            // 
            this.BarCode47 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode47.BackColor = System.Drawing.Color.Transparent;
            this.BarCode47.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 5.6, 6, 2.8);
            this.BarCode47.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode47__GetBarCode);
            this.BarCode47.ForeColor = System.Drawing.Color.Black;
            this.BarCode47.Guid = "7e99162526324265b4e322c31f8d0ddf";
            this.BarCode47.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode47.Name = "BarCode47";
            this.BarCode47.BarCodeType = new Stimulsoft.Report.BarCodes.StiEAN8BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.TwoDigit, "12", true);
            this.BarCode47.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode47.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode47.Interaction = null;
            // 
            // Text60
            // 
            this.Text60 = new Stimulsoft.Report.Components.StiText();
            this.Text60.CanGrow = true;
            this.Text60.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 2.6, 4, 3);
            this.Text60.ComponentStyle = "Header4";
            this.Text60.Guid = "03c61f7fc5134532a7e5fbd3ffc8cb7a";
            this.Text60.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text60.Name = "Text60";
            this.Text60.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text60__GetValue);
            this.Text60.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text60.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text60.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text60.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text60.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text60.Indicator = null;
            this.Text60.Interaction = null;
            this.Text60.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text60.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text60.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text61
            // 
            this.Text61 = new Stimulsoft.Report.Components.StiText();
            this.Text61.CanGrow = true;
            this.Text61.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5.6, 4, 2.8);
            this.Text61.ComponentStyle = "Header4";
            this.Text61.Guid = "92a9f27353c54b2b915fffe6f11223c2";
            this.Text61.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text61.Name = "Text61";
            this.Text61.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text61__GetValue);
            this.Text61.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text61.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text61.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text61.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text61.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text61.Indicator = null;
            this.Text61.Interaction = null;
            this.Text61.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text61.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text61.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand5.DataRelationName = null;
            this.DataBand5.Interaction = null;
            this.DataBand5.MasterComponent = null;
            // 
            // DataBand6
            // 
            this.DataBand6 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 11, 19, 9);
            this.DataBand6.ComponentStyle = "Data2";
            this.DataBand6.CountData = 1;
            this.DataBand6.Guid = "2bccc6a71b7d4b28872709885f751e06";
            this.DataBand6.Name = "DataBand6";
            this.DataBand6.Sort = new System.String[0];
            this.DataBand6.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text21
            // 
            this.Text21 = new Stimulsoft.Report.Components.StiText();
            this.Text21.CanGrow = true;
            this.Text21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3);
            this.Text21.ComponentStyle = "Header4";
            this.Text21.Guid = "a900fe349f0345b6bcbf68ace0b46abe";
            this.Text21.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text21.Name = "Text21";
            this.Text21.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text21__GetValue);
            this.Text21.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text21.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text21.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text21.Indicator = null;
            this.Text21.Interaction = null;
            this.Text21.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text21.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text21.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text22
            // 
            this.Text22 = new Stimulsoft.Report.Components.StiText();
            this.Text22.CanGrow = true;
            this.Text22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 9);
            this.Text22.ComponentStyle = "Data1";
            this.Text22.GrowToHeight = true;
            this.Text22.Guid = "032bd8257ccb415bb66ed85a491c53a3";
            this.Text22.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text22.Name = "Text22";
            this.Text22.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text22__GetValue);
            this.Text22.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text22.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text22.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text22.Font = new System.Drawing.Font("Arial", 9F);
            this.Text22.Indicator = null;
            this.Text22.Interaction = null;
            this.Text22.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text22.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text22.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode21
            // 
            this.BarCode21 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode21.BackColor = System.Drawing.Color.Transparent;
            this.BarCode21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3);
            this.BarCode21.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode21__GetBarCode);
            this.BarCode21.ForeColor = System.Drawing.Color.Black;
            this.BarCode21.Guid = "e0f52faeb61446f189940403d1d5c814";
            this.BarCode21.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode21.Name = "BarCode21";
            this.BarCode21.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode21.BarCodeType = new Stimulsoft.Report.BarCodes.StiEAN13BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, true);
            this.BarCode21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode21.Interaction = null;
            // 
            // BarCode48
            // 
            this.BarCode48 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode48.BackColor = System.Drawing.Color.Transparent;
            this.BarCode48.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 3, 6, 3);
            this.BarCode48.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode48__GetBarCode);
            this.BarCode48.ForeColor = System.Drawing.Color.Black;
            this.BarCode48.Guid = "02155bc4c50d46768125e04c267acc8b";
            this.BarCode48.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode48.Name = "BarCode48";
            this.BarCode48.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode48.BarCodeType = new Stimulsoft.Report.BarCodes.StiUpcABarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.TwoDigit, "12", false);
            this.BarCode48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode48.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode48.Interaction = null;
            // 
            // BarCode49
            // 
            this.BarCode49 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode49.BackColor = System.Drawing.Color.Transparent;
            this.BarCode49.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 6, 6, 3);
            this.BarCode49.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode49__GetBarCode);
            this.BarCode49.ForeColor = System.Drawing.Color.Black;
            this.BarCode49.Guid = "c978102d0594490a897d21600f9b1b98";
            this.BarCode49.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode49.Name = "BarCode49";
            this.BarCode49.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode49.BarCodeType = new Stimulsoft.Report.BarCodes.StiEAN13BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.FiveDigit, "12345", true);
            this.InitializeComponent2();
        }
        
        public void InitializeComponent2()
        {
            this.BarCode49.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode49.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode49.Interaction = null;
            // 
            // Text62
            // 
            this.Text62 = new Stimulsoft.Report.Components.StiText();
            this.Text62.CanGrow = true;
            this.Text62.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3, 4, 3);
            this.Text62.ComponentStyle = "Header4";
            this.Text62.Guid = "e8448461ffc84f729111d4237a7556c0";
            this.Text62.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text62.Name = "Text62";
            this.Text62.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text62__GetValue);
            this.Text62.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text62.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text62.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text62.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text62.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text62.Indicator = null;
            this.Text62.Interaction = null;
            this.Text62.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text62.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text62.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text63
            // 
            this.Text63 = new Stimulsoft.Report.Components.StiText();
            this.Text63.CanGrow = true;
            this.Text63.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6, 4, 3);
            this.Text63.ComponentStyle = "Header4";
            this.Text63.Guid = "fa8629563d9f484caaefc694770d0bc3";
            this.Text63.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text63.Name = "Text63";
            this.Text63.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text63__GetValue);
            this.Text63.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text63.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text63.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text63.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text63.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text63.Indicator = null;
            this.Text63.Interaction = null;
            this.Text63.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text63.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text63.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand6.DataRelationName = null;
            this.DataBand6.Interaction = null;
            this.DataBand6.MasterComponent = null;
            // 
            // DataBand12
            // 
            this.DataBand12 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20.8, 19, 2.6);
            this.DataBand12.ComponentStyle = "Data1";
            this.DataBand12.CountData = 1;
            this.DataBand12.EvenStyle = "Data2";
            this.DataBand12.Guid = "7db522d23c8b43668bcdf8c759493fef";
            this.DataBand12.Name = "DataBand12";
            this.DataBand12.Sort = new System.String[0];
            this.DataBand12.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.CanGrow = true;
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.6);
            this.Text10.ComponentStyle = "Header4";
            this.Text10.GrowToHeight = true;
            this.Text10.Guid = "c08c51f796ac4ef895776ffac9a64975";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text41
            // 
            this.Text41 = new Stimulsoft.Report.Components.StiText();
            this.Text41.CanGrow = true;
            this.Text41.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.6);
            this.Text41.ComponentStyle = "Data1";
            this.Text41.GrowToHeight = true;
            this.Text41.Guid = "3eaa446dd3b34135b1a2441ac5dfdc4c";
            this.Text41.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text41.Name = "Text41";
            this.Text41.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text41__GetValue);
            this.Text41.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text41.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text41.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text41.Font = new System.Drawing.Font("Arial", 9F);
            this.Text41.Indicator = null;
            this.Text41.Interaction = null;
            this.Text41.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text41.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text41.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode7
            // 
            this.BarCode7 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode7.BackColor = System.Drawing.Color.Transparent;
            this.BarCode7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.6);
            this.BarCode7.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode7__GetBarCode);
            this.BarCode7.ForeColor = System.Drawing.Color.Black;
            this.BarCode7.Guid = "6245e551c5124832b7664b053f19f041";
            this.BarCode7.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode7.Name = "BarCode7";
            this.BarCode7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode7.BarCodeType = new Stimulsoft.Report.BarCodes.StiJan8BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, true);
            this.BarCode7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode7.Interaction = null;
            this.DataBand12.DataRelationName = null;
            this.DataBand12.Interaction = null;
            this.DataBand12.MasterComponent = null;
            // 
            // DataBand13
            // 
            this.DataBand13 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 24.2, 19, 3.2);
            this.DataBand13.ComponentStyle = "Data2";
            this.DataBand13.CountData = 1;
            this.DataBand13.Guid = "046e34997e4a4f02973684cb123dcbcb";
            this.DataBand13.Name = "DataBand13";
            this.DataBand13.Sort = new System.String[0];
            this.DataBand13.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text30
            // 
            this.Text30 = new Stimulsoft.Report.Components.StiText();
            this.Text30.CanGrow = true;
            this.Text30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.2);
            this.Text30.ComponentStyle = "Header4";
            this.Text30.GrowToHeight = true;
            this.Text30.Guid = "7121b6bd9788441a8fc97202519ce82d";
            this.Text30.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text30.Name = "Text30";
            this.Text30.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text30__GetValue);
            this.Text30.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text30.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text30.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text30.Indicator = null;
            this.Text30.Interaction = null;
            this.Text30.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text30.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text30.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text42
            // 
            this.Text42 = new Stimulsoft.Report.Components.StiText();
            this.Text42.CanGrow = true;
            this.Text42.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3.2);
            this.Text42.ComponentStyle = "Data1";
            this.Text42.GrowToHeight = true;
            this.Text42.Guid = "c726da08d8ab45149c89f7c2129ed46d";
            this.Text42.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text42.Name = "Text42";
            this.Text42.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text42__GetValue);
            this.Text42.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text42.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text42.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text42.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text42.Font = new System.Drawing.Font("Arial", 9F);
            this.Text42.Indicator = null;
            this.Text42.Interaction = null;
            this.Text42.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text42.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text42.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode11
            // 
            this.BarCode11 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode11.BackColor = System.Drawing.Color.Transparent;
            this.BarCode11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.2);
            this.BarCode11.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode11__GetBarCode);
            this.BarCode11.ForeColor = System.Drawing.Color.Black;
            this.BarCode11.Guid = "52be6237ddd64cc686749b7397cc3e2f";
            this.BarCode11.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode11.Name = "BarCode11";
            this.BarCode11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode11.BarCodeType = new Stimulsoft.Report.BarCodes.StiJan13BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, true);
            this.BarCode11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode11.Interaction = null;
            this.DataBand13.DataRelationName = null;
            this.DataBand13.Interaction = null;
            this.DataBand13.MasterComponent = null;
            this.Page2.ExcelSheetValue = null;
            this.Page2.Interaction = null;
            this.Page2.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page2_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page2_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page2_Watermark.Image = null;
            this.Page2_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            // 
            // Page3
            // 
            this.Page3 = new Stimulsoft.Report.Components.StiPage();
            this.Page3.Guid = "3543ac03d5b34b1eb8ff0a585c6dfc02";
            this.Page3.Name = "Page3";
            this.Page3.PageHeight = 29.7;
            this.Page3.PageWidth = 21;
            this.Page3.PrintOnPreviousPage = true;
            this.Page3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageHeaderBand3
            // 
            this.PageHeaderBand3 = new Stimulsoft.Report.Components.StiPageHeaderBand();
            this.PageHeaderBand3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 0.6);
            this.PageHeaderBand3.Guid = "80178ec92dcb45578820672ed1cbc2ae";
            this.PageHeaderBand3.Name = "PageHeaderBand3";
            this.PageHeaderBand3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageHeaderBand3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text80
            // 
            this.Text80 = new Stimulsoft.Report.Components.StiText();
            this.Text80.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 0.6);
            this.Text80.ComponentStyle = "Header3";
            this.Text80.Guid = "243f09e9b489479cb1e07fd171e28f51";
            this.Text80.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text80.Name = "Text80";
            this.Text80.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text80__GetValue);
            this.Text80.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text80.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text80.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text80.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text80.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text80.Indicator = null;
            this.Text80.Interaction = null;
            this.Text80.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text80.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text80.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text81
            // 
            this.Text81 = new Stimulsoft.Report.Components.StiText();
            this.Text81.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 0.6);
            this.Text81.ComponentStyle = "Header3";
            this.Text81.Guid = "7e86664d28b34909ad55912a992dec66";
            this.Text81.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text81.Name = "Text81";
            this.Text81.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text81__GetValue);
            this.Text81.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text81.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text81.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text81.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text81.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text81.Indicator = null;
            this.Text81.Interaction = null;
            this.Text81.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text81.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text81.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text82
            // 
            this.Text82 = new Stimulsoft.Report.Components.StiText();
            this.Text82.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 0.6);
            this.Text82.ComponentStyle = "Header3";
            this.Text82.Guid = "62e678191b994069a50b4c0617f6530f";
            this.Text82.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text82.Name = "Text82";
            this.Text82.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text82__GetValue);
            this.Text82.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text82.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text82.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text82.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text82.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text82.Indicator = null;
            this.Text82.Interaction = null;
            this.Text82.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text82.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text82.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageHeaderBand3.Interaction = null;
            // 
            // DataBand7
            // 
            this.DataBand7 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.8, 19, 10.2);
            this.DataBand7.ComponentStyle = "Data1";
            this.DataBand7.CountData = 1;
            this.DataBand7.EvenStyle = "Data2";
            this.DataBand7.Guid = "e6f079d2f1604692be52b58db7ffabf9";
            this.DataBand7.Name = "DataBand7";
            this.DataBand7.Sort = new System.String[0];
            this.DataBand7.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.CanGrow = true;
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.4);
            this.Text1.ComponentStyle = "Header4";
            this.Text1.Guid = "c8f8f383733d4cd39f6d2b1fab82877e";
            this.Text1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.CanGrow = true;
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 10.2);
            this.Text2.ComponentStyle = "Data1";
            this.Text2.Guid = "d46eebe468d745d5a3f9e3ada5f7375a";
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text2.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("Arial", 9F);
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode1
            // 
            this.BarCode1 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode1.BackColor = System.Drawing.Color.Transparent;
            this.BarCode1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.4);
            this.BarCode1.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode1__GetBarCode);
            this.BarCode1.ForeColor = System.Drawing.Color.Black;
            this.BarCode1.Guid = "7e4f0b68abfc436b880d228f75a69c4b";
            this.BarCode1.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode1.Name = "BarCode1";
            this.BarCode1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode1.BarCodeType = new Stimulsoft.Report.BarCodes.StiUpcABarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, false);
            this.BarCode1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode1.Interaction = null;
            // 
            // BarCode41
            // 
            this.BarCode41 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode41.BackColor = System.Drawing.Color.Transparent;
            this.BarCode41.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 3.4, 6, 3.4);
            this.BarCode41.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode41__GetBarCode);
            this.BarCode41.ForeColor = System.Drawing.Color.Black;
            this.BarCode41.Guid = "4dd0c3afcadd4ae5a7be59246035ce9c";
            this.BarCode41.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode41.Name = "BarCode41";
            this.BarCode41.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode41.BarCodeType = new Stimulsoft.Report.BarCodes.StiUpcABarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.TwoDigit, "12", false);
            this.BarCode41.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode41.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode41.Interaction = null;
            // 
            // BarCode42
            // 
            this.BarCode42 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode42.BackColor = System.Drawing.Color.Transparent;
            this.BarCode42.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 6.8, 6, 3.4);
            this.BarCode42.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode42__GetBarCode);
            this.BarCode42.ForeColor = System.Drawing.Color.Black;
            this.BarCode42.Guid = "9e4f36c0a71b43c8b1883464810ad435";
            this.BarCode42.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode42.Name = "BarCode42";
            this.BarCode42.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode42.BarCodeType = new Stimulsoft.Report.BarCodes.StiUpcABarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.FiveDigit, "12345", false);
            this.BarCode42.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode42.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode42.Interaction = null;
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.CanGrow = true;
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.4, 4, 3.4);
            this.Text13.ComponentStyle = "Header4";
            this.Text13.Guid = "5df92aee14224ba88af7530f20c47567";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.CanGrow = true;
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6.8, 4, 3.4);
            this.Text14.ComponentStyle = "Header4";
            this.Text14.Guid = "8ff97fdcd8f045b68814bd96a4855d47";
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text14.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text14.Indicator = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand7.DataRelationName = null;
            this.DataBand7.Interaction = null;
            this.DataBand7.MasterComponent = null;
            // 
            // DataBand8
            // 
            this.DataBand8 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 12.8, 19, 3);
            this.DataBand8.ComponentStyle = "Data2";
            this.DataBand8.CountData = 1;
            this.DataBand8.EvenStyle = "Data2";
            this.DataBand8.Guid = "056acacbb0124387b2034a336f3b51d3";
            this.DataBand8.Name = "DataBand8";
            this.DataBand8.Sort = new System.String[0];
            this.DataBand8.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text56
            // 
            this.Text56 = new Stimulsoft.Report.Components.StiText();
            this.Text56.CanGrow = true;
            this.Text56.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3);
            this.Text56.ComponentStyle = "Header4";
            this.Text56.GrowToHeight = true;
            this.Text56.Guid = "2aa77f9ebcf246e4b582adab14e60ae0";
            this.Text56.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text56.Name = "Text56";
            this.Text56.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text56__GetValue);
            this.Text56.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text56.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text56.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text56.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text56.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text56.Indicator = null;
            this.Text56.Interaction = null;
            this.Text56.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text56.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text56.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text57
            // 
            this.Text57 = new Stimulsoft.Report.Components.StiText();
            this.Text57.CanGrow = true;
            this.Text57.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3);
            this.Text57.ComponentStyle = "Data1";
            this.Text57.Guid = "bbbc0817a2664555b65ff820e8b8ea6f";
            this.Text57.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text57.Name = "Text57";
            this.Text57.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text57__GetValue);
            this.Text57.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text57.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text57.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text57.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text57.Font = new System.Drawing.Font("Arial", 9F);
            this.Text57.Indicator = null;
            this.Text57.Interaction = null;
            this.Text57.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text57.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text57.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode2
            // 
            this.BarCode2 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode2.BackColor = System.Drawing.Color.Transparent;
            this.BarCode2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3);
            this.BarCode2.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode2__GetBarCode);
            this.BarCode2.ForeColor = System.Drawing.Color.Black;
            this.BarCode2.GrowToHeight = true;
            this.BarCode2.Guid = "31de892b0a6a45d5987aa53d82dd0c5d";
            this.BarCode2.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode2.Name = "BarCode2";
            this.BarCode2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode2.BarCodeType = new Stimulsoft.Report.BarCodes.StiUpcEBarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, false);
            this.BarCode2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode2.Interaction = null;
            this.DataBand8.DataRelationName = null;
            this.DataBand8.Interaction = null;
            this.DataBand8.MasterComponent = null;
            // 
            // DataBand14
            // 
            this.DataBand14 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 16.6, 19, 7.2);
            this.DataBand14.ComponentStyle = "Data1";
            this.DataBand14.CountData = 1;
            this.DataBand14.EvenStyle = "Data2";
            this.DataBand14.Guid = "aa528be8d9c64d1b921b574f808e4f34";
            this.DataBand14.Name = "DataBand14";
            this.DataBand14.Sort = new System.String[0];
            this.DataBand14.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text32
            // 
            this.Text32 = new Stimulsoft.Report.Components.StiText();
            this.Text32.CanGrow = true;
            this.Text32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.4);
            this.Text32.ComponentStyle = "Header4";
            this.Text32.Guid = "d5f6b48397214c279c717ab11bed7dcb";
            this.Text32.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text32.Name = "Text32";
            this.Text32.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text32__GetValue);
            this.Text32.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text32.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text32.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text32.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text32.Indicator = null;
            this.Text32.Interaction = null;
            this.Text32.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text32.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text32.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text43
            // 
            this.Text43 = new Stimulsoft.Report.Components.StiText();
            this.Text43.CanGrow = true;
            this.Text43.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 7.2);
            this.Text43.ComponentStyle = "Data1";
            this.Text43.Guid = "9a5f4d3722844836a6e486e8e94d2db1";
            this.Text43.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text43.Name = "Text43";
            this.Text43.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text43__GetValue);
            this.Text43.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text43.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text43.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text43.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text43.Font = new System.Drawing.Font("Arial", 9F);
            this.Text43.Indicator = null;
            this.Text43.Interaction = null;
            this.Text43.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text43.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text43.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text64
            // 
            this.Text64 = new Stimulsoft.Report.Components.StiText();
            this.Text64.CanGrow = true;
            this.Text64.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 2.4, 4, 2.4);
            this.Text64.ComponentStyle = "Header4";
            this.Text64.Guid = "ba2666724b04441994d16d75d1d4863b";
            this.Text64.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text64.Name = "Text64";
            this.Text64.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text64__GetValue);
            this.Text64.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text64.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text64.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text64.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text64.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text64.Indicator = null;
            this.Text64.Interaction = null;
            this.Text64.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text64.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text64.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text65
            // 
            this.Text65 = new Stimulsoft.Report.Components.StiText();
            this.Text65.CanGrow = true;
            this.Text65.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.8, 4, 2.4);
            this.Text65.ComponentStyle = "Header4";
            this.Text65.Guid = "a0d27d6c755b42e4a465a00970989a56";
            this.Text65.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text65.Name = "Text65";
            this.Text65.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text65__GetValue);
            this.Text65.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text65.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text65.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text65.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text65.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text65.Indicator = null;
            this.Text65.Interaction = null;
            this.Text65.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text65.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text65.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode29
            // 
            this.BarCode29 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode29.BackColor = System.Drawing.Color.Transparent;
            this.BarCode29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.4);
            this.BarCode29.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode29__GetBarCode);
            this.BarCode29.ForeColor = System.Drawing.Color.Black;
            this.BarCode29.Guid = "7eebc0dec0234151a956426b49b5a62a";
            this.BarCode29.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode29.Name = "BarCode29";
            this.BarCode29.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode29.BarCodeType = new Stimulsoft.Report.BarCodes.StiCode128aBarCodeType(13F, 1F);
            this.BarCode29.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode29.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode29.Interaction = null;
            // 
            // BarCode31
            // 
            this.BarCode31 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode31.BackColor = System.Drawing.Color.Transparent;
            this.BarCode31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 2.4, 6, 2.4);
            this.BarCode31.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode31__GetBarCode);
            this.BarCode31.ForeColor = System.Drawing.Color.Black;
            this.BarCode31.Guid = "66f6262dcb694a36a4861a2d58bd5995";
            this.BarCode31.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode31.Name = "BarCode31";
            this.BarCode31.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode31.BarCodeType = new Stimulsoft.Report.BarCodes.StiCode128bBarCodeType(13F, 1F);
            this.BarCode31.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode31.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode31.Interaction = null;
            // 
            // BarCode38
            // 
            this.BarCode38 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode38.BackColor = System.Drawing.Color.Transparent;
            this.BarCode38.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 4.8, 6, 2.4);
            this.BarCode38.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode38__GetBarCode);
            this.BarCode38.ForeColor = System.Drawing.Color.Black;
            this.BarCode38.Guid = "cb9af0e6715a410ea8db64fc69a3493a";
            this.BarCode38.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode38.Name = "BarCode38";
            this.BarCode38.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode38.BarCodeType = new Stimulsoft.Report.BarCodes.StiCode128cBarCodeType(13F, 1F);
            this.BarCode38.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode38.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode38.Interaction = null;
            this.DataBand14.DataRelationName = null;
            this.DataBand14.Interaction = null;
            this.DataBand14.MasterComponent = null;
            this.Page3.ExcelSheetValue = null;
            this.Page3.Interaction = null;
            this.Page3.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page3_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page3_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page3_Watermark.Image = null;
            this.Page3_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            // 
            // Page4
            // 
            this.Page4 = new Stimulsoft.Report.Components.StiPage();
            this.Page4.Guid = "72e4353ebf454f70b5e98d54ba075891";
            this.Page4.Name = "Page4";
            this.Page4.PageHeight = 29.7;
            this.Page4.PageWidth = 21;
            this.Page4.PrintOnPreviousPage = true;
            this.Page4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageHeaderBand4
            // 
            this.PageHeaderBand4 = new Stimulsoft.Report.Components.StiPageHeaderBand();
            this.PageHeaderBand4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 0.6);
            this.PageHeaderBand4.Guid = "ae724dbebc244ff2bc4919770e63af1c";
            this.PageHeaderBand4.Name = "PageHeaderBand4";
            this.PageHeaderBand4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageHeaderBand4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text83
            // 
            this.Text83 = new Stimulsoft.Report.Components.StiText();
            this.Text83.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 0.6);
            this.Text83.ComponentStyle = "Header3";
            this.Text83.Guid = "c6de4550896c44f88ab91db65eca3af5";
            this.Text83.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text83.Name = "Text83";
            this.Text83.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text83__GetValue);
            this.Text83.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text83.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text83.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text83.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text83.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text83.Indicator = null;
            this.Text83.Interaction = null;
            this.Text83.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text83.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text83.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text84
            // 
            this.Text84 = new Stimulsoft.Report.Components.StiText();
            this.Text84.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 0.6);
            this.Text84.ComponentStyle = "Header3";
            this.Text84.Guid = "a6b2863efecc42238b1bb51f12846e17";
            this.Text84.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text84.Name = "Text84";
            this.Text84.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text84__GetValue);
            this.Text84.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text84.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text84.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text84.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text84.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text84.Indicator = null;
            this.Text84.Interaction = null;
            this.Text84.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text84.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text84.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text85
            // 
            this.Text85 = new Stimulsoft.Report.Components.StiText();
            this.Text85.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 0.6);
            this.Text85.ComponentStyle = "Header3";
            this.Text85.Guid = "23c59246b0644bdeb8d47bb1d0fb5fae";
            this.Text85.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text85.Name = "Text85";
            this.Text85.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text85__GetValue);
            this.Text85.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text85.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text85.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text85.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text85.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text85.Indicator = null;
            this.Text85.Interaction = null;
            this.Text85.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text85.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text85.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageHeaderBand4.Interaction = null;
            // 
            // DataBand15
            // 
            this.DataBand15 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.8, 19, 7.2);
            this.DataBand15.ComponentStyle = "Data2";
            this.DataBand15.CountData = 1;
            this.DataBand15.EvenStyle = "Data2";
            this.DataBand15.Guid = "a6e70b2328454843a6d84d27d0805689";
            this.DataBand15.Name = "DataBand15";
            this.DataBand15.Sort = new System.String[0];
            this.DataBand15.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.CanGrow = true;
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.4);
            this.Text3.ComponentStyle = "Header4";
            this.Text3.Guid = "8a81b285eb0049c4abef7c68aa8e41b4";
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.CanGrow = true;
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 7.2);
            this.Text4.ComponentStyle = "Data1";
            this.Text4.Guid = "dc2c63d39edd44a2a6526c7875e8bb3f";
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text4.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("Arial", 9F);
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.CanGrow = true;
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 2.4, 4, 2.4);
            this.Text8.ComponentStyle = "Header4";
            this.Text8.Guid = "dfcda7dff8d64891aa9d76aceeb1ecec";
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text8.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text8.Indicator = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text66
            // 
            this.Text66 = new Stimulsoft.Report.Components.StiText();
            this.Text66.CanGrow = true;
            this.Text66.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.8, 4, 2.4);
            this.Text66.ComponentStyle = "Header4";
            this.Text66.Guid = "64bed1aecc3d41b48a103c19bf4d2367";
            this.Text66.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text66.Name = "Text66";
            this.Text66.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text66__GetValue);
            this.Text66.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text66.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text66.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text66.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text66.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text66.Indicator = null;
            this.Text66.Interaction = null;
            this.Text66.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text66.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text66.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode3
            // 
            this.BarCode3 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode3.BackColor = System.Drawing.Color.Transparent;
            this.BarCode3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.4);
            this.BarCode3.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode3__GetBarCode);
            this.BarCode3.ForeColor = System.Drawing.Color.Black;
            this.BarCode3.Guid = "5ab8017aae684f1c9019ff74a3329bf4";
            this.BarCode3.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode3.Name = "BarCode3";
            this.BarCode3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode3.BarCodeType = new Stimulsoft.Report.BarCodes.StiEAN128aBarCodeType(13F, 1F);
            this.BarCode3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode3.Interaction = null;
            // 
            // BarCode4
            // 
            this.BarCode4 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode4.BackColor = System.Drawing.Color.Transparent;
            this.BarCode4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 2.4, 6, 2.4);
            this.BarCode4.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode4__GetBarCode);
            this.BarCode4.ForeColor = System.Drawing.Color.Black;
            this.BarCode4.Guid = "b664bf2096734f1f9bf618dfebaa01d9";
            this.BarCode4.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode4.Name = "BarCode4";
            this.BarCode4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode4.BarCodeType = new Stimulsoft.Report.BarCodes.StiEAN128bBarCodeType(13F, 1F);
            this.BarCode4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode4.Interaction = null;
            // 
            // BarCode5
            // 
            this.BarCode5 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode5.BackColor = System.Drawing.Color.Transparent;
            this.BarCode5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 4.8, 6, 2.4);
            this.BarCode5.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode5__GetBarCode);
            this.BarCode5.ForeColor = System.Drawing.Color.Black;
            this.BarCode5.Guid = "dd0bb8211c1f4c40914c02aed2045e7c";
            this.BarCode5.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode5.Name = "BarCode5";
            this.BarCode5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode5.BarCodeType = new Stimulsoft.Report.BarCodes.StiEAN128cBarCodeType(13F, 1F);
            this.BarCode5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode5.Interaction = null;
            this.DataBand15.DataRelationName = null;
            this.DataBand15.Interaction = null;
            this.DataBand15.MasterComponent = null;
            // 
            // DataBand16
            // 
            this.DataBand16 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.8, 19, 2.6);
            this.DataBand16.ComponentStyle = "Data1";
            this.DataBand16.CountData = 1;
            this.DataBand16.EvenStyle = "Data2";
            this.DataBand16.Guid = "9238125f22c14ed0b86e5f44aa56bc36";
            this.DataBand16.Name = "DataBand16";
            this.DataBand16.Sort = new System.String[0];
            this.DataBand16.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.CanGrow = true;
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.6);
            this.Text18.ComponentStyle = "Header4";
            this.Text18.GrowToHeight = true;
            this.Text18.Guid = "ec1e46f4a7d74034804dd13cd404142b";
            this.Text18.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text18.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text19
            // 
            this.Text19 = new Stimulsoft.Report.Components.StiText();
            this.Text19.CanGrow = true;
            this.Text19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.6);
            this.Text19.ComponentStyle = "Data1";
            this.Text19.GrowToHeight = true;
            this.Text19.Guid = "6aa7b8d5c72e4cdbb303b3cec8c2eb53";
            this.Text19.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text19.Name = "Text19";
            this.Text19.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text19__GetValue);
            this.Text19.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text19.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text19.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text19.Font = new System.Drawing.Font("Arial", 9F);
            this.Text19.Indicator = null;
            this.Text19.Interaction = null;
            this.Text19.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text19.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text19.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode15
            // 
            this.BarCode15 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode15.BackColor = System.Drawing.Color.Transparent;
            this.BarCode15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.4);
            this.BarCode15.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode15__GetBarCode);
            this.BarCode15.ForeColor = System.Drawing.Color.Black;
            this.BarCode15.GrowToHeight = true;
            this.BarCode15.Guid = "ba27c091963044e29a22fa9a28a5b924";
            this.BarCode15.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode15.Name = "BarCode15";
            this.BarCode15.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode15.BarCodeType = new Stimulsoft.Report.BarCodes.StiCode11BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiCode11CheckSum.Auto);
            this.BarCode15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode15.Interaction = null;
            this.DataBand16.DataRelationName = null;
            this.DataBand16.Interaction = null;
            this.DataBand16.MasterComponent = null;
            // 
            // DataBand17
            // 
            this.DataBand17 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 13.2, 19, 2.4);
            this.DataBand17.ComponentStyle = "Data2";
            this.DataBand17.CountData = 1;
            this.DataBand17.Guid = "603943bb317e43bca41d4a271db0b3d8";
            this.DataBand17.Name = "DataBand17";
            this.DataBand17.Sort = new System.String[0];
            this.DataBand17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.CanGrow = true;
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.4);
            this.Text20.ComponentStyle = "Header4";
            this.Text20.GrowToHeight = true;
            this.Text20.Guid = "965cc19fe91441aa9696b15889f92a53";
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.InitializeComponent3();
        }
        
        public void InitializeComponent3()
        {
            this.Text20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text67
            // 
            this.Text67 = new Stimulsoft.Report.Components.StiText();
            this.Text67.CanGrow = true;
            this.Text67.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.4);
            this.Text67.ComponentStyle = "Data1";
            this.Text67.GrowToHeight = true;
            this.Text67.Guid = "7e04e173295e4500916a8bf46c0d97af";
            this.Text67.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text67.Name = "Text67";
            this.Text67.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text67__GetValue);
            this.Text67.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text67.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text67.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text67.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text67.Font = new System.Drawing.Font("Arial", 9F);
            this.Text67.Indicator = null;
            this.Text67.Interaction = null;
            this.Text67.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text67.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text67.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode16
            // 
            this.BarCode16 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode16.BackColor = System.Drawing.Color.Transparent;
            this.BarCode16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.4);
            this.BarCode16.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode16__GetBarCode);
            this.BarCode16.ForeColor = System.Drawing.Color.Black;
            this.BarCode16.GrowToHeight = true;
            this.BarCode16.Guid = "bf2b06367dbb489ab8f5d636424eb954";
            this.BarCode16.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode16.Name = "BarCode16";
            this.BarCode16.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode16.BarCodeType = new Stimulsoft.Report.BarCodes.StiPharmacodeBarCodeType(20F, 1F);
            this.BarCode16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode16.Interaction = null;
            this.DataBand17.DataRelationName = null;
            this.DataBand17.Interaction = null;
            this.DataBand17.MasterComponent = null;
            // 
            // DataBand18
            // 
            this.DataBand18 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 16.4, 19, 3.2);
            this.DataBand18.ComponentStyle = "Data1";
            this.DataBand18.CountData = 1;
            this.DataBand18.EvenStyle = "Data2";
            this.DataBand18.Guid = "9cb3bccec3ff410d8332e4319be90984";
            this.DataBand18.Name = "DataBand18";
            this.DataBand18.Sort = new System.String[0];
            this.DataBand18.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text35
            // 
            this.Text35 = new Stimulsoft.Report.Components.StiText();
            this.Text35.CanGrow = true;
            this.Text35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.2);
            this.Text35.ComponentStyle = "Header4";
            this.Text35.GrowToHeight = true;
            this.Text35.Guid = "63658c6c5c83453ba23d54e6880325a5";
            this.Text35.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text35.Name = "Text35";
            this.Text35.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text35__GetValue);
            this.Text35.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text35.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text35.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text35.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text35.Indicator = null;
            this.Text35.Interaction = null;
            this.Text35.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text35.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text35.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text36
            // 
            this.Text36 = new Stimulsoft.Report.Components.StiText();
            this.Text36.CanGrow = true;
            this.Text36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3.2);
            this.Text36.ComponentStyle = "Data1";
            this.Text36.GrowToHeight = true;
            this.Text36.Guid = "b075b67e894b418f9e546f2e693ed1f8";
            this.Text36.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text36.Name = "Text36";
            this.Text36.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text36__GetValue);
            this.Text36.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text36.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text36.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text36.Font = new System.Drawing.Font("Arial", 9F);
            this.Text36.Indicator = null;
            this.Text36.Interaction = null;
            this.Text36.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text36.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text36.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode17
            // 
            this.BarCode17 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode17.BackColor = System.Drawing.Color.Transparent;
            this.BarCode17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.2);
            this.BarCode17.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode17__GetBarCode);
            this.BarCode17.ForeColor = System.Drawing.Color.Black;
            this.BarCode17.GrowToHeight = true;
            this.BarCode17.Guid = "5126f78fa9e44a52a8e9bf1fc2b71883";
            this.BarCode17.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode17.Name = "BarCode17";
            this.BarCode17.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode17.BarCodeType = new Stimulsoft.Report.BarCodes.StiIsbn10BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, true);
            this.BarCode17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode17.Interaction = null;
            this.DataBand18.DataRelationName = null;
            this.DataBand18.Interaction = null;
            this.DataBand18.MasterComponent = null;
            // 
            // DataBand19
            // 
            this.DataBand19 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20.4, 19, 3.2);
            this.DataBand19.ComponentStyle = "Data2";
            this.DataBand19.CountData = 1;
            this.DataBand19.Guid = "6f7b50e038d84ca1b01857933f1a52c4";
            this.DataBand19.Name = "DataBand19";
            this.DataBand19.Sort = new System.String[0];
            this.DataBand19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text68
            // 
            this.Text68 = new Stimulsoft.Report.Components.StiText();
            this.Text68.CanGrow = true;
            this.Text68.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.2);
            this.Text68.ComponentStyle = "Header4";
            this.Text68.GrowToHeight = true;
            this.Text68.Guid = "d95cd35090b14da6999281fd6711cb86";
            this.Text68.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text68.Name = "Text68";
            this.Text68.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text68__GetValue);
            this.Text68.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text68.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text68.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text68.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text68.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text68.Indicator = null;
            this.Text68.Interaction = null;
            this.Text68.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text68.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text68.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text69
            // 
            this.Text69 = new Stimulsoft.Report.Components.StiText();
            this.Text69.CanGrow = true;
            this.Text69.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3.2);
            this.Text69.ComponentStyle = "Data1";
            this.Text69.GrowToHeight = true;
            this.Text69.Guid = "a321dcc0515b44c8adeaa438c48b0525";
            this.Text69.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text69.Name = "Text69";
            this.Text69.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text69__GetValue);
            this.Text69.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text69.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text69.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text69.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text69.Font = new System.Drawing.Font("Arial", 9F);
            this.Text69.Indicator = null;
            this.Text69.Interaction = null;
            this.Text69.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text69.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text69.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode34
            // 
            this.BarCode34 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode34.BackColor = System.Drawing.Color.Transparent;
            this.BarCode34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.2);
            this.BarCode34.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode34__GetBarCode);
            this.BarCode34.ForeColor = System.Drawing.Color.Black;
            this.BarCode34.GrowToHeight = true;
            this.BarCode34.Guid = "0cead220ceeb4c2997493c4f3e271f54";
            this.BarCode34.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode34.Name = "BarCode34";
            this.BarCode34.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode34.BarCodeType = new Stimulsoft.Report.BarCodes.StiIsbn13BarCodeType(13F, 1F, Stimulsoft.Report.BarCodes.StiEanSupplementType.None, null, true);
            this.BarCode34.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode34.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode34.Interaction = null;
            this.DataBand19.DataRelationName = null;
            this.DataBand19.Interaction = null;
            this.DataBand19.MasterComponent = null;
            // 
            // DataBand11
            // 
            this.DataBand11 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 24.4, 19, 3);
            this.DataBand11.ComponentStyle = "Data1";
            this.DataBand11.CountData = 1;
            this.DataBand11.Guid = "d4bc985faeb24e52b6cac8bc87e81a99";
            this.DataBand11.Name = "DataBand11";
            this.DataBand11.Sort = new System.String[0];
            this.DataBand11.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text39
            // 
            this.Text39 = new Stimulsoft.Report.Components.StiText();
            this.Text39.CanGrow = true;
            this.Text39.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3);
            this.Text39.ComponentStyle = "Header4";
            this.Text39.GrowToHeight = true;
            this.Text39.Guid = "4a12847c7dfc454dbb94eec32af7f59e";
            this.Text39.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text39.Name = "Text39";
            this.Text39.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text39__GetValue);
            this.Text39.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text39.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text39.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text39.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text39.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text39.Indicator = null;
            this.Text39.Interaction = null;
            this.Text39.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text39.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text39.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text40
            // 
            this.Text40 = new Stimulsoft.Report.Components.StiText();
            this.Text40.CanGrow = true;
            this.Text40.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3);
            this.Text40.ComponentStyle = "Data1";
            this.Text40.Guid = "7d6bdbba2cda4e4284b821739e7bfb5d";
            this.Text40.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text40.Name = "Text40";
            this.Text40.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text40__GetValue);
            this.Text40.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text40.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text40.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text40.Font = new System.Drawing.Font("Arial", 9F);
            this.Text40.Indicator = null;
            this.Text40.Interaction = null;
            this.Text40.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text40.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text40.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode10
            // 
            this.BarCode10 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode10.BackColor = System.Drawing.Color.Transparent;
            this.BarCode10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3);
            this.BarCode10.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode10__GetBarCode);
            this.BarCode10.ForeColor = System.Drawing.Color.Black;
            this.BarCode10.Guid = "ad21e03e59b24735a5e137d5836e7cc6";
            this.BarCode10.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode10.Name = "BarCode10";
            this.BarCode10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode10.BarCodeType = new Stimulsoft.Report.BarCodes.StiCodabarBarCodeType(13F, 1F, 2.2F);
            this.BarCode10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode10.Interaction = null;
            this.DataBand11.DataRelationName = null;
            this.DataBand11.Interaction = null;
            this.DataBand11.MasterComponent = null;
            this.Page4.ExcelSheetValue = null;
            this.Page4.Interaction = null;
            this.Page4.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page4_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page4_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page4_Watermark.Image = null;
            this.Page4_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            // 
            // Page5
            // 
            this.Page5 = new Stimulsoft.Report.Components.StiPage();
            this.Page5.Guid = "16e115c651824fea94f8048a817ce120";
            this.Page5.Name = "Page5";
            this.Page5.PageHeight = 29.7;
            this.Page5.PageWidth = 21;
            this.Page5.PrintOnPreviousPage = true;
            this.Page5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageHeaderBand5
            // 
            this.PageHeaderBand5 = new Stimulsoft.Report.Components.StiPageHeaderBand();
            this.PageHeaderBand5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 0.6);
            this.PageHeaderBand5.Guid = "215256195c674eb38e3c1de31d368e7b";
            this.PageHeaderBand5.Name = "PageHeaderBand5";
            this.PageHeaderBand5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageHeaderBand5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text86
            // 
            this.Text86 = new Stimulsoft.Report.Components.StiText();
            this.Text86.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 0.6);
            this.Text86.ComponentStyle = "Header3";
            this.Text86.Guid = "660321c5d79148cdadfb40aea698db00";
            this.Text86.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text86.Name = "Text86";
            this.Text86.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text86__GetValue);
            this.Text86.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text86.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text86.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text86.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text86.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text86.Indicator = null;
            this.Text86.Interaction = null;
            this.Text86.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text86.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text86.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text87
            // 
            this.Text87 = new Stimulsoft.Report.Components.StiText();
            this.Text87.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 0.6);
            this.Text87.ComponentStyle = "Header3";
            this.Text87.Guid = "78b1574963794112a4096a7cdb17f8c7";
            this.Text87.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text87.Name = "Text87";
            this.Text87.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text87__GetValue);
            this.Text87.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text87.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text87.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text87.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text87.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text87.Indicator = null;
            this.Text87.Interaction = null;
            this.Text87.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text87.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text87.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text88
            // 
            this.Text88 = new Stimulsoft.Report.Components.StiText();
            this.Text88.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 0.6);
            this.Text88.ComponentStyle = "Header3";
            this.Text88.Guid = "4257f3feda25431e92e0cd52e05cacc1";
            this.Text88.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text88.Name = "Text88";
            this.Text88.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text88__GetValue);
            this.Text88.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text88.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text88.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text88.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text88.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text88.Indicator = null;
            this.Text88.Interaction = null;
            this.Text88.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text88.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text88.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageHeaderBand5.Interaction = null;
            // 
            // DataBand21
            // 
            this.DataBand21 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.8, 19, 3.6);
            this.DataBand21.ComponentStyle = "Data2";
            this.DataBand21.CountData = 1;
            this.DataBand21.Guid = "c3bb664e7b37468ebd4ce27608a00440";
            this.DataBand21.Name = "DataBand21";
            this.DataBand21.Sort = new System.String[0];
            this.DataBand21.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.CanGrow = true;
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.6);
            this.Text6.ComponentStyle = "Header4";
            this.Text6.GrowToHeight = true;
            this.Text6.Guid = "3d5a14953cc94b4cb35640b5de36e6c2";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text70
            // 
            this.Text70 = new Stimulsoft.Report.Components.StiText();
            this.Text70.CanGrow = true;
            this.Text70.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3.6);
            this.Text70.ComponentStyle = "Data1";
            this.Text70.GrowToHeight = true;
            this.Text70.Guid = "8d33c320a3954232868c1fbe9e64e64d";
            this.Text70.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text70.Name = "Text70";
            this.Text70.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text70__GetValue);
            this.Text70.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text70.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text70.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text70.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text70.Font = new System.Drawing.Font("Arial", 9F);
            this.Text70.Indicator = null;
            this.Text70.Interaction = null;
            this.Text70.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text70.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text70.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode18
            // 
            this.BarCode18 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode18.BackColor = System.Drawing.Color.Transparent;
            this.BarCode18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.6);
            this.BarCode18.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode18__GetBarCode);
            this.BarCode18.ForeColor = System.Drawing.Color.Black;
            this.BarCode18.GrowToHeight = true;
            this.BarCode18.Guid = "81e76a58284f4f16be1246488c60ced9";
            this.BarCode18.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode18.Name = "BarCode18";
            this.BarCode18.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode18.BarCodeType = new Stimulsoft.Report.BarCodes.StiMsiBarCodeType(8F, 1F, Stimulsoft.Report.BarCodes.StiPlesseyCheckSum.Modulo10, Stimulsoft.Report.BarCodes.StiPlesseyCheckSum.None);
            this.BarCode18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode18.Interaction = null;
            this.DataBand21.DataRelationName = null;
            this.DataBand21.Interaction = null;
            this.DataBand21.MasterComponent = null;
            // 
            // DataBand22
            // 
            this.DataBand22 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6.2, 19, 2.2);
            this.DataBand22.ComponentStyle = "Data1";
            this.DataBand22.CountData = 1;
            this.DataBand22.EvenStyle = "Data2";
            this.DataBand22.Guid = "89719e9da6e344e09ef56569cea95b88";
            this.DataBand22.Name = "DataBand22";
            this.DataBand22.Sort = new System.String[0];
            this.DataBand22.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.CanGrow = true;
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.2);
            this.Text7.ComponentStyle = "Header4";
            this.Text7.GrowToHeight = true;
            this.Text7.Guid = "758dbd235a3d446a93026c429107ffe2";
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text71
            // 
            this.Text71 = new Stimulsoft.Report.Components.StiText();
            this.Text71.CanGrow = true;
            this.Text71.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.2);
            this.Text71.ComponentStyle = "Data1";
            this.Text71.GrowToHeight = true;
            this.Text71.Guid = "0a8b2ab206ba4af99f80de575a855351";
            this.Text71.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text71.Name = "Text71";
            this.Text71.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text71__GetValue);
            this.Text71.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text71.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text71.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text71.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text71.Font = new System.Drawing.Font("Arial", 9F);
            this.Text71.Indicator = null;
            this.Text71.Interaction = null;
            this.Text71.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text71.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text71.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode19
            // 
            this.BarCode19 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode19.BackColor = System.Drawing.Color.Transparent;
            this.BarCode19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.2);
            this.BarCode19.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode19__GetBarCode);
            this.BarCode19.ForeColor = System.Drawing.Color.Black;
            this.BarCode19.GrowToHeight = true;
            this.BarCode19.Guid = "03d393b1ac1c4540902b9e02f17561d4";
            this.BarCode19.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode19.Name = "BarCode19";
            this.BarCode19.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode19.BarCodeType = new Stimulsoft.Report.BarCodes.StiStandard2of5BarCodeType(13F, 1F, 2.2F);
            this.BarCode19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode19.Interaction = null;
            this.DataBand22.DataRelationName = null;
            this.DataBand22.Interaction = null;
            this.DataBand22.MasterComponent = null;
            // 
            // DataBand23
            // 
            this.DataBand23 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.2, 19, 2.2);
            this.DataBand23.ComponentStyle = "Data2";
            this.DataBand23.CountData = 1;
            this.DataBand23.Guid = "dd197f53f8b045a2be488a9d824bb36d";
            this.DataBand23.Name = "DataBand23";
            this.DataBand23.Sort = new System.String[0];
            this.DataBand23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.CanGrow = true;
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.2);
            this.Text5.ComponentStyle = "Header4";
            this.Text5.GrowToHeight = true;
            this.Text5.Guid = "7943804531f140c9bf889f6c7cecf781";
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text72
            // 
            this.Text72 = new Stimulsoft.Report.Components.StiText();
            this.Text72.CanGrow = true;
            this.Text72.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.2);
            this.Text72.ComponentStyle = "Data1";
            this.Text72.GrowToHeight = true;
            this.Text72.Guid = "5944b538ab3b4de29300ab07b29f4286";
            this.Text72.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text72.Name = "Text72";
            this.Text72.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text72__GetValue);
            this.Text72.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text72.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text72.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text72.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text72.Font = new System.Drawing.Font("Arial", 9F);
            this.Text72.Indicator = null;
            this.Text72.Interaction = null;
            this.Text72.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text72.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text72.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode36
            // 
            this.BarCode36 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode36.BackColor = System.Drawing.Color.Transparent;
            this.BarCode36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.2);
            this.BarCode36.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode36__GetBarCode);
            this.BarCode36.ForeColor = System.Drawing.Color.Black;
            this.BarCode36.Guid = "a93c3e0470a04488a571924a5f4b5891";
            this.BarCode36.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode36.Name = "BarCode36";
            this.BarCode36.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode36.BarCodeType = new Stimulsoft.Report.BarCodes.StiInterleaved2of5BarCodeType(13F, 1F, 2.2F);
            this.BarCode36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode36.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode36.Interaction = null;
            this.DataBand23.DataRelationName = null;
            this.DataBand23.Interaction = null;
            this.DataBand23.MasterComponent = null;
            // 
            // DataBand20
            // 
            this.DataBand20 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 12.2, 19, 3.2);
            this.DataBand20.ComponentStyle = "Data1";
            this.DataBand20.CountData = 1;
            this.DataBand20.EvenStyle = "Data2";
            this.DataBand20.Guid = "ae785877419d419fb709527694faff29";
            this.DataBand20.Name = "DataBand20";
            this.DataBand20.Sort = new System.String[0];
            this.DataBand20.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text37
            // 
            this.Text37 = new Stimulsoft.Report.Components.StiText();
            this.Text37.CanGrow = true;
            this.Text37.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.2);
            this.Text37.ComponentStyle = "Header4";
            this.Text37.GrowToHeight = true;
            this.Text37.Guid = "7ef0e0b18ca048379dac503fb0b7875e";
            this.Text37.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text37.Name = "Text37";
            this.Text37.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text37__GetValue);
            this.Text37.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text37.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text37.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text37.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text37.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text37.Indicator = null;
            this.Text37.Interaction = null;
            this.Text37.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text37.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text37.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text38
            // 
            this.Text38 = new Stimulsoft.Report.Components.StiText();
            this.Text38.CanGrow = true;
            this.Text38.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3.2);
            this.Text38.ComponentStyle = "Data1";
            this.Text38.GrowToHeight = true;
            this.Text38.Guid = "19e0c058dc714ce9939f0b14db612bff";
            this.Text38.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text38.Name = "Text38";
            this.Text38.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text38__GetValue);
            this.Text38.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text38.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text38.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text38.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text38.Font = new System.Drawing.Font("Arial", 9F);
            this.Text38.Indicator = null;
            this.Text38.Interaction = null;
            this.Text38.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text38.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text38.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode35
            // 
            this.BarCode35 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode35.BackColor = System.Drawing.Color.Transparent;
            this.BarCode35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.2);
            this.BarCode35.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode35__GetBarCode);
            this.BarCode35.ForeColor = System.Drawing.Color.Black;
            this.BarCode35.Guid = "2759717accb34597b65f9fe8fa287d95";
            this.BarCode35.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode35.Name = "BarCode35";
            this.BarCode35.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode35.BarCodeType = new Stimulsoft.Report.BarCodes.StiPlesseyBarCodeType(8F, 1F, Stimulsoft.Report.BarCodes.StiPlesseyCheckSum.None, Stimulsoft.Report.BarCodes.StiPlesseyCheckSum.None);
            this.BarCode35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode35.Interaction = null;
            this.DataBand20.DataRelationName = null;
            this.DataBand20.Interaction = null;
            this.DataBand20.MasterComponent = null;
            // 
            // DataBand24
            // 
            this.DataBand24 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 16.2, 19, 2.2);
            this.DataBand24.ComponentStyle = "Data2";
            this.DataBand24.CountData = 1;
            this.DataBand24.EvenStyle = "Data2";
            this.DataBand24.Guid = "841f2de519d74cd2b1df5f207a728b8d";
            this.DataBand24.Name = "DataBand24";
            this.DataBand24.Sort = new System.String[0];
            this.DataBand24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.CanGrow = true;
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.2);
            this.Text15.ComponentStyle = "Header4";
            this.Text15.GrowToHeight = true;
            this.Text15.Guid = "f4c758e9496942c8a12f6a6e7ff4385c";
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text15.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text15.Indicator = null;
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text16
            // 
            this.Text16 = new Stimulsoft.Report.Components.StiText();
            this.Text16.CanGrow = true;
            this.Text16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.2);
            this.Text16.ComponentStyle = "Data1";
            this.Text16.GrowToHeight = true;
            this.Text16.Guid = "2b559654f04f444caea0922dd79f06aa";
            this.Text16.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text16.Name = "Text16";
            this.Text16.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text16__GetValue);
            this.Text16.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text16.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text16.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text16.Font = new System.Drawing.Font("Arial", 9F);
            this.Text16.Indicator = null;
            this.Text16.Interaction = null;
            this.Text16.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text16.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text16.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode12
            // 
            this.BarCode12 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode12.BackColor = System.Drawing.Color.Transparent;
            this.BarCode12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.2);
            this.BarCode12.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode12__GetBarCode);
            this.BarCode12.ForeColor = System.Drawing.Color.Black;
            this.BarCode12.GrowToHeight = true;
            this.BarCode12.Guid = "8a98359428d7448e8f017158be20d98d";
            this.BarCode12.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode12.Name = "BarCode12";
            this.BarCode12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode12.BarCodeType = new Stimulsoft.Report.BarCodes.StiPostnetBarCodeType(20F, 1F, 26F);
            this.BarCode12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode12.Interaction = null;
            this.DataBand24.DataRelationName = null;
            this.DataBand24.Interaction = null;
            this.DataBand24.MasterComponent = null;
            // 
            // DataBand25
            // 
            this.DataBand25 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 19.2, 19, 2.2);
            this.DataBand25.ComponentStyle = "Data1";
            this.DataBand25.CountData = 1;
            this.DataBand25.Guid = "e1af02337a9245278f0bbb90b774463c";
            this.DataBand25.Name = "DataBand25";
            this.DataBand25.Sort = new System.String[0];
            this.DataBand25.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text73
            // 
            this.Text73 = new Stimulsoft.Report.Components.StiText();
            this.Text73.CanGrow = true;
            this.Text73.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.2);
            this.Text73.ComponentStyle = "Header4";
            this.Text73.GrowToHeight = true;
            this.Text73.Guid = "f1d51150548e4a7e9fbbee88980bd454";
            this.Text73.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text73.Name = "Text73";
            this.Text73.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text73__GetValue);
            this.Text73.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text73.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text73.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text73.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text73.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text73.Indicator = null;
            this.Text73.Interaction = null;
            this.Text73.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text73.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text73.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text74
            // 
            this.Text74 = new Stimulsoft.Report.Components.StiText();
            this.Text74.CanGrow = true;
            this.Text74.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.2);
            this.Text74.ComponentStyle = "Data1";
            this.Text74.GrowToHeight = true;
            this.Text74.Guid = "aae129812c8f417f89a25892fb8fb235";
            this.Text74.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text74.Name = "Text74";
            this.Text74.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text74__GetValue);
            this.Text74.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text74.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text74.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text74.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text74.Font = new System.Drawing.Font("Arial", 9F);
            this.Text74.Indicator = null;
            this.Text74.Interaction = null;
            this.Text74.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text74.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text74.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode13
            // 
            this.BarCode13 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode13.BackColor = System.Drawing.Color.Transparent;
            this.BarCode13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.2);
            this.BarCode13.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode13__GetBarCode);
            this.BarCode13.ForeColor = System.Drawing.Color.Black;
            this.BarCode13.GrowToHeight = true;
            this.BarCode13.Guid = "82d5b469bdb54e8a9cc0d61f51b08dd2";
            this.BarCode13.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode13.Name = "BarCode13";
            this.BarCode13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode13.BarCodeType = new Stimulsoft.Report.BarCodes.StiAustraliaPost4StateBarCodeType(20F, 1F);
            this.BarCode13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode13.Interaction = null;
            this.DataBand25.DataRelationName = null;
            this.DataBand25.Interaction = null;
            this.DataBand25.MasterComponent = null;
            // 
            // DataBand26
            // 
            this.DataBand26 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 22.2, 19, 1.4);
            this.DataBand26.ComponentStyle = "Data2";
            this.DataBand26.CountData = 1;
            this.DataBand26.EvenStyle = "Data2";
            this.DataBand26.Guid = "69d156a18d0d4ddba07b7aaf9c18da91";
            this.DataBand26.Name = "DataBand26";
            this.DataBand26.Sort = new System.String[0];
            this.DataBand26.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.CanGrow = true;
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 1.4);
            this.Text23.ComponentStyle = "Header4";
            this.Text23.GrowToHeight = true;
            this.Text23.Guid = "095fcd018f0943f488d6d36f169bf4e4";
            this.Text23.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text23.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text28
            // 
            this.Text28 = new Stimulsoft.Report.Components.StiText();
            this.Text28.CanGrow = true;
            this.Text28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 1.4);
            this.Text28.ComponentStyle = "Data1";
            this.Text28.GrowToHeight = true;
            this.Text28.Guid = "325b5bbb22114694918b86103dc8164d";
            this.Text28.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text28.Name = "Text28";
            this.Text28.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text28__GetValue);
            this.Text28.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text28.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text28.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text28.Font = new System.Drawing.Font("Arial", 9F);
            this.Text28.Indicator = null;
            this.Text28.Interaction = null;
            this.Text28.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text28.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text28.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode22
            // 
            this.BarCode22 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode22.BackColor = System.Drawing.Color.Transparent;
            this.BarCode22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 1.4);
            this.BarCode22.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode22__GetBarCode);
            this.BarCode22.ForeColor = System.Drawing.Color.Black;
            this.BarCode22.Guid = "5818f9d2128f42ffae5dfaf429fbe403";
            this.BarCode22.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode22.Name = "BarCode22";
            this.BarCode22.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode22.BarCodeType = new Stimulsoft.Report.BarCodes.StiRoyalMail4StateBarCodeType(20F, 1F, Stimulsoft.Report.BarCodes.StiCheckSum.Yes);
            this.BarCode22.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode22.Interaction = null;
            this.DataBand26.DataRelationName = null;
            this.DataBand26.Interaction = null;
            this.DataBand26.MasterComponent = null;
            // 
            // DataBand27
            // 
            this.DataBand27 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 24.4, 19, 2.2);
            this.DataBand27.ComponentStyle = "Data1";
            this.DataBand27.CountData = 1;
            this.DataBand27.Guid = "7b241e36bfcf43fd96ed1a632bb50ad7";
            this.DataBand27.Name = "DataBand27";
            this.DataBand27.Sort = new System.String[0];
            this.DataBand27.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text31
            // 
            this.Text31 = new Stimulsoft.Report.Components.StiText();
            this.Text31.CanGrow = true;
            this.Text31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.2);
            this.Text31.ComponentStyle = "Header4";
            this.Text31.GrowToHeight = true;
            this.Text31.Guid = "56ab1cde8fa84293bfaa11e2e2625b7c";
            this.Text31.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text31.Name = "Text31";
            this.Text31.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text31__GetValue);
            this.Text31.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text31.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text31.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text31.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text31.Indicator = null;
            this.Text31.Interaction = null;
            this.Text31.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text31.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text31.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text75
            // 
            this.Text75 = new Stimulsoft.Report.Components.StiText();
            this.Text75.CanGrow = true;
            this.Text75.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.2);
            this.Text75.ComponentStyle = "Data1";
            this.Text75.GrowToHeight = true;
            this.Text75.Guid = "0073a05b78e643d4ab7ac8f5de56ace9";
            this.Text75.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text75.Name = "Text75";
            this.Text75.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text75__GetValue);
            this.Text75.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text75.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text75.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text75.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text75.Font = new System.Drawing.Font("Arial", 9F);
            this.Text75.Indicator = null;
            this.Text75.Interaction = null;
            this.Text75.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text75.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text75.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode27
            // 
            this.BarCode27 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode27.BackColor = System.Drawing.Color.Transparent;
            this.BarCode27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.2);
            this.BarCode27.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode27__GetBarCode);
            this.BarCode27.ForeColor = System.Drawing.Color.Black;
            this.BarCode27.GrowToHeight = true;
            this.BarCode27.Guid = "e4eec973a9e5418da36199b68290c943";
            this.BarCode27.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode27.Name = "BarCode27";
            this.BarCode27.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode27.BarCodeType = new Stimulsoft.Report.BarCodes.StiDutchKIXBarCodeType(20F, 1F);
            this.BarCode27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode27.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode27.Interaction = null;
            this.DataBand27.DataRelationName = null;
            this.DataBand27.Interaction = null;
            this.DataBand27.MasterComponent = null;
            this.Page5.ExcelSheetValue = null;
            this.Page5.Interaction = null;
            this.Page5.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page5_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page5_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page5_Watermark.Image = null;
            this.Page5_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            // 
            // Page6
            // 
            this.Page6 = new Stimulsoft.Report.Components.StiPage();
            this.Page6.Guid = "f65f9f514c204fa79ba3cfea5436fbb0";
            this.Page6.Name = "Page6";
            this.Page6.PageHeight = 29.7;
            this.Page6.PageWidth = 21;
            this.Page6.PrintOnPreviousPage = true;
            this.Page6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageHeaderBand6
            // 
            this.PageHeaderBand6 = new Stimulsoft.Report.Components.StiPageHeaderBand();
            this.PageHeaderBand6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 0.6);
            this.PageHeaderBand6.Guid = "d36661fbc8074e12a5c513047072f7b0";
            this.PageHeaderBand6.Name = "PageHeaderBand6";
            this.PageHeaderBand6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageHeaderBand6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            this.InitializeComponent4();
        }
        
        public void InitializeComponent4()
        {
            // Text97
            // 
            this.Text97 = new Stimulsoft.Report.Components.StiText();
            this.Text97.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 0.6);
            this.Text97.ComponentStyle = "Header3";
            this.Text97.Guid = "9553cd1acd2044c194c17b81e68f802a";
            this.Text97.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text97.Name = "Text97";
            this.Text97.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text97__GetValue);
            this.Text97.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text97.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text97.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text97.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text97.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text97.Indicator = null;
            this.Text97.Interaction = null;
            this.Text97.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text97.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text97.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text98
            // 
            this.Text98 = new Stimulsoft.Report.Components.StiText();
            this.Text98.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 0.6);
            this.Text98.ComponentStyle = "Header3";
            this.Text98.Guid = "8bec893ed7f04ae79dd6b5c4bf6afa18";
            this.Text98.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text98.Name = "Text98";
            this.Text98.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text98__GetValue);
            this.Text98.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text98.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text98.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text98.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text98.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text98.Indicator = null;
            this.Text98.Interaction = null;
            this.Text98.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text98.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text98.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text99
            // 
            this.Text99 = new Stimulsoft.Report.Components.StiText();
            this.Text99.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 0.6);
            this.Text99.ComponentStyle = "Header3";
            this.Text99.Guid = "8c7fd4626d8a4a91af277ca4de85d614";
            this.Text99.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text99.Name = "Text99";
            this.Text99.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text99__GetValue);
            this.Text99.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text99.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text99.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text99.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text99.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text99.Indicator = null;
            this.Text99.Interaction = null;
            this.Text99.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text99.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text99.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageHeaderBand6.Interaction = null;
            // 
            // DataBand28
            // 
            this.DataBand28 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.8, 19, 1.8);
            this.DataBand28.ComponentStyle = "Data2";
            this.DataBand28.CountData = 1;
            this.DataBand28.EvenStyle = "Data2";
            this.DataBand28.Guid = "acf88a5c095f4721a4a0b15ce2f36253";
            this.DataBand28.Name = "DataBand28";
            this.DataBand28.Sort = new System.String[0];
            this.DataBand28.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text44
            // 
            this.Text44 = new Stimulsoft.Report.Components.StiText();
            this.Text44.CanGrow = true;
            this.Text44.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 1.8);
            this.Text44.ComponentStyle = "Header4";
            this.Text44.GrowToHeight = true;
            this.Text44.Guid = "46ecb6d582ff4e929486d86800766221";
            this.Text44.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text44.Name = "Text44";
            this.Text44.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text44__GetValue);
            this.Text44.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text44.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text44.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text44.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text44.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text44.Indicator = null;
            this.Text44.Interaction = null;
            this.Text44.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text44.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text44.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text76
            // 
            this.Text76 = new Stimulsoft.Report.Components.StiText();
            this.Text76.CanGrow = true;
            this.Text76.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 1.8);
            this.Text76.ComponentStyle = "Data1";
            this.Text76.GrowToHeight = true;
            this.Text76.Guid = "4052259fb28b4e8db90e1a79558982f4";
            this.Text76.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text76.Name = "Text76";
            this.Text76.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text76__GetValue);
            this.Text76.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text76.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text76.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text76.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text76.Font = new System.Drawing.Font("Arial", 9F);
            this.Text76.Indicator = null;
            this.Text76.Interaction = null;
            this.Text76.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text76.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text76.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode30
            // 
            this.BarCode30 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode30.BackColor = System.Drawing.Color.Transparent;
            this.BarCode30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 1.8);
            this.BarCode30.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode30__GetBarCode);
            this.BarCode30.ForeColor = System.Drawing.Color.Black;
            this.BarCode30.GrowToHeight = true;
            this.BarCode30.Guid = "ff17703a64744368a15e272e872baa5c";
            this.BarCode30.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode30.Name = "BarCode30";
            this.BarCode30.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode30.BarCodeType = new Stimulsoft.Report.BarCodes.StiITF14BarCodeType(10F, 1F, 2.5F, false);
            this.BarCode30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode30.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode30.Interaction = null;
            this.DataBand28.DataRelationName = null;
            this.DataBand28.Interaction = null;
            this.DataBand28.MasterComponent = null;
            // 
            // DataBand29
            // 
            this.DataBand29 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.4, 19, 8);
            this.DataBand29.ComponentStyle = "Data1";
            this.DataBand29.CountData = 1;
            this.DataBand29.EvenStyle = "Data2";
            this.DataBand29.Guid = "0fe8dd58f6e04b16b35a97c76b7f59a6";
            this.DataBand29.Name = "DataBand29";
            this.DataBand29.Sort = new System.String[0];
            this.DataBand29.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text29
            // 
            this.Text29 = new Stimulsoft.Report.Components.StiText();
            this.Text29.CanGrow = true;
            this.Text29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2);
            this.Text29.ComponentStyle = "Header4";
            this.Text29.Guid = "65b777f5ddbe4f588ce82d837230527f";
            this.Text29.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text29.Name = "Text29";
            this.Text29.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text29__GetValue);
            this.Text29.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text29.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text29.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text29.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text29.Indicator = null;
            this.Text29.Interaction = null;
            this.Text29.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text29.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text29.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text89
            // 
            this.Text89 = new Stimulsoft.Report.Components.StiText();
            this.Text89.CanGrow = true;
            this.Text89.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 8);
            this.Text89.ComponentStyle = "Data1";
            this.Text89.Guid = "b2ed825e58ed4b118348fc5b6b049284";
            this.Text89.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text89.Name = "Text89";
            this.Text89.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text89__GetValue);
            this.Text89.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text89.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text89.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text89.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text89.Font = new System.Drawing.Font("Arial", 9F);
            this.Text89.Indicator = null;
            this.Text89.Interaction = null;
            this.Text89.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text89.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text89.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text90
            // 
            this.Text90 = new Stimulsoft.Report.Components.StiText();
            this.Text90.CanGrow = true;
            this.Text90.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 2, 4, 2);
            this.Text90.ComponentStyle = "Header4";
            this.Text90.Guid = "835f48a12f2e45c699b518573292dd47";
            this.Text90.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text90.Name = "Text90";
            this.Text90.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text90__GetValue);
            this.Text90.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text90.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text90.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text90.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text90.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text90.Indicator = null;
            this.Text90.Interaction = null;
            this.Text90.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text90.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text90.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text91
            // 
            this.Text91 = new Stimulsoft.Report.Components.StiText();
            this.Text91.CanGrow = true;
            this.Text91.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4, 4, 2);
            this.Text91.ComponentStyle = "Header4";
            this.Text91.Guid = "c18dc15ef1524f4d86167fb0098a3598";
            this.Text91.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text91.Name = "Text91";
            this.Text91.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text91__GetValue);
            this.Text91.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text91.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text91.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text91.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text91.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text91.Indicator = null;
            this.Text91.Interaction = null;
            this.Text91.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text91.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text91.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode28
            // 
            this.BarCode28 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode28.BackColor = System.Drawing.Color.Transparent;
            this.BarCode28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6, 0, 1.8, 2);
            this.BarCode28.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode28__GetBarCode);
            this.BarCode28.ForeColor = System.Drawing.Color.Black;
            this.BarCode28.Guid = "33cbc93185fb435fae29cc4cb8919f28";
            this.BarCode28.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode28.Name = "BarCode28";
            this.BarCode28.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode28.BarCodeType = new Stimulsoft.Report.BarCodes.StiFIMBarCodeType(31.25F, 1F, false);
            this.BarCode28.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode28.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode28.Interaction = null;
            // 
            // BarCode37
            // 
            this.BarCode37 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode37.BackColor = System.Drawing.Color.Transparent;
            this.BarCode37.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6, 2, 1.8, 2);
            this.BarCode37.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode37__GetBarCode);
            this.BarCode37.ForeColor = System.Drawing.Color.Black;
            this.BarCode37.Guid = "9917aab45260437793d2dd4f94536c35";
            this.BarCode37.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode37.Name = "BarCode37";
            this.BarCode37.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode37.BarCodeType = new Stimulsoft.Report.BarCodes.StiFIMBarCodeType(31.25F, 1F, false);
            this.BarCode37.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode37.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode37.Interaction = null;
            // 
            // BarCode39
            // 
            this.BarCode39 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode39.BackColor = System.Drawing.Color.Transparent;
            this.BarCode39.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6, 4, 1.8, 2);
            this.BarCode39.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode39__GetBarCode);
            this.BarCode39.ForeColor = System.Drawing.Color.Black;
            this.BarCode39.Guid = "5194d51f9cd14918b190ff4f0eda6c09";
            this.BarCode39.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode39.Name = "BarCode39";
            this.BarCode39.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode39.BarCodeType = new Stimulsoft.Report.BarCodes.StiFIMBarCodeType(31.25F, 1F, false);
            this.BarCode39.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode39.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode39.Interaction = null;
            // 
            // BarCode40
            // 
            this.BarCode40 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode40.BackColor = System.Drawing.Color.Transparent;
            this.BarCode40.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6, 6, 1.8, 2);
            this.BarCode40.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode40__GetBarCode);
            this.BarCode40.ForeColor = System.Drawing.Color.Black;
            this.BarCode40.Guid = "921dc2e5c3b34fd98870d46113e285de";
            this.BarCode40.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode40.Name = "BarCode40";
            this.BarCode40.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode40.BarCodeType = new Stimulsoft.Report.BarCodes.StiFIMBarCodeType(31.25F, 1F, false);
            this.BarCode40.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode40.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode40.Interaction = null;
            // 
            // Text92
            // 
            this.Text92 = new Stimulsoft.Report.Components.StiText();
            this.Text92.CanGrow = true;
            this.Text92.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6, 4, 2);
            this.Text92.ComponentStyle = "Header4";
            this.Text92.Guid = "b2403492e0094930a4db1b381eaaf961";
            this.Text92.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text92.Name = "Text92";
            this.Text92.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text92__GetValue);
            this.Text92.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text92.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text92.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text92.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text92.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text92.Indicator = null;
            this.Text92.Interaction = null;
            this.Text92.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text92.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text92.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand29.DataRelationName = null;
            this.DataBand29.Interaction = null;
            this.DataBand29.MasterComponent = null;
            // 
            // DataBand30
            // 
            this.DataBand30 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 13.2, 19, 2.2);
            this.DataBand30.ComponentStyle = "Data2";
            this.DataBand30.CountData = 1;
            this.DataBand30.Guid = "160099c38d2b4cdcab1053180546afa7";
            this.DataBand30.Name = "DataBand30";
            this.DataBand30.Sort = new System.String[0];
            this.DataBand30.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text26
            // 
            this.Text26 = new Stimulsoft.Report.Components.StiText();
            this.Text26.CanGrow = true;
            this.Text26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.2);
            this.Text26.ComponentStyle = "Header4";
            this.Text26.GrowToHeight = true;
            this.Text26.Guid = "dc63235c06bf43e4a92e9a7ca3aa6358";
            this.Text26.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text26.Name = "Text26";
            this.Text26.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text26__GetValue);
            this.Text26.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text26.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text26.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text26.Indicator = null;
            this.Text26.Interaction = null;
            this.Text26.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text26.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text26.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text27
            // 
            this.Text27 = new Stimulsoft.Report.Components.StiText();
            this.Text27.CanGrow = true;
            this.Text27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.2);
            this.Text27.ComponentStyle = "Data1";
            this.Text27.GrowToHeight = true;
            this.Text27.Guid = "e178c89ab6b24c9dbb876054288f09a3";
            this.Text27.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text27.Name = "Text27";
            this.Text27.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text27__GetValue);
            this.Text27.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text27.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text27.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text27.Font = new System.Drawing.Font("Arial", 9F);
            this.Text27.Indicator = null;
            this.Text27.Interaction = null;
            this.Text27.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text27.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text27.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode25
            // 
            this.BarCode25 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode25.BackColor = System.Drawing.Color.Transparent;
            this.BarCode25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.2);
            this.BarCode25.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode25__GetBarCode);
            this.BarCode25.ForeColor = System.Drawing.Color.Black;
            this.BarCode25.GrowToHeight = true;
            this.BarCode25.Guid = "1482768564d046a3930cc1413313cd29";
            this.BarCode25.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode25.Name = "BarCode25";
            this.BarCode25.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode25.BarCodeType = new Stimulsoft.Report.BarCodes.StiDataMatrixBarCodeType(40F, Stimulsoft.Report.BarCodes.StiDataMatrixEncodingType.Ascii, false, Stimulsoft.Report.BarCodes.StiDataMatrixSize.Automatic);
            this.BarCode25.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode25.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode25.Interaction = null;
            this.DataBand30.DataRelationName = null;
            this.DataBand30.Interaction = null;
            this.DataBand30.MasterComponent = null;
            // 
            // DataBand31
            // 
            this.DataBand31 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 16.2, 19, 3.2);
            this.DataBand31.ComponentStyle = "Data1";
            this.DataBand31.CountData = 1;
            this.DataBand31.Guid = "a5dafd06c3df44668daf23cb731eb640";
            this.DataBand31.Name = "DataBand31";
            this.DataBand31.Sort = new System.String[0];
            this.DataBand31.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text33
            // 
            this.Text33 = new Stimulsoft.Report.Components.StiText();
            this.Text33.CanGrow = true;
            this.Text33.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 3.2);
            this.Text33.ComponentStyle = "Header4";
            this.Text33.GrowToHeight = true;
            this.Text33.Guid = "80dfe58c145442a89868ca30d813afe3";
            this.Text33.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text33.Name = "Text33";
            this.Text33.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text33__GetValue);
            this.Text33.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text33.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text33.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text33.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text33.Indicator = null;
            this.Text33.Interaction = null;
            this.Text33.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text33.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text33.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text34
            // 
            this.Text34 = new Stimulsoft.Report.Components.StiText();
            this.Text34.CanGrow = true;
            this.Text34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 3.2);
            this.Text34.ComponentStyle = "Data1";
            this.Text34.GrowToHeight = true;
            this.Text34.Guid = "53933e99fd654449bd06a0697d0bc0bb";
            this.Text34.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text34.Name = "Text34";
            this.Text34.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text34__GetValue);
            this.Text34.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text34.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text34.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text34.Font = new System.Drawing.Font("Arial", 9F);
            this.Text34.Indicator = null;
            this.Text34.Interaction = null;
            this.Text34.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text34.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text34.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode26
            // 
            this.BarCode26 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode26.BackColor = System.Drawing.Color.Transparent;
            this.BarCode26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 3.2);
            this.BarCode26.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode26__GetBarCode);
            this.BarCode26.ForeColor = System.Drawing.Color.Black;
            this.BarCode26.Guid = "1e0d2d7e06244e298c75dae34a31e07e";
            this.BarCode26.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode26.Name = "BarCode26";
            this.BarCode26.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode26.BarCodeType = new Stimulsoft.Report.BarCodes.StiPdf417BarCodeType(25F, Stimulsoft.Report.BarCodes.StiPdf417EncodingMode.Text, Stimulsoft.Report.BarCodes.StiPdf417ErrorsCorrectionLevel.Automatic, 5, 3, true, true, 1F, 3);
            this.BarCode26.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode26.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode26.Interaction = null;
            this.DataBand31.DataRelationName = null;
            this.DataBand31.Interaction = null;
            this.DataBand31.MasterComponent = null;
            // 
            // DataBand32
            // 
            this.DataBand32 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20.2, 19, 2.8);
            this.DataBand32.ComponentStyle = "Data2";
            this.DataBand32.CountData = 1;
            this.DataBand32.Guid = "71a407f056424b43b41643984c184b3a";
            this.DataBand32.Name = "DataBand32";
            this.DataBand32.Sort = new System.String[0];
            this.DataBand32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            // 
            // Text93
            // 
            this.Text93 = new Stimulsoft.Report.Components.StiText();
            this.Text93.CanGrow = true;
            this.Text93.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4, 2.8);
            this.Text93.ComponentStyle = "Header4";
            this.Text93.GrowToHeight = true;
            this.Text93.Guid = "ee52280596f24865ad72edd8018cd7d0";
            this.Text93.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text93.Name = "Text93";
            this.Text93.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text93__GetValue);
            this.Text93.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text93.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text93.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text93.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text93.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text93.Indicator = null;
            this.Text93.Interaction = null;
            this.Text93.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text93.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text93.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text94
            // 
            this.Text94 = new Stimulsoft.Report.Components.StiText();
            this.Text94.CanGrow = true;
            this.Text94.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 9, 2.8);
            this.Text94.ComponentStyle = "Data1";
            this.Text94.GrowToHeight = true;
            this.Text94.Guid = "1c554f2e9df34d72884ef1e2cdfa4d7f";
            this.Text94.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Width;
            this.Text94.Name = "Text94";
            this.Text94.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text94__GetValue);
            this.Text94.TextQuality = Stimulsoft.Report.Components.StiTextQuality.Wysiwyg;
            this.Text94.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text94.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text94.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text94.Font = new System.Drawing.Font("Arial", 9F);
            this.Text94.Indicator = null;
            this.Text94.Interaction = null;
            this.Text94.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text94.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text94.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // BarCode32
            // 
            this.BarCode32 = new Stimulsoft.Report.BarCodes.StiBarCode();
            this.BarCode32.BackColor = System.Drawing.Color.Transparent;
            this.BarCode32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4, 0, 6, 2.8);
            this.BarCode32.GetBarCode += new Stimulsoft.Report.Events.StiValueEventHandler(this.BarCode32__GetBarCode);
            this.BarCode32.ForeColor = System.Drawing.Color.Black;
            this.BarCode32.Guid = "75cf66cfaddc43ef903b89ba6fb22d54";
            this.BarCode32.HorAlignment = Stimulsoft.Base.Drawing.StiHorAlignment.Center;
            this.BarCode32.Name = "BarCode32";
            this.BarCode32.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.BarCode32.BarCodeType = new Stimulsoft.Report.BarCodes.StiQRCodeBarCodeType(40F, Stimulsoft.Report.BarCodes.StiQRCodeErrorCorrectionLevel.Level1, Stimulsoft.Report.BarCodes.StiQRCodeSize.Automatic);
            this.BarCode32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.BarCode32.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BarCode32.Interaction = null;
            this.DataBand32.DataRelationName = null;
            this.DataBand32.Interaction = null;
            this.DataBand32.MasterComponent = null;
            this.Page6.ExcelSheetValue = null;
            this.Page6.Interaction = null;
            this.Page6.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page6_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page6_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page6_Watermark.Image = null;
            this.Page6_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            // 
            // StyleTitle1
            // 
            this.StyleTitle1 = new Stimulsoft.Report.StiStyle();
            this.StyleTitle1.AllowUseBorderSides = false;
            this.StyleTitle1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleTitle1.Name = "Title1";
            this.StyleTitle1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleTitle1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleTitle1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleTitle1.Font = new System.Drawing.Font("Arial", 19F);
            this.StyleTitle1.Image = null;
            this.StyleTitle1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleTitle2
            // 
            this.StyleTitle2 = new Stimulsoft.Report.StiStyle();
            this.StyleTitle2.AllowUseBorderSides = false;
            this.StyleTitle2.Name = "Title2";
            this.StyleTitle2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleTitle2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleTitle2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleTitle2.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleTitle2.Image = null;
            this.StyleTitle2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            // 
            // StyleHeader1
            // 
            this.StyleHeader1 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader1.AllowUseBorderSides = false;
            this.StyleHeader1.Name = "Header1";
            this.StyleHeader1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleHeader1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleHeader1.Font = new System.Drawing.Font("Arial", 19F);
            this.StyleHeader1.Image = null;
            this.StyleHeader1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleHeader2
            // 
            this.StyleHeader2 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader2.AllowUseBorderSides = false;
            this.StyleHeader2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader2.Name = "Header2";
            this.StyleHeader2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleHeader2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleHeader2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.StyleHeader2.Image = null;
            this.StyleHeader2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleHeader3
            // 
            this.StyleHeader3 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader3.AllowUseBorderSides = false;
            this.StyleHeader3.AllowUseHorAlignment = true;
            this.StyleHeader3.AllowUseVertAlignment = true;
            this.StyleHeader3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader3.Name = "Header3";
            this.StyleHeader3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleHeader3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.StyleHeader3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.StyleHeader3.Image = null;
            this.StyleHeader3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleHeader4
            // 
            this.StyleHeader4 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader4.AllowUseBorderSides = false;
            this.StyleHeader4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader4.Name = "Header4";
            this.StyleHeader4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleHeader4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleHeader4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.StyleHeader4.Image = null;
            this.StyleHeader4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleData1
            // 
            this.StyleData1 = new Stimulsoft.Report.StiStyle();
            this.StyleData1.AllowUseBorderSides = false;
            this.StyleData1.Name = "Data1";
            this.StyleData1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleData1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleData1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleData1.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleData1.Image = null;
            this.StyleData1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
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
            this.StyleData2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleData2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            this.StyleData2.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleData2.Image = null;
            this.StyleData2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            // 
            // StyleData3
            // 
            this.StyleData3 = new Stimulsoft.Report.StiStyle();
            this.StyleData3.AllowUseBorderSides = false;
            this.StyleData3.Name = "Data3";
            this.StyleData3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleData3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleData3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 237, 232));
            this.StyleData3.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleData3.Image = null;
            this.StyleData3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            // 
            // StyleFooter1
            // 
            this.StyleFooter1 = new Stimulsoft.Report.StiStyle();
            this.StyleFooter1.AllowUseBorderSides = false;
            this.StyleFooter1.Name = "Footer1";
            this.StyleFooter1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleFooter1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Top, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleFooter1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleFooter1.Font = new System.Drawing.Font("Arial", 9F);
            this.StyleFooter1.Image = null;
            this.StyleFooter1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            // 
            // StyleFooter2
            // 
            this.StyleFooter2 = new Stimulsoft.Report.StiStyle();
            this.StyleFooter2.AllowUseBorderSides = false;
            this.StyleFooter2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleFooter2.Name = "Footer2";
            this.StyleFooter2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleFooter2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.StyleFooter2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleFooter2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.StyleFooter2.Image = null;
            this.StyleFooter2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            // 
            // StyleCrossTab
            // 
            this.StyleCrossTab = new Stimulsoft.Report.StiCrossTabStyle();
            this.StyleCrossTab.Color = System.Drawing.Color.FromArgb(255, 242, 234, 221);
            this.StyleCrossTab.Name = "CrossTab";
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.ReportTitleBand2.Page = this.Page1;
            this.ReportTitleBand2.Parent = this.Page1;
            this.Text24.Page = this.Page1;
            this.Text24.Parent = this.ReportTitleBand2;
            this.Text25.Page = this.Page1;
            this.Text25.Parent = this.ReportTitleBand2;
            this.Text95.Page = this.Page1;
            this.Text95.Parent = this.ReportTitleBand2;
            this.Text96.Page = this.Page1;
            this.Text96.Parent = this.ReportTitleBand2;
            this.PageHeaderBand1.Page = this.Page1;
            this.PageHeaderBand1.Parent = this.Page1;
            this.Text46.Page = this.Page1;
            this.Text46.Parent = this.PageHeaderBand1;
            this.Text47.Page = this.Page1;
            this.Text47.Parent = this.PageHeaderBand1;
            this.Text48.Page = this.Page1;
            this.Text48.Parent = this.PageHeaderBand1;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.BarCode6.Page = this.Page1;
            this.BarCode6.Parent = this.DataBand1;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.DataBand1;
            this.Text45.Page = this.Page1;
            this.Text45.Parent = this.DataBand1;
            this.DataBand2.Page = this.Page1;
            this.DataBand2.Parent = this.Page1;
            this.Text49.Page = this.Page1;
            this.Text49.Parent = this.DataBand2;
            this.Text50.Page = this.Page1;
            this.Text50.Parent = this.DataBand2;
            this.BarCode44.Page = this.Page1;
            this.BarCode44.Parent = this.DataBand2;
            this.DataBand3.Page = this.Page1;
            this.DataBand3.Parent = this.Page1;
            this.Text51.Page = this.Page1;
            this.Text51.Parent = this.DataBand3;
            this.Text52.Page = this.Page1;
            this.Text52.Parent = this.DataBand3;
            this.BarCode14.Page = this.Page1;
            this.BarCode14.Parent = this.DataBand3;
            this.DataBand4.Page = this.Page1;
            this.DataBand4.Parent = this.Page1;
            this.Text17.Page = this.Page1;
            this.Text17.Parent = this.DataBand4;
            this.Text53.Page = this.Page1;
            this.Text53.Parent = this.DataBand4;
            this.BarCode45.Page = this.Page1;
            this.BarCode45.Parent = this.DataBand4;
            this.DataBand9.Page = this.Page1;
            this.DataBand9.Parent = this.Page1;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.DataBand9;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.DataBand9;
            this.BarCode8.Page = this.Page1;
            this.BarCode8.Parent = this.DataBand9;
            this.DataBand10.Page = this.Page1;
            this.DataBand10.Parent = this.Page1;
            this.Text58.Page = this.Page1;
            this.Text58.Parent = this.DataBand10;
            this.Text59.Page = this.Page1;
            this.Text59.Parent = this.DataBand10;
            this.BarCode9.Page = this.Page1;
            this.BarCode9.Parent = this.DataBand10;
            this.Page2.Report = this;
            this.Page2.Watermark = this.Page2_Watermark;
            this.PageHeaderBand2.Page = this.Page2;
            this.PageHeaderBand2.Parent = this.Page2;
            this.Text77.Page = this.Page2;
            this.Text77.Parent = this.PageHeaderBand2;
            this.Text78.Page = this.Page2;
            this.Text78.Parent = this.PageHeaderBand2;
            this.Text79.Page = this.Page2;
            this.Text79.Parent = this.PageHeaderBand2;
            this.DataBand5.Page = this.Page2;
            this.DataBand5.Parent = this.Page2;
            this.Text54.Page = this.Page2;
            this.Text54.Parent = this.DataBand5;
            this.Text55.Page = this.Page2;
            this.Text55.Parent = this.DataBand5;
            this.BarCode20.Page = this.Page2;
            this.BarCode20.Parent = this.DataBand5;
            this.BarCode46.Page = this.Page2;
            this.BarCode46.Parent = this.DataBand5;
            this.BarCode47.Page = this.Page2;
            this.BarCode47.Parent = this.DataBand5;
            this.Text60.Page = this.Page2;
            this.Text60.Parent = this.DataBand5;
            this.Text61.Page = this.Page2;
            this.Text61.Parent = this.DataBand5;
            this.DataBand6.Page = this.Page2;
            this.DataBand6.Parent = this.Page2;
            this.Text21.Page = this.Page2;
            this.Text21.Parent = this.DataBand6;
            this.Text22.Page = this.Page2;
            this.Text22.Parent = this.DataBand6;
            this.BarCode21.Page = this.Page2;
            this.BarCode21.Parent = this.DataBand6;
            this.BarCode48.Page = this.Page2;
            this.BarCode48.Parent = this.DataBand6;
            this.BarCode49.Page = this.Page2;
            this.BarCode49.Parent = this.DataBand6;
            this.Text62.Page = this.Page2;
            this.Text62.Parent = this.DataBand6;
            this.Text63.Page = this.Page2;
            this.Text63.Parent = this.DataBand6;
            this.DataBand12.Page = this.Page2;
            this.DataBand12.Parent = this.Page2;
            this.Text10.Page = this.Page2;
            this.Text10.Parent = this.DataBand12;
            this.Text41.Page = this.Page2;
            this.Text41.Parent = this.DataBand12;
            this.BarCode7.Page = this.Page2;
            this.BarCode7.Parent = this.DataBand12;
            this.DataBand13.Page = this.Page2;
            this.DataBand13.Parent = this.Page2;
            this.Text30.Page = this.Page2;
            this.Text30.Parent = this.DataBand13;
            this.Text42.Page = this.Page2;
            this.Text42.Parent = this.DataBand13;
            this.BarCode11.Page = this.Page2;
            this.BarCode11.Parent = this.DataBand13;
            this.Page3.Report = this;
            this.Page3.Watermark = this.Page3_Watermark;
            this.PageHeaderBand3.Page = this.Page3;
            this.PageHeaderBand3.Parent = this.Page3;
            this.Text80.Page = this.Page3;
            this.Text80.Parent = this.PageHeaderBand3;
            this.Text81.Page = this.Page3;
            this.Text81.Parent = this.PageHeaderBand3;
            this.Text82.Page = this.Page3;
            this.Text82.Parent = this.PageHeaderBand3;
            this.DataBand7.Page = this.Page3;
            this.DataBand7.Parent = this.Page3;
            this.Text1.Page = this.Page3;
            this.Text1.Parent = this.DataBand7;
            this.Text2.Page = this.Page3;
            this.Text2.Parent = this.DataBand7;
            this.BarCode1.Page = this.Page3;
            this.BarCode1.Parent = this.DataBand7;
            this.BarCode41.Page = this.Page3;
            this.BarCode41.Parent = this.DataBand7;
            this.BarCode42.Page = this.Page3;
            this.BarCode42.Parent = this.DataBand7;
            this.Text13.Page = this.Page3;
            this.Text13.Parent = this.DataBand7;
            this.Text14.Page = this.Page3;
            this.Text14.Parent = this.DataBand7;
            this.DataBand8.Page = this.Page3;
            this.DataBand8.Parent = this.Page3;
            this.Text56.Page = this.Page3;
            this.Text56.Parent = this.DataBand8;
            this.Text57.Page = this.Page3;
            this.Text57.Parent = this.DataBand8;
            this.BarCode2.Page = this.Page3;
            this.BarCode2.Parent = this.DataBand8;
            this.DataBand14.Page = this.Page3;
            this.DataBand14.Parent = this.Page3;
            this.Text32.Page = this.Page3;
            this.Text32.Parent = this.DataBand14;
            this.Text43.Page = this.Page3;
            this.Text43.Parent = this.DataBand14;
            this.Text64.Page = this.Page3;
            this.Text64.Parent = this.DataBand14;
            this.Text65.Page = this.Page3;
            this.Text65.Parent = this.DataBand14;
            this.BarCode29.Page = this.Page3;
            this.BarCode29.Parent = this.DataBand14;
            this.BarCode31.Page = this.Page3;
            this.BarCode31.Parent = this.DataBand14;
            this.BarCode38.Page = this.Page3;
            this.BarCode38.Parent = this.DataBand14;
            this.Page4.Report = this;
            this.Page4.Watermark = this.Page4_Watermark;
            this.PageHeaderBand4.Page = this.Page4;
            this.PageHeaderBand4.Parent = this.Page4;
            this.Text83.Page = this.Page4;
            this.Text83.Parent = this.PageHeaderBand4;
            this.Text84.Page = this.Page4;
            this.Text84.Parent = this.PageHeaderBand4;
            this.Text85.Page = this.Page4;
            this.Text85.Parent = this.PageHeaderBand4;
            this.DataBand15.Page = this.Page4;
            this.DataBand15.Parent = this.Page4;
            this.Text3.Page = this.Page4;
            this.Text3.Parent = this.DataBand15;
            this.Text4.Page = this.Page4;
            this.Text4.Parent = this.DataBand15;
            this.Text8.Page = this.Page4;
            this.Text8.Parent = this.DataBand15;
            this.Text66.Page = this.Page4;
            this.Text66.Parent = this.DataBand15;
            this.BarCode3.Page = this.Page4;
            this.BarCode3.Parent = this.DataBand15;
            this.BarCode4.Page = this.Page4;
            this.BarCode4.Parent = this.DataBand15;
            this.BarCode5.Page = this.Page4;
            this.BarCode5.Parent = this.DataBand15;
            this.DataBand16.Page = this.Page4;
            this.DataBand16.Parent = this.Page4;
            this.Text18.Page = this.Page4;
            this.Text18.Parent = this.DataBand16;
            this.Text19.Page = this.Page4;
            this.Text19.Parent = this.DataBand16;
            this.BarCode15.Page = this.Page4;
            this.BarCode15.Parent = this.DataBand16;
            this.DataBand17.Page = this.Page4;
            this.DataBand17.Parent = this.Page4;
            this.Text20.Page = this.Page4;
            this.Text20.Parent = this.DataBand17;
            this.Text67.Page = this.Page4;
            this.Text67.Parent = this.DataBand17;
            this.BarCode16.Page = this.Page4;
            this.BarCode16.Parent = this.DataBand17;
            this.DataBand18.Page = this.Page4;
            this.DataBand18.Parent = this.Page4;
            this.Text35.Page = this.Page4;
            this.Text35.Parent = this.DataBand18;
            this.Text36.Page = this.Page4;
            this.Text36.Parent = this.DataBand18;
            this.BarCode17.Page = this.Page4;
            this.BarCode17.Parent = this.DataBand18;
            this.DataBand19.Page = this.Page4;
            this.DataBand19.Parent = this.Page4;
            this.Text68.Page = this.Page4;
            this.Text68.Parent = this.DataBand19;
            this.Text69.Page = this.Page4;
            this.Text69.Parent = this.DataBand19;
            this.BarCode34.Page = this.Page4;
            this.BarCode34.Parent = this.DataBand19;
            this.DataBand11.Page = this.Page4;
            this.DataBand11.Parent = this.Page4;
            this.Text39.Page = this.Page4;
            this.Text39.Parent = this.DataBand11;
            this.Text40.Page = this.Page4;
            this.Text40.Parent = this.DataBand11;
            this.BarCode10.Page = this.Page4;
            this.BarCode10.Parent = this.DataBand11;
            this.Page5.Report = this;
            this.Page5.Watermark = this.Page5_Watermark;
            this.PageHeaderBand5.Page = this.Page5;
            this.PageHeaderBand5.Parent = this.Page5;
            this.Text86.Page = this.Page5;
            this.Text86.Parent = this.PageHeaderBand5;
            this.Text87.Page = this.Page5;
            this.Text87.Parent = this.PageHeaderBand5;
            this.Text88.Page = this.Page5;
            this.Text88.Parent = this.PageHeaderBand5;
            this.DataBand21.Page = this.Page5;
            this.DataBand21.Parent = this.Page5;
            this.Text6.Page = this.Page5;
            this.Text6.Parent = this.DataBand21;
            this.Text70.Page = this.Page5;
            this.Text70.Parent = this.DataBand21;
            this.BarCode18.Page = this.Page5;
            this.BarCode18.Parent = this.DataBand21;
            this.DataBand22.Page = this.Page5;
            this.DataBand22.Parent = this.Page5;
            this.Text7.Page = this.Page5;
            this.Text7.Parent = this.DataBand22;
            this.Text71.Page = this.Page5;
            this.Text71.Parent = this.DataBand22;
            this.BarCode19.Page = this.Page5;
            this.BarCode19.Parent = this.DataBand22;
            this.DataBand23.Page = this.Page5;
            this.DataBand23.Parent = this.Page5;
            this.Text5.Page = this.Page5;
            this.Text5.Parent = this.DataBand23;
            this.Text72.Page = this.Page5;
            this.Text72.Parent = this.DataBand23;
            this.BarCode36.Page = this.Page5;
            this.BarCode36.Parent = this.DataBand23;
            this.DataBand20.Page = this.Page5;
            this.DataBand20.Parent = this.Page5;
            this.Text37.Page = this.Page5;
            this.Text37.Parent = this.DataBand20;
            this.Text38.Page = this.Page5;
            this.Text38.Parent = this.DataBand20;
            this.BarCode35.Page = this.Page5;
            this.BarCode35.Parent = this.DataBand20;
            this.InitializeComponent5();
        }
        
        public void InitializeComponent5()
        {
            this.DataBand24.Page = this.Page5;
            this.DataBand24.Parent = this.Page5;
            this.Text15.Page = this.Page5;
            this.Text15.Parent = this.DataBand24;
            this.Text16.Page = this.Page5;
            this.Text16.Parent = this.DataBand24;
            this.BarCode12.Page = this.Page5;
            this.BarCode12.Parent = this.DataBand24;
            this.DataBand25.Page = this.Page5;
            this.DataBand25.Parent = this.Page5;
            this.Text73.Page = this.Page5;
            this.Text73.Parent = this.DataBand25;
            this.Text74.Page = this.Page5;
            this.Text74.Parent = this.DataBand25;
            this.BarCode13.Page = this.Page5;
            this.BarCode13.Parent = this.DataBand25;
            this.DataBand26.Page = this.Page5;
            this.DataBand26.Parent = this.Page5;
            this.Text23.Page = this.Page5;
            this.Text23.Parent = this.DataBand26;
            this.Text28.Page = this.Page5;
            this.Text28.Parent = this.DataBand26;
            this.BarCode22.Page = this.Page5;
            this.BarCode22.Parent = this.DataBand26;
            this.DataBand27.Page = this.Page5;
            this.DataBand27.Parent = this.Page5;
            this.Text31.Page = this.Page5;
            this.Text31.Parent = this.DataBand27;
            this.Text75.Page = this.Page5;
            this.Text75.Parent = this.DataBand27;
            this.BarCode27.Page = this.Page5;
            this.BarCode27.Parent = this.DataBand27;
            this.Page6.Report = this;
            this.Page6.Watermark = this.Page6_Watermark;
            this.PageHeaderBand6.Page = this.Page6;
            this.PageHeaderBand6.Parent = this.Page6;
            this.Text97.Page = this.Page6;
            this.Text97.Parent = this.PageHeaderBand6;
            this.Text98.Page = this.Page6;
            this.Text98.Parent = this.PageHeaderBand6;
            this.Text99.Page = this.Page6;
            this.Text99.Parent = this.PageHeaderBand6;
            this.DataBand28.Page = this.Page6;
            this.DataBand28.Parent = this.Page6;
            this.Text44.Page = this.Page6;
            this.Text44.Parent = this.DataBand28;
            this.Text76.Page = this.Page6;
            this.Text76.Parent = this.DataBand28;
            this.BarCode30.Page = this.Page6;
            this.BarCode30.Parent = this.DataBand28;
            this.DataBand29.Page = this.Page6;
            this.DataBand29.Parent = this.Page6;
            this.Text29.Page = this.Page6;
            this.Text29.Parent = this.DataBand29;
            this.Text89.Page = this.Page6;
            this.Text89.Parent = this.DataBand29;
            this.Text90.Page = this.Page6;
            this.Text90.Parent = this.DataBand29;
            this.Text91.Page = this.Page6;
            this.Text91.Parent = this.DataBand29;
            this.BarCode28.Page = this.Page6;
            this.BarCode28.Parent = this.DataBand29;
            this.BarCode37.Page = this.Page6;
            this.BarCode37.Parent = this.DataBand29;
            this.BarCode39.Page = this.Page6;
            this.BarCode39.Parent = this.DataBand29;
            this.BarCode40.Page = this.Page6;
            this.BarCode40.Parent = this.DataBand29;
            this.Text92.Page = this.Page6;
            this.Text92.Parent = this.DataBand29;
            this.DataBand30.Page = this.Page6;
            this.DataBand30.Parent = this.Page6;
            this.Text26.Page = this.Page6;
            this.Text26.Parent = this.DataBand30;
            this.Text27.Page = this.Page6;
            this.Text27.Parent = this.DataBand30;
            this.BarCode25.Page = this.Page6;
            this.BarCode25.Parent = this.DataBand30;
            this.DataBand31.Page = this.Page6;
            this.DataBand31.Parent = this.Page6;
            this.Text33.Page = this.Page6;
            this.Text33.Parent = this.DataBand31;
            this.Text34.Page = this.Page6;
            this.Text34.Parent = this.DataBand31;
            this.BarCode26.Page = this.Page6;
            this.BarCode26.Parent = this.DataBand31;
            this.DataBand32.Page = this.Page6;
            this.DataBand32.Parent = this.Page6;
            this.Text93.Page = this.Page6;
            this.Text93.Parent = this.DataBand32;
            this.Text94.Page = this.Page6;
            this.Text94.Parent = this.DataBand32;
            this.BarCode32.Page = this.Page6;
            this.BarCode32.Parent = this.DataBand32;
            // 
            // Add to ReportTitleBand2.Components
            // 
            this.ReportTitleBand2.Components.Clear();
            this.ReportTitleBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text24,
                        this.Text25,
                        this.Text95,
                        this.Text96});
            // 
            // Add to PageHeaderBand1.Components
            // 
            this.PageHeaderBand1.Components.Clear();
            this.PageHeaderBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text46,
                        this.Text47,
                        this.Text48});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.BarCode6,
                        this.Text9,
                        this.Text45});
            // 
            // Add to DataBand2.Components
            // 
            this.DataBand2.Components.Clear();
            this.DataBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text49,
                        this.Text50,
                        this.BarCode44});
            // 
            // Add to DataBand3.Components
            // 
            this.DataBand3.Components.Clear();
            this.DataBand3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text51,
                        this.Text52,
                        this.BarCode14});
            // 
            // Add to DataBand4.Components
            // 
            this.DataBand4.Components.Clear();
            this.DataBand4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text17,
                        this.Text53,
                        this.BarCode45});
            // 
            // Add to DataBand9.Components
            // 
            this.DataBand9.Components.Clear();
            this.DataBand9.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text11,
                        this.Text12,
                        this.BarCode8});
            // 
            // Add to DataBand10.Components
            // 
            this.DataBand10.Components.Clear();
            this.DataBand10.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text58,
                        this.Text59,
                        this.BarCode9});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.ReportTitleBand2,
                        this.PageHeaderBand1,
                        this.DataBand1,
                        this.DataBand2,
                        this.DataBand3,
                        this.DataBand4,
                        this.DataBand9,
                        this.DataBand10});
            // 
            // Add to PageHeaderBand2.Components
            // 
            this.PageHeaderBand2.Components.Clear();
            this.PageHeaderBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text77,
                        this.Text78,
                        this.Text79});
            // 
            // Add to DataBand5.Components
            // 
            this.DataBand5.Components.Clear();
            this.DataBand5.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text54,
                        this.Text55,
                        this.BarCode20,
                        this.BarCode46,
                        this.BarCode47,
                        this.Text60,
                        this.Text61});
            // 
            // Add to DataBand6.Components
            // 
            this.DataBand6.Components.Clear();
            this.DataBand6.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text21,
                        this.Text22,
                        this.BarCode21,
                        this.BarCode48,
                        this.BarCode49,
                        this.Text62,
                        this.Text63});
            // 
            // Add to DataBand12.Components
            // 
            this.DataBand12.Components.Clear();
            this.DataBand12.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text10,
                        this.Text41,
                        this.BarCode7});
            // 
            // Add to DataBand13.Components
            // 
            this.DataBand13.Components.Clear();
            this.DataBand13.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text30,
                        this.Text42,
                        this.BarCode11});
            // 
            // Add to Page2.Components
            // 
            this.Page2.Components.Clear();
            this.Page2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageHeaderBand2,
                        this.DataBand5,
                        this.DataBand6,
                        this.DataBand12,
                        this.DataBand13});
            // 
            // Add to PageHeaderBand3.Components
            // 
            this.PageHeaderBand3.Components.Clear();
            this.PageHeaderBand3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text80,
                        this.Text81,
                        this.Text82});
            // 
            // Add to DataBand7.Components
            // 
            this.DataBand7.Components.Clear();
            this.DataBand7.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text1,
                        this.Text2,
                        this.BarCode1,
                        this.BarCode41,
                        this.BarCode42,
                        this.Text13,
                        this.Text14});
            // 
            // Add to DataBand8.Components
            // 
            this.DataBand8.Components.Clear();
            this.DataBand8.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text56,
                        this.Text57,
                        this.BarCode2});
            // 
            // Add to DataBand14.Components
            // 
            this.DataBand14.Components.Clear();
            this.DataBand14.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text32,
                        this.Text43,
                        this.Text64,
                        this.Text65,
                        this.BarCode29,
                        this.BarCode31,
                        this.BarCode38});
            // 
            // Add to Page3.Components
            // 
            this.Page3.Components.Clear();
            this.Page3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageHeaderBand3,
                        this.DataBand7,
                        this.DataBand8,
                        this.DataBand14});
            // 
            // Add to PageHeaderBand4.Components
            // 
            this.PageHeaderBand4.Components.Clear();
            this.PageHeaderBand4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text83,
                        this.Text84,
                        this.Text85});
            // 
            // Add to DataBand15.Components
            // 
            this.DataBand15.Components.Clear();
            this.DataBand15.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text3,
                        this.Text4,
                        this.Text8,
                        this.Text66,
                        this.BarCode3,
                        this.BarCode4,
                        this.BarCode5});
            // 
            // Add to DataBand16.Components
            // 
            this.DataBand16.Components.Clear();
            this.DataBand16.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text18,
                        this.Text19,
                        this.BarCode15});
            // 
            // Add to DataBand17.Components
            // 
            this.DataBand17.Components.Clear();
            this.DataBand17.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text20,
                        this.Text67,
                        this.BarCode16});
            // 
            // Add to DataBand18.Components
            // 
            this.DataBand18.Components.Clear();
            this.DataBand18.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text35,
                        this.Text36,
                        this.BarCode17});
            // 
            // Add to DataBand19.Components
            // 
            this.DataBand19.Components.Clear();
            this.DataBand19.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text68,
                        this.Text69,
                        this.BarCode34});
            // 
            // Add to DataBand11.Components
            // 
            this.DataBand11.Components.Clear();
            this.DataBand11.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text39,
                        this.Text40,
                        this.BarCode10});
            // 
            // Add to Page4.Components
            // 
            this.Page4.Components.Clear();
            this.Page4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageHeaderBand4,
                        this.DataBand15,
                        this.DataBand16,
                        this.DataBand17,
                        this.DataBand18,
                        this.DataBand19,
                        this.DataBand11});
            // 
            // Add to PageHeaderBand5.Components
            // 
            this.PageHeaderBand5.Components.Clear();
            this.PageHeaderBand5.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text86,
                        this.Text87,
                        this.Text88});
            // 
            // Add to DataBand21.Components
            // 
            this.DataBand21.Components.Clear();
            this.DataBand21.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text6,
                        this.Text70,
                        this.BarCode18});
            // 
            // Add to DataBand22.Components
            // 
            this.DataBand22.Components.Clear();
            this.DataBand22.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text7,
                        this.Text71,
                        this.BarCode19});
            // 
            // Add to DataBand23.Components
            // 
            this.DataBand23.Components.Clear();
            this.DataBand23.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text5,
                        this.Text72,
                        this.BarCode36});
            // 
            // Add to DataBand20.Components
            // 
            this.DataBand20.Components.Clear();
            this.DataBand20.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text37,
                        this.Text38,
                        this.BarCode35});
            // 
            // Add to DataBand24.Components
            // 
            this.DataBand24.Components.Clear();
            this.DataBand24.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text15,
                        this.Text16,
                        this.BarCode12});
            // 
            // Add to DataBand25.Components
            // 
            this.DataBand25.Components.Clear();
            this.DataBand25.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text73,
                        this.Text74,
                        this.BarCode13});
            // 
            // Add to DataBand26.Components
            // 
            this.DataBand26.Components.Clear();
            this.DataBand26.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text23,
                        this.Text28,
                        this.BarCode22});
            // 
            // Add to DataBand27.Components
            // 
            this.DataBand27.Components.Clear();
            this.DataBand27.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text31,
                        this.Text75,
                        this.BarCode27});
            // 
            // Add to Page5.Components
            // 
            this.Page5.Components.Clear();
            this.Page5.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageHeaderBand5,
                        this.DataBand21,
                        this.DataBand22,
                        this.DataBand23,
                        this.DataBand20,
                        this.DataBand24,
                        this.DataBand25,
                        this.DataBand26,
                        this.DataBand27});
            // 
            // Add to PageHeaderBand6.Components
            // 
            this.PageHeaderBand6.Components.Clear();
            this.PageHeaderBand6.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text97,
                        this.Text98,
                        this.Text99});
            // 
            // Add to DataBand28.Components
            // 
            this.DataBand28.Components.Clear();
            this.DataBand28.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text44,
                        this.Text76,
                        this.BarCode30});
            // 
            // Add to DataBand29.Components
            // 
            this.DataBand29.Components.Clear();
            this.DataBand29.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text29,
                        this.Text89,
                        this.Text90,
                        this.Text91,
                        this.BarCode28,
                        this.BarCode37,
                        this.BarCode39,
                        this.BarCode40,
                        this.Text92});
            // 
            // Add to DataBand30.Components
            // 
            this.DataBand30.Components.Clear();
            this.DataBand30.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text26,
                        this.Text27,
                        this.BarCode25});
            // 
            // Add to DataBand31.Components
            // 
            this.DataBand31.Components.Clear();
            this.DataBand31.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text33,
                        this.Text34,
                        this.BarCode26});
            // 
            // Add to DataBand32.Components
            // 
            this.DataBand32.Components.Clear();
            this.DataBand32.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text93,
                        this.Text94,
                        this.BarCode32});
            // 
            // Add to Page6.Components
            // 
            this.Page6.Components.Clear();
            this.Page6.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageHeaderBand6,
                        this.DataBand28,
                        this.DataBand29,
                        this.DataBand30,
                        this.DataBand31,
                        this.DataBand32});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1,
                        this.Page2,
                        this.Page3,
                        this.Page4,
                        this.Page5,
                        this.Page6});
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
                        this.StyleFooter2,
                        this.StyleCrossTab});
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
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Description", "Description", "Description", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Picture", "Picture", "Picture", typeof(byte[]))});
            this.DataSources.Add(this.Categories);
            this.Countries.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountriesID", "CountriesID", "CountriesID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Flag", "Flag", "Flag", typeof(byte[]))});
            this.DataSources.Add(this.Countries);
            this.Customers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactName", "ContactName", "ContactName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactTitle", "ContactTitle", "ContactTitle", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Fax", "Fax", "Fax", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string))});
            this.DataSources.Add(this.Customers);
            this.Employees.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BirthDate", "BirthDate", "BirthDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", "EmployeeID", "EmployeeID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Extension", "Extension", "Extension", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("FirstName", "FirstName", "FirstName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HireDate", "HireDate", "HireDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HomePhone", "HomePhone", "HomePhone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("LastName", "LastName", "LastName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Notes", "Notes", "Notes", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Photo", "Photo", "Photo", typeof(byte[])),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ReportsTo", "ReportsTo", "ReportsTo", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Title", "Title", "Title", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("TitleOfCourtesy", "TitleOfCourtesy", "TitleOfCourtesy", typeof(string))});
            this.DataSources.Add(this.Employees);
            this.Order_Details.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Discount", "Discount", "Discount", typeof(float)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", "OrderID", "OrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Quantity", "Quantity", "Quantity", typeof(short)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal))});
            this.DataSources.Add(this.Order_Details);
            this.Orders.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", "EmployeeID", "EmployeeID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Freight", "Freight", "Freight", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", "OrderID", "OrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("RequiredDate", "RequiredDate", "RequiredDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipAddress", "ShipAddress", "ShipAddress", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCity", "ShipCity", "ShipCity", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCountry", "ShipCountry", "ShipCountry", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipName", "ShipName", "ShipName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShippedDate", "ShippedDate", "ShippedDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipPostalCode", "ShipPostalCode", "ShipPostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipRegion", "ShipRegion", "ShipRegion", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipVia", "ShipVia", "ShipVia", typeof(int))});
            this.DataSources.Add(this.Orders);
            this.Products.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Discontinued", "Discontinued", "Discontinued", typeof(bool)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductName", "ProductName", "ProductName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("QuantityPerUnit", "QuantityPerUnit", "QuantityPerUnit", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ReorderLevel", "ReorderLevel", "ReorderLevel", typeof(short)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsOnOrder", "UnitsOnOrder", "UnitsOnOrder", typeof(short))});
            this.DataSources.Add(this.Products);
            this.Shippers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipperID", "ShipperID", "ShipperID", typeof(int))});
            this.DataSources.Add(this.Shippers);
            this.States.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Capital", "Capital", "Capital", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Name", "Name", "Name", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Population", "Population", "Population", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("USPS", "USPS", "USPS", typeof(string))});
            this.DataSources.Add(this.States);
            this.Suppliers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactName", "ContactName", "ContactName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactTitle", "ContactTitle", "ContactTitle", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Fax", "Fax", "Fax", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HomePage", "HomePage", "HomePage", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int))});
            this.DataSources.Add(this.Suppliers);
        }
        
        #region Relation ParentEmployees
        public class ParentEmployeesRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentEmployeesRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual string Extension
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Extension"], typeof(string), true)));
                }
            }
            
            public virtual string FirstName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["FirstName"], typeof(string), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string HomePhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["HomePhone"], typeof(string), true)));
                }
            }
            
            public virtual string LastName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["LastName"], typeof(string), true)));
                }
            }
            
            public virtual string Notes
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Notes"], typeof(string), true)));
                }
            }
            
            public virtual byte[] Photo
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["Photo"], typeof(byte[]), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual string Title
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Title"], typeof(string), true)));
                }
            }
            
            public virtual string TitleOfCourtesy
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["TitleOfCourtesy"], typeof(string), true)));
                }
            }
            
            public virtual ParentEmployeesRelation ParentEmployees
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
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual bool Discontinued
            {
                get
                {
                    return ((bool)(StiReport.ChangeType(this["Discontinued"], typeof(bool), true)));
                }
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
            
            public virtual string QuantityPerUnit
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
                }
            }
            
            public virtual short ReorderLevel
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["ReorderLevel"], typeof(short), true)));
                }
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
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
            
            public virtual short UnitsOnOrder
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["UnitsOnOrder"], typeof(short), true)));
                }
            }
            
            public virtual ParentCategoriesRelation ParentCategories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("CategoriesProducts"));
                }
            }
            
            public virtual ParentSuppliersRelation ParentSuppliers
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
            
            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }
            
            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
            }
            
            public virtual DateTime RequiredDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["RequiredDate"], typeof(DateTime), true)));
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
            
            public virtual string ShipCountry
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipCountry"], typeof(string), true)));
                }
            }
            
            public virtual string ShipName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipName"], typeof(string), true)));
                }
            }
            
            public virtual DateTime ShippedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ShippedDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string ShipPostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipPostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string ShipRegion
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipRegion"], typeof(string), true)));
                }
            }
            
            public virtual int ShipVia
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipVia"], typeof(int), true)));
                }
            }
            
            public virtual ParentCustomersRelation ParentCustomers
            {
                get
                {
                    return new ParentCustomersRelation(this.GetParentData("CustomersOrders"));
                }
            }
            
            public virtual ParentShippersRelation ParentShippers
            {
                get
                {
                    return new ParentShippersRelation(this.GetParentData("ShippersOrders"));
                }
            }
            
            public virtual ParentEmployeesRelation ParentEmployees
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
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string CustomerID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerID"], typeof(string), true)));
                }
            }
            
            public virtual string Fax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Fax"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
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
            
            public virtual int ShipperID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipperID"], typeof(int), true)));
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
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual string Extension
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Extension"], typeof(string), true)));
                }
            }
            
            public virtual string FirstName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["FirstName"], typeof(string), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string HomePhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["HomePhone"], typeof(string), true)));
                }
            }
            
            public virtual string LastName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["LastName"], typeof(string), true)));
                }
            }
            
            public virtual string Notes
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Notes"], typeof(string), true)));
                }
            }
            
            public virtual byte[] Photo
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["Photo"], typeof(byte[]), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual string Title
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Title"], typeof(string), true)));
                }
            }
            
            public virtual string TitleOfCourtesy
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["TitleOfCourtesy"], typeof(string), true)));
                }
            }
            
            public virtual ParentEmployeesRelation ParentEmployees
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
            
            public virtual byte[] Picture
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["Picture"], typeof(byte[]), true)));
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
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
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
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
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
            
            public virtual byte[] Picture
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["Picture"], typeof(byte[]), true)));
                }
            }
        }
        #endregion DataSource Categories
        
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
            
            public virtual string CountryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CountryName"], typeof(string), true)));
                }
            }
            
            public virtual byte[] Flag
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["Flag"], typeof(byte[]), true)));
                }
            }
        }
        #endregion DataSource Countries
        
        #region DataSource Customers
        public class CustomersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CustomersDataSource() : 
                    base("Demo.Customers", "Customers")
            {
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
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string CustomerID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerID"], typeof(string), true)));
                }
            }
            
            public virtual string Fax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Fax"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
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
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual string Extension
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Extension"], typeof(string), true)));
                }
            }
            
            public virtual string FirstName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["FirstName"], typeof(string), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string HomePhone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["HomePhone"], typeof(string), true)));
                }
            }
            
            public virtual string LastName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["LastName"], typeof(string), true)));
                }
            }
            
            public virtual string Notes
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Notes"], typeof(string), true)));
                }
            }
            
            public virtual byte[] Photo
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["Photo"], typeof(byte[]), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual string Title
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Title"], typeof(string), true)));
                }
            }
            
            public virtual string TitleOfCourtesy
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["TitleOfCourtesy"], typeof(string), true)));
                }
            }
            
            public virtual ParentEmployeesRelation ParentEmployees
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
            
            public virtual float Discount
            {
                get
                {
                    return ((float)(StiReport.ChangeType(this["Discount"], typeof(float), true)));
                }
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
            
            public virtual short Quantity
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["Quantity"], typeof(short), true)));
                }
            }
            
            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }
            
            public virtual ParentProductsRelation ParentProducts
            {
                get
                {
                    return new ParentProductsRelation(this.GetParentData("ProductsOrder_Details"));
                }
            }
            
            public virtual ParentOrdersRelation ParentOrders
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
            
            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }
            
            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
            }
            
            public virtual DateTime RequiredDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["RequiredDate"], typeof(DateTime), true)));
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
            
            public virtual string ShipCountry
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipCountry"], typeof(string), true)));
                }
            }
            
            public virtual string ShipName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipName"], typeof(string), true)));
                }
            }
            
            public virtual DateTime ShippedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ShippedDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string ShipPostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipPostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string ShipRegion
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ShipRegion"], typeof(string), true)));
                }
            }
            
            public virtual int ShipVia
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipVia"], typeof(int), true)));
                }
            }
            
            public virtual ParentCustomersRelation ParentCustomers
            {
                get
                {
                    return new ParentCustomersRelation(this.GetParentData("CustomersOrders"));
                }
            }
            
            public virtual ParentShippersRelation ParentShippers
            {
                get
                {
                    return new ParentShippersRelation(this.GetParentData("ShippersOrders"));
                }
            }
            
            public virtual ParentEmployeesRelation ParentEmployees
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
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual bool Discontinued
            {
                get
                {
                    return ((bool)(StiReport.ChangeType(this["Discontinued"], typeof(bool), true)));
                }
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
            
            public virtual string QuantityPerUnit
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
                }
            }
            
            public virtual short ReorderLevel
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["ReorderLevel"], typeof(short), true)));
                }
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
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
            
            public virtual short UnitsOnOrder
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["UnitsOnOrder"], typeof(short), true)));
                }
            }
            
            public virtual ParentCategoriesRelation ParentCategories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("CategoriesProducts"));
                }
            }
            
            public virtual ParentSuppliersRelation ParentSuppliers
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
            
            public virtual int ShipperID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipperID"], typeof(int), true)));
                }
            }
        }
        #endregion DataSource Shippers
        
        #region DataSource States
        public class StatesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public StatesDataSource() : 
                    base("Demo.States", "States")
            {
            }
            
            public virtual string Capital
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Capital"], typeof(string), true)));
                }
            }
            
            public new virtual string Name
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Name"], typeof(string), true)));
                }
            }
            
            public virtual int Population
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["Population"], typeof(int), true)));
                }
            }
            
            public virtual string USPS
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["USPS"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource States
        
        #region DataSource Suppliers
        public class SuppliersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public SuppliersDataSource() : 
                    base("Demo.Suppliers", "Suppliers")
            {
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
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
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
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
        }
        #endregion DataSource Suppliers
        #endregion StiReport Designer generated code - do not modify
	}
}