namespace project1
{
    partial class WorkoutPlan
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
            panel1 = new Panel();
            label1 = new Label();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            checkBox2 = new CheckBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            checkBox3 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -12);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 109);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(274, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 2;
            label1.Text = "WORKOUT PLAN\r\n";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.YellowGreen;
            checkBox1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.ImageAlign = ContentAlignment.TopCenter;
            checkBox1.Location = new Point(25, 214);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(144, 30);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Weight Loss";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "High-Intensity Interval", "Cardiovascular", "Strength", "Yoga", "Circuit" });
            comboBox1.Location = new Point(48, 391);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.IndianRed;
            checkBox2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.White;
            checkBox2.ImageAlign = ContentAlignment.TopCenter;
            checkBox2.Location = new Point(301, 214);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(146, 30);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Muscle Gain";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Strength", "Powerlifting", "Bodybuilding", "CrossFit", "Progressive Overload" });
            comboBox2.Location = new Point(312, 391);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(330, 473);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 8;
            button2.Text = "START";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 247);
            label2.Name = "label2";
            label2.Size = new Size(213, 105);
            label2.TabIndex = 9;
            label2.Text = "Join our weight loss program\r\n for tailored HIIT workouts\r\nand personalized nutrition\r\n plans. Shed excess weight\r\n and embrace a fitter you!";
            label2.Click += label2_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleVioletRed;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(301, 247);
            label3.Name = "label3";
            label3.Size = new Size(193, 126);
            label3.TabIndex = 10;
            label3.Text = "Build lean muscle with our\r\n targeted strength training\r\n and optimized nutrition.\r\n Get ready to sculpt your\r\n physique and unleash\r\n your full potential!";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.SteelBlue;
            checkBox3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.ForeColor = Color.White;
            checkBox3.ImageAlign = ContentAlignment.TopCenter;
            checkBox3.Location = new Point(565, 214);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 30);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Custom";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.CadetBlue;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(565, 247);
            label4.Name = "label4";
            label4.Size = new Size(150, 147);
            label4.TabIndex = 12;
            label4.Text = "Create your custom\r\n workout plan.\r\n Choose exercises,\r\n set intensity,\r\n and track progress. \r\nFitness, simplified,\r\n your way!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(261, 141);
            label5.Name = "label5";
            label5.Size = new Size(256, 30);
            label5.TabIndex = 13;
            label5.Text = "Choose your workout plan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 534);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(checkBox2);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private CheckBox checkBox2;
        private ComboBox comboBox2;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private CheckBox checkBox3;
        private Label label4;
        private Label label5;
    }
}
