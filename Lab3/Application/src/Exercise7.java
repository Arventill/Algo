class Exercise7 {

  static void runPrimalityTest(int number) {

    boolean test = true;
    double divisor = Math.sqrt(number);

    for (int i = 2; i <= divisor; i++){

      if(number % i == 0){
        test = false;
        break;
      }

    }

    if(!test) System.out.println("Given number is not a prime number.");
    if(test) System.out.println("Given number is a prime number.");
  }

}
