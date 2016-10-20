using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200330143
{
    public partial class GenerateNameForm : Form
    {
        private Random _random;
        public SplashForm previousForm;

        public GenerateNameForm()
        {
            InitializeComponent();
        }

        public void GenerateNames()
        {
            FirstNameListBox.ClearSelected();
            FirstNameListBox.SelectedIndex = this._random.Next(0, FirstNameListBox.Items.Count);
            FirstNameTextBox.Text = FirstNameListBox.SelectedItem.ToString();

            LastNameListBox.ClearSelected();
            LastNameListBox.SelectedIndex = this._random.Next(0, LastNameListBox.Items.Count);
            LastNameTextBox.Text = LastNameListBox.SelectedItem.ToString();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this._random = new Random();
            GenerateNames();
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Character character = Program.character;

            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbilityGeneratorForm AbilityGeneratorForm = new AbilityGeneratorForm();
            AbilityGeneratorForm.previousForm = this;
            AbilityGeneratorForm.Show();
        }
    }
}
