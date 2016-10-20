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
    public partial class SplashForm : Form
    {

        public SplashForm()
        {
            InitializeComponent();
        }

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
