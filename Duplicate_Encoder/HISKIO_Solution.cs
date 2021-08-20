using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Encoder
{
    public class HISKIO_Solution
    {
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