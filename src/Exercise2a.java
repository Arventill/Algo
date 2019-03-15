class Exercise2a {
    static int result(int number1, int number2)
    {

        if(number1%number2==0)
            return number2;
        else
        {
            do
            {
                number2--;
            } while (number1 % number2 != 0);

            return number2;
        }
    }
}
