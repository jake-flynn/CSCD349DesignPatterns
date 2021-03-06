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
    /// Interaction logic for BattleWindow_Swarm.xaml
    /// </summary>
    public partial class BattleWindow_Swarm : Window
    {

        Monster _PrototypeMonster;
        Monster[] _TheSwarm;
        Party _theParty;
        Hero[] _theHeroes;
        Boolean _IsSwarmDefeated;
        Paragraph _Paragraph;
        Inventory _BattleInventory;
        Random _randomNumber;
        //In the swarm

        public BattleWindow_Swarm()
        {
            InitializeComponent();
        }

        public BattleWindow_Swarm(Monster mon, Party heros)
        {
            InitializeComponent();
            _randomNumber = RandomGenerator.Instance;
            _theParty = heros;
            _theHeroes = _theParty.getAllHeroes();
            _TheSwarm = new Monster[6];
            _IsSwarmDefeated = false;

            _BattleInventory = _theParty.getInventory();

            _PrototypeMonster = mon;


            for (int m = 0; m < 6; m++)
            {
                _TheSwarm[m] = (Monster)_PrototypeMonster.Clone(m + 1);   
            }                                                      

            

            //tb_monster.Text = _monster.getName();
            tb_hero1.Text = _theHeroes[0].getName();
            tb_hero2.Text = _theHeroes[1].getName();
            tb_hero3.Text = _theHeroes[2].getName();
            tb_hero4.Text = _theHeroes[3].getName();

            rect_hero1.Fill = _theHeroes[0].getImageBrush();
            rect_hero2.Fill = _theHeroes[1].getImageBrush();
            rect_hero3.Fill = _theHeroes[2].getImageBrush();
            rect_hero4.Fill = _theHeroes[3].getImageBrush();
            
            rect_monster1.Fill = _TheSwarm[0].getImageBrush();
            rect_monster2.Fill = _TheSwarm[1].getImageBrush();
            rect_monster3.Fill = _TheSwarm[2].getImageBrush();
            rect_monster4.Fill = _TheSwarm[3].getImageBrush();
            rect_monster5.Fill = _TheSwarm[4].getImageBrush();
            rect_monster6.Fill = _TheSwarm[5].getImageBrush();

            _Paragraph = new Paragraph();
            rtb_testBox.Document = new FlowDocument(_Paragraph);


            _Paragraph.Inlines.Add(new Bold(new Run("Battle Log:"))
            {
                Foreground = Brushes.Black
            });

            _Paragraph.Inlines.Add(new LineBreak());
            this.DataContext = this;

            updateVisuals();
        }

        //==========================================================================================================//
        //Start Methods
        //==========================================================================================================//

        public void updateVisuals()
        {
            prgBar_Hero1.Value = ((double)_theHeroes[0].getCurHealth()) / ((double)_theHeroes[0].getMaxHealth()) * 100;
            prgBar_Hero2.Value = ((double)_theHeroes[1].getCurHealth()) / ((double)_theHeroes[1].getMaxHealth()) * 100;
            prgBar_Hero3.Value = ((double)_theHeroes[2].getCurHealth()) / ((double)_theHeroes[2].getMaxHealth()) * 100;
            prgBar_Hero4.Value = ((double)_theHeroes[3].getCurHealth()) / ((double)_theHeroes[3].getMaxHealth()) * 100;
            
            prgBar_monster1.Value = ((double)_TheSwarm[0].getCurHealth()) / ((double)_TheSwarm[0].getBaseHealth()) * 100;
            prgBar_monster2.Value = ((double)_TheSwarm[1].getCurHealth()) / ((double)_TheSwarm[1].getBaseHealth()) * 100;
            prgBar_monster3.Value = ((double)_TheSwarm[2].getCurHealth()) / ((double)_TheSwarm[2].getBaseHealth()) * 100;
            prgBar_monster4.Value = ((double)_TheSwarm[3].getCurHealth()) / ((double)_TheSwarm[3].getBaseHealth()) * 100;
            prgBar_monster5.Value = ((double)_TheSwarm[4].getCurHealth()) / ((double)_TheSwarm[4].getBaseHealth()) * 100;
            prgBar_monster6.Value = ((double)_TheSwarm[5].getCurHealth()) / ((double)_TheSwarm[5].getBaseHealth()) * 100;

            lbl_monsterHealthNumbers1.Content = "" + _TheSwarm[0].getCurHealth() + "/" + _TheSwarm[0].getBaseHealth();
            lbl_monsterHealthNumbers2.Content = "" + _TheSwarm[1].getCurHealth() + "/" + _TheSwarm[1].getBaseHealth();
            lbl_monsterHealthNumbers3.Content = "" + _TheSwarm[2].getCurHealth() + "/" + _TheSwarm[2].getBaseHealth();
            lbl_monsterHealthNumbers4.Content = "" + _TheSwarm[3].getCurHealth() + "/" + _TheSwarm[3].getBaseHealth();
            lbl_monsterHealthNumbers5.Content = "" + _TheSwarm[4].getCurHealth() + "/" + _TheSwarm[4].getBaseHealth();
            lbl_monsterHealthNumbers6.Content = "" + _TheSwarm[5].getCurHealth() + "/" + _TheSwarm[5].getBaseHealth();
            
            lbl_heroHealthNumbers1.Content = "" + _theHeroes[0].getCurHealth() + "/" + _theHeroes[0].getMaxHealth();
            lbl_heroHealthNumbers2.Content = "" + _theHeroes[1].getCurHealth() + "/" + _theHeroes[1].getMaxHealth();
            lbl_heroHealthNumbers3.Content = "" + _theHeroes[2].getCurHealth() + "/" + _theHeroes[2].getMaxHealth();
            lbl_heroHealthNumbers4.Content = "" + _theHeroes[3].getCurHealth() + "/" + _theHeroes[3].getMaxHealth();

            lbl_heroManaNumbers1.Content = "" + _theHeroes[0].getCurMana() + "/" + _theHeroes[0].getMaxMana();
            lbl_heroManaNumbers2.Content = "" + _theHeroes[1].getCurMana() + "/" + _theHeroes[1].getMaxMana();
            lbl_heroManaNumbers3.Content = "" + _theHeroes[2].getCurMana() + "/" + _theHeroes[2].getMaxMana();
            lbl_heroManaNumbers4.Content = "" + _theHeroes[3].getCurMana() + "/" + _theHeroes[3].getMaxMana();

            prgBar_Hero1_Mana.Value = ((double)_theHeroes[0].getCurMana()) / ((double)_theHeroes[0].getMaxMana()) * 100;
            prgBar_Hero2_Mana.Value = ((double)_theHeroes[1].getCurMana()) / ((double)_theHeroes[1].getMaxMana()) * 100;
            prgBar_Hero3_Mana.Value = ((double)_theHeroes[2].getCurMana()) / ((double)_theHeroes[2].getMaxMana()) * 100;
            prgBar_Hero4_Mana.Value = ((double)_theHeroes[3].getCurMana()) / ((double)_theHeroes[3].getMaxMana()) * 100;

            
        }

        public void checkForDefeatedUnit() //Checks to see if a hero or monster has been slain
        {
            if (_TheSwarm[0].getIsDefeated() && _TheSwarm[1].getIsDefeated() && _TheSwarm[2].getIsDefeated() && _TheSwarm[3].getIsDefeated() && _TheSwarm[4].getIsDefeated() && _TheSwarm[5].getIsDefeated())
            {
                MessageBox.Show("The " + _PrototypeMonster.getName() + " swarm was defeated!!!");
                _IsSwarmDefeated = true;
                this.Close();
            }
            foreach(Monster m in _TheSwarm)
            {
                if (m.getCurHealth() <= 0 && ! m.getIsDefeated())
                {
                    _Paragraph.Inlines.Add(new Bold(new Run(m.getName() + " was slain!!!"))
                    {
                        Foreground = Brushes.Red
                    });
                    _Paragraph.Inlines.Add(new LineBreak());

                    m.setIsDefeated(true);

                    if (_TheSwarm[0].getIsDefeated())
                    {
                        rect_monster1.Opacity = 0.4;
                    }
                    if (_TheSwarm[1].getIsDefeated())
                    {
                        rect_monster2.Opacity = 0.4;
                    }
                    if (_TheSwarm[2].getIsDefeated())
                    {
                        rect_monster3.Opacity = 0.4;
                    }
                    if (_TheSwarm[3].getIsDefeated())
                    {
                        rect_monster4.Opacity = 0.4;
                    }
                    if (_TheSwarm[4].getIsDefeated())
                    {
                        rect_monster5.Opacity = 0.4;
                    }
                    if (_TheSwarm[5].getIsDefeated())
                    {
                        rect_monster6.Opacity = 0.4;
                    }
                }
            }
            
            foreach (Hero h in _theHeroes)
            {
                if (h.getCurHealth() <= 0 && h.getIsDefeated() != true)
                {
                    h.setIsDefeated(true);
                    MessageBox.Show(h.getName() + " gasps a final ragged breath, then falls.");
                    //disable the hero who was killed. Ask jake how to do this at a gui level.

                    if (_theHeroes[0].getIsDefeated())
                    {
                        rect_hero1.Opacity = 0.4;
                    }
                    if (_theHeroes[1].getIsDefeated())
                    {
                        rect_hero2.Opacity = 0.4;
                    }
                    if (_theHeroes[2].getIsDefeated())
                    {
                        rect_hero3.Opacity = 0.4;
                    }
                    if (_theHeroes[3].getIsDefeated())
                    {
                        rect_hero4.Opacity = 0.4;
                    }
                }
            }
        }

        private void normalAttack(Hero hero) //Hero attacks!
        {
            var cw = new ChoiceWindow(_TheSwarm);
            cw.ShowDialog();
            int attackTarget = cw.getChoiceFromSelect();
            Monster mon = _TheSwarm[attackTarget];

            int heroDamage;
            if (hero.getIsPhysical())
            {
                heroDamage = hero.BasicAttack() - mon.getModDefense();
            }
            else
            {
                heroDamage = hero.BasicAttack() - mon.getModResistance();
            }
            if (heroDamage < 0)
                heroDamage = 0;

            _Paragraph.Inlines.Add(new Bold(new Run(hero.getName() + " used basic attack for: " + heroDamage + " damage"))
            {
                Foreground = hero.getTextColor()
            });
            _Paragraph.Inlines.Add(new LineBreak());

            mon.setCurHealth(mon.getCurHealth() - heroDamage);
            updateVisuals();

            checkForDefeatedUnit();
        }
                
        private void specialMove(Hero hero, int whichHero)
        {
            string toReturn = hero.PerformSpecialAttack(_theParty, whichHero, _TheSwarm);

            _Paragraph.Inlines.Add(new Bold(new Run(toReturn))
            {
                Foreground = hero.getTextColor()
            });
            _Paragraph.Inlines.Add(new LineBreak());
            checkForDepletedMana();
            updateVisuals();
            checkForDefeatedUnit();
        }

        private void monsterAttack(Monster mon) //Monster attacks!
        {

            Hero hero = mon.FindTarget(_theParty);
            int monsterDamage;

            
            int randSpecial = _randomNumber.Next(10) + 1;

            if (randSpecial <= mon.getSpecialAttackFrequency())
            {
                
                _Paragraph.Inlines.Add(new Bold(new Run(mon.PerformSpecialAttack(_theParty, 0, mon)))
                {
                    Foreground = Brushes.Red
                });
                _Paragraph.Inlines.Add(new LineBreak());
            }
            else
            {
                if (mon.getIsPhysical())
                {
                    if (hero.getIsDefending())
                    {//based on the attack of the monster - the defense of the hero. A greater value is used for defending heroes
                        monsterDamage = mon.BasicAttack() - hero.getDefendingDefense();
                    }
                    else
                    {
                        monsterDamage = mon.BasicAttack() - hero.getModDefense();
                    }
                }
                else
                {
                    if (hero.getIsDefending())
                    {
                        monsterDamage = mon.BasicAttack() - hero.getDefendingResistance();
                    }
                    else
                    {
                        monsterDamage = mon.BasicAttack() - hero.getModResistance();
                    }
                }
                if (monsterDamage < 0)
                    monsterDamage = 0;

                
                hero.setCurHealth(hero.getCurHealth() - monsterDamage); //actual damage is applied

                _Paragraph.Inlines.Add(new Bold(new Run("The " + mon.getName() + " attacks " + hero.getName() + " for " + monsterDamage + " damage."))
                {
                    Foreground = Brushes.Red
                });
                _Paragraph.Inlines.Add(new LineBreak());
            }
            updateVisuals();
            checkForDefeatedUnit();
        }

        private void defend(Hero hero)
        {
            hero.setIsDefending(true);
            _Paragraph.Inlines.Add(new Bold(new Run(hero.getName() + " used defend and is taking reduced damage this turn."))
            {
                Foreground = hero.getTextColor()
            });
            _Paragraph.Inlines.Add(new LineBreak());
        }

        private void useItem(Hero hero)
        {

            var consumableWindow = new ConsumableWindow(_BattleInventory);
            consumableWindow.ShowDialog();
            int choiceFromConsumableWindow = consumableWindow.getChoiceFromSelect();
            Consumable itemToUse = _BattleInventory.findConsumableByIndex(choiceFromConsumableWindow);

            var choiceWindow = new ChoiceWindow(_theHeroes);
            choiceWindow.ShowDialog();
            int attackTarget = choiceWindow.getChoiceFromSelect();
            Hero targetHero = _theHeroes[attackTarget];

            string resultString = itemToUse.use(targetHero);

            _Paragraph.Inlines.Add(new Bold(new Run(resultString))
            {
                Foreground = _theHeroes[0].getTextColor()
            });
            _Paragraph.Inlines.Add(new LineBreak());
            _BattleInventory.removeFromConsumable(choiceFromConsumableWindow);
            checkForDepletedMana();
            updateVisuals();
        }

        private void incrementEffects()//This method will process all effects and time based moves
        {
            foreach (Hero h in _theHeroes)
            {
                h.setIsDefending(false);
            }
        }

        public void checkReady()
        {
            bool ready = false;

            if (rBtn_Hero1Attack.IsChecked == true || rBtn_Hero1Defend.IsChecked == true || rBtn_Hero1Special.IsChecked == true || rBtn_Hero1Item.IsChecked == true)
            {
                if (rBtn_Hero2Attack.IsChecked == true || rBtn_Hero2Defend.IsChecked == true || rBtn_Hero2Special.IsChecked == true || rBtn_Hero2Item.IsChecked == true)
                {
                    if (rBtn_Hero3Attack.IsChecked == true || rBtn_Hero3Defend.IsChecked == true || rBtn_Hero3Special.IsChecked == true || rBtn_Hero3Item.IsChecked == true)
                    {
                        if (rBtn_Hero4Attack.IsChecked == true || rBtn_Hero4Defend.IsChecked == true || rBtn_Hero4Special.IsChecked == true || rBtn_Hero4Item.IsChecked == true)
                        {
                            ready = true;
                        }
                    }
                }
            }

            if (ready == true)
            {
                btn_Ready.IsEnabled = true;
            }
            else
            {
                btn_Ready.IsEnabled = false;
            }
        }

        public void checkForDepletedMana()
        {
            if (_theHeroes[0].getCurMana() < 15 || !_theHeroes[0].getCanSpecialAttack())
            {
                rBtn_Hero1Special.IsEnabled = false;
                rBtn_Hero1Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero1Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (_theHeroes[1].getCurMana() < 15 || !_theHeroes[1].getCanSpecialAttack())
            {
                rBtn_Hero2Special.IsEnabled = false;
                rBtn_Hero2Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero2Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (_theHeroes[2].getCurMana() < 15 || !_theHeroes[2].getCanSpecialAttack())
            {
                rBtn_Hero3Special.IsEnabled = false;
                rBtn_Hero3Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero3Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (_theHeroes[3].getCurMana() < 15 || !_theHeroes[3].getCanSpecialAttack())
            {
                rBtn_Hero4Special.IsEnabled = false;
                rBtn_Hero4Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero4Special.IsEnabled = true;
            }
        }

        public void checkForStunned()
        {
            if (!_theHeroes[0].getCanAttack())
            {
                rBtn_Hero1Attack.IsEnabled = false;
                rBtn_Hero1Attack.IsChecked = false;
                rBtn_Hero1Special.IsEnabled = false;
                rBtn_Hero1Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero1Attack.IsEnabled = true;
                if (_theHeroes[0].getCanSpecialAttack())
                    rBtn_Hero1Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (!_theHeroes[1].getCanAttack())
            {
                rBtn_Hero2Attack.IsEnabled = false;
                rBtn_Hero2Attack.IsChecked = false;
                rBtn_Hero2Special.IsEnabled = false;
                rBtn_Hero2Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero2Attack.IsEnabled = true;
                if (_theHeroes[1].getCanSpecialAttack())
                    rBtn_Hero2Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (!_theHeroes[2].getCanAttack())
            {
                rBtn_Hero3Attack.IsEnabled = false;
                rBtn_Hero3Attack.IsChecked = false;
                rBtn_Hero3Special.IsEnabled = false;
                rBtn_Hero3Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero3Attack.IsEnabled = true;
                if (_theHeroes[2].getCanSpecialAttack())
                    rBtn_Hero3Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (!_theHeroes[3].getCanAttack())
            {
                rBtn_Hero4Attack.IsEnabled = false;
                rBtn_Hero4Attack.IsChecked = false;
                rBtn_Hero4Special.IsEnabled = false;
                rBtn_Hero4Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero4Attack.IsEnabled = true;
                if (_theHeroes[3].getCanSpecialAttack())
                    rBtn_Hero4Special.IsEnabled = true;
            }
        }

        public void checkForSilenced()
        {
            
            if (!_theHeroes[0].getCanSpecialAttack())
            {
                rBtn_Hero1Special.IsEnabled = false;
                rBtn_Hero1Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero1Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (!_theHeroes[1].getCanSpecialAttack())
            {
                rBtn_Hero2Special.IsEnabled = false;
                rBtn_Hero2Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero2Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (!_theHeroes[2].getCanSpecialAttack())
            {
                rBtn_Hero3Special.IsEnabled = false;
                rBtn_Hero3Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero3Special.IsEnabled = true;
            }
            //----------------------------------------//
            if (!_theHeroes[3].getCanSpecialAttack())
            {
                rBtn_Hero4Special.IsEnabled = false;
                rBtn_Hero4Special.IsChecked = false;
            }
            else
            {
                rBtn_Hero4Special.IsEnabled = true;
            }            
        }

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private async void btn_Ready_Click(object sender, RoutedEventArgs e)
        {
            btn_Ready.IsEnabled = false;
            if (! _IsSwarmDefeated && _theHeroes[0].getCurHealth() > 0)
            {
                
                if (rBtn_Hero1Attack.IsChecked == true) 
                {
                    await Task.Delay(10);                    
                    normalAttack(_theHeroes[0]);
                }
                else if (rBtn_Hero1Defend.IsChecked == true)
                {
                    await Task.Delay(10);
                    defend(_theHeroes[0]);
                }
                else if (rBtn_Hero1Special.IsChecked == true)
                {
                    await Task.Delay(10);
                    specialMove(_theHeroes[0], 0);
                    
                }
                else if (rBtn_Hero1Item.IsChecked == true)
                {
                    await Task.Delay(10);
                    useItem(_theHeroes[0]);
                }
            }

            //----------------------------------------//
            if (! _IsSwarmDefeated && _theHeroes[1].getCurHealth() > 0)
            {
                if (rBtn_Hero2Attack.IsChecked == true)
                {
                    await Task.Delay(400);
                    normalAttack(_theHeroes[1]);
                }
                else if (rBtn_Hero2Defend.IsChecked == true)
                {
                    await Task.Delay(400);
                    defend(_theHeroes[1]);
                }
                else if (rBtn_Hero2Special.IsChecked == true)
                {
                    await Task.Delay(400);
                    specialMove(_theHeroes[1], 1);
                }
                else if (rBtn_Hero2Item.IsChecked == true)
                {
                    await Task.Delay(400);
                    useItem(_theHeroes[1]);
                }
            }

            //----------------------------------------//
            if (! _IsSwarmDefeated && _theHeroes[2].getCurHealth() > 0)
            {
                if (rBtn_Hero3Attack.IsChecked == true)
                {
                    await Task.Delay(400);
                    normalAttack(_theHeroes[2]);
                }
                else if (rBtn_Hero3Defend.IsChecked == true)
                {
                    await Task.Delay(400);
                    defend(_theHeroes[2]);

                }
                else if (rBtn_Hero3Special.IsChecked == true)
                {

                    await Task.Delay(400);
                    specialMove(_theHeroes[2], 2);
                }
                else if (rBtn_Hero3Item.IsChecked == true)
                {
                    await Task.Delay(400);
                    useItem(_theHeroes[2]);
                }
            }
            //----------------------------------------//
            if (! _IsSwarmDefeated && _theHeroes[3].getCurHealth() > 0)
            {
                if (rBtn_Hero4Attack.IsChecked == true)
                {
                    await Task.Delay(400);
                    normalAttack(_theHeroes[3]);
                }
                else if (rBtn_Hero4Defend.IsChecked == true)
                {
                    await Task.Delay(400);                    
                    defend(_theHeroes[3]);
                }
                else if (rBtn_Hero4Special.IsChecked == true)
                {
                    await Task.Delay(400);
                    specialMove(_theHeroes[3], 3);
                }
                else if (rBtn_Hero4Item.IsChecked == true)
                {
                    await Task.Delay(400);
                    useItem(_theHeroes[3]);
                }
            }
            //--------------Hero's have had their say... IT'S MONSTA TIME.---------------//
            int monstCtr = 0;
            foreach(Monster m in _TheSwarm)
            {
                monstCtr++;

                await Task.Delay(400);

                if (m.getIsDefeated() != true)
                {
                    
                    monsterAttack(m);
                    checkForDefeatedUnit();
                }
            }
            incrementEffects();                        
            foreach (Hero h in _theHeroes)
            {
                await Task.Delay(400);
                String effectString = "";

                if (!h.getIsDefeated())
                    effectString = h.Notify();

                for (int x = 0; x < h.getEffectList().Count; x++)
                {
                    LinkedListNode<StatusEffect> cur = (LinkedListNode<StatusEffect>)h.getEffectList().First;

                    if (cur.Value.getDuration() <= 0)
                    {
                        h.Unsubscribe(cur.Value);
                        x--;
                    }

                    else
                        cur = cur.Next;
                }

                _Paragraph.Inlines.Add(new Bold(new Run(effectString))
                {
                    Foreground = Brushes.Fuchsia
                });                
                updateVisuals();
                
            }
            checkForDepletedMana();
            checkForSilenced();
            checkForStunned();
            btn_Ready.IsEnabled = true;
            checkReady();
            _Paragraph.Inlines.Add(new LineBreak());
        }

        private void rBtn_Hero1Attack_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero1Defend_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero1Special_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero1Item_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero2Attack_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero2Defend_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero2Special_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero2Item_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero3Attack_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero3Defend_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero3Special_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero3Item_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero4Attack_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero4Defend_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero4Special_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rBtn_Hero4Item_Click(object sender, RoutedEventArgs e)
        {
            checkReady();
        }

        private void rtb_testBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            rtb_testBox.ScrollToEnd();
        }

        //End Event Handlers
    }
}
