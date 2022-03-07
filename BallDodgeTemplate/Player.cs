using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallDodgeTemplate
{
    class Player
    {
        public int width = 50;
        public int height = 10;
        public int xSpeed, ySpeed;
        public int x, y;

        public Player(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        } 
            
        public void Move(string direction)
        {
           switch(direction)
            {
                case "up":
                    y -= ySpeed;
                    break;
                case "left":
                    x -= xSpeed;
                    break;
                case "down":
                    y += ySpeed;
                    break;
                case "right":
                    x += xSpeed;
                    break;
            }
        }
    }
}
