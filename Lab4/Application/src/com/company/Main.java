package com.company;

import java.util.Scanner;

public class Main {
    private static boolean isRunning = true;

    public static void main(String[] args) {

        do {
            Scanner in = new Scanner(System.in);
            System.out.println();
            System.out.println("Choose an option:");
            System.out.println("[1] - ");
            System.out.println("[2] - Change of numbers from binary and decimal systems: ");
            System.out.println("[3] - ");
            System.out.println("[4] - ");
            System.out.println("[5] - Check if the given string is a palindrome. ");
            System.out.println("[6] - ");
            System.out.println("[7] - Exit");
            System.out.print("Your choice: ");

            short response = in.nextShort();

            switch (response) {

                case 1:
                    break;

                case 2:
                    Exercise2.menu();
                    break;

                case 3:
                    break;

                case 4:
                    System.out.print("Enter how many nymbers you want to add: ");
                    int no = in.nextInt();
                    Exercise4.weighted_average(no);
                    break;

                case 5:
                    System.out.println("Enter string: ");
                    String word = in.next();
                    Exercise5.checkPalindrome(word);
                    break;

                case 6:
                    break;

                case 7:
                    isRunning = false;
                    break;

                default:
                    break;
            }
        } while (isRunning);
    }
}
