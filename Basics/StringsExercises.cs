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

    public int NumberOfWords(string sentence) {
        int numberOfWords = 0;
        for(int i = 0; i < sentence.Length; i++) {
            if (sentence[i] == ' ') {
                numberOfWords++;
            }
        }
        return numberOfWords + 1;
    }

    public int HowManyOccurrences(string words, string word) {
        int occurences = 0;
        int found;
        for(int i = 0; i < words.Length; i++) {
            found = words.IndexOf(word, i);
            if (found > -1) {
                occurences++;
                i = found;
            }
        }   
        return occurences;
    }

    public char[] SortCharactersDescending(string str) {
        char[] descCharArray = str.ToCharArray();

        for(int i = 1; i < str.Length; i++) {

            for(int j = 0; j < str.Length - 1; j++) {
                if(descCharArray[j] < descCharArray[j + 1]) {
                    char temp = descCharArray[j];
                    descCharArray[j] = descCharArray[j + 1];
                    descCharArray[j + 1] = temp;
                }
            }
        }

        return descCharArray;
    }
}