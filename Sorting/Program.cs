﻿using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] data = GenerateRandomArray(1000000);

        //// Bubble Sort
        //int[] bubbleSortData = (int[])data.Clone();
        //Stopwatch stopwatch = Stopwatch.StartNew();
        //ReyRom.Sorting.BubbleSort(bubbleSortData);
        //stopwatch.Stop();
        //Console.WriteLine($"Bubble Sort Time: {stopwatch.ElapsedMilliseconds} ms");

        // Quick Sort
        int[] quickSortData = (int[])data.Clone();
        Stopwatch stopwatch = Stopwatch.StartNew();
        ReyRom.Sorting.QuickSort(quickSortData, 0, quickSortData.Length - 1);
        stopwatch.Stop();
        Console.WriteLine($"Quick Sort Time: {stopwatch.ElapsedMilliseconds} ms");

        // Insertion Sort
        int[] insertionSortData = (int[])data.Clone();
        stopwatch.Restart();
        MoIce.Sorting.InsertionSort(insertionSortData);
        stopwatch.Stop();
        Console.WriteLine($"Insertion Sort Time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 10000);
        }
        return array;
    }
}