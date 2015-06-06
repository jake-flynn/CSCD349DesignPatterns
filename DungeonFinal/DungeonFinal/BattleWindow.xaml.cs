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
        Paragraph _Paragraph;
        Inventory _BattleInventory;

        public BattleWindow()
        {
            InitializeComponent();
        }

        public BattleWindow(Monster mon, Party heros)
        {
            InitializeComponent();

            _theParty = heros;
            _theHeroes = _theParty.getAllHeroes();
            _monster = mon;

            _BattleInventory = _theParty.getInventory();

            updateVisuals();
            

            tb_monster.Text = _monster.getName();
            tb_hero1.Text = _theHeroes[0].getName();
            tb_hero2.Text = _theHeroes[1].getName();
            tb_hero3.Text = _theHeroes[2].getName();
            tb_hero4.Text = _theHeroes[3].getName();


            rect_hero1.Fill = _theHeroes[0].getImageBrush();
            rect_hero2.Fill = _theHeroes[1].getImageBrush();
            rect_hero3.Fill = _theHeroes[2].getImageBrush();
            rect_hero4.Fill = _theHeroes[3].getImageBrush();
            rect_Monster.Fill = _monster.getImageBrush();



            //testing rich text box


            
            _Paragraph = new Paragraph();
            rtb_testBox.Document = new FlowDocument(_Paragraph);

            
            _Paragraph.Inlines.Add(new Bold(new Run("Battle Log:"))
            {
                Foreground = Brushes.Black
            });
            
            _Paragraph.Inlines.Add(new LineBreak());
            this.DataContext = this;




        }
        
        //==========================================================================================================//
        //Start Methods
        //==========================================================================================================//
        
        
        public void checkForDefeatedUnit() //Checks to see if a hero or monster has been slain
        {
            if (_monster.getCurHealth() <= 0)//This method will also check for revived units as soon as an item is used.
            {
                MessageBox.Show(_monster.getName() + " was slain!!!");

                
                this.Close();
            }
            
            foreach (Hero h in _theHeroes)
            {
                if (h.getCurHealth() <= 0 && h.getIsDefeated() != true)
                {
                    h.setIsDefeated(true);
                    MessageBox.Show(h.getName() + " gasps a final ragged breath, then falls.");
                    
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
                    //disable  who was killed. Ask jake how to do this at a gui level.
                }
            }
        }

        public void updateVisuals()
        {
            prgBar_Hero1.Value = ((double)_theHeroes[0].getCurHealth()) / ((double)_theHeroes[0].getMaxHealth()) * 100;
            prgBar_Hero2.Value = ((double)_theHeroes[1].getCurHealth()) / ((double)_theHeroes[1].getMaxHealth()) * 100;
            prgBar_Hero3.Value = ((double)_theHeroes[2].getCurHealth()) / ((double)_theHeroes[2].getMaxHealth()) * 100;
            prgBar_Hero4.Value = ((double)_theHeroes[3].getCurHealth()) / ((double)_theHeroes[3].getMaxHealth()) * 100;
            prgBar_Monster.Value = ((double)_monster.getCurHealth()) / ((double)_monster.getBaseHealth()) * 100;

            lbl_monsterHealthNumbers.Content = "" + _monster.getCurHealth() + "/" + _monster.getBaseHealth();
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

            rect_Monster.ToolTip = "checking to see if this works\r\n" + _monster.getCurHealth();
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

            _Paragraph.Inlines.Add(new Bold(new Run(hero.getName() + " used basic attack for: " + heroDamage + " damage"))//EVENTUALLY, I want to say which monster got attacked, in the swarm window.
            {
                Foreground = hero.getTextColor()
            });
            _Paragraph.Inlines.Add(new LineBreak());

            mon.setCurHealth(mon.getCurHealth() - heroDamage);
            updateVisuals();

            checkForDefeatedUnit();
        }

        private string specialMove(Hero hero, int whichHero)
        {
            Monster[] justOneMonster = new Monster[1];
            justOneMonster[0] = _monster;
            string toReturn = hero.PerformSpecialAttack(_theParty, whichHero, justOneMonster);
            updateVisuals();
            checkForDefeatedUnit();
            return toReturn;
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

        }

        private void monsterAttack() //Monster attacks!
        {  
            Monster mon = _monster;
            Hero hero = mon.FindTarget(_theParty);
            int monsterDamage;

            var randomGeneratedNumber = new Random();
            int randSpecial = randomGeneratedNumber.Next(10) + 1;

            if (randSpecial <= mon.getSpecialAttackFrequency())
            {                
                _Paragraph.Inlines.Add(new Bold(new Run(_monster.PerformSpecialAttack(_theParty, 0, _monster)))
                {
                    Foreground = Brushes.Red
                });
                _Paragraph.Inlines.Add(new LineBreak());
            }
            else
            {
                if(mon.getIsPhysical())
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
            _Paragraph.Inlines.Add(new Bold(new Run(hero.getName() + " used defend and is taking reduced damage this turn."))
            {
                Foreground = hero.getTextColor()
            });
            _Paragraph.Inlines.Add(new LineBreak());
            hero.setIsDefending(true);
        }

        private void incrementEffects()//This method will process all effects and time based moves
        {
            foreach(Hero h in _theHeroes)
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


        //End Methods

        //==========================================================================================================//
        //Start Event Handlers
        //==========================================================================================================//

        private async void btn_Ready_Click(object sender, RoutedEventArgs e) 
        {
            if (_monster.getCurHealth() > 0 && _theHeroes[0].getCurHealth() > 0)
            {
                if (rBtn_Hero1Attack.IsChecked == true) //I don't like how I am doing this. Or maybe I need more things interacting with character death...
                {
                    
                    await Task.Delay(10);
                    normalAttack(_theHeroes[0], _monster);
                }
                else if (rBtn_Hero1Defend.IsChecked == true)
                {
                    await Task.Delay(10);
                    defend(_theHeroes[0]);
                }
                else if (rBtn_Hero1Special.IsChecked == true)
                {
                    await Task.Delay(10);
                    _Paragraph.Inlines.Add(new Bold(new Run(specialMove(_theHeroes[0], 0)))
                    {
                        Foreground = _theHeroes[0].getTextColor()
                    });
                    _Paragraph.Inlines.Add(new LineBreak());
                    
                }
                else if (rBtn_Hero1Item.IsChecked == true)
                {
                    await Task.Delay(10);
                    useItem(_theHeroes[0]);                    
                }
            }

            //----------------------------------------//
            if (_monster.getCurHealth() > 0 && _theHeroes[1].getCurHealth() > 0)
            {
                if (rBtn_Hero2Attack.IsChecked == true)
                {
                    await Task.Delay(400);
                    normalAttack(_theHeroes[1], _monster);
                }
                else if (rBtn_Hero2Defend.IsChecked == true)
                {
                    await Task.Delay(400);                    
                    defend(_theHeroes[1]);
                }
                else if (rBtn_Hero2Special.IsChecked == true)
                {
                    await Task.Delay(400);

                    _Paragraph.Inlines.Add(new Bold(new Run(specialMove(_theHeroes[1], 1)))
                    {
                        Foreground = _theHeroes[1].getTextColor()
                    });
                    _Paragraph.Inlines.Add(new LineBreak());                    
                }
                else if (rBtn_Hero2Item.IsChecked == true)
                {
                    await Task.Delay(400);
                    useItem(_theHeroes[1]);
                }
            }

            //----------------------------------------//
            if (_monster.getCurHealth() > 0 && _theHeroes[2].getCurHealth() > 0)
            {
                if (rBtn_Hero3Attack.IsChecked == true)
                {                    
                    await Task.Delay(400);
                    normalAttack(_theHeroes[2], _monster);
                }
                else if (rBtn_Hero3Defend.IsChecked == true)
                {
                    await Task.Delay(400);
                    defend(_theHeroes[2]);

                }
                else if (rBtn_Hero3Special.IsChecked == true)
                {
                    await Task.Delay(400);
                    _Paragraph.Inlines.Add(new Bold(new Run(specialMove(_theHeroes[2], 2)))
                    {
                        Foreground = _theHeroes[2].getTextColor()
                    });
                    _Paragraph.Inlines.Add(new LineBreak());

                    
                }
                else if (rBtn_Hero3Item.IsChecked == true)
                {
                    await Task.Delay(400);
                    useItem(_theHeroes[2]);
                    
                }
            }
            //----------------------------------------//
            if (_monster.getCurHealth() > 0 && _theHeroes[3].getCurHealth() > 0)
            {
                if (rBtn_Hero4Attack.IsChecked == true)
                {                    
                    await Task.Delay(400);
                    normalAttack(_theHeroes[3], _monster);
                }
                else if (rBtn_Hero4Defend.IsChecked == true)
                {
                    await Task.Delay(400);
                    defend(_theHeroes[3]);
                }
                else if (rBtn_Hero4Special.IsChecked == true)
                {
                    await Task.Delay(400);
                    _Paragraph.Inlines.Add(new Bold(new Run(specialMove(_theHeroes[3], 3)))
                    {
                        Foreground = _theHeroes[3].getTextColor()
                    });
                    _Paragraph.Inlines.Add(new LineBreak());                    
                }
                else if (rBtn_Hero4Item.IsChecked == true)
                {
                    await Task.Delay(400);
                    useItem(_theHeroes[3]);
                }
            }
            //--------------Hero's have had their say... IT'S MONSTA TIME.---------------//

            if (_monster.getCurHealth() > 0)
            {                
                monsterAttack();
                await Task.Delay(500);
                checkForDefeatedUnit();
            }
            //incrementEffects();
            foreach(Hero h in _theHeroes)
            {                
                String effectString = "";
                effectString = h.Notify();

                for (int x = 0; x < h.getEffectList().Count; x++ )
                {
                    LinkedListNode<StatusEffect> cur = (LinkedListNode<StatusEffect>) h.getEffectList().First;

                    if(cur.Value.getDuration() <= 0)
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


