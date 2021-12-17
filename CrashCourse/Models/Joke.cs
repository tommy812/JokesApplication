using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashCourse.Models
{
    public class Joke
    {
        //prop to auto gerate 2x tab
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //use ctro
        public Joke()
        {
                
        }
    }
}
