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
      System.out.println("[3] - Fibonacci Sequence");
      System.out.println("[4] - ");
      System.out.println("[5] - Guess the number");
      System.out.println("[6] - Determinants method");
      System.out.println("[7] - Check if input number is prime");
      System.out.println("[8] - Exit");
      System.out.print("Your choice: ");

      short response = in.nextShort();

      switch (response) {

        case 1:
          break;

        case 2:
          break;

        case 3:
          System.out.println("Enter the number of fibonacci sequence elements(1-92): ");
          int n = in.nextInt();

          Exercise3.fibonacciSequence(n);
          break;

        case 4:
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

          Exercise7.primalityTest(number);

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
