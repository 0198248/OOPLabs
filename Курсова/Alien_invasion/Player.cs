using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class Player
    {
        public event PlayerDeathEventHandler PlayerDeath;
        private Form1 form;
        public int score;
        public int HP;
        public int MaxHP;
        private int regen;
        private short moveSpeed;
        public short facingY; // 1 - up, 2 - down         
        public short facingX; // 1 - left, 2 - right
        private int delayShoot;
        private int delayShootV;
        public bool playerIsAlive;
        public short damage;
        public PictureBox playerPos;

        public void PlayerShoot()
        {
            if (delayShoot <= 0)
            {
                form.bulets.SpawnBulet(playerPos.Location, form.PointToClient(Cursor.Position));
                delayShoot = delayShootV;
            }
            else
                delayShoot--;
        }
        public void SetValues()
        {
            score = 0;
            HP = 100;
            MaxHP = 100;
            regen = 1;
            moveSpeed = 5;
            facingY = 0;
            facingX = 0;
            delayShoot = 10;
            delayShootV = 10;
            playerPos.Location = new Point(640, 360);
            playerIsAlive = true;
            damage = 1;
        } 
        public Player(PictureBox PlayerPos, Form1 Form)
        {
            playerPos = PlayerPos;
            SetValues();
            form = Form;
        }
        public void IncreaseMoveSpeed(short value = 1)
        {
            if (value > 0 && moveSpeed < 30)
            {
                moveSpeed += value;
            }
        }
        public void IncreaseShootSpeed(short value = 1)
        {
            if (value > 0 && delayShootV > 1)
            {
                delayShootV -= value;
            }
        }
        public void IncreaseRegenSpeed(short value = 1)
        {
            if (value > 0 && regen < 20)
            {
                regen += (int)value;
            }
        }
        public void IncreaseHP(short value = 10)
        {
            if (value > 0 && MaxHP < 300)
            {
                MaxHP += (int)value;
            }
        }

        public void IncreaseDamage(short value = 1)
        {
            if (value > 0 && damage < 20)
            {
                damage += value;
            }
        }

        public void addScore()
        {
            if (form.difficulty.scorePerAlien > 0)
            {
                score += form.difficulty.scorePerAlien;
            }
        }
        public void takeDamage(int value)
        {
            if (value > 0)
            {
                HP -= value;
                if (HP <= 0)
                {
                    playerIsAlive = false;
                    PlayerDeath();
                }
            }
        }
        public void regenerate()
        {
            if (regen > 0)
            {
                HP += regen;
                if (HP > MaxHP)
                {
                    HP = MaxHP;
                }
            }
        }
        public void move() 
        {
            if (facingY == 1)
            {
                if (playerPos.Top > 0)
                    playerPos.Location = new Point(
                    playerPos.Location.X,
                    playerPos.Location.Y - moveSpeed
                    );
            }
            else if (facingY == 2)
            {
                if (playerPos.Bottom < 720)
                    playerPos.Location = new Point(
                    playerPos.Location.X,
                    playerPos.Location.Y + moveSpeed
                    );
            }
            if (facingX == 1)
            {
                if (playerPos.Left > 0)
                    playerPos.Location = new Point(
                    playerPos.Location.X - moveSpeed,
                    playerPos.Location.Y
                    );
            }
            else if (facingX == 2)
            {
                if (playerPos.Right < 1280)
                    playerPos.Location = new Point(
                    playerPos.Location.X + moveSpeed,
                    playerPos.Location.Y
                    );
            }
        }
    }
}
