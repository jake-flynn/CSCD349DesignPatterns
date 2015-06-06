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
        private bool _ready = false;
        private Party _party;
        private Hero[] _TheHeroes;

        public CharacterSelect()
        {
            InitializeComponent();
            MessageBox.Show("Please select a character for each hero\r\n" +
                            "Select a character by clicking one radio button in each hero row\r\n" +
                            "indicating which character you would like to assign to each hero slot");
            btn_PartyReady.IsEnabled = false;
            _party = new Party();
            //paintRectanglesWithHeroImages();

            _TheHeroes = new Hero[4];

            btn_PartyReady.IsEnabled = true;

            

        }


        public void paintRectanglesWithHeroImages()
        {
            
        }


        public bool checkReady()
        {
            _ready = true;

         


            if(_ready == true)
            {
                btn_PartyReady.IsEnabled = true;
            }

            return _ready;
            
        }

        private void btn_PartyReady_Click(object sender, RoutedEventArgs e)
        {

            _party.addHero(_TheHeroes[0]);
            _party.addHero(_TheHeroes[1]);
            _party.addHero(_TheHeroes[2]);
            _party.addHero(_TheHeroes[3]);

            this.Close();

        }

       

        public Party getPartyFromSelect()
        {
            return _party;
        }

        private void cmbBox_Hero1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbBox_Hero1.SelectedIndex.Equals(0))
            {
                _TheHeroes[0] = new ArmorKnight();
            }
            else if (cmbBox_Hero1.SelectedIndex.Equals(1))
            {
                _TheHeroes[0] = new Cleric();
            }
            else if (cmbBox_Hero1.SelectedIndex.Equals(2))
            {
                _TheHeroes[0] = new Monk();
            }
            else if (cmbBox_Hero1.SelectedIndex.Equals(3))
            {
                _TheHeroes[0] = new Paladin();
            }
            else if (cmbBox_Hero1.SelectedIndex.Equals(4))
            {
                _TheHeroes[0] = new Rogue();
            }
            else if (cmbBox_Hero1.SelectedIndex.Equals(5))
            {
                _TheHeroes[0] = new Sorceress();
            }      
            else if(cmbBox_Hero1.SelectedIndex.Equals(6))
            {
                _TheHeroes[0] = new Swordsman();
            }
            else if (cmbBox_Hero1.SelectedIndex.Equals(7))
            {
                _TheHeroes[0] = new Warlock();
            }
            
            
            rect_Hero1.Fill = _TheHeroes[0].getImageBrush();
        }

        private void cmbBox_Hero2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbBox_Hero2.SelectedIndex.Equals(0))
            {
                _TheHeroes[1] = new ArmorKnight();
            }
            else if (cmbBox_Hero2.SelectedIndex.Equals(1))
            {
                _TheHeroes[1] = new Cleric();
            }
            else if (cmbBox_Hero2.SelectedIndex.Equals(2))
            {
                _TheHeroes[1] = new Monk();
            }
            else if (cmbBox_Hero2.SelectedIndex.Equals(3))
            {
                _TheHeroes[1] = new Paladin();
            }
            else if (cmbBox_Hero2.SelectedIndex.Equals(4))
            {
                _TheHeroes[1] = new Rogue();
            }
            else if (cmbBox_Hero2.SelectedIndex.Equals(5))
            {
                _TheHeroes[1] = new Sorceress();
            }
            else if (cmbBox_Hero2.SelectedIndex.Equals(6))
            {
                _TheHeroes[1] = new Swordsman();
            }
            else if (cmbBox_Hero2.SelectedIndex.Equals(7))
            {
                _TheHeroes[1] = new Warlock();
            }

            rect_Hero2.Fill = _TheHeroes[1].getImageBrush();
        }

        private void cmbBox_Hero3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cmbBox_Hero3.SelectedIndex.Equals(0))
            {
                _TheHeroes[2] = new ArmorKnight();
            }
            else if (cmbBox_Hero3.SelectedIndex.Equals(1))
            {
                _TheHeroes[2] = new Cleric();
            }
            else if (cmbBox_Hero3.SelectedIndex.Equals(2))
            {
                _TheHeroes[2] = new Monk();
            }
            else if (cmbBox_Hero3.SelectedIndex.Equals(3))
            {
                _TheHeroes[2] = new Paladin();
            }
            else if (cmbBox_Hero3.SelectedIndex.Equals(4))
            {
                _TheHeroes[2] = new Rogue();
            }
            else if (cmbBox_Hero3.SelectedIndex.Equals(5))
            {
                _TheHeroes[2] = new Sorceress();
            }
            else if (cmbBox_Hero3.SelectedIndex.Equals(6))
            {
                _TheHeroes[2] = new Swordsman();
            }
            else if (cmbBox_Hero3.SelectedIndex.Equals(7))
            {
                _TheHeroes[2] = new Warlock();
            }

            rect_Hero3.Fill = _TheHeroes[2].getImageBrush();
        }

        private void cmbBox_Hero4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbBox_Hero4.SelectedIndex.Equals(0))
            {
                _TheHeroes[3] = new ArmorKnight();
            }
            else if (cmbBox_Hero4.SelectedIndex.Equals(1))
            {
                _TheHeroes[3] = new Cleric();
            }
            else if (cmbBox_Hero4.SelectedIndex.Equals(2))
            {
                _TheHeroes[3] = new Monk();
            }
            else if (cmbBox_Hero4.SelectedIndex.Equals(3))
            {
                _TheHeroes[3] = new Paladin();
            }
            else if (cmbBox_Hero4.SelectedIndex.Equals(4))
            {
                _TheHeroes[3] = new Rogue();
            }
            else if (cmbBox_Hero4.SelectedIndex.Equals(5))
            {
                _TheHeroes[3] = new Sorceress();
            }
            else if (cmbBox_Hero4.SelectedIndex.Equals(6))
            {
                _TheHeroes[3] = new Swordsman();
            }
            else if (cmbBox_Hero4.SelectedIndex.Equals(7))
            {
                _TheHeroes[3] = new Warlock();
            }

            rect_Hero4.Fill = _TheHeroes[3].getImageBrush();
        }
    }
}
