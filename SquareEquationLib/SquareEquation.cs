namespace SquareEquationLib;

using System;
public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        if (a == 0  new[] { a, b, c }.Any(double.IsNaN)  new[] { a, b, c }.Any(double.IsInfinity))
        {
            throw new ArgumentException("smth went wrong :/");
        }
        double x1;
        double x2;
        double[] nums = new double[2];
        double d = b * b - 4 * a * c;
        if (d == 0)
        {
             x1 = -b / (2 * a);
             nums = new double[] { x1 };
        }
        else
        {
             x1 = -(b + Math.Sign(b) + Math.Sqrt(d)) / 2;
             x2 = c / x1;
             nums = new double[] { x1, x2 };
        }
        if (d < 0)
        {
            nums = new double[0];
        }
        return nums;
    }
}
