using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Duplicate_Encoder
{
    internal class KATA
    {
        public class Kata5
        {
            public static BigInteger[] Mixbonacci(string[] pattern, int length)
            {
                BigInteger[] returnArr = new BigInteger[length];
                BigInteger fib_count = 0;
                BigInteger pad_count = 0;
                BigInteger jac_count = 0;
                BigInteger pel_count = 0;
                BigInteger tri_count = 0;
                BigInteger tet_count = 0;
                for (int i = 0; i < length; i++)
                {
                    switch (pattern[i % pattern.Length])
                    {
                        case "fib":
                            returnArr[i] = fib(fib_count);
                            fib_count++;
                            break;

                        case "pad":
                            returnArr[i] = pad(pad_count);
                            pad_count++;
                            break;

                        case "jac":
                            returnArr[i] = jac(jac_count);
                            jac_count++;
                            break;

                        case "pel":
                            returnArr[i] = pel(pel_count);
                            pel_count++;
                            break;

                        case "tri":
                            returnArr[i] = tri(tri_count);
                            tri_count++;
                            break;

                        case "tet":
                            returnArr[i] = tet(tet_count);
                            tet_count++;
                            break;
                    }
                }
                return returnArr;

                BigInteger fib(BigInteger n)
                {
                    if (n < 0)
                    {
                        throw new NotImplementedException();
                    }
                    else if (n == 0)
                    {
                        return 0;
                    }
                    else if (n == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return fib(n - 1) + fib(n - 2);
                    }
                }

                BigInteger pad(BigInteger n)
                {
                    if (n < 0)
                    {
                        throw new NotImplementedException();
                    }
                    else if (n == 0)
                    {
                        return 1;
                    }
                    else if (n == 1 || n == 2)
                    {
                        return 0;
                    }
                    else
                    {
                        return pad(n - 2) + pad(n - 3);
                    }
                }

                BigInteger jac(BigInteger n)
                {
                    if (n < 0)
                    {
                        throw new NotImplementedException();
                    }
                    else if (n == 0)
                    {
                        return 0;
                    }
                    else if (n == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return jac(n - 1) + 2 * jac(n - 2);
                    }
                }

                BigInteger pel(BigInteger n)
                {
                    if (n < 0)
                    {
                        throw new NotImplementedException();
                    }
                    else if (n == 0)
                    {
                        return 0;
                    }
                    else if (n == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2 * pel(n - 1) + pel(n - 2);
                    }
                }

                BigInteger tri(BigInteger n)
                {
                    if (n < 0)
                    {
                        throw new NotImplementedException();
                    }
                    else if (n == 0 || n == 1)
                    {
                        return 0;
                    }
                    else if (n == 2)
                    {
                        return 1;
                    }
                    else
                    {
                        return tri(n - 1) + tri(n - 2) + tri(n - 3);
                    }
                }

                BigInteger tet(BigInteger n)
                {
                    if (n < 0)
                    {
                        throw new NotImplementedException();
                    }
                    else if (n == 0 || n == 1 || n == 2)
                    {
                        return 0;
                    }
                    else if (n == 3)
                    {
                        return 1;
                    }
                    else
                    {
                        return tet(n - 1) + tet(n - 2) + tet(n - 3) + tet(n - 4);
                    }
                }
            }

            public static string ToWeirdCase(string s)
            {
                string[] sArray = s.Split(' ');
                sArray = sArray.Select(x => string.Concat(x.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)))).ToArray();
                s = string.Join(" ", sArray);
                return s;
            }

            public static int[] MoveZeroes(int[] arr)
            {
                int[] nonZeroArray = arr.Where(x => x != 0).ToArray();
                int[] zeroArray = arr.Where(x => x == 0).ToArray();
                return nonZeroArray.Concat(zeroArray).ToArray();
            }

            public static int DescendingOrder(int num)
            {
                string str = Convert.ToString(num);
                char[] char_arr = new char[str.Length];
                char_arr = str.ToCharArray();
                int count;
                do
                {
                    count = 0;
                    for (int i = 0; i < (char_arr.Length - 1); i++)
                    {
                        int a = Convert.ToInt32(char_arr[i]);
                        int b = Convert.ToInt32(char_arr[i + 1]);

                        if (a < b)
                        {
                            char temp = char_arr[i];
                            char_arr[i] = char_arr[i + 1];
                            char_arr[i + 1] = temp;
                            count++;
                        }
                    }
                }
                while (count > 0);

                string str_return = "";
                for (int i = 0; i < char_arr.Length; i++)
                {
                    str_return += char_arr[i];
                }

                return Convert.ToInt32(str_return);
            }

            public static string DuplicateEncode(string word)
            {
                word = word.ToLower();
                char[] string_array = word.ToCharArray();
                for (int i = 0; i < string_array.Length; i++)
                {
                    string substring = word.Remove(i, 1);
                    char[] sub_arr = substring.ToCharArray();
                    //bool repeatORNOT = Array.Exists(sub_arr, elements => elements == string_array[i]);
                    int count = 0;
                    for (int j = 0; j < sub_arr.Length; j++)
                    {
                        count += (sub_arr[j] == string_array[i]) ? 1 : 0;
                    }
                    if (count > 0)
                    {
                        string_array[i] = ')';
                    }
                    else
                    {
                        string_array[i] = '(';
                    }
                }
                string fibonacci_num = "";
                for (int i = 0; i < string_array.Length; i++)
                {
                    fibonacci_num += string_array[i];
                }

                return fibonacci_num;
            }

            public static string Decode(string morseCode)
            {
                try
                {
                    morseCode = morseCode.Replace("   ", " space ");
                    string[] string_arr = morseCode.Split(' ');

                    string[] return_string_arr = new string[50];
                    string return_string = "";
                    for (int i = 0; i < string_arr.Length; i++)
                    {
                        return_string_arr[i] = "888";
                    }
                    for (int i = 0; i < return_string_arr.Length; i++)
                    {
                        return_string += return_string_arr[i];
                    }
                    return return_string;
                }
                catch (Exception ex)
                {
                    throw new System.NotImplementedException("Please provide some code.");
                }
            }

            public static string DecodeBits(string bits)
            {
                if (bits == "") throw new System.NotImplementedException("Please provide some code.");
                //string return_value = bits.Replace("1100", ".").Replace("1111", "-").Replace("0000", " ");
                string return_value = "";
                for (int i = 0; i < bits.Length; i += 4)
                {
                    string temp = bits.Substring(i, 4);
                    switch (temp)
                    {
                        case "1100":
                            return_value = ".";
                            break;

                        case "1111":
                            return_value = "-";
                            break;

                        case "0000":
                            return_value = " ";
                            break;
                    }
                }
                return return_value;
            }

            public static string Solution(int n)
            {
                if (n <= 0) throw new NotImplementedException();

                string return_string = "";
                while (n > 0)
                {
                    if (n >= 1000)
                    {
                        n -= 1000;
                        return_string += "M";
                    }
                    else if (n >= 900)
                    {
                        n -= 900;
                        return_string += "CM";
                    }
                    else if (n >= 600)
                    {
                        n -= 600;
                        return_string += "DC";
                    }
                    else if (n >= 500)
                    {
                        n -= 500;
                        return_string += "D";
                    }
                    else if (n >= 200)
                    {
                        n -= 200;
                        return_string += "CC";
                    }
                    else if (n >= 100)
                    {
                        n -= 100;
                        return_string += "C";
                    }
                    else if (n >= 90)
                    {
                        n -= 90;
                        return_string += "XC";
                    }
                    else if (n >= 60)
                    {
                        n -= 60;
                        return_string += "LX";
                    }
                    else if (n >= 50)
                    {
                        n -= 50;
                        return_string += "L";
                    }
                    else if (n >= 40)
                    {
                        n -= 40;
                        return_string += "XL";
                    }
                    else if (n >= 10)
                    {
                        n -= 10;
                        return_string += "X";
                    }
                    else if (n >= 9)
                    {
                        n -= 9;
                        return_string += "IX";
                    }
                    else if (n >= 5)
                    {
                        n -= 5;
                        return_string += "V";
                    }
                    else if (n >= 4)
                    {
                        n -= 4;
                        return_string += "IV";
                    }
                    else if (n >= 1)
                    {
                        n -= 1;
                        return_string += "I";
                    }
                }
                return return_string;
            }

            public static bool IsPrime(int n)
            {
                if (n <= 0) return false;
                //if(n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0 || n % 11 == 0 || n % 13 == 0 || n % 17 == 0 || n % 19 == 0)
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                if (n == 1) return false;
                return true;
            }

            public static bool IsPangram(string str)
            {
                int temp = 0;
                if (str == "") throw new NotImplementedException();
                string[] string_arr = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                for (int i = 0; i < 26; i++)
                {
                    if (str.ToLower().Contains(string_arr[i]))
                    {
                        temp += 1;
                    }
                }

                if (temp == 26) return true;
                else return false;
            }

            public static string PigIt(string str)
            {
                string[] strArr = str.Split(' ');
                for (int i = 0; i < strArr.Length; i++)
                {
                    if (strArr[i] != "!") strArr[i] = PigItUnit(strArr[i]);
                }
                string returnString = "";
                for (int i = 0; i < strArr.Length; i++)
                {
                    returnString += strArr[i];
                    if (i + 1 != strArr.Length) returnString += " ";
                }

                return returnString;
            }

            public static string PigItUnit(string str)
            {
                char[] strCharArr = str.ToCharArray();

                char temp = strCharArr[0];
                for (int i = 0; i + 1 < strCharArr.Length; i++)
                {
                    strCharArr[i] = strCharArr[i + 1];
                }
                strCharArr[strCharArr.Length - 1] = temp;

                string returnString = "";
                for (int i = 0; i < strCharArr.Length; i++)
                {
                    returnString += strCharArr[i];
                }
                returnString += "ay";

                return returnString;
            }
        }

        public class FactorialTail
        {
            // fixme
            public static int zeroes(int base1, int number)
            {
                Console.Write("{0}\t{1}\n", base1, number);
                BigInteger factorial = 1;
                int trailingzeroes = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (i % base1 == 0)
                    {
                        trailingzeroes++;
                    }
                    else
                    {
                        factorial *= i;
                        if (factorial % base1 == 0)
                        {
                            factorial /= base1;
                            trailingzeroes++;
                        }
                    }
                }
                return trailingzeroes;
            }
        }

        public class Evaluator
        {
            public static string sumStrings(string a, string b)
            {
                string aa = String.Join("", a.SkipWhile(p => p == '0'));
                string bb = String.Join("", b.SkipWhile(p => p == '0'));
                int[] a_split = aa.Select(p => p - '0').Reverse().ToArray();
                int[] b_split = bb.Select(p => p - '0').Reverse().ToArray();
                int longer = 0;
                if (a_split.Length > b_split.Length)
                {
                    longer = a_split.Length;
                    int[] additional_zero = new int[a_split.Length - b_split.Length];
                    b_split = b_split.Concat(additional_zero).ToArray();
                }
                else if (a_split.Length < b_split.Length)
                {
                    longer = b_split.Length;
                    int[] additional_zero = new int[b_split.Length - a_split.Length];
                    a_split = a_split.Concat(additional_zero).ToArray();
                }
                else
                {
                    longer = a_split.Length;
                }
                int[] returnArr = new int[longer + 1];
                for (int i = 0; i < longer; i++)
                {
                    returnArr[i] = 0;
                }

                for (int i = 0; i < longer; i++)
                {
                    if ((a_split[i] + b_split[i]) >= 10)
                    {
                        returnArr[i] += (a_split[i] + b_split[i]) % 10;
                        returnArr[i + 1] += (a_split[i] + b_split[i]) / 10;
                    }
                    else
                    {
                        returnArr[i] += (a_split[i] + b_split[i]);
                    }

                    if (returnArr[i] >= 10)
                    {
                        returnArr[i + 1] += returnArr[i] / 10;
                        returnArr[i] = returnArr[i] % 10;
                    }
                }

                if (returnArr.Last() == 0) returnArr = returnArr.Take(returnArr.Length - 1).ToArray();
                return String.Join("", returnArr.Reverse());
            }

            public double Evaluate(string expression)
            {
                return 0.0;
            }
        }

        public class DirReduction
        {
            public static string[] dirReduc(String[] arr)
            {
                int temp = 0;
                int item_enum = 0;
                int index = 0;
                int[] arr_enum = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    switch (arr[i])
                    {
                        case "NORTH":
                            arr_enum[i] = 1;
                            break;

                        case "SOUTH":
                            arr_enum[i] = -1;
                            break;

                        case "EAST":
                            arr_enum[i] = 100;
                            break;

                        case "WEST":
                            arr_enum[i] = -100;
                            break;
                    }
                }
                while (arr_enum.Where((p, i) => p + ((i + 1) == arr_enum.Length ? 0 : arr_enum[i + 1]) == 0).Count() > 0)
                {
                    for (int i = 0; i < arr_enum.Length - 1; i++)
                    {
                        if (arr_enum[i] + arr_enum[i + 1] == 0)
                        {
                            arr_enum[i] = 88;
                            arr_enum[i + 1] = 88;
                        }
                    }

                    arr_enum = arr_enum.Where(p => p != 88).ToArray();
                }

                string[] returnArr = new string[arr_enum.Length];
                for (int i = 0; i < arr_enum.Length; i++)
                {
                    switch (arr_enum[i])
                    {
                        case 1:
                            returnArr[i] = "NORTH";
                            break;

                        case -1:
                            returnArr[i] = "SOUTH";
                            break;

                        case 100:
                            returnArr[i] = "EAST";
                            break;

                        case -100:
                            returnArr[i] = "WEST";
                            break;
                    }
                }
                return returnArr;
            }
        }

        public class Bundesliga
        {
            public class soccer_team
            {
                public string name { get; set; } = "";
                public int total_game { get; set; } = 0;
                public int win { get; set; } = 0;
                public int tie { get; set; } = 0;
                public int lose { get; set; } = 0;
                public int shot { get; set; } = 0;
                public int gotten { get; set; } = 0;

                public int point
                {
                    get { return win * 3 + tie; }
                    set { point = win * 3 + tie; }
                }

                public int rank { get; set; } = 0;
            }

            public static string Table(string[] results)
            {
                List<soccer_team> resultTable = new List<soccer_team>();
                string returnString = "";
                foreach (string resultString in results)
                {
                    int scores1 = Convert.ToInt32(resultString.Split(' ').First().Split(':').First().Trim() == "-" ? "-1" : resultString.Split(' ').First().Split(':').First().Trim());
                    int scores2 = Convert.ToInt32(resultString.Split(' ').First().Split(':').Last().Trim() == "-" ? "-1" : resultString.Split(' ').First().Split(':').Last().Trim());
                    var temp = resultString.Split(' ').Skip(1);
                    string team1 = String.Join(" ", temp).Trim().Split('-').First().Trim();
                    string team2 = String.Join(" ", temp).Trim().Split('-').Last().Trim();
                    if (resultTable.Count == 0 || (resultTable.Where(p => p.name == team1).Count() == 0 && resultTable.Where(p => p.name == team2).Count() == 0))
                    {
                        soccer_team temp1 = new soccer_team();
                        soccer_team temp2 = new soccer_team();
                        temp1.name = team1;
                        temp2.name = team2;
                        if (scores1 != -1 && scores2 != -1)
                        {
                            temp1.total_game += 1;
                            temp2.total_game += 1;
                            temp1.shot += scores1;
                            temp1.gotten += scores2;
                            temp2.shot += scores2;
                            temp2.gotten += scores1;
                            if (scores1 > scores2)
                            {
                                temp1.win += 1;
                                temp2.lose += 1;
                            }
                            else if (scores1 < scores2)
                            {
                                temp1.lose += 1;
                                temp2.win += 1;
                            }
                            else
                            {
                                temp1.tie += 1;
                                temp2.tie += 1;
                            }
                        }
                        resultTable.Add(temp1);
                        resultTable.Add(temp2);
                    }
                    else if (resultTable.Where(p => p.name == team1).Count() != 0 && resultTable.Where(p => p.name == team2).Count() == 0)
                    {
                        int index1 = resultTable.IndexOf(resultTable.Where(p => p.name == team1).FirstOrDefault());
                        soccer_team temp2 = new soccer_team();
                        temp2.name = team2;
                        if (scores1 != -1 && scores2 != -1)
                        {
                            resultTable[index1].total_game += 1;
                            temp2.total_game += 1;
                            resultTable[index1].shot += scores1;
                            resultTable[index1].gotten += scores2;
                            temp2.shot += scores2;
                            temp2.gotten += scores1;
                            if (scores1 > scores2)
                            {
                                resultTable[index1].win += 1;
                                temp2.lose += 1;
                            }
                            else if (scores1 < scores2)
                            {
                                resultTable[index1].lose += 1;
                                temp2.win += 1;
                            }
                            else
                            {
                                resultTable[index1].tie += 1;
                                temp2.tie += 1;
                            }
                        }
                        resultTable.Add(temp2);
                    }
                    else if (resultTable.Where(p => p.name == team1).Count() == 0 && resultTable.Where(p => p.name == team2).Count() != 0)
                    {
                        soccer_team temp1 = new soccer_team();
                        int index2 = resultTable.IndexOf(resultTable.Where(p => p.name == team1).FirstOrDefault());
                        temp1.name = team1;
                        if (scores1 != -1 && scores2 != -1)
                        {
                            temp1.total_game += 1;
                            resultTable[index2].total_game += 1;
                            temp1.shot += scores1;
                            temp1.gotten += scores2;
                            resultTable[index2].shot += scores2;
                            resultTable[index2].gotten += scores1;
                            if (scores1 > scores2)
                            {
                                temp1.win += 1;
                                resultTable[index2].lose += 1;
                            }
                            else if (scores1 < scores2)
                            {
                                temp1.lose += 1;
                                resultTable[index2].win += 1;
                            }
                            else
                            {
                                temp1.tie += 1;
                                resultTable[index2].tie += 1;
                            }
                        }
                        resultTable.Add(temp1);
                    }
                    else
                    {
                        int index1 = resultTable.IndexOf(resultTable.Where(p => p.name == team1).FirstOrDefault());
                        int index2 = resultTable.IndexOf(resultTable.Where(p => p.name == team1).FirstOrDefault());
                        if (scores1 != -1 && scores2 != -1)
                        {
                            resultTable[index1].total_game += 1;
                            resultTable[index2].total_game += 1;
                            resultTable[index1].shot += scores1;
                            resultTable[index1].gotten += scores2;
                            resultTable[index2].shot += scores2;
                            resultTable[index2].gotten += scores1;
                            if (scores1 > scores2)
                            {
                                resultTable[index1].win += 1;
                                resultTable[index2].lose += 1;
                            }
                            else if (scores1 < scores2)
                            {
                                resultTable[index1].lose += 1;
                                resultTable[index2].win += 1;
                            }
                            else
                            {
                                resultTable[index1].tie += 1;
                                resultTable[index2].tie += 1;
                            }
                        }
                    }
                }
                List<soccer_team> resultTable_sorted = resultTable.OrderByDescending(p => p.point).ThenByDescending(p => p.shot - p.gotten).ThenByDescending(p => p.shot).ThenBy(p => p.name).ToList();
                int rank_point = -1;
                int rank_differ = -1;
                int rank_shot = -1;
                int rank = 1;
                foreach (soccer_team team in resultTable_sorted)
                {
                    if (rank_point == -1 && rank_differ == -1 && rank_shot == -1) team.rank = rank;
                    else if (team.point != rank_point || team.shot - team.gotten != rank_differ || team.shot != rank_shot)
                    {
                        team.rank = resultTable_sorted.IndexOf(resultTable_sorted.Where(p => p.name == team.name).FirstOrDefault()) + 1;
                        rank = team.rank;
                    }
                    else team.rank = rank;
                    returnString += team.rank.ToString().PadLeft(2, ' ') + ". " + team.name.PadRight(30, ' ') + team.total_game + "  " + team.win + "  " + team.tie + "  " + team.lose + "  " + team.shot + ":" + team.gotten + "  " + team.point + "\n";
                    rank_point = team.point;
                    rank_differ = team.shot - team.gotten;
                    rank_shot = team.shot;
                }

                return returnString.Remove(returnString.LastIndexOf("\n"));
            }
        }

        public class BattleshipField
        {
            public static bool ValidateBattlefield(int[,] field)
            {
                int amount_4Dship = 1;
                int amount_3Dship = 2;
                int amount_2Dship = 3;
                int amount_1Dship = 4;
                int count = 0;
                int row_count = 0;
                int[] col_count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (field[i, j] == 1)
                        {
                            count++;
                            if (i + 1 < 10 && field[i + 1, j] == 1)
                            {
                                if (i + 1 < 10 && field[i + 2, j] == 1)
                                {
                                    if (i + 1 < 10 && field[i + 2, j] == 1)
                                    {
                                        if (amount_4Dship > 0) amount_4Dship--;
                                        else return false;
                                        if (field[i, j + 1] + field[i + 1, j + 1] + field[i + 2, j + 1] + field[i + 3, j + 1] + field[i + 4, j] > 0) return false;
                                    }

                                    if (amount_3Dship > 0) amount_3Dship--;
                                    else return false;
                                }
                                if (amount_2Dship > 0) amount_2Dship--;
                                else return false;
                            }

                            if (j + 1 < 10 && field[i, j + 1] == 1)
                            {
                            }
                            if (amount_1Dship > 0) amount_1Dship--;
                            else return false;
                        }
                    }
                }

                if (count != 20) return false;
                return true;
            }
        }

        public class Kata4
        {
            public static string Justify(string str, int len)
            {
                if (str[len - 1] != ' ')
                {
                }
                return str;
            }

            public static long NextSmaller(long n)
            {
                // Strategy = go from right to left and find the first digit with a number greater to the left
                // eg 285123 - find the '1' because there's a greater number beside
                // Find the biggest number to the right, and switch the two
                // eg 285123 - switch the 5 and the 3 = 283125
                // Then, sort everything to the right of the index in descending order
                // eg 283125 -> 283521
                int[] intArr = new int[n.ToString().Length];
                for (int i = 0; i < intArr.Length; i++)
                {
                    intArr[i] = (int)(n % 10);
                    n /= 10;
                }

                int index_current = 0;
                int index_biggest = 0;
                for (index_current = 1; index_current < intArr.Length; index_current++)
                {
                    if (intArr[index_current] > intArr[index_current - 1]) break;
                }
                index_biggest = index_current - 1;

                if (index_current >= intArr.Length) return -1;

                for (int i = 0; i < index_current; i++)
                {
                    if (intArr[i] > intArr[index_biggest] && intArr[index_current] > intArr[i])
                    {
                        index_biggest = i;
                    }
                }

                //swap
                int temp = intArr[index_current];
                intArr[index_current] = intArr[index_biggest];
                intArr[index_biggest] = temp;

                int[] rightArr = intArr.Select((v, i) => new { Index = i, Value = v })
                                        .Where(p => p.Index <= index_current)
                                        .Select(p => p.Value)
                                        .ToArray();
                Array.Sort(rightArr);

                for (int i = 0; i < rightArr.Length; i++)
                {
                    intArr[i] = rightArr[i];
                }

                long output = 0;
                long pos = 1;
                for (int i = 0; i < intArr.Length; i++)
                {
                    output += pos * intArr[i];
                    pos *= 10;
                }

                if (output.ToString().Length < intArr.Length) return -1;

                return output;
            }
        }

        public class Sudoku
        {
            public static bool ValidateSolution(int[][] board)
            {
                int[] conditions = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int unvalidCount = 0;
                for (int i = 0; i < 9; i++)
                {
                    var row = board.Skip(i).Take(1).SelectMany(x => x).ToArray();
                    if (row.Contains(0)) return false;
                    unvalidCount += conditions.All(p => row.Contains(p)) ? 0 : 1;
                }

                for (int i = 0; i < 9; i++)
                {
                    var col = board.Take(9).Select(p => p[i]).ToArray();
                    if (col.Contains(0)) return false;
                    unvalidCount += conditions.All(p => col.Contains(p)) ? 0 : 1;
                }

                for (int i = 0; i <= 6; i += 3)
                {
                    for (int j = 0; j <= 6; j += 3)
                    {
                        var square = board.Skip(0).Take(3).Select(p => p.Skip(0).Take(3)).SelectMany(x => x).ToArray();
                        if (square.Contains(0)) return false;
                        unvalidCount += conditions.All(p => square.Contains(p)) ? 0 : 1;
                    }
                }
                return unvalidCount > 0 ? false : true;
            }
        }

        public class StripCommentsSolution
        {
            public static string StripComments(string text, string[] commentSymbols)
            {
                return string.Join("\n", text.Split('\n')
                            .Select(x => x.Split(commentSymbols, StringSplitOptions.None)
                            .First()
                            .TrimEnd(' ')));
            }
        }

        public class RangeExtraction
        {
            public static string Extract(int[] args)
            {
                int[] ss = args.OrderBy(p => p).ToArray();
                string returnValue = "";
                int temp = 0;
                for (int i = 0; i < ss.Length; i++)
                {
                    if (i == 0) temp = i;
                    else if (i == ss.Length - 1)
                    {
                        if (ss[i - 1] + 1 != ss[i])
                        {
                            if (i - temp == 1)
                            {
                                returnValue += Convert.ToString(ss[temp]) + "," + Convert.ToString(ss[i]);
                            }
                            else if (i - temp == 2)
                            {
                                returnValue += Convert.ToString(ss[temp]) + "," + Convert.ToString(ss[i - 1]) + "," + Convert.ToString(ss[i]);
                            }
                            else if (i - temp > 2)
                            {
                                returnValue += Convert.ToString(ss[temp]) + "-" + Convert.ToString(ss[i - 1]) + "," + Convert.ToString(ss[i]);
                            }
                        }
                        else
                        {
                            if (i - temp == 1)
                            {
                                returnValue += Convert.ToString(ss[temp]) + "," + Convert.ToString(ss[i]); ;
                            }
                            else
                            {
                                returnValue += Convert.ToString(ss[temp]) + "-" + Convert.ToString(ss[i]);
                            }
                        }
                    }
                    else
                    {
                        if (ss[i - 1] + 1 != ss[i])
                        {
                            if (i - temp == 1)
                            {
                                returnValue += Convert.ToString(ss[temp]) + ",";
                                temp = i;
                            }
                            else if (i - temp == 2)
                            {
                                returnValue += Convert.ToString(ss[temp]) + "," + Convert.ToString(ss[i - 1]) + ",";
                                temp = i;
                            }
                            else if (i - temp > 2)
                            {
                                returnValue += Convert.ToString(ss[temp]) + "-" + Convert.ToString(ss[i - 1]) + ",";
                                temp = i;
                            }
                        }
                    }
                }
                return returnValue;
            }
        }

        public static class Kata
        {
            public static List<string> GetPINs(string observed)
            {
                List<string> GetPINs_digits(char input)
                {
                    if (Convert.ToInt32(input) > 9 && Convert.ToInt32(input) < 0) throw new Exception();
                    switch (input)
                    {
                        case '1': return new List<string> { "1", "2", "4" };
                        case '2': return new List<string> { "1", "2", "3", "5" };
                        case '3': return new List<string> { "2", "3", "6" };
                        case '4': return new List<string> { "1", "4", "5", "7" };
                        case '5': return new List<string> { "2", "4", "5", "6", "8" };
                        case '6': return new List<string> { "3", "5", "6", "9" };
                        case '7': return new List<string> { "4", "7", "8" };
                        case '8': return new List<string> { "5", "7", "8", "9", "0" };
                        case '9': return new List<string> { "6", "8", "9" };
                        case '0': return new List<string> { "0", "8" };
                        default: return new List<string> { };
                    }
                }

                char[] obsrved_sub = observed.ToCharArray();
                List<string> returnValue = new List<string>();
                foreach (char c in obsrved_sub)
                {
                    List<string> temp = GetPINs_digits(c);
                    if (returnValue.Count == 0) returnValue = temp;
                    else
                    {
                        List<string> temp1 = new List<string>();
                        foreach (string temp_lv2 in temp)
                        {
                            temp1.AddRange(returnValue.Select(p => p + temp_lv2));
                        }
                        returnValue = temp1;
                    }
                }
                return returnValue;
            }

            public static BigInteger perimeter(BigInteger n)
            {
                BigInteger Fibonacci_sum(BigInteger nn)
                {
                    BigInteger total = nn + 1;
                    BigInteger fibonacci_num = new BigInteger(0);
                    BigInteger returnValue = new BigInteger(0);
                    BigInteger temp1 = new BigInteger(0);
                    BigInteger temp2 = new BigInteger(0);
                    for (int i = 0; i < total; i++)
                    {
                        if (i == 0)
                        {
                            fibonacci_num = 1;
                            temp1 = temp2;
                            temp2 = fibonacci_num;
                            returnValue += fibonacci_num;
                        }
                        else
                        {
                            fibonacci_num = temp1 + temp2;
                            temp1 = temp2;
                            temp2 = fibonacci_num;
                            returnValue += fibonacci_num;
                        }
                    }
                    return returnValue;
                }

                return 4 * Fibonacci_sum(n);
            }

            public static int TrailingZeros(int n)
            {
                int fibonacci_num = 0;
                while (n >= 5)
                {
                    n /= 5;
                    fibonacci_num += n;
                }

                return fibonacci_num;
            }
        }

        internal class Program
        {
            private static int[][][] matrix =
            {
            new int[][] { new [] { 1 } },
            new int[][] { new [] { 1, 3 }, new [] { 2, 5 } },
            new int[][] { new [] { 2, 5, 3 }, new [] { 1, -2, -1 }, new [] { 1, 3, 4 } },
            new int[][] { new [] { 2, 5, 3, 5, 3, 3 }, new[] { 2, 5, 3, 5, 3, 3 }, new[] { 2, 5, 3, 5, 3, 3 }, new[] { 2, 5, 3, 5, 3, 3 }, new [] { 1, -2, 3, -1, 5, 3 }, new [] { 1, 3, 3, 4, 5, 3 } }
        };

            public void Test1()
            {
                List<long[]> r = new List<long[]> {
                                                new long[] { 15, 21 },
                                                new long[] { 21, 15 }
                                                         };
                // Assert.AreEqual(r, RemovedNumbers.removNb(26));
            }

            private static int[] expected = { 1, -1, -20, 20 };

            public class IgnoreCaseSensitive : IEqualityComparer<string>
            {
                public bool Equals(string s1, string s2)
                {
                    return (s1.ToUpper().Equals(s2.ToUpper()));
                }

                public int GetHashCode(string str)
                {
                    return str.ToUpper().GetHashCode();
                }
            }

            private static string[] msg = { "Determinant of a 1 x 1 matrix yields the value of the one element", "Should return 1 * 5 - 3 * 2 == -1 ", "" };
        }

        public class TicTacToe
        {
            public static int IsSolved(int[,] board)
            {
                int rank = board.GetLength(0);
                var col = board.Cast<int>().Take(rank).ToArray();
                if (board.Cast<int>().Where(p => p == 0).Count() > 0) return -1;
                return 0;
            }
        }

        public class TopWords
        {
            public static List<string> Top3(string s)
            {
                char[] separators = new char[] { ' ', ',', '.', '/', '\n' };
                var sss = s.ToLower()
                           .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                           .Where(p => p != "\'" && !p.Contains("\'\'") && !p.Contains("-") && !p.Contains("_") && !p.Contains(":") && !p.Contains(";"))
                           .GroupBy(p => p)
                           .OrderByDescending(p => p.Count())
                           .Take(3)
                           .Select(p => p.Key)
                           .Where(p => p != "\'" && p.Contains("\'\'"))
                           .ToList();
                return sss;
            }
        }

        public class Parentheses
        {
            public static bool ValidParentheses(string input)
            {
                int parentheses = 0;
                foreach (char t in input)
                {
                    if (t == '(')
                    {
                        parentheses++;
                    }
                    else if (t == ')')
                    {
                        parentheses--;

                        if (parentheses < 0)
                        {
                            return false;
                        }
                    }
                }

                return parentheses == 0;
            }
        }

        public class SnailSolution
        {
            public static int[] Snail(int[][] array)
            {
                var outside = new int[][]
                {
        // top (left to right)
        array[0],
        // right (top to bottom)
        array.Skip(1).Take(array.Length - 2).Select(x => x[x.Length - 1]).ToArray(),
        // bottom (right to left)
        array.Length > 1 ? array.Last().Reverse().ToArray() : new int[] {},
        // left (bottom to top)
        array.Skip(1).Take(array.Length - 2).Reverse().Select(x => x[0]).ToArray()
                };

                // Get the inside to recursively pass back into this Snail method
                var inside = array
                  .Skip(1)
                  .Take(array.Length - 2)
                  .Select(x => x.Skip(1).Take(x.Length - 2).ToArray())
                  .ToArray();

                // Return a flattened array
                return outside
                  .SelectMany(x => x)
                  .Concat(inside.Length > 0 ? Snail(inside) : new int[] { })
                  .ToArray();
            }
        }

        public class Result
        {
            public class getMaxUnits_Model
            {
                public long boxes { get; set; }
                public long unitsPerBox { get; set; }
            }

            public static long getMaxUnits(List<long> boxes, List<long> unitsPerBox, long truckSize)
            {
                int n = boxes.Count;
                List<getMaxUnits_Model> returnList = new List<getMaxUnits_Model>();
                for (int i = 0; i < n; i++)
                {
                    getMaxUnits_Model returnList_item = new getMaxUnits_Model();
                    returnList_item.boxes = boxes[i];
                    returnList_item.unitsPerBox = unitsPerBox[i];
                    returnList.Add(returnList_item);
                }
                var returnList_afterOrder = returnList.OrderByDescending(p => p.unitsPerBox).Take((int)truckSize).ToList();

                long total = 0;
                for (int j = 0; j < returnList_afterOrder.Count(); j++)
                {
                    total += returnList_afterOrder[j].boxes * returnList_afterOrder[j].unitsPerBox;
                }

                return total;
            }

            public static int getMinimumUniqueSum(List<int> arr)
            {
                var duplicate = arr.GroupBy(i => i)
            .Where(g => g.Count() > 1)
            .Select(g => g.ElementAt(0));

                while (arr.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.ElementAt(0)).Count() > 0)
                {
                    int[] arrA = arr.ToArray();
                    for (int i = 0; i < arrA.Length; i++)
                    {
                        for (int j = i + 1; j < arrA.Length; j++)
                        {
                            if (arrA[i] == arrA[j])
                            {
                                arrA[j]++;
                            }
                        }
                    }
                }

                return arr.Sum();
            }

            public static string shortestSubstring(string givenString)
            {
                string distinctString = givenString.ToCharArray().GroupBy(ch => ch).Select(g => g.First()).ToString();
                return distinctString;
            }

            public class numDuplicates_Model
            {
                public string name { get; set; }
                public int price { get; set; }
                public int weight { get; set; }
            }

            public static int numDuplicates(List<string> name, List<int> price, List<int> weight)
            {
                List<numDuplicates_Model> returnList = new List<numDuplicates_Model>();
                for (int i = 0; i < name.Count; i++)
                {
                    numDuplicates_Model returnList_item = new numDuplicates_Model();
                    returnList_item.name = name[i];
                    returnList_item.price = price[i];
                    returnList_item.weight = weight[i];
                    returnList.Add(returnList_item);
                }
                List<numDuplicates_Model> returnList2 = returnList.GroupBy(p => new { p.name, p.price }).Select(g => g.First()).ToList();
                return name.Count - returnList2.Count;
            }

            public static void fizzBuzz(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i % 15 == 0 && i > 15)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 5 == 0 && i > 5)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 3 == 0 && i > 3)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }
        }

        public class RemovedNumbers
        {
            public static List<long[]> removNb(long n)
            {
                List<long[]> returnList = new List<long[]>();
                long sum = (long)(n * (n + 1) / 2);
                long b;
                for (long a = 0; a < n; a++)
                {
                    b = (sum - a) / (a + 1);

                    if (a * b + a + b == sum)
                    {
                        long[] ab = new long[2] { a, b };
                        returnList.Add(ab);
                    }
                }
                return returnList;
            }
        }

        public class Matrix
        {
            public static dynamic Determinant(int[][] matrix)
            {
                int row_n = matrix.GetLength(0);
                double[,] Matrix = new double[row_n, row_n];
                for (int i = 0; i < row_n; i++)
                {
                    for (int j = 0; j < row_n; j++)
                    {
                        Matrix[i, j] = matrix[i][j];
                    }
                }
                return Det(row_n, Matrix);

                double Det(int n, double[,] Mat)
                {
                    double d = 0;
                    int k, i, j, subi, subj;
                    double[,] SUBMat = new double[n, n];
                    var indices = Enumerable.Range(0, Mat.GetLength(0));

                    if (n == 1)
                    {
                        return Mat[0, 0];
                    }

                    if (n == 2)
                    {
                        return ((Mat[0, 0] * Mat[1, 1]) - (Mat[1, 0] * Mat[0, 1]));
                    }
                    else
                    {
                        for (k = 0; k < n; k++)
                        {
                            subi = 0;
                            for (i = 1; i < n; i++)
                            {
                                subj = 0;
                                for (j = 0; j < n; j++)
                                {
                                    if (j != k)
                                    {
                                        SUBMat[subi, subj] = Mat[i, j];
                                        subj++;
                                    }
                                }
                                subi++;
                            }
                            d = d + ((k % 2 == 0 ? 1 : -1) * Mat[0, k] * Det(n - 1, SUBMat));
                        }
                    }
                    return d;
                }
            }
        }
    }
}