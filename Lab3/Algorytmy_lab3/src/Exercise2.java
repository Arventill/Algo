public class Exercise2 {
    public static void result(double[][] tab) {
        double[][] tab2 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        double[][] resTab = new double[3][3];
        double[][] transTab = new double[3][3];
        double[][] hTab = new double[3][5];

        // mnożenie macierzy
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                int res = 0;
                for (int k = 0; k < 3; k++) {
                    res += tab[i][k] * tab2[k][j];
                }
                resTab[i][j] = res;
            }
        }

        System.out.println(Color.PURPLE + "[Your matrix] * [123; 456; 789] matrix =" + Color.DEFAULT);
        for (int i = 0; i < 3; i++) {
            System.out.println(resTab[i][0] + ", " + resTab[i][1] + ", " + resTab[i][2] + "\n");
        }System.out.println();

        //transpozycja macierzy
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                transTab[i][j] = tab[j][i];
                hTab[i][j] = tab[i][j];
            }
        }

        System.out.println(Color.PURPLE + "Transpozition of your matrix:" + Color.DEFAULT);
        for (int i = 0; i < 3; i++) {
            System.out.println(transTab[i][0] + ", " + transTab[i][1] + ", " + transTab[i][2] + "\n");
        }System.out.println("");

        //obliczanie wyznacznika
        for (int i = 0; i < 3; i++) {
            for (int j = 3, k = 0; j <= 4; j++, k++) {
                hTab[i][j] = tab[i][k];
            }
        }


        double res = 0;

        double s = 1;

        for (int j = 0, k = 0; k < 3; k++)
        {
            for (int i = 0; i < 3; i++, j++)
            {
                s *= hTab[i][j];
            } res += s; s = 1;
            j=k+1;
        }

        for (int j = 0, k = 0; k < 3; k++)
        {
            for (int i = 2; i >= 0; i--, j++)
            {
                s *= hTab[i][j];
            } res -= s; s = 1;
            j=k+1;
        }

        System.out.println(Color.PURPLE + "determinant of your matrix:" + Color.DEFAULT);
        System.out.println(res);

    }
}