using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
    public interface IKullanici
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal DiscountRate { get; }
    }
}
