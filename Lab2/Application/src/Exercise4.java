class Exercise4 {


  static double raiseToPower(double number, int exponent){

    double result = 1;

    for (double i = 1; i <=exponent; i++){
      result *= number;
    }
    return result;
  }
}
