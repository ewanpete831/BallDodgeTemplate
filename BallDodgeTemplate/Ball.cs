using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BallDodgeTemplate
{
    class Ball
    {
        public int size = 10;
        public int xSpeed, ySpeed;
        public int x, y;

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            x = _x;
            y = _y;
        }

        public void Move(Size ss)
        {
            x += xSpeed;
            y += ySpeed;

            if (x < 0 || x > ss.Width - size)
            {
                xSpeed = -xSpeed;
            }
            if (y < 0 || y > ss.Height - size)
            {
                ySpeed = -ySpeed;
            }

            if (y < 0)
            {
                y += 1;
            }
            if (y > ss.Height)
            {
                y -= 1;
            }
        }

        public bool Collison(Player p)
        {
            Rectangle ballRect = new Rectangle(x, y, size, size);
            Rectangle playerRect = new Rectangle(p.x, p.y, p.width, p.height);

            if(ballRect.IntersectsWith(playerRect))
            {
                if(ySpeed > 0)
                {
                    y = p.y - size;
                }
                else
                {
                    y = p.y + p.height;
                }

                ySpeed *= -1;
                return true;
            }
            return false;
        }
    }
}
