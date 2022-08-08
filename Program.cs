using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");


            //this won't register because we have set it so that the Rating property is private and can only be a value that we have approved even if we try to hard code a different rating in
            shrek.Rating = "dog";


            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
        }
    }
}