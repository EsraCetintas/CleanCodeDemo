using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.Name = "Televizyon";
            product.Price = 1000;

            Customer customer1 = new Customer(1);
            customer1.Id = 1;
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Kaya";

            Customer customer2 = new Customer(1);
            customer2.Id = 2;
            customer2.FirstName = "Ayşe";
            customer2.LastName = "Yılmaz";

            Student student = new Student((decimal)0.90);
            student.Id = 1;
            student.FirstName = "Esra";
            student.LastName = "Çetintaş";

            CurrencyRate currencyRate = new CurrencyRate();
            currencyRate.Unit = "Dolar";
            currencyRate.Currency = (decimal)8.14;
            

            IProductService customerProductService = new ProductManager();
            customerProductService.Sell(product, customer1);
            customerProductService.ByCurrencyRatePay(product, currencyRate, new CentralBankServiceAdapter());

            IProductService studentProductService = new ProductManager();
            studentProductService.Sell(product, student);
            studentProductService.Pay(product);
            Console.ReadKey();
        }
    }
}
