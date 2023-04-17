
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

        [Test]
        public void SnakeAteFood() {
            FoodElement food = new FoodElement();
            food.X = 2;
            food.Y = 2;
            SnakeClass snake = new SnakeClass();
            snake.X = 1;
            snake.Y = 2;
            snake.CurrentDirection = SnakeClass.Directions.Right;
            snake.IncreaseOrDecreaseXYValues(snake);

        }
    }
}