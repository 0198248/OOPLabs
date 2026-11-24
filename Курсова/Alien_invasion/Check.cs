using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class Check
    {
        Form1 form;
        public Check(Form1 Form) 
        { 
            form = Form;
        }
        public void CheckCollisions()
        {
            CheckPlayerCollision(form.player.playerPos, form.aliens);
            CheckBulletCollision(form.bulets.bulletsList, form.aliens);
        }
        private void CheckPlayerCollision(PictureBox player, Aliens aliens)
        {
            for (int i = aliens.aliensList.Count - 1; i >= 0 && aliens.aliensList.Count > 0; i--)
            {
            Alien alien = aliens.aliensList[i];
                if (alien.IsIntersect(player.Bounds))
                {
                    form.player.takeDamage(2);

                }
            }
        }
        private void CheckBulletCollision(List<Bullet> bullets, Aliens aliens)
        {
            for (int i = aliens.aliensList.Count - 1; i >= 0 && aliens.aliensList.Count > 0; i--)
            {
                Alien alien = aliens.aliensList[i];

                for (int c = bullets.Count - 1; c >= 0 && bullets.Count > 0; c--)
                {
                    Rectangle current = bullets[c].rectangle;

                    Rectangle middle = new Rectangle(
                        bullets[c].rectangle.X - (int)(bullets[c].movX/2),
                        bullets[c].rectangle.Y - (int)(bullets[c].movY / 2),
                        5, 5);

                    if (alien.IsIntersect(current) || alien.IsIntersect(middle))
                    {
                        aliens.DealDamage(form.player.damage, i);
                        bullets.RemoveAt(c);

                    }
                }

            }
        }
    }
}
