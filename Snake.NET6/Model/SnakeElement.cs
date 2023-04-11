using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Xml.Linq;
using Microsoft.Toolkit.Mvvm.ComponentModel;


namespace SnakeNet6.Model {
    internal class SnakeElement {
        private Model.SnakeElement snake;

        private bool[,] position;

        public bool[,] Position { get => position; set => position = value; }

        public void SetSnakePosition(int x, int y) {
            for(int i = 0; i < 25; i++) {
                for (int j = 0; j < 25; j++) {
                    if (i != y && j != y) {
                        snake.Position[i, j] = false;
                    }
                    if (i == x && j == y) {
                        snake.Position[i, j] = true;
                    }

                }
            }
        }
    }
}
