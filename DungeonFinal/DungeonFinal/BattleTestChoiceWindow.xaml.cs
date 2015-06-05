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
    /// Interaction logic for BattleTestChoiceWindow.xaml
    /// </summary>
    public partial class BattleTestChoiceWindow : Window
    {
        Party _TheParty;

        public BattleTestChoiceWindow()
        {
            InitializeComponent();
        }
        public BattleTestChoiceWindow(Party passedParty)
        {
            InitializeComponent();

            _TheParty = passedParty;
        }

        private void btn_MonsterChoice1_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Shade(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice2_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Skeleton(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice3_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Insect(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice4_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new VampireBat(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice5_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Slime(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice6_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Imp(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice7_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new StuBeast(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice8_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Werewolf(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice9_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Harpy(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice10_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Hellhound(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice11_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Cockatrice(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice12_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Sphynx(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice13_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Centaur(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice14_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new DemonWarrior(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice15_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Cyclops(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice16_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Dragon(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice17_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Minotaur(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice18_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Chimera(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice19_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow(new Hydra(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice20_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow_Swarm(new Insect(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice21_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow_Swarm(new VampireBat(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice22_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow_Swarm(new Slime(), _TheParty);
            bw.ShowDialog();
        }

        private void btn_MonsterChoice23_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BattleWindow_Swarm(new Hellhound(), _TheParty);
            bw.ShowDialog();
        }

        //---Swam battles---//
    }
}
