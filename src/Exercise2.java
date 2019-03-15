class Exercise2 {

    static int nwd(int liczba1, int liczba2)
    {
        if(liczba1 != 0 && liczba2 != 0) {
            while (liczba1 != liczba2) {
                if (liczba1 > liczba2) {
                    liczba1 = liczba1 - liczba2;
                }
                else liczba2=liczba2-liczba1;
            }

        }
        return liczba1;
    }


    static int nww(int l1, int l2)
    {
        int temp, ab;
        if(l1 != 0 || l2 != 0)
        {
            ab = l1 * l2;
            while(l2 == 0)
            {
                temp=l2;
                l2=l1%l2;
                l1=temp;
            }
            if(l1 != 0 && l2 != 0) {
                while (l1 != l2) {
                    if (l1 > l2) {
                        l1 = l1 - l2;
                    }
                    else l2=l2-l1;
                }

            }
            ab=ab/l1;
            l1=ab;
        }
        return l1;
    }
}
