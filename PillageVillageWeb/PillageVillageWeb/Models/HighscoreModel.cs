using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PillageVillageWeb.Models
{
    public class HighscoreModel
    {
        public List<PersonClass> HighscoreTable { get; set; }
    }
    public class PersonClass
    {
        public int Score{ get; set; }
        public string  Name{ get; set; }
    }
}