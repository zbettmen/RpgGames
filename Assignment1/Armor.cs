using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Armor : Item
    {
    
        public  ArmorType Type { get; set; }
        public PrimaryAttributes PrimaryAttributes { get; set; }
        public int Level { get; set; }

       
    }
}
