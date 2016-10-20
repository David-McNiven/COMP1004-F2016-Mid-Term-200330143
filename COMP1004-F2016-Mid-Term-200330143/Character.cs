using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Character generator	
/// David McNiven
/// Student # 200330143
/// Created on October 20th 2016
/// Generates a basic character sheet for a DnD campaign
/// </summary>
namespace COMP1004_F2016_Mid_Term_200330143
{
    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}