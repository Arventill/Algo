package com.company;
import java.util.Scanner;

class Exercise4 {
    static void weighted_average(int n){
        Scanner input = new Scanner(System.in);
        int s1=0, s2=0, no, w;

        System.out.println(n);
        for(int i = 1; i<=n; i++){
            System.out.print("enter the number: ");
            no = input.nextInt();
            System.out.print("and her weight: ");
            w = input.nextInt();
            s1+=no*w;
            s2+=w;
        }

        System.out.println("Weighted average of given numbers: " + (double)s1/s2);
    }

}
