using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
    public class Student:Kullanici,IEntity
    {
        public Student(decimal discountRate):base(discountRate)
        {
            
        }
    }
}
