using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Country()
    {
        public string name = "Undefinded";
        public string form_prav = "Undefinded";
        public double chislen = 0;
        public double ploshad = 0;

        public string PrintWonSun()
        {
            return $"Плотность населения страны {name} равна - {chislen/ploshad}";
        }
        public string PrintInfo()
        {
            return $"Название Страны - {name}\nФорма правления - {form_prav}\nЧисленность населения  - {chislen}\nПлощадь - {ploshad}";
        }
    }
}
