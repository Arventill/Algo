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
            System.out.println("[2] - ");
            System.out.println("[3] - ");
            System.out.println("[4] - ");
            System.out.println("[5] - ");
            System.out.println("[6] - ");
            System.out.println("[7] - Exit");
            System.out.print("Your choice: ");

            short response = in.nextShort();

            switch (response) {

                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
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
