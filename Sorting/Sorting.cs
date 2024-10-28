﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReyRom
{
    public static class Sorting
    {
        public static void BubbleSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        public static void QuickSort(int[] data, int left, int right)
        {
            int i = left, j = right;
            int pivot = data[(left + right) / 2];
            while (i <= j)
            {
                while (data[i] < pivot) i++;
                while (data[j] > pivot) j--;
                if (i <= j)
                {
                    int tmp = data[i];
                    data[i] = data[j];
                    data[j] = tmp;
                    i++;
                    j--;
                }
            }
            if (left < j) QuickSort(data, left, j);
            if (i < right) QuickSort(data, i, right);
        }
    }
}

namespace MoIce
{
    public static class Sorting
    {
        public static void InsertionSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int x = data[i];
                int j = i;
                while (j > 0 && data[j - 1] > x)
                {
                    data[j] = data[j - 1];
                    j--;
                }
                data[j] = x;
            }
        }
    }
}