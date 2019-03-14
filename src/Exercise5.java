class Exercise5 {


  static int addingUp(int number) {

    int sum = 0;

    while (number != 0) {

      sum += number % 10;
      number /= 10;

    }

    return sum;

  }
}
