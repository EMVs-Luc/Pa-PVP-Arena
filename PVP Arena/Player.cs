using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace PVP_Arena
{
    class Player
    {

        static int speed = 10;

        Direction dir;

        public int health = 100;
         Panel player;


        public Player(Panel playerPanel)
        {
            player = playerPanel;
        }

        public void walk(Direction dir)
        {
            this.dir = dir;
            int minX = player.Location.X;
            int maxX = player.Location.X+ player.Width;
            int minY = player.Location.Y;
            int maxY = player.Location.Y + player.Height;


            int addX = 0;
            int addY = 0;
            if (dir == Direction.FORWART)
            {
                addY -= speed;
            } else if (dir == Direction.RIGHT)
            {

                addX += speed;
            }
            else if (dir == Direction.BACKWART)
            {

                addY += speed;
            }
            else if (dir == Direction.LEFT)
            {

                addX -= speed;
            }

            if(minX + addX >= Arena.xMin && maxX + addX <= Arena.xMax && minY + addY >= Arena.yMin && maxY + addY <= Arena.yMax)
            {
                player.Location = new System.Drawing.Point(minX + addX, minY + addY);
                player.Update();
            }
            else if(minX + addX < Arena.xMin)
            {
                player.Location = new System.Drawing.Point(Arena.xMin, minY + addY);
            }else if (minY + addY < Arena.yMin)
            {
                player.Location = new System.Drawing.Point(minX + addX, Arena.yMin);
            }
            else if (maxX + addX < Arena.xMax)
            {
                player.Location = new System.Drawing.Point(Arena.xMax - player.Width, minY + addY);
            }
            else if (maxY + addY < Arena.yMax)
            {
                player.Location = new System.Drawing.Point(minX + addX, Arena.yMax - player.Height);
            }

        }


    }
}
