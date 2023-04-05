using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Toolkit.Mvvm.ComponentModel;


namespace Snake.NET6.Model {
    internal class SnakeElement : ObservableObject {

        private bool[,] snakePos;

        public bool[,] SnakePos {
            get { return snakePos; }
            set { snakePos = value; }
        }



        private string direction;

        public string Direction {
            get { return direction; }
            set { direction = value; }
        }

        private int x = 0;

        public int X {
            get { return x; }
            set { SetProperty(ref x, value); }
        }


        private int y = 12;

        public int Y {
            get { return y; }
            set { SetProperty(ref y, value); }
        }

        private Thickness coordinates;

        public Thickness Coordinates {
            get { return coordinates; }
            set { coordinates = value; }
        }

    }
}
