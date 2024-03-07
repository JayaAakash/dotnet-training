using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{

    class Saledetails
    {
        private int SalesNo;
        private int ProductNo;
        private double Price;
        private DateTime DateofSale;
        private int Qty;
        private double TotalAmount;

        public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateofSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateofSale = dateofSale;
            Sales(); 
        }

        private void Sales()
        {
            TotalAmount = Qty * Price;
        }

        public void ShowData()
        {
            Console.WriteLine($"Sales No: {SalesNo}");
            Console.WriteLine($"Product No: {ProductNo}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Date of Sale: {DateofSale}");
            Console.WriteLine($"Qty: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmount}");
        }
    }

    class salesdetails
    {
        static void Main(string[] args)
        {
            Saledetails sale = new Saledetails(9299, 01, 20000, 10, DateTime.Now);

            sale.ShowData();
            Console.ReadLine();
        }
    }
}
