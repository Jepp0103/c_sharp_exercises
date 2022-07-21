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

}