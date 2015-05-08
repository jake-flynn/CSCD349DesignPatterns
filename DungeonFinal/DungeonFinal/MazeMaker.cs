using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class MazeMaker
    {//start class

        private int _dimension;

        public MazeMaker()
        {
            _dimension = 6;
        }

        public MazeMaker(int num)
        {
            _dimension = num;
        }


        public Maze Build()
        {
            var newMaze = new Maze();

            newMaze.SetRooms(RoomSetup());
            newMaze.SetDimension(_dimension);
            do
            {
                newMaze.OpenAllDoors();
                LockBoarder(newMaze);
                BuildManualWalls(newMaze);
                //LockRandomDoors(newMaze);
            } while (!newMaze.MazeTraversal());


            return newMaze;
        }

        private void BuildManualWalls(Maze myMaze)
        {
            Room[,] rooms = myMaze.GetRooms();

            //shut border

            //for (int x = 0; x < myMaze.GetDimension(); x++)
            //{
            //    rooms[0,x].shutNorthDoor();
            //}

            //for (int x = 0; x < myMaze.GetDimension(); x++)
            //{
            //    rooms[x,0].shutWestDoor();
            //}
            //for (int x = 0; x < myMaze.GetDimension(); x++)
            //{
            //    rooms[x, myMaze.GetDimension()-1].shutEastDoor();
            //}
            //for (int x = 0; x < myMaze.GetDimension(); x++)
            //{
            //    rooms[myMaze.GetDimension() -1, x].shutSouthDoor();
            //}

            //shut interior walls manually
            rooms[0, 1].shutSouthDoor();
            rooms[0, 2].shutSouthDoor();
            rooms[0, 4].shutSouthDoor();

            rooms[1, 0].shutSouthDoor();
            rooms[1, 1].shutSouthDoor();
            rooms[1, 2].shutEastDoor();
            rooms[1, 3].shutSouthDoor();
            rooms[1, 3].shutSouthDoor();
            rooms[1, 4].shutSouthDoor();
            rooms[1, 5].shutSouthDoor();

            rooms[2, 1].shutEastDoor();
            rooms[2, 2].shutEastDoor();
            rooms[2, 4].shutSouthDoor();

            rooms[3, 0].shutEastDoor();
            rooms[3, 1].shutEastDoor();
            rooms[3, 2].shutEastDoor();
            rooms[3, 3].shutEastDoor();
            rooms[3, 5].shutSouthDoor();

            rooms[4, 0].shutEastDoor();
            rooms[4, 1].shutSouthDoor();
            rooms[4, 2].shutSouthDoor();
            rooms[4, 3].shutEastDoor();
            rooms[4, 5].shutSouthDoor();

            rooms[5, 3].shutEastDoor();






        }

        private void LockRandomDoors(Maze newMaze)
        {
            for (int i = 0; i < _dimension; i++)
            {
                for (int j = 0; j < _dimension; j++)
                {
                    var howManyLocked = newMaze.FindHowManyLocked(i, j);
                    if (howManyLocked == 0)
                    {
                        Console.WriteLine("call lock two method");
                        newMaze.lockTwo(i, j);
                    }
                    else if (howManyLocked == 1)
                    {
                        Console.WriteLine("call lock one method");
                        newMaze.lockOne(i, j);
                    }
                    else { Console.WriteLine("do not call lock one or lock two method"); }
                }
            }
        }


        private Room[,] RoomSetup()
        {
            var rooms = new Room[_dimension, _dimension];

            // Initializing Rooms
            int i, j;
            for (i = 0; i < _dimension; i++)
            {
                for (j = 0; j < _dimension; j++)
                {
                    rooms[i, j] = new Room();
                }
            }
            DoorSetup(rooms);
            setExit(rooms);

            return rooms;
        }

        private void setExit(Room[,] rooms)
        {
            rooms[_dimension - 1, _dimension - 1].SetExit();
        }


        private void DoorSetup(Room[,] rooms)
        {
            int i, j;

            // Setting up West and East Shared Doors
            for (i = 0; i < _dimension; i++)
            {
                rooms[i, 0].SetWestDoor(new Door());
                rooms[i, 0].SetEastDoor(new Door());
            }
            for (i = 0; i < _dimension; i++)
                for (j = 1; j < _dimension; j++)
                {
                    rooms[i, j].SetWestDoor(rooms[i, j - 1].GetEastDoor());

                    if (j == _dimension - 1)
                        rooms[i, j].SetEastDoor(rooms[i, 0].GetWestDoor());
                    else
                        rooms[i, j].SetEastDoor(new Door());
                }

            // Setting up North and South Shared Doors
            for (i = 0; i < _dimension; i++)
            {
                rooms[0, i].SetNorthDoor(new Door());
                rooms[0, i].SetSouthDoor(new Door());
            }
            for (i = 1; i < _dimension; i++)
                for (j = 0; j < _dimension; j++)
                {
                    rooms[i, j].SetNorthDoor(rooms[i - 1, j].GetSouthDoor());

                    if (i == _dimension - 1)
                        rooms[i, j].SetSouthDoor(rooms[0, j].GetNorthDoor());
                    else
                        rooms[i, j].SetSouthDoor(new Door());
                }
        }

        private void LockBoarder(Maze maze)
        {
            Room[,] rooms = maze.GetRooms();

            int i, j;

            for (i = 0; i < maze.GetDimension(); i++)
                for (j = 0; j < maze.GetDimension(); j++)
                {
                    if (i == 0)
                        rooms[i, j].shutNorthDoor();
                    if (j == 0)
                        rooms[i, j].shutWestDoor();


                    if (i == maze.GetDimension() - 1)
                        rooms[i, j].shutSouthDoor();


                    if (j == maze.GetDimension() - 1)
                        rooms[i, j].shutEastDoor();

                }
        }

    }//end class
}
