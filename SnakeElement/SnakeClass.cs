using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;
using System.Xml.Linq;

namespace SnakeElement {
    public class SnakeClass {
        private SnakeClass snake;
        public int Score { get; set; }
        public bool IsAlive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public enum Directions {
            Up, Down, Left, Right
        }
        public Directions CurrentDirection { get; set; }
        public void IncreaseOrDecreaseXYValues(SnakeClass snake) {
            if (snake.CurrentDirection == Directions.Up) snake.Y++;
            if (snake.CurrentDirection == Directions.Right) snake.X++;
            if (snake.CurrentDirection == Directions.Down) snake.Y--;
            if (snake.CurrentDirection == Directions.Left) snake.X--;
        }
        public void SetDirectionUp() {
            snake.CurrentDirection= Directions.Up;
        }
        public void SetDirectionRight() {
            snake.CurrentDirection= Directions.Right;
        }
        public void SetDirectionDown() {
            snake.CurrentDirection= Directions.Down;
        }
        public void SetDirectionLeft() {
            snake.CurrentDirection= Directions.Left;
        }
        public void IsSnakeInsideBound() {
            if (snake.X < 26 || snake.Y < 26) ;
            else snake.IsAlive = false;
        }
    }
}