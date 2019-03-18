class Exercise7 {

    static  void function(double a, double b, double c)
    {
        if (a != 0) {
            if (b == 0) {
                if (c == 0)
                    System.out.println("x = 0");
                else
                    System.out.println(-c / a);
            }
            else {
                if (c == 0) System.out.println("x = 0" + -b / a);
                else {
                    double delta = (b * b) - (4 * a * c);
                    double sqrt_delta = Math.sqrt(delta);
                    if (delta > 0) {
                        double x1, x2;
                        x1 = (-b - sqrt_delta) / (2 * a);
                        x2 = (-b + sqrt_delta) / (2 * a);
                        System.out.println("x1 = " + x1 + ", x2 = " + x2);
                    } else if (delta == 0) {
                        System.out.println("x = " + -b / (2 * a));
                    } else {
                        System.out.println("No elements in the set of real numbers.");
                    }
                }
            }
        }
        else
        if (b == 0) {
            if (c == 0)
                System.out.println("    identity");
            else
                System.out.println("    contradictory");
        } else {
            if (c == 0)
                System.out.println("x = 0");
            else
                System.out.print("x = " + -c / b);
        }
    }
}
