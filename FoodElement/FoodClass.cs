

namespace FoodElement {
    public class FoodClass {
        private FoodClass food;
        public int X { get; set; }
        public int Y { get; set; }
        public void SetFood(int x, int y) {
            Random rnd = new Random();
            int newX;
            int newY;
            do {
                newX = rnd.Next(25);
                newY = rnd.Next(25);
            } while (newX == x && newY == y);
        }
    }
}