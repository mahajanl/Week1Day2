using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //What data types have we talked about so far int and string 
            //An int is a whole number and a stirng is a collection of characters

            char firstInitial = 'L';
            //Characters or chars are single letters or symbols

            bool isTired = true;
            //Boolean or bool is a true or false 

            //other number data types
            float number = 2.164403304907294846437820128746f;
            decimal partialNum = 2.164403304907294846437820128746m;
            double someNumber = 2.164403304907294846437820128746d;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //Now let's talk about operators!
            // ARITHMETIC operators
            // + adds two or more operands 
            // - subtracts second operand from the first
            // * multiplies the operands
            // / divides first operand by the second
            // % modulus - divides and checks the remainder of a division operation 

            //RELATIONAL operators
            // ++ increments operator by 1
            // -- decreases operator by 1
            // == checks if the values of 2 operands are equal
            // and if they are, returns bool as true
            // != checks if stuff isn't equal to one another - my age is not the same as another - returns true

            int jarryAge = 29;
            int danielAge = 32;

            Console.WriteLine("Daniel and Jarry are the same age.");
            Console.WriteLine(jarryAge == danielAge);

            Console.WriteLine("Daniel and Jarry are different ages.");
            Console.WriteLine(jarryAge != danielAge);

            /*
             *  > checks if the left is bigger than the right, and if yes, returns as true
             *  < checks if left is smaller than the right, and if yes, returns as true
             *  >= checks if the left is bigger than or equal to
             *  <= checks if the left is smaller than or equal to
             */

            // && is the AND; for both
            // || is the OR; for one or the other
            // ! the NOT, reverses whatever logical sttament was made

        }
    }
}
