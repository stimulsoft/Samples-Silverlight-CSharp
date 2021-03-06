#region Copyright (C) 2003-2010 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports.SL											}
{	                         										}
{																	}
{	Copyright (C) 2003-2010 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2010 Stimulsoft

using System;
using System.Collections.Generic;

public class Data
{
    private List<CategoriesItem> categoriesItems = new List<CategoriesItem>();
    public List<CategoriesItem> Categories
    {
        get
        {
            return categoriesItems;
        }
        set
        {
            categoriesItems = value;
        }
    }

    public class CategoriesItem
    {
        private List<ProductsItem> products;
        public List<ProductsItem> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        private System.Int32? categoryID;
        public System.Int32? CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
            }
        }

        private System.String categoryName;
        public System.String CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                categoryName = value;
            }
        }

        private System.String description;
        public System.String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public CategoriesItem(System.Int32? categoryID, System.String categoryName, System.String description)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.description = description;
        }
    }

    private List<CustomersItem> customersItems = new List<CustomersItem>();
    public List<CustomersItem> Customers
    {
        get
        {
            return customersItems;
        }
        set
        {
            customersItems = value;
        }
    }

    public class CustomersItem
    {
        private System.String customerID;
        public System.String CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        private System.String companyName;
        public System.String CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        private System.String contactName;
        public System.String ContactName
        {
            get
            {
                return contactName;
            }
            set
            {
                contactName = value;
            }
        }

        private System.String contactTitle;
        public System.String ContactTitle
        {
            get
            {
                return contactTitle;
            }
            set
            {
                contactTitle = value;
            }
        }

        private System.String address;
        public System.String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        private System.String city;
        public System.String City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        private System.String region;
        public System.String Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }

        private System.String postalCode;
        public System.String PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }

        private System.String country;
        public System.String Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        private System.String phone;
        public System.String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        private System.String fax;
        public System.String Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }

        public CustomersItem(System.String customerID, System.String companyName, System.String contactName, System.String contactTitle, System.String address, System.String city, System.String region, System.String postalCode, System.String country, System.String phone, System.String fax)
        {
            this.customerID = customerID;
            this.companyName = companyName;
            this.contactName = contactName;
            this.contactTitle = contactTitle;
            this.address = address;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.phone = phone;
            this.fax = fax;
        }
    }

    private List<EmployeesItem> employeesItems = new List<EmployeesItem>();
    public List<EmployeesItem> Employees
    {
        get
        {
            return employeesItems;
        }
        set
        {
            employeesItems = value;
        }
    }

    public class EmployeesItem
    {
        private System.Int32? employeeID;
        public System.Int32? EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }

        private System.String lastName;
        public System.String LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        private System.String firstName;
        public System.String FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private System.String title;
        public System.String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        private System.DateTime? birthDate;
        public System.DateTime? BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        private System.DateTime? hireDate;
        public System.DateTime? HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                hireDate = value;
            }
        }

        private System.String address;
        public System.String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        private System.String city;
        public System.String City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        private System.String region;
        public System.String Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }

        private System.String postalCode;
        public System.String PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }

        private System.String country;
        public System.String Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        private System.String homePhone;
        public System.String HomePhone
        {
            get
            {
                return homePhone;
            }
            set
            {
                homePhone = value;
            }
        }

        private System.String notes;
        public System.String Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

        private System.Int32? reportsTo;
        public System.Int32? ReportsTo
        {
            get
            {
                return reportsTo;
            }
            set
            {
                reportsTo = value;
            }
        }

        public EmployeesItem(System.Int32? employeeID, System.String lastName, System.String firstName, System.String title, System.DateTime? birthDate, System.DateTime? hireDate, System.String address, System.String city, System.String region, System.String postalCode, System.String country, System.String homePhone, System.String notes, System.Int32? reportsTo)
        {
            this.employeeID = employeeID;
            this.lastName = lastName;
            this.firstName = firstName;
            this.title = title;
            this.birthDate = birthDate;
            this.hireDate = hireDate;
            this.address = address;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.homePhone = homePhone;
            this.notes = notes;
            this.reportsTo = reportsTo;
        }
    }

    private List<Order_DetailsItem> order_DetailsItems = new List<Order_DetailsItem>();
    public List<Order_DetailsItem> Order_Details
    {
        get
        {
            return order_DetailsItems;
        }
        set
        {
            order_DetailsItems = value;
        }
    }

    public class Order_DetailsItem
    {
        private List<OrdersItem> orders;
        public List<OrdersItem> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        private List<ProductsItem> products;
        public List<ProductsItem> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }        

        private System.Int32? orderID;
        public System.Int32? OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }

        private System.Int32? productID;
        public System.Int32? ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }

        private System.Decimal? unitPrice;
        public System.Decimal? UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        private System.Int16? quantity;
        public System.Int16? Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        private System.Single? discount;
        public System.Single? Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }

        public Order_DetailsItem(System.Int32? orderID, System.Int32? productID, System.Decimal? unitPrice, System.Int16? quantity, System.Single? discount)
        {
            this.orderID = orderID;
            this.productID = productID;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.discount = discount;
        }
    }

    private List<OrdersItem> ordersItems = new List<OrdersItem>();
    public List<OrdersItem> Orders
    {
        get
        {
            return ordersItems;
        }
        set
        {
            ordersItems = value;
        }
    }

    public class OrdersItem
    {
        private List<CustomersItem> customers;
        public List<CustomersItem> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
            }
        }

        private List<EmployeesItem> employees;
        public List<EmployeesItem> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
            }
        }

        private System.Int32? orderID;
        public System.Int32? OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }

        private System.String customerID;
        public System.String CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        private System.Int32? employeeID;
        public System.Int32? EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }

        private System.DateTime? orderDate;
        public System.DateTime? OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }

        private System.DateTime? requiredDate;
        public System.DateTime? RequiredDate
        {
            get
            {
                return requiredDate;
            }
            set
            {
                requiredDate = value;
            }
        }

        private System.DateTime? shippedDate;
        public System.DateTime? ShippedDate
        {
            get
            {
                return shippedDate;
            }
            set
            {
                shippedDate = value;
            }
        }

        private System.Int32? shipVia;
        public System.Int32? ShipVia
        {
            get
            {
                return shipVia;
            }
            set
            {
                shipVia = value;
            }
        }

        private System.Decimal? freight;
        public System.Decimal? Freight
        {
            get
            {
                return freight;
            }
            set
            {
                freight = value;
            }
        }

        private System.String shipName;
        public System.String ShipName
        {
            get
            {
                return shipName;
            }
            set
            {
                shipName = value;
            }
        }

        private System.String shipAddress;
        public System.String ShipAddress
        {
            get
            {
                return shipAddress;
            }
            set
            {
                shipAddress = value;
            }
        }

        private System.String shipCity;
        public System.String ShipCity
        {
            get
            {
                return shipCity;
            }
            set
            {
                shipCity = value;
            }
        }

        private System.String shipRegion;
        public System.String ShipRegion
        {
            get
            {
                return shipRegion;
            }
            set
            {
                shipRegion = value;
            }
        }

        private System.String shipPostalCode;
        public System.String ShipPostalCode
        {
            get
            {
                return shipPostalCode;
            }
            set
            {
                shipPostalCode = value;
            }
        }

        private System.String shipCountry;
        public System.String ShipCountry
        {
            get
            {
                return shipCountry;
            }
            set
            {
                shipCountry = value;
            }
        }

        public OrdersItem(System.Int32? orderID, System.String customerID, System.Int32? employeeID, System.DateTime? orderDate, System.DateTime? requiredDate, System.DateTime? shippedDate, System.Int32? shipVia, System.Decimal? freight, System.String shipName, System.String shipAddress, System.String shipCity, System.String shipRegion, System.String shipPostalCode, System.String shipCountry)
        {
            this.orderID = orderID;
            this.customerID = customerID;
            this.employeeID = employeeID;
            this.orderDate = orderDate;
            this.requiredDate = requiredDate;
            this.shippedDate = shippedDate;
            this.shipVia = shipVia;
            this.freight = freight;
            this.shipName = shipName;
            this.shipAddress = shipAddress;
            this.shipCity = shipCity;
            this.shipRegion = shipRegion;
            this.shipPostalCode = shipPostalCode;
            this.shipCountry = shipCountry;
        }
    }

    private List<ProductsItem> productsItems = new List<ProductsItem>();
    public List<ProductsItem> Products
    {
        get
        {
            return productsItems;
        }
        set
        {
            productsItems = value;
        }
    }

    public class ProductsItem
    {
        private List<Order_DetailsItem> orderDetails;
        public List<Order_DetailsItem> OrderDetails
        {
            get
            {
                return orderDetails;
            }
            set
            {
                orderDetails = value;
            }
        }

        private List<CategoriesItem> categories;
        public List<CategoriesItem> Categories
        {
            get
            {
                return categories;
            }
            set
            {
                categories = value;
            }
        }

        private System.Int32? productID;
        public System.Int32? ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }

        private System.String productName;
        public System.String ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        private System.Int32? supplierID;
        public System.Int32? SupplierID
        {
            get
            {
                return supplierID;
            }
            set
            {
                supplierID = value;
            }
        }

        private System.Int32? categoryID;
        public System.Int32? CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
            }
        }

        private System.String quantityPerUnit;
        public System.String QuantityPerUnit
        {
            get
            {
                return quantityPerUnit;
            }
            set
            {
                quantityPerUnit = value;
            }
        }

        private System.Decimal? unitPrice;
        public System.Decimal? UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        private System.Int16? unitsInStock;
        public System.Int16? UnitsInStock
        {
            get
            {
                return unitsInStock;
            }
            set
            {
                unitsInStock = value;
            }
        }

        public ProductsItem(System.Int32? productID, System.String productName, System.Int32? supplierID, System.Int32? categoryID, System.String quantityPerUnit, System.Decimal? unitPrice, System.Int16? unitsInStock)
        {
            this.productID = productID;
            this.productName = productName;
            this.supplierID = supplierID;
            this.categoryID = categoryID;
            this.quantityPerUnit = quantityPerUnit;
            this.unitPrice = unitPrice;
            this.unitsInStock = unitsInStock;
        }
    }

    private List<ShippersItem> shippersItems = new List<ShippersItem>();
    public List<ShippersItem> Shippers
    {
        get
        {
            return shippersItems;
        }
        set
        {
            shippersItems = value;
        }
    }

    public class ShippersItem
    {
        private System.Int32? shipperID;
        public System.Int32? ShipperID
        {
            get
            {
                return shipperID;
            }
            set
            {
                shipperID = value;
            }
        }

        private System.String companyName;
        public System.String CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        private System.String phone;
        public System.String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public ShippersItem(System.Int32? shipperID, System.String companyName, System.String phone)
        {
            this.shipperID = shipperID;
            this.companyName = companyName;
            this.phone = phone;
        }
    }

    private List<SuppliersItem> suppliersItems = new List<SuppliersItem>();
    public List<SuppliersItem> Suppliers
    {
        get
        {
            return suppliersItems;
        }
        set
        {
            suppliersItems = value;
        }
    }

    public class SuppliersItem
    {
        private System.Int32? supplierID;
        public System.Int32? SupplierID
        {
            get
            {
                return supplierID;
            }
            set
            {
                supplierID = value;
            }
        }

        private System.String companyName;
        public System.String CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        private System.String contactName;
        public System.String ContactName
        {
            get
            {
                return contactName;
            }
            set
            {
                contactName = value;
            }
        }

        private System.String contactTitle;
        public System.String ContactTitle
        {
            get
            {
                return contactTitle;
            }
            set
            {
                contactTitle = value;
            }
        }

        private System.String address;
        public System.String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        private System.String city;
        public System.String City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        private System.String region;
        public System.String Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }

        private System.String postalCode;
        public System.String PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }

        private System.String country;
        public System.String Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        private System.String phone;
        public System.String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        private System.String fax;
        public System.String Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }

        private System.String homePage;
        public System.String HomePage
        {
            get
            {
                return homePage;
            }
            set
            {
                homePage = value;
            }
        }

        public SuppliersItem(System.Int32? supplierID, System.String companyName, System.String contactName, System.String contactTitle, System.String address, System.String city, System.String region, System.String postalCode, System.String country, System.String phone, System.String fax, System.String homePage)
        {
            this.supplierID = supplierID;
            this.companyName = companyName;
            this.contactName = contactName;
            this.contactTitle = contactTitle;
            this.address = address;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.phone = phone;
            this.fax = fax;
            this.homePage = homePage;
        }
    }

    public Data()
    {
        this.Categories.Add(new CategoriesItem(1, "Beverages", "Soft drinks, coffees, teas, beers, and ales"));
        this.Categories.Add(new CategoriesItem(2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings"));
        this.Categories.Add(new CategoriesItem(3, "Confections", "Desserts, candies, and sweet breads"));
        this.Categories.Add(new CategoriesItem(4, "Dairy Products", "Cheeses"));
        this.Categories.Add(new CategoriesItem(5, "Grains/Cereals", "Breads, crackers, pasta, and cereal"));
        this.Categories.Add(new CategoriesItem(6, "Meat/Poultry", "Prepared meats"));
        this.Categories.Add(new CategoriesItem(7, "Produce", "Dried fruit and bean curd"));
        this.Categories.Add(new CategoriesItem(8, "Seafood", "Seaweed and fish"));
        this.Customers.Add(new CustomersItem("ALFKI", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", null, "12209", "Germany", "030-0074321", "030-0076545"));
        this.Customers.Add(new CustomersItem("ANATR", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Avda. de la Constitución 2222", "México D.F.", null, "05021", "Mexico", "(5) 555-4729", "(5) 555-3745"));
        this.Customers.Add(new CustomersItem("ANTON", "Antonio Moreno Taquería", "Antonio Moreno", "Owner", "Mataderos  2312", "México D.F.", null, "05023", "Mexico", "(5) 555-3932", null));
        this.Customers.Add(new CustomersItem("AROUT", "Around the Horn", "Thomas Hardy", "Sales Representative", "120 Hanover Sq.", "London", null, "WA1 1DP", "UK", "(171) 555-7788", "(171) 555-6750"));
        this.Customers.Add(new CustomersItem("BERGS", "Berglunds snabbköp", "Christina Berglund", "Order Administrator", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden", "0921-12 34 65", "0921-12 34 67"));
        this.Customers.Add(new CustomersItem("BLAUS", "Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Forsterstr. 57", "Mannheim", null, "68306", "Germany", "0621-08460", "0621-08924"));
        this.Customers.Add(new CustomersItem("BLONP", "Blondesddsl père et fils", "Frédérique Citeaux", "Marketing Manager", "24, place Kléber", "Strasbourg", null, "67000", "France", "88.60.15.31", "88.60.15.32"));
        this.Customers.Add(new CustomersItem("BOLID", "Bólido Comidas preparadas", "Martín Sommer", "Owner", "C/ Araquil, 67", "Madrid", null, "28023", "Spain", "(91) 555 22 82", "(91) 555 91 99"));
        this.Customers.Add(new CustomersItem("BONAP", "Bon app'", "Laurence Lebihan", "Owner", "12, rue des Bouchers", "Marseille", null, "13008", "France", "91.24.45.40", "91.24.45.41"));
        this.Customers.Add(new CustomersItem("BOTTM", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Accounting Manager", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada", "(604) 555-4729", "(604) 555-3745"));
        this.Customers.Add(new CustomersItem("BSBEV", "B's Beverages", "Victoria Ashworth", "Sales Representative", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK", "(171) 555-1212", null));
        this.Customers.Add(new CustomersItem("CACTU", "Cactus Comidas para llevar", "Patricio Simpson", "Sales Agent", "Cerrito 333", "Buenos Aires", null, "1010", "Argentina", "(1) 135-5555", "(1) 135-4892"));
        this.Customers.Add(new CustomersItem("CENTC", "Centro comercial Moctezuma", "Francisco Chang", "Marketing Manager", "Sierras de Granada 9993", "México D.F.", null, "05022", "Mexico", "(5) 555-3392", "(5) 555-7293"));
        this.Customers.Add(new CustomersItem("CHOPS", "Chop-suey Chinese", "Yang Wang", "Owner", "Hauptstr. 29", "Bern", null, "3012", "Switzerland", "0452-076545", null));
        this.Customers.Add(new CustomersItem("COMMI", "Comércio Mineiro", "Pedro Afonso", "Sales Associate", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil", "(11) 555-7647", null));
        this.Customers.Add(new CustomersItem("CONSH", "Consolidated Holdings", "Elizabeth Brown", "Sales Representative", "Berkeley Gardens 12  Brewery", "London", null, "WX1 6LT", "UK", "(171) 555-2282", "(171) 555-9199"));
        this.Customers.Add(new CustomersItem("WANDK", "Die Wandernde Kuh", "Rita Müller", "Sales Representative", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany", "0711-020361", "0711-035428"));
        this.Customers.Add(new CustomersItem("DRACD", "Drachenblut Delikatessen", "Sven Ottlieb", "Order Administrator", "Walserweg 21", "Aachen", null, "52066", "Germany", "0241-039123", "0241-059428"));
        this.Customers.Add(new CustomersItem("DUMON", "Du monde entier", "Janine Labrune", "Owner", "67, rue des Cinquante Otages", "Nantes", null, "44000", "France", "40.67.88.88", "40.67.89.89"));
        this.Customers.Add(new CustomersItem("EASTC", "Eastern Connection", "Ann Devon", "Sales Agent", "35 King George", "London", null, "WX3 6FW", "UK", "(171) 555-0297", "(171) 555-3373"));
        this.Customers.Add(new CustomersItem("ERNSH", "Ernst Handel", "Roland Mendel", "Sales Manager", "Kirchgasse 6", "Graz", null, "8010", "Austria", "7675-3425", "7675-3426"));
        this.Customers.Add(new CustomersItem("FAMIA", "Familia Arquibaldo", "Aria Cruz", "Marketing Assistant", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil", "(11) 555-9857", null));
        this.Customers.Add(new CustomersItem("FISSA", "FISSA Fabrica Inter. Salchichas S.A.", "Diego Roel", "Accounting Manager", "C/ Moralzarzal, 86", "Madrid", null, "28034", "Spain", "(91) 555 94 44", "(91) 555 55 93"));
        this.Customers.Add(new CustomersItem("FOLIG", "Folies gourmandes", "Martine Rancé", "Assistant Sales Agent", "184, chaussée de Tournai", "Lille", null, "59000", "France", "20.16.10.16", "20.16.10.17"));
        this.Customers.Add(new CustomersItem("FOLKO", "Folk och fä HB", "Maria Larsson", "Owner", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden", "0695-34 67 21", null));
        this.Customers.Add(new CustomersItem("FRANK", "Frankenversand", "Peter Franken", "Marketing Manager", "Berliner Platz 43", "München", null, "80805", "Germany", "089-0877310", "089-0877451"));
        this.Customers.Add(new CustomersItem("FRANR", "France restauration", "Carine Schmitt", "Marketing Manager", "54, rue Royale", "Nantes", null, "44000", "France", "40.32.21.21", "40.32.21.20"));
        this.Customers.Add(new CustomersItem("FRANS", "Franchi S.p.A.", "Paolo Accorti", "Sales Representative", "Via Monte Bianco 34", "Torino", null, "10100", "Italy", "011-4988260", "011-4988261"));
        this.Customers.Add(new CustomersItem("FURIB", "Furia Bacalhau e Frutos do Mar", "Lino Rodriguez", "Sales Manager", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal", "(1) 354-2534", "(1) 354-2535"));
        this.Customers.Add(new CustomersItem("GALED", "Galería del gastrónomo", "Eduardo Saavedra", "Marketing Manager", "Rambla de Cataluña, 23", "Barcelona", null, "08022", "Spain", "(93) 203 4560", "(93) 203 4561"));
        this.Customers.Add(new CustomersItem("GODOS", "Godos Cocina Típica", "José Pedro Freyre", "Sales Manager", "C/ Romero, 33", "Sevilla", null, "41101", "Spain", "(95) 555 82 82", null));
        this.Customers.Add(new CustomersItem("GOURL", "Gourmet Lanchonetes", "André Fonseca", "Sales Associate", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil", "(11) 555-9482", null));
        this.Customers.Add(new CustomersItem("GREAL", "Great Lakes Food Market", "Howard Snyder", "Marketing Manager", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA", "(503) 555-7555", null));
        this.Customers.Add(new CustomersItem("GROSR", "GROSELLA-Restaurante", "Manuel Pereira", "Owner", "5ª Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela", "(2) 283-2951", "(2) 283-3397"));
        this.Customers.Add(new CustomersItem("HANAR", "Hanari Carnes", "Mario Pontes", "Accounting Manager", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil", "(21) 555-0091", "(21) 555-8765"));
        this.Customers.Add(new CustomersItem("HILAA", "HILARION-Abastos", "Carlos Hernández", "Sales Representative", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela", "(5) 555-1340", "(5) 555-1948"));
        this.Customers.Add(new CustomersItem("HUNGC", "Hungry Coyote Import Store", "Yoshi Latimer", "Sales Representative", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA", "(503) 555-6874", "(503) 555-2376"));
        this.Customers.Add(new CustomersItem("HUNGO", "Hungry Owl All-Night Grocers", "Patricia McKenna", "Sales Associate", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland", "2967 542", "2967 3333"));
        this.Customers.Add(new CustomersItem("ISLAT", "Island Trading", "Helen Bennett", "Marketing Manager", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK", "(198) 555-8888", null));
        this.Customers.Add(new CustomersItem("KOENE", "Königlich Essen", "Philip Cramer", "Sales Associate", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany", "0555-09876", null));
        this.Customers.Add(new CustomersItem("LACOR", "La corne d'abondance", "Daniel Tonini", "Sales Representative", "67, avenue de l'Europe", "Versailles", null, "78000", "France", "30.59.84.10", "30.59.85.11"));
        this.Customers.Add(new CustomersItem("LAMAI", "La maison d'Asie", "Annette Roulet", "Sales Manager", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France", "61.77.61.10", "61.77.61.11"));
        this.Customers.Add(new CustomersItem("LAUGB", "Laughing Bacchus Wine Cellars", "Yoshi Tannamuri", "Marketing Assistant", "1900 Oak St.", "Vancouver", "BC", "V3F 2K1", "Canada", "(604) 555-3392", "(604) 555-7293"));
        this.Customers.Add(new CustomersItem("LAZYK", "Lazy K Kountry Store", "John Steel", "Marketing Manager", "12 Orchestra Terrace", "Walla Walla", "WA", "99362", "USA", "(509) 555-7969", "(509) 555-6221"));
        this.Customers.Add(new CustomersItem("LEHMS", "Lehmanns Marktstand", "Renate Messner", "Sales Representative", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany", "069-0245984", "069-0245874"));
        this.Customers.Add(new CustomersItem("LETSS", "Let's Stop N Shop", "Jaime Yorres", "Owner", "87 Polk St. Suite 5", "San Francisco", "CA", "94117", "USA", "(415) 555-5938", null));
        this.Customers.Add(new CustomersItem("LILAS", "LILA-Supermercado", "Carlos González", "Accounting Manager", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela", "(9) 331-6954", "(9) 331-7256"));
        this.Customers.Add(new CustomersItem("LINOD", "LINO-Delicateses", "Felipe Izquierdo", "Owner", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela", "(8) 34-56-12", "(8) 34-93-93"));
        this.Customers.Add(new CustomersItem("LONEP", "Lonesome Pine Restaurant", "Fran Wilson", "Sales Manager", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA", "(503) 555-9573", "(503) 555-9646"));
        this.Customers.Add(new CustomersItem("MAGAA", "Magazzini Alimentari Riuniti", "Giovanni Rovelli", "Marketing Manager", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy", "035-640230", "035-640231"));
        this.Customers.Add(new CustomersItem("MAISD", "Maison Dewey", "Catherine Dewey", "Sales Agent", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium", "(02) 201 24 67", "(02) 201 24 68"));
        this.Customers.Add(new CustomersItem("MEREP", "Mère Paillarde", "Jean Fresnière", "Marketing Assistant", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada", "(514) 555-8054", "(514) 555-8055"));
        this.Customers.Add(new CustomersItem("MORGK", "Morgenstern Gesundkost", "Alexander Feuer", "Marketing Assistant", "Heerstr. 22", "Leipzig", null, "04179", "Germany", "0342-023176", null));
        this.Customers.Add(new CustomersItem("NORTS", "North/South", "Simon Crowther", "Sales Associate", "South House 300 Queensbridge", "London", null, "SW7 1RZ", "UK", "(171) 555-7733", "(171) 555-2530"));
        this.Customers.Add(new CustomersItem("OCEAN", "Océano Atlántico Ltda.", "Yvonne Moncada", "Sales Agent", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", null, "1010", "Argentina", "(1) 135-5333", "(1) 135-5535"));
        this.Customers.Add(new CustomersItem("OLDWO", "Old World Delicatessen", "Rene Phillips", "Sales Representative", "2743 Bering St.", "Anchorage", "AK", "99508", "USA", "(907) 555-7584", "(907) 555-2880"));
        this.Customers.Add(new CustomersItem("OTTIK", "Ottilies Käseladen", "Henriette Pfalzheim", "Owner", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany", "0221-0644327", "0221-0765721"));
        this.Customers.Add(new CustomersItem("PARIS", "Paris spécialités", "Marie Bertrand", "Owner", "265, boulevard Charonne", "Paris", null, "75012", "France", "(1) 42.34.22.66", "(1) 42.34.22.77"));
        this.Customers.Add(new CustomersItem("PERIC", "Pericles Comidas clásicas", "Guillermo Fernández", "Sales Representative", "Calle Dr. Jorge Cash 321", "México D.F.", null, "05033", "Mexico", "(5) 552-3745", "(5) 545-3745"));
        this.Customers.Add(new CustomersItem("PICCO", "Piccolo und mehr", "Georg Pipps", "Sales Manager", "Geislweg 14", "Salzburg", null, "5020", "Austria", "6562-9722", "6562-9723"));
        this.Customers.Add(new CustomersItem("PRINI", "Princesa Isabel Vinhos", "Isabel de Castro", "Sales Representative", "Estrada da saúde n. 58", "Lisboa", null, "1756", "Portugal", "(1) 356-5634", null));
        this.Customers.Add(new CustomersItem("QUEDE", "Que Delícia", "Bernardo Batista", "Accounting Manager", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil", "(21) 555-4252", "(21) 555-4545"));
        this.Customers.Add(new CustomersItem("QUEEN", "Queen Cozinha", "Lúcia Carvalho", "Marketing Assistant", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil", "(11) 555-1189", null));
        this.Customers.Add(new CustomersItem("QUICK", "QUICK-Stop", "Horst Kloss", "Accounting Manager", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany", "0372-035188", null));
        this.Customers.Add(new CustomersItem("RANCH", "Rancho grande", "Sergio Gutiérrez", "Sales Representative", "Av. del Libertador 900", "Buenos Aires", null, "1010", "Argentina", "(1) 123-5555", "(1) 123-5556"));
        this.Customers.Add(new CustomersItem("RATTC", "Rattlesnake Canyon Grocery", "Paula Wilson", "Assistant Sales Representative", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA", "(505) 555-5939", "(505) 555-3620"));
        this.Customers.Add(new CustomersItem("REGGC", "Reggiani Caseifici", "Maurizio Moroni", "Sales Associate", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy", "0522-556721", "0522-556722"));
        this.Customers.Add(new CustomersItem("RICAR", "Ricardo Adocicados", "Janete Limeira", "Assistant Sales Agent", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil", "(21) 555-3412", null));
        this.Customers.Add(new CustomersItem("RICSU", "Richter Supermarkt", "Michael Holz", "Sales Manager", "Grenzacherweg 237", "Genève", null, "1203", "Switzerland", "0897-034214", null));
        this.Customers.Add(new CustomersItem("ROMEY", "Romero y tomillo", "Alejandra Camino", "Accounting Manager", "Gran Vía, 1", "Madrid", null, "28001", "Spain", "(91) 745 6200", "(91) 745 6210"));
        this.Customers.Add(new CustomersItem("SANTG", "Santé Gourmet", "Jonas Bergulfsen", "Owner", "Erling Skakkes gate 78", "Stavern", null, "4110", "Norway", "07-98 92 35", "07-98 92 47"));
        this.Customers.Add(new CustomersItem("SAVEA", "Save-a-lot Markets", "Jose Pavarotti", "Sales Representative", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA", "(208) 555-8097", null));
        this.Customers.Add(new CustomersItem("SEVES", "Seven Seas Imports", "Hari Kumar", "Sales Manager", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK", "(171) 555-1717", "(171) 555-5646"));
        this.Customers.Add(new CustomersItem("SIMOB", "Simons bistro", "Jytte Petersen", "Owner", "Vinbæltet 34", "Kobenhavn", null, "1734", "Denmark", "31 12 34 56", "31 13 35 57"));
        this.Customers.Add(new CustomersItem("SPECD", "Spécialités du monde", "Dominique Perrier", "Marketing Manager", "25, rue Lauriston", "Paris", null, "75016", "France", "(1) 47.55.60.10", "(1) 47.55.60.20"));
        this.Customers.Add(new CustomersItem("SPLIR", "Split Rail Beer & Ale", "Art Braunschweiger", "Sales Manager", "P.O. Box 555", "Lander", "WY", "82520", "USA", "(307) 555-4680", "(307) 555-6525"));
        this.Customers.Add(new CustomersItem("SUPRD", "Suprêmes délices", "Pascale Cartrain", "Accounting Manager", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium", "(071) 23 67 22 20", "(071) 23 67 22 21"));
        this.Customers.Add(new CustomersItem("THEBI", "The Big Cheese", "Liz Nixon", "Marketing Manager", "89 Jefferson Way Suite 2", "Portland", "OR", "97201", "USA", "(503) 555-3612", null));
        this.Customers.Add(new CustomersItem("THECR", "The Cracker Box", "Liu Wong", "Marketing Assistant", "55 Grizzly Peak Rd.", "Butte", "MT", "59801", "USA", "(406) 555-5834", "(406) 555-8083"));
        this.Customers.Add(new CustomersItem("TOMSP", "Toms Spezialitäten", "Karin Josephs", "Marketing Manager", "Luisenstr. 48", "Münster", null, "44087", "Germany", "0251-031259", "0251-035695"));
        this.Customers.Add(new CustomersItem("TORTU", "Tortuga Restaurante", "Miguel Angel Paolino", "Owner", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico", "(5) 555-2933", null));
        this.Customers.Add(new CustomersItem("TRADH", "Tradição Hipermercados", "Anabela Domingues", "Sales Representative", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil", "(11) 555-2167", "(11) 555-2168"));
        this.Customers.Add(new CustomersItem("TRAIH", "Trail's Head Gourmet Provisioners", "Helvetius Nagy", "Sales Associate", "722 DaVinci Blvd.", "Kirkland", "WA", "98034", "USA", "(206) 555-8257", "(206) 555-2174"));
        this.Customers.Add(new CustomersItem("VAFFE", "Vaffeljernet", "Palle Ibsen", "Sales Manager", "Smagsloget 45", "Århus", null, "8200", "Denmark", "86 21 32 43", "86 22 33 44"));
        this.Customers.Add(new CustomersItem("VICTE", "Victuailles en stock", "Mary Saveley", "Sales Agent", "2, rue du Commerce", "Lyon", null, "69004", "France", "78.32.54.86", "78.32.54.87"));
        this.Customers.Add(new CustomersItem("VINET", "Vins et alcools Chevalier", "Paul Henriot", "Accounting Manager", "59 rue de l'Abbaye", "Reims", null, "51100", "France", "26.47.15.10", "26.47.15.11"));        
        this.Customers.Add(new CustomersItem("WARTH", "Wartian Herkku", "Pirkko Koskitalo", "Accounting Manager", "Torikatu 38", "Oulu", null, "90110", "Finland", "981-443655", "981-443655"));
        this.Customers.Add(new CustomersItem("WELLI", "Wellington Importadora", "Paula Parente", "Sales Manager", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil", "(14) 555-8122", null));
        this.Customers.Add(new CustomersItem("WHITC", "White Clover Markets", "Karl Jablonski", "Owner", "305 - 14th Ave. S. Suite 3B", "Seattle", "WA", "98128", "USA", "(206) 555-4112", "(206) 555-4115"));
        this.Customers.Add(new CustomersItem("WILMK", "Wilman Kala", "Matti Karttunen", "Owner/Marketing Assistant", "Keskuskatu 45", "Helsinki", null, "21240", "Finland", "90-224 8858", "90-224 8858"));
        this.Customers.Add(new CustomersItem("WOLZA", "Wolski  Zajazd", "Zbyszek Piestrzeniewicz", "Owner", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland", "(26) 642-7012", "(26) 642-7012"));
        this.Employees.Add(new EmployeesItem(1, "Davolio", "Nancy", "Sales Representative", new DateTime(614708352000000000), new DateTime(628402752000000000), "507 - 20th Ave. E.Apt. 2A", "Seattle", "WA", "98122", "USA", "(206) 555-9857", "Education includes a BA in psychology from Colorado State University in 1970.  She also completed \"The Art of the Cold Call.\"  Nancy is a member of Toastmasters International.", 2));
        this.Employees.Add(new EmployeesItem(2, "Fuller", "Andrew", "Vice President, Sales", new DateTime(615717504000000000), new DateTime(628493472000000000), "908 W. Capital Way", "Tacoma", "WA", "98401", "USA", "(206) 555-9482", "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.", null));
        this.Employees.Add(new EmployeesItem(3, "Leverling", "Janet", "Sales Representative", new DateTime(619354944000000000), new DateTime(628376832000000000), "722 Moss Bay Blvd.", "Kirkland", "WA", "98033", "USA", "(206) 555-3412", "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992.", 2));
        this.Employees.Add(new EmployeesItem(4, "Peacock", "Margaret", "Sales Representative", new DateTime(611167680000000000), new DateTime(628719840000000000), "4110 Old Redmond Rd.", "Redmond", "WA", "98052", "USA", "(206) 555-8122", "Margaret holds a BA in English literature from Concordia College (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992.", 2));
        this.Employees.Add(new EmployeesItem(5, "Buchanan", "Steven", "Sales Manager", new DateTime(616675680000000000), new DateTime(628864128000000000), "14 Garrett Hill", "London", null, "SW1 8JR", "UK", "(71) 555-4848", "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses \"Successful Telemarketing\" and \"International Sales Management.\"  He is fluent in French.", 2));
        this.Employees.Add(new EmployeesItem(6, "Suyama", "Michael", "Sales Representative", new DateTime(619303968000000000), new DateTime(628864128000000000), "Coventry HouseMiner Rd.", "London", null, "EC2 7JR", "UK", "(71) 555-7773", "Michael is a graduate of Sussex University (MA, economics, 1983) and the University of California at Los Angeles (MBA, marketing, 1986).  He has also taken the courses \"Multi-Cultural Selling\" and \"Time Management for the Sales Professional.\"  He is fluent in Japanese and can read and write French, Portuguese, and Spanish.", 5));
        this.Employees.Add(new EmployeesItem(7, "King", "Robert", "Sales Representative", new DateTime(618328512000000000), new DateTime(628930656000000000), "Edgeham HollowWinchester Way", "London", null, "RG1 9SP", "UK", "(71) 555-5598", "Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan in 1992, the year he joined the company.  After completing a course entitled \"Selling in Europe,\" he was transferred to the London office in March 1993.", 5));
        this.Employees.Add(new EmployeesItem(8, "Callahan", "Laura", "Inside Sales Coordinator", new DateTime(617575968000000000), new DateTime(628984224000000000), "4726 - 11th Ave. N.E.", "Seattle", "WA", "98105", "USA", "(206) 555-1189", "Laura received a BA in psychology from the University of Washington.  She has also completed a course in business French.  She reads and writes French.", 2));
        this.Employees.Add(new EmployeesItem(9, "Dodsworth", "Anne", "Sales Representative", new DateTime(620116128000000000), new DateTime(629204544000000000), "7 Houndstooth Rd.", "London", null, "WG2 7LT", "UK", "(71) 555-4444", "Anne has a BA degree in English from St. Lawrence College.  She is fluent in French and German.", 5));
        this.Order_Details.Add(new Order_DetailsItem(10248, 11, 14M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10248, 42, 9.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10248, 72, 34.8M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10249, 14, 18.6M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10249, 51, 42.4M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10250, 41, 7.7M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10250, 51, 42.4M, 35, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10250, 65, 16.8M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10251, 22, 16.8M, 6, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10251, 57, 15.6M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10251, 65, 16.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10252, 20, 64.8M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10252, 33, 2M, 25, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10252, 60, 27.2M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10253, 31, 10M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10253, 39, 14.4M, 42, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10253, 49, 16M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10254, 24, 3.6M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10254, 55, 19.2M, 21, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10254, 74, 8M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10255, 2, 15.2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10255, 16, 13.9M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10255, 36, 15.2M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10255, 59, 44M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10256, 53, 26.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10256, 77, 10.4M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10257, 27, 35.1M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10257, 39, 14.4M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10257, 77, 10.4M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10258, 2, 15.2M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10258, 5, 17M, 65, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10258, 32, 25.6M, 6, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10259, 21, 8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10259, 37, 20.8M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10260, 41, 7.7M, 16, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10260, 57, 15.6M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10260, 62, 39.4M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10260, 70, 12M, 21, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10261, 21, 8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10261, 35, 14.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10262, 5, 17M, 12, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10262, 7, 24M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10262, 56, 30.4M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10263, 16, 13.9M, 60, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10263, 24, 3.6M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10263, 30, 20.7M, 60, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10263, 74, 8M, 36, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10264, 2, 15.2M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10264, 41, 7.7M, 25, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10265, 17, 31.2M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10265, 70, 12M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10266, 12, 30.4M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10267, 40, 14.7M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10267, 59, 44M, 70, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10267, 76, 14.4M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10268, 29, 99M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10268, 72, 27.8M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10269, 33, 2M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10269, 72, 27.8M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10270, 36, 15.2M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10270, 43, 36.8M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10271, 33, 2M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10272, 20, 64.8M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10272, 31, 10M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10272, 72, 27.8M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10273, 10, 24.8M, 24, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10273, 31, 10M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10273, 33, 2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10273, 40, 14.7M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10273, 76, 14.4M, 33, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10274, 71, 17.2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10274, 72, 27.8M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10275, 24, 3.6M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10275, 59, 44M, 6, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10276, 10, 24.8M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10276, 13, 4.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10277, 28, 36.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10277, 62, 39.4M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10278, 44, 15.5M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10278, 59, 44M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10278, 63, 35.1M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10278, 73, 12M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10279, 17, 31.2M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10280, 24, 3.6M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10280, 55, 19.2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10280, 75, 6.2M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10281, 19, 7.3M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10281, 24, 3.6M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10281, 35, 14.4M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10282, 30, 20.7M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10282, 57, 15.6M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10283, 15, 12.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10283, 19, 7.3M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10283, 60, 27.2M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10283, 72, 27.8M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10284, 27, 35.1M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10284, 44, 15.5M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10284, 60, 27.2M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10284, 67, 11.2M, 5, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10285, 1, 14.4M, 45, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10285, 40, 14.7M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10285, 53, 26.2M, 36, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10286, 35, 14.4M, 100, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10286, 62, 39.4M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10287, 16, 13.9M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10287, 34, 11.2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10287, 46, 9.6M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10288, 54, 5.9M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10288, 68, 10M, 3, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10289, 3, 8M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10289, 64, 26.6M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10290, 5, 17M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10290, 29, 99M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10290, 49, 16M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10290, 77, 10.4M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10291, 13, 4.8M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10291, 44, 15.5M, 24, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10291, 51, 42.4M, 2, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10292, 20, 64.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10293, 18, 50M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10293, 24, 3.6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10293, 63, 35.1M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10293, 75, 6.2M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10294, 1, 14.4M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10294, 17, 31.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10294, 43, 36.8M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10294, 60, 27.2M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10294, 75, 6.2M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10295, 56, 30.4M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10296, 11, 16.8M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10296, 16, 13.9M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10296, 69, 28.8M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10297, 39, 14.4M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10297, 72, 27.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10298, 2, 15.2M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10298, 36, 15.2M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10298, 59, 44M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10298, 62, 39.4M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10299, 19, 7.3M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10299, 70, 12M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10300, 66, 13.6M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10300, 68, 10M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10301, 40, 14.7M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10301, 56, 30.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10302, 17, 31.2M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10302, 28, 36.4M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10302, 43, 36.8M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10303, 40, 14.7M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10303, 65, 16.8M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10303, 68, 10M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10304, 49, 16M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10304, 59, 44M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10304, 71, 17.2M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10305, 18, 50M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10305, 29, 99M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10305, 39, 14.4M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10306, 30, 20.7M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10306, 53, 26.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10306, 54, 5.9M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10307, 62, 39.4M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10307, 68, 10M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10308, 69, 28.8M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10308, 70, 12M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10309, 4, 17.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10309, 6, 20M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10309, 42, 11.2M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10309, 43, 36.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10309, 71, 17.2M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10310, 16, 13.9M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10310, 62, 39.4M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10311, 42, 11.2M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10311, 69, 28.8M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10312, 28, 36.4M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10312, 43, 36.8M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10312, 53, 26.2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10312, 75, 6.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10313, 36, 15.2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10314, 32, 25.6M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10314, 58, 10.6M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10314, 62, 39.4M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10315, 34, 11.2M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10315, 70, 12M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10316, 41, 7.7M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10316, 62, 39.4M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10317, 1, 14.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10318, 41, 7.7M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10318, 76, 14.4M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10319, 17, 31.2M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10319, 28, 36.4M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10319, 76, 14.4M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10320, 71, 17.2M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10321, 35, 14.4M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10322, 52, 5.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10323, 15, 12.4M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10323, 25, 11.2M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10323, 39, 14.4M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10324, 16, 13.9M, 21, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10324, 35, 14.4M, 70, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10324, 46, 9.6M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10324, 59, 44M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10324, 63, 35.1M, 80, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10325, 6, 20M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10325, 13, 4.8M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10325, 14, 18.6M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10325, 31, 10M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10325, 72, 27.8M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10326, 4, 17.6M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10326, 57, 15.6M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10326, 75, 6.2M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10327, 2, 15.2M, 25, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10327, 11, 16.8M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10327, 30, 20.7M, 35, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10327, 58, 10.6M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10328, 59, 44M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10328, 65, 16.8M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10328, 68, 10M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10329, 19, 7.3M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10329, 30, 20.7M, 8, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10329, 38, 210.8M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10329, 56, 30.4M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10330, 26, 24.9M, 50, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10330, 72, 27.8M, 25, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10331, 54, 5.9M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10332, 18, 50M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10332, 42, 11.2M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10332, 47, 7.6M, 16, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10333, 14, 18.6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10333, 21, 8M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10333, 71, 17.2M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10334, 52, 5.6M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10334, 68, 10M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10335, 2, 15.2M, 7, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10335, 31, 10M, 25, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10335, 32, 25.6M, 6, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10335, 51, 42.4M, 48, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10336, 4, 17.6M, 18, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10337, 23, 7.2M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10337, 26, 24.9M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10337, 36, 15.2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10337, 37, 20.8M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10337, 72, 27.8M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10338, 17, 31.2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10338, 30, 20.7M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10339, 4, 17.6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10339, 17, 31.2M, 70, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10339, 62, 39.4M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10340, 18, 50M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10340, 41, 7.7M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10340, 43, 36.8M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10341, 33, 2M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10341, 59, 44M, 9, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10342, 2, 15.2M, 24, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10342, 31, 10M, 56, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10342, 36, 15.2M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10342, 55, 19.2M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10343, 64, 26.6M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10343, 68, 10M, 4, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10343, 76, 14.4M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10344, 4, 17.6M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10344, 8, 32M, 70, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10345, 8, 32M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10345, 19, 7.3M, 80, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10345, 42, 11.2M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10346, 17, 31.2M, 36, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10346, 56, 30.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10347, 25, 11.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10347, 39, 14.4M, 50, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10347, 40, 14.7M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10347, 75, 6.2M, 6, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10348, 1, 14.4M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10348, 23, 7.2M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10349, 54, 5.9M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10350, 50, 13M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10350, 69, 28.8M, 18, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10351, 38, 210.8M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10351, 41, 7.7M, 13, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10351, 44, 15.5M, 77, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10351, 65, 16.8M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10352, 24, 3.6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10352, 54, 5.9M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10353, 11, 16.8M, 12, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10353, 38, 210.8M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10354, 1, 14.4M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10354, 29, 99M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10355, 24, 3.6M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10355, 57, 15.6M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10356, 31, 10M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10356, 55, 19.2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10356, 69, 28.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10357, 10, 24.8M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10357, 26, 24.9M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10357, 60, 27.2M, 8, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10358, 24, 3.6M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10358, 34, 11.2M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10358, 36, 15.2M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10359, 16, 13.9M, 56, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10359, 31, 10M, 70, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10359, 60, 27.2M, 80, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10360, 28, 36.4M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10360, 29, 99M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10360, 38, 210.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10360, 49, 16M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10360, 54, 5.9M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10361, 39, 14.4M, 54, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10361, 60, 27.2M, 55, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10362, 25, 11.2M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10362, 51, 42.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10362, 54, 5.9M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10363, 31, 10M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10363, 75, 6.2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10363, 76, 14.4M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10364, 69, 28.8M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10364, 71, 17.2M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10365, 11, 16.8M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10366, 65, 16.8M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10366, 77, 10.4M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10367, 34, 11.2M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10367, 54, 5.9M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10367, 65, 16.8M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10367, 77, 10.4M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10368, 21, 8M, 5, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10368, 28, 36.4M, 13, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10368, 57, 15.6M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10368, 64, 26.6M, 35, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10369, 29, 99M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10369, 56, 30.4M, 18, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10370, 1, 14.4M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10370, 64, 26.6M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10370, 74, 8M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10371, 36, 15.2M, 6, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10372, 20, 64.8M, 12, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10372, 38, 210.8M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10372, 60, 27.2M, 70, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10372, 72, 27.8M, 42, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10373, 58, 10.6M, 80, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10373, 71, 17.2M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10374, 31, 10M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10374, 58, 10.6M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10375, 14, 18.6M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10375, 54, 5.9M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10376, 31, 10M, 42, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10377, 28, 36.4M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10377, 39, 14.4M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10378, 71, 17.2M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10379, 41, 7.7M, 8, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10379, 63, 35.1M, 16, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10379, 65, 16.8M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10380, 30, 20.7M, 18, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10380, 53, 26.2M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10380, 60, 27.2M, 6, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10380, 70, 12M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10381, 74, 8M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10382, 5, 17M, 32, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10382, 18, 50M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10382, 29, 99M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10382, 33, 2M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10382, 74, 8M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10383, 13, 4.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10383, 50, 13M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10383, 56, 30.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10384, 20, 64.8M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10384, 60, 27.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10385, 7, 24M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10385, 60, 27.2M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10385, 68, 10M, 8, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10386, 24, 3.6M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10386, 34, 11.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10387, 24, 3.6M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10387, 28, 36.4M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10387, 59, 44M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10387, 71, 17.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10388, 45, 7.6M, 15, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10388, 52, 5.6M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10388, 53, 26.2M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10389, 10, 24.8M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10389, 55, 19.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10389, 62, 39.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10389, 70, 12M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10390, 31, 10M, 60, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10390, 35, 14.4M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10390, 46, 9.6M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10390, 72, 27.8M, 24, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10391, 13, 4.8M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10392, 69, 28.8M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10393, 2, 15.2M, 25, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10393, 14, 18.6M, 42, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10393, 25, 11.2M, 7, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10393, 26, 24.9M, 70, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10393, 31, 10M, 32, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10394, 13, 4.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10394, 62, 39.4M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10395, 46, 9.6M, 28, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10395, 53, 26.2M, 70, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10395, 69, 28.8M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10396, 23, 7.2M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10396, 71, 17.2M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10396, 72, 27.8M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10397, 21, 8M, 10, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10397, 51, 42.4M, 18, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10398, 35, 14.4M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10398, 55, 19.2M, 120, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10399, 68, 10M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10399, 71, 17.2M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10399, 76, 14.4M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10399, 77, 10.4M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10400, 29, 99M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10400, 35, 14.4M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10400, 49, 16M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10401, 30, 20.7M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10401, 56, 30.4M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10401, 65, 16.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10401, 71, 17.2M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10402, 23, 7.2M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10402, 63, 35.1M, 65, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10403, 16, 13.9M, 21, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10403, 48, 10.2M, 70, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10404, 26, 24.9M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10404, 42, 11.2M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10404, 49, 16M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10405, 3, 8M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10406, 1, 14.4M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10406, 21, 8M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10406, 28, 36.4M, 42, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10406, 36, 15.2M, 5, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10406, 40, 14.7M, 2, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10407, 11, 16.8M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10407, 69, 28.8M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10407, 71, 17.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10408, 37, 20.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10408, 54, 5.9M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10408, 62, 39.4M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10409, 14, 18.6M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10409, 21, 8M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10410, 33, 2M, 49, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10410, 59, 44M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10411, 41, 7.7M, 25, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10411, 44, 15.5M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10411, 59, 44M, 9, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10412, 14, 18.6M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10413, 1, 14.4M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10413, 62, 39.4M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10413, 76, 14.4M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10414, 19, 7.3M, 18, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10414, 33, 2M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10415, 17, 31.2M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10415, 33, 2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10416, 19, 7.3M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10416, 53, 26.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10416, 57, 15.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10417, 38, 210.8M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10417, 46, 9.6M, 2, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10417, 68, 10M, 36, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10417, 77, 10.4M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10418, 2, 15.2M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10418, 47, 7.6M, 55, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10418, 61, 22.8M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10418, 74, 8M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10419, 60, 27.2M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10419, 69, 28.8M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10420, 9, 77.6M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10420, 13, 4.8M, 2, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10420, 70, 12M, 8, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10420, 73, 12M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10421, 19, 7.3M, 4, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10421, 26, 24.9M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10421, 53, 26.2M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10421, 77, 10.4M, 10, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10422, 26, 24.9M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10423, 31, 10M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10423, 59, 44M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10424, 35, 14.4M, 60, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10424, 38, 210.8M, 49, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10424, 68, 10M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10425, 55, 19.2M, 10, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10425, 76, 14.4M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10426, 56, 30.4M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10426, 64, 26.6M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10427, 14, 18.6M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10428, 46, 9.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10429, 50, 13M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10429, 63, 35.1M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10430, 17, 31.2M, 45, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10430, 21, 8M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10430, 56, 30.4M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10430, 59, 44M, 70, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10431, 17, 31.2M, 50, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10431, 40, 14.7M, 50, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10431, 47, 7.6M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10432, 26, 24.9M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10432, 54, 5.9M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10433, 56, 30.4M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10434, 11, 16.8M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10434, 76, 14.4M, 18, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10435, 2, 15.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10435, 22, 16.8M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10435, 72, 27.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10436, 46, 9.6M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10436, 56, 30.4M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10436, 64, 26.6M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10436, 75, 6.2M, 24, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10437, 53, 26.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10438, 19, 7.3M, 15, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10438, 34, 11.2M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10438, 57, 15.6M, 15, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10439, 12, 30.4M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10439, 16, 13.9M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10439, 64, 26.6M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10439, 74, 8M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10440, 2, 15.2M, 45, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10440, 16, 13.9M, 49, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10440, 29, 99M, 24, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10440, 61, 22.8M, 90, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10441, 27, 35.1M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10442, 11, 16.8M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10442, 54, 5.9M, 80, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10442, 66, 13.6M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10443, 11, 16.8M, 6, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10443, 28, 36.4M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10444, 17, 31.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10444, 26, 24.9M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10444, 35, 14.4M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10444, 41, 7.7M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10445, 39, 14.4M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10445, 54, 5.9M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10446, 19, 7.3M, 12, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10446, 24, 3.6M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10446, 31, 10M, 3, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10446, 52, 5.6M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10447, 19, 7.3M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10447, 65, 16.8M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10447, 71, 17.2M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10448, 26, 24.9M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10448, 40, 14.7M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10449, 10, 24.8M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10449, 52, 5.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10449, 62, 39.4M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10450, 10, 24.8M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10450, 54, 5.9M, 6, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10451, 55, 19.2M, 120, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10451, 64, 26.6M, 35, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10451, 65, 16.8M, 28, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10451, 77, 10.4M, 55, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10452, 28, 36.4M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10452, 44, 15.5M, 100, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10453, 48, 10.2M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10453, 70, 12M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10454, 16, 13.9M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10454, 33, 2M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10454, 46, 9.6M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10455, 39, 14.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10455, 53, 26.2M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10455, 61, 22.8M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10455, 71, 17.2M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10456, 21, 8M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10456, 49, 16M, 21, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10457, 59, 44M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10458, 26, 24.9M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10458, 28, 36.4M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10458, 43, 36.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10458, 56, 30.4M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10458, 71, 17.2M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10459, 7, 24M, 16, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10459, 46, 9.6M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10459, 72, 27.8M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10460, 68, 10M, 21, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10460, 75, 6.2M, 4, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10461, 21, 8M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10461, 30, 20.7M, 28, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10461, 55, 19.2M, 60, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10462, 13, 4.8M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10462, 23, 7.2M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10463, 19, 7.3M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10463, 42, 11.2M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10464, 4, 17.6M, 16, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10464, 43, 36.8M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10464, 56, 30.4M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10464, 60, 27.2M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10465, 24, 3.6M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10465, 29, 99M, 18, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10465, 40, 14.7M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10465, 45, 7.6M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10465, 50, 13M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10466, 11, 16.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10466, 46, 9.6M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10467, 24, 3.6M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10467, 25, 11.2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10468, 30, 20.7M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10468, 43, 36.8M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10469, 2, 15.2M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10469, 16, 13.9M, 35, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10469, 44, 15.5M, 2, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10470, 18, 50M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10470, 23, 7.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10470, 64, 26.6M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10471, 7, 24M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10471, 56, 30.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10472, 24, 3.6M, 80, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10472, 51, 42.4M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10473, 33, 2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10473, 71, 17.2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10474, 14, 18.6M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10474, 28, 36.4M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10474, 40, 14.7M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10474, 75, 6.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10475, 31, 10M, 35, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10475, 66, 13.6M, 60, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10475, 76, 14.4M, 42, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10476, 55, 19.2M, 2, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10476, 70, 12M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10477, 1, 14.4M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10477, 21, 8M, 21, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10477, 39, 14.4M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10478, 10, 24.8M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10479, 38, 210.8M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10479, 53, 26.2M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10479, 59, 44M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10479, 64, 26.6M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10480, 47, 7.6M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10480, 59, 44M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10481, 49, 16M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10481, 60, 27.2M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10482, 40, 14.7M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10483, 34, 11.2M, 35, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10483, 77, 10.4M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10484, 21, 8M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10484, 40, 14.7M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10484, 51, 42.4M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10485, 2, 15.2M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10485, 3, 8M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10485, 55, 19.2M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10485, 70, 12M, 60, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10486, 11, 16.8M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10486, 51, 42.4M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10486, 74, 8M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10487, 19, 7.3M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10487, 26, 24.9M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10487, 54, 5.9M, 24, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10488, 59, 44M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10488, 73, 12M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10489, 11, 16.8M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10489, 16, 13.9M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10490, 59, 44M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10490, 68, 10M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10490, 75, 6.2M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10491, 44, 15.5M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10491, 77, 10.4M, 7, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10492, 25, 11.2M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10492, 42, 11.2M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10493, 65, 16.8M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10493, 66, 13.6M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10493, 69, 28.8M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10494, 56, 30.4M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10495, 23, 7.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10495, 41, 7.7M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10495, 77, 10.4M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10496, 31, 10M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10497, 56, 30.4M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10497, 72, 27.8M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10497, 77, 10.4M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10498, 24, 4.5M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10498, 40, 18.4M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10498, 42, 14M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10499, 28, 45.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10499, 49, 20M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10500, 15, 15.5M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10500, 28, 45.6M, 8, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10501, 54, 7.45M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10502, 45, 9.5M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10502, 53, 32.8M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10502, 67, 14M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10503, 14, 23.25M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10503, 65, 21.05M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10504, 2, 19M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10504, 21, 10M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10504, 53, 32.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10504, 61, 28.5M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10505, 62, 49.3M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10506, 25, 14M, 18, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10506, 70, 15M, 14, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10507, 43, 46M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10507, 48, 12.75M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10508, 13, 6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10508, 39, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10509, 28, 45.6M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10510, 29, 123.79M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10510, 75, 7.75M, 36, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10511, 4, 22M, 50, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10511, 7, 30M, 50, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10511, 8, 40M, 10, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10512, 24, 4.5M, 10, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10512, 46, 12M, 9, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10512, 47, 9.5M, 6, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10512, 60, 34M, 12, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10513, 21, 10M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10513, 32, 32M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10513, 61, 28.5M, 15, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10514, 20, 81M, 39, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10514, 28, 45.6M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10514, 56, 38M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10514, 65, 21.05M, 39, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10514, 75, 7.75M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10515, 9, 97M, 16, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10515, 16, 17.45M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10515, 27, 43.9M, 120, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10515, 33, 2.5M, 16, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10515, 60, 34M, 84, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10516, 18, 62.5M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10516, 41, 9.65M, 80, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10516, 42, 14M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10517, 52, 7M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10517, 59, 55M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10517, 70, 15M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10518, 24, 4.5M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10518, 38, 263.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10518, 44, 19.45M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10519, 10, 31M, 16, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10519, 56, 38M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10519, 60, 34M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10520, 24, 4.5M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10520, 53, 32.8M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10521, 35, 18M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10521, 41, 9.65M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10521, 68, 12.5M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10522, 1, 18M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10522, 8, 40M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10522, 30, 25.89M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10522, 40, 18.4M, 25, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10523, 17, 39M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10523, 20, 81M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10523, 37, 26M, 18, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10523, 41, 9.65M, 6, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10524, 10, 31M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10524, 30, 25.89M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10524, 43, 46M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10524, 54, 7.45M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10525, 36, 19M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10525, 40, 18.4M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10526, 1, 18M, 8, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10526, 13, 6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10526, 56, 38M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10527, 4, 22M, 50, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10527, 36, 19M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10528, 11, 21M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10528, 33, 2.5M, 8, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10528, 72, 34.8M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10529, 55, 24M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10529, 68, 12.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10529, 69, 36M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10530, 17, 39M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10530, 43, 46M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10530, 61, 28.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10530, 76, 18M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10531, 59, 55M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10532, 30, 25.89M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10532, 66, 17M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10533, 4, 22M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10533, 72, 34.8M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10533, 73, 15M, 24, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10534, 30, 25.89M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10534, 40, 18.4M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10534, 54, 7.45M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10535, 11, 21M, 50, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10535, 40, 18.4M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10535, 57, 19.5M, 5, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10535, 59, 55M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10536, 12, 38M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10536, 31, 12.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10536, 33, 2.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10536, 60, 34M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10537, 31, 12.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10537, 51, 53M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10537, 58, 13.25M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10537, 72, 34.8M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10537, 73, 15M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10538, 70, 15M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10538, 72, 34.8M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10539, 13, 6M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10539, 21, 10M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10539, 33, 2.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10539, 49, 20M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10540, 3, 10M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10540, 26, 31.23M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10540, 38, 263.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10540, 68, 12.5M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10541, 24, 4.5M, 35, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10541, 38, 263.5M, 4, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10541, 65, 21.05M, 36, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10541, 71, 21.5M, 9, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10542, 11, 21M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10542, 54, 7.45M, 24, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10543, 12, 38M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10543, 23, 9M, 70, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10544, 28, 45.6M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10544, 67, 14M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10545, 11, 21M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10546, 7, 30M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10546, 35, 18M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10546, 62, 49.3M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10547, 32, 32M, 24, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10547, 36, 19M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10548, 34, 14M, 10, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10548, 41, 9.65M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10549, 31, 12.5M, 55, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10549, 45, 9.5M, 100, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10549, 51, 53M, 48, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10550, 17, 39M, 8, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10550, 19, 9.2M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10550, 21, 10M, 6, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10550, 61, 28.5M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10551, 16, 17.45M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10551, 35, 18M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10551, 44, 19.45M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10552, 69, 36M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10552, 75, 7.75M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10553, 11, 21M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10553, 16, 17.45M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10553, 22, 21M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10553, 31, 12.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10553, 35, 18M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10554, 16, 17.45M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10554, 23, 9M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10554, 62, 49.3M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10554, 77, 13M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10555, 14, 23.25M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10555, 19, 9.2M, 35, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10555, 24, 4.5M, 18, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10555, 51, 53M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10555, 56, 38M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10556, 72, 34.8M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10557, 64, 33.25M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10557, 75, 7.75M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10558, 47, 9.5M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10558, 51, 53M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10558, 52, 7M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10558, 53, 32.8M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10558, 73, 15M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10559, 41, 9.65M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10559, 55, 24M, 18, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10560, 30, 25.89M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10560, 62, 49.3M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10561, 44, 19.45M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10561, 51, 53M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10562, 33, 2.5M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10562, 62, 49.3M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10563, 36, 19M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10563, 52, 7M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10564, 17, 39M, 16, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10564, 31, 12.5M, 6, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10564, 55, 24M, 25, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10565, 24, 4.5M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10565, 64, 33.25M, 18, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10566, 11, 21M, 35, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10566, 18, 62.5M, 18, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10566, 76, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10567, 31, 12.5M, 60, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10567, 51, 53M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10567, 59, 55M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10568, 10, 31M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10569, 31, 12.5M, 35, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10569, 76, 18M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10570, 11, 21M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10570, 56, 38M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10571, 14, 23.25M, 11, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10571, 42, 14M, 28, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10572, 16, 17.45M, 12, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10572, 32, 32M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10572, 40, 18.4M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10572, 75, 7.75M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10573, 17, 39M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10573, 34, 14M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10573, 53, 32.8M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10574, 33, 2.5M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10574, 40, 18.4M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10574, 62, 49.3M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10574, 64, 33.25M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10575, 59, 55M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10575, 63, 43.9M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10575, 72, 34.8M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10575, 76, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10576, 1, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10576, 31, 12.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10576, 44, 19.45M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10577, 39, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10577, 75, 7.75M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10577, 77, 13M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10578, 35, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10578, 57, 19.5M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10579, 15, 15.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10579, 75, 7.75M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10580, 14, 23.25M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10580, 41, 9.65M, 9, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10580, 65, 21.05M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10581, 75, 7.75M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10582, 57, 19.5M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10582, 76, 18M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10583, 29, 123.79M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10583, 60, 34M, 24, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10583, 69, 36M, 10, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10584, 31, 12.5M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10585, 47, 9.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10586, 52, 7M, 4, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10587, 26, 31.23M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10587, 35, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10587, 77, 13M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10588, 18, 62.5M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10588, 42, 14M, 100, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10589, 35, 18M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10590, 1, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10590, 77, 13M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10591, 3, 10M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10591, 7, 30M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10591, 54, 7.45M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10592, 15, 15.5M, 25, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10592, 26, 31.23M, 5, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10593, 20, 81M, 21, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10593, 69, 36M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10593, 76, 18M, 4, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10594, 52, 7M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10594, 58, 13.25M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10595, 35, 18M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10595, 61, 28.5M, 120, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10595, 69, 36M, 65, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10596, 56, 38M, 5, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10596, 63, 43.9M, 24, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10596, 75, 7.75M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10597, 24, 4.5M, 35, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10597, 57, 19.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10597, 65, 21.05M, 12, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10598, 27, 43.9M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10598, 71, 21.5M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10599, 62, 49.3M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10600, 54, 7.45M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10600, 73, 15M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10601, 13, 6M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10601, 59, 55M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10602, 77, 13M, 5, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10603, 22, 21M, 48, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10603, 49, 20M, 25, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10604, 48, 12.75M, 6, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10604, 76, 18M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10605, 16, 17.45M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10605, 59, 55M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10605, 60, 34M, 70, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10605, 71, 21.5M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10606, 4, 22M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10606, 55, 24M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10606, 62, 49.3M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10607, 7, 30M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10607, 17, 39M, 100, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10607, 33, 2.5M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10607, 40, 18.4M, 42, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10607, 72, 34.8M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10608, 56, 38M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10609, 1, 18M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10609, 10, 31M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10609, 21, 10M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10610, 36, 19M, 21, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10611, 1, 18M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10611, 2, 19M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10611, 60, 34M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10612, 10, 31M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10612, 36, 19M, 55, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10612, 49, 20M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10612, 60, 34M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10612, 76, 18M, 80, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10613, 13, 6M, 8, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10613, 75, 7.75M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10614, 11, 21M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10614, 21, 10M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10614, 39, 18M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10615, 55, 24M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10616, 38, 263.5M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10616, 56, 38M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10616, 70, 15M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10616, 71, 21.5M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10617, 59, 55M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10618, 6, 25M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10618, 56, 38M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10618, 68, 12.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10619, 21, 10M, 42, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10619, 22, 21M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10620, 24, 4.5M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10620, 52, 7M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10621, 19, 9.2M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10621, 23, 9M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10621, 70, 15M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10621, 71, 21.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10622, 2, 19M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10622, 68, 12.5M, 18, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10623, 14, 23.25M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10623, 19, 9.2M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10623, 21, 10M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10623, 24, 4.5M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10623, 35, 18M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10624, 28, 45.6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10624, 29, 123.79M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10624, 44, 19.45M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10625, 14, 23.25M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10625, 42, 14M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10625, 60, 34M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10626, 53, 32.8M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10626, 60, 34M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10626, 71, 21.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10627, 62, 49.3M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10627, 73, 15M, 35, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10628, 1, 18M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10629, 29, 123.79M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10629, 64, 33.25M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10630, 55, 24M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10630, 76, 18M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10631, 75, 7.75M, 8, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10632, 2, 19M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10632, 33, 2.5M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10633, 12, 38M, 36, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10633, 13, 6M, 13, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10633, 26, 31.23M, 35, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10633, 62, 49.3M, 80, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10634, 7, 30M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10634, 18, 62.5M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10634, 51, 53M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10634, 75, 7.75M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10635, 4, 22M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10635, 5, 21.35M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10635, 22, 21M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10636, 4, 22M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10636, 58, 13.25M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10637, 11, 21M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10637, 50, 16.25M, 25, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10637, 56, 38M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10638, 45, 9.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10638, 65, 21.05M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10638, 72, 34.8M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10639, 18, 62.5M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10640, 69, 36M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10640, 70, 15M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10641, 2, 19M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10641, 40, 18.4M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10642, 21, 10M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10642, 61, 28.5M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10643, 28, 45.6M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10643, 39, 18M, 21, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10643, 46, 12M, 2, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10644, 18, 62.5M, 4, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10644, 43, 46M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10644, 46, 12M, 21, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10645, 18, 62.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10645, 36, 19M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10646, 1, 18M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10646, 10, 31M, 18, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10646, 71, 21.5M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10646, 77, 13M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10647, 19, 9.2M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10647, 39, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10648, 22, 21M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10648, 24, 4.5M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10649, 28, 45.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10649, 72, 34.8M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10650, 30, 25.89M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10650, 53, 32.8M, 25, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10650, 54, 7.45M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10651, 19, 9.2M, 12, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10651, 22, 21M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10652, 30, 25.89M, 2, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10652, 42, 14M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10653, 16, 17.45M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10653, 60, 34M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10654, 4, 22M, 12, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10654, 39, 18M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10654, 54, 7.45M, 6, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10655, 41, 9.65M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10656, 14, 23.25M, 3, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10656, 44, 19.45M, 28, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10656, 47, 9.5M, 6, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10657, 15, 15.5M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10657, 41, 9.65M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10657, 46, 12M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10657, 47, 9.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10657, 56, 38M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10657, 60, 34M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10658, 21, 10M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10658, 40, 18.4M, 70, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10658, 60, 34M, 55, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10658, 77, 13M, 70, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10659, 31, 12.5M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10659, 40, 18.4M, 24, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10659, 70, 15M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10660, 20, 81M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10661, 39, 18M, 3, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10661, 58, 13.25M, 49, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10662, 68, 12.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10663, 40, 18.4M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10663, 42, 14M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10663, 51, 53M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10664, 10, 31M, 24, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10664, 56, 38M, 12, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10664, 65, 21.05M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10665, 51, 53M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10665, 59, 55M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10665, 76, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10666, 29, 123.79M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10666, 65, 21.05M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10667, 69, 36M, 45, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10667, 71, 21.5M, 14, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10668, 31, 12.5M, 8, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10668, 55, 24M, 4, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10668, 64, 33.25M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10669, 36, 19M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10670, 23, 9M, 32, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10670, 46, 12M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10670, 67, 14M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10670, 73, 15M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10670, 75, 7.75M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10671, 16, 17.45M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10671, 62, 49.3M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10671, 65, 21.05M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10672, 38, 263.5M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10672, 71, 21.5M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10673, 16, 17.45M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10673, 42, 14M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10673, 43, 46M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10674, 23, 9M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10675, 14, 23.25M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10675, 53, 32.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10675, 58, 13.25M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10676, 10, 31M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10676, 19, 9.2M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10676, 44, 19.45M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10677, 26, 31.23M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10677, 33, 2.5M, 8, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10678, 12, 38M, 100, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10678, 33, 2.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10678, 41, 9.65M, 120, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10678, 54, 7.45M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10679, 59, 55M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10680, 16, 17.45M, 50, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10680, 31, 12.5M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10680, 42, 14M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10681, 19, 9.2M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10681, 21, 10M, 12, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10681, 64, 33.25M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10682, 33, 2.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10682, 66, 17M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10682, 75, 7.75M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10683, 52, 7M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10684, 40, 18.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10684, 47, 9.5M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10684, 60, 34M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10685, 10, 31M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10685, 41, 9.65M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10685, 47, 9.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10686, 17, 39M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10686, 26, 31.23M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10687, 9, 97M, 50, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10687, 29, 123.79M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10687, 36, 19M, 6, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10688, 10, 31M, 18, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10688, 28, 45.6M, 60, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10688, 34, 14M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10689, 1, 18M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10690, 56, 38M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10690, 77, 13M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10691, 1, 18M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10691, 29, 123.79M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10691, 43, 46M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10691, 44, 19.45M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10691, 62, 49.3M, 48, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10692, 63, 43.9M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10693, 9, 97M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10693, 54, 7.45M, 60, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10693, 69, 36M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10693, 73, 15M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10694, 7, 30M, 90, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10694, 59, 55M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10694, 70, 15M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10695, 8, 40M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10695, 12, 38M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10695, 24, 4.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10696, 17, 39M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10696, 46, 12M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10697, 19, 9.2M, 7, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10697, 35, 18M, 9, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10697, 58, 13.25M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10697, 70, 15M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10698, 11, 21M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10698, 17, 39M, 8, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10698, 29, 123.79M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10698, 65, 21.05M, 65, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10698, 70, 15M, 8, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10699, 47, 9.5M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10700, 1, 18M, 5, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10700, 34, 14M, 12, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10700, 68, 12.5M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10700, 71, 21.5M, 60, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10701, 59, 55M, 42, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10701, 71, 21.5M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10701, 76, 18M, 35, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10702, 3, 10M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10702, 76, 18M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10703, 2, 19M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10703, 59, 55M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10703, 73, 15M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10704, 4, 22M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10704, 24, 4.5M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10704, 48, 12.75M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10705, 31, 12.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10705, 32, 32M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10706, 16, 17.45M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10706, 43, 46M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10706, 59, 55M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10707, 55, 24M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10707, 57, 19.5M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10707, 70, 15M, 28, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10708, 5, 21.35M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10708, 36, 19M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10709, 8, 40M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10709, 51, 53M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10709, 60, 34M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10710, 19, 9.2M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10710, 47, 9.5M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10711, 19, 9.2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10711, 41, 9.65M, 42, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10711, 53, 32.8M, 120, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10712, 53, 32.8M, 3, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10712, 56, 38M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10713, 10, 31M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10713, 26, 31.23M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10713, 45, 9.5M, 110, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10713, 46, 12M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10714, 2, 19M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10714, 17, 39M, 27, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10714, 47, 9.5M, 50, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10714, 56, 38M, 18, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10714, 58, 13.25M, 12, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10715, 10, 31M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10715, 71, 21.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10716, 21, 10M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10716, 51, 53M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10716, 61, 28.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10717, 21, 10M, 32, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10717, 54, 7.45M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10717, 69, 36M, 25, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10718, 12, 38M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10718, 16, 17.45M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10718, 36, 19M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10718, 62, 49.3M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10719, 18, 62.5M, 12, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10719, 30, 25.89M, 3, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10719, 54, 7.45M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10720, 35, 18M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10720, 71, 21.5M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10721, 44, 19.45M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10722, 2, 19M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10722, 31, 12.5M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10722, 68, 12.5M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10722, 75, 7.75M, 42, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10723, 26, 31.23M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10724, 10, 31M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10724, 61, 28.5M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10725, 41, 9.65M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10725, 52, 7M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10725, 55, 24M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10726, 4, 22M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10726, 11, 21M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10727, 17, 39M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10727, 56, 38M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10727, 59, 55M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10728, 30, 25.89M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10728, 40, 18.4M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10728, 55, 24M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10728, 60, 34M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10729, 1, 18M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10729, 21, 10M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10729, 50, 16.25M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10730, 16, 17.45M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10730, 31, 12.5M, 3, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10730, 65, 21.05M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10731, 21, 10M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10731, 51, 53M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10732, 76, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10733, 14, 23.25M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10733, 28, 45.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10733, 52, 7M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10734, 6, 25M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10734, 30, 25.89M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10734, 76, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10735, 61, 28.5M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10735, 77, 13M, 2, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10736, 65, 21.05M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10736, 75, 7.75M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10737, 13, 6M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10737, 41, 9.65M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10738, 16, 17.45M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10739, 36, 19M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10739, 52, 7M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10740, 28, 45.6M, 5, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10740, 35, 18M, 35, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10740, 45, 9.5M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10740, 56, 38M, 14, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10741, 2, 19M, 15, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10742, 3, 10M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10742, 60, 34M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10742, 72, 34.8M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10743, 46, 12M, 28, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10744, 40, 18.4M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10745, 18, 62.5M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10745, 44, 19.45M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10745, 59, 55M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10745, 72, 34.8M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10746, 13, 6M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10746, 42, 14M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10746, 62, 49.3M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10746, 69, 36M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10747, 31, 12.5M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10747, 41, 9.65M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10747, 63, 43.9M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10747, 69, 36M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10748, 23, 9M, 44, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10748, 40, 18.4M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10748, 56, 38M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10749, 56, 38M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10749, 59, 55M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10749, 76, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10750, 14, 23.25M, 5, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10750, 45, 9.5M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10750, 59, 55M, 25, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10751, 26, 31.23M, 12, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10751, 30, 25.89M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10751, 50, 16.25M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10751, 73, 15M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10752, 1, 18M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10752, 69, 36M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10753, 45, 9.5M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10753, 74, 10M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10754, 40, 18.4M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10755, 47, 9.5M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10755, 56, 38M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10755, 57, 19.5M, 14, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10755, 69, 36M, 25, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10756, 18, 62.5M, 21, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10756, 36, 19M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10756, 68, 12.5M, 6, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10756, 69, 36M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10757, 34, 14M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10757, 59, 55M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10757, 62, 49.3M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10757, 64, 33.25M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10758, 26, 31.23M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10758, 52, 7M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10758, 70, 15M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10759, 32, 32M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10760, 25, 14M, 12, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10760, 27, 43.9M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10760, 43, 46M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10761, 25, 14M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10761, 75, 7.75M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10762, 39, 18M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10762, 47, 9.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10762, 51, 53M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10762, 56, 38M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10763, 21, 10M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10763, 22, 21M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10763, 24, 4.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10764, 3, 10M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10764, 39, 18M, 130, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10765, 65, 21.05M, 80, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10766, 2, 19M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10766, 7, 30M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10766, 68, 12.5M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10767, 42, 14M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10768, 22, 21M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10768, 31, 12.5M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10768, 60, 34M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10768, 71, 21.5M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10769, 41, 9.65M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10769, 52, 7M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10769, 61, 28.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10769, 62, 49.3M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10770, 11, 21M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10771, 71, 21.5M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10772, 29, 123.79M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10772, 59, 55M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10773, 17, 39M, 33, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10773, 31, 12.5M, 70, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10773, 75, 7.75M, 7, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10774, 31, 12.5M, 2, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10774, 66, 17M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10775, 10, 31M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10775, 67, 14M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10776, 31, 12.5M, 16, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10776, 42, 14M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10776, 45, 9.5M, 27, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10776, 51, 53M, 120, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10777, 42, 14M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10778, 41, 9.65M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10779, 16, 17.45M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10779, 62, 49.3M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10780, 70, 15M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10780, 77, 13M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10781, 54, 7.45M, 3, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10781, 56, 38M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10781, 74, 10M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10782, 31, 12.5M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10783, 31, 12.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10783, 38, 263.5M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10784, 36, 19M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10784, 39, 18M, 2, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10784, 72, 34.8M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10785, 10, 31M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10785, 75, 7.75M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10786, 8, 40M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10786, 30, 25.89M, 15, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10786, 75, 7.75M, 42, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10787, 2, 19M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10787, 29, 123.79M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10788, 19, 9.2M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10788, 75, 7.75M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10789, 18, 62.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10789, 35, 18M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10789, 63, 43.9M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10789, 68, 12.5M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10790, 7, 30M, 3, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10790, 56, 38M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10791, 29, 123.79M, 14, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10791, 41, 9.65M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10792, 2, 19M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10792, 54, 7.45M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10792, 68, 12.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10793, 41, 9.65M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10793, 52, 7M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10794, 14, 23.25M, 15, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10794, 54, 7.45M, 6, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10795, 16, 17.45M, 65, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10795, 17, 39M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10796, 26, 31.23M, 21, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10796, 44, 19.45M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10796, 64, 33.25M, 35, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10796, 69, 36M, 24, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10797, 11, 21M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10798, 62, 49.3M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10798, 72, 34.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10799, 13, 6M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10799, 24, 4.5M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10799, 59, 55M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10800, 11, 21M, 50, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10800, 51, 53M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10800, 54, 7.45M, 7, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10801, 17, 39M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10801, 29, 123.79M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10802, 30, 25.89M, 25, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10802, 51, 53M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10802, 55, 24M, 60, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10802, 62, 49.3M, 5, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10803, 19, 9.2M, 24, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10803, 25, 14M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10803, 59, 55M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10804, 10, 31M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10804, 28, 45.6M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10804, 49, 20M, 4, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10805, 34, 14M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10805, 38, 263.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10806, 2, 19M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10806, 65, 21.05M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10806, 74, 10M, 15, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10807, 40, 18.4M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10808, 56, 38M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10808, 76, 18M, 50, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10809, 52, 7M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10810, 13, 6M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10810, 25, 14M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10810, 70, 15M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10811, 19, 9.2M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10811, 23, 9M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10811, 40, 18.4M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10812, 31, 12.5M, 16, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10812, 72, 34.8M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10812, 77, 13M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10813, 2, 19M, 12, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10813, 46, 12M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10814, 41, 9.65M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10814, 43, 46M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10814, 48, 12.75M, 8, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10814, 61, 28.5M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10815, 33, 2.5M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10816, 38, 263.5M, 30, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10816, 62, 49.3M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10817, 26, 31.23M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10817, 38, 263.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10817, 40, 18.4M, 60, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10817, 62, 49.3M, 25, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10818, 32, 32M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10818, 41, 9.65M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10819, 43, 46M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10819, 75, 7.75M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10820, 56, 38M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10821, 35, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10821, 51, 53M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10822, 62, 49.3M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10822, 70, 15M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10823, 11, 21M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10823, 57, 19.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10823, 59, 55M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10823, 77, 13M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10824, 41, 9.65M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10824, 70, 15M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10825, 26, 31.23M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10825, 53, 32.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10826, 31, 12.5M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10826, 57, 19.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10827, 10, 31M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10827, 39, 18M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10828, 20, 81M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10828, 38, 263.5M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10829, 2, 19M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10829, 8, 40M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10829, 13, 6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10829, 60, 34M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10830, 6, 25M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10830, 39, 18M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10830, 60, 34M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10830, 68, 12.5M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10831, 19, 9.2M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10831, 35, 18M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10831, 38, 263.5M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10831, 43, 46M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10832, 13, 6M, 3, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10832, 25, 14M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10832, 44, 19.45M, 16, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10832, 64, 33.25M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10833, 7, 30M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10833, 31, 12.5M, 9, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10833, 53, 32.8M, 9, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10834, 29, 123.79M, 8, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10834, 30, 25.89M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10835, 59, 55M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10835, 77, 13M, 2, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10836, 22, 21M, 52, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10836, 35, 18M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10836, 57, 19.5M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10836, 60, 34M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10836, 64, 33.25M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10837, 13, 6M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10837, 40, 18.4M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10837, 47, 9.5M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10837, 76, 18M, 21, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10838, 1, 18M, 4, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10838, 18, 62.5M, 25, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10838, 36, 19M, 50, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10839, 58, 13.25M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10839, 72, 34.8M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10840, 25, 14M, 6, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10840, 39, 18M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10841, 10, 31M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10841, 56, 38M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10841, 59, 55M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10841, 77, 13M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10842, 11, 21M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10842, 43, 46M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10842, 68, 12.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10842, 70, 15M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10843, 51, 53M, 4, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10844, 22, 21M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10845, 23, 9M, 70, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10845, 35, 18M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10845, 42, 14M, 42, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10845, 58, 13.25M, 60, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10845, 64, 33.25M, 48, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10846, 4, 22M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10846, 70, 15M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10846, 74, 10M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10847, 1, 18M, 80, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10847, 19, 9.2M, 12, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10847, 37, 26M, 60, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10847, 45, 9.5M, 36, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10847, 60, 34M, 45, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10847, 71, 21.5M, 55, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10848, 5, 21.35M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10848, 9, 97M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10849, 3, 10M, 49, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10849, 26, 31.23M, 18, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10850, 25, 14M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10850, 33, 2.5M, 4, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10850, 70, 15M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10851, 2, 19M, 5, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10851, 25, 14M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10851, 57, 19.5M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10851, 59, 55M, 42, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10852, 2, 19M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10852, 17, 39M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10852, 62, 49.3M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10853, 18, 62.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10854, 10, 31M, 100, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10854, 13, 6M, 65, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10855, 16, 17.45M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10855, 31, 12.5M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10855, 56, 38M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10855, 65, 21.05M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10856, 2, 19M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10856, 42, 14M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10857, 3, 10M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10857, 26, 31.23M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10857, 29, 123.79M, 10, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10858, 7, 30M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10858, 27, 43.9M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10858, 70, 15M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10859, 24, 4.5M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10859, 54, 7.45M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10859, 64, 33.25M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10860, 51, 53M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10860, 76, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10861, 17, 39M, 42, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10861, 18, 62.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10861, 21, 10M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10861, 33, 2.5M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10861, 62, 49.3M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10862, 11, 21M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10862, 52, 7M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10863, 1, 18M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10863, 58, 13.25M, 12, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10864, 35, 18M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10864, 67, 14M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10865, 38, 263.5M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10865, 39, 18M, 80, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10866, 2, 19M, 21, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10866, 24, 4.5M, 6, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10866, 30, 25.89M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10867, 53, 32.8M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10868, 26, 31.23M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10868, 35, 18M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10868, 49, 20M, 42, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10869, 1, 18M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10869, 11, 21M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10869, 23, 9M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10869, 68, 12.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10870, 35, 18M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10870, 51, 53M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10871, 6, 25M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10871, 16, 17.45M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10871, 17, 39M, 16, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10872, 55, 24M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10872, 62, 49.3M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10872, 64, 33.25M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10872, 65, 21.05M, 21, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10873, 21, 10M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10873, 28, 45.6M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10874, 10, 31M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10875, 19, 9.2M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10875, 47, 9.5M, 21, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10875, 49, 20M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10876, 46, 12M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10876, 64, 33.25M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10877, 16, 17.45M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10877, 18, 62.5M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10878, 20, 81M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10879, 40, 18.4M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10879, 65, 21.05M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10879, 76, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10880, 23, 9M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10880, 61, 28.5M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10880, 70, 15M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10881, 73, 15M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10882, 42, 14M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10882, 49, 20M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10882, 54, 7.45M, 32, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10883, 24, 4.5M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10884, 21, 10M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10884, 56, 38M, 21, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10884, 65, 21.05M, 12, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10885, 2, 19M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10885, 24, 4.5M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10885, 70, 15M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10885, 77, 13M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10886, 10, 31M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10886, 31, 12.5M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10886, 77, 13M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10887, 25, 14M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10888, 2, 19M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10888, 68, 12.5M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10889, 11, 21M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10889, 38, 263.5M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10890, 17, 39M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10890, 34, 14M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10890, 41, 9.65M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10891, 30, 25.89M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10892, 59, 55M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10893, 8, 40M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10893, 24, 4.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10893, 29, 123.79M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10893, 30, 25.89M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10893, 36, 19M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10894, 13, 6M, 28, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10894, 69, 36M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10894, 75, 7.75M, 120, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10895, 24, 4.5M, 110, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10895, 39, 18M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10895, 40, 18.4M, 91, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10895, 60, 34M, 100, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10896, 45, 9.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10896, 56, 38M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10897, 29, 123.79M, 80, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10897, 30, 25.89M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10898, 13, 6M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10899, 39, 18M, 8, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10900, 70, 15M, 3, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10901, 41, 9.65M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10901, 71, 21.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10902, 55, 24M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10902, 62, 49.3M, 6, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10903, 13, 6M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10903, 65, 21.05M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10903, 68, 12.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10904, 58, 13.25M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10904, 62, 49.3M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10905, 1, 18M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10906, 61, 28.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10907, 75, 7.75M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10908, 7, 30M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10908, 52, 7M, 14, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10909, 7, 30M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10909, 16, 17.45M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10909, 41, 9.65M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10910, 19, 9.2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10910, 49, 20M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10910, 61, 28.5M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10911, 1, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10911, 17, 39M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10911, 67, 14M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10912, 11, 21M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10912, 29, 123.79M, 60, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10913, 4, 22M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10913, 33, 2.5M, 40, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10913, 58, 13.25M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10914, 71, 21.5M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10915, 17, 39M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10915, 33, 2.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10915, 54, 7.45M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10916, 16, 17.45M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10916, 32, 32M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10916, 57, 19.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10917, 30, 25.89M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10917, 60, 34M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10918, 1, 18M, 60, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10918, 60, 34M, 25, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10919, 16, 17.45M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10919, 25, 14M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10919, 40, 18.4M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10920, 50, 16.25M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10921, 35, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10921, 63, 43.9M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10922, 17, 39M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10922, 24, 4.5M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10923, 42, 14M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10923, 43, 46M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10923, 67, 14M, 24, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10924, 10, 31M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10924, 28, 45.6M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10924, 75, 7.75M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10925, 36, 19M, 25, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10925, 52, 7M, 12, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10926, 11, 21M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10926, 13, 6M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10926, 19, 9.2M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10926, 72, 34.8M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10927, 20, 81M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10927, 52, 7M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10927, 76, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10928, 47, 9.5M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10928, 76, 18M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10929, 21, 10M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10929, 75, 7.75M, 49, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10929, 77, 13M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10930, 21, 10M, 36, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10930, 27, 43.9M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10930, 55, 24M, 25, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10930, 58, 13.25M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10931, 13, 6M, 42, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10931, 57, 19.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10932, 16, 17.45M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10932, 62, 49.3M, 14, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10932, 72, 34.8M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10932, 75, 7.75M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10933, 53, 32.8M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10933, 61, 28.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10934, 6, 25M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10935, 1, 18M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10935, 18, 62.5M, 4, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10935, 23, 9M, 8, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10936, 36, 19M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10937, 28, 45.6M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10937, 34, 14M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10938, 13, 6M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10938, 43, 46M, 24, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10938, 60, 34M, 49, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10938, 71, 21.5M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10939, 2, 19M, 10, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10939, 67, 14M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10940, 7, 30M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10940, 13, 6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10941, 31, 12.5M, 44, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10941, 62, 49.3M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10941, 68, 12.5M, 80, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10941, 72, 34.8M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10942, 49, 20M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10943, 13, 6M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10943, 22, 21M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10943, 46, 12M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10944, 11, 21M, 5, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10944, 44, 19.45M, 18, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10944, 56, 38M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10945, 13, 6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10945, 31, 12.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10946, 10, 31M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10946, 24, 4.5M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10946, 77, 13M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10947, 59, 55M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10948, 50, 16.25M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10948, 51, 53M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10948, 55, 24M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10949, 6, 25M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10949, 10, 31M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10949, 17, 39M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10949, 62, 49.3M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10950, 4, 22M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10951, 33, 2.5M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10951, 41, 9.65M, 6, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10951, 75, 7.75M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10952, 6, 25M, 16, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10952, 28, 45.6M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10953, 20, 81M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10953, 31, 12.5M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10954, 16, 17.45M, 28, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10954, 31, 12.5M, 25, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10954, 45, 9.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10954, 60, 34M, 24, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10955, 75, 7.75M, 12, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10956, 21, 10M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10956, 47, 9.5M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10956, 51, 53M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10957, 30, 25.89M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10957, 35, 18M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10957, 64, 33.25M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10958, 5, 21.35M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10958, 7, 30M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10958, 72, 34.8M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10959, 75, 7.75M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10960, 24, 4.5M, 10, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10960, 41, 9.65M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10961, 52, 7M, 6, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10961, 76, 18M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10962, 7, 30M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10962, 13, 6M, 77, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10962, 53, 32.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10962, 69, 36M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10962, 76, 18M, 44, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10963, 60, 34M, 2, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10964, 18, 62.5M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10964, 38, 263.5M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10964, 69, 36M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10965, 51, 53M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10966, 37, 26M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10966, 56, 38M, 12, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10966, 62, 49.3M, 12, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10967, 19, 9.2M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10967, 49, 20M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10968, 12, 38M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10968, 24, 4.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10968, 64, 33.25M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10969, 46, 12M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10970, 52, 7M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10971, 29, 123.79M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10972, 17, 39M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10972, 33, 2.5M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10973, 26, 31.23M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10973, 41, 9.65M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10973, 75, 7.75M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10974, 63, 43.9M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10975, 8, 40M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10975, 75, 7.75M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10976, 28, 45.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10977, 39, 18M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10977, 47, 9.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10977, 51, 53M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10977, 63, 43.9M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10978, 8, 40M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10978, 21, 10M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10978, 40, 18.4M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10978, 44, 19.45M, 6, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10979, 7, 30M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10979, 12, 38M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10979, 24, 4.5M, 80, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10979, 27, 43.9M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10979, 31, 12.5M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10979, 63, 43.9M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10980, 75, 7.75M, 40, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10981, 38, 263.5M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10982, 7, 30M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10982, 43, 46M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10983, 13, 6M, 84, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10983, 57, 19.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10984, 16, 17.45M, 55, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10984, 24, 4.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10984, 36, 19M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10985, 16, 17.45M, 36, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10985, 18, 62.5M, 8, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10985, 32, 32M, 35, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10986, 11, 21M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10986, 20, 81M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10986, 76, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10986, 77, 13M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10987, 7, 30M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10987, 43, 46M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10987, 72, 34.8M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10988, 7, 30M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10988, 62, 49.3M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(10989, 6, 25M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10989, 11, 21M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10989, 41, 9.65M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10990, 21, 10M, 65, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10990, 34, 14M, 60, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10990, 55, 24M, 65, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10990, 61, 28.5M, 66, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(10991, 2, 19M, 50, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10991, 70, 15M, 20, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10991, 76, 18M, 90, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(10992, 72, 34.8M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10993, 29, 123.79M, 50, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10993, 41, 9.65M, 35, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10994, 59, 55M, 18, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10995, 51, 53M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10995, 60, 34M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10996, 42, 14M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10997, 32, 32M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10997, 46, 12M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10997, 52, 7M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(10998, 24, 4.5M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10998, 61, 28.5M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10998, 74, 10M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10998, 75, 7.75M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(10999, 41, 9.65M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10999, 51, 53M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(10999, 77, 13M, 21, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11000, 4, 22M, 25, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11000, 24, 4.5M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11000, 77, 13M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11001, 7, 30M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11001, 22, 21M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11001, 46, 12M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11001, 55, 24M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11002, 13, 6M, 56, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11002, 35, 18M, 15, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11002, 42, 14M, 24, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11002, 55, 24M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11003, 1, 18M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11003, 40, 18.4M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11003, 52, 7M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11004, 26, 31.23M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11004, 76, 18M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11005, 1, 18M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11005, 59, 55M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11006, 1, 18M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11006, 29, 123.79M, 2, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11007, 8, 40M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11007, 29, 123.79M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11007, 42, 14M, 14, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11008, 28, 45.6M, 70, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11008, 34, 14M, 90, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11008, 71, 21.5M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11009, 24, 4.5M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11009, 36, 19M, 18, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11009, 60, 34M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11010, 7, 30M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11010, 24, 4.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11011, 58, 13.25M, 40, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11011, 71, 21.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11012, 19, 9.2M, 50, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11012, 60, 34M, 36, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11012, 71, 21.5M, 60, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11013, 23, 9M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11013, 42, 14M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11013, 45, 9.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11013, 68, 12.5M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11014, 41, 9.65M, 28, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11015, 30, 25.89M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11015, 77, 13M, 18, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11016, 31, 12.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11016, 36, 19M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11017, 3, 10M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11017, 59, 55M, 110, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11017, 70, 15M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11018, 12, 38M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11018, 18, 62.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11018, 56, 38M, 5, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11019, 46, 12M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11019, 49, 20M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11020, 10, 31M, 24, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11021, 2, 19M, 11, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11021, 20, 81M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11021, 26, 31.23M, 63, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11021, 51, 53M, 44, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11021, 72, 34.8M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11022, 19, 9.2M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11022, 69, 36M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11023, 7, 30M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11023, 43, 46M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11024, 26, 31.23M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11024, 33, 2.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11024, 65, 21.05M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11024, 71, 21.5M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11025, 1, 18M, 10, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11025, 13, 6M, 20, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11026, 18, 62.5M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11026, 51, 53M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11027, 24, 4.5M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11027, 62, 49.3M, 21, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11028, 55, 24M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11028, 59, 55M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11029, 56, 38M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11029, 63, 43.9M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11030, 2, 19M, 100, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11030, 5, 21.35M, 70, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11030, 29, 123.79M, 60, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11030, 59, 55M, 100, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11031, 1, 18M, 45, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11031, 13, 6M, 80, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11031, 24, 4.5M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11031, 64, 33.25M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11031, 71, 21.5M, 16, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11032, 36, 19M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11032, 38, 263.5M, 25, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11032, 59, 55M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11033, 53, 32.8M, 70, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11033, 69, 36M, 36, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11034, 21, 10M, 15, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11034, 44, 19.45M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11034, 61, 28.5M, 6, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11035, 1, 18M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11035, 35, 18M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11035, 42, 14M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11035, 54, 7.45M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11036, 13, 6M, 7, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11036, 59, 55M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11037, 70, 15M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11038, 40, 18.4M, 5, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11038, 52, 7M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11038, 71, 21.5M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11039, 28, 45.6M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11039, 35, 18M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11039, 49, 20M, 60, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11039, 57, 19.5M, 28, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11040, 21, 10M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11041, 2, 19M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11041, 63, 43.9M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11042, 44, 19.45M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11042, 61, 28.5M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11043, 11, 21M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11044, 62, 49.3M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11045, 33, 2.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11045, 51, 53M, 24, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11046, 12, 38M, 20, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11046, 32, 32M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11046, 35, 18M, 18, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11047, 1, 18M, 25, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11047, 5, 21.35M, 30, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11048, 68, 12.5M, 42, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11049, 2, 19M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11049, 12, 38M, 4, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11050, 76, 18M, 50, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11051, 24, 4.5M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11052, 43, 46M, 30, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11052, 61, 28.5M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11053, 18, 62.5M, 35, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11053, 32, 32M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11053, 64, 33.25M, 25, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11054, 33, 2.5M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11054, 67, 14M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11055, 24, 4.5M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11055, 25, 14M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11055, 51, 53M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11055, 57, 19.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11056, 7, 30M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11056, 55, 24M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11056, 60, 34M, 50, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11057, 70, 15M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11058, 21, 10M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11058, 60, 34M, 21, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11058, 61, 28.5M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11059, 13, 6M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11059, 17, 39M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11059, 60, 34M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11060, 60, 34M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11060, 77, 13M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11061, 60, 34M, 15, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11062, 53, 32.8M, 10, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11062, 70, 15M, 12, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11063, 34, 14M, 30, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11063, 40, 18.4M, 40, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11063, 41, 9.65M, 30, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11064, 17, 39M, 77, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11064, 41, 9.65M, 12, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11064, 53, 32.8M, 25, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11064, 55, 24M, 4, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11064, 68, 12.5M, 55, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11065, 30, 25.89M, 4, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11065, 54, 7.45M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11066, 16, 17.45M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11066, 19, 9.2M, 42, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11066, 34, 14M, 35, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11067, 41, 9.65M, 9, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11068, 28, 45.6M, 8, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11068, 43, 46M, 36, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11068, 77, 13M, 28, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11069, 39, 18M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11070, 1, 18M, 40, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11070, 2, 19M, 20, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11070, 16, 17.45M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11070, 31, 12.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11071, 7, 30M, 15, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11071, 13, 6M, 10, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11072, 2, 19M, 8, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11072, 41, 9.65M, 40, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11072, 50, 16.25M, 22, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11072, 64, 33.25M, 130, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11073, 11, 21M, 10, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11073, 24, 4.5M, 20, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11074, 16, 17.45M, 14, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11075, 2, 19M, 10, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11075, 46, 12M, 30, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11075, 76, 18M, 2, 0.15f));
        this.Order_Details.Add(new Order_DetailsItem(11076, 6, 25M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11076, 14, 23.25M, 20, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11076, 19, 9.2M, 10, 0.25f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 2, 19M, 24, 0.2f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 3, 10M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 4, 22M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 6, 25M, 1, 0.02f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 7, 30M, 1, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 8, 40M, 2, 0.1f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 10, 31M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 12, 38M, 2, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 13, 6M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 14, 23.25M, 1, 0.03f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 16, 17.45M, 2, 0.03f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 20, 81M, 1, 0.04f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 23, 9M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 32, 32M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 39, 18M, 2, 0.05f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 41, 9.65M, 3, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 46, 12M, 3, 0.02f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 52, 7M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 55, 24M, 2, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 60, 34M, 2, 0.06f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 64, 33.25M, 2, 0.03f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 66, 17M, 1, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 73, 15M, 2, 0.01f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 75, 7.75M, 4, 0f));
        this.Order_Details.Add(new Order_DetailsItem(11077, 77, 13M, 2, 0f));
        this.Orders.Add(new OrdersItem(10248, "VINET", 5, new DateTime(629720352000000000), new DateTime(629744544000000000), new DateTime(629730720000000000), 3, 32.38M, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", null, "51100", "France"));
        this.Orders.Add(new OrdersItem(10249, "TOMSP", 6, new DateTime(629721216000000000), new DateTime(629757504000000000), new DateTime(629725536000000000), 1, 11.61M, "Toms Spezialitäten", "Luisenstr. 48", "Münster", null, "44087", "Germany"));
        this.Orders.Add(new OrdersItem(10250, "HANAR", 4, new DateTime(629723808000000000), new DateTime(629748000000000000), new DateTime(629727264000000000), 2, 65.83M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10251, "VICTE", 3, new DateTime(629723808000000000), new DateTime(629748000000000000), new DateTime(629729856000000000), 1, 41.34M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10252, "SUPRD", 4, new DateTime(629724672000000000), new DateTime(629748864000000000), new DateTime(629726400000000000), 2, 51.3M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10253, "HANAR", 3, new DateTime(629725536000000000), new DateTime(629737632000000000), new DateTime(629730720000000000), 2, 58.17M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10254, "CHOPS", 5, new DateTime(629726400000000000), new DateTime(629750592000000000), new DateTime(629736768000000000), 2, 22.98M, "Chop-suey Chinese", "Hauptstr. 31", "Bern", null, "3012", "Switzerland"));
        this.Orders.Add(new OrdersItem(10255, "RICSU", 9, new DateTime(629727264000000000), new DateTime(629751456000000000), new DateTime(629729856000000000), 3, 148.33M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(10256, "WELLI", 3, new DateTime(629729856000000000), new DateTime(629754048000000000), new DateTime(629731584000000000), 2, 13.97M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10257, "HILAA", 4, new DateTime(629730720000000000), new DateTime(629754912000000000), new DateTime(629735904000000000), 3, 81.91M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10258, "ERNSH", 1, new DateTime(629731584000000000), new DateTime(629755776000000000), new DateTime(629736768000000000), 1, 140.51M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10259, "CENTC", 4, new DateTime(629732448000000000), new DateTime(629756640000000000), new DateTime(629738496000000000), 3, 3.25M, "Centro comercial Moctezuma", "Sierras de Granada 9993", "México D.F.", null, "05022", "Mexico"));
        this.Orders.Add(new OrdersItem(10260, "OTTIK", 4, new DateTime(629733312000000000), new DateTime(629757504000000000), new DateTime(629741952000000000), 1, 55.09M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(10261, "QUEDE", 4, new DateTime(629733312000000000), new DateTime(629757504000000000), new DateTime(629742816000000000), 2, 3.05M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10262, "RATTC", 8, new DateTime(629735904000000000), new DateTime(629760096000000000), new DateTime(629738496000000000), 3, 48.29M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10263, "ERNSH", 9, new DateTime(629736768000000000), new DateTime(629760960000000000), new DateTime(629743680000000000), 3, 146.06M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10264, "FOLKO", 6, new DateTime(629737632000000000), new DateTime(629761824000000000), new DateTime(629763552000000000), 3, 3.67M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10265, "BLONP", 2, new DateTime(629738496000000000), new DateTime(629762688000000000), new DateTime(629754048000000000), 1, 55.28M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10266, "WARTH", 3, new DateTime(629739360000000000), new DateTime(629775648000000000), new DateTime(629743680000000000), 3, 25.73M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10267, "FRANK", 4, new DateTime(629741952000000000), new DateTime(629766144000000000), new DateTime(629748864000000000), 1, 208.58M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10268, "GROSR", 8, new DateTime(629742816000000000), new DateTime(629767008000000000), new DateTime(629745408000000000), 3, 66.29M, "GROSELLA-Restaurante", "5ª Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela"));
        this.Orders.Add(new OrdersItem(10269, "WHITC", 5, new DateTime(629743680000000000), new DateTime(629755776000000000), new DateTime(629751456000000000), 1, 4.56M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10270, "WARTH", 1, new DateTime(629744544000000000), new DateTime(629768736000000000), new DateTime(629745408000000000), 1, 136.54M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10271, "SPLIR", 6, new DateTime(629744544000000000), new DateTime(629768736000000000), new DateTime(629769600000000000), 2, 4.54M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10272, "RATTC", 6, new DateTime(629745408000000000), new DateTime(629769600000000000), new DateTime(629748864000000000), 2, 98.03M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10273, "QUICK", 3, new DateTime(629748000000000000), new DateTime(629772192000000000), new DateTime(629754048000000000), 3, 76.07M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10274, "VINET", 6, new DateTime(629748864000000000), new DateTime(629773056000000000), new DateTime(629757504000000000), 1, 6.01M, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", null, "51100", "France"));
        this.Orders.Add(new OrdersItem(10275, "MAGAA", 1, new DateTime(629749728000000000), new DateTime(629773920000000000), new DateTime(629751456000000000), 1, 26.93M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10276, "TORTU", 8, new DateTime(629750592000000000), new DateTime(629762688000000000), new DateTime(629755776000000000), 3, 13.84M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10277, "MORGK", 2, new DateTime(629751456000000000), new DateTime(629775648000000000), new DateTime(629754912000000000), 3, 125.77M, "Morgenstern Gesundkost", "Heerstr. 22", "Leipzig", null, "04179", "Germany"));
        this.Orders.Add(new OrdersItem(10278, "BERGS", 8, new DateTime(629754048000000000), new DateTime(629778240000000000), new DateTime(629757504000000000), 2, 92.69M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10279, "LEHMS", 8, new DateTime(629754912000000000), new DateTime(629779104000000000), new DateTime(629757504000000000), 2, 25.83M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10280, "BERGS", 2, new DateTime(629755776000000000), new DateTime(629779968000000000), new DateTime(629780832000000000), 1, 8.98M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10281, "ROMEY", 4, new DateTime(629755776000000000), new DateTime(629767872000000000), new DateTime(629761824000000000), 1, 2.94M, "Romero y tomillo", "Gran Vía, 1", "Madrid", null, "28001", "Spain"));
        this.Orders.Add(new OrdersItem(10282, "ROMEY", 4, new DateTime(629756640000000000), new DateTime(629780832000000000), new DateTime(629761824000000000), 1, 12.69M, "Romero y tomillo", "Gran Vía, 1", "Madrid", null, "28001", "Spain"));
        this.Orders.Add(new OrdersItem(10283, "LILAS", 3, new DateTime(629757504000000000), new DateTime(629781696000000000), new DateTime(629763552000000000), 3, 84.81M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10284, "LEHMS", 4, new DateTime(629760096000000000), new DateTime(629784288000000000), new DateTime(629767008000000000), 1, 76.56M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10285, "QUICK", 1, new DateTime(629760960000000000), new DateTime(629785152000000000), new DateTime(629766144000000000), 2, 76.83M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10286, "QUICK", 8, new DateTime(629761824000000000), new DateTime(629786016000000000), new DateTime(629769600000000000), 3, 229.24M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10287, "RICAR", 8, new DateTime(629762688000000000), new DateTime(629786880000000000), new DateTime(629767872000000000), 3, 12.76M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10288, "REGGC", 4, new DateTime(629763552000000000), new DateTime(629787744000000000), new DateTime(629773056000000000), 1, 7.45M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10289, "BSBEV", 7, new DateTime(629766144000000000), new DateTime(629790336000000000), new DateTime(629767872000000000), 3, 22.77M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10290, "COMMI", 8, new DateTime(629767008000000000), new DateTime(629791200000000000), new DateTime(629773056000000000), 1, 79.7M, "Comércio Mineiro", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"));
        this.Orders.Add(new OrdersItem(10291, "QUEDE", 6, new DateTime(629767008000000000), new DateTime(629791200000000000), new DateTime(629773920000000000), 2, 6.4M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10292, "TRADH", 1, new DateTime(629767872000000000), new DateTime(629792064000000000), new DateTime(629772192000000000), 2, 1.35M, "Tradiçao Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10293, "TORTU", 1, new DateTime(629768736000000000), new DateTime(629792928000000000), new DateTime(629779968000000000), 3, 21.18M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10294, "RATTC", 4, new DateTime(629769600000000000), new DateTime(629793792000000000), new DateTime(629774784000000000), 2, 147.26M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10295, "VINET", 2, new DateTime(629772192000000000), new DateTime(629796384000000000), new DateTime(629779104000000000), 2, 1.15M, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", null, "51100", "France"));
        this.Orders.Add(new OrdersItem(10296, "LILAS", 6, new DateTime(629773056000000000), new DateTime(629797248000000000), new DateTime(629779968000000000), 1, 0.12M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10297, "BLONP", 5, new DateTime(629773920000000000), new DateTime(629810208000000000), new DateTime(629779104000000000), 2, 5.74M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10298, "HUNGO", 6, new DateTime(629774784000000000), new DateTime(629798976000000000), new DateTime(629779968000000000), 2, 168.22M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10299, "RICAR", 4, new DateTime(629775648000000000), new DateTime(629799840000000000), new DateTime(629781696000000000), 2, 29.76M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10300, "MAGAA", 2, new DateTime(629778240000000000), new DateTime(629802432000000000), new DateTime(629786016000000000), 2, 17.68M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10301, "WANDK", 8, new DateTime(629778240000000000), new DateTime(629802432000000000), new DateTime(629785152000000000), 2, 45.08M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10302, "SUPRD", 4, new DateTime(629779104000000000), new DateTime(629803296000000000), new DateTime(629804160000000000), 2, 6.27M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10303, "GODOS", 7, new DateTime(629779968000000000), new DateTime(629804160000000000), new DateTime(629786016000000000), 2, 107.83M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(10304, "TORTU", 1, new DateTime(629780832000000000), new DateTime(629805024000000000), new DateTime(629785152000000000), 2, 63.79M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10305, "OLDWO", 8, new DateTime(629781696000000000), new DateTime(629805888000000000), new DateTime(629804160000000000), 3, 257.62M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10306, "ROMEY", 1, new DateTime(629784288000000000), new DateTime(629808480000000000), new DateTime(629790336000000000), 3, 7.56M, "Romero y tomillo", "Gran Vía, 1", "Madrid", null, "28001", "Spain"));
        this.Orders.Add(new OrdersItem(10307, "LONEP", 2, new DateTime(629785152000000000), new DateTime(629809344000000000), new DateTime(629792064000000000), 2, 0.56M, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
        this.Orders.Add(new OrdersItem(10308, "ANATR", 7, new DateTime(629786016000000000), new DateTime(629810208000000000), new DateTime(629791200000000000), 3, 1.61M, "Ana Trujillo Emparedados y helados", "Avda. de la Constitución 2222", "México D.F.", null, "05021", "Mexico"));
        this.Orders.Add(new OrdersItem(10309, "HUNGO", 3, new DateTime(629786880000000000), new DateTime(629811072000000000), new DateTime(629816256000000000), 1, 47.3M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10310, "THEBI", 8, new DateTime(629787744000000000), new DateTime(629811936000000000), new DateTime(629793792000000000), 2, 17.52M, "The Big Cheese", "89 Jefferson Way Suite 2", "Portland", "OR", "97201", "USA"));
        this.Orders.Add(new OrdersItem(10311, "DUMON", 1, new DateTime(629787744000000000), new DateTime(629799840000000000), new DateTime(629792928000000000), 3, 24.69M, "Du monde entier", "67, rue des Cinquante Otages", "Nantes", null, "44000", "France"));
        this.Orders.Add(new OrdersItem(10312, "WANDK", 2, new DateTime(629790336000000000), new DateTime(629814528000000000), new DateTime(629798976000000000), 2, 40.26M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10313, "QUICK", 2, new DateTime(629791200000000000), new DateTime(629815392000000000), new DateTime(629799840000000000), 2, 1.96M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10314, "RATTC", 1, new DateTime(629792064000000000), new DateTime(629816256000000000), new DateTime(629799840000000000), 2, 74.16M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10315, "ISLAT", 4, new DateTime(629792928000000000), new DateTime(629817120000000000), new DateTime(629798976000000000), 2, 41.76M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10316, "RATTC", 1, new DateTime(629793792000000000), new DateTime(629817984000000000), new DateTime(629803296000000000), 3, 150.15M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10317, "LONEP", 6, new DateTime(629796384000000000), new DateTime(629820576000000000), new DateTime(629805024000000000), 1, 12.69M, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
        this.Orders.Add(new OrdersItem(10318, "ISLAT", 8, new DateTime(629797248000000000), new DateTime(629821440000000000), new DateTime(629799840000000000), 2, 4.73M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10319, "TORTU", 7, new DateTime(629798112000000000), new DateTime(629822304000000000), new DateTime(629805888000000000), 3, 64.5M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10320, "WARTH", 5, new DateTime(629798976000000000), new DateTime(629811072000000000), new DateTime(629811936000000000), 3, 34.57M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10321, "ISLAT", 3, new DateTime(629798976000000000), new DateTime(629823168000000000), new DateTime(629805888000000000), 2, 3.43M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10322, "PERIC", 7, new DateTime(629799840000000000), new DateTime(629824032000000000), new DateTime(629816256000000000), 3, 0.4M, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10323, "KOENE", 4, new DateTime(629802432000000000), new DateTime(629826624000000000), new DateTime(629808480000000000), 1, 4.88M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10324, "SAVEA", 9, new DateTime(629803296000000000), new DateTime(629827488000000000), new DateTime(629805024000000000), 1, 214.27M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10325, "KOENE", 1, new DateTime(629804160000000000), new DateTime(629816256000000000), new DateTime(629808480000000000), 3, 64.86M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10326, "BOLID", 4, new DateTime(629805024000000000), new DateTime(629829216000000000), new DateTime(629808480000000000), 2, 77.92M, "Bólido Comidas preparadas", "C/ Araquil, 67", "Madrid", null, "28023", "Spain"));
        this.Orders.Add(new OrdersItem(10327, "FOLKO", 2, new DateTime(629805888000000000), new DateTime(629830080000000000), new DateTime(629808480000000000), 1, 63.36M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10328, "FURIB", 4, new DateTime(629808480000000000), new DateTime(629832672000000000), new DateTime(629811072000000000), 3, 87.03M, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal"));
        this.Orders.Add(new OrdersItem(10329, "SPLIR", 4, new DateTime(629809344000000000), new DateTime(629845632000000000), new DateTime(629816256000000000), 2, 191.67M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10330, "LILAS", 3, new DateTime(629810208000000000), new DateTime(629834400000000000), new DateTime(629820576000000000), 1, 12.75M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10331, "BONAP", 9, new DateTime(629810208000000000), new DateTime(629846496000000000), new DateTime(629814528000000000), 1, 10.19M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10332, "MEREP", 3, new DateTime(629811072000000000), new DateTime(629847360000000000), new DateTime(629814528000000000), 2, 52.84M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10333, "WARTH", 5, new DateTime(629811936000000000), new DateTime(629836128000000000), new DateTime(629817984000000000), 3, 0.59M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10334, "VICTE", 8, new DateTime(629814528000000000), new DateTime(629838720000000000), new DateTime(629820576000000000), 2, 8.56M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10335, "HUNGO", 7, new DateTime(629815392000000000), new DateTime(629839584000000000), new DateTime(629817120000000000), 2, 42.11M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10336, "PRINI", 7, new DateTime(629816256000000000), new DateTime(629840448000000000), new DateTime(629817984000000000), 2, 15.51M, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", null, "1756", "Portugal"));
        this.Orders.Add(new OrdersItem(10337, "FRANK", 4, new DateTime(629817120000000000), new DateTime(629841312000000000), new DateTime(629821440000000000), 3, 108.26M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10338, "OLDWO", 4, new DateTime(629817984000000000), new DateTime(629842176000000000), new DateTime(629821440000000000), 3, 84.21M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10339, "MEREP", 2, new DateTime(629820576000000000), new DateTime(629844768000000000), new DateTime(629826624000000000), 2, 15.66M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10340, "BONAP", 1, new DateTime(629821440000000000), new DateTime(629845632000000000), new DateTime(629830080000000000), 3, 166.31M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10341, "SIMOB", 7, new DateTime(629821440000000000), new DateTime(629845632000000000), new DateTime(629827488000000000), 3, 26.78M, "Simons bistro", "Vinbæltet 34", "Kobenhavn", null, "1734", "Denmark"));
        this.Orders.Add(new OrdersItem(10342, "FRANK", 4, new DateTime(629822304000000000), new DateTime(629834400000000000), new DateTime(629826624000000000), 2, 54.83M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10343, "LEHMS", 4, new DateTime(629823168000000000), new DateTime(629847360000000000), new DateTime(629828352000000000), 1, 110.37M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10344, "WHITC", 4, new DateTime(629824032000000000), new DateTime(629848224000000000), new DateTime(629827488000000000), 2, 23.29M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10345, "QUICK", 2, new DateTime(629826624000000000), new DateTime(629850816000000000), new DateTime(629832672000000000), 2, 249.06M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10346, "RATTC", 3, new DateTime(629827488000000000), new DateTime(629863776000000000), new DateTime(629830080000000000), 3, 142.08M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10347, "FAMIA", 4, new DateTime(629828352000000000), new DateTime(629852544000000000), new DateTime(629830080000000000), 3, 3.1M, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10348, "WANDK", 4, new DateTime(629829216000000000), new DateTime(629853408000000000), new DateTime(629836128000000000), 2, 0.78M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10349, "SPLIR", 7, new DateTime(629830080000000000), new DateTime(629854272000000000), new DateTime(629836128000000000), 1, 8.63M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10350, "LAMAI", 6, new DateTime(629832672000000000), new DateTime(629856864000000000), new DateTime(629851680000000000), 2, 64.19M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10351, "ERNSH", 1, new DateTime(629832672000000000), new DateTime(629856864000000000), new DateTime(629840448000000000), 1, 162.33M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10352, "FURIB", 3, new DateTime(629833536000000000), new DateTime(629845632000000000), new DateTime(629838720000000000), 3, 1.3M, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal"));
        this.Orders.Add(new OrdersItem(10353, "PICCO", 7, new DateTime(629834400000000000), new DateTime(629858592000000000), new DateTime(629844768000000000), 3, 360.63M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10354, "PERIC", 8, new DateTime(629835264000000000), new DateTime(629859456000000000), new DateTime(629840448000000000), 3, 53.8M, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10355, "AROUT", 6, new DateTime(629836128000000000), new DateTime(629860320000000000), new DateTime(629840448000000000), 1, 41.95M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10356, "WANDK", 6, new DateTime(629838720000000000), new DateTime(629862912000000000), new DateTime(629846496000000000), 2, 36.71M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10357, "LILAS", 1, new DateTime(629839584000000000), new DateTime(629863776000000000), new DateTime(629850816000000000), 3, 34.88M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10358, "LAMAI", 5, new DateTime(629840448000000000), new DateTime(629864640000000000), new DateTime(629846496000000000), 1, 19.64M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10359, "SEVES", 5, new DateTime(629841312000000000), new DateTime(629865504000000000), new DateTime(629845632000000000), 3, 288.43M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10360, "BLONP", 4, new DateTime(629842176000000000), new DateTime(629866368000000000), new DateTime(629850816000000000), 3, 131.7M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10361, "QUICK", 1, new DateTime(629842176000000000), new DateTime(629866368000000000), new DateTime(629851680000000000), 2, 183.17M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10362, "BONAP", 3, new DateTime(629844768000000000), new DateTime(629868960000000000), new DateTime(629847360000000000), 1, 96.04M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10363, "DRACD", 4, new DateTime(629845632000000000), new DateTime(629869824000000000), new DateTime(629852544000000000), 3, 30.54M, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", null, "52066", "Germany"));
        this.Orders.Add(new OrdersItem(10364, "EASTC", 1, new DateTime(629845632000000000), new DateTime(629881920000000000), new DateTime(629852544000000000), 1, 71.97M, "Eastern Connection", "35 King George", "London", null, "WX3 6FW", "UK"));
        this.Orders.Add(new OrdersItem(10365, "ANTON", 3, new DateTime(629846496000000000), new DateTime(629870688000000000), new DateTime(629850816000000000), 2, 22M, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", null, "05023", "Mexico"));
        this.Orders.Add(new OrdersItem(10366, "GALED", 8, new DateTime(629847360000000000), new DateTime(629883648000000000), new DateTime(629875008000000000), 2, 10.14M, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", null, "8022", "Spain"));
        this.Orders.Add(new OrdersItem(10367, "VAFFE", 7, new DateTime(629847360000000000), new DateTime(629871552000000000), new DateTime(629850816000000000), 3, 13.55M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10368, "ERNSH", 2, new DateTime(629848224000000000), new DateTime(629872416000000000), new DateTime(629850816000000000), 2, 101.95M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10369, "SPLIR", 8, new DateTime(629850816000000000), new DateTime(629875008000000000), new DateTime(629856864000000000), 2, 195.68M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10370, "CHOPS", 6, new DateTime(629851680000000000), new DateTime(629875872000000000), new DateTime(629872416000000000), 2, 1.17M, "Chop-suey Chinese", "Hauptstr. 31", "Bern", null, "3012", "Switzerland"));
        this.Orders.Add(new OrdersItem(10371, "LAMAI", 1, new DateTime(629851680000000000), new DateTime(629875872000000000), new DateTime(629869824000000000), 1, 0.45M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10372, "QUEEN", 5, new DateTime(629852544000000000), new DateTime(629876736000000000), new DateTime(629856864000000000), 2, 890.78M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10373, "HUNGO", 4, new DateTime(629853408000000000), new DateTime(629877600000000000), new DateTime(629858592000000000), 3, 124.12M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10374, "WOLZA", 1, new DateTime(629853408000000000), new DateTime(629877600000000000), new DateTime(629856864000000000), 3, 3.94M, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland"));
        this.Orders.Add(new OrdersItem(10375, "HUNGC", 3, new DateTime(629854272000000000), new DateTime(629878464000000000), new DateTime(629856864000000000), 2, 20.12M, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
        this.Orders.Add(new OrdersItem(10376, "MEREP", 1, new DateTime(629856864000000000), new DateTime(629881056000000000), new DateTime(629860320000000000), 2, 20.39M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10377, "SEVES", 1, new DateTime(629856864000000000), new DateTime(629881056000000000), new DateTime(629860320000000000), 3, 22.21M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10378, "FOLKO", 5, new DateTime(629857728000000000), new DateTime(629881920000000000), new DateTime(629865504000000000), 3, 5.44M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10379, "QUEDE", 2, new DateTime(629858592000000000), new DateTime(629882784000000000), new DateTime(629860320000000000), 1, 45.03M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10380, "HUNGO", 8, new DateTime(629859456000000000), new DateTime(629883648000000000), new DateTime(629889696000000000), 3, 35.03M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10381, "LILAS", 3, new DateTime(629859456000000000), new DateTime(629883648000000000), new DateTime(629860320000000000), 3, 7.99M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10382, "ERNSH", 4, new DateTime(629860320000000000), new DateTime(629884512000000000), new DateTime(629862912000000000), 1, 94.77M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10383, "AROUT", 8, new DateTime(629862912000000000), new DateTime(629887104000000000), new DateTime(629864640000000000), 3, 34.24M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10384, "BERGS", 3, new DateTime(629862912000000000), new DateTime(629887104000000000), new DateTime(629866368000000000), 3, 168.64M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10385, "SPLIR", 1, new DateTime(629863776000000000), new DateTime(629887968000000000), new DateTime(629868960000000000), 2, 30.96M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10386, "FAMIA", 9, new DateTime(629864640000000000), new DateTime(629876736000000000), new DateTime(629870688000000000), 3, 13.99M, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10387, "SANTG", 1, new DateTime(629864640000000000), new DateTime(629888832000000000), new DateTime(629866368000000000), 2, 93.63M, "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", null, "4110", "Norway"));
        this.Orders.Add(new OrdersItem(10388, "SEVES", 2, new DateTime(629865504000000000), new DateTime(629889696000000000), new DateTime(629866368000000000), 1, 34.86M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10389, "BOTTM", 4, new DateTime(629866368000000000), new DateTime(629890560000000000), new DateTime(629869824000000000), 2, 47.42M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10390, "ERNSH", 6, new DateTime(629868960000000000), new DateTime(629893152000000000), new DateTime(629871552000000000), 1, 126.38M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10391, "DRACD", 3, new DateTime(629868960000000000), new DateTime(629893152000000000), new DateTime(629875872000000000), 3, 5.45M, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", null, "52066", "Germany"));
        this.Orders.Add(new OrdersItem(10392, "PICCO", 2, new DateTime(629869824000000000), new DateTime(629894016000000000), new DateTime(629876736000000000), 3, 122.46M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10393, "SAVEA", 1, new DateTime(629870688000000000), new DateTime(629894880000000000), new DateTime(629878464000000000), 3, 126.56M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10394, "HUNGC", 1, new DateTime(629870688000000000), new DateTime(629894880000000000), new DateTime(629878464000000000), 3, 30.34M, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
        this.Orders.Add(new OrdersItem(10395, "HILAA", 6, new DateTime(629871552000000000), new DateTime(629895744000000000), new DateTime(629878464000000000), 1, 184.41M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10396, "FRANK", 1, new DateTime(629872416000000000), new DateTime(629884512000000000), new DateTime(629881056000000000), 3, 135.35M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10397, "PRINI", 5, new DateTime(629872416000000000), new DateTime(629896608000000000), new DateTime(629877600000000000), 1, 60.26M, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", null, "1756", "Portugal"));
        this.Orders.Add(new OrdersItem(10398, "SAVEA", 2, new DateTime(629875008000000000), new DateTime(629899200000000000), new DateTime(629883648000000000), 3, 89.16M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10399, "VAFFE", 8, new DateTime(629875872000000000), new DateTime(629887968000000000), new DateTime(629882784000000000), 3, 27.36M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10400, "EASTC", 1, new DateTime(629876736000000000), new DateTime(629900928000000000), new DateTime(629889696000000000), 3, 83.93M, "Eastern Connection", "35 King George", "London", null, "WX3 6FW", "UK"));
        this.Orders.Add(new OrdersItem(10401, "RATTC", 1, new DateTime(629876736000000000), new DateTime(629900928000000000), new DateTime(629884512000000000), 1, 12.51M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10402, "ERNSH", 8, new DateTime(629877600000000000), new DateTime(629913888000000000), new DateTime(629884512000000000), 2, 67.88M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10403, "ERNSH", 4, new DateTime(629878464000000000), new DateTime(629902656000000000), new DateTime(629883648000000000), 3, 73.79M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10404, "MAGAA", 2, new DateTime(629878464000000000), new DateTime(629902656000000000), new DateTime(629882784000000000), 1, 155.97M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10405, "LINOD", 1, new DateTime(629881056000000000), new DateTime(629905248000000000), new DateTime(629894880000000000), 1, 34.82M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10406, "QUEEN", 7, new DateTime(629881920000000000), new DateTime(629918208000000000), new DateTime(629887104000000000), 1, 108.04M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10407, "OTTIK", 2, new DateTime(629881920000000000), new DateTime(629906112000000000), new DateTime(629901792000000000), 2, 91.48M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(10408, "FOLIG", 8, new DateTime(629882784000000000), new DateTime(629906976000000000), new DateTime(629887968000000000), 1, 11.26M, "Folies gourmandes", "184, chaussée de Tournai", "Lille", null, "59000", "France"));
        this.Orders.Add(new OrdersItem(10409, "OCEAN", 3, new DateTime(629883648000000000), new DateTime(629907840000000000), new DateTime(629887968000000000), 1, 29.83M, "Océano Atlántico Ltda.", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10410, "BOTTM", 3, new DateTime(629884512000000000), new DateTime(629908704000000000), new DateTime(629888832000000000), 3, 2.4M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10411, "BOTTM", 9, new DateTime(629884512000000000), new DateTime(629908704000000000), new DateTime(629894016000000000), 3, 23.65M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10412, "WARTH", 8, new DateTime(629887104000000000), new DateTime(629911296000000000), new DateTime(629888832000000000), 2, 3.77M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10413, "LAMAI", 3, new DateTime(629887968000000000), new DateTime(629912160000000000), new DateTime(629889696000000000), 2, 95.66M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10414, "FAMIA", 2, new DateTime(629887968000000000), new DateTime(629912160000000000), new DateTime(629890560000000000), 3, 21.48M, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10415, "HUNGC", 3, new DateTime(629888832000000000), new DateTime(629913024000000000), new DateTime(629896608000000000), 1, 0.2M, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
        this.Orders.Add(new OrdersItem(10416, "WARTH", 8, new DateTime(629889696000000000), new DateTime(629913888000000000), new DateTime(629899200000000000), 3, 22.72M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10417, "SIMOB", 4, new DateTime(629889696000000000), new DateTime(629913888000000000), new DateTime(629900064000000000), 3, 70.29M, "Simons bistro", "Vinbæltet 34", "Kobenhavn", null, "1734", "Denmark"));
        this.Orders.Add(new OrdersItem(10418, "QUICK", 4, new DateTime(629890560000000000), new DateTime(629914752000000000), new DateTime(629896608000000000), 1, 17.55M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10419, "RICSU", 4, new DateTime(629893152000000000), new DateTime(629917344000000000), new DateTime(629901792000000000), 2, 137.35M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(10420, "WELLI", 3, new DateTime(629894016000000000), new DateTime(629918208000000000), new DateTime(629899200000000000), 1, 44.12M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10421, "QUEDE", 8, new DateTime(629894016000000000), new DateTime(629930304000000000), new DateTime(629899200000000000), 1, 99.23M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10422, "FRANS", 2, new DateTime(629894880000000000), new DateTime(629919072000000000), new DateTime(629902656000000000), 1, 3.02M, "Franchi S.p.A.", "Via Monte Bianco 34", "Torino", null, "10100", "Italy"));
        this.Orders.Add(new OrdersItem(10423, "GOURL", 6, new DateTime(629895744000000000), new DateTime(629907840000000000), new DateTime(629923392000000000), 3, 24.5M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(10424, "MEREP", 7, new DateTime(629895744000000000), new DateTime(629919936000000000), new DateTime(629899200000000000), 2, 370.61M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10425, "LAMAI", 6, new DateTime(629896608000000000), new DateTime(629920800000000000), new DateTime(629914752000000000), 2, 7.93M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10426, "GALED", 4, new DateTime(629899200000000000), new DateTime(629923392000000000), new DateTime(629907840000000000), 1, 18.69M, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", null, "8022", "Spain"));
        this.Orders.Add(new OrdersItem(10427, "PICCO", 4, new DateTime(629899200000000000), new DateTime(629923392000000000), new DateTime(629929440000000000), 2, 31.29M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10428, "REGGC", 7, new DateTime(629900064000000000), new DateTime(629924256000000000), new DateTime(629906112000000000), 1, 11.09M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10429, "HUNGO", 3, new DateTime(629900928000000000), new DateTime(629937216000000000), new DateTime(629908704000000000), 2, 56.63M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10430, "ERNSH", 4, new DateTime(629901792000000000), new DateTime(629913888000000000), new DateTime(629905248000000000), 1, 458.78M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10431, "BOTTM", 4, new DateTime(629901792000000000), new DateTime(629913888000000000), new DateTime(629908704000000000), 2, 44.17M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10432, "SPLIR", 3, new DateTime(629902656000000000), new DateTime(629914752000000000), new DateTime(629908704000000000), 2, 4.34M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10433, "PRINI", 3, new DateTime(629905248000000000), new DateTime(629929440000000000), new DateTime(629930304000000000), 3, 73.83M, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", null, "1756", "Portugal"));
        this.Orders.Add(new OrdersItem(10434, "FOLKO", 3, new DateTime(629905248000000000), new DateTime(629929440000000000), new DateTime(629913888000000000), 2, 17.92M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10435, "CONSH", 8, new DateTime(629906112000000000), new DateTime(629942400000000000), new DateTime(629908704000000000), 2, 9.21M, "Consolidated Holdings", "Berkeley Gardens 12  Brewery", "London", null, "WX1 6LT", "UK"));
        this.Orders.Add(new OrdersItem(10436, "BLONP", 3, new DateTime(629906976000000000), new DateTime(629931168000000000), new DateTime(629912160000000000), 2, 156.66M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10437, "WARTH", 8, new DateTime(629906976000000000), new DateTime(629931168000000000), new DateTime(629913024000000000), 1, 19.97M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10438, "TOMSP", 3, new DateTime(629907840000000000), new DateTime(629932032000000000), new DateTime(629914752000000000), 2, 8.24M, "Toms Spezialitäten", "Luisenstr. 48", "Münster", null, "44087", "Germany"));
        this.Orders.Add(new OrdersItem(10439, "MEREP", 6, new DateTime(629908704000000000), new DateTime(629932896000000000), new DateTime(629911296000000000), 3, 4.07M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10440, "SAVEA", 4, new DateTime(629911296000000000), new DateTime(629935488000000000), new DateTime(629926848000000000), 2, 86.53M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10441, "OLDWO", 3, new DateTime(629911296000000000), new DateTime(629947584000000000), new DateTime(629938944000000000), 2, 73.02M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10442, "ERNSH", 3, new DateTime(629912160000000000), new DateTime(629936352000000000), new DateTime(629918208000000000), 2, 47.94M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10443, "REGGC", 8, new DateTime(629913024000000000), new DateTime(629937216000000000), new DateTime(629914752000000000), 1, 13.95M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10444, "BERGS", 3, new DateTime(629913024000000000), new DateTime(629937216000000000), new DateTime(629920800000000000), 3, 3.5M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10445, "BERGS", 3, new DateTime(629913888000000000), new DateTime(629938080000000000), new DateTime(629919936000000000), 1, 9.3M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10446, "TOMSP", 6, new DateTime(629914752000000000), new DateTime(629938944000000000), new DateTime(629919072000000000), 1, 14.68M, "Toms Spezialitäten", "Luisenstr. 48", "Münster", null, "44087", "Germany"));
        this.Orders.Add(new OrdersItem(10447, "RICAR", 4, new DateTime(629914752000000000), new DateTime(629938944000000000), new DateTime(629932896000000000), 2, 68.66M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10448, "RANCH", 4, new DateTime(629917344000000000), new DateTime(629941536000000000), new DateTime(629923392000000000), 2, 38.82M, "Rancho grande", "Av. del Libertador 900", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10449, "BLONP", 3, new DateTime(629918208000000000), new DateTime(629942400000000000), new DateTime(629925984000000000), 2, 53.3M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10450, "VICTE", 8, new DateTime(629919072000000000), new DateTime(629943264000000000), new DateTime(629936352000000000), 2, 7.23M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10451, "QUICK", 4, new DateTime(629919072000000000), new DateTime(629931168000000000), new DateTime(629937216000000000), 3, 189.09M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10452, "SAVEA", 8, new DateTime(629919936000000000), new DateTime(629944128000000000), new DateTime(629925120000000000), 1, 140.26M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10453, "AROUT", 1, new DateTime(629920800000000000), new DateTime(629944992000000000), new DateTime(629925120000000000), 2, 25.36M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10454, "LAMAI", 4, new DateTime(629920800000000000), new DateTime(629944992000000000), new DateTime(629924256000000000), 3, 2.74M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10455, "WARTH", 8, new DateTime(629923392000000000), new DateTime(629959680000000000), new DateTime(629929440000000000), 2, 180.45M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10456, "KOENE", 8, new DateTime(629924256000000000), new DateTime(629960544000000000), new DateTime(629926848000000000), 2, 8.12M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10457, "KOENE", 2, new DateTime(629924256000000000), new DateTime(629948448000000000), new DateTime(629929440000000000), 1, 11.57M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10458, "SUPRD", 7, new DateTime(629925120000000000), new DateTime(629949312000000000), new DateTime(629930304000000000), 3, 147.06M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10459, "VICTE", 4, new DateTime(629925984000000000), new DateTime(629950176000000000), new DateTime(629926848000000000), 2, 25.09M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10460, "FOLKO", 8, new DateTime(629926848000000000), new DateTime(629951040000000000), new DateTime(629929440000000000), 1, 16.27M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10461, "LILAS", 1, new DateTime(629926848000000000), new DateTime(629951040000000000), new DateTime(629931168000000000), 3, 148.61M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10462, "CONSH", 2, new DateTime(629929440000000000), new DateTime(629953632000000000), new DateTime(629942400000000000), 1, 6.17M, "Consolidated Holdings", "Berkeley Gardens 12  Brewery", "London", null, "WX1 6LT", "UK"));
        this.Orders.Add(new OrdersItem(10463, "SUPRD", 5, new DateTime(629930304000000000), new DateTime(629954496000000000), new DateTime(629932032000000000), 3, 14.78M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10464, "FURIB", 4, new DateTime(629930304000000000), new DateTime(629954496000000000), new DateTime(629938944000000000), 2, 89M, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal"));
        this.Orders.Add(new OrdersItem(10465, "VAFFE", 1, new DateTime(629931168000000000), new DateTime(629955360000000000), new DateTime(629938944000000000), 3, 145.04M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10466, "COMMI", 4, new DateTime(629932032000000000), new DateTime(629956224000000000), new DateTime(629938080000000000), 1, 11.93M, "Comércio Mineiro", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"));
        this.Orders.Add(new OrdersItem(10467, "MAGAA", 8, new DateTime(629932032000000000), new DateTime(629956224000000000), new DateTime(629936352000000000), 2, 4.93M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10468, "KOENE", 3, new DateTime(629932896000000000), new DateTime(629957088000000000), new DateTime(629937216000000000), 3, 44.12M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10469, "WHITC", 1, new DateTime(629935488000000000), new DateTime(629959680000000000), new DateTime(629938944000000000), 1, 60.18M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10470, "BONAP", 4, new DateTime(629936352000000000), new DateTime(629960544000000000), new DateTime(629938944000000000), 2, 64.56M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10471, "BSBEV", 2, new DateTime(629936352000000000), new DateTime(629960544000000000), new DateTime(629942400000000000), 3, 45.59M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10472, "SEVES", 8, new DateTime(629937216000000000), new DateTime(629961408000000000), new DateTime(629943264000000000), 1, 4.2M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10473, "ISLAT", 1, new DateTime(629938080000000000), new DateTime(629950176000000000), new DateTime(629944992000000000), 3, 16.37M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10474, "PERIC", 5, new DateTime(629938080000000000), new DateTime(629962272000000000), new DateTime(629944992000000000), 2, 83.49M, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10475, "SUPRD", 9, new DateTime(629938944000000000), new DateTime(629963136000000000), new DateTime(629957088000000000), 1, 68.52M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10476, "HILAA", 8, new DateTime(629941536000000000), new DateTime(629965728000000000), new DateTime(629947584000000000), 3, 4.41M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10477, "PRINI", 5, new DateTime(629941536000000000), new DateTime(629965728000000000), new DateTime(629948448000000000), 2, 13.02M, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", null, "1756", "Portugal"));
        this.Orders.Add(new OrdersItem(10478, "VICTE", 2, new DateTime(629942400000000000), new DateTime(629954496000000000), new DateTime(629949312000000000), 3, 4.81M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10479, "RATTC", 3, new DateTime(629943264000000000), new DateTime(629967456000000000), new DateTime(629944992000000000), 3, 708.95M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10480, "FOLIG", 6, new DateTime(629944128000000000), new DateTime(629968320000000000), new DateTime(629947584000000000), 2, 1.35M, "Folies gourmandes", "184, chaussée de Tournai", "Lille", null, "59000", "France"));
        this.Orders.Add(new OrdersItem(10481, "RICAR", 8, new DateTime(629944128000000000), new DateTime(629968320000000000), new DateTime(629948448000000000), 2, 64.33M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10482, "LAZYK", 1, new DateTime(629944992000000000), new DateTime(629969184000000000), new DateTime(629962272000000000), 3, 7.48M, "Lazy K Kountry Store", "12 Orchestra Terrace", "Walla Walla", "WA", "99362", "USA"));
        this.Orders.Add(new OrdersItem(10483, "WHITC", 7, new DateTime(629947584000000000), new DateTime(629971776000000000), new DateTime(629975232000000000), 2, 15.28M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10484, "BSBEV", 3, new DateTime(629947584000000000), new DateTime(629971776000000000), new DateTime(629954496000000000), 3, 6.88M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10485, "LINOD", 4, new DateTime(629948448000000000), new DateTime(629960544000000000), new DateTime(629953632000000000), 2, 64.45M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10486, "HILAA", 1, new DateTime(629949312000000000), new DateTime(629973504000000000), new DateTime(629955360000000000), 2, 30.53M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10487, "QUEEN", 2, new DateTime(629949312000000000), new DateTime(629973504000000000), new DateTime(629951040000000000), 2, 71.07M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10488, "FRANK", 8, new DateTime(629950176000000000), new DateTime(629974368000000000), new DateTime(629955360000000000), 2, 4.93M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10489, "PICCO", 6, new DateTime(629951040000000000), new DateTime(629975232000000000), new DateTime(629961408000000000), 2, 5.29M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10490, "HILAA", 7, new DateTime(629953632000000000), new DateTime(629977824000000000), new DateTime(629956224000000000), 2, 210.19M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10491, "FURIB", 8, new DateTime(629953632000000000), new DateTime(629977824000000000), new DateTime(629960544000000000), 3, 16.96M, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal"));
        this.Orders.Add(new OrdersItem(10492, "BOTTM", 3, new DateTime(629954496000000000), new DateTime(629978688000000000), new DateTime(629963136000000000), 1, 62.89M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10493, "LAMAI", 4, new DateTime(629955360000000000), new DateTime(629979552000000000), new DateTime(629962272000000000), 3, 10.64M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10494, "COMMI", 4, new DateTime(629955360000000000), new DateTime(629979552000000000), new DateTime(629961408000000000), 2, 65.99M, "Comércio Mineiro", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"));
        this.Orders.Add(new OrdersItem(10495, "LAUGB", 3, new DateTime(629956224000000000), new DateTime(629980416000000000), new DateTime(629963136000000000), 3, 4.65M, "Laughing Bacchus Wine Cellars", "2319 Elm St.", "Vancouver", "BC", "V3F 2K1", "Canada"));
        this.Orders.Add(new OrdersItem(10496, "TRADH", 7, new DateTime(629957088000000000), new DateTime(629981280000000000), new DateTime(629959680000000000), 2, 46.77M, "Tradiçao Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10497, "LEHMS", 7, new DateTime(629957088000000000), new DateTime(629981280000000000), new DateTime(629959680000000000), 1, 36.21M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10498, "HILAA", 8, new DateTime(629959680000000000), new DateTime(629983872000000000), new DateTime(629963136000000000), 2, 29.75M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10499, "LILAS", 4, new DateTime(629960544000000000), new DateTime(629984736000000000), new DateTime(629967456000000000), 2, 102.02M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10500, "LAMAI", 6, new DateTime(629961408000000000), new DateTime(629985600000000000), new DateTime(629968320000000000), 1, 42.68M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10501, "BLAUS", 9, new DateTime(629961408000000000), new DateTime(629985600000000000), new DateTime(629967456000000000), 3, 8.85M, "Blauer See Delikatessen", "Forsterstr. 57", "Mannheim", null, "68306", "Germany"));
        this.Orders.Add(new OrdersItem(10502, "PERIC", 2, new DateTime(629962272000000000), new DateTime(629986464000000000), new DateTime(629978688000000000), 1, 69.32M, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10503, "HUNGO", 6, new DateTime(629963136000000000), new DateTime(629987328000000000), new DateTime(629967456000000000), 2, 16.74M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10504, "WHITC", 4, new DateTime(629963136000000000), new DateTime(629987328000000000), new DateTime(629969184000000000), 3, 59.13M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10505, "MEREP", 3, new DateTime(629965728000000000), new DateTime(629989920000000000), new DateTime(629971776000000000), 3, 7.13M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10506, "KOENE", 9, new DateTime(629966592000000000), new DateTime(629990784000000000), new DateTime(629981280000000000), 2, 21.19M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10507, "ANTON", 7, new DateTime(629966592000000000), new DateTime(629990784000000000), new DateTime(629972640000000000), 1, 47.45M, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", null, "05023", "Mexico"));
        this.Orders.Add(new OrdersItem(10508, "OTTIK", 1, new DateTime(629967456000000000), new DateTime(629991648000000000), new DateTime(629990784000000000), 2, 4.99M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(10509, "BLAUS", 4, new DateTime(629968320000000000), new DateTime(629992512000000000), new DateTime(629978688000000000), 1, 0.15M, "Blauer See Delikatessen", "Forsterstr. 57", "Mannheim", null, "68306", "Germany"));
        this.Orders.Add(new OrdersItem(10510, "SAVEA", 6, new DateTime(629969184000000000), new DateTime(629993376000000000), new DateTime(629977824000000000), 3, 367.63M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10511, "BONAP", 4, new DateTime(629969184000000000), new DateTime(629993376000000000), new DateTime(629971776000000000), 3, 350.64M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10512, "FAMIA", 7, new DateTime(629971776000000000), new DateTime(629995968000000000), new DateTime(629974368000000000), 2, 3.53M, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10513, "WANDK", 7, new DateTime(629972640000000000), new DateTime(630008928000000000), new DateTime(629977824000000000), 1, 105.65M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10514, "ERNSH", 3, new DateTime(629972640000000000), new DateTime(629996832000000000), new DateTime(629993376000000000), 2, 789.95M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10515, "QUICK", 2, new DateTime(629973504000000000), new DateTime(629985600000000000), new DateTime(629999424000000000), 1, 204.47M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10516, "HUNGO", 2, new DateTime(629974368000000000), new DateTime(629998560000000000), new DateTime(629980416000000000), 3, 62.78M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10517, "NORTS", 3, new DateTime(629974368000000000), new DateTime(629998560000000000), new DateTime(629978688000000000), 3, 32.07M, "North/South", "South House 300 Queensbridge", "London", null, "SW7 1RZ", "UK"));
        this.Orders.Add(new OrdersItem(10518, "TORTU", 4, new DateTime(629975232000000000), new DateTime(629987328000000000), new DateTime(629983872000000000), 2, 218.15M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10519, "CHOPS", 6, new DateTime(629977824000000000), new DateTime(630002016000000000), new DateTime(629980416000000000), 3, 91.76M, "Chop-suey Chinese", "Hauptstr. 31", "Bern", null, "3012", "Switzerland"));
        this.Orders.Add(new OrdersItem(10520, "SANTG", 7, new DateTime(629978688000000000), new DateTime(630002880000000000), new DateTime(629980416000000000), 1, 13.37M, "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", null, "4110", "Norway"));
        this.Orders.Add(new OrdersItem(10521, "CACTU", 8, new DateTime(629978688000000000), new DateTime(630002880000000000), new DateTime(629981280000000000), 2, 17.22M, "Cactus Comidas para llevar", "Cerrito 333", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10522, "LEHMS", 4, new DateTime(629979552000000000), new DateTime(630003744000000000), new DateTime(629984736000000000), 1, 45.33M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10523, "SEVES", 7, new DateTime(629980416000000000), new DateTime(630004608000000000), new DateTime(630005472000000000), 2, 77.63M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10524, "BERGS", 1, new DateTime(629980416000000000), new DateTime(630004608000000000), new DateTime(629985600000000000), 2, 244.79M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10525, "BONAP", 1, new DateTime(629981280000000000), new DateTime(630005472000000000), new DateTime(629999424000000000), 2, 11.06M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10526, "WARTH", 4, new DateTime(629983872000000000), new DateTime(630008064000000000), new DateTime(629992512000000000), 2, 58.59M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10527, "QUICK", 7, new DateTime(629983872000000000), new DateTime(630008064000000000), new DateTime(629985600000000000), 1, 41.9M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10528, "GREAL", 6, new DateTime(629984736000000000), new DateTime(629996832000000000), new DateTime(629987328000000000), 2, 3.35M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(10529, "MAISD", 5, new DateTime(629985600000000000), new DateTime(630009792000000000), new DateTime(629987328000000000), 2, 66.69M, "Maison Dewey", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium"));
        this.Orders.Add(new OrdersItem(10530, "PICCO", 3, new DateTime(629986464000000000), new DateTime(630010656000000000), new DateTime(629989920000000000), 2, 339.22M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10531, "OCEAN", 7, new DateTime(629986464000000000), new DateTime(630010656000000000), new DateTime(629995968000000000), 1, 8.12M, "Océano Atlántico Ltda.", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10532, "EASTC", 7, new DateTime(629987328000000000), new DateTime(630011520000000000), new DateTime(629989920000000000), 3, 74.46M, "Eastern Connection", "35 King George", "London", null, "WX3 6FW", "UK"));
        this.Orders.Add(new OrdersItem(10533, "FOLKO", 8, new DateTime(629989920000000000), new DateTime(630014112000000000), new DateTime(629998560000000000), 1, 188.04M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10534, "LEHMS", 8, new DateTime(629989920000000000), new DateTime(630014112000000000), new DateTime(629991648000000000), 2, 27.94M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10535, "ANTON", 4, new DateTime(629990784000000000), new DateTime(630014976000000000), new DateTime(629997696000000000), 1, 15.64M, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", null, "05023", "Mexico"));
        this.Orders.Add(new OrdersItem(10536, "LEHMS", 3, new DateTime(629991648000000000), new DateTime(630015840000000000), new DateTime(630011520000000000), 2, 58.88M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10537, "RICSU", 1, new DateTime(629991648000000000), new DateTime(630003744000000000), new DateTime(629995968000000000), 1, 78.85M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(10538, "BSBEV", 9, new DateTime(629992512000000000), new DateTime(630016704000000000), new DateTime(629993376000000000), 3, 4.87M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10539, "BSBEV", 6, new DateTime(629993376000000000), new DateTime(630017568000000000), new DateTime(629999424000000000), 3, 12.36M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10540, "QUICK", 3, new DateTime(629995968000000000), new DateTime(630020160000000000), new DateTime(630017568000000000), 3, 1007.64M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10541, "HANAR", 2, new DateTime(629995968000000000), new DateTime(630020160000000000), new DateTime(630004608000000000), 1, 68.65M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10542, "KOENE", 1, new DateTime(629996832000000000), new DateTime(630021024000000000), new DateTime(630002016000000000), 3, 10.95M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10543, "LILAS", 8, new DateTime(629997696000000000), new DateTime(630021888000000000), new DateTime(629999424000000000), 2, 48.17M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10544, "LONEP", 4, new DateTime(629997696000000000), new DateTime(630021888000000000), new DateTime(630005472000000000), 1, 24.91M, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
        this.Orders.Add(new OrdersItem(10545, "LAZYK", 8, new DateTime(629998560000000000), new DateTime(630022752000000000), new DateTime(630028800000000000), 2, 11.92M, "Lazy K Kountry Store", "12 Orchestra Terrace", "Walla Walla", "WA", "99362", "USA"));
        this.Orders.Add(new OrdersItem(10546, "VICTE", 1, new DateTime(629999424000000000), new DateTime(630023616000000000), new DateTime(630002880000000000), 3, 194.72M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10547, "SEVES", 3, new DateTime(629999424000000000), new DateTime(630023616000000000), new DateTime(630008064000000000), 2, 178.43M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10548, "TOMSP", 3, new DateTime(630002016000000000), new DateTime(630026208000000000), new DateTime(630008064000000000), 2, 1.43M, "Toms Spezialitäten", "Luisenstr. 48", "Münster", null, "44087", "Germany"));
        this.Orders.Add(new OrdersItem(10549, "QUICK", 5, new DateTime(630002880000000000), new DateTime(630014976000000000), new DateTime(630005472000000000), 1, 171.24M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10550, "GODOS", 7, new DateTime(630003744000000000), new DateTime(630027936000000000), new DateTime(630011520000000000), 3, 4.32M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(10551, "FURIB", 4, new DateTime(630003744000000000), new DateTime(630040032000000000), new DateTime(630011520000000000), 3, 72.95M, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal"));
        this.Orders.Add(new OrdersItem(10552, "HILAA", 2, new DateTime(630004608000000000), new DateTime(630028800000000000), new DateTime(630010656000000000), 1, 83.22M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10553, "WARTH", 2, new DateTime(630005472000000000), new DateTime(630029664000000000), new DateTime(630008928000000000), 2, 149.49M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10554, "OTTIK", 4, new DateTime(630005472000000000), new DateTime(630029664000000000), new DateTime(630010656000000000), 3, 120.97M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(10555, "SAVEA", 6, new DateTime(630008064000000000), new DateTime(630032256000000000), new DateTime(630009792000000000), 3, 252.49M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10556, "SIMOB", 2, new DateTime(630008928000000000), new DateTime(630045216000000000), new DateTime(630017568000000000), 1, 9.8M, "Simons bistro", "Vinbæltet 34", "Kobenhavn", null, "1734", "Denmark"));
        this.Orders.Add(new OrdersItem(10557, "LEHMS", 9, new DateTime(630008928000000000), new DateTime(630021024000000000), new DateTime(630011520000000000), 2, 96.72M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10558, "AROUT", 1, new DateTime(630009792000000000), new DateTime(630033984000000000), new DateTime(630014976000000000), 2, 72.97M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10559, "BLONP", 6, new DateTime(630010656000000000), new DateTime(630034848000000000), new DateTime(630017568000000000), 1, 8.05M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10560, "FRANK", 8, new DateTime(630011520000000000), new DateTime(630035712000000000), new DateTime(630014112000000000), 1, 36.65M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10561, "FOLKO", 2, new DateTime(630011520000000000), new DateTime(630035712000000000), new DateTime(630014112000000000), 2, 242.21M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10562, "REGGC", 1, new DateTime(630014112000000000), new DateTime(630038304000000000), new DateTime(630016704000000000), 1, 22.95M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10563, "RICAR", 2, new DateTime(630014976000000000), new DateTime(630051264000000000), new DateTime(630027072000000000), 2, 60.43M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10564, "RATTC", 4, new DateTime(630014976000000000), new DateTime(630039168000000000), new DateTime(630020160000000000), 3, 13.75M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10565, "MEREP", 8, new DateTime(630015840000000000), new DateTime(630040032000000000), new DateTime(630021888000000000), 2, 7.15M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10566, "BLONP", 9, new DateTime(630016704000000000), new DateTime(630040896000000000), new DateTime(630021888000000000), 1, 88.4M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10567, "HUNGO", 1, new DateTime(630016704000000000), new DateTime(630040896000000000), new DateTime(630021024000000000), 1, 33.97M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10568, "GALED", 3, new DateTime(630017568000000000), new DateTime(630041760000000000), new DateTime(630040032000000000), 3, 6.54M, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", null, "8022", "Spain"));
        this.Orders.Add(new OrdersItem(10569, "RATTC", 5, new DateTime(630020160000000000), new DateTime(630044352000000000), new DateTime(630041760000000000), 1, 58.98M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10570, "MEREP", 3, new DateTime(630021024000000000), new DateTime(630045216000000000), new DateTime(630022752000000000), 3, 188.99M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10571, "ERNSH", 8, new DateTime(630021024000000000), new DateTime(630057312000000000), new DateTime(630035712000000000), 3, 26.06M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10572, "BERGS", 3, new DateTime(630021888000000000), new DateTime(630046080000000000), new DateTime(630027936000000000), 2, 116.43M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10573, "ANTON", 7, new DateTime(630022752000000000), new DateTime(630046944000000000), new DateTime(630023616000000000), 3, 84.84M, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", null, "05023", "Mexico"));
        this.Orders.Add(new OrdersItem(10574, "TRAIH", 4, new DateTime(630022752000000000), new DateTime(630046944000000000), new DateTime(630032256000000000), 2, 37.6M, "Trail's Head Gourmet Provisioners", "722 DaVinci Blvd.", "Kirkland", "WA", "98034", "USA"));
        this.Orders.Add(new OrdersItem(10575, "MORGK", 5, new DateTime(630023616000000000), new DateTime(630035712000000000), new DateTime(630032256000000000), 1, 127.34M, "Morgenstern Gesundkost", "Heerstr. 22", "Leipzig", null, "04179", "Germany"));
        this.Orders.Add(new OrdersItem(10576, "TORTU", 3, new DateTime(630026208000000000), new DateTime(630038304000000000), new DateTime(630032256000000000), 3, 18.56M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10577, "TRAIH", 9, new DateTime(630026208000000000), new DateTime(630062496000000000), new DateTime(630032256000000000), 2, 25.41M, "Trail's Head Gourmet Provisioners", "722 DaVinci Blvd.", "Kirkland", "WA", "98034", "USA"));
        this.Orders.Add(new OrdersItem(10578, "BSBEV", 4, new DateTime(630027072000000000), new DateTime(630051264000000000), new DateTime(630053856000000000), 3, 29.6M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10579, "LETSS", 1, new DateTime(630027936000000000), new DateTime(630052128000000000), new DateTime(630035712000000000), 2, 13.73M, "Let's Stop N Shop", "87 Polk St. Suite 5", "San Francisco", "CA", "94117", "USA"));
        this.Orders.Add(new OrdersItem(10580, "OTTIK", 4, new DateTime(630028800000000000), new DateTime(630052992000000000), new DateTime(630033120000000000), 3, 75.89M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(10581, "FAMIA", 3, new DateTime(630028800000000000), new DateTime(630052992000000000), new DateTime(630033984000000000), 1, 3.01M, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10582, "BLAUS", 3, new DateTime(630029664000000000), new DateTime(630053856000000000), new DateTime(630044352000000000), 2, 27.71M, "Blauer See Delikatessen", "Forsterstr. 57", "Mannheim", null, "68306", "Germany"));
        this.Orders.Add(new OrdersItem(10583, "WARTH", 2, new DateTime(630032256000000000), new DateTime(630056448000000000), new DateTime(630035712000000000), 2, 7.28M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10584, "BLONP", 4, new DateTime(630032256000000000), new DateTime(630056448000000000), new DateTime(630035712000000000), 1, 59.14M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10585, "WELLI", 7, new DateTime(630033120000000000), new DateTime(630057312000000000), new DateTime(630040896000000000), 1, 13.41M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10586, "REGGC", 9, new DateTime(630033984000000000), new DateTime(630058176000000000), new DateTime(630040032000000000), 1, 0.48M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10587, "QUEDE", 1, new DateTime(630033984000000000), new DateTime(630058176000000000), new DateTime(630040032000000000), 1, 62.52M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10588, "QUICK", 2, new DateTime(630034848000000000), new DateTime(630059040000000000), new DateTime(630040896000000000), 3, 194.67M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10589, "GREAL", 8, new DateTime(630035712000000000), new DateTime(630059904000000000), new DateTime(630044352000000000), 2, 4.42M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(10590, "MEREP", 4, new DateTime(630038304000000000), new DateTime(630062496000000000), new DateTime(630044352000000000), 3, 44.77M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10591, "VAFFE", 1, new DateTime(630038304000000000), new DateTime(630050400000000000), new DateTime(630046080000000000), 1, 55.92M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10592, "LEHMS", 3, new DateTime(630039168000000000), new DateTime(630063360000000000), new DateTime(630046080000000000), 1, 32.1M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10593, "LEHMS", 7, new DateTime(630040032000000000), new DateTime(630064224000000000), new DateTime(630070272000000000), 2, 174.2M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10594, "OLDWO", 3, new DateTime(630040032000000000), new DateTime(630064224000000000), new DateTime(630046080000000000), 2, 5.24M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10595, "ERNSH", 2, new DateTime(630040896000000000), new DateTime(630065088000000000), new DateTime(630044352000000000), 1, 96.78M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10596, "WHITC", 8, new DateTime(630041760000000000), new DateTime(630065952000000000), new DateTime(630069408000000000), 1, 16.34M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10597, "PICCO", 7, new DateTime(630041760000000000), new DateTime(630065952000000000), new DateTime(630047808000000000), 3, 35.12M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10598, "RATTC", 1, new DateTime(630044352000000000), new DateTime(630068544000000000), new DateTime(630047808000000000), 3, 44.42M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10599, "BSBEV", 6, new DateTime(630045216000000000), new DateTime(630081504000000000), new DateTime(630050400000000000), 3, 29.98M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10600, "HUNGC", 4, new DateTime(630046080000000000), new DateTime(630070272000000000), new DateTime(630050400000000000), 1, 45.13M, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
        this.Orders.Add(new OrdersItem(10601, "HILAA", 7, new DateTime(630046080000000000), new DateTime(630082368000000000), new DateTime(630051264000000000), 1, 58.3M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10602, "VAFFE", 8, new DateTime(630046944000000000), new DateTime(630071136000000000), new DateTime(630051264000000000), 2, 2.92M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10603, "SAVEA", 8, new DateTime(630047808000000000), new DateTime(630072000000000000), new DateTime(630065952000000000), 2, 48.77M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10604, "FURIB", 1, new DateTime(630047808000000000), new DateTime(630072000000000000), new DateTime(630057312000000000), 1, 7.46M, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal"));
        this.Orders.Add(new OrdersItem(10605, "MEREP", 1, new DateTime(630050400000000000), new DateTime(630074592000000000), new DateTime(630057312000000000), 2, 379.13M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10606, "TRADH", 4, new DateTime(630051264000000000), new DateTime(630075456000000000), new DateTime(630059040000000000), 3, 79.4M, "Tradiçao Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10607, "SAVEA", 5, new DateTime(630051264000000000), new DateTime(630075456000000000), new DateTime(630053856000000000), 1, 200.24M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10608, "TOMSP", 4, new DateTime(630052128000000000), new DateTime(630076320000000000), new DateTime(630059904000000000), 2, 27.79M, "Toms Spezialitäten", "Luisenstr. 48", "Münster", null, "44087", "Germany"));
        this.Orders.Add(new OrdersItem(10609, "DUMON", 7, new DateTime(630052992000000000), new DateTime(630077184000000000), new DateTime(630058176000000000), 2, 1.85M, "Du monde entier", "67, rue des Cinquante Otages", "Nantes", null, "44000", "France"));
        this.Orders.Add(new OrdersItem(10610, "LAMAI", 8, new DateTime(630053856000000000), new DateTime(630078048000000000), new DateTime(630064224000000000), 1, 26.78M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10611, "WOLZA", 6, new DateTime(630053856000000000), new DateTime(630078048000000000), new DateTime(630059904000000000), 2, 80.65M, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland"));
        this.Orders.Add(new OrdersItem(10612, "SAVEA", 1, new DateTime(630056448000000000), new DateTime(630080640000000000), new DateTime(630059904000000000), 2, 544.08M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10613, "HILAA", 4, new DateTime(630057312000000000), new DateTime(630081504000000000), new DateTime(630059904000000000), 2, 8.11M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10614, "BLAUS", 8, new DateTime(630057312000000000), new DateTime(630081504000000000), new DateTime(630059904000000000), 3, 1.93M, "Blauer See Delikatessen", "Forsterstr. 57", "Mannheim", null, "68306", "Germany"));
        this.Orders.Add(new OrdersItem(10615, "WILMK", 2, new DateTime(630058176000000000), new DateTime(630082368000000000), new DateTime(630064224000000000), 3, 0.75M, "Wilman Kala", "Keskuskatu 45", "Helsinki", null, "21240", "Finland"));
        this.Orders.Add(new OrdersItem(10616, "GREAL", 1, new DateTime(630059040000000000), new DateTime(630083232000000000), new DateTime(630063360000000000), 2, 116.53M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(10617, "GREAL", 4, new DateTime(630059040000000000), new DateTime(630083232000000000), new DateTime(630062496000000000), 2, 18.53M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(10618, "MEREP", 1, new DateTime(630059904000000000), new DateTime(630096192000000000), new DateTime(630065952000000000), 1, 154.68M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10619, "MEREP", 3, new DateTime(630062496000000000), new DateTime(630086688000000000), new DateTime(630065088000000000), 3, 91.05M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10620, "LAUGB", 2, new DateTime(630063360000000000), new DateTime(630087552000000000), new DateTime(630071136000000000), 3, 0.94M, "Laughing Bacchus Wine Cellars", "2319 Elm St.", "Vancouver", "BC", "V3F 2K1", "Canada"));
        this.Orders.Add(new OrdersItem(10621, "ISLAT", 4, new DateTime(630063360000000000), new DateTime(630087552000000000), new DateTime(630068544000000000), 2, 23.73M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10622, "RICAR", 4, new DateTime(630064224000000000), new DateTime(630088416000000000), new DateTime(630068544000000000), 3, 50.97M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10623, "FRANK", 8, new DateTime(630065088000000000), new DateTime(630089280000000000), new DateTime(630069408000000000), 2, 97.18M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10624, "THECR", 4, new DateTime(630065088000000000), new DateTime(630089280000000000), new DateTime(630075456000000000), 2, 94.8M, "The Cracker Box", "55 Grizzly Peak Rd.", "Butte", "MT", "59801", "USA"));
        this.Orders.Add(new OrdersItem(10625, "ANATR", 3, new DateTime(630065952000000000), new DateTime(630090144000000000), new DateTime(630071136000000000), 1, 43.9M, "Ana Trujillo Emparedados y helados", "Avda. de la Constitución 2222", "México D.F.", null, "05021", "Mexico"));
        this.Orders.Add(new OrdersItem(10626, "BERGS", 1, new DateTime(630068544000000000), new DateTime(630092736000000000), new DateTime(630076320000000000), 2, 138.69M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10627, "SAVEA", 8, new DateTime(630068544000000000), new DateTime(630104832000000000), new DateTime(630077184000000000), 3, 107.46M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10628, "BLONP", 4, new DateTime(630069408000000000), new DateTime(630093600000000000), new DateTime(630076320000000000), 3, 30.36M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10629, "GODOS", 4, new DateTime(630069408000000000), new DateTime(630093600000000000), new DateTime(630076320000000000), 3, 85.46M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(10630, "KOENE", 1, new DateTime(630070272000000000), new DateTime(630094464000000000), new DateTime(630075456000000000), 2, 32.35M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10631, "LAMAI", 8, new DateTime(630071136000000000), new DateTime(630095328000000000), new DateTime(630072000000000000), 1, 0.87M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10632, "WANDK", 8, new DateTime(630071136000000000), new DateTime(630095328000000000), new DateTime(630075456000000000), 1, 41.38M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10633, "ERNSH", 7, new DateTime(630072000000000000), new DateTime(630096192000000000), new DateTime(630074592000000000), 3, 477.9M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10634, "FOLIG", 4, new DateTime(630072000000000000), new DateTime(630096192000000000), new DateTime(630077184000000000), 3, 487.38M, "Folies gourmandes", "184, chaussée de Tournai", "Lille", null, "59000", "France"));
        this.Orders.Add(new OrdersItem(10635, "MAGAA", 8, new DateTime(630074592000000000), new DateTime(630098784000000000), new DateTime(630077184000000000), 3, 47.46M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10636, "WARTH", 4, new DateTime(630075456000000000), new DateTime(630099648000000000), new DateTime(630081504000000000), 1, 1.15M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10637, "QUEEN", 6, new DateTime(630075456000000000), new DateTime(630099648000000000), new DateTime(630081504000000000), 1, 201.29M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10638, "LINOD", 3, new DateTime(630076320000000000), new DateTime(630100512000000000), new DateTime(630086688000000000), 1, 158.44M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10639, "SANTG", 7, new DateTime(630076320000000000), new DateTime(630100512000000000), new DateTime(630082368000000000), 3, 38.64M, "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", null, "4110", "Norway"));
        this.Orders.Add(new OrdersItem(10640, "WANDK", 4, new DateTime(630077184000000000), new DateTime(630101376000000000), new DateTime(630083232000000000), 1, 23.55M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10641, "HILAA", 4, new DateTime(630078048000000000), new DateTime(630102240000000000), new DateTime(630081504000000000), 2, 179.61M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10642, "SIMOB", 7, new DateTime(630078048000000000), new DateTime(630102240000000000), new DateTime(630090144000000000), 3, 41.89M, "Simons bistro", "Vinbæltet 34", "Kobenhavn", null, "1734", "Denmark"));
        this.Orders.Add(new OrdersItem(10643, "ALFKI", 6, new DateTime(630080640000000000), new DateTime(630104832000000000), new DateTime(630087552000000000), 1, 29.46M, "Alfreds Futterkiste", "Obere Str. 57", "Berlin", null, "12209", "Germany"));
        this.Orders.Add(new OrdersItem(10644, "WELLI", 3, new DateTime(630080640000000000), new DateTime(630104832000000000), new DateTime(630086688000000000), 2, 0.14M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10645, "HANAR", 4, new DateTime(630081504000000000), new DateTime(630105696000000000), new DateTime(630087552000000000), 1, 12.41M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10646, "HUNGO", 9, new DateTime(630082368000000000), new DateTime(630118656000000000), new DateTime(630088416000000000), 3, 142.33M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10647, "QUEDE", 4, new DateTime(630082368000000000), new DateTime(630094464000000000), new DateTime(630088416000000000), 2, 45.54M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10648, "RICAR", 5, new DateTime(630083232000000000), new DateTime(630119520000000000), new DateTime(630093600000000000), 2, 14.25M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10649, "MAISD", 5, new DateTime(630083232000000000), new DateTime(630107424000000000), new DateTime(630084096000000000), 3, 6.2M, "Maison Dewey", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium"));
        this.Orders.Add(new OrdersItem(10650, "FAMIA", 5, new DateTime(630084096000000000), new DateTime(630108288000000000), new DateTime(630088416000000000), 3, 176.81M, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10651, "WANDK", 8, new DateTime(630086688000000000), new DateTime(630110880000000000), new DateTime(630095328000000000), 2, 20.6M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10652, "GOURL", 4, new DateTime(630086688000000000), new DateTime(630110880000000000), new DateTime(630092736000000000), 2, 7.14M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(10653, "FRANK", 1, new DateTime(630087552000000000), new DateTime(630111744000000000), new DateTime(630102240000000000), 1, 93.25M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10654, "BERGS", 5, new DateTime(630087552000000000), new DateTime(630111744000000000), new DateTime(630095328000000000), 1, 55.26M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10655, "REGGC", 1, new DateTime(630088416000000000), new DateTime(630112608000000000), new DateTime(630095328000000000), 2, 4.41M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10656, "GREAL", 6, new DateTime(630089280000000000), new DateTime(630113472000000000), new DateTime(630094464000000000), 1, 57.15M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(10657, "SAVEA", 2, new DateTime(630089280000000000), new DateTime(630113472000000000), new DateTime(630098784000000000), 2, 352.69M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10658, "QUICK", 4, new DateTime(630090144000000000), new DateTime(630114336000000000), new DateTime(630092736000000000), 1, 364.15M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10659, "QUEEN", 7, new DateTime(630090144000000000), new DateTime(630114336000000000), new DateTime(630094464000000000), 2, 105.81M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10660, "HUNGC", 8, new DateTime(630092736000000000), new DateTime(630116928000000000), new DateTime(630124704000000000), 1, 111.29M, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
        this.Orders.Add(new OrdersItem(10661, "HUNGO", 7, new DateTime(630093600000000000), new DateTime(630117792000000000), new DateTime(630098784000000000), 3, 17.55M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10662, "LONEP", 3, new DateTime(630093600000000000), new DateTime(630117792000000000), new DateTime(630101376000000000), 2, 1.28M, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
        this.Orders.Add(new OrdersItem(10663, "BONAP", 2, new DateTime(630094464000000000), new DateTime(630106560000000000), new DateTime(630114336000000000), 2, 113.15M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10664, "FURIB", 1, new DateTime(630094464000000000), new DateTime(630118656000000000), new DateTime(630102240000000000), 3, 1.27M, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal"));
        this.Orders.Add(new OrdersItem(10665, "LONEP", 1, new DateTime(630095328000000000), new DateTime(630119520000000000), new DateTime(630100512000000000), 2, 26.31M, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
        this.Orders.Add(new OrdersItem(10666, "RICSU", 7, new DateTime(630096192000000000), new DateTime(630120384000000000), new DateTime(630104832000000000), 2, 232.42M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(10667, "ERNSH", 7, new DateTime(630096192000000000), new DateTime(630120384000000000), new DateTime(630102240000000000), 1, 78.09M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10668, "WANDK", 1, new DateTime(630098784000000000), new DateTime(630122976000000000), new DateTime(630105696000000000), 2, 47.22M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(10669, "SIMOB", 2, new DateTime(630098784000000000), new DateTime(630122976000000000), new DateTime(630104832000000000), 1, 24.39M, "Simons bistro", "Vinbæltet 34", "Kobenhavn", null, "1734", "Denmark"));
        this.Orders.Add(new OrdersItem(10670, "FRANK", 4, new DateTime(630099648000000000), new DateTime(630123840000000000), new DateTime(630101376000000000), 1, 203.48M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10671, "FRANR", 1, new DateTime(630100512000000000), new DateTime(630124704000000000), new DateTime(630106560000000000), 1, 30.34M, "France restauration", "54, rue Royale", "Nantes", null, "44000", "France"));
        this.Orders.Add(new OrdersItem(10672, "BERGS", 9, new DateTime(630100512000000000), new DateTime(630112608000000000), new DateTime(630108288000000000), 2, 95.75M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10673, "WILMK", 2, new DateTime(630101376000000000), new DateTime(630125568000000000), new DateTime(630102240000000000), 1, 22.76M, "Wilman Kala", "Keskuskatu 45", "Helsinki", null, "21240", "Finland"));
        this.Orders.Add(new OrdersItem(10674, "ISLAT", 4, new DateTime(630101376000000000), new DateTime(630125568000000000), new DateTime(630111744000000000), 2, 0.9M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10675, "FRANK", 5, new DateTime(630102240000000000), new DateTime(630126432000000000), new DateTime(630105696000000000), 2, 31.85M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10676, "TORTU", 2, new DateTime(630104832000000000), new DateTime(630129024000000000), new DateTime(630110880000000000), 2, 2.01M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10677, "ANTON", 1, new DateTime(630104832000000000), new DateTime(630129024000000000), new DateTime(630108288000000000), 3, 4.03M, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", null, "05023", "Mexico"));
        this.Orders.Add(new OrdersItem(10678, "SAVEA", 7, new DateTime(630105696000000000), new DateTime(630129888000000000), new DateTime(630125568000000000), 3, 388.98M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10679, "BLONP", 8, new DateTime(630105696000000000), new DateTime(630129888000000000), new DateTime(630111744000000000), 3, 27.94M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10680, "OLDWO", 1, new DateTime(630106560000000000), new DateTime(630130752000000000), new DateTime(630108288000000000), 1, 26.61M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10681, "GREAL", 3, new DateTime(630107424000000000), new DateTime(630131616000000000), new DateTime(630111744000000000), 3, 76.13M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(10682, "ANTON", 3, new DateTime(630107424000000000), new DateTime(630131616000000000), new DateTime(630112608000000000), 2, 36.13M, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", null, "05023", "Mexico"));
        this.Orders.Add(new OrdersItem(10683, "DUMON", 2, new DateTime(630108288000000000), new DateTime(630132480000000000), new DateTime(630112608000000000), 1, 4.4M, "Du monde entier", "67, rue des Cinquante Otages", "Nantes", null, "44000", "France"));
        this.Orders.Add(new OrdersItem(10684, "OTTIK", 3, new DateTime(630108288000000000), new DateTime(630132480000000000), new DateTime(630111744000000000), 1, 145.63M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(10685, "GOURL", 4, new DateTime(630110880000000000), new DateTime(630122976000000000), new DateTime(630114336000000000), 2, 33.75M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(10686, "PICCO", 2, new DateTime(630111744000000000), new DateTime(630135936000000000), new DateTime(630118656000000000), 1, 96.5M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10687, "HUNGO", 9, new DateTime(630111744000000000), new DateTime(630135936000000000), new DateTime(630137664000000000), 2, 296.43M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10688, "VAFFE", 4, new DateTime(630112608000000000), new DateTime(630124704000000000), new DateTime(630117792000000000), 2, 299.09M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10689, "BERGS", 1, new DateTime(630112608000000000), new DateTime(630136800000000000), new DateTime(630117792000000000), 2, 13.42M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10690, "HANAR", 1, new DateTime(630113472000000000), new DateTime(630137664000000000), new DateTime(630114336000000000), 1, 15.8M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10691, "QUICK", 2, new DateTime(630114336000000000), new DateTime(630150624000000000), new DateTime(630130752000000000), 2, 810.05M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10692, "ALFKI", 4, new DateTime(630114336000000000), new DateTime(630138528000000000), new DateTime(630122976000000000), 2, 61.02M, "Alfred's Futterkiste", "Obere Str. 57", "Berlin", null, "12209", "Germany"));
        this.Orders.Add(new OrdersItem(10693, "WHITC", 3, new DateTime(630116928000000000), new DateTime(630129024000000000), new DateTime(630120384000000000), 3, 139.34M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10694, "QUICK", 8, new DateTime(630116928000000000), new DateTime(630141120000000000), new DateTime(630119520000000000), 3, 398.36M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10695, "WILMK", 7, new DateTime(630117792000000000), new DateTime(630154080000000000), new DateTime(630123840000000000), 1, 16.72M, "Wilman Kala", "Keskuskatu 45", "Helsinki", null, "21240", "Finland"));
        this.Orders.Add(new OrdersItem(10696, "WHITC", 8, new DateTime(630118656000000000), new DateTime(630154944000000000), new DateTime(630123840000000000), 3, 102.55M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10697, "LINOD", 3, new DateTime(630118656000000000), new DateTime(630142848000000000), new DateTime(630123840000000000), 1, 45.52M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10698, "ERNSH", 4, new DateTime(630119520000000000), new DateTime(630143712000000000), new DateTime(630126432000000000), 1, 272.47M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10699, "MORGK", 3, new DateTime(630119520000000000), new DateTime(630143712000000000), new DateTime(630122976000000000), 3, 0.58M, "Morgenstern Gesundkost", "Heerstr. 22", "Leipzig", null, "04179", "Germany"));
        this.Orders.Add(new OrdersItem(10700, "SAVEA", 3, new DateTime(630120384000000000), new DateTime(630144576000000000), new DateTime(630125568000000000), 1, 65.1M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10701, "HUNGO", 6, new DateTime(630122976000000000), new DateTime(630135072000000000), new DateTime(630124704000000000), 3, 220.31M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10702, "ALFKI", 4, new DateTime(630122976000000000), new DateTime(630159264000000000), new DateTime(630129888000000000), 1, 23.94M, "Alfred's Futterkiste", "Obere Str. 57", "Berlin", null, "12209", "Germany"));
        this.Orders.Add(new OrdersItem(10703, "FOLKO", 6, new DateTime(630123840000000000), new DateTime(630148032000000000), new DateTime(630129024000000000), 2, 152.3M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10704, "QUEEN", 6, new DateTime(630123840000000000), new DateTime(630148032000000000), new DateTime(630144576000000000), 1, 4.78M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10705, "HILAA", 9, new DateTime(630124704000000000), new DateTime(630148896000000000), new DateTime(630154080000000000), 2, 3.52M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10706, "OLDWO", 8, new DateTime(630125568000000000), new DateTime(630149760000000000), new DateTime(630129888000000000), 3, 135.63M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10707, "AROUT", 4, new DateTime(630125568000000000), new DateTime(630137664000000000), new DateTime(630131616000000000), 3, 21.74M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10708, "THEBI", 6, new DateTime(630126432000000000), new DateTime(630162720000000000), new DateTime(630142848000000000), 2, 2.96M, "The Big Cheese", "89 Jefferson Way Suite 2", "Portland", "OR", "97201", "USA"));
        this.Orders.Add(new OrdersItem(10709, "GOURL", 1, new DateTime(630126432000000000), new DateTime(630150624000000000), new DateTime(630155808000000000), 3, 210.8M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(10710, "FRANS", 1, new DateTime(630129024000000000), new DateTime(630153216000000000), new DateTime(630131616000000000), 1, 4.98M, "Franchi S.p.A.", "Via Monte Bianco 34", "Torino", null, "10100", "Italy"));
        this.Orders.Add(new OrdersItem(10711, "SAVEA", 5, new DateTime(630129888000000000), new DateTime(630166176000000000), new DateTime(630136800000000000), 2, 52.41M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10712, "HUNGO", 3, new DateTime(630129888000000000), new DateTime(630154080000000000), new DateTime(630138528000000000), 1, 89.93M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10713, "SAVEA", 1, new DateTime(630130752000000000), new DateTime(630154944000000000), new DateTime(630132480000000000), 1, 167.05M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10714, "SAVEA", 5, new DateTime(630130752000000000), new DateTime(630154944000000000), new DateTime(630135072000000000), 3, 24.49M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10715, "BONAP", 3, new DateTime(630131616000000000), new DateTime(630143712000000000), new DateTime(630136800000000000), 1, 63.2M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10716, "RANCH", 4, new DateTime(630132480000000000), new DateTime(630156672000000000), new DateTime(630135072000000000), 2, 22.57M, "Rancho grande", "Av. del Libertador 900", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10717, "FRANK", 1, new DateTime(630132480000000000), new DateTime(630156672000000000), new DateTime(630136800000000000), 2, 59.25M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10718, "KOENE", 1, new DateTime(630135072000000000), new DateTime(630159264000000000), new DateTime(630136800000000000), 3, 170.88M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10719, "LETSS", 8, new DateTime(630135072000000000), new DateTime(630159264000000000), new DateTime(630142848000000000), 2, 51.44M, "Let's Stop N Shop", "87 Polk St. Suite 5", "San Francisco", "CA", "94117", "USA"));
        this.Orders.Add(new OrdersItem(10720, "QUEDE", 8, new DateTime(630135936000000000), new DateTime(630148032000000000), new DateTime(630142848000000000), 2, 9.53M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10721, "QUICK", 5, new DateTime(630136800000000000), new DateTime(630160992000000000), new DateTime(630138528000000000), 3, 48.92M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10722, "SAVEA", 8, new DateTime(630136800000000000), new DateTime(630173088000000000), new DateTime(630141984000000000), 1, 74.58M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10723, "WHITC", 3, new DateTime(630137664000000000), new DateTime(630161856000000000), new DateTime(630160128000000000), 1, 21.72M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10724, "MEREP", 8, new DateTime(630137664000000000), new DateTime(630173952000000000), new DateTime(630142848000000000), 2, 57.75M, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
        this.Orders.Add(new OrdersItem(10725, "FAMIA", 4, new DateTime(630138528000000000), new DateTime(630162720000000000), new DateTime(630142848000000000), 3, 10.83M, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10726, "EASTC", 4, new DateTime(630141120000000000), new DateTime(630153216000000000), new DateTime(630168768000000000), 1, 16.56M, "Eastern Connection", "35 King George", "London", null, "WX3 6FW", "UK"));
        this.Orders.Add(new OrdersItem(10727, "REGGC", 2, new DateTime(630141120000000000), new DateTime(630165312000000000), new DateTime(630168768000000000), 1, 89.9M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10728, "QUEEN", 4, new DateTime(630141984000000000), new DateTime(630166176000000000), new DateTime(630148032000000000), 2, 58.33M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10729, "LINOD", 8, new DateTime(630141984000000000), new DateTime(630178272000000000), new DateTime(630150624000000000), 3, 141.06M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10730, "BONAP", 5, new DateTime(630142848000000000), new DateTime(630167040000000000), new DateTime(630150624000000000), 1, 20.12M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10731, "CHOPS", 7, new DateTime(630143712000000000), new DateTime(630167904000000000), new DateTime(630150624000000000), 1, 96.65M, "Chop-suey Chinese", "Hauptstr. 31", "Bern", null, "3012", "Switzerland"));
        this.Orders.Add(new OrdersItem(10732, "BONAP", 3, new DateTime(630143712000000000), new DateTime(630167904000000000), new DateTime(630144576000000000), 1, 16.97M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10733, "BERGS", 1, new DateTime(630144576000000000), new DateTime(630168768000000000), new DateTime(630147168000000000), 3, 110.11M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10734, "GOURL", 2, new DateTime(630144576000000000), new DateTime(630168768000000000), new DateTime(630148896000000000), 3, 1.63M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(10735, "LETSS", 6, new DateTime(630147168000000000), new DateTime(630171360000000000), new DateTime(630156672000000000), 2, 45.97M, "Let's Stop N Shop", "87 Polk St. Suite 5", "San Francisco", "CA", "94117", "USA"));
        this.Orders.Add(new OrdersItem(10736, "HUNGO", 9, new DateTime(630148032000000000), new DateTime(630172224000000000), new DateTime(630156672000000000), 2, 44.1M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10737, "VINET", 2, new DateTime(630148032000000000), new DateTime(630172224000000000), new DateTime(630154080000000000), 2, 7.79M, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", null, "51100", "France"));
        this.Orders.Add(new OrdersItem(10738, "SPECD", 2, new DateTime(630148896000000000), new DateTime(630173088000000000), new DateTime(630154080000000000), 1, 2.91M, "Spécialités du monde", "25, rue Lauriston", "Paris", null, "75016", "France"));
        this.Orders.Add(new OrdersItem(10739, "VINET", 3, new DateTime(630148896000000000), new DateTime(630173088000000000), new DateTime(630153216000000000), 3, 11.08M, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", null, "51100", "France"));
        this.Orders.Add(new OrdersItem(10740, "WHITC", 4, new DateTime(630149760000000000), new DateTime(630173952000000000), new DateTime(630160128000000000), 2, 81.88M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10741, "AROUT", 4, new DateTime(630150624000000000), new DateTime(630162720000000000), new DateTime(630154080000000000), 3, 10.96M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10742, "BOTTM", 3, new DateTime(630150624000000000), new DateTime(630174816000000000), new DateTime(630154080000000000), 3, 243.73M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10743, "AROUT", 1, new DateTime(630153216000000000), new DateTime(630177408000000000), new DateTime(630156672000000000), 2, 23.72M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10744, "VAFFE", 6, new DateTime(630153216000000000), new DateTime(630177408000000000), new DateTime(630159264000000000), 1, 69.19M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10745, "QUICK", 9, new DateTime(630154080000000000), new DateTime(630178272000000000), new DateTime(630161856000000000), 1, 3.52M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10746, "CHOPS", 1, new DateTime(630154944000000000), new DateTime(630179136000000000), new DateTime(630156672000000000), 3, 31.43M, "Chop-suey Chinese", "Hauptstr. 31", "Bern", null, "3012", "Switzerland"));
        this.Orders.Add(new OrdersItem(10747, "PICCO", 6, new DateTime(630154944000000000), new DateTime(630179136000000000), new DateTime(630160992000000000), 1, 117.33M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10748, "SAVEA", 3, new DateTime(630155808000000000), new DateTime(630180000000000000), new DateTime(630162720000000000), 1, 232.55M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10749, "ISLAT", 4, new DateTime(630155808000000000), new DateTime(630180000000000000), new DateTime(630180864000000000), 2, 61.53M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10750, "WARTH", 9, new DateTime(630156672000000000), new DateTime(630180864000000000), new DateTime(630159264000000000), 1, 79.3M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10751, "RICSU", 3, new DateTime(630159264000000000), new DateTime(630183456000000000), new DateTime(630167040000000000), 3, 130.79M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(10752, "NORTS", 2, new DateTime(630159264000000000), new DateTime(630183456000000000), new DateTime(630162720000000000), 3, 1.39M, "North/South", "South House 300 Queensbridge", "London", null, "SW7 1RZ", "UK"));
        this.Orders.Add(new OrdersItem(10753, "FRANS", 3, new DateTime(630160128000000000), new DateTime(630184320000000000), new DateTime(630161856000000000), 1, 7.7M, "Franchi S.p.A.", "Via Monte Bianco 34", "Torino", null, "10100", "Italy"));
        this.Orders.Add(new OrdersItem(10754, "MAGAA", 6, new DateTime(630160128000000000), new DateTime(630184320000000000), new DateTime(630161856000000000), 3, 2.38M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10755, "BONAP", 4, new DateTime(630160992000000000), new DateTime(630185184000000000), new DateTime(630162720000000000), 2, 16.71M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10756, "SPLIR", 8, new DateTime(630161856000000000), new DateTime(630186048000000000), new DateTime(630166176000000000), 2, 73.21M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10757, "SAVEA", 6, new DateTime(630161856000000000), new DateTime(630186048000000000), new DateTime(630177408000000000), 1, 8.19M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10758, "RICSU", 3, new DateTime(630162720000000000), new DateTime(630186912000000000), new DateTime(630167904000000000), 3, 138.17M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(10759, "ANATR", 3, new DateTime(630162720000000000), new DateTime(630186912000000000), new DateTime(630174816000000000), 3, 11.99M, "Ana Trujillo Emparedados y helados", "Avda. de la Constitución 2222", "México D.F.", null, "05021", "Mexico"));
        this.Orders.Add(new OrdersItem(10760, "MAISD", 4, new DateTime(630165312000000000), new DateTime(630189504000000000), new DateTime(630173088000000000), 1, 155.64M, "Maison Dewey", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium"));
        this.Orders.Add(new OrdersItem(10761, "RATTC", 5, new DateTime(630166176000000000), new DateTime(630190368000000000), new DateTime(630171360000000000), 2, 18.66M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10762, "FOLKO", 3, new DateTime(630166176000000000), new DateTime(630190368000000000), new DateTime(630172224000000000), 1, 328.74M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10763, "FOLIG", 3, new DateTime(630167040000000000), new DateTime(630191232000000000), new DateTime(630171360000000000), 3, 37.35M, "Folies gourmandes", "184, chaussée de Tournai", "Lille", null, "59000", "France"));
        this.Orders.Add(new OrdersItem(10764, "ERNSH", 6, new DateTime(630167040000000000), new DateTime(630191232000000000), new DateTime(630171360000000000), 3, 145.45M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10765, "QUICK", 3, new DateTime(630167904000000000), new DateTime(630192096000000000), new DateTime(630172224000000000), 3, 42.74M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10766, "OTTIK", 4, new DateTime(630168768000000000), new DateTime(630192960000000000), new DateTime(630172224000000000), 1, 157.55M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(10767, "SUPRD", 4, new DateTime(630168768000000000), new DateTime(630192960000000000), new DateTime(630177408000000000), 3, 1.59M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10768, "AROUT", 3, new DateTime(630171360000000000), new DateTime(630195552000000000), new DateTime(630177408000000000), 2, 146.32M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10769, "VAFFE", 3, new DateTime(630171360000000000), new DateTime(630195552000000000), new DateTime(630174816000000000), 1, 65.06M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10770, "HANAR", 8, new DateTime(630172224000000000), new DateTime(630196416000000000), new DateTime(630179136000000000), 3, 5.32M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10771, "ERNSH", 9, new DateTime(630173088000000000), new DateTime(630197280000000000), new DateTime(630192960000000000), 2, 11.19M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10772, "LEHMS", 3, new DateTime(630173088000000000), new DateTime(630197280000000000), new DateTime(630180864000000000), 2, 91.28M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10773, "ERNSH", 1, new DateTime(630173952000000000), new DateTime(630198144000000000), new DateTime(630178272000000000), 3, 96.43M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10774, "FOLKO", 4, new DateTime(630173952000000000), new DateTime(630186048000000000), new DateTime(630174816000000000), 1, 48.2M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10775, "THECR", 7, new DateTime(630174816000000000), new DateTime(630199008000000000), new DateTime(630186912000000000), 1, 20.25M, "The Cracker Box", "55 Grizzly Peak Rd.", "Butte", "MT", "59801", "USA"));
        this.Orders.Add(new OrdersItem(10776, "ERNSH", 1, new DateTime(630177408000000000), new DateTime(630201600000000000), new DateTime(630180000000000000), 3, 351.53M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10777, "GOURL", 7, new DateTime(630177408000000000), new DateTime(630189504000000000), new DateTime(630209376000000000), 2, 3.01M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(10778, "BERGS", 3, new DateTime(630178272000000000), new DateTime(630202464000000000), new DateTime(630185184000000000), 1, 6.79M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10779, "MORGK", 3, new DateTime(630178272000000000), new DateTime(630202464000000000), new DateTime(630203328000000000), 2, 58.13M, "Morgenstern Gesundkost", "Heerstr. 22", "Leipzig", null, "04179", "Germany"));
        this.Orders.Add(new OrdersItem(10780, "LILAS", 2, new DateTime(630178272000000000), new DateTime(630190368000000000), new DateTime(630186048000000000), 1, 42.13M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10781, "WARTH", 2, new DateTime(630179136000000000), new DateTime(630203328000000000), new DateTime(630180864000000000), 3, 73.16M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(10782, "CACTU", 9, new DateTime(630179136000000000), new DateTime(630203328000000000), new DateTime(630183456000000000), 3, 1.1M, "Cactus Comidas para llevar", "Cerrito 333", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10783, "HANAR", 4, new DateTime(630180000000000000), new DateTime(630204192000000000), new DateTime(630180864000000000), 2, 124.98M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10784, "MAGAA", 4, new DateTime(630180000000000000), new DateTime(630204192000000000), new DateTime(630183456000000000), 3, 70.09M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10785, "GROSR", 1, new DateTime(630180000000000000), new DateTime(630204192000000000), new DateTime(630185184000000000), 3, 1.51M, "GROSELLA-Restaurante", "5ª Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela"));
        this.Orders.Add(new OrdersItem(10786, "QUEEN", 8, new DateTime(630180864000000000), new DateTime(630205056000000000), new DateTime(630184320000000000), 1, 110.87M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10787, "LAMAI", 2, new DateTime(630180864000000000), new DateTime(630192960000000000), new DateTime(630186912000000000), 1, 249.93M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10788, "QUICK", 1, new DateTime(630183456000000000), new DateTime(630207648000000000), new DateTime(630207648000000000), 2, 42.7M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10789, "FOLIG", 1, new DateTime(630183456000000000), new DateTime(630207648000000000), new DateTime(630191232000000000), 2, 100.6M, "Folies gourmandes", "184, chaussée de Tournai", "Lille", null, "59000", "France"));
        this.Orders.Add(new OrdersItem(10790, "GOURL", 6, new DateTime(630183456000000000), new DateTime(630207648000000000), new DateTime(630186912000000000), 1, 28.23M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(10791, "FRANK", 6, new DateTime(630184320000000000), new DateTime(630208512000000000), new DateTime(630192096000000000), 2, 16.85M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10792, "WOLZA", 1, new DateTime(630184320000000000), new DateTime(630208512000000000), new DateTime(630191232000000000), 3, 23.79M, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland"));
        this.Orders.Add(new OrdersItem(10793, "AROUT", 3, new DateTime(630185184000000000), new DateTime(630209376000000000), new DateTime(630198144000000000), 3, 4.52M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10794, "QUEDE", 6, new DateTime(630185184000000000), new DateTime(630209376000000000), new DateTime(630192960000000000), 1, 21.49M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10795, "ERNSH", 8, new DateTime(630185184000000000), new DateTime(630209376000000000), new DateTime(630208512000000000), 2, 126.66M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10796, "HILAA", 3, new DateTime(630186048000000000), new DateTime(630210240000000000), new DateTime(630203328000000000), 1, 26.52M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10797, "DRACD", 7, new DateTime(630186048000000000), new DateTime(630210240000000000), new DateTime(630195552000000000), 2, 33.35M, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", null, "52066", "Germany"));
        this.Orders.Add(new OrdersItem(10798, "ISLAT", 2, new DateTime(630186912000000000), new DateTime(630211104000000000), new DateTime(630195552000000000), 1, 2.33M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10799, "KOENE", 9, new DateTime(630186912000000000), new DateTime(630223200000000000), new DateTime(630195552000000000), 3, 30.76M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10800, "SEVES", 1, new DateTime(630186912000000000), new DateTime(630211104000000000), new DateTime(630195552000000000), 3, 137.44M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10801, "BOLID", 4, new DateTime(630189504000000000), new DateTime(630213696000000000), new DateTime(630191232000000000), 2, 97.09M, "Bólido Comidas preparadas", "C/ Araquil, 67", "Madrid", null, "28023", "Spain"));
        this.Orders.Add(new OrdersItem(10802, "SIMOB", 4, new DateTime(630189504000000000), new DateTime(630213696000000000), new DateTime(630192960000000000), 2, 257.26M, "Simons bistro", "Vinbæltet 34", "Kobenhavn", null, "1734", "Denmark"));
        this.Orders.Add(new OrdersItem(10803, "WELLI", 4, new DateTime(630190368000000000), new DateTime(630214560000000000), new DateTime(630196416000000000), 1, 55.23M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10804, "SEVES", 6, new DateTime(630190368000000000), new DateTime(630214560000000000), new DateTime(630197280000000000), 2, 27.33M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10805, "THEBI", 2, new DateTime(630190368000000000), new DateTime(630214560000000000), new DateTime(630199008000000000), 3, 237.34M, "The Big Cheese", "89 Jefferson Way Suite 2", "Portland", "OR", "97201", "USA"));
        this.Orders.Add(new OrdersItem(10806, "VICTE", 3, new DateTime(630191232000000000), new DateTime(630215424000000000), new DateTime(630195552000000000), 2, 22.11M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10807, "FRANS", 4, new DateTime(630191232000000000), new DateTime(630215424000000000), new DateTime(630217152000000000), 1, 1.36M, "Franchi S.p.A.", "Via Monte Bianco 34", "Torino", null, "10100", "Italy"));
        this.Orders.Add(new OrdersItem(10808, "OLDWO", 2, new DateTime(630192096000000000), new DateTime(630216288000000000), new DateTime(630199008000000000), 3, 45.53M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10809, "WELLI", 7, new DateTime(630192096000000000), new DateTime(630216288000000000), new DateTime(630197280000000000), 1, 4.87M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10810, "LAUGB", 2, new DateTime(630192096000000000), new DateTime(630216288000000000), new DateTime(630197280000000000), 3, 4.33M, "Laughing Bacchus Wine Cellars", "2319 Elm St.", "Vancouver", "BC", "V3F 2K1", "Canada"));
        this.Orders.Add(new OrdersItem(10811, "LINOD", 8, new DateTime(630192960000000000), new DateTime(630217152000000000), new DateTime(630198144000000000), 1, 31.22M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10812, "REGGC", 5, new DateTime(630192960000000000), new DateTime(630217152000000000), new DateTime(630201600000000000), 1, 59.78M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10813, "RICAR", 1, new DateTime(630195552000000000), new DateTime(630219744000000000), new DateTime(630199008000000000), 1, 47.38M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10814, "VICTE", 3, new DateTime(630195552000000000), new DateTime(630219744000000000), new DateTime(630203328000000000), 3, 130.94M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10815, "SAVEA", 2, new DateTime(630195552000000000), new DateTime(630219744000000000), new DateTime(630203328000000000), 3, 14.62M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10816, "GREAL", 4, new DateTime(630196416000000000), new DateTime(630220608000000000), new DateTime(630221472000000000), 2, 719.78M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(10817, "KOENE", 3, new DateTime(630196416000000000), new DateTime(630208512000000000), new DateTime(630202464000000000), 2, 306.07M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10818, "MAGAA", 7, new DateTime(630197280000000000), new DateTime(630221472000000000), new DateTime(630201600000000000), 3, 65.48M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10819, "CACTU", 2, new DateTime(630197280000000000), new DateTime(630221472000000000), new DateTime(630205056000000000), 3, 19.76M, "Cactus Comidas para llevar", "Cerrito 333", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10820, "RATTC", 3, new DateTime(630197280000000000), new DateTime(630221472000000000), new DateTime(630202464000000000), 2, 37.52M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10821, "SPLIR", 1, new DateTime(630198144000000000), new DateTime(630222336000000000), new DateTime(630204192000000000), 1, 36.68M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10822, "TRAIH", 6, new DateTime(630198144000000000), new DateTime(630222336000000000), new DateTime(630205056000000000), 3, 7M, "Trail's Head Gourmet Provisioners", "722 DaVinci Blvd.", "Kirkland", "WA", "98034", "USA"));
        this.Orders.Add(new OrdersItem(10823, "LILAS", 5, new DateTime(630199008000000000), new DateTime(630223200000000000), new DateTime(630202464000000000), 2, 163.97M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10824, "FOLKO", 8, new DateTime(630199008000000000), new DateTime(630223200000000000), new DateTime(630217152000000000), 1, 1.23M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10825, "DRACD", 1, new DateTime(630199008000000000), new DateTime(630223200000000000), new DateTime(630203328000000000), 1, 79.25M, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", null, "52066", "Germany"));
        this.Orders.Add(new OrdersItem(10826, "BLONP", 6, new DateTime(630201600000000000), new DateTime(630225792000000000), new DateTime(630223200000000000), 1, 7.09M, "Blondel père et fils", "24, place Kléber", "Strasbourg", null, "67000", "France"));
        this.Orders.Add(new OrdersItem(10827, "BONAP", 1, new DateTime(630201600000000000), new DateTime(630213696000000000), new DateTime(630223200000000000), 2, 63.54M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10828, "RANCH", 9, new DateTime(630202464000000000), new DateTime(630214560000000000), new DateTime(630221472000000000), 1, 90.85M, "Rancho grande", "Av. del Libertador 900", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10829, "ISLAT", 9, new DateTime(630202464000000000), new DateTime(630226656000000000), new DateTime(630211104000000000), 1, 154.72M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10830, "TRADH", 4, new DateTime(630202464000000000), new DateTime(630238752000000000), new DateTime(630209376000000000), 2, 81.83M, "Tradiçao Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10831, "SANTG", 3, new DateTime(630203328000000000), new DateTime(630227520000000000), new DateTime(630211104000000000), 2, 72.19M, "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", null, "4110", "Norway"));
        this.Orders.Add(new OrdersItem(10832, "LAMAI", 2, new DateTime(630203328000000000), new DateTime(630227520000000000), new DateTime(630207648000000000), 2, 43.26M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10833, "OTTIK", 6, new DateTime(630204192000000000), new DateTime(630228384000000000), new DateTime(630211104000000000), 2, 71.49M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(10834, "TRADH", 1, new DateTime(630204192000000000), new DateTime(630228384000000000), new DateTime(630207648000000000), 3, 29.78M, "Tradiçao Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10835, "ALFKI", 1, new DateTime(630204192000000000), new DateTime(630228384000000000), new DateTime(630209376000000000), 3, 69.53M, "Alfred's Futterkiste", "Obere Str. 57", "Berlin", null, "12209", "Germany"));
        this.Orders.Add(new OrdersItem(10836, "ERNSH", 7, new DateTime(630205056000000000), new DateTime(630229248000000000), new DateTime(630209376000000000), 1, 411.88M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10837, "BERGS", 9, new DateTime(630205056000000000), new DateTime(630229248000000000), new DateTime(630211104000000000), 3, 13.32M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10838, "LINOD", 3, new DateTime(630207648000000000), new DateTime(630231840000000000), new DateTime(630211104000000000), 3, 59.28M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10839, "TRADH", 3, new DateTime(630207648000000000), new DateTime(630231840000000000), new DateTime(630210240000000000), 3, 35.43M, "Tradiçao Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil"));
        this.Orders.Add(new OrdersItem(10840, "LINOD", 4, new DateTime(630207648000000000), new DateTime(630243936000000000), new DateTime(630231840000000000), 2, 2.71M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10841, "SUPRD", 5, new DateTime(630208512000000000), new DateTime(630232704000000000), new DateTime(630216288000000000), 2, 424.3M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10842, "TORTU", 1, new DateTime(630208512000000000), new DateTime(630232704000000000), new DateTime(630216288000000000), 3, 54.42M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10843, "VICTE", 4, new DateTime(630209376000000000), new DateTime(630233568000000000), new DateTime(630213696000000000), 2, 9.26M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10844, "PICCO", 8, new DateTime(630209376000000000), new DateTime(630233568000000000), new DateTime(630213696000000000), 2, 25.22M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(10845, "QUICK", 8, new DateTime(630209376000000000), new DateTime(630221472000000000), new DateTime(630217152000000000), 1, 212.98M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10846, "SUPRD", 2, new DateTime(630210240000000000), new DateTime(630246528000000000), new DateTime(630211104000000000), 3, 56.46M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10847, "SAVEA", 4, new DateTime(630210240000000000), new DateTime(630222336000000000), new DateTime(630226656000000000), 3, 487.57M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10848, "CONSH", 7, new DateTime(630211104000000000), new DateTime(630235296000000000), new DateTime(630216288000000000), 2, 38.24M, "Consolidated Holdings", "Berkeley Gardens 12  Brewery", "London", null, "WX1 6LT", "UK"));
        this.Orders.Add(new OrdersItem(10849, "KOENE", 9, new DateTime(630211104000000000), new DateTime(630235296000000000), new DateTime(630217152000000000), 2, 0.56M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10850, "VICTE", 1, new DateTime(630211104000000000), new DateTime(630247392000000000), new DateTime(630217152000000000), 1, 49.19M, "Victuailles en stock", "2, rue du Commerce", "Lyon", null, "69004", "France"));
        this.Orders.Add(new OrdersItem(10851, "RICAR", 5, new DateTime(630213696000000000), new DateTime(630237888000000000), new DateTime(630219744000000000), 1, 160.55M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10852, "RATTC", 8, new DateTime(630213696000000000), new DateTime(630225792000000000), new DateTime(630217152000000000), 1, 174.05M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10853, "BLAUS", 9, new DateTime(630214560000000000), new DateTime(630238752000000000), new DateTime(630220608000000000), 2, 53.83M, "Blauer See Delikatessen", "Forsterstr. 57", "Mannheim", null, "68306", "Germany"));
        this.Orders.Add(new OrdersItem(10854, "ERNSH", 3, new DateTime(630214560000000000), new DateTime(630238752000000000), new DateTime(630222336000000000), 2, 100.22M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10855, "OLDWO", 3, new DateTime(630214560000000000), new DateTime(630238752000000000), new DateTime(630221472000000000), 1, 170.97M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10856, "ANTON", 3, new DateTime(630215424000000000), new DateTime(630239616000000000), new DateTime(630226656000000000), 2, 58.43M, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", null, "05023", "Mexico"));
        this.Orders.Add(new OrdersItem(10857, "BERGS", 8, new DateTime(630215424000000000), new DateTime(630239616000000000), new DateTime(630223200000000000), 2, 188.85M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10858, "LACOR", 2, new DateTime(630216288000000000), new DateTime(630240480000000000), new DateTime(630220608000000000), 1, 52.51M, "La corne d'abondance", "67, avenue de l'Europe", "Versailles", null, "78000", "France"));
        this.Orders.Add(new OrdersItem(10859, "FRANK", 1, new DateTime(630216288000000000), new DateTime(630240480000000000), new DateTime(630219744000000000), 2, 76.1M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10860, "FRANR", 3, new DateTime(630216288000000000), new DateTime(630240480000000000), new DateTime(630221472000000000), 3, 19.26M, "France restauration", "54, rue Royale", "Nantes", null, "44000", "France"));
        this.Orders.Add(new OrdersItem(10861, "WHITC", 4, new DateTime(630217152000000000), new DateTime(630241344000000000), new DateTime(630232704000000000), 2, 14.93M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10862, "LEHMS", 8, new DateTime(630217152000000000), new DateTime(630253440000000000), new DateTime(630219744000000000), 2, 53.23M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10863, "HILAA", 4, new DateTime(630219744000000000), new DateTime(630243936000000000), new DateTime(630232704000000000), 2, 30.26M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10864, "AROUT", 4, new DateTime(630219744000000000), new DateTime(630243936000000000), new DateTime(630225792000000000), 2, 3.04M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10865, "QUICK", 2, new DateTime(630219744000000000), new DateTime(630231840000000000), new DateTime(630228384000000000), 1, 348.14M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10866, "BERGS", 5, new DateTime(630220608000000000), new DateTime(630244800000000000), new DateTime(630228384000000000), 1, 109.11M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10867, "LONEP", 6, new DateTime(630220608000000000), new DateTime(630256896000000000), new DateTime(630227520000000000), 1, 1.93M, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
        this.Orders.Add(new OrdersItem(10868, "QUEEN", 7, new DateTime(630221472000000000), new DateTime(630245664000000000), new DateTime(630237888000000000), 2, 191.27M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10869, "SEVES", 5, new DateTime(630221472000000000), new DateTime(630245664000000000), new DateTime(630225792000000000), 1, 143.28M, "Seven Seas Imports", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK"));
        this.Orders.Add(new OrdersItem(10870, "WOLZA", 5, new DateTime(630221472000000000), new DateTime(630245664000000000), new DateTime(630229248000000000), 3, 12.04M, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland"));
        this.Orders.Add(new OrdersItem(10871, "BONAP", 9, new DateTime(630222336000000000), new DateTime(630246528000000000), new DateTime(630226656000000000), 2, 112.27M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10872, "GODOS", 5, new DateTime(630222336000000000), new DateTime(630246528000000000), new DateTime(630225792000000000), 2, 175.32M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(10873, "WILMK", 4, new DateTime(630223200000000000), new DateTime(630247392000000000), new DateTime(630225792000000000), 1, 0.82M, "Wilman Kala", "Keskuskatu 45", "Helsinki", null, "21240", "Finland"));
        this.Orders.Add(new OrdersItem(10874, "GODOS", 5, new DateTime(630223200000000000), new DateTime(630247392000000000), new DateTime(630227520000000000), 2, 19.58M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(10875, "BERGS", 4, new DateTime(630223200000000000), new DateTime(630247392000000000), new DateTime(630244800000000000), 2, 32.37M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10876, "BONAP", 7, new DateTime(630225792000000000), new DateTime(630249984000000000), new DateTime(630228384000000000), 3, 60.42M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10877, "RICAR", 1, new DateTime(630225792000000000), new DateTime(630249984000000000), new DateTime(630234432000000000), 1, 38.06M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(10878, "QUICK", 4, new DateTime(630226656000000000), new DateTime(630250848000000000), new DateTime(630228384000000000), 1, 46.69M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10879, "WILMK", 3, new DateTime(630226656000000000), new DateTime(630250848000000000), new DateTime(630228384000000000), 3, 8.5M, "Wilman Kala", "Keskuskatu 45", "Helsinki", null, "21240", "Finland"));
        this.Orders.Add(new OrdersItem(10880, "FOLKO", 7, new DateTime(630226656000000000), new DateTime(630262944000000000), new DateTime(630233568000000000), 1, 88.01M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10881, "CACTU", 4, new DateTime(630227520000000000), new DateTime(630251712000000000), new DateTime(630233568000000000), 1, 2.84M, "Cactus Comidas para llevar", "Cerrito 333", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10882, "SAVEA", 4, new DateTime(630227520000000000), new DateTime(630251712000000000), new DateTime(630235296000000000), 3, 23.1M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10883, "LONEP", 8, new DateTime(630228384000000000), new DateTime(630252576000000000), new DateTime(630235296000000000), 3, 0.53M, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
        this.Orders.Add(new OrdersItem(10884, "LETSS", 4, new DateTime(630228384000000000), new DateTime(630252576000000000), new DateTime(630229248000000000), 2, 90.97M, "Let's Stop N Shop", "87 Polk St. Suite 5", "San Francisco", "CA", "94117", "USA"));
        this.Orders.Add(new OrdersItem(10885, "SUPRD", 6, new DateTime(630228384000000000), new DateTime(630252576000000000), new DateTime(630233568000000000), 3, 5.64M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10886, "HANAR", 1, new DateTime(630229248000000000), new DateTime(630253440000000000), new DateTime(630243936000000000), 1, 4.99M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10887, "GALED", 8, new DateTime(630229248000000000), new DateTime(630253440000000000), new DateTime(630231840000000000), 3, 1.25M, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", null, "8022", "Spain"));
        this.Orders.Add(new OrdersItem(10888, "GODOS", 1, new DateTime(630231840000000000), new DateTime(630256032000000000), new DateTime(630237888000000000), 2, 51.87M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(10889, "RATTC", 9, new DateTime(630231840000000000), new DateTime(630256032000000000), new DateTime(630237888000000000), 3, 280.61M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10890, "DUMON", 7, new DateTime(630231840000000000), new DateTime(630256032000000000), new DateTime(630233568000000000), 1, 32.76M, "Du monde entier", "67, rue des Cinquante Otages", "Nantes", null, "44000", "France"));
        this.Orders.Add(new OrdersItem(10891, "LEHMS", 7, new DateTime(630232704000000000), new DateTime(630256896000000000), new DateTime(630234432000000000), 2, 20.37M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10892, "MAISD", 4, new DateTime(630232704000000000), new DateTime(630256896000000000), new DateTime(630234432000000000), 2, 120.27M, "Maison Dewey", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium"));
        this.Orders.Add(new OrdersItem(10893, "KOENE", 9, new DateTime(630233568000000000), new DateTime(630257760000000000), new DateTime(630235296000000000), 2, 77.78M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(10894, "SAVEA", 1, new DateTime(630233568000000000), new DateTime(630257760000000000), new DateTime(630235296000000000), 1, 116.13M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10895, "ERNSH", 3, new DateTime(630233568000000000), new DateTime(630257760000000000), new DateTime(630237888000000000), 1, 162.75M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10896, "MAISD", 7, new DateTime(630234432000000000), new DateTime(630258624000000000), new DateTime(630241344000000000), 3, 32.45M, "Maison Dewey", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium"));
        this.Orders.Add(new OrdersItem(10897, "HUNGO", 3, new DateTime(630234432000000000), new DateTime(630258624000000000), new DateTime(630239616000000000), 2, 603.54M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10898, "OCEAN", 4, new DateTime(630235296000000000), new DateTime(630259488000000000), new DateTime(630247392000000000), 2, 1.27M, "Océano Atlántico Ltda.", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10899, "LILAS", 5, new DateTime(630235296000000000), new DateTime(630259488000000000), new DateTime(630240480000000000), 3, 1.21M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10900, "WELLI", 1, new DateTime(630235296000000000), new DateTime(630259488000000000), new DateTime(630245664000000000), 2, 1.66M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10901, "HILAA", 4, new DateTime(630237888000000000), new DateTime(630262080000000000), new DateTime(630240480000000000), 1, 62.09M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10902, "FOLKO", 1, new DateTime(630237888000000000), new DateTime(630262080000000000), new DateTime(630244800000000000), 1, 44.15M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10903, "HANAR", 3, new DateTime(630238752000000000), new DateTime(630262944000000000), new DateTime(630245664000000000), 3, 36.71M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10904, "WHITC", 3, new DateTime(630238752000000000), new DateTime(630262944000000000), new DateTime(630241344000000000), 3, 162.95M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(10905, "WELLI", 9, new DateTime(630238752000000000), new DateTime(630262944000000000), new DateTime(630247392000000000), 2, 13.72M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10906, "WOLZA", 4, new DateTime(630239616000000000), new DateTime(630251712000000000), new DateTime(630244800000000000), 3, 26.29M, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland"));
        this.Orders.Add(new OrdersItem(10907, "SPECD", 6, new DateTime(630239616000000000), new DateTime(630263808000000000), new DateTime(630241344000000000), 3, 9.19M, "Spécialités du monde", "25, rue Lauriston", "Paris", null, "75016", "France"));
        this.Orders.Add(new OrdersItem(10908, "REGGC", 4, new DateTime(630240480000000000), new DateTime(630264672000000000), new DateTime(630247392000000000), 2, 32.96M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10909, "SANTG", 1, new DateTime(630240480000000000), new DateTime(630264672000000000), new DateTime(630250848000000000), 2, 53.05M, "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", null, "4110", "Norway"));
        this.Orders.Add(new OrdersItem(10910, "WILMK", 1, new DateTime(630240480000000000), new DateTime(630264672000000000), new DateTime(630245664000000000), 3, 38.11M, "Wilman Kala", "Keskuskatu 45", "Helsinki", null, "21240", "Finland"));
        this.Orders.Add(new OrdersItem(10911, "GODOS", 3, new DateTime(630240480000000000), new DateTime(630264672000000000), new DateTime(630246528000000000), 1, 38.19M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(10912, "HUNGO", 2, new DateTime(630240480000000000), new DateTime(630264672000000000), new DateTime(630257760000000000), 2, 580.91M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10913, "QUEEN", 4, new DateTime(630240480000000000), new DateTime(630264672000000000), new DateTime(630245664000000000), 1, 33.05M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10914, "QUEEN", 6, new DateTime(630241344000000000), new DateTime(630265536000000000), new DateTime(630243936000000000), 1, 21.19M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10915, "TORTU", 2, new DateTime(630241344000000000), new DateTime(630265536000000000), new DateTime(630243936000000000), 2, 3.51M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10916, "RANCH", 1, new DateTime(630241344000000000), new DateTime(630265536000000000), new DateTime(630249984000000000), 2, 63.77M, "Rancho grande", "Av. del Libertador 900", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10917, "ROMEY", 4, new DateTime(630243936000000000), new DateTime(630268128000000000), new DateTime(630251712000000000), 2, 8.29M, "Romero y tomillo", "Gran Vía, 1", "Madrid", null, "28001", "Spain"));
        this.Orders.Add(new OrdersItem(10918, "BOTTM", 3, new DateTime(630243936000000000), new DateTime(630268128000000000), new DateTime(630251712000000000), 3, 48.83M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10919, "LINOD", 2, new DateTime(630243936000000000), new DateTime(630268128000000000), new DateTime(630245664000000000), 2, 19.8M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10920, "AROUT", 4, new DateTime(630244800000000000), new DateTime(630268992000000000), new DateTime(630249984000000000), 2, 29.61M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10921, "VAFFE", 1, new DateTime(630244800000000000), new DateTime(630281088000000000), new DateTime(630249984000000000), 1, 176.48M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10922, "HANAR", 5, new DateTime(630244800000000000), new DateTime(630268992000000000), new DateTime(630246528000000000), 3, 62.74M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10923, "LAMAI", 7, new DateTime(630244800000000000), new DateTime(630281088000000000), new DateTime(630253440000000000), 3, 68.26M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(10924, "BERGS", 3, new DateTime(630245664000000000), new DateTime(630269856000000000), new DateTime(630275904000000000), 2, 151.52M, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", null, "S-958 22", "Sweden"));
        this.Orders.Add(new OrdersItem(10925, "HANAR", 3, new DateTime(630245664000000000), new DateTime(630269856000000000), new DateTime(630253440000000000), 1, 2.27M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10926, "ANATR", 4, new DateTime(630245664000000000), new DateTime(630269856000000000), new DateTime(630251712000000000), 3, 39.92M, "Ana Trujillo Emparedados y helados", "Avda. de la Constitución 2222", "México D.F.", null, "05021", "Mexico"));
        this.Orders.Add(new OrdersItem(10927, "LACOR", 4, new DateTime(630246528000000000), new DateTime(630270720000000000), new DateTime(630275904000000000), 1, 19.79M, "La corne d'abondance", "67, avenue de l'Europe", "Versailles", null, "78000", "France"));
        this.Orders.Add(new OrdersItem(10928, "GALED", 1, new DateTime(630246528000000000), new DateTime(630270720000000000), new DateTime(630257760000000000), 1, 1.36M, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", null, "8022", "Spain"));
        this.Orders.Add(new OrdersItem(10929, "FRANK", 6, new DateTime(630246528000000000), new DateTime(630270720000000000), new DateTime(630252576000000000), 1, 33.93M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(10930, "SUPRD", 4, new DateTime(630247392000000000), new DateTime(630283680000000000), new DateTime(630257760000000000), 3, 15.55M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(10931, "RICSU", 4, new DateTime(630247392000000000), new DateTime(630259488000000000), new DateTime(630258624000000000), 2, 13.6M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(10932, "BONAP", 8, new DateTime(630247392000000000), new DateTime(630271584000000000), new DateTime(630262944000000000), 1, 134.64M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10933, "ISLAT", 6, new DateTime(630247392000000000), new DateTime(630271584000000000), new DateTime(630256032000000000), 3, 54.15M, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
        this.Orders.Add(new OrdersItem(10934, "LEHMS", 3, new DateTime(630249984000000000), new DateTime(630274176000000000), new DateTime(630252576000000000), 3, 32.01M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(10935, "WELLI", 4, new DateTime(630249984000000000), new DateTime(630274176000000000), new DateTime(630257760000000000), 3, 47.59M, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
        this.Orders.Add(new OrdersItem(10936, "GREAL", 3, new DateTime(630249984000000000), new DateTime(630274176000000000), new DateTime(630257760000000000), 2, 33.68M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(10937, "CACTU", 7, new DateTime(630250848000000000), new DateTime(630262944000000000), new DateTime(630253440000000000), 3, 31.51M, "Cactus Comidas para llevar", "Cerrito 333", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10938, "QUICK", 3, new DateTime(630250848000000000), new DateTime(630275040000000000), new DateTime(630256032000000000), 2, 31.89M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10939, "MAGAA", 2, new DateTime(630250848000000000), new DateTime(630275040000000000), new DateTime(630253440000000000), 2, 76.33M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10940, "BONAP", 8, new DateTime(630251712000000000), new DateTime(630275904000000000), new DateTime(630262080000000000), 3, 19.77M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(10941, "SAVEA", 7, new DateTime(630251712000000000), new DateTime(630275904000000000), new DateTime(630259488000000000), 2, 400.81M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10942, "REGGC", 9, new DateTime(630251712000000000), new DateTime(630275904000000000), new DateTime(630257760000000000), 3, 17.95M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(10943, "BSBEV", 4, new DateTime(630251712000000000), new DateTime(630275904000000000), new DateTime(630258624000000000), 2, 2.17M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10944, "BOTTM", 6, new DateTime(630252576000000000), new DateTime(630264672000000000), new DateTime(630253440000000000), 3, 52.92M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10945, "MORGK", 4, new DateTime(630252576000000000), new DateTime(630276768000000000), new DateTime(630257760000000000), 1, 10.22M, "Morgenstern Gesundkost", "Heerstr. 22", "Leipzig", null, "04179", "Germany"));
        this.Orders.Add(new OrdersItem(10946, "VAFFE", 1, new DateTime(630252576000000000), new DateTime(630276768000000000), new DateTime(630258624000000000), 2, 27.2M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10947, "BSBEV", 3, new DateTime(630253440000000000), new DateTime(630277632000000000), new DateTime(630256032000000000), 2, 3.26M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(10948, "GODOS", 3, new DateTime(630253440000000000), new DateTime(630277632000000000), new DateTime(630258624000000000), 3, 23.39M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(10949, "BOTTM", 2, new DateTime(630253440000000000), new DateTime(630277632000000000), new DateTime(630256896000000000), 3, 74.44M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10950, "MAGAA", 1, new DateTime(630256032000000000), new DateTime(630280224000000000), new DateTime(630262080000000000), 2, 2.5M, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy"));
        this.Orders.Add(new OrdersItem(10951, "RICSU", 9, new DateTime(630256032000000000), new DateTime(630292320000000000), new DateTime(630275040000000000), 2, 30.85M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(10952, "ALFKI", 1, new DateTime(630256032000000000), new DateTime(630292320000000000), new DateTime(630262944000000000), 1, 40.42M, "Alfred's Futterkiste", "Obere Str. 57", "Berlin", null, "12209", "Germany"));
        this.Orders.Add(new OrdersItem(10953, "AROUT", 9, new DateTime(630256032000000000), new DateTime(630268128000000000), new DateTime(630263808000000000), 2, 23.72M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(10954, "LINOD", 5, new DateTime(630256896000000000), new DateTime(630293184000000000), new DateTime(630259488000000000), 1, 27.91M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(10955, "FOLKO", 8, new DateTime(630256896000000000), new DateTime(630281088000000000), new DateTime(630259488000000000), 2, 3.26M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10956, "BLAUS", 6, new DateTime(630256896000000000), new DateTime(630293184000000000), new DateTime(630259488000000000), 2, 44.65M, "Blauer See Delikatessen", "Forsterstr. 57", "Mannheim", null, "68306", "Germany"));
        this.Orders.Add(new OrdersItem(10957, "HILAA", 8, new DateTime(630257760000000000), new DateTime(630281952000000000), new DateTime(630265536000000000), 3, 105.36M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10958, "OCEAN", 7, new DateTime(630257760000000000), new DateTime(630281952000000000), new DateTime(630265536000000000), 2, 49.56M, "Océano Atlántico Ltda.", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10959, "GOURL", 6, new DateTime(630257760000000000), new DateTime(630294048000000000), new DateTime(630262080000000000), 2, 4.98M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(10960, "HILAA", 3, new DateTime(630258624000000000), new DateTime(630270720000000000), new DateTime(630275904000000000), 1, 2.08M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10961, "QUEEN", 8, new DateTime(630258624000000000), new DateTime(630282816000000000), new DateTime(630268128000000000), 1, 104.47M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(10962, "QUICK", 8, new DateTime(630258624000000000), new DateTime(630282816000000000), new DateTime(630262080000000000), 2, 275.79M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10963, "FURIB", 9, new DateTime(630258624000000000), new DateTime(630282816000000000), new DateTime(630264672000000000), 3, 2.7M, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal"));
        this.Orders.Add(new OrdersItem(10964, "SPECD", 3, new DateTime(630259488000000000), new DateTime(630283680000000000), new DateTime(630262944000000000), 2, 87.38M, "Spécialités du monde", "25, rue Lauriston", "Paris", null, "75016", "France"));
        this.Orders.Add(new OrdersItem(10965, "OLDWO", 6, new DateTime(630259488000000000), new DateTime(630283680000000000), new DateTime(630268128000000000), 3, 144.38M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(10966, "CHOPS", 4, new DateTime(630259488000000000), new DateTime(630283680000000000), new DateTime(630275904000000000), 1, 27.19M, "Chop-suey Chinese", "Hauptstr. 31", "Bern", null, "3012", "Switzerland"));
        this.Orders.Add(new OrdersItem(10967, "TOMSP", 2, new DateTime(630262080000000000), new DateTime(630286272000000000), new DateTime(630270720000000000), 2, 62.22M, "Toms Spezialitäten", "Luisenstr. 48", "Münster", null, "44087", "Germany"));
        this.Orders.Add(new OrdersItem(10968, "ERNSH", 1, new DateTime(630262080000000000), new DateTime(630286272000000000), new DateTime(630269856000000000), 3, 74.6M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10969, "COMMI", 1, new DateTime(630262080000000000), new DateTime(630286272000000000), new DateTime(630268128000000000), 2, 0.21M, "Comércio Mineiro", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"));
        this.Orders.Add(new OrdersItem(10970, "BOLID", 9, new DateTime(630262944000000000), new DateTime(630275040000000000), new DateTime(630289728000000000), 1, 16.16M, "Bólido Comidas preparadas", "C/ Araquil, 67", "Madrid", null, "28023", "Spain"));
        this.Orders.Add(new OrdersItem(10971, "FRANR", 2, new DateTime(630262944000000000), new DateTime(630287136000000000), new DateTime(630270720000000000), 2, 121.82M, "France restauration", "54, rue Royale", "Nantes", null, "44000", "France"));
        this.Orders.Add(new OrdersItem(10972, "LACOR", 4, new DateTime(630262944000000000), new DateTime(630287136000000000), new DateTime(630264672000000000), 2, 0.02M, "La corne d'abondance", "67, avenue de l'Europe", "Versailles", null, "78000", "France"));
        this.Orders.Add(new OrdersItem(10973, "LACOR", 6, new DateTime(630262944000000000), new DateTime(630287136000000000), new DateTime(630265536000000000), 2, 15.17M, "La corne d'abondance", "67, avenue de l'Europe", "Versailles", null, "78000", "France"));
        this.Orders.Add(new OrdersItem(10974, "SPLIR", 3, new DateTime(630263808000000000), new DateTime(630275904000000000), new DateTime(630271584000000000), 3, 12.96M, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
        this.Orders.Add(new OrdersItem(10975, "BOTTM", 1, new DateTime(630263808000000000), new DateTime(630288000000000000), new DateTime(630265536000000000), 3, 32.27M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10976, "HILAA", 1, new DateTime(630263808000000000), new DateTime(630300096000000000), new DateTime(630271584000000000), 1, 37.97M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(10977, "FOLKO", 8, new DateTime(630264672000000000), new DateTime(630288864000000000), new DateTime(630277632000000000), 3, 208.5M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10978, "MAISD", 9, new DateTime(630264672000000000), new DateTime(630288864000000000), new DateTime(630288864000000000), 2, 32.82M, "Maison Dewey", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium"));
        this.Orders.Add(new OrdersItem(10979, "ERNSH", 8, new DateTime(630264672000000000), new DateTime(630288864000000000), new DateTime(630268992000000000), 2, 353.07M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10980, "FOLKO", 4, new DateTime(630265536000000000), new DateTime(630301824000000000), new DateTime(630283680000000000), 1, 1.26M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10981, "HANAR", 1, new DateTime(630265536000000000), new DateTime(630289728000000000), new DateTime(630270720000000000), 2, 193.37M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(10982, "BOTTM", 2, new DateTime(630265536000000000), new DateTime(630289728000000000), new DateTime(630275904000000000), 1, 14.01M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(10983, "SAVEA", 2, new DateTime(630265536000000000), new DateTime(630289728000000000), new DateTime(630274176000000000), 2, 657.54M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10984, "SAVEA", 1, new DateTime(630268128000000000), new DateTime(630292320000000000), new DateTime(630271584000000000), 3, 211.22M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(10985, "HUNGO", 2, new DateTime(630268128000000000), new DateTime(630292320000000000), new DateTime(630270720000000000), 1, 91.51M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(10986, "OCEAN", 8, new DateTime(630268128000000000), new DateTime(630292320000000000), new DateTime(630287136000000000), 2, 217.86M, "Océano Atlántico Ltda.", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(10987, "EASTC", 8, new DateTime(630268992000000000), new DateTime(630293184000000000), new DateTime(630274176000000000), 1, 185.48M, "Eastern Connection", "35 King George", "London", null, "WX3 6FW", "UK"));
        this.Orders.Add(new OrdersItem(10988, "RATTC", 3, new DateTime(630268992000000000), new DateTime(630293184000000000), new DateTime(630277632000000000), 2, 61.14M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(10989, "QUEDE", 2, new DateTime(630268992000000000), new DateTime(630293184000000000), new DateTime(630270720000000000), 1, 34.76M, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
        this.Orders.Add(new OrdersItem(10990, "ERNSH", 2, new DateTime(630269856000000000), new DateTime(630306144000000000), new DateTime(630275040000000000), 3, 117.61M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(10991, "QUICK", 1, new DateTime(630269856000000000), new DateTime(630294048000000000), new DateTime(630275040000000000), 1, 38.51M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10992, "THEBI", 1, new DateTime(630269856000000000), new DateTime(630294048000000000), new DateTime(630271584000000000), 3, 4.27M, "The Big Cheese", "89 Jefferson Way Suite 2", "Portland", "OR", "97201", "USA"));
        this.Orders.Add(new OrdersItem(10993, "FOLKO", 7, new DateTime(630269856000000000), new DateTime(630294048000000000), new DateTime(630277632000000000), 3, 8.81M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(10994, "VAFFE", 2, new DateTime(630270720000000000), new DateTime(630282816000000000), new DateTime(630276768000000000), 3, 65.53M, "Vaffeljernet", "Smagsloget 45", "Århus", null, "8200", "Denmark"));
        this.Orders.Add(new OrdersItem(10995, "PERIC", 1, new DateTime(630270720000000000), new DateTime(630294912000000000), new DateTime(630274176000000000), 3, 46M, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(10996, "QUICK", 4, new DateTime(630270720000000000), new DateTime(630294912000000000), new DateTime(630277632000000000), 2, 1.12M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(10997, "LILAS", 8, new DateTime(630271584000000000), new DateTime(630307872000000000), new DateTime(630280224000000000), 2, 73.91M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(10998, "WOLZA", 8, new DateTime(630271584000000000), new DateTime(630283680000000000), new DateTime(630283680000000000), 2, 20.31M, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland"));
        this.Orders.Add(new OrdersItem(10999, "OTTIK", 6, new DateTime(630271584000000000), new DateTime(630295776000000000), new DateTime(630277632000000000), 2, 96.35M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(11000, "RATTC", 2, new DateTime(630274176000000000), new DateTime(630298368000000000), new DateTime(630281088000000000), 3, 55.12M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Orders.Add(new OrdersItem(11001, "FOLKO", 2, new DateTime(630274176000000000), new DateTime(630298368000000000), new DateTime(630281088000000000), 2, 197.3M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(11002, "SAVEA", 4, new DateTime(630274176000000000), new DateTime(630298368000000000), new DateTime(630282816000000000), 1, 141.16M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(11003, "THECR", 3, new DateTime(630274176000000000), new DateTime(630298368000000000), new DateTime(630275904000000000), 3, 14.91M, "The Cracker Box", "55 Grizzly Peak Rd.", "Butte", "MT", "59801", "USA"));
        this.Orders.Add(new OrdersItem(11004, "MAISD", 3, new DateTime(630275040000000000), new DateTime(630299232000000000), new DateTime(630286272000000000), 1, 44.84M, "Maison Dewey", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium"));
        this.Orders.Add(new OrdersItem(11005, "WILMK", 2, new DateTime(630275040000000000), new DateTime(630299232000000000), new DateTime(630277632000000000), 1, 0.75M, "Wilman Kala", "Keskuskatu 45", "Helsinki", null, "21240", "Finland"));
        this.Orders.Add(new OrdersItem(11006, "GREAL", 3, new DateTime(630275040000000000), new DateTime(630299232000000000), new DateTime(630281952000000000), 2, 25.19M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(11007, "PRINI", 8, new DateTime(630275904000000000), new DateTime(630300096000000000), new DateTime(630280224000000000), 2, 202.24M, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", null, "1756", "Portugal"));
        this.Orders.Add(new OrdersItem(11008, "ERNSH", 7, new DateTime(630275904000000000), new DateTime(630300096000000000), null, 3, 79.46M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(11009, "GODOS", 2, new DateTime(630275904000000000), new DateTime(630300096000000000), new DateTime(630277632000000000), 1, 59.11M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(11010, "REGGC", 2, new DateTime(630276768000000000), new DateTime(630300960000000000), new DateTime(630287136000000000), 2, 28.71M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(11011, "ALFKI", 3, new DateTime(630276768000000000), new DateTime(630300960000000000), new DateTime(630280224000000000), 1, 1.21M, "Alfred's Futterkiste", "Obere Str. 57", "Berlin", null, "12209", "Germany"));
        this.Orders.Add(new OrdersItem(11012, "FRANK", 1, new DateTime(630276768000000000), new DateTime(630288864000000000), new DateTime(630283680000000000), 3, 242.95M, "Frankenversand", "Berliner Platz 43", "München", null, "80805", "Germany"));
        this.Orders.Add(new OrdersItem(11013, "ROMEY", 2, new DateTime(630276768000000000), new DateTime(630300960000000000), new DateTime(630277632000000000), 1, 32.99M, "Romero y tomillo", "Gran Vía, 1", "Madrid", null, "28001", "Spain"));
        this.Orders.Add(new OrdersItem(11014, "LINOD", 2, new DateTime(630277632000000000), new DateTime(630301824000000000), new DateTime(630281952000000000), 3, 23.6M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(11015, "SANTG", 2, new DateTime(630277632000000000), new DateTime(630289728000000000), new DateTime(630286272000000000), 2, 4.62M, "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", null, "4110", "Norway"));
        this.Orders.Add(new OrdersItem(11016, "AROUT", 9, new DateTime(630277632000000000), new DateTime(630301824000000000), new DateTime(630280224000000000), 2, 33.8M, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
        this.Orders.Add(new OrdersItem(11017, "ERNSH", 9, new DateTime(630280224000000000), new DateTime(630304416000000000), new DateTime(630286272000000000), 2, 754.26M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(11018, "LONEP", 4, new DateTime(630280224000000000), new DateTime(630304416000000000), new DateTime(630282816000000000), 2, 11.65M, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
        this.Orders.Add(new OrdersItem(11019, "RANCH", 6, new DateTime(630280224000000000), new DateTime(630304416000000000), null, 3, 3.17M, "Rancho grande", "Av. del Libertador 900", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(11020, "OTTIK", 2, new DateTime(630281088000000000), new DateTime(630305280000000000), new DateTime(630282816000000000), 2, 43.3M, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", null, "50739", "Germany"));
        this.Orders.Add(new OrdersItem(11021, "QUICK", 3, new DateTime(630281088000000000), new DateTime(630305280000000000), new DateTime(630287136000000000), 1, 297.18M, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", null, "01307", "Germany"));
        this.Orders.Add(new OrdersItem(11022, "HANAR", 9, new DateTime(630281088000000000), new DateTime(630305280000000000), new DateTime(630298368000000000), 2, 6.27M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(11023, "BSBEV", 1, new DateTime(630281088000000000), new DateTime(630293184000000000), new DateTime(630289728000000000), 2, 123.83M, "B's Beverages", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK"));
        this.Orders.Add(new OrdersItem(11024, "EASTC", 4, new DateTime(630281952000000000), new DateTime(630306144000000000), new DateTime(630286272000000000), 1, 74.36M, "Eastern Connection", "35 King George", "London", null, "WX3 6FW", "UK"));
        this.Orders.Add(new OrdersItem(11025, "WARTH", 6, new DateTime(630281952000000000), new DateTime(630306144000000000), new DateTime(630289728000000000), 3, 29.17M, "Wartian Herkku", "Torikatu 38", "Oulu", null, "90110", "Finland"));
        this.Orders.Add(new OrdersItem(11026, "FRANS", 4, new DateTime(630281952000000000), new DateTime(630306144000000000), new DateTime(630293184000000000), 1, 47.09M, "Franchi S.p.A.", "Via Monte Bianco 34", "Torino", null, "10100", "Italy"));
        this.Orders.Add(new OrdersItem(11027, "BOTTM", 1, new DateTime(630282816000000000), new DateTime(630307008000000000), new DateTime(630286272000000000), 1, 52.52M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(11028, "KOENE", 2, new DateTime(630282816000000000), new DateTime(630307008000000000), new DateTime(630288000000000000), 1, 29.59M, "Königlich Essen", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany"));
        this.Orders.Add(new OrdersItem(11029, "CHOPS", 4, new DateTime(630282816000000000), new DateTime(630307008000000000), new DateTime(630292320000000000), 1, 47.84M, "Chop-suey Chinese", "Hauptstr. 31", "Bern", null, "3012", "Switzerland"));
        this.Orders.Add(new OrdersItem(11030, "SAVEA", 7, new DateTime(630283680000000000), new DateTime(630307872000000000), new DateTime(630292320000000000), 2, 830.75M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(11031, "SAVEA", 6, new DateTime(630283680000000000), new DateTime(630307872000000000), new DateTime(630289728000000000), 2, 227.22M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(11032, "WHITC", 2, new DateTime(630283680000000000), new DateTime(630307872000000000), new DateTime(630288864000000000), 3, 606.19M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(11033, "RICSU", 7, new DateTime(630283680000000000), new DateTime(630307872000000000), new DateTime(630288864000000000), 3, 84.74M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(11034, "OLDWO", 8, new DateTime(630286272000000000), new DateTime(630322560000000000), new DateTime(630292320000000000), 1, 40.32M, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
        this.Orders.Add(new OrdersItem(11035, "SUPRD", 2, new DateTime(630286272000000000), new DateTime(630310464000000000), new DateTime(630289728000000000), 2, 0.17M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(11036, "DRACD", 8, new DateTime(630286272000000000), new DateTime(630310464000000000), new DateTime(630288000000000000), 3, 149.47M, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", null, "52066", "Germany"));
        this.Orders.Add(new OrdersItem(11037, "GODOS", 7, new DateTime(630287136000000000), new DateTime(630311328000000000), new DateTime(630292320000000000), 1, 3.2M, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", null, "41101", "Spain"));
        this.Orders.Add(new OrdersItem(11038, "SUPRD", 1, new DateTime(630287136000000000), new DateTime(630311328000000000), new DateTime(630294912000000000), 2, 29.59M, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium"));
        this.Orders.Add(new OrdersItem(11039, "LINOD", 1, new DateTime(630287136000000000), new DateTime(630311328000000000), null, 2, 65M, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
        this.Orders.Add(new OrdersItem(11040, "GREAL", 4, new DateTime(630288000000000000), new DateTime(630312192000000000), null, 3, 18.84M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(11041, "CHOPS", 3, new DateTime(630288000000000000), new DateTime(630312192000000000), new DateTime(630293184000000000), 2, 48.22M, "Chop-suey Chinese", "Hauptstr. 31", "Bern", null, "3012", "Switzerland"));
        this.Orders.Add(new OrdersItem(11042, "COMMI", 2, new DateTime(630288000000000000), new DateTime(630300096000000000), new DateTime(630295776000000000), 1, 29.99M, "Comércio Mineiro", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"));
        this.Orders.Add(new OrdersItem(11043, "SPECD", 5, new DateTime(630288000000000000), new DateTime(630312192000000000), new DateTime(630294048000000000), 2, 8.8M, "Spécialités du monde", "25, rue Lauriston", "Paris", null, "75016", "France"));
        this.Orders.Add(new OrdersItem(11044, "WOLZA", 4, new DateTime(630288864000000000), new DateTime(630313056000000000), new DateTime(630295776000000000), 1, 8.72M, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland"));
        this.Orders.Add(new OrdersItem(11045, "BOTTM", 6, new DateTime(630288864000000000), new DateTime(630313056000000000), null, 2, 70.58M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(11046, "WANDK", 8, new DateTime(630288864000000000), new DateTime(630313056000000000), new DateTime(630289728000000000), 2, 71.64M, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany"));
        this.Orders.Add(new OrdersItem(11047, "EASTC", 7, new DateTime(630289728000000000), new DateTime(630313920000000000), new DateTime(630295776000000000), 3, 46.62M, "Eastern Connection", "35 King George", "London", null, "WX3 6FW", "UK"));
        this.Orders.Add(new OrdersItem(11048, "BOTTM", 7, new DateTime(630289728000000000), new DateTime(630313920000000000), new DateTime(630294912000000000), 3, 24.12M, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
        this.Orders.Add(new OrdersItem(11049, "GOURL", 3, new DateTime(630289728000000000), new DateTime(630313920000000000), new DateTime(630298368000000000), 1, 8.34M, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
        this.Orders.Add(new OrdersItem(11050, "FOLKO", 8, new DateTime(630292320000000000), new DateTime(630316512000000000), new DateTime(630299232000000000), 2, 59.41M, "Folk och fä HB", "Åkergatan 24", "Bräcke", null, "S-844 67", "Sweden"));
        this.Orders.Add(new OrdersItem(11051, "LAMAI", 7, new DateTime(630292320000000000), new DateTime(630316512000000000), null, 3, 2.79M, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France"));
        this.Orders.Add(new OrdersItem(11052, "HANAR", 3, new DateTime(630292320000000000), new DateTime(630316512000000000), new DateTime(630295776000000000), 1, 67.26M, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
        this.Orders.Add(new OrdersItem(11053, "PICCO", 2, new DateTime(630292320000000000), new DateTime(630316512000000000), new DateTime(630294048000000000), 2, 53.05M, "Piccolo und mehr", "Geislweg 14", "Salzburg", null, "5020", "Austria"));
        this.Orders.Add(new OrdersItem(11054, "CACTU", 8, new DateTime(630293184000000000), new DateTime(630317376000000000), null, 1, 0.33M, "Cactus Comidas para llevar", "Cerrito 333", "Buenos Aires", null, "1010", "Argentina"));
        this.Orders.Add(new OrdersItem(11055, "HILAA", 7, new DateTime(630293184000000000), new DateTime(630317376000000000), new DateTime(630299232000000000), 2, 120.92M, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
        this.Orders.Add(new OrdersItem(11056, "EASTC", 8, new DateTime(630293184000000000), new DateTime(630305280000000000), new DateTime(630295776000000000), 2, 278.96M, "Eastern Connection", "35 King George", "London", null, "WX3 6FW", "UK"));
        this.Orders.Add(new OrdersItem(11057, "NORTS", 3, new DateTime(630294048000000000), new DateTime(630318240000000000), new DateTime(630295776000000000), 3, 4.13M, "North/South", "South House 300 Queensbridge", "London", null, "SW7 1RZ", "UK"));
        this.Orders.Add(new OrdersItem(11058, "BLAUS", 9, new DateTime(630294048000000000), new DateTime(630318240000000000), null, 3, 31.14M, "Blauer See Delikatessen", "Forsterstr. 57", "Mannheim", null, "68306", "Germany"));
        this.Orders.Add(new OrdersItem(11059, "RICAR", 2, new DateTime(630294048000000000), new DateTime(630330336000000000), null, 2, 85.8M, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
        this.Orders.Add(new OrdersItem(11060, "FRANS", 2, new DateTime(630294912000000000), new DateTime(630319104000000000), new DateTime(630298368000000000), 2, 10.98M, "Franchi S.p.A.", "Via Monte Bianco 34", "Torino", null, "10100", "Italy"));
        this.Orders.Add(new OrdersItem(11061, "GREAL", 4, new DateTime(630294912000000000), new DateTime(630331200000000000), null, 3, 14.01M, "Great Lakes Food Market", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA"));
        this.Orders.Add(new OrdersItem(11062, "REGGC", 4, new DateTime(630294912000000000), new DateTime(630319104000000000), null, 2, 29.93M, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy"));
        this.Orders.Add(new OrdersItem(11063, "HUNGO", 3, new DateTime(630294912000000000), new DateTime(630319104000000000), new DateTime(630300096000000000), 2, 81.73M, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland"));
        this.Orders.Add(new OrdersItem(11064, "SAVEA", 1, new DateTime(630295776000000000), new DateTime(630319968000000000), new DateTime(630298368000000000), 1, 30.09M, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
        this.Orders.Add(new OrdersItem(11065, "LILAS", 8, new DateTime(630295776000000000), new DateTime(630319968000000000), null, 1, 12.91M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(11066, "WHITC", 7, new DateTime(630295776000000000), new DateTime(630319968000000000), new DateTime(630298368000000000), 2, 44.72M, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
        this.Orders.Add(new OrdersItem(11067, "DRACD", 1, new DateTime(630298368000000000), new DateTime(630310464000000000), new DateTime(630300096000000000), 2, 7.98M, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", null, "52066", "Germany"));
        this.Orders.Add(new OrdersItem(11068, "QUEEN", 8, new DateTime(630298368000000000), new DateTime(630322560000000000), null, 2, 81.75M, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
        this.Orders.Add(new OrdersItem(11069, "TORTU", 1, new DateTime(630298368000000000), new DateTime(630322560000000000), new DateTime(630300096000000000), 2, 15.67M, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(11070, "LEHMS", 2, new DateTime(630299232000000000), new DateTime(630323424000000000), null, 1, 136M, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", null, "60528", "Germany"));
        this.Orders.Add(new OrdersItem(11071, "LILAS", 1, new DateTime(630299232000000000), new DateTime(630323424000000000), null, 1, 0.93M, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
        this.Orders.Add(new OrdersItem(11072, "ERNSH", 4, new DateTime(630299232000000000), new DateTime(630323424000000000), null, 2, 258.64M, "Ernst Handel", "Kirchgasse 6", "Graz", null, "8010", "Austria"));
        this.Orders.Add(new OrdersItem(11073, "PERIC", 2, new DateTime(630299232000000000), new DateTime(630323424000000000), null, 2, 24.95M, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", null, "05033", "Mexico"));
        this.Orders.Add(new OrdersItem(11074, "SIMOB", 7, new DateTime(630300096000000000), new DateTime(630324288000000000), null, 2, 18.44M, "Simons bistro", "Vinbæltet 34", "Kobenhavn", null, "1734", "Denmark"));
        this.Orders.Add(new OrdersItem(11075, "RICSU", 8, new DateTime(630300096000000000), new DateTime(630324288000000000), null, 2, 6.19M, "Richter Supermarkt", "Starenweg 5", "Genève", null, "1204", "Switzerland"));
        this.Orders.Add(new OrdersItem(11076, "BONAP", 4, new DateTime(630300096000000000), new DateTime(630324288000000000), null, 2, 38.28M, "Bon app'", "12, rue des Bouchers", "Marseille", null, "13008", "France"));
        this.Orders.Add(new OrdersItem(11077, "RATTC", 1, new DateTime(630300096000000000), new DateTime(630324288000000000), null, 2, 8.53M, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
        this.Products.Add(new ProductsItem(1, "Chai", 1, 1, "10 boxes x 20 bags", 18M, 39));
        this.Products.Add(new ProductsItem(2, "Chang", 1, 1, "24 - 12 oz bottles", 19M, 17));
        this.Products.Add(new ProductsItem(3, "Aniseed Syrup", 1, 2, "12 - 550 ml bottles", 10M, 13));
        this.Products.Add(new ProductsItem(4, "Chef Anton's Cajun Seasoning", 2, 2, "48 - 6 oz jars", 22M, 53));
        this.Products.Add(new ProductsItem(5, "Chef Anton's Gumbo Mix", 2, 2, "36 boxes", 21.35M, 0));
        this.Products.Add(new ProductsItem(6, "Grandma's Boysenberry Spread", 3, 2, "12 - 8 oz jars", 25M, 120));
        this.Products.Add(new ProductsItem(7, "Uncle Bob's Organic Dried Pears", 3, 7, "12 - 1 lb pkgs.", 30M, 15));
        this.Products.Add(new ProductsItem(8, "Northwoods Cranberry Sauce", 3, 2, "12 - 12 oz jars", 40M, 6));
        this.Products.Add(new ProductsItem(9, "Mishi Kobe Niku", 4, 6, "18 - 500 g pkgs.", 97M, 29));
        this.Products.Add(new ProductsItem(10, "Ikura", 4, 8, "12 - 200 ml jars", 31M, 31));
        this.Products.Add(new ProductsItem(11, "Queso Cabrales", 5, 4, "1 kg pkg.", 21M, 22));
        this.Products.Add(new ProductsItem(12, "Queso Manchego La Pastora", 5, 4, "10 - 500 g pkgs.", 38M, 86));
        this.Products.Add(new ProductsItem(13, "Konbu", 6, 8, "2 kg box", 6M, 24));
        this.Products.Add(new ProductsItem(14, "Tofu", 6, 7, "40 - 100 g pkgs.", 23.25M, 35));
        this.Products.Add(new ProductsItem(15, "Genen Shouyu", 6, 2, "24 - 250 ml bottles", 15.5M, 39));
        this.Products.Add(new ProductsItem(16, "Pavlova", 7, 3, "32 - 500 g boxes", 17.45M, 29));
        this.Products.Add(new ProductsItem(17, "Alice Mutton", 7, 6, "20 - 1 kg tins", 39M, 0));
        this.Products.Add(new ProductsItem(18, "Carnarvon Tigers", 7, 8, "16 kg pkg.", 62.5M, 42));
        this.Products.Add(new ProductsItem(19, "Teatime Chocolate Biscuits", 8, 3, "10 boxes x 12 pieces", 9.2M, 25));
        this.Products.Add(new ProductsItem(20, "Sir Rodney's Marmalade", 8, 3, "30 gift boxes", 81M, 40));
        this.Products.Add(new ProductsItem(21, "Sir Rodney's Scones", 8, 3, "24 pkgs. x 4 pieces", 10M, 3));
        this.Products.Add(new ProductsItem(22, "Gustaf's Knäckebröd", 9, 5, "24 - 500 g pkgs.", 21M, 104));
        this.Products.Add(new ProductsItem(23, "Tunnbröd", 9, 5, "12 - 250 g pkgs.", 9M, 61));
        this.Products.Add(new ProductsItem(24, "Guaraná Fantástica", 10, 1, "12 - 355 ml cans", 4.5M, 20));
        this.Products.Add(new ProductsItem(25, "NuNuCa Nuß-Nougat-Creme", 11, 3, "20 - 450 g glasses", 14M, 76));
        this.Products.Add(new ProductsItem(26, "Gumbär Gummibärchen", 11, 3, "100 - 250 g bags", 31.23M, 15));
        this.Products.Add(new ProductsItem(27, "Schoggi Schokolade", 11, 3, "100 - 100 g pieces", 43.9M, 49));
        this.Products.Add(new ProductsItem(28, "Rössle Sauerkraut", 12, 7, "25 - 825 g cans", 45.6M, 26));
        this.Products.Add(new ProductsItem(29, "Thüringer Rostbratwurst", 12, 6, "50 bags x 30 sausgs.", 123.79M, 0));
        this.Products.Add(new ProductsItem(30, "Nord-Ost Matjeshering", 13, 8, "10 - 200 g glasses", 25.89M, 10));
        this.Products.Add(new ProductsItem(31, "Gorgonzola Telino", 14, 4, "12 - 100 g pkgs", 12.5M, 0));
        this.Products.Add(new ProductsItem(32, "Mascarpone Fabioli", 14, 4, "24 - 200 g pkgs.", 32M, 9));
        this.Products.Add(new ProductsItem(33, "Geitost", 15, 4, "500 g", 2.5M, 112));
        this.Products.Add(new ProductsItem(34, "Sasquatch Ale", 16, 1, "24 - 12 oz bottles", 14M, 111));
        this.Products.Add(new ProductsItem(35, "Steeleye Stout", 16, 1, "24 - 12 oz bottles", 18M, 20));
        this.Products.Add(new ProductsItem(36, "Inlagd Sill", 17, 8, "24 - 250 g  jars", 19M, 112));
        this.Products.Add(new ProductsItem(37, "Gravad lax", 17, 8, "12 - 500 g pkgs.", 26M, 11));
        this.Products.Add(new ProductsItem(38, "Côte de Blaye", 18, 1, "12 - 75 cl bottles", 263.5M, 17));
        this.Products.Add(new ProductsItem(39, "Chartreuse verte", 18, 1, "750 cc per bottle", 18M, 69));
        this.Products.Add(new ProductsItem(40, "Boston Crab Meat", 19, 8, "24 - 4 oz tins", 18.4M, 123));
        this.Products.Add(new ProductsItem(41, "Jack's New England Clam Chowder", 19, 8, "12 - 12 oz cans", 9.65M, 85));
        this.Products.Add(new ProductsItem(42, "Singaporean Hokkien Fried Mee", 20, 5, "32 - 1 kg pkgs.", 14M, 26));
        this.Products.Add(new ProductsItem(43, "Ipoh Coffee", 20, 1, "16 - 500 g tins", 46M, 17));
        this.Products.Add(new ProductsItem(44, "Gula Malacca", 20, 2, "20 - 2 kg bags", 19.45M, 27));
        this.Products.Add(new ProductsItem(45, "Rogede sild", 21, 8, "1k pkg.", 9.5M, 5));
        this.Products.Add(new ProductsItem(46, "Spegesild", 21, 8, "4 - 450 g glasses", 12M, 95));
        this.Products.Add(new ProductsItem(47, "Zaanse koeken", 22, 3, "10 - 4 oz boxes", 9.5M, 36));
        this.Products.Add(new ProductsItem(48, "Chocolade", 22, 3, "10 pkgs.", 12.75M, 15));
        this.Products.Add(new ProductsItem(49, "Maxilaku", 23, 3, "24 - 50 g pkgs.", 20M, 10));
        this.Products.Add(new ProductsItem(50, "Valkoinen suklaa", 23, 3, "12 - 100 g bars", 16.25M, 65));
        this.Products.Add(new ProductsItem(51, "Manjimup Dried Apples", 24, 7, "50 - 300 g pkgs.", 53M, 20));
        this.Products.Add(new ProductsItem(52, "Filo Mix", 24, 5, "16 - 2 kg boxes", 7M, 38));
        this.Products.Add(new ProductsItem(53, "Perth Pasties", 24, 6, "48 pieces", 32.8M, 0));
        this.Products.Add(new ProductsItem(54, "Tourtière", 25, 6, "16 pies", 7.45M, 21));
        this.Products.Add(new ProductsItem(55, "Pâté chinois", 25, 6, "24 boxes x 2 pies", 24M, 115));
        this.Products.Add(new ProductsItem(56, "Gnocchi di nonna Alice", 26, 5, "24 - 250 g pkgs.", 38M, 21));
        this.Products.Add(new ProductsItem(57, "Ravioli Angelo", 26, 5, "24 - 250 g pkgs.", 19.5M, 36));
        this.Products.Add(new ProductsItem(58, "Escargots de Bourgogne", 27, 8, "24 pieces", 13.25M, 62));
        this.Products.Add(new ProductsItem(59, "Raclette Courdavault", 28, 4, "5 kg pkg.", 55M, 79));
        this.Products.Add(new ProductsItem(60, "Camembert Pierrot", 28, 4, "15 - 300 g rounds", 34M, 19));
        this.Products.Add(new ProductsItem(61, "Sirop d'érable", 29, 2, "24 - 500 ml bottles", 28.5M, 113));
        this.Products.Add(new ProductsItem(62, "Tarte au sucre", 29, 3, "48 pies", 49.3M, 17));
        this.Products.Add(new ProductsItem(63, "Vegie-spread", 7, 2, "15 - 625 g jars", 43.9M, 24));
        this.Products.Add(new ProductsItem(64, "Wimmers gute Semmelknödel", 12, 5, "20 bags x 4 pieces", 33.25M, 22));
        this.Products.Add(new ProductsItem(65, "Louisiana Fiery Hot Pepper Sauce", 2, 2, "32 - 8 oz bottles", 21.05M, 76));
        this.Products.Add(new ProductsItem(66, "Louisiana Hot Spiced Okra", 2, 2, "24 - 8 oz jars", 17M, 4));
        this.Products.Add(new ProductsItem(67, "Laughing Lumberjack Lager", 16, 1, "24 - 12 oz bottles", 14M, 52));
        this.Products.Add(new ProductsItem(68, "Scottish Longbreads", 8, 3, "10 boxes x 8 pieces", 12.5M, 6));
        this.Products.Add(new ProductsItem(69, "Gudbrandsdalsost", 15, 4, "10 kg pkg.", 36M, 26));
        this.Products.Add(new ProductsItem(70, "Outback Lager", 7, 1, "24 - 355 ml bottles", 15M, 15));
        this.Products.Add(new ProductsItem(71, "Flotemysost", 15, 4, "10 - 500 g pkgs.", 21.5M, 26));
        this.Products.Add(new ProductsItem(72, "Mozzarella di Giovanni", 14, 4, "24 - 200 g pkgs.", 34.8M, 14));
        this.Products.Add(new ProductsItem(73, "Röd Kaviar", 17, 8, "24 - 150 g jars", 15M, 101));
        this.Products.Add(new ProductsItem(74, "Longlife Tofu", 4, 7, "5 kg pkg.", 10M, 4));
        this.Products.Add(new ProductsItem(75, "Rhönbräu Klosterbier", 12, 1, "24 - 0.5 l bottles", 7.75M, 125));
        this.Products.Add(new ProductsItem(76, "Lakkalikööri", 23, 1, "500 ml", 18M, 57));
        this.Products.Add(new ProductsItem(77, "Original Frankfurter grüne Soße", 12, 2, "12 boxes", 13M, 32));
        this.Shippers.Add(new ShippersItem(1, "Speedy Express", "(503) 555-9831"));
        this.Shippers.Add(new ShippersItem(2, "United Package", "(503) 555-3199"));
        this.Shippers.Add(new ShippersItem(3, "Federal Shipping", "(503) 555-9931"));
        this.Suppliers.Add(new SuppliersItem(1, "Exotic Liquids", "Charlotte Cooper", "Purchasing Manager", "49 Gilbert St.", "London", null, "EC1 4SD", "UK", "(171) 555-2222", null, null));
        this.Suppliers.Add(new SuppliersItem(2, "New Orleans Cajun Delights", "Shelley Burke", "Order Administrator", "P.O. Box 78934", "New Orleans", "LA", "70117", "USA", "(100) 555-4822", null, "#CAJUN.HTM#"));
        this.Suppliers.Add(new SuppliersItem(3, "Grandma Kelly's Homestead", "Regina Murphy", "Sales Representative", "707 Oxford Rd.", "Ann Arbor", "MI", "48104", "USA", "(313) 555-5735", "(313) 555-3349", null));
        this.Suppliers.Add(new SuppliersItem(4, "Tokyo Traders", "Yoshi Nagase", "Marketing Manager", "9-8 Sekimai Musashino-shi", "Tokyo", null, "100", "Japan", "(03) 3555-5011", null, null));
        this.Suppliers.Add(new SuppliersItem(5, "Cooperativa de Quesos 'Las Cabras'", "Antonio del Valle Saavedra", "Export Administrator", "Calle del Rosal 4", "Oviedo", "Asturias", "33007", "Spain", "(98) 598 76 54", null, null));
        this.Suppliers.Add(new SuppliersItem(6, "Mayumi's", "Mayumi Ohno", "Marketing Representative", "92 Setsuko Chuo-ku", "Osaka", null, "545", "Japan", "(06) 431-7877", null, "Mayumi's (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/mayumi.htm#"));
        this.Suppliers.Add(new SuppliersItem(7, "Pavlova, Ltd.", "Ian Devling", "Marketing Manager", "74 Rose St. Moonie Ponds", "Melbourne", "Victoria", "3058", "Australia", "(03) 444-2343", "(03) 444-6588", null));
        this.Suppliers.Add(new SuppliersItem(8, "Specialty Biscuits, Ltd.", "Peter Wilson", "Sales Representative", "29 King's Way", "Manchester", null, "M14 GSD", "UK", "(161) 555-4448", null, null));
        this.Suppliers.Add(new SuppliersItem(9, "PB Knäckebröd AB", "Lars Peterson", "Sales Agent", "Kaloadagatan 13", "Göteborg", null, "S-345 67", "Sweden", "031-987 65 43", "031-987 65 91", null));
        this.Suppliers.Add(new SuppliersItem(10, "Refrescos Americanas LTDA", "Carlos Diaz", "Marketing Manager", "Av. das Americanas 12.890", "Sao Paulo", null, "5442", "Brazil", "(11) 555 4640", null, null));
        this.Suppliers.Add(new SuppliersItem(11, "Heli Süßwaren GmbH & Co. KG", "Petra Winkler", "Sales Manager", "Tiergartenstraße 5", "Berlin", null, "10785", "Germany", "(010) 9984510", null, null));
        this.Suppliers.Add(new SuppliersItem(12, "Plutzer Lebensmittelgroßmärkte AG", "Martin Bein", "International Marketing Mgr.", "Bogenallee 51", "Frankfurt", null, "60439", "Germany", "(069) 992755", null, "Plutzer (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/plutzer.htm#"));
        this.Suppliers.Add(new SuppliersItem(13, "Nord-Ost-Fisch Handelsgesellschaft mbH", "Sven Petersen", "Coordinator Foreign Markets", "Frahmredder 112a", "Cuxhaven", null, "27478", "Germany", "(04721) 8713", "(04721) 8714", null));
        this.Suppliers.Add(new SuppliersItem(14, "Formaggi Fortini s.r.l.", "Elio Rossi", "Sales Representative", "Viale Dante, 75", "Ravenna", null, "48100", "Italy", "(0544) 60323", "(0544) 60603", "#FORMAGGI.HTM#"));
        this.Suppliers.Add(new SuppliersItem(15, "Norske Meierier", "Beate Vileid", "Marketing Manager", "Hatlevegen 5", "Sandvika", null, "1320", "Norway", "(0)2-953010", null, null));
        this.Suppliers.Add(new SuppliersItem(16, "Bigfoot Breweries", "Cheryl Saylor", "Regional Account Rep.", "3400 - 8th Avenue Suite 210", "Bend", "OR", "97101", "USA", "(503) 555-9931", null, null));
        this.Suppliers.Add(new SuppliersItem(17, "Svensk Sjöföda AB", "Michael Björn", "Sales Representative", "Brovallavägen 231", "Stockholm", null, "S-123 45", "Sweden", "08-123 45 67", null, null));
        this.Suppliers.Add(new SuppliersItem(18, "Aux joyeux ecclésiastiques", "Guylène Nodier", "Sales Manager", "203, Rue des Francs-Bourgeois", "Paris", null, "75004", "France", "(1) 03.83.00.68", "(1) 03.83.00.62", null));
        this.Suppliers.Add(new SuppliersItem(19, "New England Seafood Cannery", "Robb Merchant", "Wholesale Account Agent", "Order Processing Dept. 2100 Paul Revere Blvd.", "Boston", "MA", "02134", "USA", "(617) 555-3267", "(617) 555-3389", null));
        this.Suppliers.Add(new SuppliersItem(20, "Leka Trading", "Chandra Leka", "Owner", "471 Serangoon Loop, Suite #402", "Singapore", null, "0512", "Singapore", "555-8787", null, null));
        this.Suppliers.Add(new SuppliersItem(21, "Lyngbysild", "Niels Petersen", "Sales Manager", "Lyngbysild Fiskebakken 10", "Lyngby", null, "2800", "Denmark", "43844108", "43844115", null));
        this.Suppliers.Add(new SuppliersItem(22, "Zaanse Snoepfabriek", "Dirk Luchte", "Accounting Manager", "Verkoop Rijnweg 22", "Zaandam", null, "9999 ZZ", "Netherlands", "(12345) 1212", "(12345) 1210", null));
        this.Suppliers.Add(new SuppliersItem(23, "Karkki Oy", "Anne Heikkonen", "Product Manager", "Valtakatu 12", "Lappeenranta", null, "53120", "Finland", "(953) 10956", null, null));
        this.Suppliers.Add(new SuppliersItem(24, "G'day, Mate", "Wendy Mackenzie", "Sales Representative", "170 Prince Edward Parade Hunter's Hill", "Sydney", "NSW", "2042", "Australia", "(02) 555-5914", "(02) 555-4873", "G'day Mate (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/gdaymate.htm#"));
        this.Suppliers.Add(new SuppliersItem(25, "Ma Maison", "Jean-Guy Lauzon", "Marketing Manager", "2960 Rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada", "(514) 555-9022", null, null));
        this.Suppliers.Add(new SuppliersItem(26, "Pasta Buttini s.r.l.", "Giovanni Giudici", "Order Administrator", "Via dei Gelsomini, 153", "Salerno", null, "84100", "Italy", "(089) 6547665", "(089) 6547667", null));
        this.Suppliers.Add(new SuppliersItem(27, "Escargots Nouveaux", "Marie Delamare", "Sales Manager", "22, rue H. Voiron", "Montceau", null, "71300", "France", "85.57.00.07", null, null));
        this.Suppliers.Add(new SuppliersItem(28, "Gai pâturage", "Eliane Noz", "Sales Representative", "Bat. B 3, rue des Alpes", "Annecy", null, "74000", "France", "38.76.98.06", "38.76.98.58", null));
        this.Suppliers.Add(new SuppliersItem(29, "Forêts d'érables", "Chantal Goulet", "Accounting Manager", "148 rue Chasseur", "Ste-Hyacinthe", "Québec", "J2S 7S8", "Canada", "(514) 555-2955", "(514) 555-2921", null));

        #region category.CategoryID == product.CategoryID
        foreach (CategoriesItem category in this.Categories)
        {
            category.Products = new List<ProductsItem>();

            foreach (ProductsItem product in this.Products)
            {
                if (category.CategoryID == product.CategoryID)
                {
                    category.Products.Add(product);
                }
            }
        }
        #endregion

        #region product.ProductID == orderDetail.ProductID
        foreach (ProductsItem product in this.Products)
        {
            product.OrderDetails = new List<Order_DetailsItem>();

            foreach (Order_DetailsItem orderDetail in this.Order_Details)
            {
                if (product.ProductID == orderDetail.ProductID)
                {
                    product.OrderDetails.Add(orderDetail);
                }
            }
        }
        #endregion

        #region orderDetail.OrderID == order.OrderID
        foreach (Order_DetailsItem orderDetail in this.Order_Details)
        {
            orderDetail.Orders = new List<OrdersItem>();

            foreach (OrdersItem order in this.Orders)
            {
                if (orderDetail.OrderID == order.OrderID)
                {
                    orderDetail.Orders.Add(order);
                }
            }
        }
        #endregion

        #region order.CustomerID == customer.CustomerID
        foreach (OrdersItem order in this.Orders)
        {
            order.Customers = new List<CustomersItem>();

            foreach (CustomersItem customer in this.Customers)
            {
                if (order.CustomerID == customer.CustomerID)
                {
                    order.Customers.Add(customer);
                }
            }
        }
        #endregion

        #region orderDetail.ProductID == product.ProductID
        foreach (Order_DetailsItem orderDetail in this.Order_Details)
        {
            orderDetail.Products = new List<ProductsItem>();

            foreach (ProductsItem product in this.Products)
            {
                if (orderDetail.ProductID == product.ProductID)
                {
                    orderDetail.Products.Add(product);
                }
            }
        }
        #endregion

        #region product.CategoryID == category.CategoryID
        foreach (ProductsItem product in this.Products)
        {
            product.Categories = new List<CategoriesItem>();

            foreach (CategoriesItem category in this.Categories)
            {
                if (product.CategoryID == category.CategoryID)
                {
                    product.Categories.Add(category);
                }
            }
        }
        #endregion

        #region order.CustomerID == customer.CustomerID
        foreach (OrdersItem order in this.Orders)
        {
            order.Employees = new List<EmployeesItem>();

            foreach (EmployeesItem employee in this.Employees)
            {
                if (order.EmployeeID == employee.EmployeeID)
                {
                    order.Employees.Add(employee);
                }
            }
        }
        #endregion
    }
}
