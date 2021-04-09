using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
   public class ProductManager:IProductService
    {
        public void Sell(Product product, IKullanici kullanici)
        {
            Console.WriteLine(kullanici.FirstName + " " + kullanici.LastName + " ürünü satın aldı");
            product.Price = product.Price * kullanici.DiscountRate;
        }

        public void Pay(Product product)
        {
            Console.WriteLine(product.Price+" TL ödeme alındı");
        }

        public void ByCurrencyRatePay(Product product, CurrencyRate currencyRate, IBankService bankService)
        {
            currencyRate.Price = product.Price;
            var result=bankService.ConvertRate(currencyRate);
            Console.WriteLine(result+" "+currencyRate.Unit+" ödeme alındı");
        }
    }
}
