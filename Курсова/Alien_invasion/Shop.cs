using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class Shop
    {
        private Player player;
        private Form1 form;
        private int damagePrice;
        private int HPPrice;
        private int speedPrice;
        private int shootSpeedPrice;
        private float priceChange;

        public Shop(Form1 form1)
        {
            form = form1;
            player = form.player;
            SetValues();
        }
        public void SetValues()
                    {
            damagePrice = 50;
            HPPrice = 50;
            speedPrice = 50;
            priceChange = 1.25f;
            shootSpeedPrice = 150;
            UpdatePriceGui();
        }

        public void BuyDamage()
        {
            if (player.score >= this.damagePrice)
            {
                player.score -= this.damagePrice;
                player.IncreaseDamage();
                this.damagePrice = (int)(this.damagePrice * this.priceChange);
                form.DamageShop.Text = "+ Пошкодження(x): " + this.damagePrice.ToString();
            }
        }
        public void BuyShootSpeed()
        {
            if (player.score >= this.shootSpeedPrice)
            {
                player.score -= this.shootSpeedPrice;
                player.IncreaseShootSpeed();
                this.shootSpeedPrice = (int)(this.shootSpeedPrice * this.priceChange);
                form.ShootSpeedShop.Text = "+ Швидкість стрільби(z): " + this.shootSpeedPrice.ToString();
            }
        }
        public void BuyHP()
        {
            if (player.score >= this.HPPrice)
            {
                player.score -= this.HPPrice;
                player.IncreaseHP((short)10);
                this.HPPrice = (int)(this.HPPrice * this.priceChange);
                form.HPShop.Text = "+ Здоров'я(c): " + this.HPPrice.ToString();
            }
        }
        public void BuySpeed()
        {
            if (player.score >= this.speedPrice)
            {
                player.score -= this.speedPrice;
                player.IncreaseMoveSpeed();
                this.speedPrice = (int)(this.speedPrice * this.priceChange);
                form.SpeedShop.Text = "+ Швидкість(v): " + this.speedPrice.ToString();
            }
        }

        public void UpdatePriceGui()
        {
            form.DamageShop.Text = "+ Пошкодження(x): " + this.damagePrice.ToString();
            form.HPShop.Text = "+ Здоров'я(c): " + this.HPPrice.ToString();
            form.SpeedShop.Text = "+ Швидкість(v): " + this.speedPrice.ToString();
            form.ShootSpeedShop.Text = "+ Швидкість стрільби(z): " + this.shootSpeedPrice.ToString();
        }
    }
}
