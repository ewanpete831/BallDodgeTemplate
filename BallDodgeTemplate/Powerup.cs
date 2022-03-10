using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BallDodgeTemplate
{
    class Powerup
    {
        public int id;
        public int size = 10;
        public int fallSpeed = 8;

        public int x, y;

        public Powerup(int _id, int _x, int _y)
        {
            id = _id;
            x = _x;
            y = _y;
        }

        public void move()
        {
            y += fallSpeed;
        }

        public bool Collison(Player p)
        {
            Rectangle ballRect = new Rectangle(x, y, size, size);
            Rectangle playerRect = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRect.IntersectsWith(playerRect))
            { 
                return true;
            }
            return false;
        }
    }
}
