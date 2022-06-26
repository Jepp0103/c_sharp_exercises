using System;
class ConditionalStatements {

    public int AbsoluteValue(int number) {
        return number >= 0 ? number : number * -1;
    }

    public int DivisibleBy2Or3(int arg1, int arg2) {
        if ((arg1 % 2 == 0 && arg2 % 2 == 0) || (arg1 % 3 == 0 && arg2 % 3 == 0) || (arg1 % 3 == 0 && arg2 % 2 == 0) || (arg1 % 2 == 0 && arg2 % 3 == 0)) {
            return arg1 * arg2;
        } else {
            return arg1 + arg2;
        }
        //Sample solution: return (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;
    }

    public bool IfConsistsOfUppercaseLetters(string character) {
        return ((character[0] >= 65 && character[1] >= 65 && character[2] >= 65) && (character[0] >= 90 && character[1] >= 90 && character[2] >= 90));
    }

    public bool IfGreaterThanThirdOne(int[] numbers) {
        // if (numbers.Length == 3 && ((numbers[0] * numbers[1]) > numbers[2] || (numbers[0] + numbers[1]) > numbers[2])) {
        //     return true;
        // } else {
        //     return false;
        // }

        return numbers[0] * numbers[1] > numbers[2] || (numbers[0] + numbers[1]) > numbers[2];
    }

    public bool IfNumberIsEven(int number) {
        return number % 2 == 0 ? true : false;
    }

    public bool IfSortedAscending(int[] numbers) {
        return numbers[0] < numbers[1] && numbers[1] < numbers[2];
    }

    public bool IsLonelyIsland(string character) {
        return character[0] == character[1] - 1 || character[1] == character[2] - 1 || character[0] == character[1] + 1 || character[1] == character[2] + 1;
    }

    public string PositiveNegativeOrZero(double number){
        if (number > 0) {
            return "positive";
        } else if (number == 0.0) {
            return "zero";
        } else {
            return "negative";
        }
    }

    public bool IfYearIsLeap(int year) {
        return DateTime.IsLeapYear(year);
    }

    public bool IfNumberContains3(int number){
        while (number > 0) {
            if (number % 10 == 3) {
                return true;
            }

            number /= 10;
        }

        return false;
    } 
}