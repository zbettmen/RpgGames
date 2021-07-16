using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Assignment1
{   public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int TotalDamage { get; set; } = 1;



        public PrimaryAttributes BasePrimaryAttributes { get; set; }
        public PrimaryAttributes TotalPrimaryAttributes { get; set; }

        public Dictionary<Slot, Item> Equipments { get; set; } = new Dictionary<Slot, Item>();

        public abstract void LevelUp(int level);

        /// <summary>
        /// Check is if level is higher or equal to item level for items.
        /// returns true if level is higher or equal to object item.
        /// returns false if level is lower than item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public bool CheckifLevelIsRequired(Item item, int level)
        {
            return level >= item.RLevel;
        }

        public abstract string setArmorEquipment(Armor armor);
        public abstract string setWeaponEquipment(Weapon weapon);
        public SecondaryAttributes SecondaryAttributes { get; set; }
       
        /// <summary>
        /// Calculate all my stats 
        /// </summary>
        public virtual void TotalPrimaryAttribute()
        {
            TotalPrimaryAttributes = new PrimaryAttributes();
            TotalPrimaryAttributes.Vitality = BasePrimaryAttributes.Vitality;
            TotalPrimaryAttributes.Strenght = BasePrimaryAttributes.Strenght;
            TotalPrimaryAttributes.Dexterity = BasePrimaryAttributes.Dexterity;
            TotalPrimaryAttributes.Intelligence = BasePrimaryAttributes.Intelligence;
          
                
             //Foreach loop checking weapon   
            foreach (Item item in Equipments.Values)
            {
                if (item.GetType() != typeof(Weapon))
                {
                    Armor armor = (Armor) item;
                    TotalPrimaryAttributes.Vitality += armor.PrimaryAttributes.Vitality;
                    TotalPrimaryAttributes.Strenght += armor.PrimaryAttributes.Strenght;
                    TotalPrimaryAttributes.Dexterity += armor.PrimaryAttributes.Dexterity;
                    TotalPrimaryAttributes.Intelligence += armor.PrimaryAttributes.Intelligence;
                   
                }

            }

            
        }
        /// <summary>
        /// Generates secondary values of the character.
        /// </summary>
        public void generateSecondaryValues()
        {
            int health = BasePrimaryAttributes.Vitality * 10;
            int armorRating = BasePrimaryAttributes.Strenght + BasePrimaryAttributes.Dexterity;
            int elementResistance = BasePrimaryAttributes.Intelligence;
            SecondaryAttributes = new SecondaryAttributes()
                {ArmorRating = armorRating, ElementalResistance = elementResistance, Health = health};
        }

        public abstract double generateCharacterDps();





    }
}
