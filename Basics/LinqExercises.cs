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
    
    public string SquareGreaterThan20(int[] numbers) {
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

    public string ReplaceSubstring(string[] strings) {
        string result = "";
        var newStrings = strings.Select(str => str.Contains("ea") ? str.Replace("ea", "*") : str);

        foreach(string str in newStrings) {
            result += str == newStrings.Last() ? str : str + ", ";
        }

        return result;
    }

    public char MostFrequentCharacter(string str) {
        var mostFrequentCharacter = str.GroupBy(s => s).OrderByDescending(s => s.Count()).First().Key;
        return mostFrequentCharacter;
    }

    public string UniqueValues(string[] strings) {
        IEnumerable<string> uniqueStrings = strings
        .GroupBy(str => str)
        .Where(str => str.Count() == 1)
        .Select(str => str.Key);
        
        string result = "";
        foreach(string str in uniqueStrings) {
            result += str == uniqueStrings.Last() ? str : str + ", ";
        }

        return result;
    }

    public string UppercaseOnly(string str) {
        string[] substrings = str.Split(" ");
        IEnumerable<string> uppercaseStrings =
        substrings
        .Where(s => string.Equals(s, s.ToUpper()));
        string result = "";

        foreach(string s in uppercaseStrings) {
            result += s == uppercaseStrings.Last() ? s : s + ", ";
        }

        return result;
    }

    public int DotProduct(int[] arr1, int[] arr2) {
        var dotProduct = arr1.Zip(arr2, (first, second) => first * second).Sum();
        return dotProduct;
    }

    public string FrequenceOfLetters(string str) {
        string result = "";

        var letters = str.GroupBy(s => s);

        foreach(var l in letters) {
            result += $"Letter {l.Key} occurs {l.Count()} time(s), ";
        }

        return result;
    }




}