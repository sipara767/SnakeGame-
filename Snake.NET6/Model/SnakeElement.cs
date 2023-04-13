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
    public class SnakeElement {
        private Model.SnakeElement snake;

        public int Score { get; set; }
        public bool Alive { get; set; } = true;

        public Directions currentDirection { get; set; }

        public enum Directions {
            Up, Right, Down, Left
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Move(Directions direction) {
            if (direction == Directions.Up) snake.Y++;
            if (direction == Directions.Right) snake.X++;
            if (direction == Directions.Down) snake.Y--;
            if (direction == Directions.Left) snake.X--;
        }

        public void MoveUp() {
            snake.currentDirection = Directions.Up;
        }
        public void MoveRight() {
            snake.currentDirection = Directions.Right;
        }
        public void MoveDown() {
            snake.currentDirection = Directions.Down;
        }
        public void MoveLeft() {
            snake.currentDirection=Directions.Left;
        }


        //Alte Idee
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
