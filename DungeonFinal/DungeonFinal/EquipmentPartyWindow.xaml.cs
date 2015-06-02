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
        Hero[] _TheHeroes;
        Inventory _Inventory;
        Equipment _Equipment;

        public PartyEquipmentWindow(Party party)
        {
            InitializeComponent();

            _TheHeroes = party.getAllHeroes();
            _Inventory = party.getInventory();
            updateVisuals();
        }
        //start methods

        public void updateVisuals()
        {
            lbl_Char1_Helm.Content = _TheHeroes[0].getHelmet().getItemName();

            rect_Char1_Helm.Fill = _TheHeroes[0].getHelmet().getImageBrush();
        }

        private void changeHelmet(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();            
            _Equipment = hero.getHelmet().unEquip(hero);
            hero.setHelmet(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getHelmet().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);

            _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);

            updateVisuals();

        }

        private void changeTorso(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            _Equipment = hero.getTorso().unEquip(hero);
            hero.setTorso(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getTorso().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);

            _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);

            updateVisuals();

        }
                
        private void changeGloves(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            _Equipment = hero.getGloves().unEquip(hero);
            hero.setGloves(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getGloves().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);

            _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);

            updateVisuals();

        }

        private void changeBoots(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            _Equipment = hero.getBoots().unEquip(hero);
            hero.setBoots(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getBoots().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);

            _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);

            updateVisuals();

        }

        private void changeWeapon(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();
            _Equipment = hero.getWeapon().unEquip(hero);
            hero.setWeapon(_Inventory.findEquipmentByIndex(equipInventoryIndex));
            hero.getWeapon().equip(hero);
            _Inventory.removeFromEquipment(equipInventoryIndex);

            _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);

            updateVisuals();

        }

        
                    

        //end methods

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private void btn_Char1_Helm_Click(object sender, RoutedEventArgs e)
        {
            changeHelmet(_TheHeroes[0]);
        }

        private void btn_Char1_Body_Click(object sender, RoutedEventArgs e)
        {
            changeTorso(_TheHeroes[0]);
        }

        private void btn_Char1_Gloves_Click(object sender, RoutedEventArgs e)
        {
            changeGloves(_TheHeroes[0]);
        }

        private void btn_Char1_Footwear_Click(object sender, RoutedEventArgs e)
        {
            changeBoots(_TheHeroes[0]);
        }

        private void btn_Char1_Weapon_Click(object sender, RoutedEventArgs e)
        {
            changeWeapon(_TheHeroes[0]);
        }

        
    }
}
