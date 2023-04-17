using SnakeElement;
using System.Xml.Linq;

namespace EnvironmentElement {
    public class EnvironmentClass {
        public bool[,] EnvironmentMatrix { get; set; }
        public int xLength { get; set; } = 25;
        public int yLength { get; set; } = 25;

        public void ResetEnvironmentMatrixToFalse() {
            for (int i = 0; i < xLength; i++) {
                for (int j = 0; j < yLength; j++) {
                    EnvironmentMatrix[i, j] = false;
                }
            }
        }
        public void PlaceSnakeInEnvironment(SnakeClass snake) {
            EnvironmentMatrix[snake.X, snake.Y] = true;
        }
    }
}