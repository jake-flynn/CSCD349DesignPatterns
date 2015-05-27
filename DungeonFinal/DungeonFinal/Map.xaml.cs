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
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : Window
    {

        Rectangle[,] rooms = new Rectangle[6, 6];
        Rectangle[,] NorthDoors = new Rectangle[6, 6];
        Rectangle[,] EastDoors = new Rectangle[6, 6];
        Rectangle[,] SouthDoors = new Rectangle[6, 6];
        Rectangle[,] WestDoors = new Rectangle[6, 6];

        
        

        public Map(Room[,] r, int[,] v, int X, int Y)
        {
            InitializeComponent();

            ImageBrush brushRoom = new ImageBrush();
            BitmapImage room = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-leEjej7SaL4/VQa3h-QaegI/AAAAAAAAAqQ/YKS1YvvMQyw/w506-h532/room%2Btest.jpg"));
            brushRoom.ImageSource = room;

            rect_VisitedRoom.Fill = brushRoom;
            rect_VisitedRoom.Opacity = 0.5;
            rect_CurrentRoom.Fill = brushRoom;


            //build rooms rectangle array
            BuildRoomsRectangleArray();
            BuildNorthDoorRectangleArray();
            BuildEastDoorsRectangleArray();
            BuildWestDoorsRectangleArray();
            BuildSouthDoorsRectangleArray();
            

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    rooms[i,j].Fill = new SolidColorBrush(Colors.Black);
                    NorthDoors[i, j].Fill = new SolidColorBrush(Colors.Gray);
                    EastDoors[i, j].Fill = new SolidColorBrush(Colors.Gray);
                    WestDoors[i, j].Fill = new SolidColorBrush(Colors.Gray);
                    SouthDoors[i, j].Fill = new SolidColorBrush(Colors.Gray);
                }
            }

            PaintRoomsAndDoors(r, v, X, Y);
        }

        public void BuildRoomsRectangleArray()
        {
            rooms[0, 0] = row0col0Room;
            rooms[0, 1] = row0col1Room;
            rooms[0, 2] = row0col2Room;
            rooms[0, 3] = row0col3Room;
            rooms[0, 4] = row0col4Room;
            rooms[0, 5] = row0col5Room;

            rooms[1, 0] = row1col0Room;
            rooms[1, 1] = row1col1Room;
            rooms[1, 2] = row1col2Room;
            rooms[1, 3] = row1col3Room;
            rooms[1, 4] = row1col4Room;
            rooms[1, 5] = row1col5Room;

            rooms[2, 0] = row2col0Room;
            rooms[2, 1] = row2col1Room;
            rooms[2, 2] = row2col2Room;
            rooms[2, 3] = row2col3Room;
            rooms[2, 4] = row2col4Room;
            rooms[2, 5] = row2col5Room;

            rooms[3, 0] = row3col0Room;
            rooms[3, 1] = row3col1Room;
            rooms[3, 2] = row3col2Room;
            rooms[3, 3] = row3col3Room;
            rooms[3, 4] = row3col4Room;
            rooms[3, 5] = row3col5Room;

            rooms[4, 0] = row4col0Room;
            rooms[4, 1] = row4col1Room;
            rooms[4, 2] = row4col2Room;
            rooms[4, 3] = row4col3Room;
            rooms[4, 4] = row4col4Room;
            rooms[4, 5] = row4col5Room;

            rooms[5, 0] = row5col0Room;
            rooms[5, 1] = row5col1Room;
            rooms[5, 2] = row5col2Room;
            rooms[5, 3] = row5col3Room;
            rooms[5, 4] = row5col4Room;
            rooms[5, 5] = row5col5Room;
        }

        public void BuildNorthDoorRectangleArray()
        {
            NorthDoors[0, 0] = flatDoor_row0col0;
            NorthDoors[0, 1] = flatDoor_row0col1;
            NorthDoors[0, 2] = flatDoor_row0col2;
            NorthDoors[0, 3] = flatDoor_row0col3;
            NorthDoors[0, 4] = flatDoor_row0col4;
            NorthDoors[0, 5] = flatDoor_row0col5;

            NorthDoors[1, 0] = flatDoor_row1col0;
            NorthDoors[1, 1] = flatDoor_row1col1;
            NorthDoors[1, 2] = flatDoor_row1col2;
            NorthDoors[1, 3] = flatDoor_row1col3;
            NorthDoors[1, 4] = flatDoor_row1col4;
            NorthDoors[1, 5] = flatDoor_row1col5;

            NorthDoors[2, 0] = flatDoor_row2col0;
            NorthDoors[2, 1] = flatDoor_row2col1;
            NorthDoors[2, 2] = flatDoor_row2col2;
            NorthDoors[2, 3] = flatDoor_row2col3;
            NorthDoors[2, 4] = flatDoor_row2col4;
            NorthDoors[2, 5] = flatDoor_row2col5;

            NorthDoors[3, 0] = flatDoor_row3col0;
            NorthDoors[3, 1] = flatDoor_row3col1;
            NorthDoors[3, 2] = flatDoor_row3col2;
            NorthDoors[3, 3] = flatDoor_row3col3;
            NorthDoors[3, 4] = flatDoor_row3col4;
            NorthDoors[3, 5] = flatDoor_row3col5;

            NorthDoors[4, 0] = flatDoor_row4col0;
            NorthDoors[4, 1] = flatDoor_row4col1;
            NorthDoors[4, 2] = flatDoor_row4col2;
            NorthDoors[4, 3] = flatDoor_row4col3;
            NorthDoors[4, 4] = flatDoor_row4col4;
            NorthDoors[4, 5] = flatDoor_row4col5;

            NorthDoors[5, 0] = flatDoor_row5col0;
            NorthDoors[5, 1] = flatDoor_row5col1;
            NorthDoors[5, 2] = flatDoor_row5col2;
            NorthDoors[5, 3] = flatDoor_row5col3;
            NorthDoors[5, 4] = flatDoor_row5col4;
            NorthDoors[5, 5] = flatDoor_row5col5;

        }

        public void BuildEastDoorsRectangleArray()
        {
            EastDoors[0, 0] = verticalDoor_row0col1;
            EastDoors[0, 1] = verticalDoor_row0col2;
            EastDoors[0, 2] = verticalDoor_row0col3;
            EastDoors[0, 3] = verticalDoor_row0col4;
            EastDoors[0, 4] = verticalDoor_row0col5;
            EastDoors[0, 5] = verticalDoor_row0col6;

            EastDoors[1, 0] = verticalDoor_row1col1;
            EastDoors[1, 1] = verticalDoor_row1col2;
            EastDoors[1, 2] = verticalDoor_row1col3;
            EastDoors[1, 3] = verticalDoor_row1col4;
            EastDoors[1, 4] = verticalDoor_row1col5;
            EastDoors[1, 5] = verticalDoor_row1col6;

            EastDoors[2, 0] = verticalDoor_row2col1;
            EastDoors[2, 1] = verticalDoor_row2col2;
            EastDoors[2, 2] = verticalDoor_row2col3;
            EastDoors[2, 3] = verticalDoor_row2col4;
            EastDoors[2, 4] = verticalDoor_row2col5;
            EastDoors[2, 5] = verticalDoor_row2col6;

            EastDoors[3, 0] = verticalDoor_row3col1;
            EastDoors[3, 1] = verticalDoor_row3col2;
            EastDoors[3, 2] = verticalDoor_row3col3;
            EastDoors[3, 3] = verticalDoor_row3col4;
            EastDoors[3, 4] = verticalDoor_row3col5;
            EastDoors[3, 5] = verticalDoor_row3col6;

            EastDoors[4, 0] = verticalDoor_row4col1;
            EastDoors[4, 1] = verticalDoor_row4col2;
            EastDoors[4, 2] = verticalDoor_row4col3;
            EastDoors[4, 3] = verticalDoor_row4col4;
            EastDoors[4, 4] = verticalDoor_row4col5;
            EastDoors[4, 5] = verticalDoor_row4col6;

            EastDoors[5, 0] = verticalDoor_row5col1;
            EastDoors[5, 1] = verticalDoor_row5col2;
            EastDoors[5, 2] = verticalDoor_row5col3;
            EastDoors[5, 3] = verticalDoor_row5col4;
            EastDoors[5, 4] = verticalDoor_row5col5;
            EastDoors[5, 5] = verticalDoor_row5col6;
            
        }

        public void BuildWestDoorsRectangleArray()
        {
            WestDoors[0, 0] = verticalDoor_row0col0;
            WestDoors[0, 1] = verticalDoor_row0col1;
            WestDoors[0, 2] = verticalDoor_row0col2;
            WestDoors[0, 3] = verticalDoor_row0col3;
            WestDoors[0, 4] = verticalDoor_row0col4;
            WestDoors[0, 5] = verticalDoor_row0col5;

            WestDoors[1, 0] = verticalDoor_row1col0;
            WestDoors[1, 1] = verticalDoor_row1col1;
            WestDoors[1, 2] = verticalDoor_row1col2;
            WestDoors[1, 3] = verticalDoor_row1col3;
            WestDoors[1, 4] = verticalDoor_row1col4;
            WestDoors[1, 5] = verticalDoor_row1col5;

            WestDoors[2, 0] = verticalDoor_row2col0;
            WestDoors[2, 1] = verticalDoor_row2col1;
            WestDoors[2, 2] = verticalDoor_row2col2;
            WestDoors[2, 3] = verticalDoor_row2col3;
            WestDoors[2, 4] = verticalDoor_row2col4;
            WestDoors[2, 5] = verticalDoor_row2col5;

            WestDoors[3, 0] = verticalDoor_row3col0;
            WestDoors[3, 1] = verticalDoor_row3col1;
            WestDoors[3, 2] = verticalDoor_row3col2;
            WestDoors[3, 3] = verticalDoor_row3col3;
            WestDoors[3, 4] = verticalDoor_row3col4;
            WestDoors[3, 5] = verticalDoor_row3col5;

            WestDoors[4, 0] = verticalDoor_row4col0;
            WestDoors[4, 1] = verticalDoor_row4col1;
            WestDoors[4, 2] = verticalDoor_row4col2;
            WestDoors[4, 3] = verticalDoor_row4col3;
            WestDoors[4, 4] = verticalDoor_row4col4;
            WestDoors[4, 5] = verticalDoor_row4col5;

            WestDoors[5, 0] = verticalDoor_row5col0;
            WestDoors[5, 1] = verticalDoor_row5col1;
            WestDoors[5, 2] = verticalDoor_row5col2;
            WestDoors[5, 3] = verticalDoor_row5col3;
            WestDoors[5, 4] = verticalDoor_row5col4;
            WestDoors[5, 5] = verticalDoor_row5col5;
        }

        public void BuildSouthDoorsRectangleArray()
        {

            SouthDoors[0, 0] = flatDoor_row1col0;
            SouthDoors[0, 1] = flatDoor_row1col1;
            SouthDoors[0, 2] = flatDoor_row1col2;
            SouthDoors[0, 3] = flatDoor_row1col3;
            SouthDoors[0, 4] = flatDoor_row1col4;
            SouthDoors[0, 5] = flatDoor_row1col5;

            SouthDoors[1, 0] = flatDoor_row2col0;
            SouthDoors[1, 1] = flatDoor_row2col1;
            SouthDoors[1, 2] = flatDoor_row2col2;
            SouthDoors[1, 3] = flatDoor_row2col3;
            SouthDoors[1, 4] = flatDoor_row2col4;
            SouthDoors[1, 5] = flatDoor_row2col5;

            SouthDoors[2, 0] = flatDoor_row3col0;
            SouthDoors[2, 1] = flatDoor_row3col1;
            SouthDoors[2, 2] = flatDoor_row3col2;
            SouthDoors[2, 3] = flatDoor_row3col3;
            SouthDoors[2, 4] = flatDoor_row3col4;
            SouthDoors[2, 5] = flatDoor_row3col5;

            SouthDoors[3, 0] = flatDoor_row4col0;
            SouthDoors[3, 1] = flatDoor_row4col1;
            SouthDoors[3, 2] = flatDoor_row4col2;
            SouthDoors[3, 3] = flatDoor_row4col3;
            SouthDoors[3, 4] = flatDoor_row4col4;
            SouthDoors[3, 5] = flatDoor_row4col5;

            SouthDoors[4, 0] = flatDoor_row5col0;
            SouthDoors[4, 1] = flatDoor_row5col1;
            SouthDoors[4, 2] = flatDoor_row5col2;
            SouthDoors[4, 3] = flatDoor_row5col3;
            SouthDoors[4, 4] = flatDoor_row5col4;
            SouthDoors[4, 5] = flatDoor_row5col5;

            SouthDoors[5, 0] = flatDoor_row6col0;
            SouthDoors[5, 1] = flatDoor_row6col1;
            SouthDoors[5, 2] = flatDoor_row6col2;
            SouthDoors[5, 3] = flatDoor_row6col3;
            SouthDoors[5, 4] = flatDoor_row6col4;
            SouthDoors[5, 5] = flatDoor_row6col5;

        }


        public void PaintRoomsAndDoors(Room[,] r,int[,] v, int curRow, int curCol)
        {

            ImageBrush brushRoom = new ImageBrush();
            BitmapImage room = new BitmapImage(new Uri(@"https://lh3.googleusercontent.com/-leEjej7SaL4/VQa3h-QaegI/AAAAAAAAAqQ/YKS1YvvMQyw/w506-h532/room%2Btest.jpg"));
            brushRoom.ImageSource = room;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (v[i, j] == 1)
                    {
                        rooms[i, j].Fill = brushRoom;
                        rooms[i, j].Opacity = 0.5;
                        if (v[i, j] == 1 && i == curRow && j == curCol)
                        {
                            rooms[i, j].Fill = brushRoom;
                            rooms[i, j].Opacity = 1;
                        }
                        
                        if (!r[i, j].GetNorthDoor().CanPass())
                        {
                            NorthDoors[i,j].Fill = new SolidColorBrush(Colors.Black);
                        }
                        if (r[i, j].GetNorthDoor().CanPass())
                        {
                            NorthDoors[i, j].Fill = new SolidColorBrush(Colors.White);
                        }


                        if (!r[i, j].GetEastDoor().CanPass())
                        {
                            EastDoors[i, j].Fill = new SolidColorBrush(Colors.Black);
                        }
                        if (r[i, j].GetEastDoor().CanPass())
                        {
                            EastDoors[i, j].Fill = new SolidColorBrush(Colors.White);
                        }


                        if (!r[i, j].GetWestDoor().CanPass())
                        {
                            WestDoors[i, j].Fill = new SolidColorBrush(Colors.Black);
                        }
                        if (r[i, j].GetWestDoor().CanPass())
                        {
                            WestDoors[i, j].Fill = new SolidColorBrush(Colors.White);
                        }


                        if (!r[i, j].GetSouthDoor().CanPass())
                        {
                            SouthDoors[i, j].Fill = new SolidColorBrush(Colors.Black);
                        }
                        if (r[i, j].GetSouthDoor().CanPass())
                        {
                            SouthDoors[i, j].Fill = new SolidColorBrush(Colors.White);
                        }
                    }
                }
            }
        }




        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
