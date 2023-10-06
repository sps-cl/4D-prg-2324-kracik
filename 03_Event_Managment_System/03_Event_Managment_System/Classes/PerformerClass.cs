using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Event_Managment_System.Classes;
using System.Xml.Linq;

namespace _03_Event_Managment_System.Classes
{
    internal class Performer : Atendee<Performer>
    {

        public string job;

        public Performer(string name, string surname, int age, string job) : base(name, surname, age)
        {
            this.job = job;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}, Job: {job}");
        }

    }
}
