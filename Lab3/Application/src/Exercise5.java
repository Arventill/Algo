import java.util.Random;
import java.util.Scanner;

class Exercise5 {

  static void checkNumber(){
    Scanner in = new Scanner(System.in);
    Random random = new Random();

    System.out.println("Your answer: ");
    int number = 0;
    int answer = random.nextInt(15) + 1;

    while(number != answer) {
      number = in.nextInt();
      if (number > answer) {
        System.out.println("To large number. Try again: ");
      }
      if (number < answer) {
        System.out.println("To small number. Try again: ");
      }
    }
    System.out.println("Congratulations! You guessed the number: " + answer);
    }


  }
