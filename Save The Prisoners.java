import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int rounds = input.nextInt();
        for(int i = 0; i < rounds; i++)
        {
            int num = input.nextInt();
            int lop = input.nextInt();
            int s = input.nextInt() - 1;
            while(lop != 0)
            {
                lop--;
                s++;
                if(s > num)
                    s = 1;
            }
            System.out.println(s);
        }    
    }
}