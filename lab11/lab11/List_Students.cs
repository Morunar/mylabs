using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class CharacteristicStudent
    {
        public static bool FirstLetter(CharacteristicStudent student)
        {
            if (student.FirstName.ToLower().Substring(0, 1) == "a")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool More18(CharacteristicStudent student)
        {
            if (student.Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        public static bool LenghtLastName(CharacteristicStudent student)
        {
            if (student.LastName.Length > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string FirstName { get; set; }


        public int Age { get; set; }
      
        public string LastName { get; set; }
      

        





    }
}
