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
using FontAwesome.Sharp;

namespace COMP1004_F2016_Mid_Term_200330143
{
    public partial class AbilityGeneratorForm : Form
    {
        // private Instance Object
        private Random _random;
        public GenerateNameForm previousForm;



        public AbilityGeneratorForm()
        {
            InitializeComponent();
        }

        private Int32 Roll()
        {
            // create new empty list
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            // roll 4 dice
            for (int count = 0; count < 4; count++)
            {
                int generatedNumber = this._random.Next(0, 6) + 1;
                numbers.Add(generatedNumber);
            }

            // drop the lowest die
            numbers.Remove(numbers.Min());

            // add the numbers to the result

            foreach (int number in numbers)
            {
                result += number;
            }

            // lambda expression equivalent
            //result = numbers.Sum(number => number);

            return result;
        }

        private void GenerateAbilities()
        {
            StrengthTextBox.Text = this.Roll().ToString();
            DexterityTextBox.Text = this.Roll().ToString();
            ConstitutionTextBox.Text = this.Roll().ToString();
            IntelligenceTextBox.Text = this.Roll().ToString();
            WisdomTextBox.Text = this.Roll().ToString();
            CharismaTextBox.Text = this.Roll().ToString();
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            this._random = new Random(); // initialize random number object

            GenerateAbilities();
            AbilityListBox.SelectedIndex = 0;
            AbilityListBox2.SelectedIndex = 0;
            ModifyAbilitiesListBox.SelectedIndex = 0;
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Strength = StrengthTextBox.Text;
            character.Dexterity = DexterityTextBox.Text;
            character.Constitution = ConstitutionTextBox.Text;
            character.Intelligence = IntelligenceTextBox.Text;
            character.Wisdom = WisdomTextBox.Text;
            character.Charisma = CharismaTextBox.Text;

            // Step 1 - Hide the parent form
            this.Hide();

            // Step 2 - Instantiate an object for the form type
            // you are going to next
            RaceAndClassForm raceAndClassForm = new RaceAndClassForm();

            // Step 3 - create a property in the next form that 
            // we will use to point to this form
            // e.g. public AbilityGeneratorForm previousForm;

            // Step 4 - point this form to the parent Form 
            // property in the next form
            raceAndClassForm.previousForm = this;

            // Step 5 - Show the next form
            raceAndClassForm.Show();
        }

        private void AbilitySwap(String Ability1, String Ability2)
        {
            String AbilityScoreTemp;
            if (Ability1.Equals("Strength"))
            {
                AbilityScoreTemp = StrengthTextBox.Text;
                if (Ability2.Equals("Dexterity"))
                {
                    StrengthTextBox.Text = DexterityTextBox.Text;
                    DexterityTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Constitution"))
                {
                    StrengthTextBox.Text = ConstitutionTextBox.Text;
                    ConstitutionTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Intelligence"))
                {
                    StrengthTextBox.Text = IntelligenceTextBox.Text;
                    IntelligenceTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Wisdom"))
                {
                    StrengthTextBox.Text = WisdomTextBox.Text;
                    WisdomTextBox.Text = AbilityScoreTemp;
                }
                else 
                {
                    StrengthTextBox.Text = CharismaTextBox.Text;
                    CharismaTextBox.Text = AbilityScoreTemp;
                }
            } else if (Ability1.Equals("Dexterity"))
            {
                AbilityScoreTemp = DexterityTextBox.Text;
                if (Ability2.Equals("Strength"))
                {
                    DexterityTextBox.Text = StrengthTextBox.Text;
                    StrengthTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Constitution"))
                {
                    DexterityTextBox.Text = ConstitutionTextBox.Text;
                    ConstitutionTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Intelligence"))
                {
                    DexterityTextBox.Text = IntelligenceTextBox.Text;
                    IntelligenceTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Wisdom"))
                {
                    DexterityTextBox.Text = WisdomTextBox.Text;
                    WisdomTextBox.Text = AbilityScoreTemp;
                }
                else
                {
                    DexterityTextBox.Text = CharismaTextBox.Text;
                    CharismaTextBox.Text = AbilityScoreTemp;
                }
            }
            else if (Ability1.Equals("Constitution"))
            {
                AbilityScoreTemp = ConstitutionTextBox.Text;
                if (Ability2.Equals("Strength"))
                {
                    ConstitutionTextBox.Text = StrengthTextBox.Text;
                    StrengthTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Dexterity"))
                {
                    ConstitutionTextBox.Text = DexterityTextBox.Text;
                    DexterityTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Intelligence"))
                {
                    ConstitutionTextBox.Text = IntelligenceTextBox.Text;
                    IntelligenceTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Wisdom"))
                {
                    ConstitutionTextBox.Text = WisdomTextBox.Text;
                    WisdomTextBox.Text = AbilityScoreTemp;
                }
                else
                {
                    ConstitutionTextBox.Text = CharismaTextBox.Text;
                    CharismaTextBox.Text = AbilityScoreTemp;
                }
            }
            else if (Ability1.Equals("Intelligence"))
            {
                AbilityScoreTemp = IntelligenceTextBox.Text;
                if (Ability2.Equals("Strength"))
                {
                    IntelligenceTextBox.Text = StrengthTextBox.Text;
                    StrengthTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Dexterity"))
                {
                    IntelligenceTextBox.Text = DexterityTextBox.Text;
                    DexterityTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Constitution"))
                {
                    IntelligenceTextBox.Text = ConstitutionTextBox.Text;
                    ConstitutionTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Wisdom"))
                {
                    IntelligenceTextBox.Text = WisdomTextBox.Text;
                    WisdomTextBox.Text = AbilityScoreTemp;
                }
                else
                {
                    IntelligenceTextBox.Text = CharismaTextBox.Text;
                    CharismaTextBox.Text = AbilityScoreTemp;
                }
            }
            else if (Ability1.Equals("Wisdom"))
            {
                AbilityScoreTemp = WisdomTextBox.Text;
                if (Ability2.Equals("Strength"))
                {
                    WisdomTextBox.Text = StrengthTextBox.Text;
                    StrengthTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Dexterity"))
                {
                    WisdomTextBox.Text = DexterityTextBox.Text;
                    DexterityTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Constitution"))
                {
                    WisdomTextBox.Text = ConstitutionTextBox.Text;
                    ConstitutionTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Intelligence"))
                {
                    WisdomTextBox.Text = IntelligenceTextBox.Text;
                    IntelligenceTextBox.Text = AbilityScoreTemp;
                }
                else
                {
                    WisdomTextBox.Text = CharismaTextBox.Text;
                    CharismaTextBox.Text = AbilityScoreTemp;
                }
            }
            else 
            {
                AbilityScoreTemp = CharismaTextBox.Text;
                if (Ability2.Equals("Strength"))
                {
                    CharismaTextBox.Text = StrengthTextBox.Text;
                    StrengthTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Dexterity"))
                {
                    CharismaTextBox.Text = DexterityTextBox.Text;
                    DexterityTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Constitution"))
                {
                    CharismaTextBox.Text = ConstitutionTextBox.Text;
                    ConstitutionTextBox.Text = AbilityScoreTemp;
                }
                else if (Ability2.Equals("Intelligence"))
                {
                    CharismaTextBox.Text = IntelligenceTextBox.Text;
                    IntelligenceTextBox.Text = AbilityScoreTemp;
                }
                else
                {
                    CharismaTextBox.Text = WisdomTextBox.Text;
                    WisdomTextBox.Text = AbilityScoreTemp;
                }
            }
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            if (!AbilityListBox.SelectedItem.ToString().Equals(AbilityListBox2.SelectedItem.ToString())) {
                AbilitySwap(AbilityListBox.SelectedItem.ToString(), AbilityListBox2.SelectedItem.ToString());
                SwapButton.Enabled = false;
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (ModifyAbilitiesListBox.SelectedItem.ToString().Equals("Strength"))
            {
                StrengthTextBox.Text = (Int32.Parse(StrengthTextBox.Text) + 1).ToString();
            }
            if (ModifyAbilitiesListBox.SelectedItem.ToString().Equals("Dexterity"))
            {
                DexterityTextBox.Text = (Int32.Parse(DexterityTextBox.Text) + 1).ToString();
            }
            if (ModifyAbilitiesListBox.SelectedItem.ToString().Equals("Constitution"))
            {
                ConstitutionTextBox.Text = (Int32.Parse(ConstitutionTextBox.Text) + 1).ToString();
            }
            if (ModifyAbilitiesListBox.SelectedItem.ToString().Equals("Intelligence"))
            {
                IntelligenceTextBox.Text = (Int32.Parse(IntelligenceTextBox.Text) + 1).ToString();
            }
            if (ModifyAbilitiesListBox.SelectedItem.ToString().Equals("Wisdom"))
            {
                WisdomTextBox.Text = (Int32.Parse(WisdomTextBox.Text) + 1).ToString();
            }
            if (ModifyAbilitiesListBox.SelectedItem.ToString().Equals("Charisma"))
            {
                CharismaTextBox.Text = (Int32.Parse(CharismaTextBox.Text) + 1).ToString();
            }
            ModifyButton.Enabled = false;
        }
    }
}
