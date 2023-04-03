using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;


namespace Snake.NET6.Model {
    internal class SnakeElement : ObservableObject {
        
        private int x;

        public int X {
            get { return x; }
            set { SetProperty(ref x, value); }
        }


        private int y;

        public int Y {
            get { return y; }
            set { SetProperty(ref y, value); }
        }

    }
}
