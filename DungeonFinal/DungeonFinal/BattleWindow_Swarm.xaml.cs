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
    /// Interaction logic for BattleWindow_Swarm.xaml
    /// </summary>
    public partial class BattleWindow_Swarm : Window
    {
        public BattleWindow_Swarm()
        {
            InitializeComponent();
            _theParty = heros;
            _theHeroes = _theParty.getHeros();
            _monster = mon;


            prgBar_Hero1.Value = _theHeroes[0].getModHealth();
            prgBar_Hero2.Value = _theHeroes[1].getModHealth();
            prgBar_Hero3.Value = _theHeroes[2].getModHealth();
            prgBar_Hero4.Value = _theHeroes[3].getModHealth();
            prgBar_Monster.Value = _monster.getModHealth();

            prgBar_Hero1_Mana.Value = 100;
            prgBar_Hero2_Mana.Value = 100;
            prgBar_Hero3_Mana.Value = 100;
            prgBar_Hero4_Mana.Value = 100;

            tb_monster.Text = _monster.getName();
            tb_hero1.Text = _theHeroes[0].getName();
            tb_hero2.Text = _theHeroes[1].getName();
            tb_hero3.Text = _theHeroes[2].getName();
            tb_hero4.Text = _theHeroes[3].getName();
        }

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private void btn_Ready_Click(object sender, RoutedEventArgs e)
        {
            if (_monster.getModHealth() > 0 && _theHeroes[0].getModHealth() > 0)
            {
                if (rBtn_Hero1Attack.IsChecked == true) //I don't like how I am doing this. Or maybe I need more things interacting with character death...
                {
                    MessageBox.Show(_theHeroes[0].getName() + " used basic attack");
                    normalAttack(_theHeroes[0], _monster);
                }
                else if (rBtn_Hero1Defend.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[0].getName() + " used defend and is taking reduced damage this turn.");
                    defend(_theHeroes[0]);
                }
                else if (rBtn_Hero1Special.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[0].getName() + " used special attack");
                    specialMove(_theHeroes[0], 0);
                }
                else if (rBtn_Hero1Item.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[0].getName() + " used item");
                }
            }

            //----------------------------------------//
            if (_monster.getModHealth() > 0 && _theHeroes[1].getModHealth() > 0)
            {
                if (rBtn_Hero2Attack.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[1].getName() + " used basic attack");
                    normalAttack(_theHeroes[1], _monster);
                }
                else if (rBtn_Hero2Defend.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[1].getName() + " used defend");
                    defend(_theHeroes[1]);
                }
                else if (rBtn_Hero2Special.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[1].getName() + " used special attack");
                    specialMove(_theHeroes[1], 1);
                }
                else if (rBtn_Hero2Item.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[1].getName() + " used item");
                }
            }

            //----------------------------------------//
            if (_monster.getModHealth() > 0 && _theHeroes[2].getModHealth() > 0)
            {
                if (rBtn_Hero3Attack.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[2].getName() + " used basic attack");
                    normalAttack(_theHeroes[2], _monster);
                }
                else if (rBtn_Hero3Defend.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[2].getName() + " used defend");
                    defend(_theHeroes[2]);

                }
                else if (rBtn_Hero3Special.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[2].getName() + " used special attack");
                    specialMove(_theHeroes[2], 2);
                }
                else if (rBtn_Hero3Item.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[2].getName() + " used item");
                }
            }
            //----------------------------------------//
            if (_monster.getModHealth() > 0 && _theHeroes[3].getModHealth() > 0)
            {
                if (rBtn_Hero4Attack.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[3].getName() + " used basic attack");
                    normalAttack(_theHeroes[3], _monster);
                }
                else if (rBtn_Hero4Defend.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[3].getName() + " used defend");
                    defend(_theHeroes[3]);
                }
                else if (rBtn_Hero4Special.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[3].getName() + " used special attack");
                    specialMove(_theHeroes[3], 3);
                }
                else if (rBtn_Hero4Item.IsChecked == true)
                {
                    MessageBox.Show(_theHeroes[3].getName() + " used item");
                }
            }
            //--------------Hero's have had their say... IT'S MONSTA TIME.---------------//

            if (_monster.getModHealth() > 0)
            {
                MessageBox.Show("Monster Attacked!");
                monsterAttack(_theHeroes[0], _monster);
                incrementEffects();
                checkForDefeatedUnit();
            }
        }

    }
}
