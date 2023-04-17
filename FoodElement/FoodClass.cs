

using EnvironmentElement;
using SnakeElement;

namespace FoodElement {
    public class FoodClass {
        private FoodClass food;
        private EnvironmentClass evm;
        private SnakeClass snake;
        public int X { get; set; }
        public int Y { get; set; }
        public void SetFood() {
            Random rnd = new Random();
            int newX;
            int newY;
            do {
                newX = rnd.Next(evm.xLength - 1);
                newY = rnd.Next(evm.yLength - 1);
            } while (newX == snake.X|| newY == snake.Y);
            food.X = newX;
            food.Y = newY;
        }
    }
}