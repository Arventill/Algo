import java.util.Scanner;

class Exercise6 {

    private Scanner in = new Scanner(System.in);

    void menu(int[] tab)
    {
        while (true)
        {
            System.out.println();
            System.out.println("Choose an option:");
            System.out.println("[1] - Max value");
            System.out.println("[2] - ?");
            System.out.println("[3] - ?");
            System.out.println("[4] - ?");
            System.out.println("[5] - ?");
            System.out.println("[6] - ?");
            System.out.println("[7] - ?");
            System.out.println("[8] - ?");
            System.out.println("[9] - Get value of nth element");
            System.out.println("[10] - Back to main menu");

            System.out.print("Your choice: ");

            short response = in.nextShort();

            switch (response)
            {

                case 1:
                    maxValue(tab);
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
                    break;

                case 8:
                    break;

                case 9:

                  System.out.println("Enter the item number: ");
                  int n = in.nextInt();
                  System.out.println("Value of " + n +"element is: " + getValue(tab, n));
                  break;

              case 10:
                  break;

                default:
                    break;

            }
        }

    }

    private void maxValue(int[] tab)
    {
        int max=0;
        for (int i=0; i<10; i++)
        {
            if (tab[i] > max)
                max = tab[i];
        }

        System.out.println("The biggest value in array: " + max);
    }

    private int getValue(int[] tab, int n){

      return tab[n];
    }
}
