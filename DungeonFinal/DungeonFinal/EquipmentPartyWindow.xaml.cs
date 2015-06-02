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
        //start methods

        private void changeHelmet(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();            
            hero.getHelmet().unEquip(hero);
            hero.setHelmet(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getHelmet().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);
        }

        private void changeTorso(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            hero.getTorso().unEquip(hero);
            hero.setTorso(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getTorso().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);
        }
                
        private void changeGloves(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            hero.getGloves().unEquip(hero);
            hero.setGloves(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getGloves().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);
        }

        private void changeBoots(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            hero.getBoots().unEquip(hero);
            hero.setBoots(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getBoots().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);
        }

        private void changeWeapon(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            hero.getWeapon().unEquip(hero);
            hero.setWeapon(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getWeapon().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);
        }

        
                    

        //end methods

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private void btn_Char1_Helm_Click(object sender, RoutedEventArgs e)
        {
            changeHelmet(_theHeroes[0]);
        }

        private void btn_Char1_Body_Click(object sender, RoutedEventArgs e)
        {
            changeTorso(_theHeroes[0]);
        }

        private void btn_Char1_Gloves_Click(object sender, RoutedEventArgs e)
        {
            changeGloves(_theHeroes[0]);
        }

        private void btn_Char1_Footwear_Click(object sender, RoutedEventArgs e)
        {
            changeBoots(_theHeroes[0]);
        }

        private void btn_Char1_Weapon_Click(object sender, RoutedEventArgs e)
        {
            changeWeapon(_theHeroes[0]);
        }

        
    }
}
