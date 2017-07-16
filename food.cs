using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace snake_game
{
    class food
    {
        private int x, y, w, h;
        private SolidBrush brush;
        public Rectangle foodRec;
        public food(Random ranFood)
        {
            x = ranFood.Next(0, 29) * 10;
            y = ranFood.Next(0, 29) * 10;
            brush = new SolidBrush(Color.Red);
            w = 10; h = 10;
            foodRec = new Rectangle(x, y, w, h);
        }
        public void foodLocation(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
        }
        public void drawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;
            paper.FillEllipse(brush, foodRec);
        }
    }
}
