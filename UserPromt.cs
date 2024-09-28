using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    internal class UserPromt
    {
        // Created a simple class. 
        // Using static void. Meaning i won´t be creating an object. If that where the case i would use public void.
        public static void userPromt() 
        {
            Console.WriteLine("Mata in en siffra");
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //string input = Console.ReadLine();
            int givenInput;


            /*Not using int.parse due to runtime error in case the input is in the wrong format and not convertable.
            Also using tryparse for easy och secure convertion*/

            if (int.TryParse(Console.ReadLine(), out givenInput))
            {

                // Gör forloop att skriva ut rad, nestlade forloop for column , if satsen med % 

                for (int i = 1; i <= givenInput; i++)
                {


                    for (int j = 1; j <= givenInput; j++)
                    {


                        if ((i + j) % 2 == 0)
                        {
                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write("□");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");

            }

        }
       
    } 
}
