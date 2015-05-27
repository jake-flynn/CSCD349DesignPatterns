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


        private Maze maze;
        public int difficulty = 6;
        public int move = 0;
        public int[,] visited;
        public int MonstersSeen = 0;
        public int runDifficulty = 1;
        public Party HerosParty;

        public MainWindow()
        {
            InitializeComponent();
            


            HerosParty = new Party();
            MessageBox.Show("Hello, and welcome to OFOM!");
            //newGame();
            //updateButtonsVisibility();
        }

        

        //---ALL METHODS BELOW---

        public void newGame()//resets all variables for a new game
        {
            runDifficulty = difficulty;
            var builder = new MazeMaker(runDifficulty);
            maze = builder.Build();
            visited = new int[runDifficulty, runDifficulty];
            newVisitArray();
            visit(maze.GetPosition()[0], maze.GetPosition()[1]);
            MonstersSeen = 0;
            populateMonsters();

            var charSelect = new CharacterSelect();
            charSelect.ShowDialog();
            HerosParty = charSelect.getPartyFromSelect();
        }

        public void newVisitArray()
        {
            for (int i = 0; i < runDifficulty; i++)
            {
                for (int j = 0; j < runDifficulty; j++)
                {
                    visited[i, j] = 0;
                }
            }
        }

        public void visit(int x, int y)
        {
            visited[x, y] = 1;
        }

        public void updateButtonsVisibility()
        {
            if (maze.GetCurrentRoom().GetNorthDoor().CanPass())
            {
                btn_moveNorth.IsEnabled = true;
            }
            if (!maze.GetCurrentRoom().GetNorthDoor().CanPass())
            {
                btn_moveNorth.IsEnabled = false;
            }

            if (maze.GetCurrentRoom().GetEastDoor().CanPass())
            {
                btn_moveEast.IsEnabled = true;
            }
            if (!maze.GetCurrentRoom().GetEastDoor().CanPass())
            {
                btn_moveEast.IsEnabled = false;
            }

            if (maze.GetCurrentRoom().GetSouthDoor().CanPass())
            {
                btn_moveSouth.IsEnabled = true;
            }
            if (!maze.GetCurrentRoom().GetSouthDoor().CanPass())
            {
                btn_moveSouth.IsEnabled = false;
            }

            if (maze.GetCurrentRoom().GetWestDoor().CanPass())
            {
                btn_moveWest.IsEnabled = true;
            }
            if (!maze.GetCurrentRoom().GetWestDoor().CanPass())
            {
                btn_moveWest.IsEnabled = false;
            }

            btn_viewMap.IsEnabled = true;

            tb_currentRow.Text = maze.GetCurrentRow()+1 + "";
            tb_currentCol.Text = maze.GetCurrentCol()+1 + "";
            tb_numberOfMonsters.Text = MonstersSeen + "";
        }

        public async void populateMonsters()
        {
            var randomGeneratedNumber = new Random();
            int randomNumber = randomGeneratedNumber.Next(10);
            Room[,] settingMonstersInRooms = maze.GetRooms();
            Monster monsterToAdd;
            MonsterFactory mazePopulator = new MonsterFactory();
            for(int i = 0; i < difficulty; i++)
            {
                for(int j = 1; j < difficulty; j++)
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
            settingMonstersInRooms[difficulty-1, difficulty-1].setMonster(monsterToAdd);
            maze.SetRooms(settingMonstersInRooms);

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
            MonstersSeen++;
            updateButtonsVisibility();
            //upgradeStats(heros);
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
            if (maze.GetCurrentRoom().GetNorthDoor().IsOpen() == true)
            {
                maze.MoveNorth();
                visit(maze.GetPosition()[0], maze.GetPosition()[1]);
                if(maze.GetCurrentRoom().hasMonster() == true)
                {
                    startBattle(maze.GetCurrentRoom().getMonster(), HerosParty);
                    maze.GetCurrentRoom().defeatedMonster();
                }
                if (maze.GetCurrentRoom().IsExit())
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
            if (maze.GetCurrentRoom().GetEastDoor().IsOpen() == true)
            {
                maze.MoveEast();
                visit(maze.GetPosition()[0], maze.GetPosition()[1]);
                if (maze.GetCurrentRoom().hasMonster() == true)
                {
                    startBattle(maze.GetCurrentRoom().getMonster(), HerosParty);
                    maze.GetCurrentRoom().defeatedMonster();
                }
                if (maze.GetCurrentRoom().IsExit())
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
            if (maze.GetCurrentRoom().GetSouthDoor().IsOpen() == true)
            {
                maze.MoveSouth();
                visit(maze.GetPosition()[0], maze.GetPosition()[1]);
                if (maze.GetCurrentRoom().hasMonster() == true)
                {
                    startBattle(maze.GetCurrentRoom().getMonster(), HerosParty);
                    maze.GetCurrentRoom().defeatedMonster();
                }
                if (maze.GetCurrentRoom().IsExit())
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
            if (maze.GetCurrentRoom().GetWestDoor().IsOpen() == true)
            {
                maze.MoveWest();
                visit(maze.GetPosition()[0], maze.GetPosition()[1]);
                if (maze.GetCurrentRoom().hasMonster() == true)
                {
                    startBattle(maze.GetCurrentRoom().getMonster(), HerosParty);
                    maze.GetCurrentRoom().defeatedMonster();
                }
                if (maze.GetCurrentRoom().IsExit())
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
            var map = new Map(maze.GetRooms(), visited, maze.GetPosition()[0], maze.GetPosition()[1]);
            map.ShowDialog();

        }



        private void btn_newGameNoSelect_Click(object sender, RoutedEventArgs e)
        {

            Party party = new Party();
            party.addHero(new Swordsman());
            party.addHero(new Paladin());
            party.addHero(new Rogue());
            party.addHero(new Cleric());
            HerosParty = party;

            runDifficulty = difficulty;
            var builder = new MazeMaker(runDifficulty);
            maze = builder.Build();
            visited = new int[runDifficulty, runDifficulty];
            newVisitArray();
            visit(maze.GetPosition()[0], maze.GetPosition()[1]);
            MonstersSeen = 0;
            populateMonsters();

            updateButtonsVisibility();
        }

    


    }
}
