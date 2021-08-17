using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Duplicate_Encoder
{
    internal class main
    {
        private static void Main(string[] args)
        {
            //int[][] array =
            //{
            //    new []{1, 2, 3},
            //    new []{4, 5, 6},
            //    new []{7, 8, 9}
            //};
            //var list = new List<string>() { "ASUS", "Acer", "BenQ", "asus", "ACER", "HP" };
            //var comparer = new IgnoreCaseSensitive();
            //var list2 = list.Distinct();
            //var list3 = list.Distinct(comparer);
            //foreach (var i in list2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //foreach (var i in list3)
            //{
            //    Console.WriteLine(i);
            //}
            int[][] board = new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
          new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
        };
            //StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" });
            //Sudoku.ValidateSolution(board);
            //Console.WriteLine(Kata.TrailingZeros(6));
            //      Console.WriteLine(Bundesliga.Table(new[]
            //{
            //  "6:0 FC Bayern Muenchen - Werder Bremen",
            //  "-:- Eintracht Frankfurt - Schalke 04",
            //  "-:- FC Augsburg - VfL Wolfsburg",
            //  "-:- Hamburger SV - FC Ingolstadt",
            //  "-:- 1. FC Koeln - SV Darmstadt",
            //  "-:- Borussia Dortmund - FSV Mainz 05",
            //  "-:- Borussia Moenchengladbach - Bayer Leverkusen",
            //  "-:- Hertha BSC Berlin - SC Freiburg",
            //  "-:- TSG 1899 Hoffenheim - RasenBall Leipzig"
            //}));
            //Console.Write(Kata5.Mixbonacci(new string[] { "fib" }, 10));
            //string[] returnString = DirReduction.dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" });
            //foreach (string item in returnString)
            //{
            //    Console.Write(item + " ");
            //}

            LeetCode_Solution instanceA = new LeetCode_Solution();
            HISKIO_Solution instanceB = new HISKIO_Solution();
            //bool outputA = instanceA.IsPalindrome(1221);
            int[] testCase = new int[] { 1, 2, 3 };
            TreeNode bst1 = new TreeNode(5);
            bst1.left = new TreeNode(4);
            bst1.left.left = new TreeNode(11);
            bst1.left.left.left = new TreeNode(7);
            bst1.left.left.right = new TreeNode(2);
            bst1.right = new TreeNode(8);
            bst1.right.left = new TreeNode(13);
            bst1.right.right = new TreeNode(4);
            bst1.right.right.right = new TreeNode(1);
            //instanceA.SearchInsert(new int[] { 1, 3, 4 }, 2);
            //instanceA.parse_0AH(176);
            //Console.WriteLine(instanceA.ThreeSumMulti(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0));
            //int[] temp = instanceA.BeautifulArray(6);
            int[][] testCase2 = new int[6][];
            testCase2[0] = new int[] { 0, 1, 1, 0, 0, 0 };
            testCase2[1] = new int[] { 0, 1, 0, 1, 1, 0 };
            testCase2[2] = new int[] { 0, 1, 1, 0, 1, 0 };
            testCase2[3] = new int[] { 0, 0, 0, 1, 1, 0 };
            testCase2[4] = new int[] { 1, 1, 1, 1, 1, 0 };
            testCase2[5] = new int[] { 1, 1, 1, 1, 1, 0 };
            //int a = instanceA.ShortestPathBinaryMatrix(testCase2);

            ListNode l1 = new ListNode(1);
            ListNode l1_clone = l1;
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);
            ListNode l2 = new ListNode(1);
            ListNode l2_clone = l2;
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);
            //instanceA.SetZeroes(new int[][] { new int[] { 0, 1, 2, 0 }, new int[] { 3, 4, 5, 2 }, new int[] { 1, 3, 1, 5 } });
            Console.WriteLine(instanceA.CanCompleteCircuit(new int[] { 2 }, new int[] { 2 }));
            //foreach (int i in temp)
            //{
            //    Console.WriteLine();
            //}
            Console.Read();

            //SnailSolution.Snail(array);
            //Console.Write(Result.getMinimumUniqueSum(eee));
            //Console.Read();
            //for (int n = 0; n < expected.Length; n++)
            //{
            //IWorkbook wb = new HSSFWorkbook();
            //ISheet ws = wb.CreateSheet("class");

            //    Console.Write(Matrix.Determinant(matrix[n]));
            //    Console.Read();
            //}
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

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
    }
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

    //public class Parentheses
    //{
    //    public static bool ValidParentheses(string input)
    //    {
    //        Console.Write(input);
    //        if (input == null) return false;
    //        if (input.Length == 0) return false;
    //        var var1 = input.Where(p => p == '(' || p == ')').ToArray();
    //        string returnString = new string(var1);
    //        if (!returnString.Contains("()")) return false;
    //        while (returnString.Length > 1 && returnString.Contains("()"))
    //        {
    //            returnString = returnString.Replace("()", "");
    //        }
    //        if (returnString.Length >= 1) return false;
    //        return true;
    //    }
    //}
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

public static class Kata5
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
