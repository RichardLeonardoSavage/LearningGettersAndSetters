using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGettersAndSetters
{


    //so here is the class that we have assigned properties to
    class Movie
    {
        public string title;
        public string director;
        private string rating;


        //this is the constructor 
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;

            
        }


        //here we have defined a method to determine that the Rating property can only have certain values
        public string Rating
        {
            
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") 
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }

        }
    }
}

