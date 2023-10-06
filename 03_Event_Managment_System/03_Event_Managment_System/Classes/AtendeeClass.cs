using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Event_Managment_System.Classes
{
    internal abstract class Atendee<T>
    {

        public string name;
        public string surname;
        public int age;

        public Atendee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public abstract void DisplayInfo();

    }
}
