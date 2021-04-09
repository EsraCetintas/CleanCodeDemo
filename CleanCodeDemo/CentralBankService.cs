using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
        //Merkez bankası kodu gibi düşünün.Kod değiştirilemiyor...
      public  class CentralBankService
        {
            public decimal ConvertCurrency(CurrencyRate currencyRate)
            {
                return currencyRate.Price / currencyRate.Currency;
            }
        }
}
