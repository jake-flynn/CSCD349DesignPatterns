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
        public ConsumableWindow(Inventory CurrentInventory)
        {
            InitializeComponent();
            _Inventory = CurrentInventory;
            lbl_item1.Content = _Inventory.findItemByIndex(0).getItemName();
            lbl_item2.Content = _Inventory.findItemByIndex(1).getItemName();
            lbl_item3.Content = _Inventory.findItemByIndex(2).getItemName();
            lbl_item4.Content = _Inventory.findItemByIndex(3).getItemName();
            lbl_item5.Content = _Inventory.findItemByIndex(4).getItemName();
            lbl_item6.Content = _Inventory.findItemByIndex(5).getItemName();
            lbl_item7.Content = _Inventory.findItemByIndex(6).getItemName();
            lbl_item8.Content = _Inventory.findItemByIndex(7).getItemName();
            lbl_item9.Content = _Inventory.findItemByIndex(8).getItemName();
            lbl_item10.Content = _Inventory.findItemByIndex(9).getItemName();
            lbl_item11.Content = _Inventory.findItemByIndex(10).getItemName();
            lbl_item12.Content = _Inventory.findItemByIndex(11).getItemName();
            lbl_item13.Content = _Inventory.findItemByIndex(12).getItemName();
            lbl_item14.Content = _Inventory.findItemByIndex(13).getItemName();
            lbl_item15.Content = _Inventory.findItemByIndex(14).getItemName();
            lbl_item16.Content = _Inventory.findItemByIndex(15).getItemName();
            lbl_item17.Content = _Inventory.findItemByIndex(16).getItemName();
            lbl_item18.Content = _Inventory.findItemByIndex(17).getItemName();
            lbl_item19.Content = _Inventory.findItemByIndex(18).getItemName();
            lbl_item20.Content = _Inventory.findItemByIndex(19).getItemName();
        }


        //start methods
        public void updateVisuals()
        {
            
        }


        //end methods

        private int btn_item1_Click(object sender, RoutedEventArgs e)
        {
            return 0;
        }

        private int btn_item2_Click(object sender, RoutedEventArgs e)
        {
            return 1;
        }

        private int btn_item3_Click(object sender, RoutedEventArgs e)
        {
            return 2;
        }

        private int btn_item4_Click(object sender, RoutedEventArgs e)
        {
            return 3;
        }

        private int btn_item5_Click(object sender, RoutedEventArgs e)
        {
            return 4;
        }

        private int btn_item6_Click(object sender, RoutedEventArgs e)
        {
            return 5;
        }

        private int btn_item7_Click(object sender, RoutedEventArgs e)
        {
            return 6;
        }

        private int btn_item8_Click(object sender, RoutedEventArgs e)
        {
            return 7;
        }

        private int btn_item9_Click(object sender, RoutedEventArgs e)
        {
            return 8;
        }

        private int btn_item10_Click(object sender, RoutedEventArgs e)
        {
            return 9;
        }

        private int btn_item11_Click(object sender, RoutedEventArgs e)
        {
            return 10;
        }

        private int btn_item12_Click(object sender, RoutedEventArgs e)
        {
            return 11;
        }

        private int btn_item13_Click(object sender, RoutedEventArgs e)
        {
            return 12;
        }

        private int btn_item14_Click(object sender, RoutedEventArgs e)
        {
            return 13;
        }

        private int btn_item15_Click(object sender, RoutedEventArgs e)
        {
            return 14;
        }

        private int btn_item16_Click(object sender, RoutedEventArgs e)
        {
            return 15;
        }

        private int btn_item17_Click(object sender, RoutedEventArgs e)
        {
            return 16;
        }

        private int btn_item18_Click(object sender, RoutedEventArgs e)
        {
            return 17;
        }

        private int btn_item19_Click(object sender, RoutedEventArgs e)
        {
            return 18;
        }

        private int btn_item20_Click(object sender, RoutedEventArgs e)
        {
            return 19;
        }
    }
}
