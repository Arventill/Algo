public class Excercise2a {
    static int result(int liczba1, int liczba2)
    {

        if(liczba1%liczba2==0)
            return liczba2;
        else
        {
            do
            {
                liczba2--;
            } while (liczba1 % liczba2 != 0);

            return liczba2;
        }
    }
}
