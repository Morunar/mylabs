using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    
        public static class Extension
        {
            public static List<CharacteristicStudent> FindStudent(this List<CharacteristicStudent> students, StudentPredicateDelegate studentGroup)
            {
                List<CharacteristicStudent> studentsResult = new List<CharacteristicStudent>();

                foreach (CharacteristicStudent student in students)
                {
                    if (studentGroup.Invoke(student))
                    {
                        studentsResult.Add(student);
                    }
                }
                return studentsResult;











            }
        }
 }

