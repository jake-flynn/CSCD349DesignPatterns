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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DungeonFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private Maze _Maze;
        public int _Difficulty = 6;
        public int _Move = 0;
        public int[,] _Visited;
        public int _MonstersSeen = 0;
        public int _RunDifficulty = 1;
        public Party _TheParty;
        private ItemFactory _ItemFactory;

        public MainWindow()
        {
            InitializeComponent();
            


            _TheParty = new Party();
            MessageBox.Show("Hello, and welcome to OFOM!");
            _ItemFactory = new ItemFactory();
            //newGame();
            //updateButtonsVisibility();
        }

        

        //---ALL METHODS BELOW---

        public void newGame()//resets all variables for a new game
        {
            _RunDifficulty = _Difficulty;
            var builder = new MazeMaker(_RunDifficulty);
            _Maze = builder.Build();
            _Visited = new int[_RunDifficulty, _RunDifficulty];
            newVisitArray();
            visit(_Maze.GetPosition()[0], _Maze.GetPosition()[1]);
            _MonstersSeen = 0;
            populateMonsters();

            var charSelect = new CharacterSelect();
            charSelect.ShowDialog();
            _TheParty = charSelect.getPartyFromSelect();
            btn_equipmentSelect.IsEnabled = true;
        }

        public void newVisitArray()
        {
            for (int i = 0; i < _RunDifficulty; i++)
            {
                for (int j = 0; j < _RunDifficulty; j++)
                {
                    _Visited[i, j] = 0;
                }
            }
        }

        public void visit(int x, int y)
        {
            _Visited[x, y] = 1;
        }

        public void updateButtonsVisibility()
        {
            if (_Maze.GetCurrentRoom().GetNorthDoor().CanPass())
            {
                btn_moveNorth.IsEnabled = true;
            }
            if (!_Maze.GetCurrentRoom().GetNorthDoor().CanPass())
            {
                btn_moveNorth.IsEnabled = false;
            }

            if (_Maze.GetCurrentRoom().GetEastDoor().CanPass())
            {
                btn_moveEast.IsEnabled = true;
            }
            if (!_Maze.GetCurrentRoom().GetEastDoor().CanPass())
            {
                btn_moveEast.IsEnabled = false;
            }

            if (_Maze.GetCurrentRoom().GetSouthDoor().CanPass())
            {
                btn_moveSouth.IsEnabled = true;
            }
            if (!_Maze.GetCurrentRoom().GetSouthDoor().CanPass())
            {
                btn_moveSouth.IsEnabled = false;
            }

            if (_Maze.GetCurrentRoom().GetWestDoor().CanPass())
            {
                btn_moveWest.IsEnabled = true;
            }
            if (!_Maze.GetCurrentRoom().GetWestDoor().CanPass())
            {
                btn_moveWest.IsEnabled = false;
            }

            btn_viewMap.IsEnabled = true;

            tb_currentRow.Text = _Maze.GetCurrentRow()+1 + "";
            tb_currentCol.Text = _Maze.GetCurrentCol()+1 + "";
            tb_numberOfMonsters.Text = _MonstersSeen + "";
        }

        public async void populateMonsters()
        {
            var randomGeneratedNumber = new Random();
            int randomNumber = randomGeneratedNumber.Next(10);
            Room[,] settingMonstersInRooms = _Maze.GetRooms();
            Monster monsterToAdd;
            MonsterFactory mazePopulator = new MonsterFactory();
            for(int i = 0; i < _Difficulty; i++)
            {
                for(int j = 1; j < _Difficulty; j++)
                {
                    randomNumber = randomGeneratedNumber.Next(10);
                    if( i < 3 && j < 3)
                    {
                        await Task.Delay(100);
                        settingMonstersInRooms[i, j].setMonster(mazePopulator.createMonster(1));
                    }
                    else if(i < 3 && j > 2 || i > 2 && j < 3)
                    {
                        await Task.Delay(100);
                        settingMonstersInRooms[i, j].setMonster(mazePopulator.createMonster(2));
                    }
                    else if (i>2 && j>2)
                    {
                        await Task.Delay(100);
                        settingMonstersInRooms[i, j].setMonster(mazePopulator.createMonster(3));
                    }

                }
            }
            
            //adding stu as a monster for sure and insect into second room
            settingMonstersInRooms[0, 1].setMonster(new Insect());
            settingMonstersInRooms[0, 3].setMonster(new StuBeast());


            monsterToAdd = mazePopulator.createMonster(4); //Random boss created
            settingMonstersInRooms[_Difficulty-1, _Difficulty-1].setMonster(monsterToAdd);
            _Maze.SetRooms(settingMonstersInRooms);

        }

        public void startBattle(Monster m, Party heros)
        {
            if(m.getIsSwarm())
            {
                int rndSwarm = new Random().Next(3) + 1;
                if(rndSwarm == 1 || rndSwarm == 2)
                {
                    SwarmBattle(m, heros);
                }
                else
                {
                    NormalBattle(m, heros);
                }
            }
            else
            {
                NormalBattle(m, heros);
            }
            _MonstersSeen++;
            updateButtonsVisibility();
            //upgradeStats(heros);
            _TheParty.getInventory().addLastToConsumable(_ItemFactory.createConsumable(1));
        }

        public void NormalBattle(Monster m, Party heros)
        {
            MessageBox.Show("Your Party enters the room...\r\n" +
                            "Only to see a " + m.getName() + " awaiting your arival!\r\n" +
                            "Prepare for the battle that is about to take place...");

            var bw = new BattleWindow(m, heros);
            bw.ShowDialog();
        }

        public void SwarmBattle(Monster m, Party heros)
        {
            MessageBox.Show("Your Party enters the room...\r\n" +
                "And you are ambushed by a horde of " + m.getName() + "s that fill the room!\r\n" +
                "Completely surrounded, you party prepares for a hard fight...");

            var bw = new BattleWindow_Swarm(m, heros);
            bw.ShowDialog();
        }

        public void upgradeStats(Party party)
        {
            Hero[] Heroes = party.getHeros();
            for (int i = 0; i < Heroes.Length; i++ )
            {
                Heroes[i].setMaxHealth(Heroes[i].getMaxHealth() + 5);
                Heroes[i].setCurHealth(Heroes[i].getCurHealth() + 4);
                Heroes[i].setMaxMana(Heroes[i].getMaxMana() + 5);
                Heroes[i].setCurMana(Heroes[i].getCurMana() + 4);

                Heroes[i].setModStrength(Heroes[i].getModStrength() + 1);
                Heroes[i].setModMagic(Heroes[i].getModMagic() + 1);
                Heroes[i].setModDefense(Heroes[i].getModDefense() + 1);
                Heroes[i].setModResistance(Heroes[i].getModResistance() + 1);

                MessageBox.Show("" + Heroes[i].getName() + "Stats have increased!!!\r\n"
                                + "Max Health increased by 5\r\n"
                                + "Current Health increased by 4\r\n"
                                + "Max Mana increased by 5\r\n"
                                + "Current Mana Increased by 4\r\n"
                                + "Strength increased by 1\r\n"
                                + "Magic increased by 1\r\n"
                                + "Defense increased by 1\r\n"
                                + "Resistance increased by 1");
                
            }
        }


        //---END ALL METHODS---

        //---ALL EVENT HANDLERS BELOW---

        private void btn_newGame_Click(object sender, RoutedEventArgs e)
        {
            newGame();
            updateButtonsVisibility();
        }

        private void btn_moveNorth_Click(object sender, RoutedEventArgs e)
        {
            if (_Maze.GetCurrentRoom().GetNorthDoor().IsOpen() == true)
            {
                _Maze.MoveNorth();
                visit(_Maze.GetPosition()[0], _Maze.GetPosition()[1]);
                if(_Maze.GetCurrentRoom().hasMonster() == true)
                {
                    startBattle(_Maze.GetCurrentRoom().getMonster(), _TheParty);
                    _Maze.GetCurrentRoom().defeatedMonster();
                }
                if (_Maze.GetCurrentRoom().IsExit())
                {
                    MessageBox.Show("You have reached the exit!!!\r\nYou may wander the maze or start a new game!");
                }

            }
            else
            {
                MessageBox.Show("Door is locked, find another way around");
            }
            updateButtonsVisibility();
        }

        private void btn_moveEast_Click(object sender, RoutedEventArgs e)
        {
            if (_Maze.GetCurrentRoom().GetEastDoor().IsOpen() == true)
            {
                _Maze.MoveEast();
                visit(_Maze.GetPosition()[0], _Maze.GetPosition()[1]);
                if (_Maze.GetCurrentRoom().hasMonster() == true)
                {
                    startBattle(_Maze.GetCurrentRoom().getMonster(), _TheParty);
                    _Maze.GetCurrentRoom().defeatedMonster();
                }
                if (_Maze.GetCurrentRoom().IsExit())
                {
                    MessageBox.Show("You have reached the exit!!!\r\nYou may wander the maze or start a new game!");
                }
            }
            else 
            {
                MessageBox.Show("Door is locked, find another way around");
            }
            updateButtonsVisibility();
        }

        private void btn_moveSouth_Click(object sender, RoutedEventArgs e)
        {
            if (_Maze.GetCurrentRoom().GetSouthDoor().IsOpen() == true)
            {
                _Maze.MoveSouth();
                visit(_Maze.GetPosition()[0], _Maze.GetPosition()[1]);
                if (_Maze.GetCurrentRoom().hasMonster() == true)
                {
                    startBattle(_Maze.GetCurrentRoom().getMonster(), _TheParty);
                    _Maze.GetCurrentRoom().defeatedMonster();
                }
                if (_Maze.GetCurrentRoom().IsExit())
                {
                    MessageBox.Show("You have reached the exit!!!\r\nYou may wander the maze or start a new game!");
                }

            }
            else
            {
                MessageBox.Show("Door is locked, find another way around");
            }
            updateButtonsVisibility();
        }

        private void btn_moveWest_Click(object sender, RoutedEventArgs e)
        {
            if (_Maze.GetCurrentRoom().GetWestDoor().IsOpen() == true)
            {
                _Maze.MoveWest();
                visit(_Maze.GetPosition()[0], _Maze.GetPosition()[1]);
                if (_Maze.GetCurrentRoom().hasMonster() == true)
                {
                    startBattle(_Maze.GetCurrentRoom().getMonster(), _TheParty);
                    _Maze.GetCurrentRoom().defeatedMonster();
                }
                if (_Maze.GetCurrentRoom().IsExit())
                {
                    MessageBox.Show("You have reached the exit!!!\r\nYou may wander the maze or start a new game!");
                }

            }
            else
            {
                MessageBox.Show("Door is locked, find another way around");
            }
            updateButtonsVisibility();
        }

        private void btn_viewMap_Click(object sender, RoutedEventArgs e)
        {
            var map = new Map(_Maze.GetRooms(), _Visited, _Maze.GetPosition()[0], _Maze.GetPosition()[1]);
            map.ShowDialog();

        }



        private void btn_newGameNoSelect_Click(object sender, RoutedEventArgs e)
        {

            Party party = new Party();
            party.addHero(new Swordsman());
            party.addHero(new Paladin());
            party.addHero(new Rogue());
            party.addHero(new Cleric());
            _TheParty = party;

            _RunDifficulty = _Difficulty;
            var builder = new MazeMaker(_RunDifficulty);
            _Maze = builder.Build();
            _Visited = new int[_RunDifficulty, _RunDifficulty];
            newVisitArray();
            visit(_Maze.GetPosition()[0], _Maze.GetPosition()[1]);
            _MonstersSeen = 0;
            populateMonsters();

            updateButtonsVisibility();
            btn_equipmentSelect.IsEnabled = true;
        }

        private void btn_equipmentSelect_Click(object sender, RoutedEventArgs e)
        {
            var equipmentSelect = new PartyEquipmentWindow(_TheParty);
            equipmentSelect.ShowDialog();
        }

    


    }
}
