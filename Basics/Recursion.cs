using System;

public class Recursion {

    public int DigitsMultiplication(int number) {
        int multiSum = 0;
        string stringNumber = number.ToString();
        for(int i = 0; i < stringNumber.Length; i++) {
            multiSum = i == 0 ? multiSum += stringNumber[i] - '0' : multiSum = multiSum * (stringNumber[i] - '0');
        }

        return multiSum;
    }

    public int Factorial(int number) {
        int factorial = 0;
        int muliplier = number;
        for(int i = 1; i < number; i++) {
            factorial = i == 1 ? factorial += number : factorial = factorial * muliplier;
            muliplier--;
        }
        return factorial;
    }

    public int NumbersMultiplication(int val1, int val2) {
        int multipliedValue = 0;
        int currentValue = val1;
        for(int i = 0; i < (val2 - val1); i++) {
            multipliedValue = i == 0 ? multipliedValue += val1 : multipliedValue = multipliedValue * currentValue;
            currentValue++;
        }

        if (val1 == val2) {
            return val1;
        } else {
            return multipliedValue * val2;    
        }
    }

    public double ToThePowerOfRecursion(int number1, int number2) {
        return Math.Pow(number1, number2);
    }
    
}