using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses3
{
    public class Movie
    {
        //Fields
        //Under invisibility cloak.  Fields are there, just haven't written them out



        //Properties - usually done this way:
        public string Title { get; set; }  //Get-Set makes it a property and not a field
        public string Producer { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; } 
        public bool IsGood { get; set; }

        
        //Constructors
        public Movie()  //Not required to get and set values when first created
        {

        }

        public Movie(bool sequel)  //Not all contructors are properties
        {
            this.IsGood = false;  //Refers to THIS sequel...rushHour2 in program class. 
        }

        public Movie (string superhero)
        {
            this.Genre = "action";
        }


        //Methods

    }
}
