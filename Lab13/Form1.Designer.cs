namespace WeatherFileApp
{
    partial class MainForm
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
            City = new Label();
            label1 = new Label();
            label3 = new Label();
            statusLabel = new Label();
            label5 = new Label();
            CityName = new TextBox();
            temperatureText = new TextBox();
            humidityText = new TextBox();
            timeText = new TextBox();
            loadButton = new Button();
            openButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // City
            // 
            City.AutoSize = true;
            City.Font = new Font("Segoe UI", 14F);
            City.Location = new Point(647, 49);
            City.Name = "City";
            City.Size = new Size(62, 25);
            City.TabIndex = 0;
            City.Text = "Місто";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(36, 147);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Температура";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(592, 147);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 0;
            label3.Text = "Час спостереження";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 14F);
            statusLabel.Location = new Point(29, 257);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(155, 25);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Ще немає даних";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(305, 147);
            label5.Name = "label5";
            label5.Size = new Size(176, 25);
            label5.TabIndex = 0;
            label5.Text = "Відносна вологість";
            // 
            // CityName
            // 
            CityName.Font = new Font("Segoe UI", 14F);
            CityName.ForeColor = SystemColors.WindowText;
            CityName.Location = new Point(615, 93);
            CityName.Name = "CityName";
            CityName.ReadOnly = true;
            CityName.Size = new Size(132, 32);
            CityName.TabIndex = 1;
            CityName.TextAlign = HorizontalAlignment.Center;
            // 
            // temperatureText
            // 
            temperatureText.Font = new Font("Segoe UI", 14F);
            temperatureText.ForeColor = SystemColors.WindowText;
            temperatureText.Location = new Point(29, 189);
            temperatureText.Name = "temperatureText";
            temperatureText.ReadOnly = true;
            temperatureText.Size = new Size(132, 32);
            temperatureText.TabIndex = 1;
            temperatureText.TextAlign = HorizontalAlignment.Center;
            // 
            // humidityText
            // 
            humidityText.Font = new Font("Segoe UI", 14F);
            humidityText.ForeColor = SystemColors.WindowText;
            humidityText.Location = new Point(326, 189);
            humidityText.Name = "humidityText";
            humidityText.ReadOnly = true;
            humidityText.Size = new Size(132, 32);
            humidityText.TabIndex = 1;
            humidityText.TextAlign = HorizontalAlignment.Center;
            // 
            // timeText
            // 
            timeText.Font = new Font("Segoe UI", 14F);
            timeText.ForeColor = SystemColors.WindowText;
            timeText.Location = new Point(572, 189);
            timeText.Name = "timeText";
            timeText.ReadOnly = true;
            timeText.Size = new Size(216, 32);
            timeText.TabIndex = 1;
            timeText.TextAlign = HorizontalAlignment.Center;
            // 
            // loadButton
            // 
            loadButton.FlatStyle = FlatStyle.System;
            loadButton.Font = new Font("Segoe UI", 14F);
            loadButton.Location = new Point(615, 386);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(173, 52);
            loadButton.TabIndex = 2;
            loadButton.Text = "Оновити";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // openButton
            // 
            openButton.Enabled = false;
            openButton.FlatStyle = FlatStyle.System;
            openButton.Font = new Font("Segoe UI", 14F);
            openButton.Location = new Point(420, 386);
            openButton.Name = "openButton";
            openButton.Size = new Size(173, 52);
            openButton.TabIndex = 2;
            openButton.Text = "Завантажити";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.System;
            saveButton.Font = new Font("Segoe UI", 14F);
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(224, 386);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(173, 52);
            saveButton.TabIndex = 2;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(openButton);
            Controls.Add(loadButton);
            Controls.Add(timeText);
            Controls.Add(humidityText);
            Controls.Add(temperatureText);
            Controls.Add(CityName);
            Controls.Add(label1);
            Controls.Add(statusLabel);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(City);
            Font = new Font("Segoe UI", 9F);
            Name = "MainForm";
            Text = "Погода";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label City;
        private Label label1;
        private Label label3;
        private Label statusLabel;
        private Label label5;
        private TextBox CityName;
        private TextBox temperatureText;
        private TextBox humidityText;
        private TextBox timeText;
        private Button loadButton;
        private Button openButton;
        private Button saveButton;
    }
}
