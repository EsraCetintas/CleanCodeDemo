using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
    public class Kullanici : IKullanici
    {
        public Kullanici(decimal discountRate)
        {
            DiscountRate = discountRate;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal DiscountRate { get;}
    }
}
