using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Move()
        {
            x += xSpeed;
            y += ySpeed;

            if(x < 0 || x > GameScreen.gsWidth - size)
            {
                xSpeed = -xSpeed;
            }
            if(y < 0 || y > GameScreen.gsHeight - size)
            {
                ySpeed = -ySpeed;
            }

        }
    }
}
