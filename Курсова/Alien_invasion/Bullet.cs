using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class Bullet
    {
        public Rectangle rectangle;
        public short movX, movY;

        public Bullet(Rectangle Position, short moveX, short moveY)
        {
            rectangle = Position;
            movX = moveX;
            movY = moveY;
        }

        public void BulletMove()
        {
            rectangle.X += movX;
            rectangle.Y += movY;
        }

        
    }
    
}
