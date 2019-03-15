import java.util.Scanner;

public class Main
{
    private static boolean isRunning = true;

    public static void main(String[] args) {
        Exercise6 ex6 = new Exercise6();

        do {
            Scanner in = new Scanner(System.in);
            System.out.println();
            System.out.println("Choose an option:");
            System.out.println("[1] - Hello World");
            System.out.println("[2] - Factorial");
            System.out.println("[3] - NWW");
            System.out.println("[4] - NWD");
            System.out.println("[5] - Raise n to the m power");
            System.out.println("[6] - Adding up digits of the number");
            System.out.println("[7] - Operations on a given array");
            System.out.println("[8] - Adding up digits of the number");
            System.out.println("[9] - Exit");
            System.out.print("Your choice: ");

            short response = in.nextShort();

            switch (response) {

                case 1:
                    System.out.println(Color.BLUE + "Hello world" + Color.DEFAULT);
                    break;

                case 2:
                    System.out.print("a: ");
                    int a = in.nextInt();
                    System.out.println(Color.GREEN + Exercise3.result(a) + Color.DEFAULT);
                    break;

                case 3:
                    System.out.println(Color.BLUE + "NWW" + Color.DEFAULT);
                    break;

                case 4:
                    System.out.print("a: ");
                    int num1 = in.nextInt();
                    System.out.print("b: ");
                    int num2 = in.nextInt();
                    System.out.println(Color.CYAN + "NWD is: " + Exercise2.nwd(num1, num2) + Color.DEFAULT);
                    break;

                case 5:
                    System.out.println("Enter the basis of power: ");
                    int n = in.nextInt();
                    System.out.println("Enter exponent: ");
                    int e = in.nextInt();
                    System.out.println(Color.BLUE + Exercise4.raiseToPower(n, e) + Color.DEFAULT);
                    break;

                case 6:
                    System.out.println("Enter a number: ");
                    int number = in.nextInt();
                    System.out.println(Color.BLUE + Exercise5.addingUp(number) + Color.DEFAULT);
                    break;

                case 7:
                    int[] tab = new int[10];

                    System.out.println("Enter 10 elements to your array: ");
                    for (int i=0; i<10; i++)
                    {
                        tab[i] = in.nextInt();
                    }
                    ex6.menu(tab);
                    break;

                case 8:
                    System.out.println();
                    break;

                case 9:
                    System.out.println(Color.BLUE + "Bye :P" + Color.DEFAULT);
                    isRunning = false;
                    break;

                default:
                    System.out.println(Color.RED + "Unknown option, please try again" + Color.DEFAULT);
                    break;
            }
        } while (isRunning);
    }
}
