using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
   public class FakeBankManager : IBankService
    {
            public decimal ConvertRate(CurrencyRate currencyRate)
            {
                 var result= currencyRate.Price / currencyRate.Currency;
                 result=Decimal.Round(result, 2);
                  return result;
            }
    }
}
