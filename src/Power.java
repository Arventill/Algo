class Power {


  static int raiseToPower(int number, int exponent){

    int temp = 1;

    for (int i = 1; i <=exponent; i++){

      temp *= number;

    }

    return temp;

  }
}
