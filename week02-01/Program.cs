using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Author: Krytia Fernandez
* Date : May 17, 2016
*Description: Advance Methods Demo for Lesson 2
* Version : 0.0.5--  added a method in array ReadUntilEnd--not completed 
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
            int result = 0;
            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();


            addYtoX(ref x, ref x);
            Console.WriteLine(x);

            Console.WriteLine(readUntilEnd);
        }
        /*
        *simple method to add two values 
        *@method addXandY
        *@param{int } first number
        *@param {int } second num
        */
        public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;

        }
        //simple method to demonstrate pass by ref with ref keyword
        //@mthod addYtoX
        //@param {ref int} X
        //@parm {ref int }Y
        public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;
            return X;
        }
        public static string[] readUntilEnd()
        {
            string[] inputs = new string[3];
            int inputCounter = 0;
            
            
            do
            {
                Console.WriteLine("Enter a Value --('end' to stop)");
                inputs[inputCounter] = Console.ReadLine();
                if(inputs[inputCounter]=="end")
                {
                    inputCounter = -1;

                }
                else
                {
                    inputCounter++;
                }
            }
            while (inputCounter != -1);

            return inputs;
        }
    }
}
