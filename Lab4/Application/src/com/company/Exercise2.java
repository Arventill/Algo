package com.company;

import java.util.Scanner;

class Exercise2 {


  static void menu() {

    short option;
    Scanner in = new Scanner(System.in);
    while (true) {
      System.out.println("Choose an option:");
      System.out.println("[1] - Binary to decimal.");
      System.out.println("[2] - Decimal to binary.");
      System.out.println("[3] - Return to menu.");
      System.out.print("Your choice: ");

      option = in.nextShort();

      switch (option) {
        case 1:
          System.out.println("Enter the binary number: ");
          int binaryNumber = in.nextInt();
          System.out.println("Given binary sequence in decimal system: " + binaryToDecimal(binaryNumber));
          break;

        case 2:
          System.out.println("Enter the decimal number: ");
          int decimal = in.nextInt();
          System.out.println("Given decimal number in binary system: " + decimalToBinary(decimal));
          break;

        case 3:
          return;

        default:
          break;
      }
    }

  }

  private static int binaryToDecimal(int binary){
    int decimal =0;
    int factor = 0;

   while(binary != 0){
     decimal +=((binary%10)*Math.pow(2,factor));
     binary /= 10;
     factor++;
   }
    return decimal;

  }

  private static String decimalToBinary(int decimal){

    String binary = "";

    while(decimal > 0){

      int temp = decimal %2;
      binary = temp + binary;
      decimal /= 2;

    }
    return binary;

  }
}
