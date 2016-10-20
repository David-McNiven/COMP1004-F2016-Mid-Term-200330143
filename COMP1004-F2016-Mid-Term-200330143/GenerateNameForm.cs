using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Character generator	
/// David McNiven
/// Student # 200330143
/// Created on October 20th 2016
/// Generates a basic character sheet for a DnD campaign
/// </summary>
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

        /// <summary>
        ///  handles random selection of names from the two lists and places them in the textboxes
        /// </summary>
        public void GenerateNames()
        {
            FirstNameListBox.ClearSelected();
            FirstNameListBox.SelectedIndex = this._random.Next(0, FirstNameListBox.Items.Count);
            FirstNameTextBox.Text = FirstNameListBox.SelectedItem.ToString();

            LastNameListBox.ClearSelected();
            LastNameListBox.SelectedIndex = this._random.Next(0, LastNameListBox.Items.Count);
            LastNameTextBox.Text = LastNameListBox.SelectedItem.ToString();
        }

        /// <summary>
        /// generates a new name on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this._random = new Random();
            GenerateNames();
        }

        /// <summary>
        /// event handler for the generate button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        /// <summary>
        /// event handler for the next button, saves the name for future forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;

            this.Hide();
            AbilityGeneratorForm AbilityGeneratorForm = new AbilityGeneratorForm();
            AbilityGeneratorForm.previousForm = this;
            AbilityGeneratorForm.Show();
        }
    }
}
