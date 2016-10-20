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
    public partial class SplashForm : Form
    {

        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// once the timer ticks, moves to the next form and disables the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            GenerateNameForm GenerateNameForm = new GenerateNameForm();
            GenerateNameForm.previousForm = this;
            GenerateNameForm.Show();
            SplashTimer.Enabled = false;
        }
    }
}
