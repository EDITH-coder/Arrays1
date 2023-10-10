using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of 5 element and add values later
            String[] Colours = new String[5] ;

            //Create an array of 5 element and add values right away

            string[] Cars= new String[5] {"BMW","POLO", "MAZDA" ,"TOYOTA","TAZZ"};

            //Create an array of 5 element without specifying the size

            int[] Numbers = new int[] {} ;
            // Create an array of 5 elements, omitting the new keyword, and without specifying the size
            int[] numbers2 = {2,4,6,8,10};
            Console.WriteLine(numbers2[3]);



            //  //Create an array of 5 element and add values right away and access element 4 from the array
            string[] Car = new String[5] { "BMW", "POLO", "MAZDA", "TOYOTA", "TAZZ" };
            Console.WriteLine(Car[3]);

            Console.ReadLine();
        }
    }
}
