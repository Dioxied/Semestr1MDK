using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Planet()
    {
        public string name = "Undefinded";
        public double diametr = 0;
        public double weight = 0;
        public double wonSun = 0;

        public string PrintWonSun()
        {
            return $"Расстояние от планеты {name} до Солнца составляет {wonSun * 0.621371} тысяч миль.";
        }
        public string PrintInfo()
        {
            return $"Название планеты - {name}\nДиаметр планеты - {diametr}\nМасса планеты - {weight}";
        }
    }
}
