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
using System.Windows.Shapes;

namespace DungeonFinal
{
    /// <summary>
    /// Interaction logic for CharacterSelect.xaml
    /// </summary>
    public partial class CharacterSelect : Window
    {
        private bool ready = false;
        private Party party;

        public CharacterSelect()
        {
            InitializeComponent();
            MessageBox.Show("Please select a character for each hero\r\n" +
                            "Select a character by clicking one radio button in each hero row\r\n" +
                            "indicating which character you would like to assign to each hero slot");
            btn_PartyReady.IsEnabled = false;
            party = new Party();
            paintRectanglesWithHeroImages();
        }


        public void paintRectanglesWithHeroImages()
        {
            ImageBrush imgBrushSwordsman = new ImageBrush();
            BitmapImage imageSwordsman = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-jwP2jq5N8vk/VV7qG6mhNWI/AAAAAAAAA1Q/MCdr_HdAZnw/w506-h731/Swordsman.jpg"));
            imgBrushSwordsman.ImageSource = imageSwordsman;
            rect_Swordsman.Fill = imgBrushSwordsman;

            ImageBrush imgBrushPaladin = new ImageBrush();
            BitmapImage imagePaladin = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-9PZ0hjpgspI/VV7p99bG62I/AAAAAAAAAzg/Ejq9YL1hAtM/w506-h764/Paladin.jpg"));
            imgBrushPaladin.ImageSource = imagePaladin;
            rect_Paladin.Fill = imgBrushPaladin;

            ImageBrush imgBrushCleric = new ImageBrush();
            BitmapImage imageCleric = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-J6UohVY0-2Y/VV7poKYTrEI/AAAAAAAAAws/Xmdq1-qREdI/w506-h900/Cleric.jpg"));
            imgBrushCleric.ImageSource = imageCleric;
            rect_Cleric.Fill = imgBrushCleric;

            ImageBrush imgBrushRogue = new ImageBrush();
            BitmapImage imageRogue = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-GqQ6Ja-aahk/VV7qAx0PD8I/AAAAAAAAA0E/tguBh4geous/w506-h647/Rogue.jpg"));
            imgBrushRogue.ImageSource = imageRogue;
            rect_Rogue.Fill = imgBrushRogue;
        }


        public bool checkReady()
        {
            ready = false;

            if(rbtn_Hero1_Swordsman.IsChecked == true || rbtn_Hero1_Paladin.IsChecked == true || rbtn_Hero1_Cleric.IsChecked == true || rbtn_Hero1_Rogue.IsChecked == true)
            {
                if(rbtn_Hero2_Swordsman.IsChecked == true || rbtn_Hero2_Paladin.IsChecked == true || rbtn_Hero2_Cleric.IsChecked == true || rbtn_Hero2_Rogue.IsChecked == true)
                {
                    if(rbtn_Hero3_Swordsman.IsChecked == true || rbtn_Hero3_Paladin.IsChecked == true || rbtn_Hero3_Cleric.IsChecked == true || rbtn_Hero3_Rogue.IsChecked == true)
                    {
                        if(rbtn_Hero4_Swordsman.IsChecked == true || rbtn_Hero4_Paladin.IsChecked == true || rbtn_Hero4_Cleric.IsChecked == true || rbtn_Hero4_Rogue.IsChecked == true)
                        {
                            ready = true;
                        }
                    }
                }
            }


            if(ready == true)
            {
                btn_PartyReady.IsEnabled = true;
            }

            return ready;
            
        }

        private void btn_PartyReady_Click(object sender, RoutedEventArgs e)
        {
            
            if(rbtn_Hero1_Swordsman.IsChecked == true)
            {
                party.addHero(new Swordsman());
            }
            else if(rbtn_Hero1_Paladin.IsChecked == true)
            {
                party.addHero(new Paladin());
            }
            else if(rbtn_Hero1_Cleric.IsChecked == true)
            {
                party.addHero(new Cleric());
            }
            else if(rbtn_Hero1_Rogue.IsChecked == true)
            {
                party.addHero(new Rogue());
            }


            if (rbtn_Hero2_Swordsman.IsChecked == true)
            {
                party.addHero(new Swordsman());
            }
            else if (rbtn_Hero2_Paladin.IsChecked == true)
            {
                party.addHero(new Paladin());
            }
            else if (rbtn_Hero2_Cleric.IsChecked == true)
            {
                party.addHero(new Cleric());
            }
            else if (rbtn_Hero2_Rogue.IsChecked == true)
            {
                party.addHero(new Rogue());
            }



            if (rbtn_Hero3_Swordsman.IsChecked == true)
            {
                party.addHero(new Swordsman());
            }
            else if (rbtn_Hero3_Paladin.IsChecked == true)
            {
                party.addHero(new Paladin());
            }
            else if (rbtn_Hero3_Cleric.IsChecked == true)
            {
                party.addHero(new Cleric());
            }
            else if (rbtn_Hero3_Rogue.IsChecked == true)
            {
                party.addHero(new Rogue());
            }



            if (rbtn_Hero4_Swordsman.IsChecked == true)
            {
                party.addHero(new Swordsman());
            }
            else if (rbtn_Hero4_Paladin.IsChecked == true)
            {
                party.addHero(new Paladin());
            }
            else if (rbtn_Hero4_Cleric.IsChecked == true)
            {
                party.addHero(new Cleric());
            }
            else if (rbtn_Hero4_Rogue.IsChecked == true)
            {
                party.addHero(new Rogue());
            }

            this.Close();

        }

        private void rbtn_Hero1_Swordsman_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero1_Paladin_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero1_Priest_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero1_Rogue_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero2_Swordsman_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero2_Paladin_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero2_Priest_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero2_Rogue_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero3_Swordsman_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero3_Paladin_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero3_Priest_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero3_Rogue_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero4_Swordsman_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero4_Paladin_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero4_Priest_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rbtn_Hero4_Rogue_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        public Party getPartyFromSelect()
        {
            return party;
        }
    }
}
