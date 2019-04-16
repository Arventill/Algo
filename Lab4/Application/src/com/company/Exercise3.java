package com.company;

import java.util.Scanner;

class Exercise3 {


    static void hexDec() {

        short option;
        Scanner in = new Scanner(System.in);
        while (true) {
            System.out.println("Choose an option:");
            System.out.println("[1] - Heximal to decimal.");
            System.out.println("[2] - Decimal to Heximal.");
            System.out.println("[3] - Return to menu.");
            System.out.print("Your choice: ");

            option = in.nextShort();

            switch (option) {
                case 1:
                    System.out.println("Enter the Heximal number: ");
                    String hex = in.next();
                    System.out.println("Given Heximal sequence in decimal system: " + heximalToDecimal(hex));
                    break;

                case 2:
                    System.out.println("Enter the decimal number: ");
                    int decimal = in.nextInt();
                    System.out.println("Given decimal number in heximal system: " + decimalToHeximal(decimal));
                    break;

                case 3:
                    return;

                default:
                    break;
            }
        }

    }

    private static int heximalToDecimal(String hex){
        String digits = "0123456789ABCDEF";
        hex = hex.toUpperCase();
        int val = 0;
        for (int i = 0; i < hex.length(); i++)
        {
            char c = hex.charAt(i);
            int d = digits.indexOf(c);
            val = 16*val + d;
        }
        return val;

    }

    private static String decimalToHeximal(int decimal){
            int rem;
            String hex="";
            char hexchars[]={'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
            while(decimal>0)
            {
                rem=decimal%16;
                hex=hexchars[rem]+hex;
                decimal=decimal/16;
            }
            return hex;

        }
}
