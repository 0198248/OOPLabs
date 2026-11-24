using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class Aliens
    {
        public Form1 form;
        public List<Alien> aliensList = new List<Alien>();
        private bool created = false;
        private Point newPos;
        public Aliens(Form1 Form) 
        { 
            form = Form;
        }
        public void CreateAlien()
        {
            while (!created)
            {
                Point pos = new Point(form.rand.createNum(40, form.Width - 40), form.rand.createNum(40, form.Height - 40));
                if (Math.Abs(pos.X - form.player.playerPos.Location.X) < 400 && Math.Abs(pos.Y - form.player.playerPos.Location.Y) < 400)
                    continue;
                else
                    created = true;
                newPos = pos;
            }
            aliensList.Add(new Alien(newPos,
                (short)form.rand.createNum(1, form.difficulty.alienHP),
                (short)form.rand.createNum(1, form.difficulty.alienMoveSpeed),
                (short)form.rand.createNum(1, form.difficulty.alienDamage)
                ));
            created = false;
        }
        public void RandomAlliansCreate()
        {
            if (form.rand.createNum(1, 100) == 100)
                CreateAlien();
        }
        public void Draw(Graphics g)
        {
            for (int i = aliensList.Count - 1; i >= 0; i--)
            {
                Alien alien = aliensList[i];
                foreach (Rectangle rect in alien.rectangles)
                    g.FillRectangle(Brushes.Green, rect);
            }
        }

        public void AliensMove()
        {
            
            foreach (Alien alien in aliensList)
            {
                if (form.rand.createNum(1, 3) == 3)
                    alien.AlienMove(form.player.playerPos.Location);
            }
        }

        public void DeleteAliens()
        {
            aliensList.Clear();
        }
        public void DealDamage(short value, int pos)
        {
            Alien alien = aliensList[pos];

            alien.TakeDamage(value);
            if (alien.HP <= 0)
            {
                aliensList.RemoveAt(pos);
                form.player.addScore();
            }
        }
    }
}
