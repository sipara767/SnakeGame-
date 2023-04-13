using SnakeElement;
using System.Xml.Linq;

namespace Environment {
    public class EnvironmentClass {
        public bool[,] EnvironmentMatrix { get; set; }
        public void PlaceSnakeInEnvironment(SnakeClass) {
            environmentMatrix[snake.X, snake.Y] = true;
        }
    }
}