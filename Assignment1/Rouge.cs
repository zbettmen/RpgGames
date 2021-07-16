using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Exceptions;

namespace Assignment1
{
   public class Rouge : Character
   {
         PrimaryAttributes primaryAttributes = new PrimaryAttributes();
        public  Rouge(string name)
        {
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 8, Strenght = 2, Dexterity = 6, Intelligence = 1 };
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
                BasePrimaryAttributes.Vitality += level * 3 ;
                BasePrimaryAttributes.Strenght += level * 1;
                BasePrimaryAttributes.Dexterity += level * 4;
                BasePrimaryAttributes.Intelligence += level * 1;
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

            if (CheckifLevelIsRequired(armor, Level))
            {

                if (armor.Type == ArmorType.LEATHER || armor.Type == ArmorType.MAIL)
                {
                    if (armor.Slot == Slot.HEAD)
                    {
                        Equipments.Add(Slot.HEAD, armor);
                    }
                    else if (armor.Slot == Slot.BODY)
                    {
                        Equipments.Add(Slot.BODY, armor);
                    }
                    else if (armor.Slot == Slot.LEGS)
                    {
                        Equipments.Add(Slot.LEGS, armor);
                    }
                    else
                    {
                        throw new InvalidArmorExeption();
                    }
                }

            }
            else
            {
                throw new InvalidArmorExeption();
            }

            return "Nice new armor";
        }

        public override string setWeaponEquipment(Weapon weapon)
        {

            if ((weapon.WeaponType == WeponType.Dagger || weapon.WeaponType == WeponType.Sword) && CheckifLevelIsRequired(weapon, Level))
            {
                Equipments.Add(Slot.WEAPON, weapon);
            }
            else
            {
                throw new InvalidWeaponExeption();
            }

            return "Nice right weapon";



        }

        public override double generateCharacterDps()
        {
            throw new NotImplementedException();
        }
   }

   
}
