using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SnakeNet6.Model {
    internal class FoodElement {
        private int[] position;

        public int[] Position { get => position; set => position = value; }

        public void SetFoodPosition() {
            Random rnd = new Random();
            Position[0] = rnd.Next(25);
            Position[1] = rnd.Next(25);
        }
    }
}
