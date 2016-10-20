using System;
using System.Collections.Generic;
using System.Linq;
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
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
