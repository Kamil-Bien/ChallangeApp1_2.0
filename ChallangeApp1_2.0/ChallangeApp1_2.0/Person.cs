using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp1_2._0
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
    }
}
