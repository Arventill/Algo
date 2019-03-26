public class Exercise2 {
    public static void result(double [][] tab)
    {
        double [][] tab2 = {{1,2,3}, {4,5,6}, {7,8,9}};
        double [][] resTab = new double[3][3];
        double [][] transTab = new double[3][3];
        double [][] hTab = new double[3][5];

        // mnożenie macierzy
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int res = 0;
                for (int k = 0; k < 3; k++)
                {
                    res += tab[i][k]*tab2[k][j];
                }
                resTab[i][j] = res;
            }
        }

        for (int i = 0; i < 3; i++)
        {
                System.out.println(resTab[i][0] + ", " + resTab[i][1] + ", " + resTab[i][2] + "\n");
        }

        //transpozycja macierzy
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                transTab[i][j] = tab[j][i];
                hTab[i][j] = tab[i][j];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            System.out.println(transTab[i][0] + ", " + transTab[i][1] + ", " + transTab[i][2] + "\n");
        }

        //obliczanie wyznacznika
        for (int i = 0; i < 3; i++)
        {
            for (int j = 3, k = 0; j <= 4; j++, k++)
            {
                hTab[i][j] = tab[i][k];
            }
        }


        double res = 0;

        double s;
        for (int t = 0; t < 3; t++)
        {
            s=1;
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                s *= hTab[i][j];
            }
            res += s;
        }

        System.out.println(res);


        for (int t = 0; t < 3; t++)
        {
            s = 1;
            for (int i = 2, j = 0; i >= 0; i--, j++)
            {
                s *= hTab[i][j];
            }
            res -= s;
        }
            System.out.println(res);
    }
}
