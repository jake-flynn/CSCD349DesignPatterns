﻿using System;
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
    /// Interaction logic for ConsumableWindow.xaml
    /// </summary>
    public partial class EquipmentChoiceWindow : Window
    {
        Inventory _Inventory;
        int _choice;

        public EquipmentChoiceWindow(Inventory CurrentInventory)
        {
            InitializeComponent();
            _Inventory = CurrentInventory;
            updateVisuals();
        }


        //start methods
        public void updateVisuals()
        {
            lbl_item1.Content = _Inventory.findEquipmentByIndex(0).getItemName();
            lbl_item2.Content = _Inventory.findEquipmentByIndex(1).getItemName();
            lbl_item3.Content = _Inventory.findEquipmentByIndex(2).getItemName();
            lbl_item4.Content = _Inventory.findEquipmentByIndex(3).getItemName();
            lbl_item5.Content = _Inventory.findEquipmentByIndex(4).getItemName();
            lbl_item6.Content = _Inventory.findEquipmentByIndex(5).getItemName();
            lbl_item7.Content = _Inventory.findEquipmentByIndex(6).getItemName();
            lbl_item8.Content = _Inventory.findEquipmentByIndex(7).getItemName();
            lbl_item9.Content = _Inventory.findEquipmentByIndex(8).getItemName();
            lbl_item10.Content = _Inventory.findEquipmentByIndex(9).getItemName();
            lbl_item11.Content = _Inventory.findEquipmentByIndex(10).getItemName();
            lbl_item12.Content = _Inventory.findEquipmentByIndex(11).getItemName();
            lbl_item13.Content = _Inventory.findEquipmentByIndex(12).getItemName();
            lbl_item14.Content = _Inventory.findEquipmentByIndex(13).getItemName();
            lbl_item15.Content = _Inventory.findEquipmentByIndex(14).getItemName();
            lbl_item16.Content = _Inventory.findEquipmentByIndex(15).getItemName();
            lbl_item17.Content = _Inventory.findEquipmentByIndex(16).getItemName();
            lbl_item18.Content = _Inventory.findEquipmentByIndex(17).getItemName();
            lbl_item19.Content = _Inventory.findEquipmentByIndex(18).getItemName();
            lbl_item20.Content = _Inventory.findEquipmentByIndex(19).getItemName();

            rect_item1.Fill = _Inventory.findEquipmentByIndex(0).getImageBrush();
            rect_item2.Fill = _Inventory.findEquipmentByIndex(1).getImageBrush();
            rect_item3.Fill = _Inventory.findEquipmentByIndex(2).getImageBrush();
            rect_item4.Fill = _Inventory.findEquipmentByIndex(3).getImageBrush();
            rect_item5.Fill = _Inventory.findEquipmentByIndex(4).getImageBrush();
            rect_item6.Fill = _Inventory.findEquipmentByIndex(5).getImageBrush();
            rect_item7.Fill = _Inventory.findEquipmentByIndex(6).getImageBrush();
            rect_item8.Fill = _Inventory.findEquipmentByIndex(7).getImageBrush();
            rect_item9.Fill = _Inventory.findEquipmentByIndex(8).getImageBrush();
            rect_item10.Fill = _Inventory.findEquipmentByIndex(9).getImageBrush();
            rect_item11.Fill = _Inventory.findEquipmentByIndex(10).getImageBrush();
            rect_item12.Fill = _Inventory.findEquipmentByIndex(11).getImageBrush();
            rect_item13.Fill = _Inventory.findEquipmentByIndex(12).getImageBrush();
            rect_item14.Fill = _Inventory.findEquipmentByIndex(13).getImageBrush();
            rect_item15.Fill = _Inventory.findEquipmentByIndex(14).getImageBrush();
            rect_item16.Fill = _Inventory.findEquipmentByIndex(15).getImageBrush();
            rect_item17.Fill = _Inventory.findEquipmentByIndex(16).getImageBrush();
            rect_item18.Fill = _Inventory.findEquipmentByIndex(17).getImageBrush();
            rect_item19.Fill = _Inventory.findEquipmentByIndex(18).getImageBrush();
            rect_item20.Fill = _Inventory.findEquipmentByIndex(19).getImageBrush();

            
        }

        public int getChoiceFromSelect()
        {
            return _choice;
        }

        //end methods

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private void btn_item1_Click(object sender, RoutedEventArgs e)
        {
            _choice = 0;
            this.Close();
        }

        private void btn_item2_Click(object sender, RoutedEventArgs e)
        {
            _choice = 1;
            this.Close();
        }

        private void btn_item3_Click(object sender, RoutedEventArgs e)
        {
            _choice = 2;
            this.Close();
        }

        private void btn_item4_Click(object sender, RoutedEventArgs e)
        {
            _choice = 3;
            this.Close();
        }

        private void btn_item5_Click(object sender, RoutedEventArgs e)
        {
            _choice = 4;
            this.Close();
        }

        private void btn_item6_Click(object sender, RoutedEventArgs e)
        {
            _choice = 5;
            this.Close();
        }

        private void btn_item7_Click(object sender, RoutedEventArgs e)
        {
            _choice = 6;
            this.Close();
        }

        private void btn_item8_Click(object sender, RoutedEventArgs e)
        {
            _choice = 7;
            this.Close();
        }

        private void btn_item9_Click(object sender, RoutedEventArgs e)
        {
            _choice = 8;
            this.Close();
        }

        private void btn_item10_Click(object sender, RoutedEventArgs e)
        {
            _choice = 9;
            this.Close();
        }

        private void btn_item11_Click(object sender, RoutedEventArgs e)
        {
            _choice = 10;
            this.Close();
        }

        private void btn_item12_Click(object sender, RoutedEventArgs e)
        {
            _choice = 11;
            this.Close();
        }

        private void btn_item13_Click(object sender, RoutedEventArgs e)
        {
            _choice = 12;
            this.Close();
        }

        private void btn_item14_Click(object sender, RoutedEventArgs e)
        {
            _choice = 13;
            this.Close();
        }

        private void btn_item15_Click(object sender, RoutedEventArgs e)
        {
            _choice = 14;
            this.Close();
        }

        private void btn_item16_Click(object sender, RoutedEventArgs e)
        {
            _choice = 15;
            this.Close();
        }

        private void btn_item17_Click(object sender, RoutedEventArgs e)
        {
            _choice = 16;
            this.Close();
        }

        private void btn_item18_Click(object sender, RoutedEventArgs e)
        {
            _choice = 17;
            this.Close();
        }

        private void btn_item19_Click(object sender, RoutedEventArgs e)
        {
            _choice = 18;
            this.Close();
        }

        private void btn_item20_Click(object sender, RoutedEventArgs e)
        {
            _choice = 19;
            this.Close();
        }
    }
}
