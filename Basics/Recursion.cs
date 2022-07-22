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
}