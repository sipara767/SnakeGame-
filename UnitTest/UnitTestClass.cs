
using SnakeElement;

namespace UnitTest {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void SnakeIsMoving() {
            SnakeClass snake = new SnakeClass();
            snake.X= 1;
            snake.Y= 2;
            snake.IncreaseOrDecreaseXYValues(snake);
            if (snake.X != 1 && snake.Y == 2) {
                Assert.Pass();
            }
        }
    }
}