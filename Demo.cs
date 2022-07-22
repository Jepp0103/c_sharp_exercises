using System;

namespace c_sharp_exercises
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("BASICS DEMO");
            Basics b = new Basics();
            Console.WriteLine(b.AddAndMultiply(2,4,5));

            Console.WriteLine("CTFO: " + b.CelciusToFahrenHeit(0));
            Console.WriteLine("CTFO: " + b.CelciusToFahrenHeit(100));
            Console.WriteLine("CTFO: " + b.CelciusToFahrenHeit(-300));

            Console.WriteLine("ELM OP: " + b.ElementaryOperations(3,8));
            Console.WriteLine("RESULT THE SAME: " + b.IsResultTheSame(2+2, 2*2));
            Console.WriteLine("RESULT THE SAME: " + b.IsResultTheSame(9/3, 16-1));
            Console.WriteLine("MODULO: " + b.ModuloOperations(8,5,2));
            Console.WriteLine("CUBE: " + b.TheCubeOf(2));
            Console.WriteLine("CUBE: " + b.TheCubeOf(-5.5));
            Console.WriteLine("SWAP TWO NUMBERS: " + b.SwapTwoNumbers(87, 45));
            Console.WriteLine("SWAP TWO NUMBERS: " + b.SwapTwoNumbers(-13, 2));
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("CONDITIONALS DEMO:");
            ConditionalStatements c = new ConditionalStatements();
            Console.WriteLine("ABSOLUTE VALUE: " + c.AbsoluteValue(6832));
            Console.WriteLine("ABSOLUTE VALUE: " + c.AbsoluteValue(-392));
            Console.WriteLine("DIVISIBLE BY 2 OR 3: " + c.DivisibleBy2Or3(15,30));
            Console.WriteLine("DIVISIBLE BY 2 OR 3: " + c.DivisibleBy2Or3(2,90));
            Console.WriteLine("DIVISIBLE BY 2 OR 3: " + c.DivisibleBy2Or3(7,12));
            Console.WriteLine("Uppercase letters: " + c.IfConsistsOfUppercaseLetters("xyz"));
            Console.WriteLine("Uppercase letters: " + c.IfConsistsOfUppercaseLetters("DOG"));
            Console.WriteLine("Uppercase letters: " + c.IfConsistsOfUppercaseLetters("L9#"));
            Console.WriteLine("If greater than third one: " + c.IfGreaterThanThirdOne(new int[]{2, 7, 12}));
            Console.WriteLine("If greater than third one: " + c.IfGreaterThanThirdOne(new int[]{-5, -8, 50}));
            Console.WriteLine("Is number even: " + c.IfNumberIsEven(721));
            Console.WriteLine("Is number even: " + c.IfNumberIsEven(1248));
            Console.WriteLine("Is numbers sorted ascending: " + c.IfSortedAscending(new int[]{3, 7, 10}));
            Console.WriteLine("Is numbers sorted ascending: " + c.IfSortedAscending(new int[]{74, 62, 99}));
            Console.WriteLine("Has neighbours: " + c.IsLonelyIsland("XYZ"));
            Console.WriteLine("Has neighbours: " + c.IsLonelyIsland("GWK"));
            Console.WriteLine("Has neighbours: " + c.IsLonelyIsland("ABL"));
            Console.WriteLine("Positive, negative or zero: " + c.PositiveNegativeOrZero(5.24));
            Console.WriteLine("Positive, negative or zero: " + c.PositiveNegativeOrZero(0.0));
            Console.WriteLine("Positive, negative or zero: " + c.PositiveNegativeOrZero(-994.53));
            Console.WriteLine("Leap year: " + c.IfYearIsLeap(2016));
            Console.WriteLine("Leap year: " + c.IfYearIsLeap(2018));
            Console.WriteLine("Number contains 3: " + c.IfNumberContains3(7201432));
            Console.WriteLine("Number contains 3: " + c.IfNumberContains3(87501));
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("LOOPS DEMO:");
            Loops l = new Loops();
            l.MultiplicationTable();
            Console.WriteLine("Fraction sum: " + l.FractionsSum(3));
            Console.WriteLine("Fraction sum: " + l.FractionsSum(5));
            
            int[] sortedArr = l.SortArrayAscending(new int[] { 0, -23, 9, 18, -51, 1, 90, 57, -1, 25 });
            // foreach (var s in sortedArr) {
            //     Console.Write($"{s} "); // -51 -23 -1 0 1 9 18 25 57 90
            // }

            Console.WriteLine("Max number in array: " + l.TheBiggestNumber(new int[] {190, 291, 145, 209, 280, 300}));
            Console.WriteLine("Numbers of 7s next to each other: " + l.Two7sNextToEachOther(new int[] {8, 2, 5, 7, 9, 0, 7, 7, 3, 1}));
            Console.WriteLine("Numbers of 7s next to each other: " + l.Two7sNextToEachOther(new int[] {9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7}));
            Console.WriteLine("Three increasing adjacent: " + l.ThreeIncreasingAdjacent(new int[] {45, 23, 44, 68, 65, 70, 80, 81, 82}));
            Console.WriteLine("Three increasing adjacent: " + l.ThreeIncreasingAdjacent(new int[] {7, 3, 5, 8, 9, 3, 1, 4 }));
            Console.WriteLine("Three increasing adjacent: " + l.ThreeIncreasingAdjacent(new int[] {45, 23, 44, 45, 46, 70, 80, 81, 82}));
            Console.WriteLine("Three increasing adjacent: " + l.ThreeIncreasingAdjacent(new int[] {1, 2, 3, 8, 9, 3, 1, 4 }));
            Console.WriteLine("Even numbers: " + l.ReturnEvenNumbers());

            // var arrayOfPrimes = l.SieveOfEratosthenes(30);
            // for (int i = 0; i < arrayOfPrimes.Length; i++)
            // {
            //     if (arrayOfPrimes[i] != false)
            //     {
            //         Console.Write($"{i} "); // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 
            //     }                           
            // }         

            Console.WriteLine("Parallelogram: ");
            l.DrawParallelogram();

            Console.WriteLine("Full sequence of letters: " + l.FullSequenceOfLetters("ak"));
            Console.WriteLine("Full sequence of letters: " + l.FullSequenceOfLetters("eh"));
            
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("STRINGS DEMO:");
            StringsExercises s = new StringsExercises();
            Console.WriteLine("Add seperator: " + s.AddSeperator("ABCD", "^"));
            Console.WriteLine("Add seperator: " + s.AddSeperator("chocolate", "-"));
            Console.WriteLine("Length of string: " + s.LengthOfString("computer"));
            Console.WriteLine("Length of string: " + s.LengthOfString("ice cream"));
            Console.WriteLine("String reversed: " + s.StringInReverseOrder("qwerty"));
            Console.WriteLine("Sum of digits in string: " + s.SumDigitsInString("ss11234"));
            Console.WriteLine("Make upper case word: " + s.MakeUppercase("modem"));
            Console.WriteLine("Make upper case word: " + s.MakeUppercase("BookWorm"));
            Console.WriteLine("Make upper case word: " + s.MakeUppercase("Aliquam dolor nisl?"));
            Console.WriteLine("Mixed two strings: " + s.MixTwoStrings("aaa", "BBB"));
            Console.WriteLine("Mixed two strings: " + s.MixTwoStrings("good one", "111"));
            Console.WriteLine("Number of words: " + s.NumberOfWords("This is sample sentence df"));
            Console.WriteLine("Number of words: " + s.NumberOfWords("OK s"));
            Console.WriteLine("Occurences word: " + s.HowManyOccurrences("dot it now", "do"));
            Console.WriteLine("Occurences word: " + s.HowManyOccurrences("empty", "d"));
            Console.WriteLine("Sort characters descending: " + s.SortCharactersDescending("onomatopoeia"));
            Console.WriteLine("Sort characters descending: " + s.SortCharactersDescending("fohjwf42os"));
            

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("RECURSION DEMO:");
            Recursion r = new Recursion();
            Console.WriteLine("Digits multiplication: " + r.DigitsMultiplication(456));
            Console.WriteLine("Digits multiplication: " + r.DigitsMultiplication(123));

        }
    }
}
