using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Fahmi", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Kamarudin", 45, "190345", "Pemograman");
            teacher.GetNameAndAge();

            Student student = new Student(" M.Fahmi A", 19, "19.11.2597", "Muhammad.attaqwa@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}