package com.company;

import java.util.Scanner;

import static java.lang.Math.abs;

public class Exercise6 {
    private static boolean isRunning = true;

    public static void result()
    {
        do {
            Scanner in = new Scanner(System.in);
            short response;

            System.out.println("[1] - Code");
            System.out.println("[2] - Decode");
            System.out.println("[3] - Exit");
            System.out.print("Your option: ");
            response = in.nextShort();

            switch (response) {
                case 1:
                    String cres = code();
                    System.out.println(cres);
                    break;

                case 2:
                    String dres = decode();
                    System.out.println(dres);
                    break;

                case 3:
                    isRunning = false;
                    break;

                default:
                    System.out.println("That option does not exist");
                    break;
            }
        } while (isRunning);
    }

    private static String code()
    {
        Scanner in = new Scanner(System.in);
        String origin;
        int salt;

        System.out.println("Enter a string to code");
        origin = in.next();
        char[] word = origin.toCharArray();
        System.out.println("Enter a number to code your string");
        salt = in.nextInt();

        int dl = origin.length();
        for (int i = 0; i < dl; i++)
        {
            if (word[i] + salt > 90)
                word[i] += salt - 26;
            else
                word[i] += salt;
        }

        String output = new String(word);
        return output;
    }

    private static String decode()
    {
        Scanner in = new Scanner(System.in);
        String origin;
        int salt;

        System.out.println("Enter a string to decode");
        origin = in.next();
        char[] word = origin.toCharArray();
        System.out.println("Enter a number to decode your string");
        salt = in.nextInt();

        int dl = origin.length();
        for (int i = 0; i < dl; i++)
        {
            if (word[i] - salt < 65)
            {
                word[i] += 26;
                word[i] -= salt;
            }
            else
                word[i] -= salt;
        }

        String output = new String(word);
        return output;
    }
}
