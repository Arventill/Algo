import java.util.Scanner;

public class Exercise6 {

    Scanner in = new Scanner(System.in);

    public void menu(int tab[])
    {
        for (int i=0; i<10; i++)
        {
            tab[i] = in.nextInt();
        }

        while (true)
        {
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
