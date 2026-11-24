using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class Alien
    {
        public Rectangle[] rectangles = new Rectangle[6];
        public short HP;
        public Point position;
        private short moveSpeed;
        public short damage;
        public Alien(Point pos, short HP1, short MoveSpeed, short Damage) 
        {
            position = pos;

            rectangles[0] = (new Rectangle(position.X + 10, position.Y, 20, 10));
            rectangles[1] = (new Rectangle(position.X, position.Y + 10, 40, 20));
            rectangles[2] = (new Rectangle(position.X + 5, position.Y + 30, 10, 10));
            rectangles[3] = (new Rectangle(position.X + 25, position.Y + 30, 10, 10));

            rectangles[4] = (new Rectangle(position.X + 8, position.Y + 15, 8, 8));
            rectangles[5] = (new Rectangle(position.X + 24, position.Y + 15, 8, 8));

            HP = HP1;
            moveSpeed = MoveSpeed;
            damage = Damage;

        }
        public void AlienMove(Point playerPos)
        {
            float dx = playerPos.X - position.X;
            float dy = playerPos.Y - position.Y;


            float distance = MathF.Sqrt(dx * dx + dy * dy);
            short moveX = (short)MathF.Round((dx / distance) * moveSpeed);
            short moveY = (short)MathF.Round((dy / distance) * moveSpeed);
            position.X += moveX;
            position.Y += moveY;
            for (int i = 0; i < rectangles.Length; i++)
            {
                Rectangle rect = rectangles[i];
                rect.X += moveX;
                rect.Y += moveY;
                rectangles[i] = rect;
            }
        }
        public void TakeDamage(short damage)
        {
            HP -= damage;
        }
        public bool IsIntersect(Rectangle rect) 
        {
            foreach (Rectangle alienRect in rectangles)
            {
                if (alienRect.IntersectsWith(rect))
                    return true;
            }

            return false;
        }
    }
}
