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


        Monster _monster;
        Party _theParty;
        Hero[] _theHeros;
 
        
        //test values for health bars
        int curHealth = 100;
        int monsterHealth = 100;


        public BattleWindow()
        {
            InitializeComponent();// do things after this!!!


            //the following is for debug only, it sets heros and monsters health to 100 for testing display
            prgBar_Hero1.Value = 100;
            prgBar_Hero2.Value = 100;
            prgBar_Hero3.Value = 100;
            prgBar_Hero4.Value = 100;
            prgBar_Monster.Value = 100;

            _monster = new Shade();


            
        }

        public BattleWindow(Monster mon, Party heros)
        {
            InitializeComponent();
            _theParty = heros;
            _theHeros = _theParty.getHeros();
            _monster = mon;

            //ProgressBar [] prgBar_array = new ProgressBar 

            prgBar_Hero1.Value = _theHeros[0].getModHealth();
            prgBar_Hero2.Value = _theHeros[1].getModHealth();
            prgBar_Hero3.Value = _theHeros[2].getModHealth();
            prgBar_Hero4.Value = _theHeros[3].getModHealth();
            prgBar_Monster.Value = _monster.getModHealth();



            tb_monster.Text = _monster.getName();
            tb_hero1.Text = _theHeros[0].getName();
            tb_hero2.Text = _theHeros[1].getName();
            tb_hero3.Text = _theHeros[2].getName();
            tb_hero4.Text = _theHeros[3].getName();

        }

        //Start Methods
        public void checkForDefeatedMonster()
        {

            if(_monster.getModHealth() <= 0)
            {
                MessageBox.Show(_monster.getName() + " was defeated!!!");

                this.Close();
            }
        }

        public void checkForDefeatedHero(Hero hero)
        {

            if (hero.getModHealth() <= 0)
            {
                MessageBox.Show(hero.getName() + " was killed!!!");
                this.Close();
            }
        }

        private void normalAttack(Hero hero, Monster mon) //Hero attacks!
        {
            int heroDamage = 15; //get damage from hero class

            mon.setModHealth(mon.getModHealth() - heroDamage);

            prgBar_Monster.Value = mon.getModHealth();
            checkForDefeatedMonster();
        }


        private void monsterAttack(Hero hero, Monster mon) //Monster
        {
            int monsterDamage = 15; //get damage from hero class


            hero.setModHealth(hero.getModHealth() - monsterDamage);


            prgBar_Hero1.Value = mon.getModHealth();
            checkForDefeatedMonster();
        }

        private void defend(Hero hero)
        {
            hero.setIsDefending(true);
        }

        private void incrementEffects()//This method will process all effects and time based moves
        {
            for(Hero h: _theHeros)
            {
                h.setIsDefending(false);
            }
        }


        //End Methods


        //Start Event Handlers
        private void btn_Ready_Click(object sender, RoutedEventArgs e)
        {
            if (rBtn_Hero1Attack.IsChecked == true)
            {
                MessageBox.Show(_theHeros[0].getName() + " used basic attack");
                normalAttack(_theHeros[0], _monster);
            }
            else if (rBtn_Hero1Defend.IsChecked == true)
            {
                MessageBox.Show(_theHeros[0].getName() + " used defend");
                
            }
            else if (rBtn_Hero1Special.IsChecked == true)
            {
                MessageBox.Show(_theHeros[0].getName() + " used special attack");
            }
            else if (rBtn_Hero1Item.IsChecked == true)
            {
                MessageBox.Show(_theHeros[0].getName() + " used item");
            }


            if (rBtn_Hero2Attack.IsChecked == true)
            {
                MessageBox.Show(_theHeros[1].getName() + " used basic attack");
                normalAttack(_theHeros[1], _monster);
            }
            else if (rBtn_Hero2Defend.IsChecked == true)
            {
                MessageBox.Show(_theHeros[1].getName() + " used defend");

            }
            else if (rBtn_Hero2Special.IsChecked == true)
            {
                MessageBox.Show(_theHeros[1].getName() + " used special attack");
            }
            else if (rBtn_Hero2Item.IsChecked == true)
            {
                MessageBox.Show(_theHeros[1].getName() + " used item");
            }

            if (rBtn_Hero3Attack.IsChecked == true)
            {
                MessageBox.Show(_theHeros[2].getName() + " used basic attack");
                normalAttack(_theHeros[2], _monster);
            }
            else if (rBtn_Hero3Defend.IsChecked == true)
            {
                MessageBox.Show(_theHeros[2].getName() + " used defend");

            }
            else if (rBtn_Hero3Special.IsChecked == true)
            {
                MessageBox.Show(_theHeros[2].getName() + " used special attack");
            }
            else if (rBtn_Hero3Item.IsChecked == true)
            {
                MessageBox.Show(_theHeros[2].getName() + " used item");
            }

            if (rBtn_Hero4Attack.IsChecked == true)
            {
                MessageBox.Show(_theHeros[3].getName() + " used basic attack");
                normalAttack(_theHeros[3], _monster);
            }
            else if (rBtn_Hero4Defend.IsChecked == true)
            {
                MessageBox.Show(_theHeros[3].getName() + " used defend");

            }
            else if (rBtn_Hero4Special.IsChecked == true)
            {
                MessageBox.Show(_theHeros[3].getName() + " used special attack");
            }
            else if (rBtn_Hero4Item.IsChecked == true)
            {
                MessageBox.Show(_theHeros[3].getName() + " used item");
            }
            //-----------------------------Hero's have had their say... IT'S MONSTA TIME.----------------------//

<<<<<<< HEAD
            monsterAttack(_theHeros[0], _monster);

=======
            incrementEffects();
>>>>>>> 0ea3c3e52207855ba00ebf96861584db35d59f8a
            checkForDefeatedMonster();
        }

        private void btn_testHealth_Click(object sender, RoutedEventArgs e)
        {
           
            if (curHealth > 0)
            {
                curHealth -= 10;

                _monster.setModHealth(_monster.getModHealth() - 10);
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
