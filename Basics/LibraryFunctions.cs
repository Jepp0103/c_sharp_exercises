using System;
public class LibraryFunctions {

    public double NegativeOrPositive(double number) {
        double result = number < 0 ? Math.Pow(number, 2) : Math.Sqrt(number);
        return result;
    }

    public string ReplaceXWithY(string str) {
        string replacedString = str.Contains("y") ? str.Replace("y", "x") : str;
        return replacedString;
    }

    public string ToLowerOrToUpper(string str) {
        string[] strings = str.Split(" ");
        string result = "";
        for(int i = 0; i < strings.Length; i++) {
            result += i % 2 == 0 ? strings[i].ToUpper() + " " : strings[i].ToLower() + " ";
        }

        return result;
    }

    public string IfStartsWithLowerCase(string str) {
        string[] strings = str.Split(" ");
        string result = "";

        for(int i = 0; i < strings.Length; i++) {
            Console.WriteLine("strings: " + strings[i]);
            result += Char.IsLower(strings[i][0]) ? strings[i].Remove(0,1) + " " : strings[i] + " ";
        }

        return result;
    }
}