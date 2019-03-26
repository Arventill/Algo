class Exercise6 {

  static void doMath(double a, double b, double c, double d, double A, double B) {

    double w = a * d - c * b;
    double wx = A * d - B * b;
    double wy = a * B - c * A;

    if (w == 0 && wx == 0 && wy == 0) {
      System.out.println("The system has infinitely many solutions.");
    }
    if (w == 0 && wx != 0 && wy != 0) {
      System.out.println("The system has no solution.");
    }
    if (w != 0 && wx != 0 && wy != 0) {
      System.out.println("Solutions: " + "\n" + "x = " + wx / w + "\n" + "y = " + wy / w);
    }

  }

}
