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
    /// Interaction logic for PartyEquipmentWindow.xaml
    /// </summary>
    public partial class PartyEquipmentWindow : Window
    {
        Hero[] _theHeroes;
        Inventory _Inventory;

        public PartyEquipmentWindow(Party party)
        {
            InitializeComponent();

            _theHeroes = party.getHeros();
            _Inventory = party.getInventory();
        }

        private void btn_Char1_Helm_Click(object sender, RoutedEventArgs e)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            MessageBox.Show(equipInventoryIndex + "");
            _theHeroes[0].setHelm(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            _Inventory.removeFromEquipment(equipInventoryIndex);
        }

        private void btn_Char1_Body_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Char1_Gloves_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Char1_Footwear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Char1_Weapon_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
