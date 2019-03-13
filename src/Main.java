import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        System.out.println( "Wybierz opcję:" );
        System.out.println( "[1] - Hello World" );
        System.out.println( "[2] - Factorial" );
        System.out.println( "[3] - NWD" );
        System.out.println( "[4] - NWW" );
        System.out.println( "[5] - Raise n to the m power" );

        int a = in.nextInt();
        switch (a)
        {
            case 1:
                System.out.println(Color.BLUE + "Hello world" + Color.DEFAULT);
                break;
            case 2:
                System.out.println(Color.GREEN + Excercise3.result(10) + Color.DEFAULT);
                break;
            case 3:
                System.out.println(Color.BLUE + "NWW" + Color.DEFAULT);
                break;
            case 4:
                System.out.println(Color.BLUE + "NWD" + Color.DEFAULT);
                break;
            case 5:
                System.out.println(Color.BLUE + "Ex5" + Color.DEFAULT);
                break;

                default:
                    System.out.println(Color.BLUE + "Działa" + Color.DEFAULT);
                    break;
        }
    }
}
