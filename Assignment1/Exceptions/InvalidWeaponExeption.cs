using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Exceptions
{
    public class InvalidWeaponExeption : Exception
    {
        public override string Message => "Not valid weapon for this Character";

    }
}
