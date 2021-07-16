using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Assignment1.Exceptions;
namespace Assignment1
{
    public class Warrior : Character
    {
         PrimaryAttributes primaryAttributes = new PrimaryAttributes();

        public Warrior(string name)
        {
            BasePrimaryAttributes = new PrimaryAttributes {Vitality = 10, Strenght = 5, Dexterity = 2, Intelligence = 1};
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
                BasePrimaryAttributes.Vitality += level * 5 ;
                BasePrimaryAttributes.Strenght +=  level * 3 ;
                BasePrimaryAttributes.Dexterity +=  level * 2 ;
                BasePrimaryAttributes.Intelligence +=  level * 1 ;
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



                if (armor.Type == ArmorType.PLATE || armor.Type == ArmorType.MAIL)
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

            TotalPrimaryAttribute();
            generateSecondaryValues();
            return "Nice new armor";
        }


        public override string setWeaponEquipment(Weapon weapon)
        {

            if ((weapon.WeaponType == WeponType.Axe || weapon.WeaponType == WeponType.Hammer || weapon.WeaponType == WeponType.Sword) && CheckifLevelIsRequired(weapon, Level))
            {
                    Equipments.Add(Slot.WEAPON,weapon);
            }
            else
            {
                    throw new InvalidWeaponExeption();
            }

            return "Nice right weapon";



        }


        public override double generateCharacterDps()
        {
            TotalPrimaryAttribute();
            //double totalAttrubutes = (double)  TotalPrimaryAttributes.Strenght;
            //                         ////TotalPrimaryAttributes.Dexterity + TotalPrimaryAttributes.Intelligence;


            if (Equipments.ContainsKey(Slot.WEAPON))
            {
                Weapon weapon = (Weapon)Equipments[Slot.WEAPON];
                double WeaponDamge = weapon.calculateDamage();
                return WeaponDamge *  (1.0 +  TotalPrimaryAttributes.Strenght  / 100.0);
            }
            else
            {
                return 1.0 * (1.0 + TotalPrimaryAttributes.Strenght / 100.0);
            }

            
        }

        public int calulculateCharacterDps2()
        {
           return  1 + (TotalPrimaryAttributes.Strenght / 100);
        }
    }


    
    
}
