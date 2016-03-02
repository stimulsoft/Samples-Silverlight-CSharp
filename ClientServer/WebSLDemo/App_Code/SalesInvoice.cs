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
    public class SalesInvoice : Stimulsoft.Report.StiReport
    {
		public SalesInvoice()
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
        public Stimulsoft.Report.Components.StiPageHeaderBand PageHeaderBand1;
        public Stimulsoft.Report.Components.StiText Text41;
        public Stimulsoft.Report.Components.StiText Text42;
        public Stimulsoft.Report.Components.StiText Text47;
        public Stimulsoft.Report.Components.StiText Text48;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand2;
        public Stimulsoft.Report.Components.StiText Text46;
        public Stimulsoft.Report.Components.StiGroupHeaderBand GroupHeader1;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiText Text19;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Components.StiText Text21;
        public Stimulsoft.Report.Components.StiText Text22;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text24;
        public Stimulsoft.Report.Components.StiText Text25;
        public Stimulsoft.Report.Components.StiText Text26;
        public Stimulsoft.Report.Components.StiText Text27;
        public Stimulsoft.Report.Components.StiText Text28;
        public Stimulsoft.Report.Components.StiText Text29;
        public Stimulsoft.Report.Components.StiText Text30;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text31;
        public Stimulsoft.Report.Components.StiText Text32;
        public Stimulsoft.Report.Components.StiText Text33;
        public Stimulsoft.Report.Components.StiText Text34;
        public Stimulsoft.Report.Components.StiText Text35;
        public Stimulsoft.Report.Components.StiText Text36;
        public Stimulsoft.Report.Components.StiDataBand Data1;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiText Text37;
        public Stimulsoft.Report.Components.StiGroupFooterBand GroupFooterBand1;
        public Stimulsoft.Report.Components.StiText Text38;
        public Stimulsoft.Report.Dictionary.StiSumDecimalFunctionService Text38_Sum;
        public Stimulsoft.Report.Components.StiText Text39;
        public Stimulsoft.Report.Components.StiText Text40;
        public Stimulsoft.Report.Dictionary.StiSumDecimalFunctionService Text40_Sum;
        public Stimulsoft.Report.Components.StiText Text43;
        public Stimulsoft.Report.Components.StiText Text44;
        public Stimulsoft.Report.Components.StiText Text45;
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
        public Stimulsoft.Report.StiCrossTabStyle StyleCrossTab;
        public CategoriesDataSource Categories;
        public CustomersDataSource Customers;
        public EmployeesDataSource Employees;
        public Order_DetailsDataSource Order_Details;
        public OrdersDataSource Orders;
        public ProductsDataSource Products;
        public ShippersDataSource Shippers;
        public SuppliersDataSource Suppliers;
        public CountriesDataSource Countries;
        
        public void Text41__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stimulsoft";
        }
        
        public void Text42__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Sales Invoice";
        }
        
        public void Text47__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text48__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text48.TextFormat.Format(CheckExcelValue(sender, "Date: " + Today.ToString("Y")));
        }
        
        public void Text46__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text46_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }
        
        public void GroupHeader1__GetValue(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = Order_Details.OrderID;
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Product";
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Product Name";
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Quantity";
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Unit Price";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Discount";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "BILL TO";
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.ShipName, true);
        }
        
        public void Text19__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "SHIP TO";
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.Customers.CompanyName, true);
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Order ID";
        }
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Customer ID";
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Sales Person";
        }
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Order Date";
        }
        
        public void Text21__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Requred Date";
        }
        
        public void Text22__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Shipped Date";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Ship Via";
        }
        
        public void Text24__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.OrderID, true);
        }
        
        public void Text25__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.CustomerID, true);
        }
        
        public void Text26__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.Employees.FirstName, true) + " " + ToString(sender, Order_Details.Orders.Employees.LastName, true);
        }
        
        public void Text27__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text27.TextFormat.Format(CheckExcelValue(sender, Order_Details.Orders.OrderDate));
        }
        
        public void Text28__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text28.TextFormat.Format(CheckExcelValue(sender, Order_Details.Orders.RequiredDate));
        }
        
        public void Text29__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text29.TextFormat.Format(CheckExcelValue(sender, Order_Details.Orders.ShippedDate));
        }
        
        public void Text30__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.ShipVia, true);
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.ShipAddress, true);
        }
        
        public void Text31__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.ShipPostalCode, true);
        }
        
        public void Text32__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.ShipCountry, true);
        }
        
        public void Text33__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.Customers.Address, true);
        }
        
        public void Text34__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.Customers.PostalCode, true);
        }
        
        public void Text35__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Orders.Customers.Country, true);
        }
        
        public void Text36__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Extended Price";
        }
        
        public void Data1__GetFilter(object sender, Stimulsoft.Report.Events.StiFilterEventArgs e)
        {
            e.Value = Order_Details.OrderID >= 11073 && Order_Details.OrderID <= 11077;
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.ProductID, true);
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Order_Details.Products.ProductName, true);
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text3.TextFormat.Format(CheckExcelValue(sender, Order_Details.Quantity));
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text4.TextFormat.Format(CheckExcelValue(sender, Order_Details.UnitPrice));
        }
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text5.TextFormat.Format(CheckExcelValue(sender, Order_Details.Discount));
        }
        
        public void Text37__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text37.TextFormat.Format(CheckExcelValue(sender, Order_Details.UnitPrice * Order_Details.Quantity * (1 - (decimal)Order_Details.Discount)));
        }
        
        public void Text38__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(Order_Details.UnitPrice * Order_Details.Quantity * (1 - (decimal)Order_De" +
"tails.Discount))}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text38_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return this.Text38.TextFormat.Format(CheckExcelValue(sender, ((decimal)(StiReport.ChangeType(this.Text38_Sum.GetValue(), typeof(decimal), true)))));
        }
        
        public void Text39__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text39.TextFormat.Format(CheckExcelValue(sender, Order_Details.Orders.Freight));
        }
        
        public void Text40__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{Sum(Order_Details.UnitPrice * Order_Details.Quantity * (1 - (decimal)Order_De" +
"tails.Discount)) + Order_Details.Orders.Freight}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text40_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return ToString(sender, ((decimal)(StiReport.ChangeType(this.Text40_Sum.GetValue(), typeof(decimal), true))) + Order_Details.Orders.Freight, true);
        }
        
        public void Text43__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "SubTotal:";
        }
        
        public void Text44__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Freight:";
        }
        
        public void Text45__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Total:";
        }
        
        public void GroupHeader1__BeginRender(object sender, System.EventArgs e)
        {
            this.Text38_Sum.Init();
            this.Text38.TextValue = "";
            this.Text40_Sum.Init();
            this.Text40.TextValue = "";
        }
        
        public void GroupHeader1__EndRender(object sender, System.EventArgs e)
        {
            this.Text38.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text38_GetValue_End));
            this.Text40.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text40_GetValue_End));
        }
        
        public void GroupHeader1__Rendering(object sender, System.EventArgs e)
        {
            this.Text38_Sum.CalcItem(Order_Details.UnitPrice*Order_Details.Quantity*(1-(decimal)Order_Details.Discount));
            this.Text40_Sum.CalcItem(Order_Details.UnitPrice*Order_Details.Quantity*(1-(decimal)Order_Details.Discount));
        }
        
        public void ReportWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text46.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text46_GetValue_End));
        }
        
        private void InitializeComponent()
        {
            this.Countries = new CountriesDataSource();
            this.Suppliers = new SuppliersDataSource();
            this.Shippers = new ShippersDataSource();
            this.Products = new ProductsDataSource();
            this.Orders = new OrdersDataSource();
            this.Order_Details = new Order_DetailsDataSource();
            this.Employees = new EmployeesDataSource();
            this.Customers = new CustomersDataSource();
            this.Categories = new CategoriesDataSource();
            this.ParentSuppliers = new Stimulsoft.Report.Dictionary.StiDataRelation("SuppliersProducts", "Suppliers", "Suppliers", this.Suppliers, this.Products, new System.String[] {
                        "SupplierID"}, new System.String[] {
                        "SupplierID"});
            this.ParentCategories = new Stimulsoft.Report.Dictionary.StiDataRelation("CategoriesProducts", "Categories", "Categories", this.Categories, this.Products, new System.String[] {
                        "CategoryID"}, new System.String[] {
                        "CategoryID"});
            this.ParentEmployees1 = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesOrders", "Employees", "Employees", this.Employees, this.Orders, new System.String[] {
                        "EmployeeID"}, new System.String[] {
                        "EmployeeID"});
            this.ParentShippers = new Stimulsoft.Report.Dictionary.StiDataRelation("ShippersOrders", "Shippers", "Shippers", this.Shippers, this.Orders, new System.String[] {
                        "ShipperID"}, new System.String[] {
                        "ShipVia"});
            this.ParentCustomers = new Stimulsoft.Report.Dictionary.StiDataRelation("CustomersOrders", "Customers", "Customers", this.Customers, this.Orders, new System.String[] {
                        "CustomerID"}, new System.String[] {
                        "CustomerID"});
            this.ParentOrders = new Stimulsoft.Report.Dictionary.StiDataRelation("OrdersOrder_Details", "Orders", "Orders", this.Orders, this.Order_Details, new System.String[] {
                        "OrderID"}, new System.String[] {
                        "OrderID"});
            this.ParentProducts = new Stimulsoft.Report.Dictionary.StiDataRelation("ProductsOrder_Details", "Products", "Products", this.Products, this.Order_Details, new System.String[] {
                        "ProductID"}, new System.String[] {
                        "ProductID"});
            this.ParentEmployees = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesEmployees", "Employees", "Employees", this.Employees, this.Employees, new System.String[] {
                        "EmployeeID"}, new System.String[] {
                        "ReportsTo"});
            this.NeedsCompiling = false;
            this.Text40_Sum = new Stimulsoft.Report.Dictionary.StiSumDecimalFunctionService();
            this.Text38_Sum = new Stimulsoft.Report.Dictionary.StiSumDecimalFunctionService();
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
            this.ReportAlias = "Sales Invoice";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 4, 4, 11, 8, 43, 992);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "Sales invoice.";
            this.ReportFile = "E:\\002\\SalesInvoice.mrt";
            this.ReportGuid = "55c5aea0f3634fed9bcd1fbed8adfe6a";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.1000";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "366bfdc35bcf48f3aeb38f2b5f58db21";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 29.7;
            this.Page1.PageWidth = 21;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageHeaderBand1
            // 
            this.PageHeaderBand1 = new Stimulsoft.Report.Components.StiPageHeaderBand();
            this.PageHeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 2);
            this.PageHeaderBand1.Name = "PageHeaderBand1";
            this.PageHeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageHeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text41
            // 
            this.Text41 = new Stimulsoft.Report.Components.StiText();
            this.Text41.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(9.4, 0, 9.6, 0.8);
            this.Text41.ComponentStyle = "Title1";
            this.Text41.Guid = "71a5bc7c3e4a48a0a285f52a29f30c58";
            this.Text41.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text41.Name = "Text41";
            this.Text41.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text41__GetValue);
            this.Text41.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text41.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text41.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text41.Font = new System.Drawing.Font("Arial", 19F);
            this.Text41.Indicator = null;
            this.Text41.Interaction = null;
            this.Text41.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text41.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text41.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text42
            // 
            this.Text42 = new Stimulsoft.Report.Components.StiText();
            this.Text42.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 9.4, 0.8);
            this.Text42.ComponentStyle = "Title1";
            this.Text42.Guid = "49666e178d10470088a727abbb4dcb62";
            this.Text42.Name = "Text42";
            this.Text42.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text42__GetValue);
            this.Text42.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text42.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text42.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text42.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text42.Font = new System.Drawing.Font("Arial", 19F);
            this.Text42.Indicator = null;
            this.Text42.Interaction = null;
            this.Text42.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text42.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text42.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text47
            // 
            this.Text47 = new Stimulsoft.Report.Components.StiText();
            this.Text47.CanGrow = true;
            this.Text47.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1, 14.6, 0.8);
            this.Text47.ComponentStyle = "Title2";
            this.Text47.Guid = "84c7a39a741540498d07d26116dbf56d";
            this.Text47.Name = "Text47";
            this.Text47.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text47__GetValue);
            this.Text47.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text47.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text47.Font = new System.Drawing.Font("Arial", 9F);
            this.Text47.Indicator = null;
            this.Text47.Interaction = null;
            this.Text47.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text47.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text47.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text48
            // 
            this.Text48 = new Stimulsoft.Report.Components.StiText();
            this.Text48.CanGrow = true;
            this.Text48.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14.6, 1, 4.4, 0.8);
            this.Text48.ComponentStyle = "Title2";
            this.Text48.Guid = "11700b4f441f45d1ae53d5d79daa7b96";
            this.Text48.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text48.Name = "Text48";
            this.Text48.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text48__GetValue);
            this.Text48.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 102, 77, 38), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text48.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text48.Font = new System.Drawing.Font("Arial", 9F);
            this.Text48.Indicator = null;
            this.Text48.Interaction = null;
            this.Text48.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text48.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text48.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("yyyy, MMMM", " ");
            this.Text48.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageHeaderBand1.Guid = null;
            this.PageHeaderBand1.Interaction = null;
            // 
            // PageFooterBand2
            // 
            this.PageFooterBand2 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 27.3, 19, 0.4);
            this.PageFooterBand2.Guid = "ba7bbbfc42314859ba26fe843dc9f42a";
            this.PageFooterBand2.Name = "PageFooterBand2";
            this.PageFooterBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageFooterBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text46
            // 
            this.Text46 = new Stimulsoft.Report.Components.StiText();
            this.Text46.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 12.2, 0.4);
            this.Text46.ComponentStyle = "Footer1";
            this.Text46.Guid = "c5f7181d3bb24473b986a0a2e7bca717";
            this.Text46.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text46.Name = "Text46";
            this.Text46.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text46__GetValue);
            this.Text46.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text46.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text46.Font = new System.Drawing.Font("Arial", 9F);
            this.Text46.Indicator = null;
            this.Text46.Interaction = null;
            this.Text46.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text46.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text46.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooterBand2.Interaction = null;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1 = new Stimulsoft.Report.Components.StiGroupHeaderBand();
            this.GroupHeader1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.2, 19, 6.4);
            this.GroupHeader1.GetValue += new Stimulsoft.Report.Events.StiValueEventHandler(this.GroupHeader1__GetValue);
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.NewPageBefore = true;
            this.GroupHeader1.SortDirection = Stimulsoft.Report.Components.StiGroupSortDirection.Descending;
            this.GroupHeader1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.GroupHeader1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5.8, 2.2, 0.6);
            this.Text6.ComponentStyle = "Header3";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text6.Guid = null;
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.2, 5.8, 6.4, 0.6);
            this.Text7.ComponentStyle = "Header3";
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text7.Guid = null;
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8.6, 5.8, 2, 0.6);
            this.Text8.ComponentStyle = "Header3";
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text8.Guid = null;
            this.Text8.Indicator = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10.6, 5.8, 3.2, 0.6);
            this.Text9.ComponentStyle = "Header3";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text9.Guid = null;
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13.8, 5.8, 2, 0.6);
            this.Text10.ComponentStyle = "Header3";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text10.Guid = null;
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 2.6, 0.8);
            this.Text17.ComponentStyle = "Header3";
            this.Text17.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text17.Guid = null;
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.6, 0, 6.2, 0.8);
            this.Text18.ComponentStyle = "Data1";
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text18.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text18.Font = new System.Drawing.Font("Arial", 9F);
            this.Text18.Guid = null;
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(5, 0, 5, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text19
            // 
            this.Text19 = new Stimulsoft.Report.Components.StiText();
            this.Text19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10, 0, 2.8, 0.8);
            this.Text19.ComponentStyle = "Header3";
            this.Text19.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text19.Name = "Text19";
            this.Text19.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text19__GetValue);
            this.Text19.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text19.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text19.Guid = null;
            this.Text19.Indicator = null;
            this.Text19.Interaction = null;
            this.Text19.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text19.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text19.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0, 6.2, 0.8);
            this.Text20.ComponentStyle = "Data1";
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text20.Font = new System.Drawing.Font("Arial", 9F);
            this.Text20.Guid = null;
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(5, 0, 5, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.8, 1.8, 0.6);
            this.Text11.ComponentStyle = "Header3";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text11.Guid = null;
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(1.8, 3.8, 2.8, 0.6);
            this.Text13.ComponentStyle = "Header3";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text13.Guid = null;
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.6, 3.8, 4.2, 0.6);
            this.Text14.ComponentStyle = "Header3";
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text14.Guid = null;
            this.Text14.Indicator = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8.8, 3.8, 2.4, 0.6);
            this.Text15.ComponentStyle = "Header3";
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text15.Guid = null;
            this.Text15.Indicator = null;
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text21
            // 
            this.Text21 = new Stimulsoft.Report.Components.StiText();
            this.Text21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(11.2, 3.8, 2.8, 0.6);
            this.Text21.ComponentStyle = "Header3";
            this.Text21.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text21.Name = "Text21";
            this.Text21.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text21__GetValue);
            this.Text21.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text21.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text21.Guid = null;
            this.Text21.Indicator = null;
            this.Text21.Interaction = null;
            this.Text21.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text21.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text21.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text22
            // 
            this.Text22 = new Stimulsoft.Report.Components.StiText();
            this.Text22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14, 3.8, 2.8, 0.6);
            this.Text22.ComponentStyle = "Header3";
            this.Text22.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text22.Name = "Text22";
            this.Text22.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text22__GetValue);
            this.Text22.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text22.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text22.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text22.Guid = null;
            this.Text22.Indicator = null;
            this.Text22.Interaction = null;
            this.Text22.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text22.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text22.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16.8, 3.8, 2.2, 0.6);
            this.Text23.ComponentStyle = "Header3";
            this.Text23.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text23.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text23.Guid = null;
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text24
            // 
            this.Text24 = new Stimulsoft.Report.Components.StiText();
            this.Text24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.4, 1.8, 0.8);
            this.Text24.ComponentStyle = "Data1";
            this.Text24.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text24.Name = "Text24";
            this.Text24.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text24__GetValue);
            this.Text24.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text24.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text24.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text24.Font = new System.Drawing.Font("Arial", 9F);
            this.Text24.Guid = null;
            this.Text24.Indicator = null;
            this.Text24.Interaction = null;
            this.Text24.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text24.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text24.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text25
            // 
            this.Text25 = new Stimulsoft.Report.Components.StiText();
            this.Text25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(1.8, 4.4, 2.8, 0.8);
            this.Text25.ComponentStyle = "Data1";
            this.Text25.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text25.Name = "Text25";
            this.Text25.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text25__GetValue);
            this.Text25.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text25.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text25.Font = new System.Drawing.Font("Arial", 9F);
            this.Text25.Guid = null;
            this.Text25.Indicator = null;
            this.Text25.Interaction = null;
            this.Text25.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text25.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text25.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text26
            // 
            this.Text26 = new Stimulsoft.Report.Components.StiText();
            this.Text26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.6, 4.4, 4.2, 0.8);
            this.Text26.ComponentStyle = "Data1";
            this.Text26.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text26.Name = "Text26";
            this.Text26.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text26__GetValue);
            this.Text26.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text26.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text26.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text26.Font = new System.Drawing.Font("Arial", 9F);
            this.Text26.Guid = null;
            this.Text26.Indicator = null;
            this.Text26.Interaction = null;
            this.Text26.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text26.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text26.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text27
            // 
            this.Text27 = new Stimulsoft.Report.Components.StiText();
            this.Text27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8.8, 4.4, 2.4, 0.8);
            this.Text27.ComponentStyle = "Data1";
            this.Text27.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text27.Name = "Text27";
            this.Text27.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text27__GetValue);
            this.Text27.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text27.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text27.Font = new System.Drawing.Font("Arial", 9F);
            this.Text27.Guid = null;
            this.Text27.Indicator = null;
            this.Text27.Interaction = null;
            this.Text27.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text27.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text27.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("d", " ");
            this.Text27.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text28
            // 
            this.Text28 = new Stimulsoft.Report.Components.StiText();
            this.Text28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(11.2, 4.4, 2.8, 0.8);
            this.Text28.ComponentStyle = "Data1";
            this.Text28.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text28.Name = "Text28";
            this.Text28.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text28__GetValue);
            this.Text28.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text28.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text28.Font = new System.Drawing.Font("Arial", 9F);
            this.Text28.Guid = null;
            this.Text28.Indicator = null;
            this.Text28.Interaction = null;
            this.Text28.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text28.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text28.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("d", " ");
            this.Text28.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text29
            // 
            this.Text29 = new Stimulsoft.Report.Components.StiText();
            this.Text29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14, 4.4, 2.8, 0.8);
            this.Text29.ComponentStyle = "Data1";
            this.Text29.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text29.Name = "Text29";
            this.Text29.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text29__GetValue);
            this.Text29.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text29.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text29.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text29.Font = new System.Drawing.Font("Arial", 9F);
            this.Text29.Guid = null;
            this.Text29.Indicator = null;
            this.Text29.Interaction = null;
            this.Text29.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text29.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text29.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("d", " ");
            this.Text29.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text30
            // 
            this.Text30 = new Stimulsoft.Report.Components.StiText();
            this.Text30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16.8, 4.4, 2.2, 0.8);
            this.Text30.ComponentStyle = "Data1";
            this.Text30.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text30.Name = "Text30";
            this.Text30.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text30__GetValue);
            this.Text30.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text30.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text30.Font = new System.Drawing.Font("Arial", 9F);
            this.Text30.Guid = null;
            this.Text30.Indicator = null;
            this.Text30.Interaction = null;
            this.Text30.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text30.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text30.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.6, 0.8, 6.2, 0.8);
            this.Text12.ComponentStyle = "Data1";
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text12.Font = new System.Drawing.Font("Arial", 9F);
            this.Text12.Guid = null;
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(5, 0, 5, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text31
            // 
            this.Text31 = new Stimulsoft.Report.Components.StiText();
            this.Text31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.6, 1.6, 6.2, 0.8);
            this.Text31.ComponentStyle = "Data1";
            this.Text31.Name = "Text31";
            this.Text31.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text31__GetValue);
            this.Text31.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text31.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text31.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text31.Font = new System.Drawing.Font("Arial", 9F);
            this.Text31.Guid = null;
            this.Text31.Indicator = null;
            this.Text31.Interaction = null;
            this.Text31.Margins = new Stimulsoft.Report.Components.StiMargins(5, 0, 5, 0);
            this.Text31.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text31.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text32
            // 
            this.Text32 = new Stimulsoft.Report.Components.StiText();
            this.Text32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.6, 2.4, 6.2, 0.8);
            this.Text32.ComponentStyle = "Data1";
            this.Text32.Name = "Text32";
            this.Text32.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text32__GetValue);
            this.Text32.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text32.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text32.Font = new System.Drawing.Font("Arial", 9F);
            this.Text32.Guid = null;
            this.Text32.Indicator = null;
            this.Text32.Interaction = null;
            this.Text32.Margins = new Stimulsoft.Report.Components.StiMargins(5, 0, 5, 0);
            this.Text32.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text32.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text33
            // 
            this.Text33 = new Stimulsoft.Report.Components.StiText();
            this.Text33.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 0.8, 6.2, 0.8);
            this.Text33.ComponentStyle = "Data1";
            this.Text33.Name = "Text33";
            this.Text33.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text33__GetValue);
            this.Text33.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text33.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text33.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text33.Font = new System.Drawing.Font("Arial", 9F);
            this.Text33.Guid = null;
            this.Text33.Indicator = null;
            this.Text33.Interaction = null;
            this.Text33.Margins = new Stimulsoft.Report.Components.StiMargins(5, 0, 5, 0);
            this.Text33.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text33.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text34
            // 
            this.Text34 = new Stimulsoft.Report.Components.StiText();
            this.Text34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 1.6, 6.2, 0.8);
            this.Text34.ComponentStyle = "Data1";
            this.Text34.Name = "Text34";
            this.Text34.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text34__GetValue);
            this.Text34.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text34.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text34.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text34.Font = new System.Drawing.Font("Arial", 9F);
            this.Text34.Guid = null;
            this.Text34.Indicator = null;
            this.Text34.Interaction = null;
            this.Text34.Margins = new Stimulsoft.Report.Components.StiMargins(5, 0, 5, 0);
            this.Text34.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text34.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text35
            // 
            this.Text35 = new Stimulsoft.Report.Components.StiText();
            this.Text35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.8, 2.4, 6.2, 0.8);
            this.Text35.ComponentStyle = "Data1";
            this.Text35.Name = "Text35";
            this.Text35.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text35__GetValue);
            this.Text35.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text35.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text35.Font = new System.Drawing.Font("Arial", 9F);
            this.Text35.Guid = null;
            this.Text35.Indicator = null;
            this.Text35.Interaction = null;
            this.Text35.Margins = new Stimulsoft.Report.Components.StiMargins(5, 0, 5, 0);
            this.Text35.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text35.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text36
            // 
            this.Text36 = new Stimulsoft.Report.Components.StiText();
            this.Text36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15.8, 5.8, 3.2, 0.6);
            this.Text36.ComponentStyle = "Header3";
            this.Text36.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text36.Name = "Text36";
            this.Text36.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text36__GetValue);
            this.Text36.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text36.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text36.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text36.Guid = null;
            this.Text36.Indicator = null;
            this.Text36.Interaction = null;
            this.Text36.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text36.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text36.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.GroupHeader1.Guid = null;
            this.GroupHeader1.Interaction = null;
            // 
            // Data1
            // 
            this.Data1 = new Stimulsoft.Report.Components.StiDataBand();
            this.Data1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.4, 19, 0.6);
            this.Data1.DataSourceName = "Order_Details";
            this.Data1.EvenStyle = "Data2";
            this.Data1.Name = "Data1";
            this.Data1.Sort = new System.String[] {
                    "ASC",
                    "ProductsOrder_Details",
                    "ProductName"};
            this.Data1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Right, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Data1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Data1.BusinessObjectGuid = null;
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 2.2, 0.6);
            this.Text1.ComponentStyle = "Data1";
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("Arial", 9F);
            this.Text1.Guid = null;
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.2, 0, 6.4, 0.6);
            this.Text2.ComponentStyle = "Data1";
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("Arial", 9F);
            this.Text2.Guid = null;
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8.6, 0, 2, 0.6);
            this.Text3.ComponentStyle = "Data1";
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("Arial", 9F);
            this.Text3.Guid = null;
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text3.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ".", 2, ",", 3, true, true, " ");
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(10.6, 0, 3.2, 0.6);
            this.Text4.ComponentStyle = "Data1";
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("Arial", 9F);
            this.Text4.Guid = null;
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text4.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCurrencyFormatService(0, 0, ".", 2, ",", 3, "$", true, true, " ");
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(13.8, 0, 2, 0.6);
            this.Text5.ComponentStyle = "Data1";
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("Arial", 9F);
            this.Text5.Guid = null;
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text5.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiPercentageFormatService(0, 0, ".", 2, ",", 3, "%", true, true, " ");
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text37
            // 
            this.Text37 = new Stimulsoft.Report.Components.StiText();
            this.Text37.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15.8, 0, 3.2, 0.6);
            this.Text37.ComponentStyle = "Data1";
            this.Text37.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text37.Name = "Text37";
            this.Text37.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text37__GetValue);
            this.Text37.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text37.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text37.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text37.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text37.Font = new System.Drawing.Font("Arial", 9F);
            this.Text37.Guid = null;
            this.Text37.Indicator = null;
            this.Text37.Interaction = null;
            this.Text37.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text37.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text37.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCurrencyFormatService(0, 0, ".", 2, ",", 3, "$", true, true, " ");
            this.Text37.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Data1.Guid = null;
            this.Data1.Interaction = null;
            this.Data1.MasterComponent = null;
            // 
            // GroupFooterBand1
            // 
            this.GroupFooterBand1 = new Stimulsoft.Report.Components.StiGroupFooterBand();
            this.GroupFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 11.8, 19, 2.8);
            this.GroupFooterBand1.ComponentStyle = "Footer1";
            this.GroupFooterBand1.Name = "GroupFooterBand1";
            this.GroupFooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.GroupFooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text38
            // 
            this.Text38 = new Stimulsoft.Report.Components.StiText();
            this.Text38.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16, 0.2, 2.8, 0.8);
            this.Text38.ComponentStyle = "Footer1";
            this.Text38.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text38.Name = "Text38";
            // 
            // Text38_Sum
            // 
            this.Text38.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text38__GetValue);
            this.Text38.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text38.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text38.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text38.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text38.Font = new System.Drawing.Font("Arial", 9F);
            this.Text38.Guid = null;
            this.Text38.Indicator = null;
            this.Text38.Interaction = null;
            this.Text38.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text38.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text38.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCurrencyFormatService(0, 0, ".", 2, ",", 3, "$", true, true, " ");
            this.Text38.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text39
            // 
            this.Text39 = new Stimulsoft.Report.Components.StiText();
            this.Text39.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16, 1, 2.8, 0.8);
            this.Text39.ComponentStyle = "Footer1";
            this.Text39.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text39.Name = "Text39";
            this.Text39.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text39__GetValue);
            this.Text39.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text39.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text39.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text39.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text39.Font = new System.Drawing.Font("Arial", 9F);
            this.Text39.Guid = null;
            this.Text39.Indicator = null;
            this.Text39.Interaction = null;
            this.Text39.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text39.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text39.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCurrencyFormatService(0, 0, ".", 2, ",", 3, "$", true, true, " ");
            this.Text39.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text40
            // 
            this.Text40 = new Stimulsoft.Report.Components.StiText();
            this.Text40.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16, 1.8, 2.8, 0.8);
            this.Text40.ComponentStyle = "Footer1";
            this.Text40.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text40.Name = "Text40";
            // 
            // Text40_Sum
            // 
            this.Text40.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text40__GetValue);
            this.Text40.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text40.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text40.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text40.Font = new System.Drawing.Font("Arial", 9F);
            this.Text40.Guid = null;
            this.Text40.Indicator = null;
            this.Text40.Interaction = null;
            this.Text40.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text40.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text40.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text43
            // 
            this.Text43 = new Stimulsoft.Report.Components.StiText();
            this.Text43.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.4, 0.2, 3.6, 0.8);
            this.Text43.ComponentStyle = "Footer1";
            this.Text43.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text43.Name = "Text43";
            this.Text43.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text43__GetValue);
            this.Text43.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text43.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text43.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text43.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text43.Font = new System.Drawing.Font("Arial", 9F);
            this.Text43.Guid = null;
            this.Text43.Indicator = null;
            this.Text43.Interaction = null;
            this.Text43.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text43.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text43.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text44
            // 
            this.Text44 = new Stimulsoft.Report.Components.StiText();
            this.Text44.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.4, 1, 3.6, 0.8);
            this.Text44.ComponentStyle = "Footer1";
            this.Text44.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.InitializeComponent2();
        }
        
        public void InitializeComponent2()
        {
            this.Text44.Name = "Text44";
            this.Text44.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text44__GetValue);
            this.Text44.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text44.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text44.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text44.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text44.Font = new System.Drawing.Font("Arial", 9F);
            this.Text44.Guid = null;
            this.Text44.Indicator = null;
            this.Text44.Interaction = null;
            this.Text44.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text44.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text44.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text45
            // 
            this.Text45 = new Stimulsoft.Report.Components.StiText();
            this.Text45.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12.4, 1.8, 3.6, 0.8);
            this.Text45.ComponentStyle = "Footer1";
            this.Text45.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text45.Name = "Text45";
            this.Text45.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text45__GetValue);
            this.Text45.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text45.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text45.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text45.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text45.Font = new System.Drawing.Font("Arial", 9F);
            this.Text45.Guid = null;
            this.Text45.Indicator = null;
            this.Text45.Interaction = null;
            this.Text45.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text45.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text45.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.GroupFooterBand1.Guid = null;
            this.GroupFooterBand1.Interaction = null;
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Bold);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.ReportAuthor = null;
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
            this.PageHeaderBand1.Page = this.Page1;
            this.PageHeaderBand1.Parent = this.Page1;
            this.Text41.Page = this.Page1;
            this.Text41.Parent = this.PageHeaderBand1;
            this.Text42.Page = this.Page1;
            this.Text42.Parent = this.PageHeaderBand1;
            this.Text47.Page = this.Page1;
            this.Text47.Parent = this.PageHeaderBand1;
            this.Text48.Page = this.Page1;
            this.Text48.Parent = this.PageHeaderBand1;
            this.PageFooterBand2.Page = this.Page1;
            this.PageFooterBand2.Parent = this.Page1;
            this.Text46.Page = this.Page1;
            this.Text46.Parent = this.PageFooterBand2;
            this.GroupHeader1.Page = this.Page1;
            this.GroupHeader1.Parent = this.Page1;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.GroupHeader1;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.GroupHeader1;
            this.Text8.Page = this.Page1;
            this.Text8.Parent = this.GroupHeader1;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.GroupHeader1;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.GroupHeader1;
            this.Text17.Page = this.Page1;
            this.Text17.Parent = this.GroupHeader1;
            this.Text18.Page = this.Page1;
            this.Text18.Parent = this.GroupHeader1;
            this.Text19.Page = this.Page1;
            this.Text19.Parent = this.GroupHeader1;
            this.Text20.Page = this.Page1;
            this.Text20.Parent = this.GroupHeader1;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.GroupHeader1;
            this.Text13.Page = this.Page1;
            this.Text13.Parent = this.GroupHeader1;
            this.Text14.Page = this.Page1;
            this.Text14.Parent = this.GroupHeader1;
            this.Text15.Page = this.Page1;
            this.Text15.Parent = this.GroupHeader1;
            this.Text21.Page = this.Page1;
            this.Text21.Parent = this.GroupHeader1;
            this.Text22.Page = this.Page1;
            this.Text22.Parent = this.GroupHeader1;
            this.Text23.Page = this.Page1;
            this.Text23.Parent = this.GroupHeader1;
            this.Text24.Page = this.Page1;
            this.Text24.Parent = this.GroupHeader1;
            this.Text25.Page = this.Page1;
            this.Text25.Parent = this.GroupHeader1;
            this.Text26.Page = this.Page1;
            this.Text26.Parent = this.GroupHeader1;
            this.Text27.Page = this.Page1;
            this.Text27.Parent = this.GroupHeader1;
            this.Text28.Page = this.Page1;
            this.Text28.Parent = this.GroupHeader1;
            this.Text29.Page = this.Page1;
            this.Text29.Parent = this.GroupHeader1;
            this.Text30.Page = this.Page1;
            this.Text30.Parent = this.GroupHeader1;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.GroupHeader1;
            this.Text31.Page = this.Page1;
            this.Text31.Parent = this.GroupHeader1;
            this.Text32.Page = this.Page1;
            this.Text32.Parent = this.GroupHeader1;
            this.Text33.Page = this.Page1;
            this.Text33.Parent = this.GroupHeader1;
            this.Text34.Page = this.Page1;
            this.Text34.Parent = this.GroupHeader1;
            this.Text35.Page = this.Page1;
            this.Text35.Parent = this.GroupHeader1;
            this.Text36.Page = this.Page1;
            this.Text36.Parent = this.GroupHeader1;
            this.Data1.Page = this.Page1;
            this.Data1.Parent = this.Page1;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.Data1;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.Data1;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.Data1;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.Data1;
            this.Text5.Page = this.Page1;
            this.Text5.Parent = this.Data1;
            this.Text37.Page = this.Page1;
            this.Text37.Parent = this.Data1;
            this.GroupFooterBand1.Page = this.Page1;
            this.GroupFooterBand1.Parent = this.Page1;
            this.Text38.Page = this.Page1;
            this.Text38.Parent = this.GroupFooterBand1;
            this.Text39.Page = this.Page1;
            this.Text39.Parent = this.GroupFooterBand1;
            this.Text40.Page = this.Page1;
            this.Text40.Parent = this.GroupFooterBand1;
            this.Text43.Page = this.Page1;
            this.Text43.Parent = this.GroupFooterBand1;
            this.Text44.Page = this.Page1;
            this.Text44.Parent = this.GroupFooterBand1;
            this.Text45.Page = this.Page1;
            this.Text45.Parent = this.GroupFooterBand1;
            this.GroupHeader1.BeginRender += new System.EventHandler(this.GroupHeader1__BeginRender);
            this.GroupHeader1.EndRender += new System.EventHandler(this.GroupHeader1__EndRender);
            this.GroupHeader1.Rendering += new System.EventHandler(this.GroupHeader1__Rendering);
            this.EndRender += new System.EventHandler(this.ReportWordsToEnd__EndRender);
            this.AggregateFunctions = new object[] {
                    this.Text38_Sum,
                    this.Text40_Sum};
            // 
            // Add to PageHeaderBand1.Components
            // 
            this.PageHeaderBand1.Components.Clear();
            this.PageHeaderBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text41,
                        this.Text42,
                        this.Text47,
                        this.Text48});
            // 
            // Add to PageFooterBand2.Components
            // 
            this.PageFooterBand2.Components.Clear();
            this.PageFooterBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text46});
            // 
            // Add to GroupHeader1.Components
            // 
            this.GroupHeader1.Components.Clear();
            this.GroupHeader1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text6,
                        this.Text7,
                        this.Text8,
                        this.Text9,
                        this.Text10,
                        this.Text17,
                        this.Text18,
                        this.Text19,
                        this.Text20,
                        this.Text11,
                        this.Text13,
                        this.Text14,
                        this.Text15,
                        this.Text21,
                        this.Text22,
                        this.Text23,
                        this.Text24,
                        this.Text25,
                        this.Text26,
                        this.Text27,
                        this.Text28,
                        this.Text29,
                        this.Text30,
                        this.Text12,
                        this.Text31,
                        this.Text32,
                        this.Text33,
                        this.Text34,
                        this.Text35,
                        this.Text36});
            // 
            // Add to Data1.Components
            // 
            this.Data1.Components.Clear();
            this.Data1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text1,
                        this.Text2,
                        this.Text3,
                        this.Text4,
                        this.Text5,
                        this.Text37});
            // 
            // Add to GroupFooterBand1.Components
            // 
            this.GroupFooterBand1.Components.Clear();
            this.GroupFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text38,
                        this.Text39,
                        this.Text40,
                        this.Text43,
                        this.Text44,
                        this.Text45});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageHeaderBand1,
                        this.PageFooterBand2,
                        this.GroupHeader1,
                        this.Data1,
                        this.GroupFooterBand1});
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
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Description", "Description", "Description", typeof(string))});
            this.DataSources.Add(this.Categories);
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
            this.DataSources.Add(this.Customers);
            this.Employees.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", "EmployeeID", "EmployeeID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("LastName", "LastName", "LastName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("FirstName", "FirstName", "FirstName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Title", "Title", "Title", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BirthDate", "BirthDate", "BirthDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HireDate", "HireDate", "HireDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HomePhone", "HomePhone", "HomePhone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Notes", "Notes", "Notes", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ReportsTo", "ReportsTo", "ReportsTo", typeof(int))});
            this.DataSources.Add(this.Employees);
            this.Order_Details.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", "OrderID", "OrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Quantity", "Quantity", "Quantity", typeof(short)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Discount", "Discount", "Discount", typeof(float))});
            this.DataSources.Add(this.Order_Details);
            this.Orders.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", "OrderID", "OrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", "EmployeeID", "EmployeeID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderDate", "OrderDate", "OrderDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("RequiredDate", "RequiredDate", "RequiredDate", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShippedDate", "ShippedDate", "ShippedDate", typeof(object)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipVia", "ShipVia", "ShipVia", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Freight", "Freight", "Freight", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipName", "ShipName", "ShipName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipAddress", "ShipAddress", "ShipAddress", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCity", "ShipCity", "ShipCity", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipRegion", "ShipRegion", "ShipRegion", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipPostalCode", "ShipPostalCode", "ShipPostalCode", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCountry", "ShipCountry", "ShipCountry", typeof(string))});
            this.DataSources.Add(this.Orders);
            this.Products.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", "ProductID", "ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductName", "ProductName", "ProductName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", "CategoryID", "CategoryID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("QuantityPerUnit", "QuantityPerUnit", "QuantityPerUnit", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", "UnitPrice", "UnitPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsInStock", "UnitsInStock", "UnitsInStock", typeof(short))});
            this.DataSources.Add(this.Products);
            this.Shippers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipperID", "ShipperID", "ShipperID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string))});
            this.DataSources.Add(this.Shippers);
            this.Suppliers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", "SupplierID", "SupplierID", typeof(int)),
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
            this.DataSources.Add(this.Suppliers);
            this.Countries.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountriesID", "CountriesID", "CountriesID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Flag", "Flag", "Flag", typeof(byte[])),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountryName", "CountryName", "CountryName", typeof(string))});
            this.DataSources.Add(this.Countries);
        }
        
        #region Relation ParentEmployees
        public class ParentEmployeesRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentEmployeesRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
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
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
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
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
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
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual string QuantityPerUnit
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
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
            
            public virtual ParentCategoriesRelation Categories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("CategoriesProducts"));
                }
            }
            
            public virtual ParentSuppliersRelation Suppliers
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
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
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
            
            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime RequiredDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["RequiredDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual object ShippedDate
            {
                get
                {
                    return this["ShippedDate"];
                }
            }
            
            public virtual int ShipVia
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipVia"], typeof(int), true)));
                }
            }
            
            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
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
            
            public virtual ParentCustomersRelation Customers
            {
                get
                {
                    return new ParentCustomersRelation(this.GetParentData("CustomersOrders"));
                }
            }
            
            public virtual ParentShippersRelation Shippers
            {
                get
                {
                    return new ParentShippersRelation(this.GetParentData("ShippersOrders"));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
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
        #endregion Relation ParentCustomers
        
        #region Relation ParentShippers
        public class ParentShippersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentShippersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int ShipperID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipperID"], typeof(int), true)));
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
        #endregion Relation ParentShippers
        
        #region Relation ParentEmployees1
        public class ParentEmployees1Relation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentEmployees1Relation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
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
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
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
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
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
        }
        #endregion Relation ParentCategories
        
        #region Relation ParentSuppliers
        public class ParentSuppliersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentSuppliersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
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
        }
        #endregion DataSource Categories
        
        #region DataSource Customers
        public class CustomersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CustomersDataSource() : 
                    base("Demo.Customers", "Customers")
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
        #endregion DataSource Customers
        
        #region DataSource Employees
        public class EmployeesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public EmployeesDataSource() : 
                    base("Demo.Employees", "Employees")
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
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
            
            public virtual DateTime BirthDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["BirthDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime HireDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["HireDate"], typeof(DateTime), true)));
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
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
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
                    base("Demo.Order Details", "Order_Details")
            {
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
            
            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }
            
            public virtual short Quantity
            {
                get
                {
                    return ((short)(StiReport.ChangeType(this["Quantity"], typeof(short), true)));
                }
            }
            
            public virtual float Discount
            {
                get
                {
                    return ((float)(StiReport.ChangeType(this["Discount"], typeof(float), true)));
                }
            }
            
            public virtual ParentProductsRelation Products
            {
                get
                {
                    return new ParentProductsRelation(this.GetParentData("ProductsOrder_Details"));
                }
            }
            
            public virtual ParentOrdersRelation Orders
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
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
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
            
            public virtual DateTime OrderDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["OrderDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime RequiredDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["RequiredDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual object ShippedDate
            {
                get
                {
                    return this["ShippedDate"];
                }
            }
            
            public virtual int ShipVia
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipVia"], typeof(int), true)));
                }
            }
            
            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
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
            
            public virtual ParentCustomersRelation Customers
            {
                get
                {
                    return new ParentCustomersRelation(this.GetParentData("CustomersOrders"));
                }
            }
            
            public virtual ParentShippersRelation Shippers
            {
                get
                {
                    return new ParentShippersRelation(this.GetParentData("ShippersOrders"));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
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
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual string QuantityPerUnit
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["QuantityPerUnit"], typeof(string), true)));
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
            
            public virtual ParentCategoriesRelation Categories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("CategoriesProducts"));
                }
            }
            
            public virtual ParentSuppliersRelation Suppliers
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
            
            public virtual int ShipperID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ShipperID"], typeof(int), true)));
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
        #endregion DataSource Shippers
        
        #region DataSource Suppliers
        public class SuppliersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public SuppliersDataSource() : 
                    base("Demo.Suppliers", "Suppliers")
            {
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
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
        #endregion DataSource Suppliers
        
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
            
            public virtual byte[] Flag
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["Flag"], typeof(byte[]), true)));
                }
            }
            
            public virtual string CountryName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CountryName"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Countries
        #endregion StiReport Designer generated code - do not modify
    }
}