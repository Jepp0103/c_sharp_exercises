using System;
using System.Linq;
using System.Collections.Generic;
public class LinqExercises {

    public string NumbersFromRange(int[] numbers) {
        string result = "";
        IEnumerable<int> rangedNumbers = 
            from number in numbers 
            where number > 30 && number < 100
            select number;

        foreach(int i in rangedNumbers) {
            result += i == rangedNumbers.Last() ? i.ToString() : i + ", ";
        }

        return result;
    }

    public string MinimumLength(string[] words) {
        string result = "";
        IEnumerable<string> fiveCharWords =
            from word in words
            where word.Length >= 5
            select word.ToUpper();

        foreach(string word in fiveCharWords) {
            result += word == fiveCharWords.Last() ? word : word + ", ";
        }

        return result;
    }

    public string AStartMEndWords(string[] words) {
        string result = "";
        IEnumerable<string> amWords = 
        from word in words 
        where word.StartsWith("a") && word.EndsWith("m")
        select word;

        foreach(string word in amWords) {
            result += word == amWords.Last() ? word : word + ", ";
        }

        return result;
    }

    public string Top5Numbers(int[] numbers) {
        string result = "";
        IEnumerable<int> topFiveNumbers = numbers.OrderByDescending(number => number).Take(5);

        foreach(int number in topFiveNumbers) {
            result += number == topFiveNumbers.Last() ? number.ToString() : number + ", ";
        }

        return result;
    }
    
    public string SquareGreaterThan20 (int[] numbers) {
        string result = "";

        IEnumerable<int> squaredNumbersGreaterThan20 = 
        from number in numbers
        where number * number > 20
        select number;

        foreach(int number in squaredNumbersGreaterThan20) {
            result += number == squaredNumbersGreaterThan20.Last() ? number.ToString() + " - " + number * number 
            : number + " - " + number * number + ", ";
        }

        return result;
    }
    
}