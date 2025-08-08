using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Car()
    {
        public string name_model = "Undefinded";
        public string name_author = "Undefinded";
        public double silaVloshad = 0;
        public double rashodna100 = 0;

        public string PrintrashodNa100(double km)
        {
            return $"Расход топлива на {km} км. равен - {rashodna100 * (km / 100)} л";
        }
        public string PrintInfo()
        {
            return $"Название модели - {name_model}\nИзготовитель - {name_author}\nКоличество лош. сил - {silaVloshad}\nРасход топлива на 100 км - {rashodna100}";
        }
    }
}
