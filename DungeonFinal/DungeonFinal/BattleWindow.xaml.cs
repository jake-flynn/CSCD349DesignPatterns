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
    /// Interaction logic for BattleWindow.xaml
    /// </summary>
    /// 
    public partial class BattleWindow : Window
    {


        Monster monster;
        Party theParty;
        Hero[] theHeros;
 
        
        //test values for health bars
        int curHealth = 100;


        public BattleWindow()
        {
            InitializeComponent();// do things after this!!!


            //the following is for debug only, it sets heros and monsters health to 100 for testing display
            prgBar_Hero1.Value = 100;
            prgBar_Hero2.Value = 100;
            prgBar_Hero3.Value = 100;
            prgBar_Hero4.Value = 100;
            prgBar_Monster.Value = 100;
            monster = new Shade();

            
        }

        public BattleWindow(Monster mon, Party heros)
        {
            InitializeComponent();
            theParty = heros;
            theHeros = theParty.getHeros();
            monster = mon;


            prgBar_Hero1.Value = theHeros[0].getModHealth();
            prgBar_Hero2.Value = theHeros[1].getModHealth();
            prgBar_Hero3.Value = theHeros[2].getModHealth();
            prgBar_Hero4.Value = theHeros[3].getModHealth();
            prgBar_Monster.Value = monster.getModHealth();

            tb_monster.Text = monster.getName();
            tb_hero1.Text = theHeros[0].getName();
            tb_hero2.Text = theHeros[1].getName();
            tb_hero3.Text = theHeros[2].getName();
            tb_hero4.Text = theHeros[3].getName();

        }

        //Start Methods
        public void checkForDefeatedMonster()
        {
            if(monster.getModHealth() <= 0)
            {
                MessageBox.Show(monster.getName() + " was defeated!!!");
                this.Close();
            }
        }

        //End Methods

        //Start Event Handlers
        private void btn_Ready_Click(object sender, RoutedEventArgs e)
        {
            if (rBtn_Hero1Attack.IsChecked == true)
            {
                MessageBox.Show(theHeros[0].getName() + " used basic attack");
            }
            else if (rBtn_Hero1Defend.IsChecked == true)
            {
                MessageBox.Show(theHeros[0].getName() + " used defend");
                
            }
            else if (rBtn_Hero1Special.IsChecked == true)
            {
                MessageBox.Show(theHeros[0].getName() + " used special attack");
            }
            else if (rBtn_Hero1Item.IsChecked == true)
            {
                MessageBox.Show(theHeros[0].getName() + " used item");
            }


            if (rBtn_Hero2Attack.IsChecked == true)
            {
                MessageBox.Show(theHeros[1].getName() + " used basic attack");
            }
            else if (rBtn_Hero2Defend.IsChecked == true)
            {
                MessageBox.Show(theHeros[1].getName() + " used defend");

            }
            else if (rBtn_Hero2Special.IsChecked == true)
            {
                MessageBox.Show(theHeros[1].getName() + " used special attack");
            }
            else if (rBtn_Hero2Item.IsChecked == true)
            {
                MessageBox.Show(theHeros[1].getName() + " used item");
            }

            if (rBtn_Hero3Attack.IsChecked == true)
            {
                MessageBox.Show(theHeros[2].getName() + " used basic attack");
            }
            else if (rBtn_Hero3Defend.IsChecked == true)
            {
                MessageBox.Show(theHeros[2].getName() + " used defend");

            }
            else if (rBtn_Hero3Special.IsChecked == true)
            {
                MessageBox.Show(theHeros[2].getName() + " used special attack");
            }
            else if (rBtn_Hero3Item.IsChecked == true)
            {
                MessageBox.Show(theHeros[2].getName() + " used item");
            }

            if (rBtn_Hero4Attack.IsChecked == true)
            {
                MessageBox.Show(theHeros[3].getName() + " used basic attack");
            }
            else if (rBtn_Hero4Defend.IsChecked == true)
            {
                MessageBox.Show(theHeros[3].getName() + " used defend");

            }
            else if (rBtn_Hero4Special.IsChecked == true)
            {
                MessageBox.Show(theHeros[3].getName() + " used special attack");
            }
            else if (rBtn_Hero4Item.IsChecked == true)
            {
                MessageBox.Show(theHeros[3].getName() + " used item");
            }


            checkForDefeatedMonster();
        }

        private void btn_testHealth_Click(object sender, RoutedEventArgs e)
        {
           
            if (curHealth > 0)
            {
                curHealth -= 10;
                monster.setModHealth(monster.getModHealth() - 10);
                prgBar_Hero1.Value = curHealth;
                prgBar_Hero2.Value = curHealth;
                prgBar_Hero3.Value = curHealth;
                prgBar_Hero4.Value = curHealth;
                prgBar_Monster.Value = curHealth;
            }
            checkForDefeatedMonster();
        }

        //End Event Handlers
    }
}
