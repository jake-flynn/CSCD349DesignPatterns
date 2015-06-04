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
            //lbl_Char1_Helm.Content = _TheHeroes[0].getHelmet().getItemName();
            //lbl_Char1_Footwear.Content = _TheHeroes[0].getBoots().getItemName();
            //lbl_Char1_Gloves.Content = _TheHeroes[0].getGloves().getItemName();
            //lbl_Char1_Body.Content = _TheHeroes[0].getTorso().getItemName();
            //lbl_Char1_Weapon.Content = _TheHeroes[0].getWeapon().getItemName();


            //hero1
            rect_Hero1_Helm.Fill = _TheHeroes[0].getHelmet().getImageBrush();
            rect_Hero1_Footwear.Fill = _TheHeroes[0].getBoots().getImageBrush();
            rect_Hero1_Gloves.Fill = _TheHeroes[0].getGloves().getImageBrush();
            rect_Hero1_Body.Fill = _TheHeroes[0].getTorso().getImageBrush();
            rect_Hero1_Weapon.Fill = _TheHeroes[0].getWeapon().getImageBrush();
            rect_Hero1.Fill = _TheHeroes[0].getImageBrush();
            lbl_Hero1_Stats.Content = _TheHeroes[0].getStats();

            //hero2
            rect_Hero2_Helm.Fill = _TheHeroes[1].getHelmet().getImageBrush();
            rect_Hero2_Footwear.Fill = _TheHeroes[1].getBoots().getImageBrush();
            rect_Hero2_Gloves.Fill = _TheHeroes[1].getGloves().getImageBrush();
            rect_Hero2_Body.Fill = _TheHeroes[1].getTorso().getImageBrush();
            rect_Hero2_Weapon.Fill = _TheHeroes[1].getWeapon().getImageBrush();
            rect_Hero2.Fill = _TheHeroes[1].getImageBrush();
            lbl_Hero2_Stats.Content = _TheHeroes[1].getStats();

            //hero3
            rect_Hero3_Helm.Fill = _TheHeroes[2].getHelmet().getImageBrush();
            rect_Hero3_Footwear.Fill = _TheHeroes[2].getBoots().getImageBrush();
            rect_Hero3_Gloves.Fill = _TheHeroes[2].getGloves().getImageBrush();
            rect_Hero3_Body.Fill = _TheHeroes[2].getTorso().getImageBrush();
            rect_Hero3_Weapon.Fill = _TheHeroes[2].getWeapon().getImageBrush();
            rect_Hero3.Fill = _TheHeroes[2].getImageBrush();
            lbl_Hero3_Stats.Content = _TheHeroes[2].getStats();

            //hero4
            rect_Hero4_Helm.Fill = _TheHeroes[3].getHelmet().getImageBrush();
            rect_Hero4_Footwear.Fill = _TheHeroes[3].getBoots().getImageBrush();
            rect_Hero4_Gloves.Fill = _TheHeroes[3].getGloves().getImageBrush();
            rect_Hero4_Body.Fill = _TheHeroes[3].getTorso().getImageBrush();
            rect_Hero4_Weapon.Fill = _TheHeroes[3].getWeapon().getImageBrush();
            rect_Hero4.Fill = _TheHeroes[3].getImageBrush();
            lbl_Hero4_Stats.Content = _TheHeroes[3].getStats();
        }

        private void changeHelmet(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();

            if (_Inventory.findEquipmentByIndex(equipInventoryIndex).getIsHelmet())
            {
                _Equipment = hero.getHelmet().unEquip(hero);
                hero.setHelmet(_Inventory.findEquipmentByIndex(equipInventoryIndex));
                hero.getHelmet().equip(hero);
                _Inventory.removeFromEquipment(equipInventoryIndex);

                _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);
            }

            else
            {
                MessageBox.Show("Cannot equip something that is not a helmet to this slot!");
            }
            

            updateVisuals();

        }

        private void changeTorso(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();

            if (_Inventory.findEquipmentByIndex(equipInventoryIndex).getIsTorso())
            {
                _Equipment = hero.getTorso().unEquip(hero);
                hero.setTorso(_Inventory.findEquipmentByIndex(equipInventoryIndex));
                hero.getTorso().equip(hero);
                _Inventory.removeFromEquipment(equipInventoryIndex);

                _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);
            }

            else
            {
                MessageBox.Show("Cannot equip something that is not chest armor to this slot");
            }
            
            updateVisuals();

        }
                
        private void changeGloves(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();

            if (_Inventory.findEquipmentByIndex(equipInventoryIndex).getIsGloves())
            {
                _Equipment = hero.getGloves().unEquip(hero);
                hero.setGloves(_Inventory.findEquipmentByIndex(equipInventoryIndex));
                hero.getGloves().equip(hero);
                _Inventory.removeFromEquipment(equipInventoryIndex);

                _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);
            }
            
            else
            {
                MessageBox.Show("Cannot equip something that is not gloves to this slot.");
            }

            updateVisuals();

        }

        private void changeBoots(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();

            if (_Inventory.findEquipmentByIndex(equipInventoryIndex).getIsBoots())
            {
                _Equipment = hero.getBoots().unEquip(hero);
                hero.setBoots(_Inventory.findEquipmentByIndex(equipInventoryIndex));
                hero.getBoots().equip(hero);
                _Inventory.removeFromEquipment(equipInventoryIndex);

                _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);
            }

            else
            {
                MessageBox.Show("Cannot equip something that is not boots to this slot");
            }

            updateVisuals();

        }

        private void changeWeapon(Hero hero)
        {
            var equipmentChoiceWindow = new EquipmentChoiceWindow(_Inventory);
            equipmentChoiceWindow.ShowDialog();
            int equipInventoryIndex = equipmentChoiceWindow.getChoiceFromSelect();

            if (_Inventory.findEquipmentByIndex(equipInventoryIndex).getIsWeapon())
            {
                _Equipment = hero.getWeapon().unEquip(hero);
                hero.setWeapon(_Inventory.findEquipmentByIndex(equipInventoryIndex));
                hero.getWeapon().equip(hero);
                _Inventory.removeFromEquipment(equipInventoryIndex);

                _Inventory.addToEquipmentByIndex(equipInventoryIndex, _Equipment);
            }

            else
            {
                MessageBox.Show("Cannot equip something that is not a weapon to this slot");
            }

            updateVisuals();
        }

        
                    

        //end methods

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private void btn_Hero1_Helm_Click(object sender, RoutedEventArgs e)
        {
            changeHelmet(_TheHeroes[0]);
        }

        private void btn_Hero1_Body_Click(object sender, RoutedEventArgs e)
        {
            changeTorso(_TheHeroes[0]);
        }

        private void btn_Hero1_Gloves_Click(object sender, RoutedEventArgs e)
        {
            changeGloves(_TheHeroes[0]);
        }

        private void btn_Hero1_Footwear_Click(object sender, RoutedEventArgs e)
        {
            changeBoots(_TheHeroes[0]);
        }

        private void btn_Hero1_Weapon_Click(object sender, RoutedEventArgs e)
        {
            changeWeapon(_TheHeroes[0]);
        }

        //------------------------------------//

        private void btn_Hero2_Helm_Click(object sender, RoutedEventArgs e)
        {
            changeHelmet(_TheHeroes[1]);
        }

        private void btn_Hero2_Body_Click(object sender, RoutedEventArgs e)
        {
            changeTorso(_TheHeroes[1]);
        }

        private void btn_Hero2_Gloves_Click(object sender, RoutedEventArgs e)
        {
            changeGloves(_TheHeroes[1]);
        }

        private void btn_Hero2_Footwear_Click(object sender, RoutedEventArgs e)
        {
            changeBoots(_TheHeroes[1]);
        }

        private void btn_Hero2_Weapon_Click(object sender, RoutedEventArgs e)
        {
            changeWeapon(_TheHeroes[1]);
        }

        //------------------------------------//
        
        private void btn_Hero3_Helm_Click(object sender, RoutedEventArgs e)
        {
            changeHelmet(_TheHeroes[2]);
        }

        private void btn_Hero3_Body_Click(object sender, RoutedEventArgs e)
        {
            changeTorso(_TheHeroes[2]);
        }

        private void btn_Hero3_Footwear_Click(object sender, RoutedEventArgs e)
        {
            changeBoots(_TheHeroes[2]);
        }

        private void btn_Hero3_Gloves_Click(object sender, RoutedEventArgs e)
        {
            changeGloves(_TheHeroes[2]);
        }

        private void btn_Hero3_Weapon_Click(object sender, RoutedEventArgs e)
        {
            changeWeapon(_TheHeroes[2]);
        }

        //------------------------------------//

        private void btn_Hero4_Helm_Click(object sender, RoutedEventArgs e)
        {
            changeHelmet(_TheHeroes[3]);
        }

        private void btn_Hero4_Body_Click(object sender, RoutedEventArgs e)
        {
            changeTorso(_TheHeroes[3]);
        }

        private void btn_Hero4_Footwear_Click(object sender, RoutedEventArgs e)
        {
            changeBoots(_TheHeroes[3]);
        }

        private void btn_Hero4_Gloves_Click(object sender, RoutedEventArgs e)
        {
            changeGloves(_TheHeroes[3]);
        }

        private void btn_Hero4_Weapon_Click(object sender, RoutedEventArgs e)
        {
            changeWeapon(_TheHeroes[3]);
        }

        
    }
}
