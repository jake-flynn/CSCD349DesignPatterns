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
    /// Interaction logic for ConsumableWindow.xaml
    /// </summary>
    public partial class ConsumableWindow : Window
    {
        Inventory _Inventory;
        int _choice;

        public ConsumableWindow(Inventory CurrentInventory)
        {
            InitializeComponent();
            _Inventory = CurrentInventory;
            lbl_item1.Content = _Inventory.findConsumableByIndex(0).getItemName();
            lbl_item2.Content = _Inventory.findConsumableByIndex(1).getItemName();
            lbl_item3.Content = _Inventory.findConsumableByIndex(2).getItemName();
            lbl_item4.Content = _Inventory.findConsumableByIndex(3).getItemName();
            //lbl_item5.Content = _Inventory.findItemByIndex(4).getItemName();
            //lbl_item6.Content = _Inventory.findItemByIndex(5).getItemName();
            //lbl_item7.Content = _Inventory.findItemByIndex(6).getItemName();
            //lbl_item8.Content = _Inventory.findItemByIndex(7).getItemName();
            //lbl_item9.Content = _Inventory.findItemByIndex(8).getItemName();
            //lbl_item10.Content = _Inventory.findItemByIndex(9).getItemName();
            //lbl_item11.Content = _Inventory.findItemByIndex(10).getItemName();
            //lbl_item12.Content = _Inventory.findItemByIndex(11).getItemName();
            //lbl_item13.Content = _Inventory.findItemByIndex(12).getItemName();
            //lbl_item14.Content = _Inventory.findItemByIndex(13).getItemName();
            //lbl_item15.Content = _Inventory.findItemByIndex(14).getItemName();
            //lbl_item16.Content = _Inventory.findItemByIndex(15).getItemName();
            //lbl_item17.Content = _Inventory.findItemByIndex(16).getItemName();
            //lbl_item18.Content = _Inventory.findItemByIndex(17).getItemName();
            //lbl_item19.Content = _Inventory.findItemByIndex(18).getItemName();
            //lbl_item20.Content = _Inventory.findItemByIndex(19).getItemName();

            rect_item1.Fill = _Inventory.findConsumableByIndex(0).getBrush();
            rect_item2.Fill = _Inventory.findConsumableByIndex(1).getBrush();
            rect_item3.Fill = _Inventory.findConsumableByIndex(2).getBrush();
            rect_item4.Fill = _Inventory.findConsumableByIndex(3).getBrush();

        }


        //start methods
        public void updateVisuals()
        {
            
        }

        public int getChoiceFromSelect()
        {
            return _choice;
        }

        //end methods

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
