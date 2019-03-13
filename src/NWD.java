public class NWD {
    static int result(int liczba1, int liczba2)
    {

        if(liczba1%liczba2==0) return liczba2;//jak reszta jest zero to jest zajebiscie
        else {
            do {
                liczba2--;
            } while (liczba1 % liczba2 != 0);
            //no zajebiscie
            return liczba2;
        }
    }
}
