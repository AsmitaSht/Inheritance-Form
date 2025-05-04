using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inheritance_Form
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int age = (int)numericUpDown1.Value;
            string province = comboBox1.Text.Trim();
            string district = comboBox2.Text.Trim();
            bool hasSkill = checkedListBox1.CheckedItems.Count > 0;

            // Determine selected gender
            string gender = "";
            if (radioButton1.Checked)
                gender = "Male";
            else
                gender = "Female";


            // Validation check
            if (string.IsNullOrEmpty(name) || age <= 16 || string.IsNullOrEmpty(province) ||
                string.IsNullOrEmpty(district) || string.IsNullOrEmpty(gender) || !hasSkill)
            {
                MessageBox.Show("Please fill all the fields properly, select a gender, and choose at least one skill.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Pass gender to Reg form if needed (not shown here)
                Reg welcomeForm = new Reg();
                welcomeForm.Show();
                this.Hide();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the text fields
            textBox1.Clear();

            // Reset the numeric up-down control
            numericUpDown1.Value = numericUpDown1.Minimum;

            // Reset combo boxes
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            // Uncheck all items in the checked list box
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var province = comboBox1.SelectedItem.ToString();
            List<string> bagmatiDistricts = new List<string> { "Kathmandu", "Bhaktapur", "Lalitpur" };
            List<string> gandakiDistricts = new List<string> { "Kaski", "Lamjung", "Manang" };

            comboBox2.Items.Clear();
            switch (province)
            {
                case "Bagmati":
                    comboBox2.Items.AddRange(bagmatiDistricts.ToArray());
                    break;
                case "Gandaki":
                    comboBox2.Items.AddRange(gandakiDistricts.ToArray());
                    break;
                default:
                    comboBox2.Items.Clear();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
