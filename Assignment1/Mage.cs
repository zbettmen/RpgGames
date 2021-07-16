using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Exceptions;

namespace Assignment1
{
  public class Mage : Character
    {
         PrimaryAttributes primaryAttributes = new PrimaryAttributes();
         


         //public PrimaryAttributes prim { get; set; }
      
       

        public Mage(string name)
        {
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 5, Strenght = 1, Dexterity = 1, Intelligence = 8 };
            Name = name;
            Level = 1;
            TotalPrimaryAttribute();
            generateSecondaryValues();

        }

       public override void LevelUp(int level)
       {

           if (level > 0)
           {
               
               Level += level;
               BasePrimaryAttributes.Vitality += level * 3; 
               BasePrimaryAttributes.Strenght += level * 1;
               BasePrimaryAttributes.Dexterity += level * 1;
               BasePrimaryAttributes.Intelligence += level * 5;
               TotalPrimaryAttribute();
               generateSecondaryValues();
           }
           else
           {
               throw new ArgumentException();
           }
            
       }

       public override string setArmorEquipment(Armor armor)
       {
           if (CheckifLevelIsRequired(armor, armor.Level))
           {
               if (armor.Type == ArmorType.CLOTH)
               {
                   if (armor.Slot == Slot.HEAD)
                   {
                       Equipments.Add(Slot.HEAD,armor);
                   }
                   else if (armor.Slot == Slot.BODY)
                   {
                       Equipments.Add(Slot.HEAD,armor);
                   }
                   else if(armor.Slot == Slot.LEGS)
                   {
                       Equipments.Add(Slot.LEGS,armor);
                   }
                   else
                   {
                       throw new InvalidWeaponExeption();
                   }
                  
               }
           }


           return "nice";
       }

       public override string setWeaponEquipment(Weapon weapon)
       {
           if (CheckifLevelIsRequired(weapon, weapon.RLevel))
           {
               if (weapon.WeaponType == WeponType.Staff || weapon.WeaponType == WeponType.Wand)
               {
                   Equipments.Add(Slot.WEAPON,weapon);
               }
               else
               {
                   throw new InvalidWeaponExeption();
               }
           }
           
           return "Nice right weapon";
       }

     

       public override double generateCharacterDps()
       {
           throw new NotImplementedException();
       }
    }
}

