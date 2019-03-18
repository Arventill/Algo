class Exercise4 {


  static double raiseToPower(double number, int exponent){

    double temp = 1;

    for (double i = 1; i <=exponent; i++){

      temp *= number;

    }

    return temp;

  }
}
