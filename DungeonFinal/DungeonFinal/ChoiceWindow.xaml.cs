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
    /// Interaction logic for ChoiceWindow.xaml
    /// </summary>
    public partial class ChoiceWindow : Window
    {
        int _choice = 5;

        public ChoiceWindow(Monster[] TheSwarm)// make monster choices visible
        {
            InitializeComponent();

            btn_SelectHero1.IsEnabled = false;
            btn_SelectHero2.IsEnabled = false;
            btn_SelectHero3.IsEnabled = false;
            btn_SelectHero4.IsEnabled = false;
        }

        public ChoiceWindow(Hero[] TheHeroes)// make hero choices visible
        {
            InitializeComponent();

            btn_SelectMonster1.IsEnabled = false;
            btn_SelectMonster2.IsEnabled = false;
            btn_SelectMonster3.IsEnabled = false;
            btn_SelectMonster4.IsEnabled = false;
            btn_SelectMonster5.IsEnabled = false;
            btn_SelectMonster6.IsEnabled = false;
        }



        private void btn_SelectHero1_Click(object sender, RoutedEventArgs e)
        {
            _choice = 0;
            this.Close();
        }

        private void btn_SelectHero2_Click(object sender, RoutedEventArgs e)
        {
            _choice = 1;
            this.Close();
        }

        private void btn_SelectHero3_Click(object sender, RoutedEventArgs e)
        {
            _choice = 2;
            this.Close();
        }

        private void btn_SelectHero4_Click(object sender, RoutedEventArgs e)
        {
            _choice = 3;
            this.Close();
        }

        private void btn_SelectMonster1_Click(object sender, RoutedEventArgs e)
        {
            _choice = 0;
            this.Close();
        }

        private void btn_SelectMonster2_Click(object sender, RoutedEventArgs e)
        {
            _choice = 1;
            this.Close();
        }

        private void btn_SelectMonster3_Click(object sender, RoutedEventArgs e)
        {
            _choice = 2;
            this.Close();
        }

        private void btn_SelectMonster4_Click(object sender, RoutedEventArgs e)
        {
            _choice = 3;
            this.Close();
        }

        private void btn_SelectMonster5_Click(object sender, RoutedEventArgs e)
        {
            _choice = 4;
            this.Close();
        }

        private void btn_SelectMonster6_Click(object sender, RoutedEventArgs e)
        {
            _choice = 5;
            this.Close();
        }

        public int getChoiceFromSelect()
        {
            return _choice;
        }
    }
}
