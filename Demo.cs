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
            foreach (var s in sortedArr) {
                Console.Write($"{s} "); // -51 -23 -1 0 1 9 18 25 57 90
            }
        }
    }
}
