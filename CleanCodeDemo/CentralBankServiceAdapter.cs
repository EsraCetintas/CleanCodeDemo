using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
    //Merkes bankasının kodunu sisteme adapte ettik
    //Adapter Pattern
   public class CentralBankServiceAdapter : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            CentralBankService centralBankService = new CentralBankService();
            var result= centralBankService.ConvertCurrency(currencyRate);
            result = Decimal.Round(result, 2);
            return result;
        }
    }
}
