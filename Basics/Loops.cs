using System;
using System.Linq;

class Loops {

    public void MultiplicationTable() {
        for (int i = 1; i <= 10; i++){
                for (int j = 1; j <= 10; j++) {
                    if (i == 1) {
                        if (i * j < 10) {
                            Console.Write($" {i * j} ");
                        } else {
                            Console.Write($"{i * j} ");
                        }
                    }
                    else if (i > 1 && i < 10) {
                        if (i * j < 10) {
                            Console.Write($" {i * j} ");
                        } else {
                            Console.Write($"{i * j} ");
                        }
                    } else {
                        Console.Write($"{i * j} ");
                    }
                }
                Console.WriteLine();
            }
    }

    public double FractionsSum(int number) {
        double fraction_sum = 0.0;
        for(int i = 1; i < number; i++) {
            fraction_sum += (1 / (double)(i * i));
        }
        return fraction_sum;
    }

    public int[] SortArrayAscending(int[] numbers) {
       int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

        return numbers;
    }

    public int TheBiggestNumber(int[] numbers) {
        return numbers.Max();
    }

    public int Two7sNextToEachOther(int[] numbers) {
        int amountOf7s = 0;

        for(int i = 0; i < numbers.Length; i++) {
            if (i != 0) {
                if(numbers[i - 1] == numbers[i]) {
                    amountOf7s++;
                }
            }
        }
        
        return amountOf7s;
    }

    public bool ThreeIncreasingAdjacent(int[] numbers) {
        for(int i = 0; i < numbers.Length; i++) {
            if (i != 0) {
                if(numbers[i - 1] == numbers[i] - 1 && numbers[i + 1] == numbers[i] + 1) {
                    return true;
                }
            }
        }
        return false;
    }
    
    public string ReturnEvenNumbers() {
        string evenNumbers = "";

        for(int i = 1; i < 100; i++) {
            if(i % 2 == 0) {
                evenNumbers += i + " ";
            }
        }

        return evenNumbers;
    }

    public bool[] SieveOfEratosthenes(int n) {
        bool[] array = new bool[n];
        for (int i = 2; i < n; i++){
            array[i] = true;
        }

        for (int j = 2; j * j <= n; j++){
            if (array[j] == true) {
                for (int k = j * j; k < n; k += j) {
                    array[k] = false;
                }
            }
        }

        return array;
    }

    public void DrawParallelogram() {
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5 - i; j++) {
                Console.Write(" ");
            }

            for(int k = 0; k < 15; k++) {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }

    public string FullSequenceOfLetters(string word) {
        string fullSequence = "";
        
        for(int i = word[0], j = 0; i <= word[1]; i++, j++) {
            fullSequence += (char)(word[0] + j);
        }

        return fullSequence;
    }

    
}