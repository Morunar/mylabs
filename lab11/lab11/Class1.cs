using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public delegate bool StudentPredicateDelegate(CharacteristicStudent student);

    internal class Class1
    {
        private static void Main()
        {
            List<CharacteristicStudent> students = new List<CharacteristicStudent>()
            {
                new CharacteristicStudent(){FirstName="Vlad",LastName="Bahlai",Age=18},
                new CharacteristicStudent(){FirstName="Andrew",LastName="Melnik",Age=19},
                new CharacteristicStudent(){FirstName="Vlad",LastName="Chypys",Age=20},
                new CharacteristicStudent(){FirstName="Michael",LastName="Yik",Age=21},
                new CharacteristicStudent(){FirstName="Nikolay",LastName="Kariy",Age=22},
                new CharacteristicStudent(){FirstName="Fedor",LastName="Bryzgalov",Age=23},
                new CharacteristicStudent(){FirstName="Alexandr",LastName="Coder",Age=14},
                new CharacteristicStudent(){FirstName="Vitaliy",LastName="Chypys",Age=15},
                new CharacteristicStudent(){FirstName="Maria",LastName="Troelsen",Age=16},
                new CharacteristicStudent(){FirstName="Vika",LastName="Troelsen",Age=16}
            };


           
            
       







            List<CharacteristicStudent> StudentsAge = students.FindStudent((student) => CharacteristicStudent.More18(student));
            Console.WriteLine("Students age more 17 := ");

            foreach (CharacteristicStudent student in StudentsAge)
            {
                Console.WriteLine("FirstName - {0}, LastName - {1}, Age - {2}", student.FirstName, student.LastName,student.Age);
            }

            List<CharacteristicStudent> StudentsFirstName = students.FindStudent((student) => CharacteristicStudent.FirstLetter(student));
            Console.WriteLine("Students with first letter A :=");

            foreach (CharacteristicStudent student in StudentsFirstName)
            {
                Console.WriteLine("FirstName - {0}, LastName - {1}, Age - {2}", student.FirstName, student.LastName, student.Age);
            }

            List<CharacteristicStudent> foundStudentsLastName = students.FindStudent((student) => CharacteristicStudent.LenghtLastName(student));
            Console.WriteLine("Students with last name more then 3 letters :=");
            foreach (CharacteristicStudent student in foundStudentsLastName)
            {
                Console.WriteLine("FirstName - {0}, LastName - {1}, Age - {2}", student.FirstName, student.LastName, student.Age);
            }



            List<CharacteristicStudent> StudentsAndrew = students.FindStudent((student) => student.FirstName == "Andrew");
            Console.WriteLine("Students with first name Andrew :=");

            foreach (CharacteristicStudent student in StudentsAndrew)
            {
                Console.WriteLine("FirstName - {0}, LastName - {1}, Age - {2}", student.FirstName, student.LastName, student.Age);
            }





            List<CharacteristicStudent> StudentsTroelsen = students.FindStudent((student) => student.LastName == "Troelsen");
            Console.WriteLine("Students with last name Troelsen :=");

            foreach (CharacteristicStudent student in StudentsTroelsen)
            {
                Console.WriteLine("FirstName - {0}, LastName - {1}, Age - {2}", student.FirstName, student.LastName, student.Age);
            }

            Console.ReadKey();
        }
    }
}
