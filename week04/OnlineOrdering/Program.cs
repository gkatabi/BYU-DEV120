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
    }
}
   
