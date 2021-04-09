using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
   public interface IBankService
    {
        decimal ConvertRate(CurrencyRate currencyRate);
    }
}
