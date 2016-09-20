using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses3
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie rushHour2 = new Movie(true);
            Console.WriteLine(rushHour2.IsGood);

            Movie darkKnight = new Movie("Batman");  //New movie instance called darkKnight with a parameter of Batman
            Console.WriteLine(darkKnight.Genre);
        }
    }
}
