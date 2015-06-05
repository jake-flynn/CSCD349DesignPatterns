using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DungeonFinal
{
    public class ItemFactory
    {
        private static Random randomNumber;
        public ItemFactory()
        {
            if (randomNumber == null)
            {
                randomNumber = new Random();
            }
            
        }

        public Consumable createConsumable(int tierLevel)
        {
            Consumable newItem = new NullItemConsumable();

            if(tierLevel == 1)
            {
                
                int choice = randomNumber.Next(9) + 1;

                if(choice == 1)
                {
                    return new LesserPotionOfHealth();
                }

                else if(choice == 2)
                {
                    return new LesserPotionOfMana();
                }

                else if(choice == 3)
                {
                    return new LesserPotionOfDefense();
                }

                else if(choice == 4)
                {
                    return new LesserPotionOfResistance();
                }

                else if(choice == 5)
                {
                    return new LesserPotionOfMagic();
                }

                else if(choice == 6)
                {
                    return new LesserPotionOfPower();
                }

                else if(choice == 7)
                {
                    return new LesserPotionOfRejuvenation();
                }

                else if(choice == 8)
                {
                    return new LesserPotionOfHealthRegeneration();
                }

                else if (choice == 9)
                {
                    return new LesserPotionOfManaRegeneration();
                }
            }

            else if(tierLevel == 2)
            {
                int choice = randomNumber.Next(9) + 1;

                if (choice == 1)
                {
                    return new PotionOfDefense();
                }

                else if (choice == 2)
                {
                    return new PotionOfResistance();
                }

                else if (choice == 3)
                {
                    return new PotionOfHealth();
                }

                else if (choice == 4)
                {
                    return new PotionOfMana();
                }

                else if (choice == 5)
                {
                    return new PotionOfPower();
                }

                else if (choice == 6)
                {
                    return new PotionOfMagic();
                }

                else if (choice == 7)
                {
                    return new PotionOfHealthRegeneration();
                }

                else if (choice == 8)
                {
                    return new PotionOfManaRegeneration();
                }

                else if (choice == 9)
                {
                    return new PotionOfRejuvenation();
                }
            }

            else if(tierLevel == 3)
            {                
                int choice = randomNumber.Next(9) + 1;

                if (choice == 1)
                {
                    return new GreaterPotionOfHealth();
                }

                else if (choice == 2)
                {
                    return new GreaterPotionOfMana();
                }

                else if (choice == 3)
                {
                    return new GreaterPotionOfDefense();
                }

                else if (choice == 4)
                {
                    return new GreaterPotionOfResistance();
                }

                else if (choice == 5)
                {
                    return new GreaterPotionOfMagic();
                }

                else if (choice == 6)
                {
                    return new GreaterPotionOfPower();
                }

                else if (choice == 7)
                {
                    return new GreaterPotionOfHealthRegeneration();
                }

                else if (choice == 8)
                {
                    return new GreaterPotionOfManaRegeneration();
                }

                else if (choice == 9)
                {
                    return new GreaterPotionOfRejuvenation();
                }
            }

            return newItem;
        }

        public Equipment createEquipment(int tierLevel)
        {
            Equipment newItem = new NullItemEquipment();

            if (tierLevel == 1)
            {                
                int choice = randomNumber.Next(16) + 1;

                if (choice == 1)
                {
                    return new BronzeSword();
                }

                else if (choice == 2)
                {
                    return new BronzeAxe();
                }

                else if (choice == 3)
                {
                    return new BronzeDagger();
                }

                else if (choice == 4)
                {
                    return new BronzeStaff();
                }

                else if (choice == 5)
                {
                    return new ClothGloves();
                }

                else if (choice == 6)
                {
                    return new ClothHood();
                }

                else if (choice == 7)
                {
                    return new ClothRobes();
                }

                else if (choice == 8)
                {
                    return new ClothBoots();
                }

                else if (choice == 9)
                {
                    return new BronzeGloves();
                }

                else if (choice == 10)
                {
                    return new BronzeHelmet();
                }

                else if (choice == 11)
                {
                    return new BronzeBoots();
                }

                else if (choice == 12)
                {
                    return new BronzeChestPlate();
                }

                else if (choice == 13)
                {
                    return new LeatherBoots();
                }

                else if (choice == 14)
                {
                    return new LeatherGloves();
                }

                else if (choice == 15)
                {
                    return new LeatherHelmet();
                }

                else if (choice == 16)
                {
                    return new LeatherVest();
                }

                //if (choice == 1)
                //{
                //    return new SimpleSword();
                //}

                //else if (choice == 2)
                //{
                //    return new SimpleAxe();
                //}

                //else if (choice == 3)
                //{
                //    return new SimpleDagger();
                //}

                //else if (choice == 4)
                //{
                //    return new SimpleStaff();
                //}
            

            }

            else if (tierLevel == 2)
            {                
                int choice = randomNumber.Next(16) + 1;

                if (choice == 1)
                {
                    return new SteelSword();
                }

                else if (choice == 2)
                {
                    return new SteelAxe();
                }

                else if (choice == 3)
                {
                    return new SteelDagger();
                }

                else if (choice == 4)
                {
                    return new SteelStaff();
                }

                else if (choice == 5)
                {
                    return new SteelBoots();
                }

                else if (choice == 6)
                {
                    return new SteelChestPlate();
                }

                else if (choice == 7)
                {
                    return new SteelGloves();
                }

                else if (choice == 8)
                {
                    return new SteelHelmet();
                }

                else if (choice == 9)
                {
                    return new ChainMailBoots();
                }

                else if (choice == 10)
                {
                    return new ChainMailGloves();
                }

                else if (choice == 11)
                {
                    return new ChainMailHelm();
                }

                else if (choice == 12)
                {
                    return new ChainMailVest();
                }

                else if (choice == 13)
                {
                    return new EnchantedBoots();
                }

                else if (choice == 14)
                {
                    return new EnchantedGloves();
                }

                else if (choice == 15)
                {
                    return new EnchantedHood();
                }

                else if (choice == 16)
                {
                    return new EnchantedRobes();
                }
            }

            else if (tierLevel == 3)
            {                
                int choice = randomNumber.Next(20) + 1;

                if(choice == 1)
                {
                    return new MythrilBoots();
                }

                else if (choice == 2)
                {
                    return new MythrilGloves();
                }

                else if (choice == 3)
                {
                    return new MythrilHelmet();
                }

                else if (choice == 4)
                {
                    return new MythrilChestPlate();
                }

                else if (choice == 5)
                {
                    return new AssassinBoots();
                }

                else if (choice == 6)
                {
                    return new AssassinGloves();
                }

                else if (choice == 7)
                {
                    return new AssassinHood();
                }

                else if (choice == 8)
                {
                    return new AssassinCloak();
                }

                else if(choice == 9)
                {
                    return new PlateMailBoots();
                }

                else if (choice == 10)
                {
                    return new PlateMailGloves();
                }

                else if (choice == 11)
                {
                    return new PlateMailHelmet();
                }

                else if (choice == 12)
                {
                    return new PlateMailVest();
                }

                else if(choice == 13)
                {
                    return new MythicalBoots();
                }

                else if (choice == 14)
                {
                    return new MythicalGloves();
                }

                else if (choice == 15)
                {
                    return new MythicalHelmet();
                }

                else if (choice == 16)
                {
                    return new MythicalRobes();
                }

                else if(choice == 17)
                {
                    return new MythrilAxe();
                }

                else if (choice == 18)
                {
                    return new MythrilSword();
                }

                else if (choice == 19)
                {
                    return new MythrilDagger();
                }

                else if (choice == 20)
                {
                    return new MythrilStaff();
                }
            }

            else if (tierLevel == 4)
            {                
                int choice = randomNumber.Next(1) + 1;

                if (choice == 1)
                {
                    return new Ultima();
                }

            }

            return newItem;
        }
    }
}
