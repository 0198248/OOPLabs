namespace Alien_invasion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            startButton = new Button();
            topScore = new Label();
            ContiueButton = new Button();
            menuButton = new Button();
            scoreLabel = new Label();
            HPBar1 = new ProgressBar();
            playerPicture = new PictureBox();
            DamageShop = new Label();
            HPShop = new Label();
            SpeedShop = new Label();
            ShootSpeedShop = new Label();
            ((System.ComponentModel.ISupportInitialize)playerPicture).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.GradientInactiveCaption;
            startButton.Font = new Font("Segoe UI", 30F);
            startButton.ForeColor = SystemColors.ControlText;
            startButton.Location = new Point(503, 229);
            startButton.Name = "startButton";
            startButton.RightToLeft = RightToLeft.No;
            startButton.Size = new Size(300, 75);
            startButton.TabIndex = 0;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // topScore
            // 
            topScore.AutoSize = true;
            topScore.BackColor = SystemColors.ActiveBorder;
            topScore.Font = new Font("Segoe UI", 14F);
            topScore.Location = new Point(605, 327);
            topScore.Name = "topScore";
            topScore.Size = new Size(78, 25);
            topScore.TabIndex = 1;
            topScore.Text = "Рекорд:";
            // 
            // ContiueButton
            // 
            ContiueButton.BackColor = SystemColors.GradientInactiveCaption;
            ContiueButton.Font = new Font("Segoe UI", 30F);
            ContiueButton.ForeColor = SystemColors.ControlText;
            ContiueButton.Location = new Point(503, 229);
            ContiueButton.Name = "ContiueButton";
            ContiueButton.RightToLeft = RightToLeft.No;
            ContiueButton.Size = new Size(300, 75);
            ContiueButton.TabIndex = 2;
            ContiueButton.Text = "Продовжити";
            ContiueButton.UseVisualStyleBackColor = false;
            ContiueButton.Visible = false;
            ContiueButton.Click += ContiueButton_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = SystemColors.GradientInactiveCaption;
            menuButton.Font = new Font("Segoe UI", 30F);
            menuButton.ForeColor = SystemColors.ControlText;
            menuButton.Location = new Point(503, 327);
            menuButton.Name = "menuButton";
            menuButton.RightToLeft = RightToLeft.No;
            menuButton.Size = new Size(300, 75);
            menuButton.TabIndex = 2;
            menuButton.Text = "Меню";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Visible = false;
            menuButton.Click += menuButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = SystemColors.ActiveBorder;
            scoreLabel.Font = new Font("Segoe UI", 14F);
            scoreLabel.Location = new Point(21, 18);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(82, 25);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Рахунок";
            scoreLabel.Visible = false;
            // 
            // HPBar1
            // 
            HPBar1.Location = new Point(503, 18);
            HPBar1.Name = "HPBar1";
            HPBar1.Size = new Size(300, 23);
            HPBar1.TabIndex = 4;
            HPBar1.Value = 100;
            HPBar1.Visible = false;
            // 
            // playerPicture
            // 
            playerPicture.BackColor = Color.Transparent;
            playerPicture.BackgroundImageLayout = ImageLayout.None;
            playerPicture.Image = (Image)resources.GetObject("playerPicture.Image");
            playerPicture.Location = new Point(583, 246);
            playerPicture.Name = "playerPicture";
            playerPicture.Size = new Size(75, 106);
            playerPicture.SizeMode = PictureBoxSizeMode.Zoom;
            playerPicture.TabIndex = 5;
            playerPicture.TabStop = false;
            playerPicture.Visible = false;
            // 
            // DamageShop
            // 
            DamageShop.AutoSize = true;
            DamageShop.BackColor = Color.Transparent;
            DamageShop.Font = new Font("Segoe UI", 12F);
            DamageShop.Location = new Point(21, 651);
            DamageShop.Name = "DamageShop";
            DamageShop.Size = new Size(133, 21);
            DamageShop.TabIndex = 6;
            DamageShop.Text = "+Пошкодження: ";
            DamageShop.Visible = false;
            // 
            // HPShop
            // 
            HPShop.AutoSize = true;
            HPShop.BackColor = Color.Transparent;
            HPShop.Font = new Font("Segoe UI", 12F);
            HPShop.Location = new Point(21, 630);
            HPShop.Name = "HPShop";
            HPShop.Size = new Size(93, 21);
            HPShop.TabIndex = 6;
            HPShop.Text = "+Здоров'я: ";
            HPShop.Visible = false;
            // 
            // SpeedShop
            // 
            SpeedShop.AutoSize = true;
            SpeedShop.BackColor = Color.Transparent;
            SpeedShop.Font = new Font("Segoe UI", 12F);
            SpeedShop.Location = new Point(21, 609);
            SpeedShop.Name = "SpeedShop";
            SpeedShop.Size = new Size(103, 21);
            SpeedShop.TabIndex = 6;
            SpeedShop.Text = "+Швидкість: ";
            SpeedShop.Visible = false;
            // 
            // ShootSpeedShop
            // 
            ShootSpeedShop.AutoSize = true;
            ShootSpeedShop.BackColor = Color.Transparent;
            ShootSpeedShop.Font = new Font("Segoe UI", 12F);
            ShootSpeedShop.Location = new Point(21, 588);
            ShootSpeedShop.Name = "ShootSpeedShop";
            ShootSpeedShop.Size = new Size(168, 21);
            ShootSpeedShop.TabIndex = 6;
            ShootSpeedShop.Text = "+Швидкість стрільби: ";
            ShootSpeedShop.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 681);
            Controls.Add(ShootSpeedShop);
            Controls.Add(SpeedShop);
            Controls.Add(HPShop);
            Controls.Add(DamageShop);
            Controls.Add(playerPicture);
            Controls.Add(HPBar1);
            Controls.Add(scoreLabel);
            Controls.Add(menuButton);
            Controls.Add(ContiueButton);
            Controls.Add(topScore);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Alien invasion game";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)playerPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button startButton;
        public Label topScore;
        public Button ContiueButton;
        public Button menuButton;
        public Label scoreLabel;
        public ProgressBar HPBar1;
        public PictureBox playerPicture;
        public Label DamageShop;
        public Label HPShop;
        public Label SpeedShop;
        private Label label1;
        public Label ShootSpeedShop;
    }
}
