using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;

            ChangePicture();
        }

        /// <summary>
        ///  changes the picture displayed based on the currently selected race
        /// </summary>
        private void ChangePicture()
        {
            if (_selectedRace.Equals("Human"))
            {
                RacePictureBox.Image = Properties.Resources.Human_Male;
            }
            else if (_selectedRace.Equals("Elf"))
            {
                RacePictureBox.Image = Properties.Resources.Elf_Male;
            }
            else if (_selectedRace.Equals("Dwarf"))
            {
                RacePictureBox.Image = Properties.Resources.Dwarf_Male;
            }
            else
            {
                RacePictureBox.Image = Properties.Resources.Halfling_Male;
            }
            RacePictureBox.Refresh();
        }

        /// <summary>
        /// saves the current race before moving to the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }

        /// <summary>
        /// checks if a race has been previously selected and changes the picture and radio buttons accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {
            Character character = Program.character;
            if (character.Race == null)
            {
                this._selectedRace = "Human";
            }
            else
            {
                this._selectedRace = character.Race;

                if (this._selectedRace.Equals("Elf"))
                {
                    ElfRadioButton.Checked = true;
                }
                else if (this._selectedRace.Equals("Dwarf"))
                {
                    DwarfRadioButton.Checked = true;
                }
                else if (this._selectedRace.Equals("Halfling"))
                {
                    HalflingRadioButton.Checked = true;
                }

                ChangePicture();
            }
        }
    }
}
