﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace Reports
{
    public class AllGroupFootersAtEnd : Stimulsoft.Report.StiReport
    {
        public AllGroupFootersAtEnd()
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
        public string Letter;
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand2;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand2;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiGroupHeaderBand GroupHeaderBand1;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiGroupFooterBand GroupFooterBand1;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Dictionary.StiCountFunctionService Text9_Count;
        public Stimulsoft.Report.Components.StiColumnHeaderBand ColumnHeaderBand1;
        public Stimulsoft.Report.Components.StiGroupHeaderBand GroupHeaderBand2;
        public Stimulsoft.Report.Components.StiDataBand DataBand2;
        public Stimulsoft.Report.Components.StiGroupFooterBand GroupFooterBand2;
        public Stimulsoft.Report.Components.StiText Text19;
        public Stimulsoft.Report.Dictionary.StiCountFunctionService Text19_Count;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiText Text15;
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
        public CategoriesDataSource Categories;
        public CustomersDataSource Customers;
        public EmployeesDataSource Employees;
        public Order_DetailsDataSource Order_Details;
        public OrdersDataSource Orders;
        public ProductsDataSource Products;
        public ShippersDataSource Shippers;
        public SuppliersDataSource Suppliers;
        public CountriesDataSource Countries;
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text5_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return ToString(sender, PageNofM, true);
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Stimulsoft";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Group Footers at End";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text18.TextFormat.Format(CheckExcelValue(sender, "Date: " + Today.ToString("Y")));
        }
        
        public void GroupHeaderBand1__GetBookmark(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = ToString(Customers.CompanyName.Substring(0, 1));
        }
        
        public void GroupHeaderBand1__GetValue(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = Customers.CompanyName.Substring(0, 1);
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Customers.CompanyName.Substring(0, 1), true);
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Address";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Company";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Phone";
        }
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Contact";
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Customers.Address, true);
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Customers.Phone, true);
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Customers.ContactTitle, true);
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Customers.CompanyName, true);
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#Count: {Count()}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text9_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return "Count: " + ToString(sender, ((long)(StiReport.ChangeType(this.Text9_Count.GetValue(), typeof(long), true))), true);
        }
        
        public void GroupHeaderBand2__GetBookmark(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = ToString(Customers.CompanyName.Substring(0, 1));
        }
        
        public void GroupHeaderBand2__GetValue(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = Customers.CompanyName.Substring(0, 1);
        }
        
        public void GroupHeaderBand2_BeforePrint(object sender, System.EventArgs e)
        {
            Letter = Customers.CompanyName.Substring(0, 1);;
        }
        
        public void Text19__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#Count: {Count()}";
            e.StoreToPrinted = true;
        }
        
        public System.String Text19_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            return "Count: " + ToString(sender, ((long)(StiReport.ChangeType(this.Text19_Count.GetValue(), typeof(long), true))), true);
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Letter: " + ToString(sender, Letter, true) + ":";
        }
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "All GroupFooters\r\n\r\nin the end\r\n\r\nof report";
        }
        
        public void GroupHeaderBand1__BeginRender(object sender, System.EventArgs e)
        {
            this.Text9_Count.Init();
            this.Text9.TextValue = "";
        }
        
        public void GroupHeaderBand1__EndRender(object sender, System.EventArgs e)
        {
            this.Text9.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text9_GetValue_End));
        }
        
        public void GroupHeaderBand2__BeginRender(object sender, System.EventArgs e)
        {
            this.Text19_Count.Init();
            this.Text19.TextValue = "";
        }
        
        public void GroupHeaderBand2__EndRender(object sender, System.EventArgs e)
        {
            this.Text19.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text19_GetValue_End));
        }
        
        public void GroupHeaderBand1__Rendering(object sender, System.EventArgs e)
        {
            this.Text9_Count.CalcItem(null);
        }
        
        public void GroupHeaderBand2__Rendering(object sender, System.EventArgs e)
        {
            this.Text19_Count.CalcItem(null);
        }
        
        public void ReportWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text5.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text5_GetValue_End));
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
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "Letter", "Letter", "", typeof(string), "", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, false));
            this.NeedsCompiling = false;
            this.Text19_Count = new Stimulsoft.Report.Dictionary.StiCountFunctionService();
            this.Text9_Count = new Stimulsoft.Report.Dictionary.StiCountFunctionService();
            // 
            // Variables init
            // 
            this.Letter = "";
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
            this.ReportAlias = "All GroupFooters in the End";
            this.ReportAuthor = "Stimulsoft";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2011, 4, 4, 10, 47, 37, 768);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "This sample shows all group footers at the bottom of a report.";
            this.ReportFile = "E:\\002\\AllGroupFootersAtEnd.mrt";
            this.ReportGuid = "078e267d574246eea535856e12d24af2";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportVersion = "2011.1.1000";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "b682c7f00c8b4c6da77f29ebbde6224e";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 29.7;
            this.Page1.PageWidth = 21;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageFooterBand2
            // 
            this.PageFooterBand2 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 27.3, 19, 0.4);
            this.PageFooterBand2.Guid = "74cf268816db47adb5b4f1fe19a361c0";
            this.PageFooterBand2.Name = "PageFooterBand2";
            this.PageFooterBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.PageFooterBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 12.2, 0.4);
            this.Text5.ComponentStyle = "Footer1";
            this.Text5.Guid = "a017ece896e54dde869053dc2f912c34";
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("Arial", 9F);
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooterBand2.Interaction = null;
            // 
            // ReportTitleBand2
            // 
            this.ReportTitleBand2 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 2);
            this.ReportTitleBand2.Guid = "2efdf9c5543d47b39b18ccf996058508";
            this.ReportTitleBand2.Name = "ReportTitleBand2";
            this.ReportTitleBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.ReportTitleBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(11.4, 0, 7.6, 0.8);
            this.Text20.ComponentStyle = "Title1";
            this.Text20.Guid = "2278a0198a3c4709a2225274c4ef341a";
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
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 11.4, 0.8);
            this.Text23.ComponentStyle = "Title1";
            this.Text23.Guid = "30c225db67e74a0287d69a735e7a3e6f";
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
            this.Text17.ComponentStyle = "Title2";
            this.Text17.Guid = "d379352db05149f187e07380e8ff8097";
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
            this.Text18.ComponentStyle = "Title2";
            this.Text18.Guid = "13dcdde5092d40c8880c3aefcaaf9ffb";
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
            // 
            // GroupHeaderBand1
            // 
            this.GroupHeaderBand1 = new Stimulsoft.Report.Components.StiGroupHeaderBand();
            this.GroupHeaderBand1.GetBookmark += new Stimulsoft.Report.Events.StiValueEventHandler(this.GroupHeaderBand1__GetBookmark);
            this.GroupHeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 3.2, 19, 1.8);
            this.GroupHeaderBand1.GetValue += new Stimulsoft.Report.Events.StiValueEventHandler(this.GroupHeaderBand1__GetValue);
            this.GroupHeaderBand1.KeepGroupTogether = true;
            this.GroupHeaderBand1.Name = "GroupHeaderBand1";
            this.GroupHeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.GroupHeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 1.2);
            this.Text8.ComponentStyle = "Header1";
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text8.Font = new System.Drawing.Font("Arial", 19F);
            this.Text8.Guid = null;
            this.Text8.Indicator = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 1.2, 5.2, 0.6);
            this.Text11.ComponentStyle = "Header3";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
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
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.2, 6.8, 0.6);
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
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12, 1.2, 3, 0.6);
            this.Text12.ComponentStyle = "Header3";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder((((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Top) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Bottom), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text12.Guid = null;
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15, 1.2, 4, 0.6);
            this.Text13.ComponentStyle = "Header3";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 242, 234, 221));
            this.Text13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Text13.Guid = null;
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.GroupHeaderBand1.Guid = null;
            this.GroupHeaderBand1.Interaction = null;
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 5.8, 19, 0.6);
            this.DataBand1.DataSourceName = "Customers";
            this.DataBand1.EvenStyle = "Data2";
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new System.String[] {
                    "ASC",
                    "CompanyName"};
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand1.BusinessObjectGuid = null;
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 5.2, 0.6);
            this.Text2.ComponentStyle = "Data1";
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("Arial", 9F);
            this.Text2.Guid = null;
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12, 0, 3, 0.6);
            this.Text4.ComponentStyle = "Data1";
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("Arial", 9F);
            this.Text4.Guid = null;
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15, 0, 4, 0.6);
            this.Text3.ComponentStyle = "Data1";
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(((Stimulsoft.Base.Drawing.StiBorderSides.None | Stimulsoft.Base.Drawing.StiBorderSides.Left) 
                            | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("Arial", 9F);
            this.Text3.Guid = null;
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.8, 0.6);
            this.Text1.ComponentStyle = "Data1";
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("Arial", 9F);
            this.Text1.Guid = null;
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand1.Guid = null;
            this.DataBand1.Interaction = null;
            this.DataBand1.MasterComponent = null;
            // 
            // GroupFooterBand1
            // 
            this.GroupFooterBand1 = new Stimulsoft.Report.Components.StiGroupFooterBand();
            this.GroupFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 7.2, 19, 0.6);
            this.GroupFooterBand1.Name = "GroupFooterBand1";
            this.GroupFooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.GroupFooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 0.6);
            this.Text9.ComponentStyle = "Footer1";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text9.Name = "Text9";
            // 
            // Text9_Count
            // 
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text9.Font = new System.Drawing.Font("Arial", 9F);
            this.Text9.Guid = null;
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.GroupFooterBand1.Guid = null;
            this.GroupFooterBand1.Interaction = null;
            // 
            // ColumnHeaderBand1
            // 
            this.ColumnHeaderBand1 = new Stimulsoft.Report.Components.StiColumnHeaderBand();
            this.ColumnHeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 8.6, 19, 0.4);
            this.ColumnHeaderBand1.Name = "ColumnHeaderBand1";
            this.ColumnHeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.ColumnHeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.ColumnHeaderBand1.Guid = null;
            this.ColumnHeaderBand1.Interaction = null;
            // 
            // GroupHeaderBand2
            // 
            this.GroupHeaderBand2 = new Stimulsoft.Report.Components.StiGroupHeaderBand();
            this.GroupHeaderBand2.GetBookmark += new Stimulsoft.Report.Events.StiValueEventHandler(this.GroupHeaderBand2__GetBookmark);
            this.GroupHeaderBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.8, 19, 0);
            this.GroupHeaderBand2.GetValue += new Stimulsoft.Report.Events.StiValueEventHandler(this.GroupHeaderBand2__GetValue);
            this.GroupHeaderBand2.Name = "GroupHeaderBand2";
            this.GroupHeaderBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.GroupHeaderBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.GroupHeaderBand2.Guid = null;
            this.GroupHeaderBand2.Interaction = null;
            this.GroupHeaderBand2.BeforePrint += new System.EventHandler(this.GroupHeaderBand2_BeforePrint);
            // 
            // DataBand2
            // 
            this.DataBand2 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.6, 19, 0);
            this.DataBand2.DataSourceName = "Customers";
            this.DataBand2.Name = "DataBand2";
            this.DataBand2.ResetDataSource = true;
            this.DataBand2.Sort = new System.String[] {
                    "ASC",
                    "CompanyName"};
            this.DataBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand2.BusinessObjectGuid = null;
            this.DataBand2.Guid = null;
            this.DataBand2.Interaction = null;
            this.DataBand2.MasterComponent = null;
            // 
            // GroupFooterBand2
            // 
            this.GroupFooterBand2 = new Stimulsoft.Report.Components.StiGroupFooterBand();
            this.GroupFooterBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 11.4, 19, 0.4);
            this.GroupFooterBand2.Name = "GroupFooterBand2";
            this.GroupFooterBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.GroupFooterBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text19
            // 
            this.Text19 = new Stimulsoft.Report.Components.StiText();
            this.Text19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(16.8, 0, 2.2, 0.4);
            this.Text19.ComponentStyle = "Footer1";
            this.Text19.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text19.Name = "Text19";
            // 
            // Text19_Count
            // 
            this.Text19.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text19__GetValue);
            this.Text19.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text19.Font = new System.Drawing.Font("Arial", 9F);
            this.Text19.Guid = null;
            this.Text19.Indicator = null;
            this.Text19.Interaction = null;
            this.Text19.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text19.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text19.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(14.6, 0, 2.2, 0.4);
            this.Text14.ComponentStyle = "Footer1";
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text14.Font = new System.Drawing.Font("Arial", 9F);
            this.Text14.Guid = null;
            this.Text14.Indicator = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 102, 77, 38));
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.4, 0, 13.8, 0.4);
            this.Text15.ComponentStyle = "Header1";
            this.Text15.GrowToHeight = true;
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text15.Name = "Text15";
            this.Text15.ProcessingDuplicates = Stimulsoft.Report.Components.StiProcessingDuplicatesType.Merge;
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 193, 152, 89), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text15.Font = new System.Drawing.Font("Arial", 19F);
            this.Text15.Guid = null;
            this.Text15.Indicator = null;
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 193, 152, 89));
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.GroupFooterBand2.Guid = null;
            this.GroupFooterBand2.Interaction = null;
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
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
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.PageFooterBand2.Page = this.Page1;
            this.PageFooterBand2.Parent = this.Page1;
            this.Text5.Page = this.Page1;
            this.Text5.Parent = this.PageFooterBand2;
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
            this.GroupHeaderBand1.Page = this.Page1;
            this.GroupHeaderBand1.Parent = this.Page1;
            this.Text8.Page = this.Page1;
            this.Text8.Parent = this.GroupHeaderBand1;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.GroupHeaderBand1;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.GroupHeaderBand1;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.GroupHeaderBand1;
            this.Text13.Page = this.Page1;
            this.Text13.Parent = this.GroupHeaderBand1;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.DataBand1;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.DataBand1;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.DataBand1;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.DataBand1;
            this.GroupFooterBand1.Page = this.Page1;
            this.GroupFooterBand1.Parent = this.Page1;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.GroupFooterBand1;
            this.ColumnHeaderBand1.Page = this.Page1;
            this.ColumnHeaderBand1.Parent = this.Page1;
            this.GroupHeaderBand2.Page = this.Page1;
            this.GroupHeaderBand2.Parent = this.Page1;
            this.DataBand2.Page = this.Page1;
            this.DataBand2.Parent = this.Page1;
            this.GroupFooterBand2.Page = this.Page1;
            this.GroupFooterBand2.Parent = this.Page1;
            this.Text19.Page = this.Page1;
            this.Text19.Parent = this.GroupFooterBand2;
            this.Text14.Page = this.Page1;
            this.Text14.Parent = this.GroupFooterBand2;
            this.Text15.Page = this.Page1;
            this.Text15.Parent = this.GroupFooterBand2;
            this.GroupHeaderBand1.BeginRender += new System.EventHandler(this.GroupHeaderBand1__BeginRender);
            this.GroupHeaderBand1.EndRender += new System.EventHandler(this.GroupHeaderBand1__EndRender);
            this.GroupHeaderBand2.BeginRender += new System.EventHandler(this.GroupHeaderBand2__BeginRender);
            this.GroupHeaderBand2.EndRender += new System.EventHandler(this.GroupHeaderBand2__EndRender);
            this.GroupHeaderBand1.Rendering += new System.EventHandler(this.GroupHeaderBand1__Rendering);
            this.GroupHeaderBand2.Rendering += new System.EventHandler(this.GroupHeaderBand2__Rendering);
            this.EndRender += new System.EventHandler(this.ReportWordsToEnd__EndRender);
            this.AggregateFunctions = new object[] {
                    this.Text9_Count,
                    this.Text19_Count};
            // 
            // Add to PageFooterBand2.Components
            // 
            this.PageFooterBand2.Components.Clear();
            this.PageFooterBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text5});
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
            // Add to GroupHeaderBand1.Components
            // 
            this.GroupHeaderBand1.Components.Clear();
            this.GroupHeaderBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text8,
                        this.Text11,
                        this.Text10,
                        this.Text12,
                        this.Text13});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text2,
                        this.Text4,
                        this.Text3,
                        this.Text1});
            // 
            // Add to GroupFooterBand1.Components
            // 
            this.GroupFooterBand1.Components.Clear();
            this.GroupFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text9});
            // 
            // Add to GroupFooterBand2.Components
            // 
            this.GroupFooterBand2.Components.Clear();
            this.GroupFooterBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text19,
                        this.Text14,
                        this.Text15});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooterBand2,
                        this.ReportTitleBand2,
                        this.GroupHeaderBand1,
                        this.DataBand1,
                        this.GroupFooterBand1,
                        this.ColumnHeaderBand1,
                        this.GroupHeaderBand2,
                        this.DataBand2,
                        this.GroupFooterBand2});
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
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShippedDate", "ShippedDate", "ShippedDate", typeof(DateTime)),
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
            
            public virtual DateTime ShippedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ShippedDate"], typeof(DateTime), true)));
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
                    base("Demo.Order Details", "Order Details")
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
            
            public virtual DateTime ShippedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["ShippedDate"], typeof(DateTime), true)));
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