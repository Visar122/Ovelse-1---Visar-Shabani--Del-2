using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_1__Del_2
{
     sealed class Teacher : Student  // Her Låser jeg Teacher og  base  længere ned , således at man ikke kan instantiere den det betyder at klassen er låst så  andre klasser ikke kan arve fra klassen
    {

    

            
         public   Teacher(int _StudentId,string _FirstName,string _LastName,DateTime _DateofBirth ) : base  ( _StudentId,_FirstName,_LastName,_DateofBirth)    // Her bruger jeg Arv metoden  hvor jeg  har fjernet department fra teacher Classen og jeg bruger nu, StudentID som Department//
        {                                                                                                                                                 // Jeg bruger også  base klasse constructor til at vider sende data fra Student vider til base klassen Techer.




        }
        public  override string ToString()  // ToString  gør at teksten kommer frem hver gang jeg kører programmet //
        {
            return SudentID + " Lærer "+ FirstName + LastName + DateOfBirth.ToString("dd/MM/yyyy") + " Age:" + Age;
        }
    }
}
