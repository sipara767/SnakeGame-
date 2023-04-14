using SnakeElement;
using System.Xml.Linq;

namespace Environment {
    public class EnvironmentClass {
        public bool[,] EnvironmentMatrix { get; set; }
        public void ResetEnvironmentMatrixToFalse() {
            for (int i = 0; i < 25; i++) {
                for (int j = 0; j < 25; j++) {
                    EnvironmentMatrix[i, j] = false;
                }
            }
        }
        public void PlaceSnakeInEnvironment(SnakeClass snake) {
            EnvironmentMatrix[snake.X, snake.Y] = true;
        }
    }
}