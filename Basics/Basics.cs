using System;
class Basics {

    public int AddAndMultiply (int arg1, int arg2, int arg3) {
        int result = (arg1 + arg2) * arg3;
        return result;
    }

    public String CelciusToFahrenHeit(int arg) {
        int result = (int)(arg * 1.8 + 32);
        if ((double)result < -271.15) {
            return "Temperature below absolute zero!";
        } else {
            return String.Format($"T= {result}");
        }
    }

    public String ElementaryOperations(int arg1, int arg2) {
        int addition = (arg1 + arg2);
        int substraction  = (arg1 - arg2);
        int multiplication  = (arg1 * arg2);
        int division = (arg1 / arg2);
        return String.Format($"a + b = {addition}, a - b = {substraction}, a * b = {multiplication}, a / b = {division}");
    }

    public Boolean IsResultTheSame(int arg1, int arg2) {
        if (arg1 == arg2) {
            return true;
        } else {
            return false;
        }
    }

    public int ModuloOperations(int arg1, int arg2, int arg3) {
        int modulo = arg1 % arg2;
        int result = modulo % arg3;
        return result;
    }

    public double TheCubeOf(double number) {
        return (double)Math.Pow(number, 3);
    }

    public String SwapTwoNumbers(int arg1, int arg2) {
        int a = arg2;
        int b = arg1;
        return String.Format($"Before: a= {arg1}, b={arg2}; After: a={a}, b= {b}");
    }


}