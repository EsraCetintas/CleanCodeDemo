using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
   public interface IProductService
    {
        void Sell(Product product, IKullanici kullanici);
        void Pay(Product product);
        void ByCurrencyRatePay(Product product,CurrencyRate currencyRate, IBankService bankService);
    }
}
