using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
 public class Weapon : Item
 {
        public WeponType WeaponType { get; set; }

        public WeaponAttributes WeaponAttributes { get; set; }

        public double calculateDamage()
        {
            return WeaponAttributes.Damage * WeaponAttributes.AttackSpeed;
        }
 }
 

}
