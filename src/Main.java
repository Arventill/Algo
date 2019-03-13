import java.util.Scanner;

public class Main
{
    private static boolean isRunning = true;

    public static void main(String[] args) {
        do {
            Scanner in = new Scanner(System.in);
            System.out.println();
            System.out.println("Choose an option:");
            System.out.println("[1] - Hello World");
            System.out.println("[2] - Factorial");
            System.out.println("[3] - NWW");
            System.out.println("[4] - NWD");
            System.out.println("[5] - Raise n to the m power");
            System.out.println("[6] - Exit");
            System.out.print("Your choice: ");

            short response = in.nextShort();
            switch (response) {
                case 1: {
                    System.out.println(Color.BLUE + "Hello world" + Color.DEFAULT);
                    break;
                }
                case 2: {
                    System.out.println(Color.GREEN + Excercise3.result(10) + Color.DEFAULT);
                    break;
                }
                case 3: {
                    System.out.println(Color.BLUE + "NWW" + Color.DEFAULT);
                    break;
                }
                case 4: {
                    System.out.print("a: ");
                    int a = in.nextInt();
                    System.out.print("b: ");
                    int b = in.nextInt();
                    System.out.println(Color.CYAN + "NWD is: " + Excercise2a.result(a, b) + Color.DEFAULT);
                    break;
                }
                case 5: {
                    System.out.println(Color.BLUE + "Ex5" + Color.DEFAULT);
                    break;
                }
                case 6:
                {
                    System.out.println(Color.BLUE + "Bye :P" + Color.DEFAULT);
                    isRunning = false;
                    break;
                }

                default:
                    System.out.println(Color.RED + "Unknown option, please try again" + Color.DEFAULT);
                    break;
            }
        } while (isRunning);
    }
}
