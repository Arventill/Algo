class Exercise2 {

    static int nwd(int n1, int n2)
    {
        if(n1 != 0 && n2 != 0) {
            while (n1 != n2) {
                if (n1 > n2) {
                    n1 -= n2;
                }
                else n2 -= n1;
            }
        }
        return n1;
    }


    static int nww(int n1, int n2)
    {
        int temp, ab;
        if(n1 != 0 || n2 != 0)
        {
            ab = n1 * n2;
            while(n2 == 0)
            {
                temp=n2;
                n2=n1%n2;
                n1=temp;
            }
            if(n1 != 0 && n2 != 0) {
                while (n1 != n2) {
                    if (n1 > n2) {
                        n1 = n1 - n2;
                    }
                    else n2=n2-n1;
                }
            }
            ab=ab/n1;
            n1=ab;
        }
        return n1;
    }
}
