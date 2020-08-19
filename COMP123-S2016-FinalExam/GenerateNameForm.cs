using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this.generatenames();
        }

        public void generatenames()
        {

            var random = new Random();

            int index = random.Next(0, listBox1.Items.Count);
            LastNameTextBox.Text = listBox1.Items[index].ToString();

            int inde = random.Next(0, FirstNameListBox.Items.Count);
            firstnametextBox.Text = FirstNameListBox.Items[inde].ToString();
        }
        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //firstnametextBox.Text = FirstNameListBox.SelectedIndex.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LastNameTextBox.Text = listBox1.SelectedIndex.ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.generatenames();
            firstnametextBox.Text = Program.character.Firstname;
            LastNameTextBox.Text = Program.character.Lastname;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abil = new AbilityGeneratorForm();
            abil.Show();
            this.Hide();
        }
    }
}
