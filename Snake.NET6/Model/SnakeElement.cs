using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Toolkit.Mvvm.ComponentModel;


namespace Snake.NET6.Model {
    internal class SnakeElement : ObservableObject {
        
        private int x = 10;

        public int X {
            get { return x; }
            set { SetProperty(ref x, value); }
        }


        private int y = 10;

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
