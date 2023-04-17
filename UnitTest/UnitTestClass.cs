using FoodElement;
using SnakeElement;

namespace UnitTest {
    public class Tests {
        [SetUp]
        public void Setup() {
        }
        private SnakeClass snake;
        private FoodClass food;
        [Test]
        public void SnakeIsMoving() {
            snake.X= 1;
            snake.Y= 2;
            snake.IncreaseOrDecreaseXYValues(snake);
            if (snake.X != 1 && snake.Y == 2) { Assert.Pass(); }
        }

        [Test]
        public void SnakeAteFood() {
            food.X = 2;
            food.Y = 2;
            snake.X = 1;
            snake.Y = 2;
            snake.CurrentDirection = SnakeClass.Directions.Right;
            snake.IncreaseOrDecreaseXYValues(snake);
            if (snake.Score == 1) { Assert.Pass();}
        }
        [Test]
        public void SnakeIsOutOfBound() {
            snake.CurrentDirection= SnakeClass.Directions.Right;
            snake.IncreaseOrDecreaseXYValues(snake);
        }
    }
}