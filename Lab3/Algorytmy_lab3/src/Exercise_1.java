public class Exercise_1 {
    static void triangle(double tab[]) {

        double p;
        double temp;
        if (tab[0] <= 0 || tab[1] <= 0 || tab[2] <= 0) {
            System.out.println("that triangle does not exist");
        } else {
            for (int i=0; i<2; i++)
            {
                if(tab[i]>tab[i+1])
                {
                    temp=tab[i];
                    tab[i]=tab[i+1];
                    tab[i+1]=temp;
                }

            }
            if (tab[0] + tab[1] > tab[2] ) {
                System.out.println(tab[0] + tab[1] + tab[2]);
                p=(tab[0]+tab[1]+tab[2])/2;
                System.out.println(Math.sqrt(p*(p-tab[0])*(p-tab[1])*(p-tab[2])));
            }
            else
                System.out.println("that triangle does not exist");
        }
    }
}
