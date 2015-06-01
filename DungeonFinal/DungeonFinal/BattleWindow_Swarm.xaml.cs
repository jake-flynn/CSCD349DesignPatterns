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

        Monster _PrototypeMonster;
        Monster[] _TheSwarm;
        Party _theParty;
        Hero[] _theHeroes;
        Boolean _IsSwarmDefeated;
        Paragraph paragraph;

        //In the swarm

        public BattleWindow_Swarm()
        {
            InitializeComponent();
        }

        public BattleWindow_Swarm(Monster mon, Party heros)
        {
            InitializeComponent();
            _theParty = heros;
            _theHeroes = _theParty.getHeros();
            _TheSwarm = new Monster[6];
            _IsSwarmDefeated = false;

            _PrototypeMonster = mon;


            for (int m = 0; m < 6; m++)
            {
                _TheSwarm[m] = (Monster)_PrototypeMonster.Clone(m + 1);   
            }                                                      

            //_TheSwarm[0] = new Insect();
            //_TheSwarm[1] = new Insect();
            //_TheSwarm[2] = new Insect();
            //_TheSwarm[3] = new Insect();
            //_TheSwarm[4] = new Insect();
            //_TheSwarm[5] = new Insect();

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

            paragraph = new Paragraph();
            rtb_testBox.Document = new FlowDocument(paragraph);


            paragraph.Inlines.Add(new Bold(new Run("Battle Log:"))
            {
                Foreground = Brushes.Black
            });

            paragraph.Inlines.Add(new LineBreak());
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
                MessageBox.Show("The " + _TheSwarm[0].getName() + " swarm was defeated!!!");
                _IsSwarmDefeated = true;
                this.Close();
            }
            foreach(Monster m in _TheSwarm)
            {
                if (m.getCurHealth() <= 0 && ! m.getIsDefeated())
                {
                    MessageBox.Show(m.getName() + " was slain!!!");
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

            paragraph.Inlines.Add(new Bold(new Run(hero.getName() + " used basic attack for: " + heroDamage + " damage"))
            {
                Foreground = hero.getTextColor()
            });
            paragraph.Inlines.Add(new LineBreak());

            mon.setCurHealth(mon.getCurHealth() - heroDamage);
            updateVisuals();

            checkForDefeatedUnit();
        }

        private string specialMove(Hero hero, int whichHero)
        {
            var cw = new ChoiceWindow(_TheSwarm);
            cw.ShowDialog();
            int attackTarget = cw.getChoiceFromSelect();
            Monster mon = _TheSwarm[attackTarget];
            string toReturn = hero.PerformSpecialAttack(_theParty, whichHero, mon);
            updateVisuals();
            checkForDefeatedUnit();
            return toReturn;
        }

        private void monsterAttack(Monster mon) //Monster attacks!
        {
            
            Hero hero = mon.FindTarget(_theParty);
            int monsterDamage;

            var randomGeneratedNumber = new Random();
            int randSpecial = randomGeneratedNumber.Next(10) + 1;

            if (randSpecial <= mon.getSpecialAttackFrequency())
            {
                
                paragraph.Inlines.Add(new Bold(new Run(mon.PerformSpecialAttack(_theParty, 0, mon)))
                {
                    Foreground = Brushes.Red
                });
                paragraph.Inlines.Add(new LineBreak());
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

                paragraph.Inlines.Add(new Bold(new Run("The " + mon.getName() + " attacks " + hero.getName() + " for " + monsterDamage + " damage."))
                {
                    Foreground = Brushes.Red
                });
                paragraph.Inlines.Add(new LineBreak());
            }
            updateVisuals();
            checkForDefeatedUnit();
        }

        private void defend(Hero hero)
        {
            hero.setIsDefending(true);
            paragraph.Inlines.Add(new Bold(new Run(hero.getName() + " used defend and is taking reduced damage this turn."))
            {
                Foreground = hero.getTextColor()
            });
            paragraph.Inlines.Add(new LineBreak());
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
        }

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private async void btn_Ready_Click(object sender, RoutedEventArgs e)
        {
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
                    paragraph.Inlines.Add(new Bold(new Run(specialMove(_theHeroes[0], 0)))
                    {
                        Foreground = _theHeroes[0].getTextColor()
                    });
                    paragraph.Inlines.Add(new LineBreak());
                    
                }
                else if (rBtn_Hero1Item.IsChecked == true)
                {
                    await Task.Delay(10);
                    paragraph.Inlines.Add(new Bold(new Run(_theHeroes[0].getName() + " used item"))
                    {
                        Foreground = _theHeroes[0].getTextColor()
                    });
                    paragraph.Inlines.Add(new LineBreak());
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

                    paragraph.Inlines.Add(new Bold(new Run(specialMove(_theHeroes[1], 1)))
                    {
                        Foreground = _theHeroes[1].getTextColor()
                    });
                    paragraph.Inlines.Add(new LineBreak());
                }
                else if (rBtn_Hero2Item.IsChecked == true)
                {
                    await Task.Delay(400);

                    paragraph.Inlines.Add(new Bold(new Run(_theHeroes[1].getName() + " used item"))
                    {
                        Foreground = _theHeroes[1].getTextColor()
                    });
                    paragraph.Inlines.Add(new LineBreak());
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

                    paragraph.Inlines.Add(new Bold(new Run(specialMove(_theHeroes[2], 2)))
                    {
                        Foreground = _theHeroes[2].getTextColor()
                    });
                    paragraph.Inlines.Add(new LineBreak());
                }
                else if (rBtn_Hero3Item.IsChecked == true)
                {
                    await Task.Delay(400);

                    paragraph.Inlines.Add(new Bold(new Run(_theHeroes[2].getName() + " used item"))
                    {
                        Foreground = _theHeroes[2].getTextColor()
                    });

                    paragraph.Inlines.Add(new LineBreak());
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

                    paragraph.Inlines.Add(new Bold(new Run(specialMove(_theHeroes[3], 3)))
                    {
                        Foreground = _theHeroes[3].getTextColor()
                    });
                    paragraph.Inlines.Add(new LineBreak());
                }
                else if (rBtn_Hero4Item.IsChecked == true)
                {
                    await Task.Delay(400);

                    paragraph.Inlines.Add(new Bold(new Run(_theHeroes[3].getName() + " used item"))
                    {
                        Foreground = _theHeroes[3].getTextColor()
                    });
                    paragraph.Inlines.Add(new LineBreak());
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
                h.Notify();
            }
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
