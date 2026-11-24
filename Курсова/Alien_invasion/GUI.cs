using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Alien_invasion
{
    public class GUI
    {
        bool isOpen = true;
        bool pauseIsOpen = true;
        private Form1 form;
        public GUI(Form1 form1)
        {
            form = form1;
        }
        private Image[] backgrounds =
        {
            Image.FromFile(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Images",
                "BackgroundMenu.png"
            )),
                Image.FromFile(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Images",
                "BackgroundGame.png"
            ))
        };
        public void Open_Menu(bool open = true)
        {
            if (open)
            {
                form.BackgroundImage = backgrounds[0];
                form.startButton.Visible = true;
                form.topScore.Visible = true;
                form.scoreLabel.Visible = false;
                form.HPBar1.Visible = false;
                form.playerPicture.Visible = false;
                form.HPShop.Visible = false;
                form.SpeedShop.Visible = false;
                form.DamageShop.Visible = false;
                form.ShootSpeedShop.Visible = false;
                isOpen = true;
            }
            else
            {
                form.BackgroundImage = backgrounds[1];
                form.startButton.Visible = false;
                form.topScore.Visible = false;
                form.scoreLabel.Visible = true;
                form.HPBar1.Visible = true;
                form.playerPicture.Visible = true;
                form.HPShop.Visible = true;
                form.SpeedShop.Visible = true;
                form.DamageShop.Visible = true;
                form.ShootSpeedShop.Visible = true;
                isOpen = false;
            }
        }
        public void Pause_Menu(bool open = true)
        {
            if (open && !pauseIsOpen)
            {
                if (!isOpen)
                {
                    form.menuButton.Visible = true;
                    form.ContiueButton.Visible = true;
                    pauseIsOpen = true;
                    form.timer.Stop();
                }
            }
            else
            {
                form.menuButton.Visible = false;
                form.ContiueButton.Visible = false;
                pauseIsOpen = false;
                form.timer.Start();
            }

        }
    }
}
