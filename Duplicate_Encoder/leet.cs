using System;
using System.Collections.Generic;
using System.Linq;
using ListNode = Duplicate_Encoder.DataModel.ListNode;
using Node = Duplicate_Encoder.DataModel.Node;
using TreeNode = Duplicate_Encoder.DataModel.TreeNode;

namespace Duplicate_Encoder
{
    internal class leet
    {
        public const int mod = (int)1e9 + 7;

        public class NumArray//leet 303
        {
            public int[] numArray = new int[] { };

            public NumArray(int[] nums)
            {
                this.numArray = nums;
            }

            public int SumRange(int left, int right)
            {
                if (left > right || right >= this.numArray.Length) return -1;

                int sum = 0;
                for (int i = left; i <= right; i++)
                {
                    sum += this.numArray[i];
                }
                return sum;
            }
        }

        public class LeetCode_Solution
        {
            public int MaxCount(int m, int n, int[][] ops)//598. Range Addition II
            {
                int m_Min = int.MaxValue;
                int n_Min = int.MaxValue;

                foreach (var op in ops)
                {
                    m_Min = Math.Min(m_Min, op[0]);
                    n_Min = Math.Min(n_Min, op[1]);
                }

                return ops.Length == 0 ? m * n : m_Min * n_Min;
            }
            public bool IsValidSerialization(string preorder)//331. Verify Preorder Serialization of a Binary Tree
            {
                List<string> list = new List<string>();

                foreach (var node in preorder.Split(','))
                {
                    list.Add(node);

                    while (list.Count >= 3 && list[list.Count - 1] == "#" && list[list.Count - 2] == "#" && list[list.Count - 3] != "#")
                    {
                        list.RemoveAt(list.Count - 1);
                        list.RemoveAt(list.Count - 1);
                        list.RemoveAt(list.Count - 1);
                        list.Add("#");
                    }
                }

                return list.Count == 1 && list[0] == "#";
            }
            public bool JudgeSquareSum(int c)//633. Sum of Square Numbers
            {
                long a = 0, b = (long)Math.Sqrt(c);//

                while (a <= b)
                {
                    long temp = a * a + b * b;
                    if (temp == c) return true;
                    else if (temp > c) --b;
                    else ++a;
                }

                return false;
            }
            public int MinOperations(int[] nums1, int[] nums2)//1775. Equal Sum Arrays With Minimum Number of Operations
            {
                //red:https://www.youtube.com/watch?v=FdM_IFKXaHY
                if (Math.Min(nums1.Length, nums2.Length) * 6 < Math.Max(nums1.Length, nums2.Length)) return -1;

                int i = 0, j = 0, steps = 0;
                int sum1 = nums1.Sum();
                int sum2 = nums2.Sum();

                if (sum1 > sum2) return MinOperations(nums2, nums1);

                Array.Sort(nums1);
                Array.Sort(nums2);
                Array.Reverse(nums2);

                while (sum1 != sum2)
                {
                    int diff = sum2 - sum1;
                    int d1 = i == nums1.Length ? 0 : 6 - nums1[i];
                    int d2 = j == nums2.Length ? 0 : nums2[j] - 1;
                    int d = Math.Min(diff, Math.Max(d1, d2));

                    if (d1 >= d2)
                    {
                        sum1 += d;
                        i++;
                    }
                    else
                    {
                        sum2 -= d;
                        j++;
                    }

                    steps++;
                }
                return steps;
            }
            public string ComplexNumberMultiply(string num1, string num2)//537. Complex Number Multiplication
            {
                int[] parse(string complexNumber)//{real, imaginary}
                {
                    return new int[] { Convert.ToInt32(complexNumber.Split('+')[0]), Convert.ToInt32(complexNumber.Split('+')[1].TrimEnd('i')) };
                }

                var num1_parse = parse(num1);
                var num2_parse = parse(num2);

                int realPart = num1_parse[0] * num2_parse[0] + (-1) * num1_parse[1] * num2_parse[1];
                int imaginaryPart = num1_parse[0] * num2_parse[1] + num2_parse[0] * num1_parse[1];
                return Convert.ToString(realPart) + "+" + Convert.ToString(imaginaryPart) + "i";
            }
            public string LongestPalindrome(string s)//5. Longest Palindromic Substring
            {
                if (s == null || s.Length < 2) return s;

                int maxStart = 0, maxEnd = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    int start = i, end = i;

                    while (start > 0 && end < s.Length - 1 && s[start - 1] == s[end + 1])//index左邊與右邊相等的話就再往外看，直到左右不相等為止
                    {
                        start--;
                        end++;
                    }

                    if (end - start > maxEnd - maxStart)
                    {
                        maxStart = start;
                        maxEnd = end;
                    }

                    if (i < s.Length && s[i] == s[i + 1])//考慮相同字元並排的情況
                    {
                        start = i;
                        end = i + 1;

                        while (start > 0 && end < s.Length - 1 && s[start - 1] == s[end + 1])
                        {
                            start--;
                            end++;
                        }

                        if (end - start > maxEnd - maxStart)
                        {
                            maxStart = start;
                            maxEnd = end;
                        }
                    }
                }

                return s.Substring(maxStart, maxEnd - maxStart + 1);
            }
            public bool FindTarget(TreeNode root, int k)//653. Two Sum IV - Input is a BST
            {
                var hashset = new HashSet<int>();

                getBSTval(root);

                void getBSTval(TreeNode t)
                {
                    if (t == null) return;
                    hashset.Add(t.val);

                    getBSTval(t.left);
                    getBSTval(t.right);
                }

                foreach (var i in hashset)
                {
                    if (i * 2 != k && hashset.Contains(k - i)) return true;
                }

                return false;
            }
            public bool IsRectangleOverlap(int[] rec1, int[] rec2)//836. Rectangle Overlap
            {
                if ((rec2[2] < rec1[0] && rec2[3] < rec1[1]) || (rec1[2] < rec2[0] && rec1[3] < rec2[1])) return false;
                return true;
            }
            public int RectangleArea_TLE(int[][] rectangles)//850. Rectangle Area II
            {
                var dict = new Dictionary<long, long[]>();
                foreach (var rec in rectangles)
                {
                    for (int i = rec[1]; i < rec[3]; i++)
                    {
                        if (dict.ContainsKey(i))
                        {
                            dict[i][0] = Math.Min(dict[i][0], rec[0]);
                            dict[i][1] = Math.Max(dict[i][1], rec[2]);
                        }
                        else dict.Add(i, new long[] { rec[0], rec[2] });
                    }
                }

                long sum = 0;
                foreach (var k in dict.Keys)
                {
                    sum += dict[k][1] - dict[k][0];
                    sum %= mod;
                }

                return (int)sum;
            }
            public int ComputeArea(int[] rec1, int[] rec2)//223. Rectangle Area
            {
                int ax1 = rec1[0];
                int ay1 = rec1[1];
                int ax2 = rec1[2];
                int ay2 = rec1[3];
                int bx1 = rec2[0];
                int by1 = rec2[1];
                int bx2 = rec2[2];
                int by2 = rec2[3];

                if (ax1 > ax2 || ay1 > ay2 || bx1 > bx2 || by1 > by2) return 0;

                int overlapping = 0;
                if (ax1 < bx1 && ay1 < by1 && ax2 > bx2 && ay2 > by2) overlapping = singleArea(bx1, by1, bx2, by2);
                else if (ax1 > bx1 && ay1 > by1 && ax2 < bx2 && ay2 < by2) overlapping = singleArea(ax1, ay1, ax2, ay2);
                else overlapping = singleArea(Math.Max(ax1, bx1), Math.Max(ay1, by1), Math.Min(ax2, bx2), Math.Min(ay2, by2));

                return singleArea(ax1, ay1, ax2, ay2) + singleArea(bx1, by1, bx2, by2) - overlapping;

                int singleArea(int x1, int y1, int x2, int y2)
                {
                    if (x1 > x2 || y1 > y2) return 0;
                    return (x2 - x1) * (y2 - y1);
                }
            }
            public string[] GetFolderNames(string[] names)//1487. Making File Names Unique
            {
                var dict = new Dictionary<string, int>();
                for (int i = 0; i < names.Length; i++)
                {
                    string name = names[i];

                    if (dict.ContainsKey(name))
                    {
                        while (dict.ContainsKey(name + "(" + (dict[name]) + ")")) dict[name]++;
                        names[i] = name + "(" + (dict[name]) + ")";
                        dict.Add(name + "(" + (dict[name]) + ")", 1);
                    }
                    else dict.Add(name, 1);
                }

                return names;
            }
            public int MinDepth(TreeNode root)//111. Minimum Depth of Binary Tree
            {
                if (root == null) return 0;
                else if (root.left == null) return MinDepth(root.right) + 1;
                else if (root.right == null) return MinDepth(root.left) + 1;
                else return Math.Min(MinDepth(root.right), MinDepth(root.left)) + 1;
            }

            public int MaxDepth_B(TreeNode root)//104. Maximum Depth of Binary Tree
            {
                if (root == null) return 0;
                int depth = 0;
                depth = Math.Max(depth, MaxDepth_B(root.left));
                depth = Math.Max(depth, MaxDepth_B(root.right));

                return depth + 1;
            }

            public int MaxDepth_N(Node root)//559. Maximum Depth of N-ary Tree
            {
                if (root == null) return 0;
                int depth = 0;

                foreach (var n in root.children)
                {
                    depth = Math.Max(depth, MaxDepth_N(n));
                }
                return depth + 1;
            }

            public int MaxProduct(TreeNode root)//1339. Maximum Product of Splitted Binary Tree
            {
                if (root == null) return -1;

                HashSet<int> hashset = new HashSet<int>();

                int total = getTreeNodeSum(root);
                long max = 0;

                foreach (var num in hashset)
                {
                    max = Math.Max(max, (long)(total - num) * (long)num);
                }

                return (int)(max % 1_000_000_007);

                int getTreeNodeSum(TreeNode r)
                {
                    if (r == null) return 0;
                    int sum = getTreeNodeSum(r.left) + getTreeNodeSum(r.right) + r.val;
                    hashset.Add(sum);
                    return sum;
                }
            }

            public int ClimbStairs(int n)//70. Climbing Stairs
            {
                //Fibonacci數列
                if (n < 2) return n;
                var dp = new int[n];
                dp[0] = 1;
                dp[1] = 2;

                for (int i = 2; i < n; i++)
                {
                    dp[i] = dp[i - 1] + dp[i - 2];
                }

                return dp[n - 1];
            }

            public int NumDecodings(string s)//91. Decode Ways
            {
                //特殊Fibonacci數列
                if (s.Length == 0 || s == null || s[0] == '0') return 0;
                var dp = new int[s.Length + 1];
                dp[0] = 1;

                for (int i = 0; i < s.Length; i++)
                {
                    dp[i + 1] = s[i] == '0' ? 0 : dp[i];//若第i個數字不為0，那至少會包含前面全部的可能性(單獨算);若為0，則不可能單獨算，一定要和前一位合併算

                    if (i > 0 && (s[i - 1] == '1' || (s[i - 1] == '2' && s[i] - '0' <= 6))) dp[i + 1] += dp[i - 1];//往前看一位，若有機會湊成10~26，則要在加上前面的可能性
                }
                return dp[s.Length];
            }

            public int NumDecodings_hard(string s)//639. Decode Ways II
            {
                //特殊Fibonacci數列
                if (s.Length == 0 || s == null || s[0] == '0') return 0;

                const int mod = (int)1e9 + 7;
                var dp = new long[s.Length + 1];
                dp[0] = 1;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != '*')
                    {
                        dp[i + 1] = s[i] == '0' ? 0 : dp[i];//0不能單獨算，所以單度計算的排列為0

                        if (i > 0)
                        {
                            if (s[i - 1] == '1')
                            {
                                dp[i + 1] += dp[i - 1];
                            }
                            else if (s[i - 1] == '2' && s[i] - '0' <= 6)
                            {
                                dp[i + 1] += dp[i - 1];
                            }
                            else if (s[i - 1] == '*' && s[i] - '0' <= 6)
                            {
                                dp[i + 1] += dp[i - 1] * 2;
                            }
                            else if (s[i - 1] == '*' && s[i] - '0' > 6)
                            {
                                dp[i + 1] += dp[i - 1] * 1;
                            }
                            else if (s[i] == '0' && s[i - 1] - '0' > 2) return 0;

                            dp[i + 1] %= mod;
                        }
                    }
                    else if (s[i] == '*')
                    {
                        dp[i + 1] = dp[i] * 9;

                        if (i > 0)
                        {
                            if (s[i - 1] == '1')
                            {
                                dp[i + 1] += (dp[i - 1]) * 9;
                            }
                            else if (s[i - 1] == '2')
                            {
                                dp[i + 1] += (dp[i - 1]) * 6;
                            }
                            else if (s[i - 1] == '*')
                            {
                                dp[i + 1] += (dp[i - 1]) * 15;
                            }
                        }

                        dp[i + 1] %= mod;
                    }
                    else return 0;
                }
                return (int)dp[s.Length];
            }

            public int UniqueLetterString(string s)//828. Count Unique Characters of All Substrings of a Given String
            {
                //ref:https://leetcode.jp/leetcode-828-unique-letter-string-%E8%A7%A3%E9%A2%98%E6%80%9D%E8%B7%AF%E5%88%86%E6%9E%90/
                var positions = new List<int>[26];
                int res = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    int c = s[i] - 'A';
                    List<int> list = positions[c];
                    if (list == null) list = new List<int>();
                    list.Add(i);
                    positions[c] = list;
                }

                foreach (var list in positions)
                {
                    if (list == null) continue;

                    for (int i = 0; i < list.Count; i++)
                    {
                        int currentIndex = list[i];//第i次出現的位置
                        int leftIndex = i == 0 ? 0 : list[i - 1] + 1;//上次出現的位置，+1是為了避開自己
                        int rightIndex = i == list.Count - 1 ? s.Length - 1 : list[i + 1] - 1;//下次出現的位置，若是最後一次出現，則指向數列最後位置，-1是為了避開自己

                        int leftRange = currentIndex - leftIndex;
                        int rightRange = rightIndex - currentIndex;

                        res += (leftRange + 1) * (rightRange + 1) % 10000007;
                    }
                }
                return res;
            }

            public int UniqueLetterString_TLE(string s)//828. Count Unique Characters of All Substrings of a Given String
            {
                //TLE
                int head = 0, tail = 0;
                long total_sum = 0;

                while (head < s.Length || tail < s.Length - 1)
                {
                    total_sum += findUniLetterCount(s.Substring(head, tail - head + 1));
                    if (tail == s.Length - 1)
                    {
                        head++;
                        tail = head;
                    }
                    else tail++;
                }

                int findUniLetterCount(string p)
                {
                    var dict = new Dictionary<char, int>();
                    int sum = 0;
                    for (int i = 0; i < p.Length; i++)
                    {
                        if (dict.ContainsKey(p[i])) dict[p[i]]++;
                        else dict.Add(p[i], 1);
                    }

                    foreach (var k in dict.Keys)
                    {
                        if (dict[k] == 1) sum++;
                    }

                    return sum;
                }

                return (int)total_sum;
            }

            public int FindSubstringInWraproundString(string p)//467. Unique Substrings in Wraparound String
            {
                var letters = new int[26];//記錄個字母結尾的連續字串長度
                int len = 0;

                for (int i = 0; i < p.Length; i++)
                {
                    if (i > 0 && (p[i] == p[i - 1] + 1 || p[i - 1] - p[i] == 25))//若是連續則連續長度++
                    {
                        ++len;
                    }
                    else//若非則重置連續長度
                    {
                        len = 1;
                    }

                    letters[p[i] - 'a'] = Math.Max(letters[p[i] - 'a'], len);//若目前記錄字串比之前記的更長則更新
                }
                return letters.Sum();//總和即為答案，ref:https://www.cnblogs.com/grandyang/p/6143071.html
            }

            public int FirstUniqChar(string s)//387. First Unique Character in a String
            {
                int currentFirst = -1;
                var dict = new Dictionary<char, int[]>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        dict[s[i]][1]++;
                    }
                    else
                    {
                        dict.Add(s[i], new int[] { i, 1 });//{firstAppearIndex, count}
                    }
                }

                foreach (var k in dict.Keys)
                {
                    if (dict[k][1] == 1)
                    {
                        currentFirst = currentFirst == -1 ? dict[k][0] : Math.Min(currentFirst, dict[k][0]);
                    }
                }
                return currentFirst;
            }

            public int GoodNodes(TreeNode root)//1448. Count Good Nodes in Binary Tree
            {
                if (root == null) return 0;
                int count = 0;

                traverse(root, root.val, ref count);
                return count;

                void traverse(TreeNode node, int maxPathValue, ref int goodNodeCount)
                {
                    if (node == null) return;

                    if (maxPathValue <= node.val)
                    {
                        maxPathValue = node.val;
                        goodNodeCount++;
                    }

                    traverse(node.left, maxPathValue, ref goodNodeCount);
                    traverse(node.right, maxPathValue, ref goodNodeCount);
                }
            }

            public int CanCompleteCircuit(int[] gas, int[] cost)//134. Gas Station
            {
                for (int i = 0; i < gas.Length; i++)
                {
                    if (gas[i] >= cost[i])
                    {
                        int tank = 0;
                        int exit = i - 1 >= 0 ? i - 1 : i - 1 + gas.Length;
                        for (int j = 0; j < gas.Length; j++)
                        {
                            int temp = i + j > gas.Length - 1 ? i + j - gas.Length : i + j;
                            tank = tank + gas[temp] - cost[temp];
                            if (temp == exit && tank >= 0) return i;
                            else if (tank > 0) continue;
                            else break;
                        }
                    }
                }
                return -1;
            }

            public string MinWindow(string source, string target)//76. Minimum Window Substring
            {
                if (target.Length > source.Length) return "";

                var dict = new Dictionary<char, int>();//記下target中每個字符出現次數
                var cur = new Dictionary<char, int>();//用來記目前source中所含有target字符的個數

                foreach (char i in target)
                {
                    if (dict.ContainsKey(i)) ++dict[i];
                    else dict.Add(i, 1);

                    if (!cur.ContainsKey(i)) cur.Add(i, 0);//只記種類
                }

                int head = 0,
                    tail = 0,
                    return_head = -1,
                    return_tail = -1,
                    count = 0;

                while (true)
                {
                    if (count >= target.Length && LastOneIsContainfrontOne(dict, cur))//當cur包含所有dict的直就能進入(count負責cut corner，若count還沒比target.Length多則繼續去找target)
                    {
                        if (return_head == -1 || tail - head - 1 < return_tail - return_head) //初始化，且當目前的slide window比之前記的slide window小時，則指向目前的slide window
                        {
                            return_head = head;
                            return_tail = tail - 1;
                        }

                        if (dict.ContainsKey(source[head]))//head準備要往下一格，所以先確認head指到的字符是否在target中，有的話要扣掉
                        {
                            cur[source[head]] -= 1;
                            count--;
                        }

                        head++;
                    }
                    else if (tail < source.Length)//先找到target全部字符，並將出現個數記入cur
                    {
                        if (dict.ContainsKey(source[tail]))
                        {
                            cur[source[tail]] += 1;
                            count++;
                        }

                        tail++;
                    }
                    else break;
                }

                return return_tail == -1 ? string.Empty : source.Substring(return_head, return_tail - return_head + 1);//若沒找到則return empty
            }

            private bool LastOneIsContainfrontOne(Dictionary<char, int> dict, Dictionary<char, int> cur)
            {
                foreach (var item in dict)
                    if (item.Value > cur[item.Key])
                        return false;

                return true;
            }

            public bool containTarget(string source, string target)
            {
                var dict = new Dictionary<char, int>();

                foreach (char i in target)
                {
                    if (dict.ContainsKey(i)) ++dict[i];
                    else dict.Add(i, 1);
                }

                foreach (char i in source)
                {
                    if (dict.ContainsKey(i)) --dict[i];
                }

                foreach (var i in dict.Keys)
                {
                    if (dict[i] > 0) return false;
                }

                return true;
            }

            public int MyAtoi(string s)//8. String to Integer (atoi)
            {
                if (s == null || s == String.Empty) return 0;

                int output = 0, sign = 1;
                bool findSign = false, findDigit = false;

                foreach (var c in s)
                {
                    if (!findSign && !findDigit && (c == '-' || c == '+'))//當找到+或-且還沒找到其他+-或是數字時
                    {
                        findSign = true;
                        sign = c == '+' ? 1 : -1;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        findDigit = true;

                        if (output == 0 && c == '0') continue;//略過前置0
                        else if (output > int.MaxValue / 10 || (output == int.MaxValue / 10 && c - '0' > int.MaxValue % 10)) return sign == 1 ? int.MaxValue : int.MinValue;//處理邊界
                        else output = output * 10 + (c - '0');
                    }
                    else if (c != ' ' || ((findDigit || findSign) && c == ' ')) break;//找到文字或是空白(但已經找到數字)就不找了
                }

                return sign * output;
            }

            public int SumSubarrayMins2(int[] arr)//907. Sum of Subarray Minimums in O(n)
            {
                //使用單調堆疊方法(Monotonic Stack)，幫助找到向左/向右走訪第一個比當前元素小/大的元素。
                long mod = Convert.ToInt64(1e9 + 7);
                int n = arr.Length;
                int[] left = new int[n];
                int[] right = new int[n];
                var nums = new Stack<int>();//計數
                var lens = new Stack<int>();//計次
                long sum = 0;

                for (int i = 0; i < n; i++)
                {
                    int len = 1;

                    while (nums.Count > 0 && nums.Peek() > arr[i])
                    {
                        len += lens.Pop();
                        nums.Pop();
                    }
                    nums.Push(arr[i]);
                    lens.Push(len);
                    left[i] = len;
                }

                nums.Clear();
                lens.Clear();

                for (int i = n - 1; i >= 0; i--)
                {
                    int len = 1;

                    while (nums.Count > 0 && nums.Peek() >= arr[i])
                    {
                        len += lens.Pop();
                        nums.Pop();
                    }
                    nums.Push(arr[i]);
                    lens.Push(len);
                    right[i] = len;
                }

                for (int i = 0; i < n; i++)
                {
                    sum += (long)arr[i] * (long)(left[i]) * (long)(right[i]) % mod;
                }

                return (int)(sum % mod);
            }

            public int SumSubarrayMins(int[] arr)//907. Sum of Subarray Minimums in O(n^2)
            {
                long mod = Convert.ToInt64(1e9 + 7);
                int n = arr.Length;
                long sum = 0;

                for (int i = 0; i < n; i++)
                {
                    int left = 0, right = 0;

                    for (int j = i - 1; j >= 0 && arr[j] > arr[i]; j--) left++;
                    for (int j = i + 1; j < n && arr[j] >= arr[i]; j++) right++;
                    sum += (long)arr[i] * (long)(left + 1) * (long)(right + 1) % mod;
                }
                return (int)(sum % mod);
            }

            public int MaxSubArray(int[] nums)//53. Maximum Subarray
            {
                int sum = 0;
                int maxSum = nums[0];

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    if (nums[i] > sum)//若當下的數字比加上當下的數字的總和還要大，代表前面都是拖油瓶
                    {
                        sum = nums[i];//重新由當下的數字開始計算sum
                    }
                    maxSum = Math.Max(sum, maxSum);
                }
                return maxSum;
            }

            public void SetZeroes(int[][] matrix)//73. Set Matrix Zeroes
            {
                int m = matrix.Length;
                int n = matrix[0].Length;
                Queue<int[]> q = new Queue<int[]>();

                for (int x = 0; x < m; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        if (matrix[x][y] == 0) q.Enqueue(new int[] { x, y });
                    }
                }

                foreach (var temp in q)
                {
                    matrix[temp[0]] = new int[n];
                    for (int i = 0; i < m; i++)
                    {
                        matrix[i][temp[1]] = 0;
                    }
                }
            }

            public bool IsAnagram(string a, string b)//242. Valid Anagram
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

            public IList<IList<string>> GroupAnagrams(string[] strs)//49. Group Anagrams
            {
                var returnList = new List<IList<string>>();

                if (strs.Length < 1 || strs == null) return returnList;

                var dict = new Dictionary<string, List<string>>();

                foreach (string member in strs)
                {
                    char[] temp = member.ToCharArray();
                    Array.Sort(temp);
                    string member_sorted = new string(temp);//new string(char[] a)將字元串列轉為字串

                    //查找dict是否有已排序過的member，若無則新增，有就將member加入list
                    if (!dict.ContainsKey(member_sorted)) dict.Add(member_sorted, new List<string>());

                    dict[member_sorted].Add(member);
                }

                foreach (var key in dict.Keys)
                {
                    returnList.Add(dict[key]);
                }
                return returnList;
            }

            public int MySqrt(int x)//69. Sqrt(x)
            {
                if (x == 0) return 0;
                if (x == 1) return 1;
                long currentClosest = 0;
                long left = 0;
                long right = x / 2 + 1;

                while (left < right)
                {
                    long mid = left + (right - left) / 2;//取中點，此作法是為了避免過大溢位
                    currentClosest = mid * mid;
                    if (currentClosest == x) return (int)mid;
                    else if (currentClosest > x) right = mid;
                    else left = ++mid;
                }

                return (int)left - 1;
            }

            public bool CanReorderDoubled(int[] arr)//954 Array of Doubled Pairs
            {
                //處理邊界條件
                if (arr.Length <= 1) return false;

                //排序整理並分堆存入dictionary(or hash map)
                Array.Sort(arr);
                var dict = new Dictionary<int, int>();

                //dict的key和value分別是arr的值與出現次數
                foreach (var i in arr)
                {
                    if (dict.ContainsKey(i)) ++dict[i];
                    else dict.Add(i, 1);
                }

                //遍歷arr並找兩倍與一半的值是否有出現在dict，有的話，target與target_helf抵銷，一起移出dict，double同理。
                foreach (var i in arr)
                {
                    int target = i;
                    int target_helf = i / 2;
                    int target_double = i * 2;

                    if (dict[i] == 0) continue;

                    if (target % 2 == 0 && dict.ContainsKey(target_helf) && dict[target_helf] > 0)
                    {
                        --dict[target_helf];
                        --dict[target];
                    }
                    else if (dict.ContainsKey(target_double) && dict[target_double] > 0)
                    {
                        --dict[target_double];
                        --dict[target];
                    }
                    else return false;
                }

                foreach (var i in dict.Keys)
                {
                    if (dict[i] != 0) return false;
                }

                return true;
            }

            public string AddBinary(string num1, string num2)//67. Add Binary
            {
                if (num1 == null && num2 == null) return null;
                if (num1 == null) return num2;
                if (num2 == null) return num1;
                string[] returnString = new string[Math.Max(num1.Length, num2.Length) + 1];
                int round = 0;
                int index = 1;

                while (returnString.Length - index >= 0)
                {
                    if (index == returnString.Length && round == 0) returnString[returnString.Length - index] = null;
                    else
                    {
                        int temp_num1 = num1.Length - index >= 0 ? num1[num1.Length - index] - '0' : 0;
                        int temp_num2 = num2.Length - index >= 0 ? num2[num2.Length - index] - '0' : 0;
                        int temp_sum = round + temp_num1 + temp_num2;
                        round = temp_sum / 2;
                        returnString[returnString.Length - index] = (temp_sum % 2).ToString();
                    }

                    index++;
                }

                return String.Join("", returnString.Where(p => p != null).ToArray());
            }

            public int MinFlipsMonoIncr(string s)//926. Flip String to Monotone Increasing
            {
                int currentMin = 0, ONEcount = 0, n = s.Length;

                for (int i = 0; i < n; i++)
                {
                    //先判斷當下的字元是不是0，若是則在最小翻轉數+1，然後跟1的計數器去較小的回存到最小翻轉數，
                    //如果字串持續沒出現1則1的計數器維持0，最小翻轉數也永遠是0
                    //如果1的計數器已經>1，代表前面出現過1，當又出現0時，就要判斷是出線的0少還是出現的1少，較少的是最小的翻轉數
                    //ref: https://www.cnblogs.com/grandyang/p/11964938.html
                    if (s[i] == '0') ++currentMin;
                    else ++ONEcount;

                    currentMin = Math.Min(currentMin, ONEcount);
                }

                return currentMin;
            }

            public string ZigZagConvert(string s, int numRows)//6. ZigZag Conversion
            {
                //處理邊界條件
                if (s == null || s.Length == 0) return "";
                if (numRows == 1 || s.Length == 1 || numRows >= s.Length) return s;

                //遍歷s，同時遍歷numRows，當numsRow碰到邊界後反方向走
                bool isDownward = true;//true向下走 false向上走
                string[] output = new string[numRows];
                int rowCount = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    output[rowCount] += s[i];
                    if (isDownward)
                    {
                        rowCount++;
                        if (rowCount >= numRows - 1) isDownward = false;
                    }
                    else
                    {
                        rowCount--;
                        if (rowCount <= 0) isDownward = true;
                    }
                }

                return String.Join("", output);
            }

            public string AddStrings(string num1, string num2)
            {
                if (num1 == null && num2 == null) return null;
                if (num1 == null) return num2;
                if (num2 == null) return num1;
                string[] returnString = new string[Math.Max(num1.Length, num2.Length) + 1];
                int round = 0;
                int index = 1;

                while (returnString.Length - index >= 0)
                {
                    if (index == returnString.Length && round == 0) returnString[returnString.Length - index] = null;
                    else
                    {
                        int temp_num1 = num1.Length - index >= 0 ? num1[num1.Length - index] - '0' : 0;
                        int temp_num2 = num2.Length - index >= 0 ? num2[num2.Length - index] - '0' : 0;
                        int temp_sum = round + temp_num1 + temp_num2;
                        round = temp_sum / 10;
                        returnString[returnString.Length - index] = (temp_sum % 10).ToString();
                    }

                    index++;
                }

                return String.Join("", returnString.Where(p => p != null).ToArray());
            }

            public int LengthOfLongestSubstring(string s)
            {
                if (s == null || s == string.Empty) return 0;

                //hashset不能存重複值，用來找不重複組合相當合適
                HashSet<char> set = new HashSet<char>();
                int currentMax = 0, head = 0, tail = 0;

                while (tail < s.Length)
                {
                    if (!set.Contains(s[tail]))
                    {
                        //若沒重複，尾巴持續往後指並加入hashset
                        set.Add(s[tail]);
                        tail++;
                        //計算最長字串長度
                        currentMax = Math.Max(currentMax, tail - head);
                    }
                    else
                    {
                        //若有重複，從頭開始刪，接著重複查找尾巴是否重複，若還是有，則繼續刪
                        set.Remove(s[head]);
                        head++;
                    }
                }

                return currentMax;
            }

            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                //處理邊界條件
                if (l1 == null && l2 == null) return null;

                //將l1、l2整串依序存入queue後轉為array方便排序
                Queue<int> l1_q = new Queue<int>();
                Queue<int> l2_q = new Queue<int>();

                while (l1 != null)
                {
                    l1_q.Enqueue(l1.val);
                    l1 = l1.next;
                }
                int[] l1_a = l1_q.ToArray();

                while (l2 != null)
                {
                    l2_q.Enqueue(l2.val);
                    l2 = l2.next;
                }
                int[] l2_a = l2_q.ToArray();

                //l1、l2合併並排序
                int[] l3_a = l1_a.Concat(l2_a).ToArray();
                Array.Sort(l3_a);

                //依序將排序完的l3串成listNode
                ListNode returnNode = new ListNode();
                ListNode returnNode_clone = returnNode;

                returnNode.val = l3_a[0];
                for (int i = 1; i < l3_a.Length; i++)
                {
                    returnNode.next = new ListNode(l3_a[i]);
                    returnNode = returnNode.next;
                }

                return returnNode_clone;
            }

            public bool HasPathSum(TreeNode root, int targetSum)
            {
                if (root == null) return false;
                if (root.right == null && root.left == null && root.val == targetSum) return true;
                return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
            }

            public int ShortestPathBinaryMatrix(int[][] grid)
            {
                //定位終點
                int terminal_x = grid.Length - 1;
                int terminal_y = grid[0].Length - 1;

                //處理邊界條件
                if (grid == null || grid.Length == 0) return 0;
                if (terminal_x == 0 && terminal_y == 0 && grid[0][0] == 0) return 1;
                if (grid[0][0] == 1 || grid[terminal_x][terminal_y] == 1) return -1;

                int path = 0;//最短路徑長
                Queue<int[]> q = new Queue<int[]>();//可能的節點堆疊
                                                    //八個方位對應(x, y)=>下(0, 1), 上(0, -1).....
                int[] dx = new int[] { 0, 0, 1, -1, 1, 1, -1, -1 },
                      dy = new int[] { 1, -1, 0, 0, 1, -1, 1, -1 };

                q.Enqueue(new int[] { 0, 0 });
                grid[0][0] = -1;//標記已經過

                while (q.Count > 0)
                {
                    int count = q.Count;
                    path++;

                    while (count > 0)
                    {
                        int[] cur = q.Dequeue();

                        if (cur[0] == terminal_x && cur[1] == terminal_y) return path;//抵達終點

                        for (int i = 0; i < 8; i++)
                        {
                            //往八個方位走下一步
                            int newX = cur[0] + dx[i],
                                newY = cur[1] + dy[i];

                            //若新的格子沒有走過同時在範圍內且是0, 則放入堆疊
                            if (newX > -1 && newX <= terminal_x && newY > -1 && newY <= terminal_y && grid[newX][newY] == 0)
                            {
                                q.Enqueue(new int[] { newX, newY });
                                grid[newX][newY] = -1;
                            }
                        }

                        count--;
                    }
                }

                return -1;
            }

            public int[][] UpdateMatrix(int[][] mat)
            {
                int[][] returnMatrix = new int[mat.Length][];
                int adid = returnMatrix[0][2];
                for (int i = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j > mat[i].Length; j++)
                    {
                        if (mat[i][j] == 0) returnMatrix[i][j] = 0;
                        else
                        {
                        }
                    }
                }
                return returnMatrix;
            }

            public int[] BeautifulArray(int n)
            {
                List<int> intList = new List<int>();
                intList.Add(1);

                while (intList.Count < n)
                {
                    List<int> tempList = new List<int>();
                    foreach (int i in intList)
                    {
                        if ((i * 2) - 1 <= n) tempList.Add((i * 2) - 1);
                    }

                    foreach (int i in intList)
                    {
                        if ((i * 2) <= n) tempList.Add((i * 2));
                    }

                    intList = tempList;
                }

                int[] intArray = new int[n];
                int count = 0;
                foreach (int i in intList)
                {
                    intArray[count] = i;
                    count++;
                }

                return intArray;
            }

            public void parse_0AH(byte i)
            {
                //9 10 11 12
                int num9 = Convert.ToInt32(i);
                string hardware_status = Convert.ToString(num9, 2).PadLeft(8, '0');
                char[] hardware_status1 = Convert.ToString(num9, 2).PadLeft(8, '0').ToCharArray();

                //int speed = Convert.ToInt32(Data[10]);
                //Console.WriteLine("speed:" + speed.ToString());
                //Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            }

            public int ThreeSumMulti(int[] arr, int target)
            {
                double res = 0, M = 1e9 + 7;
                Array.Sort(arr);

                for (int i = 0; i < arr.Length - 2; i++)
                {
                    int sum = target - arr[i];
                    int left = i + 1;
                    int right = arr.Length - 1;

                    while (left < right)
                    {
                        int temp_sum = arr[left] + arr[right];

                        //temp_sum比sum小的話，左pointer往右;反之，右pointer往左
                        if (temp_sum < sum) left++;
                        else if (temp_sum > sum) right--;
                        else
                        {
                            int counter_left = 1, counter_right = 1;
                            //計算左pointer有幾個重複
                            while (left + counter_left < right && arr[left + counter_left] == arr[left]) counter_left++;
                            //計算右pointer有幾個重複
                            while (left + counter_left <= right - counter_right && arr[right - counter_right] == arr[right]) counter_right++;
                            //計算排列組合，若左右pointer指到的值都相同則C個數取2，若值不同則直接將兩個值的個數相乘
                            res += arr[left] == arr[right] ? (right - left + 1) * (right - left) / 2 : counter_left * counter_right;
                            //跳過重複的值
                            left += counter_left;
                            right -= counter_right;
                        }
                    }
                }
                return Convert.ToInt32(res % M);
            }

            public IList<IList<int>> ThreeSum(int[] nums)
            {
                List<IList<int>> returnList = new List<IList<int>>();

                //處理邊界條件
                if (nums == null) return returnList;
                if (nums.Length < 3) return returnList;

                //排序
                Array.Sort(nums);

                //遍歷
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    //剪枝優化: array已經排序過，故當第一個數即為正數，則不可能後三數和為0
                    if (nums[i] > 0) break;

                    //跳過重複
                    if (i > 0 && nums[i] == nums[i - 1]) continue;

                    int left = i + 1;
                    int right = nums.Length - 1;

                    while (left < right)
                    {
                        int temp_sum = nums[i] + nums[left] + nums[right];

                        //temp_sum比0小的話，左pointer往右;反之，右pointer往左;temp_sum剛好等於0則為所求
                        if (temp_sum < 0) left++;
                        else if (temp_sum > 0) right--;
                        else
                        {
                            returnList.Add(new List<int> { nums[i], nums[left], nums[right] });
                            left++;
                            right--;

                            //重複的話 pointer直接指向下個
                            while (left < right && nums[left] == nums[left - 1])
                                left++;
                            while (left < right && nums[right] == nums[right + 1])
                                right--;
                        }
                    }
                }

                return returnList;
            }

            public int ThreeSumClosest(int[] nums, int target)
            {
                //先排序
                Array.Sort(nums);
                int closest = nums[0] + nums[1] + nums[2];
                int diff = Math.Abs(target - closest);

                //遍歷
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    int left = i + 1;
                    int right = nums.Length - 1;

                    //當左右pointer交叉時結束
                    while (left < right)
                    {
                        int temp_sum = nums[i] + nums[left] + nums[right];
                        int temp_diff = Math.Abs(target - temp_sum);

                        //找到最小得差距便替換
                        if (temp_diff < diff)
                        {
                            diff = temp_diff;
                            closest = temp_sum;
                        }

                        //temp_sum比target小的話，左pointer往右;反之，右pointer往左;temp_sum剛好等於target代表最靠近，直接回傳
                        if (temp_sum < target) left++;
                        else if (temp_sum > target) right--;
                        else return target;
                    }
                }

                return closest;
            }

            public TreeNode DeleteNode(TreeNode root, int key)
            {
                //LeetCode450
                return new TreeNode(0);
            }

            //reference: https://desolve.medium.com/%E5%BE%9Eleetcode%E5%AD%B8%E6%BC%94%E7%AE%97%E6%B3%95-35-bst-3-b1f225f39aa3
            public TreeNode SortedArrayToBST(int[] nums)
            {
                if (nums == null || nums.Length == 0) return null;

                return getNode(nums, 0, nums.Length - 1);
            }

            public TreeNode getNode(int[] nums, int start, int end)
            {
                if (start > end) return null;
                int mid = (start + end) / 2;
                TreeNode newNode = new TreeNode(nums[mid]);
                newNode.left = getNode(nums, start, mid - 1);
                newNode.right = getNode(nums, mid + 1, end);
                return newNode;
            }

            public bool res = true;

            public bool IsBalanced(TreeNode root)
            {
                maxdp(root);
                return res;
            }

            public int maxdp(TreeNode root)
            {
                if (root == null || !res) return 0;
                int l = maxdp(root.left);
                int r = maxdp(root.right);
                if (Math.Abs(l - r) > 1)
                {
                    res = false;
                    return 0;
                }
                return Math.Max(l, r) + 1;
            }

            public int[] PlusOne(int[] digits)
            {
                int[] returnArray = new int[digits.Length];
                int carry = 0;

                for (int i = (digits.Length - 1); i >= 0; i--)
                {
                    if (i == digits.Length - 1) digits[i] = digits[i] + 1;

                    if (digits[i] + carry == 10)
                    {
                        returnArray[i] = 0;
                        carry = 1;
                    }
                    else
                    {
                        returnArray[i] = digits[i] + carry;
                        carry = 0;
                    }
                }

                int[] tempArray = new int[1] { 1 };
                if (carry == 1) returnArray = tempArray.Concat(returnArray).ToArray();
                return returnArray;
            }

            public int LengthOfLastWord(string s)
            {
                if (s.Trim().Length == 0) return 0;

                string[] s_split = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                return s_split.Length == 1 ? s_split[0].Length : s_split[s_split.Length - 1].Length;
            }

            public int SearchInsert(int[] nums, int target)
            {
                int returnValue = nums.Select((v, i) => new { i, v }).Where(p => p.v >= target).Select(p => p.i).FirstOrDefault();
                return returnValue;
            }

            public void permutation(int[] nums, int startIndex)
            {
                if (startIndex == nums.Length - 1) Console.WriteLine(string.Join(",", nums));
                else
                {
                    for (int i = startIndex; i < nums.Length; i++)
                    {
                        if (i == startIndex || nums[i] != nums[startIndex])
                        {
                            SWAP(nums, i, startIndex);
                            permutation(nums, startIndex + 1);
                            SWAP(nums, i, startIndex);
                        }
                    }
                }
            }

            public void permutation(int[] nums)
            {
                if (nums.Length > 0) permutation(nums, 0);
            }

            public void SWAP(int[] nums, int index_A, int index_B)
            {
                int temp = nums[index_A];
                nums[index_A] = nums[index_B];
                nums[index_B] = temp;
            }

            public void NextPermutation(int[] nums)
            {
                if (nums.Length < 2) return;

                if (isReverse(nums))
                {
                    Array.Sort(nums);
                    return;
                }

                //從倒數第2個往前找
                for (int i = nums.Length - 2; i >= 0; i--)
                {
                    //找到第一個升冪
                    if (nums[i] < nums[i + 1])
                    {
                        //若是最後兩個則直接交換
                        if (i == nums.Length - 2)
                        {
                            SWAP(nums, i, i + 1);
                            return;
                        }

                        //若非最後兩個則在往後找比nums[i]大又最接近的
                        int temp = i + 1;
                        for (int j = i; j <= nums.Length - 1; j++)
                        {
                            if (nums[j] <= nums[temp] && nums[j] > nums[i]) temp = j;
                        }
                        //找到後交換
                        SWAP(nums, i, temp);
                        //最後reverse
                        Array.Reverse(nums, i + 1, nums.Length - (i + 1));
                        return;
                    }
                }
                return;
            }

            public bool isReverse(int[] nums)
            {
                int[] nums_clone = new int[nums.Length];
                nums.CopyTo(nums_clone, 0);
                Array.Sort(nums_clone);
                Array.Reverse(nums_clone);
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != nums_clone[i]) return false;
                }
                return true;
            }

            public int StrStr(string haystack, string needle)
            {
                return haystack.IndexOf(needle);
            }

            public int Divide(int dividend, int divisor)
            {
                if (dividend == 0) return 0;
                else if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
                return dividend / divisor;
            }

            public int RemoveElement(int[] nums, int val)
            {
                int[] nums1 = nums.Where(x => x != val).ToArray();
                for (int i = 0; i < nums1.Length; i++)
                {
                    nums[i] = nums1[i];
                }
                return nums1.Length;
            }

            public int RemoveDuplicates(int[] nums)
            {
                Dictionary<int, int> DD = new Dictionary<int, int>();
                int temp = -1;
                foreach (int j in nums)
                {
                    if (!DD.ContainsValue(j))
                    {
                        temp++;
                        DD.Add(temp, j);
                    }
                }
                int[] returnArray = new int[temp + 1];

                for (int i = 0; i <= temp; i++)
                {
                    nums[i] = DD[i];
                }

                return temp + 1;
            }

            public bool IsValid(string s)
            {
                int len = s.Length;
                if (len % 2 == 1) return false;

                char[] stacks = new char[len];
                int index = -1;
                foreach (char a in s.ToCharArray())
                {
                    if (a == '(' || a == '[' || a == '{')
                    {
                        index++;
                        stacks[index] = a;
                    }
                    else//若字元是右引號
                    {
                        //第一個字元就是右引號
                        if (index < 0) return false;

                        //取出stack最新塞入的字元
                        char popChar = stacks[index];
                        index--;

                        if (a == '}' && popChar != '{') return false;
                        if (a == ']' && popChar != '[') return false;
                        if (a == ')' && popChar != '(') return false;
                    }
                }

                return index == -1;
            }

            public string LongestCommonPrefix(string[] strs)
            {
                string returnString = strs[0];
                for (int i = 1; i < strs.Length; i++)
                {
                    while (strs[i].IndexOf(returnString) != 0)
                    {
                        returnString = returnString.Substring(0, returnString.Length - 1);
                        if (returnString == "") return "";
                    }
                }
                return returnString;
            }

            public int RomanToInt(string input)
            {
                int returnValue = 0;
                while (input.Trim() != "" && input != null)
                {
                    if (input.Contains("CM"))
                    {
                        int temp = input.IndexOf("CM");
                        input = input.Remove(temp, 2);
                        returnValue += 900;
                    }
                    else if (input.Contains("M"))
                    {
                        int temp = input.IndexOf("M");
                        input = input.Remove(temp, 1);
                        returnValue += 1000;
                    }
                    else if (input.Contains("CD"))
                    {
                        int temp = input.IndexOf("CD");
                        input = input.Remove(temp, 2);
                        returnValue += 400;
                    }
                    else if (input.Contains("D"))
                    {
                        int temp = input.IndexOf("D");
                        input = input.Remove(temp, 1);
                        returnValue += 500;
                    }
                    else if (input.Contains("XC"))
                    {
                        int temp = input.IndexOf("XC");
                        input = input.Remove(temp, 2);
                        returnValue += 90;
                    }
                    else if (input.Contains("C"))
                    {
                        int temp = input.IndexOf("C");
                        input = input.Remove(temp, 1);
                        returnValue += 100;
                    }
                    else if (input.Contains("XL"))
                    {
                        int temp = input.IndexOf("XL");
                        input = input.Remove(temp, 2);
                        returnValue += 40;
                    }
                    else if (input.Contains("L"))
                    {
                        int temp = input.IndexOf("L");
                        input = input.Remove(temp, 1);
                        returnValue += 50;
                    }
                    else if (input.Contains("IX"))
                    {
                        int temp = input.IndexOf("IX");
                        input = input.Remove(temp, 2);
                        returnValue += 9;
                    }
                    else if (input.Contains("X"))
                    {
                        int temp = input.IndexOf("X");
                        input = input.Remove(temp, 1);
                        returnValue += 10;
                    }
                    else if (input.Contains("IV"))
                    {
                        int temp = input.IndexOf("IV");
                        input = input.Remove(temp, 2);
                        returnValue += 4;
                    }
                    else if (input.Contains("V"))
                    {
                        int temp = input.IndexOf("V");
                        input = input.Remove(temp, 1);
                        returnValue += 5;
                    }
                    else if (input.Contains("I"))
                    {
                        int temp = input.IndexOf("I");
                        input = input.Remove(temp, 1);
                        returnValue += 1;
                    }
                }
                return returnValue;
            }

            public bool IsPalindrome(int x)
            {
                if (x < 0 || (x % 10 == 0 && x != 0)) return false;
                //char[] x_toCharArray = Convert.ToString(x).ToArray();
                //for (int i = 0; i <= x_toCharArray.Length / 2; i++)
                //{
                //    if (x_toCharArray[i] != x_toCharArray[(x_toCharArray.Length - 1) - i]) return false;
                //}
                //return true;
                int revertedNumber = 0;
                while (x > revertedNumber)
                {
                    revertedNumber = revertedNumber * 10 + x % 10;
                    x /= 10;
                }
                return x == revertedNumber || x == revertedNumber / 10;
            }

            public int Reverse(int x)
            {
                int orgin_x = x;
                x = x < 0 ? 0 - x : x;
                string returnValue = "";

                while (x > 0)
                {
                    returnValue += Convert.ToString(x % 10);
                    x /= 10;
                }
                try
                {
                    int returnInt = orgin_x > 0 ? Convert.ToInt32(returnValue == "" ? "0" : returnValue) : (0 - Convert.ToInt32(returnValue == "" ? "0" : returnValue));
                    return returnInt;
                }
                catch (OverflowException)
                {
                    return 0;
                }
            }

            public int[] TwoSum(int[] nums, int target)
            {
                int[] returnValue = new int[2];
                int index_i = 0;
                int index_j = 0;
                for (index_i = 0; index_i < nums.Length; index_i++)
                {
                    for (index_j = index_i + 1; index_j < nums.Length; index_j++)
                    {
                        if (nums[index_i] + nums[index_j] == target)
                        {
                            returnValue[0] = index_i;
                            returnValue[1] = index_j;
                            return returnValue;
                        }
                    }
                }

                return returnValue;
            }
        }
    }
}
