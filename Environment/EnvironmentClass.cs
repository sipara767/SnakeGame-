using SnakeElement;
using System.Xml.Linq;

namespace Environment {
    public class EnvironmentClass {
        private const int MatrixSize = 25;
        public bool[,] EnvironmentMatrix { get; set; }
        public EnvironmentClass()
        {
            EnvironmentMatrix = new bool[MatrixSize,MatrixSize];
            ResetEnvironmentMatrixToFalse();
        }
        public void ResetEnvironmentMatrixToFalse() {
            for (int i = 0; i < MatrixSize; i++) {
                for (int j = 0; j < MatrixSize; j++) {
                    EnvironmentMatrix[i, j] = false;
                }
            }
        }
        public void PlaceSnakeInEnvironment(SnakeClass snake) {
            EnvironmentMatrix[snake.X, snake.Y] = true;
        }
    }
}