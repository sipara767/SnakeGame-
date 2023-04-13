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
        public void IncreaseOrDecreaseXYValues(Directions direction) {
            if (direction == Directions.Up) snake.Y++;
            if (direction == Directions.Right) snake.X++;
            if (direction == Directions.Down) snake.Y--;
            if (direction == Directions.Left) snake.X--;
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
    }
}