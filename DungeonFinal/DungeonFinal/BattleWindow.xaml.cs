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
        Hero[] _theHeroes;
 
        
        //test values for health bars
        int curHealth = 100;
        int monsterHealth = 100;


        public BattleWindow()
        {
            InitializeComponent();
        }

        public BattleWindow(Monster mon, Party heros)
        {
            InitializeComponent();
            _theParty = heros;
            _theHeroes = _theParty.getHeros();
            _monster = mon;

            //ProgressBar [] prgBar_array = new ProgressBar 

            prgBar_Hero1.Value = _theHeroes[0].getModHealth();
            prgBar_Hero2.Value = _theHeroes[1].getModHealth();
            prgBar_Hero3.Value = _theHeroes[2].getModHealth();
            prgBar_Hero4.Value = _theHeroes[3].getModHealth();
            prgBar_Monster.Value = _monster.getModHealth();



            tb_monster.Text = _monster.getName();
            tb_hero1.Text = _theHeroes[0].getName();
            tb_hero2.Text = _theHeroes[1].getName();
            tb_hero3.Text = _theHeroes[2].getName();
            tb_hero4.Text = _theHeroes[3].getName();

        }
        
        //==========================================================================================================//
        //Start Methods
        //==========================================================================================================//
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
        }

        private void specialMove(Hero hero, int whichHero)
        {
            hero.PerformSpecialAttack(_theParty, whichHero);
            //updatevisuals
        }

        private void monsterAttack(Hero hero, Monster mon) //Monster attacks!
        {
            int monsterDamage = 15; //get damage from hero class


            hero.setModHealth(hero.getModHealth() - monsterDamage);


            prgBar_Hero1.Value = hero.getModHealth();
        }

        private void defend(Hero hero)
        {
            hero.setIsDefending(true);
        }

        private void incrementEffects()//This method will process all effects and time based moves
        {
            foreach(Hero h in _theHeroes)
            {
                h.setIsDefending(false);
            }
        }


        //End Methods

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private void btn_Ready_Click(object sender, RoutedEventArgs e) 
        {
            if (rBtn_Hero1Attack.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[0].getName() + " used basic attack");
                normalAttack(_theHeroes[0], _monster);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero1Defend.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[0].getName() + " used defend and is taking reduced damage this turn.");
                defend(_theHeroes[0]);
                checkForDefeatedMonster();
                
            }
            else if (rBtn_Hero1Special.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[0].getName() + " used special attack");
                specialMove(_theHeroes[0], 0);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero1Item.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[0].getName() + " used item");
                checkForDefeatedMonster();
            }
            //----------------------------------------//

            if (rBtn_Hero2Attack.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[1].getName() + " used basic attack");
                normalAttack(_theHeroes[1], _monster);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero2Defend.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[1].getName() + " used defend");
                defend(_theHeroes[1]);
                checkForDefeatedMonster();

            }
            else if (rBtn_Hero2Special.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[1].getName() + " used special attack");
                specialMove(_theHeroes[1], 1);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero2Item.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[1].getName() + " used item");
                checkForDefeatedMonster();
            }
            //----------------------------------------//

            if (rBtn_Hero3Attack.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[2].getName() + " used basic attack");
                normalAttack(_theHeroes[2], _monster);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero3Defend.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[2].getName() + " used defend");
                defend(_theHeroes[2]);
                checkForDefeatedMonster();

            }
            else if (rBtn_Hero3Special.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[2].getName() + " used special attack");
                specialMove(_theHeroes[2], 2);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero3Item.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[2].getName() + " used item");
                checkForDefeatedMonster();
            }
            //----------------------------------------//

            if (rBtn_Hero4Attack.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[3].getName() + " used basic attack");
                normalAttack(_theHeroes[3], _monster);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero4Defend.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[3].getName() + " used defend");
                defend(_theHeroes[3]);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero4Special.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[3].getName() + " used special attack");
                specialMove(_theHeroes[3], 3);
                checkForDefeatedMonster();
            }
            else if (rBtn_Hero4Item.IsChecked == true && _monster.getModHealth() > 0)
            {
                MessageBox.Show(_theHeroes[3].getName() + " used item");
                checkForDefeatedMonster();
            }
            //--------------Hero's have had their say... IT'S MONSTA TIME.---------------//

            if (_monster.getModHealth() > 0)
            {
                MessageBox.Show("Monster Attacked!");
                monsterAttack(_theHeroes[0], _monster);
                incrementEffects();
                checkForDefeatedMonster();
            }
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
