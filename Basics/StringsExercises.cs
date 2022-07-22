using System;

class StringsExercises {

    public string AddSeperator(string word, string seperator) {
        string seperatorString = "";

        for(int i = 0; i < word.Length; i++) {
            seperatorString += word[i] + seperator;
        }

        return seperatorString.Substring(0, seperatorString.Length - 1);
    }

    public int LengthOfString(string word) {
        int n = 0;
        foreach(char c in word) {
            n++;
        }

        return n;
    }

    public string StringInReverseOrder(string word) {
        string reversedWord = "";
        for(int i = word.Length - 1; i >= 0; i--) {
            reversedWord += word[i];
        }

        return reversedWord;
    }

    public int SumDigitsInString(string word) {
        int sum = 0;

        for (int i = 0; i < word.Length; i++) {
            if(char.IsDigit(word[i])) {
                sum += (int)char.GetNumericValue(word[i]);
            }
        }

        return sum;
    }

    public string MakeUppercase(string word) {
        string upperCaseWord = "";
        int letterIndex = 0;
        for(int i = 0; i < word.Length; i++) {    
            if(word[i] >= 'a' && word[i] <= 'z' && letterIndex % 2 == 0) {
                upperCaseWord += (char)(word[i] - 32);
                letterIndex++;
            } else {
                upperCaseWord += word[i];
                letterIndex++;
            }
        }

        return upperCaseWord;
    }

    public string MixTwoStrings(string str1, string str2) { //Mixing strings
        string mixedString = "";
        int wordLength = str1.Length > str2.Length ? wordLength = str1.Length : wordLength = str2.Length;

        for(int i = 0; i < wordLength; i++) {
            if(i < str1.Length) {
                mixedString += str1[i];
            }

            if(i < str2.Length) {
                mixedString += str2[i];
            }
        }

        return mixedString;
    }

}