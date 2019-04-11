package com.company;

public class Exercise1 {
    public static void result()
    {
        System.out.println("Perfect number from <2,30>");

        for (int i = 2; i <= 30; i++)
        {
            if (check(i) == true)
                System.out.println(i + ", ");
        }
    }

    private static boolean check(int k)
    {
        int sum = 0;
        for (int i = 1; i < k; i++)
        {
            if (k%i == 0)
                sum += i;
        }

        if (sum == k)
            return true;
        else
            return false;
    }
}
