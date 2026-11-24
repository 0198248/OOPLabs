using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class Bulets
    {
        short speed = 16;
        public List<Bullet> bulletsList = new List<Bullet>();

        public void SpawnBulet(Point pos, Point mousePos)
        {
            pos.X += 60; pos.Y += 60;
            float dx = mousePos.X - pos.X;
            float dy = mousePos.Y - pos.Y;

            float distance = MathF.Sqrt(dx * dx + dy * dy);

            short moveX = (short)MathF.Round(dx / distance * speed);
            short moveY = (short)MathF.Round(dy / distance * speed);

            bulletsList.Add(new Bullet(new Rectangle(pos.X, pos.Y, 5, 5), moveX, moveY));
        }
        public void Draw(Graphics g)
        {
            for (int i = bulletsList.Count - 1; i >= 0; i--)
            {
                Bullet bullet = bulletsList[i];
                g.FillEllipse(Brushes.White, bullet.rectangle);
            }
        }
        public void MoveBullets()
        {
            for (int i = bulletsList.Count - 1; i >= 0; i--)
            {
                Bullet bullet = bulletsList[i];
                if (bullet.rectangle.X < 0 || bullet.rectangle.Y < 0 || bullet.rectangle.X > 1280 || bullet.rectangle.Y > 720)
                {
                    bulletsList.RemoveAt(i);
                }
                else
                {
                    bullet.BulletMove();
                }
            }
        }
        public void DeleteBulets()
        {
            bulletsList.Clear();
        }
    }
}
