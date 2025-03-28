using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace VideoTracker;
    public class Product
    {
        private string _productName = "" ;
        private string _productId;
        private static string _productquantity;
        private string _customer;
        public int GetProductTotalCost()
        {
            int  _pricePerUnit=6 ;
            int  _quantity =5;
            int  _productTotalPrice=(_pricePerUnit * _quantity);
        
            return _productTotalPrice;
        }
    }
    public class Customer
    {
        string _firstName;
        string _lastName;
    }
    public class Address
    {
        public int _houseNumber = 75;
        public string _street = "";
        public string _city = " ";
        public string _country = "";
    } 
    public class Order
    {
        public  string _productsName ;
        public int _quantityOfProducts =8;
        public int _costOfproducts = 98 ;
        
        public int _customer = 24;

        public static void TotalCostOfOrder()
        {
           int __costOfproducts =6;
        
        }    
    public static void Main(string[] args)
    {
        Product p1  = new Product();
        string _productName1 = "Wood"; 
        string _productId1 = "3Hl#";
        int _productquantity1 = 18;
        int _customerL1 = 24;
        Console.WriteLine($"The order of:\n{_productName1}\nId {_productId1 }\nQnty {_productquantity1}\nBy {_customerL1}Lx");
        Customer C1 = new Customer();
        string _Customer1 = "John"; 
        Console.Write($"{_Customer1}"); 
        Address A1  = new Address();
        int _houseNumber1=75;
        string _city = "Down city";
        string _country = "Russia";
        string _street ="hemingways street";
        Console.WriteLine($"Address: {_houseNumber1}\n{_street}\n{_city}\n{_country}");
        Order O1    = new Order();
        string _productsName1 = "Soap"  ;
        int  _quantityOfProducts1 = 5 ;
        int  _costOfproducts1 =400 ;
        string  _customer1 = "Rich Hards";
        Console.WriteLine($"{ _productsName1}: Boxes {_quantityOfProducts1 }\n${_costOfproducts1}\nTo{ _customerL1}");

        Product p2  = new Product();
        string _productName2 = "Fish"; 
        string _productId2 = "54Hl#";
        int _productquantity2 = 154;
        int _customerL2 = 42;
        Console.WriteLine($"The order of:\n{_productName2}\nId {_productId2 }\nQnty {_productquantity2}\nBy {_customerL2}Lx");
        Customer C2 = new Customer();
        string _Customer2 = "Jogn"; 
        Console.Write($"{_Customer2}"); 
        Address A2  = new Address();
        int _houseNumber2=88;
        string _city2 = "Kansas city";
        string _country2 = "USA";
        string _street2 ="Hemiltons street";
        Console.WriteLine($"Address: {_houseNumber2}\n{_street2}\n{_city2}\n{_country2}");
        Order O2    = new Order();
        string _productsName2 = "Roaps"  ;
        int  _quantityOfProducts2 = 87 ;
        int  _costOfproducts2 =300 ;
        string  _customer2 = "Rich Hards";
        Console.WriteLine($"{ _productsName2}: Boxes {_quantityOfProducts2 }\n${_costOfproducts2}\nTo{ _customerL2}");

        Product p3  = new Product();
        string _productName3 = "Sugar"; 
        string _productId3 = "54Hl#";
        int _productquantity3 = 154;
        int _customerL3 = 42;
        Console.WriteLine($"The order of:\n{_productName3}\nId {_productId3 }\nQnty {_productquantity3}\nBy {_customerL3}Lx");
        Customer C3 = new Customer();
        string _Customer3 = "Greatley"; 
        Console.Write($"{_Customer3}"); 
        Address A3  = new Address();
        int _houseNumber3=88;
        string _city3 = "Mishasas city";
        string _country3 = "Uruguay";
        string _street3 ="Strad street";
        Console.WriteLine($"Address: {_houseNumber3}\n{_street3}\n{_city3}\n{_country3}");
        Order O3    = new Order();
        string _productsName3 = "Roaps"  ;
        int  _quantityOfProducts3 = 8987 ;
        int  _costOfproducts3 =900 ;
        string  _customer3 = "Rich Hards";
        Console.WriteLine($"{ _productsName3}: Boxes {_quantityOfProducts3 }\n${_costOfproducts3}\nTo{ _customer3}");
    
    }
}
   
