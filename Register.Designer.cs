namespace Inheritance_Form
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            label7 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button4 = new Button();
            label3 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Java", "JavaScript" });
            checkedListBox1.Location = new Point(331, 407);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.RightToLeft = RightToLeft.No;
            checkedListBox1.Size = new Size(240, 76);
            checkedListBox1.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 433);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(62, 32);
            label7.TabIndex = 72;
            label7.Text = "Skill:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(331, 28);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(169, 32);
            label2.TabIndex = 62;
            label2.Text = "Sign Up Form";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bhaktapur", "Kathmandu", "Lalitpur", "Ilam ", "Bara", "Jhapa", "Mustang", "Makwanpur", "Chitwan", "Baglung" });
            comboBox2.Location = new Point(331, 331);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.No;
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 71;
            // 
            // button4
            // 
            button4.Location = new Point(206, 521);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(150, 46);
            button4.TabIndex = 67;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 100);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(83, 32);
            label3.TabIndex = 63;
            label3.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 339);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(93, 32);
            label6.TabIndex = 66;
            label6.Text = "District:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bagmati", "Gandaki", "Lumbini", "Madhesh", "Koshi", "Karnali", "Sudurpaschim" });
            comboBox1.Location = new Point(331, 267);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 70;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 97);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(244, 39);
            textBox1.TabIndex = 68;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 213);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(61, 32);
            label4.TabIndex = 64;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 270);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(110, 32);
            label5.TabIndex = 65;
            label5.Text = "Province:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(331, 206);
            numericUpDown1.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.RightToLeft = RightToLeft.No;
            numericUpDown1.Size = new Size(90, 39);
            numericUpDown1.TabIndex = 69;
            numericUpDown1.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 159);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 74;
            label1.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(339, 152);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(98, 36);
            radioButton1.TabIndex = 75;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(479, 152);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(122, 36);
            radioButton2.TabIndex = 76;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(540, 521);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 77;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 611);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label7;
        private Label label2;
        private ComboBox comboBox2;
        private Button button4;
        private Label label3;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
    }
}