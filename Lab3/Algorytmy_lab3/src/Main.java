import java.util.Scanner;

public class Main {
  private static boolean isRunning = true;

  public static void main(String[] args) {

    do {
      Scanner in = new Scanner(System.in);
      System.out.println();
      System.out.println("Choose an option:");
      System.out.println("[1] - Calculate the circumference(?) and Perimeter of the triangle ");
      System.out.println("[2] - ");
      System.out.println("[3] - Fibonacci Sequence");
      System.out.println("[4] - Simple Calculator");
      System.out.println("[5] - Guess the number");
      System.out.println("[6] - Determinants method");
      System.out.println("[7] - Check if input number is prime");
      System.out.println("[8] - Exit");
      System.out.print("Your choice: ");

      short response = in.nextShort();

      switch (response) {

        case 1:
          double[] tab = new double[3];
          System.out.println("Enter 3  sides of a triangle: ");
          for (int i = 0; i < 3; i++) {
            tab[i] = in.nextDouble();
          }
          Exercise1.triangle(tab);

          break;

        case 2:
          double[][] t = new double[3][3];
          for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
              t[i][j] = in.nextDouble();
            }
          }

          Exercise2.result(t);
          break;

        case 3:
          System.out.println("Enter the number of fibonacci sequence elements(1-92): ");
          int n = in.nextInt();

          Exercise3.printFibonacciSequence(n);
          break;

        case 4:
          System.out.print("Enter a: ");
          double no1 = in.nextDouble();
          System.out.print("Enter b: ");
          double no2 = in.nextDouble();
          Exercise4.calculator(no1, no2);
          break;

        case 5:
          Exercise5.checkNumber();
          break;

        case 6:
          System.out.println("General form of equations: " + "\n" + "ax + by = A" + "\n" + "cx + dy = B");
          System.out.print("Enter a: ");
          double a = in.nextDouble();
          System.out.print("Enter b: ");
          double b = in.nextDouble();
          System.out.print("Enter A: ");
          double A = in.nextDouble();
          System.out.print("Enter c: ");
          double c = in.nextDouble();
          System.out.print("Enter d: ");
          double d = in.nextDouble();
          System.out.print("Enter B: ");
          double B = in.nextDouble();

          Exercise6.doMath(a, b, c, d, A, B);
          break;

        case 7:
          System.out.println("Enter the number: ");
          int number = in.nextInt();

          Exercise7.runPrimalityTest(number);

          break;

        case 8:
          System.out.println(Color.BLUE + "Bye :P" + Color.DEFAULT);
          isRunning = false;
          break;

        default:
          break;
      }
    } while (isRunning);
  }
}
