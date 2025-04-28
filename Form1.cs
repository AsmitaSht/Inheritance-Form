using System.Diagnostics;

namespace Inheritance_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register page = new Register();
            page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int age = (int)numericUpDown1.Value;
            string province = comboBox1.Text.Trim();
            string district = comboBox2.Text.Trim();
            bool hasSkill = checkedListBox1.CheckedItems.Count > 0;

            if (string.IsNullOrEmpty(name) || age <= 0 || string.IsNullOrEmpty(province) || string.IsNullOrEmpty(district) || !hasSkill)
            {
                MessageBox.Show("Please fill all the fields properly and select at least one skill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reg welcomeForm = new Reg();
                welcomeForm.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator math = new Calculator();
            math.Show();
        }
    }
}
