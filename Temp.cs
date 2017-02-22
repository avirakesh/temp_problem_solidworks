using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        if (n != 0) {
            string [] tokens = temps.Split(' ');
            int low = 5527;
            foreach (string temp in tokens){
                int i = int.Parse(temp);
                
                if (Math.Abs(i) < Math.Abs(low)) {
                    low = i;   
                } else if (Math.Abs(i) == Math.Abs(low) && i > low) {
                    low = i;
                }
            }
            
            Console.WriteLine(low);
        } else {
            Console.WriteLine("0");
        }
    }
}