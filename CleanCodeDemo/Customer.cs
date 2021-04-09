using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
   public class Customer:Kullanici,IEntity
    {
        public Customer(decimal discountRate) : base(discountRate)
        {
            
        }
    }
}
