using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Author: Krytia Fernandez
* Date : May 17, 2016
*Description: Advance Methods Demo for Lesson 2
* Version : 0.0.3--  added  add x && y method 
*/
namespace week02_01
{
    /*
    * Main driver class for lesson 2 
    * @ class program 
    */
    public class Program
    {
        /**
        * Main method for our drive class
        * @ constructor main
        *@param {string[]} args
        */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result =0;
            result = addXandY(x, y);
            Console.WriteLine(result);
               
        }
        /*
        *simple method to add two values 
        */
       public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
            
        }
    }
}
