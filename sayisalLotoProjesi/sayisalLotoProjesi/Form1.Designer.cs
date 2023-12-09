namespace sayisalLotoProjesi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 50);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 0;
            label1.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 50);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 28);
            label2.TabIndex = 1;
            label2.Text = "--";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 50);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 28);
            label3.TabIndex = 2;
            label3.Text = "--";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 50);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 28);
            label4.TabIndex = 3;
            label4.Text = "--";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 36);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 36);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(257, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 36);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(388, 106);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 36);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Location = new Point(182, 173);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 8;
            button1.Text = "Oyna";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(27, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 221);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toto";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(588, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 160);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Captcha Kullanımı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 55);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 0;
            label5.Text = "label5";
            // 
            // button2
            // 
            button2.Location = new Point(64, 96);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 630);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label5;
    }
}