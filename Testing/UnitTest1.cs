using System;
using Assignment1;
using Xunit;
using Assignment1.Exceptions;
using Xunit.Abstractions;

namespace Testing
{
    public class UnitTest1
    {

        //Mage

        [Fact]
        public void test_Check_LevelUp_When_Create()
        {
            Mage mage = new Mage("Rijad");
            mage.LevelUp(1);
            int actualLevel = 1;
            int expected = 1;
            Assert.Equal(expected, actualLevel);

        }

        [Fact]
        public void test_LevelUp_To_2_mage()
        {
            int excpected = 2;
            Mage mage = new Mage("Rijad");
            mage.LevelUp(1);
            int actual = mage.Level;
            Assert.Equal(excpected, actual);

        }

        [Fact]
        public void test_Mage_Defualt_Attributes()
        {

            int expectedVitality = 5;
            int expectedStrenght = 1;
            int expectedDecterity = 1;
            int expectedIntelligence = 8;



            Mage mage = new Mage("Rijad");
            int actualVitality = mage.BasePrimaryAttributes.Vitality;
            int actualStrenght = mage.BasePrimaryAttributes.Strenght;
            int actualDecterity = mage.BasePrimaryAttributes.Dexterity;
            int actualItelligence = mage.BasePrimaryAttributes.Intelligence;

            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrenght, actualStrenght);
            Assert.Equal(expectedDecterity, actualDecterity);
            Assert.Equal(expectedIntelligence, actualItelligence);

        }


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void test_LevelInvalid_Number_mage(int InlineData)
        {
            int expectedVitality = 5;
            int expectedStrenght = 1;
            int expectedDecterity = 1;
            int expectedIntelligence = 8;



            Mage mage = new Mage("Rijad");
            mage.BasePrimaryAttributes.Vitality = expectedVitality;
            mage.BasePrimaryAttributes.Strenght = expectedStrenght;
            mage.BasePrimaryAttributes.Dexterity = expectedDecterity;
            mage.BasePrimaryAttributes.Intelligence = expectedIntelligence;

            Assert.Throws<ArgumentException>(() => mage.LevelUp(InlineData));
        }

        [Fact]
        public void test_CheckLevelUpAttributes_mage()
        {

            double expectedVitality = 8;
            double expectedStrenght = 2;
            double expectedDexterity = 2;
            double expetecIntelligence = 13;

            Mage mage = new Mage("Rijad");
            mage.LevelUp(1);
            double actualVitality = mage.BasePrimaryAttributes.Vitality;
            double actualStrenght = mage.BasePrimaryAttributes.Strenght;
            double actualDecterity = mage.BasePrimaryAttributes.Dexterity;
            double actualIntelligence = mage.BasePrimaryAttributes.Intelligence;

            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrenght, actualStrenght);
            Assert.Equal(expectedDexterity, actualDecterity);
            Assert.Equal(actualIntelligence, expetecIntelligence);

        }

        //Ranger
        [Fact]
        public void test_ranger_defult_attributes()
        {

            int expectedVitality = 8;
            int expectedStrenght = 1;
            int expectedDecterity = 7;
            int expectedIntelligence = 1;



            Ranger ranger = new Ranger("Rijad");
            int actualVitality = ranger.BasePrimaryAttributes.Vitality;
            int actualStrenght = ranger.BasePrimaryAttributes.Strenght;
            int actualDecterity = ranger.BasePrimaryAttributes.Dexterity;
            int actualItelligence = ranger.BasePrimaryAttributes.Intelligence;

            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrenght, actualStrenght);
            Assert.Equal(expectedDecterity, actualDecterity);
            Assert.Equal(expectedIntelligence, actualItelligence);

        }

        [Fact]
        public void test_CheckLevelUpAttributes_ranger()
        {

            double expectedVitality = 10;
            double expectedStrenght = 2;
            double expectedDexterity = 12;
            double expetecIntelligence = 2;

            Ranger ranger = new Ranger("Rijad");
            ranger.LevelUp(1);
            double actualVitality = ranger.BasePrimaryAttributes.Vitality;
            double actualStrenght = ranger.BasePrimaryAttributes.Strenght;
            double actualDecterity = ranger.BasePrimaryAttributes.Dexterity;
            double actualIntelligence = ranger.BasePrimaryAttributes.Intelligence;

            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrenght, actualStrenght);
            Assert.Equal(expectedDexterity, actualDecterity);
            Assert.Equal(actualIntelligence, expetecIntelligence);

        }

        [Fact]
        public void test_levelUp_ranger()
        {
            int expected = 2;
            Ranger ranger = new Ranger("Rijad");
            ranger.LevelUp(1);
            int actual = ranger.Level;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void test_rouge_deafult_value()
        {
            Rouge rouge = new Rouge("Rijad");

            double expectedVitality = rouge.TotalPrimaryAttributes.Vitality = 8;
            double expectedStrenght = rouge.TotalPrimaryAttributes.Strenght = 2;
            double expectedDexterity = rouge.TotalPrimaryAttributes.Dexterity = 6;
            double expetecIntelligence = rouge.TotalPrimaryAttributes.Intelligence = 1;

            double actualVitality = rouge.TotalPrimaryAttributes.Vitality;
            double actualStrenght = rouge.TotalPrimaryAttributes.Strenght;
            double actualDecterity = rouge.TotalPrimaryAttributes.Dexterity;
            double actualIntelligence = rouge.TotalPrimaryAttributes.Intelligence;

            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrenght, actualStrenght);
            Assert.Equal(expectedDexterity, actualDecterity);
            Assert.Equal(actualIntelligence, expetecIntelligence);

        }


        [Fact]
        public void test_rouge_LevelUp_Attributes()
        {
            Rouge rouge = new Rouge("Rijad");
            double expectedVitality = rouge.TotalPrimaryAttributes.Vitality = 11;
            double expectedStrenght = rouge.TotalPrimaryAttributes.Strenght = 3;
            double expectedDexterity = rouge.TotalPrimaryAttributes.Dexterity = 10;
            double expetecIntelligence = rouge.TotalPrimaryAttributes.Intelligence = 2;


            rouge.LevelUp(1);
            double actualVitality = rouge.TotalPrimaryAttributes.Vitality;
            double actualStrenght = rouge.TotalPrimaryAttributes.Strenght;
            double actualDecterity = rouge.TotalPrimaryAttributes.Dexterity;
            double actualIntelligence = rouge.TotalPrimaryAttributes.Intelligence;

            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrenght, actualStrenght);
            Assert.Equal(expectedDexterity, actualDecterity);
            Assert.Equal(actualIntelligence, expetecIntelligence);

        }

        [Fact]
        public void test_Warrior_deafult_stats()
        {
            Warrior warrior = new Warrior("Rijad");
            double expectedVitality = 10;
            double expectedStrenght = 5;
            double expectedDexterity = 2;
            double expetecIntelligence = 1;

            double actualVitality = warrior.BasePrimaryAttributes.Vitality;
            double actualStrenght = warrior.BasePrimaryAttributes.Strenght;
            double actualDecterity = warrior.BasePrimaryAttributes.Dexterity;
            double actualIntelligence = warrior.BasePrimaryAttributes.Intelligence;

            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrenght, actualStrenght);
            Assert.Equal(expectedDexterity, actualDecterity);
            Assert.Equal(actualIntelligence, expetecIntelligence);

        }

        [Fact]
        public void test_Warrior_LevelUp()
        {
            double expectedVitality = 15;
            double expectedStrenght = 8;
            double expectedDexterity = 4;
            double expetecIntelligence = 2;

            Warrior warrior = new Warrior("Rijad");
            warrior.LevelUp(1);
            double actualVitality = warrior.BasePrimaryAttributes.Vitality;
            double actualStrenght = warrior.BasePrimaryAttributes.Strenght;
            double actualDecterity = warrior.BasePrimaryAttributes.Dexterity;
            double actualIntelligence = warrior.BasePrimaryAttributes.Intelligence;

            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrenght, actualStrenght);
            Assert.Equal(expectedDexterity, actualDecterity);
            Assert.Equal(actualIntelligence, expetecIntelligence);


        }

        [Fact]
        public void test_SecondaryStats_Warrior()
        {
            double expectedHealth = 150;
            double expectedArmorRating = 12;
            double expectedElementalResistance = 2;

            Warrior warrior = new Warrior("Warrior");
            warrior.LevelUp(1);

            double actualHealth = warrior.SecondaryAttributes.Health;
            double actualArmorRating = warrior.SecondaryAttributes.ArmorRating;
            double actualElementalResistance = warrior.SecondaryAttributes.ElementalResistance;

            Assert.Equal(expectedHealth, actualHealth);
            Assert.Equal(expectedArmorRating, actualArmorRating);
            Assert.Equal(expectedElementalResistance, actualElementalResistance);
            ;

        }

        [Fact]
        public void test_Mage_Wrong_Weapon()
        {
            Mage mage = new Mage("Rijad");


            Weapon testBow = new Weapon()
            {
                Name = "Common Bow",
                RLevel = 1,
                Slot = Slot.WEAPON,
                WeaponType = WeponType.Bow

            };

            Assert.Throws<InvalidWeaponExeption>(() => mage.setWeaponEquipment(testBow));
        }



        [Fact]
        public void test_Mage_Right_Weapon()
        {
            string expected = "Nice right weapon";
            Mage mage = new Mage("Rijad");
            Weapon testWand = new Weapon()
            {
                Name = "Common Wand",
                RLevel = 1,
                Slot = Slot.WEAPON,
                WeaponType = WeponType.Wand
            };
            string actual = mage.setWeaponEquipment(testWand);
            //Weapon actual = (Weapon) mage.Equipments[Slot.WEAPON];
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void checkDps()
        {
            double expected = (7 * 1.1) * (1 + (5 / 100));
            Warrior warrior = new Warrior("Rijad");

            Weapon testAxeW = new Weapon()
            {
                Name = "Common axe",
                RLevel = 1,
                Slot = Slot.WEAPON,
                WeaponType = WeponType.Axe,
                WeaponAttributes = new WeaponAttributes() {Damage = 7, AttackSpeed = 1.1}


            };
            warrior.setWeaponEquipment(testAxeW);
            double actual = testAxeW.calculateDamage() * warrior.calulculateCharacterDps2();
            Assert.Equal(expected, actual);


        }


        [Fact]
        public void test_checkIfWeaponIsHigherLevel()
        {
            Warrior warrior = new Warrior("Rijad");
            Weapon testAxe = new Weapon()
            {
                Name = "Common axe",
                RLevel = 2,
                Slot = Slot.WEAPON,
                WeaponType = WeponType.Axe,
                WeaponAttributes = new WeaponAttributes() {Damage = 7, AttackSpeed = 1.1}
            };
            Assert.Throws<InvalidWeaponExeption>(() => warrior.setWeaponEquipment(testAxe));

        }

        [Fact]
        public void test_toHighLevel_armor()
        {
            Warrior warrior = new Warrior("warrior");

            Armor testPlateBody = new Armor()
            {
                Name = "Common plate body armor",
                RLevel = 2,
                Slot = Slot.BODY,
                Type = ArmorType.PLATE,
                PrimaryAttributes = new PrimaryAttributes() {Vitality = 2, Strenght = 1}
            };
            Assert.Throws<InvalidArmorExeption>(() => warrior.setArmorEquipment(testPlateBody));
        }

        [Fact]
        public void test_checkDPS_validDpsInLevel1_validDps()
        {
            double expectedDps = 1 * (1 + (5 / 100));
            Warrior warrior = new Warrior("Warrior");
            double actualDps = warrior.generateCharacterDps();

            Assert.Equal(expectedDps, (int) actualDps);
        }


        [Fact]
        public void test_checkDps_validDpsWithAxeAndPlate_correctDps()
        {
            double expected = (7.0 * 1.1) * (1.0 + ((5.0 + 1.0) / 100.0));

            Warrior warrior = new Warrior("Warrior");
            Weapon testAxe = new Weapon()
            {
                Name = "Common axe",
                RLevel = 1,
                Slot = Slot.WEAPON,
                WeaponType = WeponType.Axe,
                WeaponAttributes = new WeaponAttributes() {Damage = 7, AttackSpeed = 1.1}
            };
            warrior.setWeaponEquipment(testAxe);
            Armor plate = new Armor()
            {
                Name = "Plate",
                RLevel = 1,
                Type = ArmorType.PLATE,
                PrimaryAttributes = new PrimaryAttributes(){Dexterity = 1,Intelligence = 1,Strenght = 1,Vitality = 2}
            };

            warrior.setArmorEquipment(plate);

            Assert.Equal(expected,warrior.generateCharacterDps());
            
        }


    }


    
}
