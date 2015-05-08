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
        }

        public bool checkReady()
        {
            ready = false;

            if(rbtn_Hero1_Swordsman.IsChecked == true || rbtn_Hero1_Paladin.IsChecked == true || rbtn_Hero1_Priest.IsChecked == true || rbtn_Hero1_Rogue.IsChecked == true)
            {
                if(rbtn_Hero2_Swordsman.IsChecked == true || rbtn_Hero2_Paladin.IsChecked == true || rbtn_Hero2_Priest.IsChecked == true || rbtn_Hero2_Rogue.IsChecked == true)
                {
                    if(rbtn_Hero3_Swordsman.IsChecked == true || rbtn_Hero3_Paladin.IsChecked == true || rbtn_Hero3_Priest.IsChecked == true || rbtn_Hero3_Rogue.IsChecked == true)
                    {
                        if(rbtn_Hero4_Swordsman.IsChecked == true || rbtn_Hero4_Paladin.IsChecked == true || rbtn_Hero4_Priest.IsChecked == true || rbtn_Hero4_Rogue.IsChecked == true)
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
                party.addHero(new Hero(1));
            }
            else if(rbtn_Hero1_Paladin.IsChecked == true)
            {
                party.addHero(new Hero(2));
            }
            else if(rbtn_Hero1_Priest.IsChecked == true)
            {
                party.addHero(new Hero(3));
            }
            else if(rbtn_Hero1_Rogue.IsChecked == true)
            {
                party.addHero(new Hero(4));
            }


            if (rbtn_Hero2_Swordsman.IsChecked == true)
            {
                party.addHero(new Hero(1));
            }
            else if (rbtn_Hero2_Paladin.IsChecked == true)
            {
                party.addHero(new Hero(2));
            }
            else if (rbtn_Hero2_Priest.IsChecked == true)
            {
                party.addHero(new Hero(3));
            }
            else if (rbtn_Hero2_Rogue.IsChecked == true)
            {
                party.addHero(new Hero(4));
            }



            if (rbtn_Hero3_Swordsman.IsChecked == true)
            {
                party.addHero(new Hero(1));
            }
            else if (rbtn_Hero3_Paladin.IsChecked == true)
            {
                party.addHero(new Hero(2));
            }
            else if (rbtn_Hero3_Priest.IsChecked == true)
            {
                party.addHero(new Hero(3));
            }
            else if (rbtn_Hero3_Rogue.IsChecked == true)
            {
                party.addHero(new Hero(4));
            }



            if (rbtn_Hero4_Swordsman.IsChecked == true)
            {
                party.addHero(new Hero(1));
            }
            else if (rbtn_Hero4_Paladin.IsChecked == true)
            {
                party.addHero(new Hero(2));
            }
            else if (rbtn_Hero4_Priest.IsChecked == true)
            {
                party.addHero(new Hero(3));
            }
            else if (rbtn_Hero4_Rogue.IsChecked == true)
            {
                party.addHero(new Hero(4));
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
