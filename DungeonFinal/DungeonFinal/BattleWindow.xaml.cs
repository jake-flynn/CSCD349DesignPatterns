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
 

            prgBar_Hero1.Value = _theHeroes[0].getModHealth();
            prgBar_Hero2.Value = _theHeroes[1].getModHealth();
            prgBar_Hero3.Value = _theHeroes[2].getModHealth();
            prgBar_Hero4.Value = _theHeroes[3].getModHealth();


            prgBar_Monster.Value = _monster.getCurHealth();
            lbl_monsterHealthNumbers.Content = "" + _monster.getCurHealth() + "/" + _monster.getBaseHealth();
            lbl_heroHealthNumbers1.Content = "" + _theHeroes[0].getModHealth() + "/" + _theHeroes[0].getBaseHealth();
            lbl_heroHealthNumbers1.Content = "" + _theHeroes[1].getModHealth() + "/" + _theHeroes[1].getBaseHealth();
            lbl_heroHealthNumbers1.Content = "" + _theHeroes[2].getModHealth() + "/" + _theHeroes[2].getBaseHealth();
            lbl_heroHealthNumbers1.Content = "" + _theHeroes[3].getModHealth() + "/" + _theHeroes[3].getBaseHealth();

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
        //Start Methods
        //==========================================================================================================//
        
        
        public void checkForDefeatedUnit() //Checks to see if a hero or monster has been slain
        {
            if (_monster.getCurHealth() <= 0)
            {
                MessageBox.Show(_monster.getName() + " was slain!!!");
                this.Close();
            }
            
            foreach (Hero h in _theHeroes)
            {
                if (h.getModHealth() <= 0 && h.getIsDefeated() != true)
                {
                    h.setIsDefeated(true);
                    MessageBox.Show(h.getName() + " gasps a final ragged breath, then falls.");
                    //disable the hero who was killed. Ask jake how to do this at a gui level.
                }
            }
        }

        public void updateVisuals(Hero hero, Monster mon)
        {
            lbl_monsterHealthNumbers.Content = "" + _monster.getCurHealth() + "/" + _monster.getBaseHealth();
            prgBar_Monster.Value = ((double)_monster.getCurHealth()) / ((double)_monster.getBaseHealth()) * 100;
            prgBar_Hero1.Value = _theHeroes[0].getModHealth();
            prgBar_Hero2.Value = _theHeroes[1].getModHealth();
            prgBar_Hero3.Value = _theHeroes[2].getModHealth();
            prgBar_Hero4.Value = _theHeroes[3].getModHealth();
        }

        private void normalAttack(Hero hero, Monster mon) //Hero attacks!
        {
            int heroDamage;
            if(hero.getIsPhysical())
            {
                heroDamage = hero.BasicAttack() - mon.getModDefense();
            }
            else
            {
                heroDamage = hero.BasicAttack() - mon.getModResistance();
            }
            if (heroDamage < 0)
                heroDamage = 0;

            mon.setCurHealth(mon.getCurHealth() - heroDamage);
            updateVisuals(hero, mon);

            checkForDefeatedUnit();
        }

        private void specialMove(Hero hero, int whichHero)
        {
            hero.PerformSpecialAttack(_theParty, whichHero, _monster);
            updateVisuals(hero, _monster);
        }

        private void monsterAttack(Hero hero, Monster mon) //Monster attacks!
        {
            int monsterDamage; //This integer and the following block calculates the damage the monster will do,
            if(hero.getIsDefending()){//based on the attack of the monster - the defense of the hero. A greater value is used for defending heroes
                monsterDamage = mon.BasicAttack() - hero.getDefendingDefense();
            }
            else{
                monsterDamage = mon.BasicAttack() - hero.getModDefense();
            }
            if (monsterDamage < 0)
                monsterDamage = 0;

            hero.setModHealth(hero.getModHealth() - monsterDamage); //actual damgae is applied
            updateVisuals(hero, mon);//health bar updated
            checkForDefeatedUnit();
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
            if (_monster.getCurHealth() > 0 && _theHeroes[0].getModHealth() > 0)
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
            if (_monster.getCurHealth() > 0 && _theHeroes[1].getModHealth() > 0)
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
            if (_monster.getCurHealth() > 0 && _theHeroes[2].getModHealth() > 0)
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
            if (_monster.getCurHealth() > 0 && _theHeroes[3].getModHealth() > 0)
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

            if (_monster.getCurHealth() > 0)
            {
                MessageBox.Show("Monster Attacked!");
                monsterAttack(_theHeroes[0], _monster);
                incrementEffects();
                checkForDefeatedUnit();
            }
        }


        //End Event Handlers
    }
}
