import java.util.Scanner;

public class Exercise6 {

    Scanner in = new Scanner(System.in);

    public void menu(int tab[])
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
            System.out.println("[9] - ?");
            System.out.println("[10] - Back to main menu");

            System.out.print("Your choice: ");
            short response = in.nextShort();
            switch (response)
            {
                case 1: {
                    maxValue(tab);
                    break;
                }
                case 2: {
                    break;
                }
                case 3: {
                    break;
                }
                case 4: {
                    break;
                }
                case 5: {
                    break;
                }
                case 6: {
                    break;
                }case 7: {
                    break;
                }
                case 8: {
                    break;
                }
                case 9: {
                    break;
                }
                case 10: {
                    return;
                }

                default: {
                    break;
                }
            }
        }

    }

    private void maxValue(int tab[])
    {
        int imax=0;
        for (int i=0; i<10; i++)
        {
            if (tab[i] > imax)
                imax = tab[i];
        }

        System.out.println("Największa wartość w tablicy: " + imax);
    }
}
