using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            
        public void Move(string direction, Size ss)
        {
           switch(direction)
            {
                case "up":
                        y -= ySpeed;

                    if(y < 0)
                    {
                        y = 0;
                    }

                    break;
                case "left":
                        x -= xSpeed;

                    if(x < 0)
                    {
                        x = 0;
                    }
                    break;
                case "down":
                        y += ySpeed;   

                    if(y > ss.Height - height)
                    {
                        y = ss.Height - height;
                    }    
                    break;
                case "right":
                        x += xSpeed;

                    if(x > ss.Width - width)
                    {
                        x = ss.Width - width;
                    }
                    break;
            }
        }
    }
}
