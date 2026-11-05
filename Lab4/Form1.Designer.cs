namespace Lab4
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
            txtInput = new TextBox();
            btnProcess = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnProcessClear = new Button();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(16, 88);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(772, 50);
            txtInput.TabIndex = 2;
            // 
            // btnProcess
            // 
            btnProcess.Font = new Font("Segoe UI", 12F);
            btnProcess.Location = new Point(16, 149);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(772, 72);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Обробити";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 47);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 5;
            label1.Text = "Введіть текст:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(229, 9);
            label2.Name = "label2";
            label2.Size = new Size(334, 30);
            label2.TabIndex = 6;
            label2.Text = "Текстові рядки та символи в C#";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 233);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 7;
            label3.Text = "Результати:";
            // 
            // btnProcessClear
            // 
            btnProcessClear.Font = new Font("Segoe UI", 12F);
            btnProcessClear.Location = new Point(594, 411);
            btnProcessClear.Name = "btnProcessClear";
            btnProcessClear.Size = new Size(194, 27);
            btnProcessClear.TabIndex = 8;
            btnProcessClear.Text = "Очистити";
            btnProcessClear.UseVisualStyleBackColor = true;
            btnProcessClear.Click += btnProcessClear_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(21, 269);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(767, 136);
            txtOutput.TabIndex = 9;
            txtOutput.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOutput);
            Controls.Add(btnProcessClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProcess);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private Button btnProcess;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnProcessClear;
        private TextBox txtOutput;
    }
}
