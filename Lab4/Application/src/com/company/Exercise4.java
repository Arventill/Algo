package com.company;
import java.util.Scanner;

public class Exercise4 {
    static double weighted_average(int n){
        Scanner input = new Scanner(System.in);
        int s1=0, s2=0, no, w;
        double s;
        for(int i = 0; i<n; i++){
            System.out.print("enter the number: ");
            no = input.nextInt();
            System.out.print("and her weight: ");
            w = input.nextInt();
            s1+=no*w;
            s2+=w;
            i++;
        }
        System.out.println(s1);
        System.out.println(s2);
        s=s1/s2;
        return s;
    }

}
