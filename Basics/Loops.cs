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
        int currentNumber;
        int nextNumber;

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
            // if(i == )
        }

        return true;
    }
    
}