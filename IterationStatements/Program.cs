using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                var numbers = new List<int>();

      
            var myNumber = 0;



            do
            {
               
                myNumber++;
                
                numbers.Add(myNumber);

            } while (myNumber < 100);



            // Create a while loop
            while(myNumber < 200)
            {
              
                myNumber++;
              
                numbers.Add(myNumber);


            }


           
            Console.WriteLine("Increase:");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


           for(int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
