import java.util.Scanner;

public class Exercise4 {
    static void calculator(double no1, double no2)
    {
        System.out.println("choose the option \n[1] - Addition\n[2] - Substraction\n" +
                "[3] - Multiplication\n[4] - Division ");
        System.out.print("Your ption: ");
        Scanner scan= new Scanner(System.in);
        int response = scan.nextInt();
        switch (response) {
            case 1:
                System.out.println(no1+no2);
            break;
            case 2:
                System.out.println(no1-no2);
            break;
            case 3:
                System.out.println(no1*no2);
            break;
            case 4:
                if(no2 != 0) {
                    System.out.println(no1 / no2);
                    return;
                }
                else {
                    System.out.println("can not divided by 0");
                    break;
                }
            default:
                break;
        }
    }
}
