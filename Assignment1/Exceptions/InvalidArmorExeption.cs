using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Exceptions
{
    public class InvalidArmorExeption : Exception
    {
        public override string Message => "Not valid armor for this Character";
    }
    
     
}
