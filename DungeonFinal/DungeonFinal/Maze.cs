using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class Maze
    {

        private int _dimension;
        private int _curRow, _curCol;
        private Room[,] _rooms;

        public int GetDimension()
        {
            return _dimension;
        }

        public void SetDimension(int d)
        {
            _dimension = d;
        }

        public int GetCurrentRow()
        {
            return _curRow;
        }

        public void SetCurrentRow(int r)
        {
            _curRow = r;
        }

        public int GetCurrentCol()
        {
            return _curCol;
        }

        public void SetCurrentCol(int c)
        {
            _curCol = c;
        }

        public Room GetCurrentRoom()
        {
            return _rooms[_curRow, _curCol];
        }

        public int[] GetPosition()
        {
            int[] position = new int[2];
            position[0] = GetCurrentRow();
            position[1] = GetCurrentCol();
            return position;
        }

        public Room[,] GetRooms()
        {
            return _rooms;
        }

        public void SetRooms(Room[,] toSet)
        {
            _rooms = toSet;
        }

        private void WallMessage()
        {
            Console.WriteLine("Thats a wall dummy!");
        }

        public void MoveNorth()
        {
            var curRoom = _rooms[_curRow, _curCol];
            if (!curRoom.GetNorthDoor().CanPass())
                WallMessage();
            else
            {
                _curRow--;
            }
        }

        public void MoveEast()
        {
            var curRoom = _rooms[_curRow, _curCol];
            if (!curRoom.GetEastDoor().CanPass())
                WallMessage();
            else
            {
                _curCol++;
            }
        }

        public void MoveSouth()
        {
            var curRoom = _rooms[_curRow, _curCol];
            if (!curRoom.GetSouthDoor().CanPass())
                WallMessage();
            else
            {
                _curRow++;
            }
        }

        public void MoveWest()
        {
            var curRoom = _rooms[_curRow, _curCol];
            if (!curRoom.GetWestDoor().CanPass())
                WallMessage();
            else
            {
                _curCol--;
            }
        }

        public bool PlayerInExit()
        {
            return _rooms[_curRow, _curCol].IsExit();
        }




        public bool MazeTraversal()
        {
            var grid = new bool[_dimension, _dimension];

            for (var i = 0; i < _dimension; i++)
                for (var j = 0; j < _dimension; j++)
                    grid[i, j] = false;

            MazeTraversalHelper(_curRow, _curCol, grid);

            return grid[_dimension - 1, _dimension - 1];
        }

        private void MazeTraversalHelper(int row, int col, bool[,] grid)
        {
            var curRoom = _rooms[row, col];
            grid[row, col] = true;
            if (curRoom.IsExit())
                return;

            int northRow = row - 1,
                northCol = col,
                southRow = row + 1,
                southCol = col,
                eastRow = row,
                eastCol = col + 1,
                westRow = row,
                westCol = col - 1;

            if (northRow < 0)
                northRow = _dimension - 1;
            if (southRow >= _dimension)
                southRow = 0;
            if (eastCol >= _dimension)
                eastCol = 0;
            if (westCol < 0)
                westCol = _dimension - 1;

            if (curRoom.GetNorthDoor().IsOpen() && !grid[northRow, northCol])
                MazeTraversalHelper(northRow, northCol, grid);
            if (curRoom.GetSouthDoor().IsOpen() && !grid[southRow, northCol])
                MazeTraversalHelper(southRow, southCol, grid);
            if (curRoom.GetEastDoor().IsOpen() && !grid[eastRow, eastCol])
                MazeTraversalHelper(eastRow, eastCol, grid);
            if (curRoom.GetWestDoor().IsOpen() && !grid[westRow, westCol])
                MazeTraversalHelper(westRow, westCol, grid);
        }









        public override string ToString()
        {
            var maze = "";
            int i, j;

            for (i = 0; i < _rooms.GetLength(0); i++)
            {
                // build north doors
                for (j = 0; j < _rooms.GetLength(1); j++)
                {
                    maze += "*";
                    if (_rooms[i, j].GetNorthDoor().IsOpen() == false)
                        maze += "x";
                    else
                        maze += "-";
                }

                maze += "*" + Environment.NewLine;
                for (j = 0; j < _rooms.GetLength(1); j++)
                {
                    if (_rooms[i, j].GetWestDoor().IsOpen() == false)
                        maze += "x";
                    else
                        maze += "|";
                    if (_rooms[i, j].IsExit())
                        maze += "E";
                    else if (i == _curRow && j == _curCol)
                        maze += "P";
                    else
                        maze += " ";
                    maze += "";
                }
                if (_rooms[i, j - 1].GetEastDoor().IsOpen() == false)
                    maze += "x";
                else
                    maze += "|";
                maze += Environment.NewLine;
            }
            for (j = 0; j < _rooms.GetLength(1); j++)
            {
                maze += "*";
                if (_rooms[_rooms.GetLength(0) - 1, j].GetSouthDoor().IsOpen() == false)
                    maze += "x";
                else
                    maze += "-";
            }
            maze += "*" + Environment.NewLine;
            return maze;
        }

        public void OpenAllDoors()
        {
            for (int i = 0; i < _dimension; i++)
            {
                for (int j = 0; j < _dimension; j++)
                {
                    _rooms[i, j].openAllDoors();
                }
            }
        }

        public int FindHowManyLocked(int i, int j)
        {
            int numberOfLockedDoors = 0;
            if (_rooms[i, j].GetNorthDoor().IsOpen() == false)
            {
                numberOfLockedDoors++;
            }

            if (_rooms[i, j].GetEastDoor().IsOpen() == false)
            {
                numberOfLockedDoors++;
            }

            if (_rooms[i, j].GetSouthDoor().IsOpen() == false)
            {
                numberOfLockedDoors++;
            }

            if (_rooms[i, j].GetWestDoor().IsOpen() == false)
            {
                numberOfLockedDoors++;
            }
            Console.WriteLine("numberOfDoorsLocked variable: " + numberOfLockedDoors);
            return numberOfLockedDoors;
        }

        public void lockTwo(int i, int j)
        {
            var randomGeneratedNumber = new Random();
            int randomNumber1 = randomGeneratedNumber.Next(5);
            int randomNumber2 = 0;
            do
            {
                randomNumber2 = randomGeneratedNumber.Next(5);
            } while (randomNumber2 == randomNumber1);

            Console.WriteLine("random number 1 and random number 2: " + randomNumber1 + " " + randomNumber1);
            if (randomNumber1 == 1)
            {
                _rooms[i, j].GetNorthDoor().Shut();
            }
            else if (randomNumber1 == 2)
            {
                _rooms[i, j].GetEastDoor().Shut();
            }
            else if (randomNumber1 == 3)
            {
                _rooms[i, j].GetSouthDoor().Shut();
            }
            else if (randomNumber1 == 4)
            {
                _rooms[i, j].GetWestDoor().Shut();
            }

            if (randomNumber2 == 1)
            {
                _rooms[i, j].GetNorthDoor().Shut();
            }
            else if (randomNumber2 == 2)
            {
                _rooms[i, j].GetEastDoor().Shut();
            }
            else if (randomNumber2 == 3)
            {
                _rooms[i, j].GetSouthDoor().Shut();
            }
            else if (randomNumber2 == 4)
            {
                _rooms[i, j].GetWestDoor().Shut();
            }
        }

        public void lockOne(int i, int j)
        {
            int locked = 0;
            if (_rooms[i, j].GetNorthDoor().IsOpen() == false)
            {
                locked = 1;
            }
            else if (_rooms[i, j].GetEastDoor().IsOpen() == false)
            {
                locked = 2;
            }
            else if (_rooms[i, j].GetSouthDoor().IsOpen() == false)
            {
                locked = 3;
            }
            else if (_rooms[i, j].GetWestDoor().IsOpen() == false)
            {
                locked = 4;
            }


            var randomGen = new Random();
            int toLock;
            do
            {
                toLock = randomGen.Next(5);
            } while (toLock == locked);


            Console.WriteLine("toLock variable " + toLock);
            if (toLock == 1)
            {
                _rooms[i, j].GetNorthDoor().Shut();
            }
            else if (toLock == 2)
            {
                _rooms[i, j].GetEastDoor().Shut();
            }
            else if (toLock == 3)
            {
                _rooms[i, j].GetSouthDoor().Shut();
            }
            else if (toLock == 4)
            {
                _rooms[i, j].GetWestDoor().Shut();
            }
        }

    }
}
