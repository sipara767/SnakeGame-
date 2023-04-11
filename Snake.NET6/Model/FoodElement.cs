using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SnakeNet6.Model {
    internal class FoodElement {
        private Model.FoodElement foodElement;
        public int X { get; set; }
        public int Y { get; set; }

        public void SetFoodPosition() {
            Random rnd = new Random();
            foodElement.X = rnd.Next(25);
            foodElement.Y = rnd.Next(25);
        }
    }
}
