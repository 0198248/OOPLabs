using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Windows.Forms;

namespace Alien_invasion
{
    public partial class Form1 : Form
    {
        private GUI gui;
        public Player player;
        public System.Windows.Forms.Timer timer;
        public int biggestScore;
        public Bulets bulets;
        public randomizer rand;
        public Aliens aliens;
        public Check check;
        public Difficulty difficulty;
        private Shop shop;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            gui = new GUI(this);
            player = new Player(playerPicture, this);
            player.PlayerDeath += Death;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            this.KeyUp += Form1_KeyUp;
            this.Paint += Form1_Paint;
            bulets = new Bulets();
            rand = new randomizer();
            aliens = new Aliens(this);
            check = new Check(this);
            difficulty = new Difficulty(rand);
            shop = new Shop(this);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.KeyPreview = true;
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            bulets.Draw(e.Graphics);
            aliens.Draw(e.Graphics);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            scoreLabel.Text = "Рахунок: " + player.score.ToString();
            HPBar1.Maximum = player.MaxHP;
            HPBar1.Value = player.HP;
            player.regenerate();
            player.move();
            player.PlayerShoot();
            aliens.AliensMove();

            aliens.RandomAlliansCreate();
            difficulty.DifficultyTick();
            check.CheckCollisions();
            bulets.MoveBullets();
            this.Invalidate();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            difficulty.SetNormalDifficulty();
            player.SetValues();
            shop.SetValues();
            gui.Open_Menu(false);
            timer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) gui.Pause_Menu();
            if (e.KeyCode == Keys.W) player.facingY = 1;
            if (e.KeyCode == Keys.S) player.facingY = 2;
            if (e.KeyCode == Keys.A) player.facingX = 1;
            if (e.KeyCode == Keys.D) player.facingX = 2;
            if (e.KeyCode == Keys.F) aliens.CreateAlien();

            if (e.KeyCode == Keys.X) shop.BuyDamage();
            if (e.KeyCode == Keys.C) shop.BuyHP();
            if (e.KeyCode == Keys.V) shop.BuySpeed();
            if (e.KeyCode == Keys.Z) shop.BuyShootSpeed();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) player.facingY = 0;
            if (e.KeyCode == Keys.S) player.facingY = 0;
            if (e.KeyCode == Keys.A) player.facingX = 0;
            if (e.KeyCode == Keys.D) player.facingX = 0;
        }

        private void Death()
        {
            if (player.score > biggestScore)
            {
                this.topScore.Text = "Рекорд: " + player.score.ToString();
                biggestScore = player.score;
            }
            timer.Stop();
            bulets.DeleteBulets();
            aliens.DeleteAliens();
            gui.Open_Menu();
            player.SetValues();
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            Death();
            gui.Pause_Menu(false);
            timer.Stop();
            gui.Open_Menu();

        }

        private void ContiueButton_Click(object sender, EventArgs e)
        {
            gui.Pause_Menu(false);
        }
    }
}
