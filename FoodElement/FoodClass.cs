

namespace FoodElement {
    public class FoodClass {
        
        public int X { get; set; }
        public int Y { get; set; }
        public FoodClass(bool[,] gameBord)
        {
            GenerateRandomPosition(gameBord)
        }
        public void GenerateRandomPosition(bool[,] gameBord)
        {
            Random rnd = new Random();
            int boardsize = gameBord.GetLength(0)
            int x;
            int y;
            do {
                X = rnd.Next(boardsize);
                Y = rnd.Next(boardsize);
            } while (gameBord[x,y]);
            X = x;
            Y = y
        }
    }
}