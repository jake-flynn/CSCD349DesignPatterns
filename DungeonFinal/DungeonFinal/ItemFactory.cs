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
        public ItemFactory()
        {

        }

        public Item createItem(int tierLevel)
        {
            Item newItem = new NullItemConsumable();

            if(tierLevel == 1)
            {
                var randomNumber = new Random();
                int choice = randomNumber.Next(12) + 1;

                if(choice == 1)
                {
                    return new SimpleSword();
                }

                else if(choice == 2)
                {
                    return new SimpleAxe();
                }

                else if(choice == 3)
                {
                    return new SimpleDagger();
                }

                else if(choice == 4)
                {
                    return new SimpleStaff();
                }

                else if(choice == 5)
                {
                    return new LesserPotionOfHealth();
                }

                else if(choice == 6)
                {
                    return new LesserPotionOfMana();
                }

                else if(choice == 7)
                {
                    return new LesserPotionOfDefense();
                }

                else if(choice == 8)
                {
                    return new LesserPotionOfResistance();
                }

                else if(choice == 9)
                {
                    return new LesserPotionOfMagic();
                }

                else if(choice == 10)
                {
                    return new LesserPotionOfPower();
                }

                else if(choice == 11)
                {
                    return new RuneOfHope();
                }

                else if (choice == 12)
                {
                    return new RuneOfDespair();
                }
            }

            else if(tierLevel == 2)
            {
                var randomNumber = new Random();
                int choice = randomNumber.Next(26) + 1;

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
                    return new PotionOfDefense();
                }

                else if (choice == 6)
                {
                    return new PotionOfResistance();
                }

                else if (choice == 7)
                {
                    return new PotionOfHealth();
                }

                else if (choice == 8)
                {
                    return new PotionOfMana();
                }

                else if (choice == 9)
                {
                    return new PotionOfPower();
                }

                else if (choice == 10)
                {
                    return new PotionOfMagic();
                }

                else if (choice == 11)
                {
                    return new ChainMailBoots();
                }

                else if (choice == 12)
                {
                    return new ChainMailGloves();
                }

                else if(choice == 13)
                {
                    return new ChainMailHelm();
                }

                else if(choice == 14)
                {
                    return new ChainMailVest();
                }

                else if(choice == 15)
                {
                    return new ClothGloves();
                }

                else if(choice == 16)
                {
                    return new ClothHeadPiece();
                }
                
                else if(choice == 17)
                {
                    return new ClothRobes();
                }

                else if(choice == 18)
                {
                    return new ClothShoes();
                }

                else if (choice == 19)
                {
                    return new BronzeGloves();
                }

                else if (choice == 20)
                {
                    return new BronzeHelmet();
                }

                else if (choice == 21)
                {
                    return new BronzeBoots();
                }

                else if (choice == 22)
                {
                    return new BronzeChestPlate();
                }

                else if (choice == 23)
                {
                    return new LeatherBoots();
                }

                else if (choice == 24)
                {
                    return new LeatherGloves();
                }

                else if (choice == 25)
                {
                    return new LeatherHelmet();
                }

                else if (choice == 26)
                {
                    return new LeatherVest();
                }
            }

            else if(tierLevel == 3)
            {
                var randomNumber = new Random();
                int choice = randomNumber.Next(13) + 1;

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
                    return new GreaterPotionOfHealth();
                }

                else if (choice == 6)
                {
                    return new GreaterPotionOfMana();
                }

                else if (choice == 7)
                {
                    return new GreaterPotionOfDefense();
                }

                else if (choice == 8)
                {
                    return new GreaterPotionOfResistance();
                }

                else if (choice == 9)
                {
                    return new GreaterPotionOfMagic();
                }

                else if (choice == 10)
                {
                    return new GreaterPotionOfPower();
                }

                else if (choice == 11)
                {
                    return new RuneOfDestruction();
                }

                else if (choice == 12)
                {
                    return new RuneOfCreation();
                }

                else if(choice == 13)
                {
                    return new RuneOfTranquility();
                }
            }

            else if(tierLevel == 4)
            {
                var randomNumber = new Random();
                int choice = randomNumber.Next(1) + 1;

                if(choice == 1)
                {
                    return new Ultima();
                }

            }

            return newItem;
        }
    }
}
