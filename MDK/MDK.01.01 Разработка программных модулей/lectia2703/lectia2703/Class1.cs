using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia2703
{
    class InformationSystem
    {
        public string Name {  get; set; }
        public string Version { get; set; }
        public string Developer { get; set; }

        public InformationSystem()
        {
            Name = "Linux";
            Version = "1.0 Дикобраз";
            Developer = "Алена";
        }
        public InformationSystem(string name, string version, string developer)
        {
            Name = name;
            Version = version;
            Developer = developer;
        }
        public void Deconstruct(out string name, out string version, out string developer)
        {
            name = Name;
            version = Version;
            developer = Developer;
        }
        public void DisplayInfo() {
            Console.WriteLine($"Название системы: {Name}\nВерсия: {Version}\nРазработчик: {Developer}");
        }
    }
}
