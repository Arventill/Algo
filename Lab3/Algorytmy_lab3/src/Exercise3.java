class Exercise3 {

  static void printFibonacciSequence(int n){

    long[] tab = new long[n];
    tab[0] = 1;
    tab[1] = 1;

    for (int i = 2; i < n; i++){

      tab[i] = tab[i-1] + tab[i-2];

    }

    for(int i = 0; i < n; i++) System.out.println((i+1) + " element of the seqence: " + tab[i]);

  }
}
