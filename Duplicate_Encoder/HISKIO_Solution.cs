using System;
using System.Collections.Generic;

namespace Duplicate_Encoder
{
    public class HISKIO_Solution
    {
        public void Swap(int[] targetArray, int a, int b)
        {
            int temp = targetArray[a];
            targetArray[a] = targetArray[b];
            targetArray[b] = temp;
        }
        public void bubbleSort(int[] unsortedArray)
        {
            int n = unsortedArray.Length;

            for (int i = 0; i <= n - 2; i++)
            {
                bool flag = true;

                for (int j = n - 1; j >= i + 1; j--)
                {
                    if (unsortedArray[j] < unsortedArray[j - 1])
                    {
                        Swap(unsortedArray, j, j - 1);
                        flag = false;
                    }
                }

                if (flag) return;
            }
        }
        public void insertionSort(int[] unsortedArray)
        {
            int n = unsortedArray.Length;

            for (int i = 1; i < n; i++)
            {
                int key = unsortedArray[i];
                int j = i - 1;

                while (j >= 0 && unsortedArray[j] > key)
                {
                    unsortedArray[j + 1] = unsortedArray[j];
                    j--;
                }

                unsortedArray[j + 1] = key;
            }
        }

        public void selectionSort(int[] unsortedArray)
        {
            int n = unsortedArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i; j < n; j++)
                {
                    if (unsortedArray[j] < unsortedArray[minIndex]) minIndex = j;
                }

                Swap(unsortedArray, i, minIndex);
            }
        }
        public bool Alogroithm_unit7_frequencyTest(string a, string b)
        {
            if (a.Length != b.Length) return false;
            var dict = new Dictionary<char, int>();

            foreach (char i in a)
            {
                if (dict.ContainsKey(i)) ++dict[i];
                else dict.Add(i, 1);
            }

            foreach (char i in b)
            {
                if (dict.ContainsKey(i)) --dict[i];
                else return false;
            }

            foreach (var i in dict.Keys)
            {
                if (dict[i] != 0) return false;
            }

            return true;
        }

        public int longestUniSubString(string s)
        {
            int head = 0, tail = 0, currentLongest = 0;
            var dict = new Dictionary<char, int>();

            while (tail < s.Length)
            {
                if (!dict.ContainsKey(s[tail]))
                {
                    dict.Add(s[tail], 1);
                    currentLongest = Math.Max(currentLongest, tail - head + 1);
                    tail++;
                }
                else
                {
                    dict.Remove(s[head]);
                    head++;
                }
            }
            return currentLongest;
        }

        public long findLargeProduct(int[] source, int n)
        {
            long currentMax = 0;

            for (int i = 0; i < source.Length - n; i++)
            {
                long temp = source[i];
                for (int j = 1; j < n; j++)
                {
                    //if (source[i + j] > int.MaxValue / temp) temp %= 1000000007;
                    temp *= source[i + j];
                }

                currentMax = Math.Max(currentMax, temp);
            }
            return currentMax;
        }
    }
}
