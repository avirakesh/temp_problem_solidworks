import java.util.*;
import java.io.*;
import java.math.*;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt(); // the number of temperatures to analyse
        in.nextLine();
        String temps = in.nextLine(); // the n temperatures expressed as integers ranging from -273 to 5526

        // Write an action using System.out.println()
        // To debug: System.err.println("Debug messages...");
        
        if (n != 0) {
            String[] tokens = temps.split(" ");
        
            int min = 5527;
        
            for (String tempS : tokens) {
                int temp = Integer.parseInt(tempS);
                
                if (Math.abs(temp) < Math.abs(min)) {
                    min = temp;   
                } else if (Math.abs(temp) == Math.abs(min) && temp > min) {
                    min = temp;    
                }
            }

            System.out.println(String.valueOf(min));
        } else {
            System.out.println("0");
        }
    }
}