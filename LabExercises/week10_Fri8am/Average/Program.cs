﻿using System.Diagnostics.CodeAnalysis;

class Program
{
    public static double average(int[] inputArray) {
        int sum = 0; 
        foreach (var item in inputArray)
        {
            sum = sum + item;
        }
        return (double) sum / inputArray.Length;
    }

    public static void arrayChange(int[] inputArray){
        // change the 0th element of the inputArray
        inputArray[0] = 1000;
    }

    public static void numberChange(int input){
        //change input
        input = 3000;
    }

    public static void printArray(int[] inputs){
        foreach (var item in inputs)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        int[] numbers = new int[10]; 
        numbers = [2, 4, 13, 12, 11, 9, 25, 2, 64,99];
        //pass numbers to average method and get the average and display it

        int[] numbers_ = {2, 4, 13, 12, 11, 9, 25, 2, 64,99};
        double ave = average(numbers);
        Console.WriteLine("the average of the array elemets is: " + ave);

        Console.WriteLine("numbers before arrayChange call");
        printArray(numbers);

        arrayChange(numbers);
        Console.WriteLine("numbers after arrayChange call");
        printArray(numbers);


        int number = 10; 
        Console.WriteLine("number before numberChange call: " + number);
        numberChange(number); 
        Console.WriteLine("number after numberChange call: " + number);        
    }
}