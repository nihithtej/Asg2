/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM6225_Assignment_2_Spring_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 1, 2, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums1, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Question2:
            Console.WriteLine("Question 2");
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = { "hit" };
            string commonWord = MostCommonWord(paragraph, banned);
            Console.WriteLine("Most frequent word is {0}:", commonWord);
            Console.WriteLine();

            //Question 3:
            Console.WriteLine("Question 3");
            int[] arr1 = { 2, 2, 3, 4 };
            int lucky_number = FindLucky(arr1);
            Console.WriteLine("The Lucky number in the given array is {0}", lucky_number);
            Console.WriteLine();

            //Question 4:
            Console.WriteLine("Question 4");
            string secret = "1807";
            string guess = "7810";
            string hint = GetHint(secret, guess);
            Console.WriteLine("Hint for the guess is :{0}", hint);
            Console.WriteLine();


            //Question 5:
            Console.WriteLine("Question 5");
            string s = "ababcbacadefegdehijhklij";
            List<int> part = PartitionLabels(s);
            Console.WriteLine("Partation lengths are:");
            for (int i = 0; i < part.Count; i++)
            {
                Console.Write(part[i] + "\t");
            }
            Console.WriteLine();

            //Question 6:
            Console.WriteLine("Question 6");
            int[] widths = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            string bulls_string9 = "abcdefghijklmnopqrstuvwxyz";
            List<int> lines = NumberOfLines(widths, bulls_string9);
            Console.WriteLine("Lines Required to print:");
            for (int i = 0; i < lines.Count; i++)
            {
                Console.Write(lines[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Question 7:
            Console.WriteLine("Question 7:");
            string bulls_string10 = "()[]{}";
            bool isvalid = IsValid(bulls_string10);
            if (isvalid)
                Console.WriteLine("Valid String");
            else
                Console.WriteLine("String is not Valid");

            Console.WriteLine();
            Console.WriteLine();


            //Question 8:
            Console.WriteLine("Question 8");
            string[] bulls_string13 = { "gin", "zen", "gig", "msg" };
            int diffwords = UniqueMorseRepresentations(bulls_string13);
            Console.WriteLine("Number of with unique code are: {0}", diffwords);
            Console.WriteLine();
            Console.WriteLine();

            //Question 9:
            //Console.WriteLine("Question 9");
            //int[,] grid = new int[,]{ { 0, 1, 2, 3, 4 }, { 24, 23, 22, 21, 5 }, { 12, 13, 14, 15, 16 }, { 11, 17, 18, 19, 20 }, { 10, 9, 8, 7, 6 } };
            //int time = SwimInWater(grid);
            //Console.WriteLine("Minimum time required is: {0}", time);
            //Console.WriteLine();

            //Question 10:
            Console.WriteLine("Question 10");
            string word1 = "horse";
            string word2 = "ros";
            int minLen = MinDistance(word1, word2);
            Console.WriteLine("Minimum number of operations required are {0}", minLen);
            Console.WriteLine();
        }


        /*
        
        Question 1:
        Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        Note: The algorithm should have run time complexity of O (log n).
        Hint: Use binary search
        Example 1:
        Input: nums = [1,3,5,6], target = 5
        Output: 2
        Example 2:
        Input: nums = [1,3,5,6], target = 2
        Output: 1
        Example 3:
        Input: nums = [1,3,5,6], target = 7
        Output: 4
        */

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {

                int min = 0;
                int max = nums.Length - 1;

                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    Console.WriteLine(mid);
                    if (target == nums[mid])
                    {
                        return mid;
                    }
                    else if (target < nums[mid])
                    {
                        max = mid - 1;

                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                return min + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         
        Question 2
       
        Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.
        The words in paragraph are case-insensitive and the answer should be returned in lowercase.
        Example 1:
        Input: paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
        Output: "ball"
        Explanation: "hit" occurs 3 times, but it is a banned word. "ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
        Note that words in the paragraph are not case sensitive, that punctuation is ignored (even if adjacent to words, such as "ball,"), and that "hit" isn't the answer even though it occurs more because it is banned.
        Example 2:
        Input: paragraph = "a.", banned = []
        Output: "a"
        */

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            try
            {

                string s = paragraph;
                //Console.WriteLine(s);
                char[] totrim = { ',', '.', '?', '\'', ';', '!' };


                //Dictionary<int, int>.ValueCollection valueColl = D.Values;

                s = s.ToLower();
                //Console.WriteLine(s);

                //foreach (string q in banned)
                //{
                //    s = s.Replace(q," ");
                //}
                //Console.WriteLine(s);
                string[] s2 = new string[s.Length];

                s2 = s.Split(" ");
                int i = 0;
                foreach (string s3 in s2)
                {
                    //Console.WriteLine(s3);
                    s2[i] = s3.Trim(totrim);
                    //Console.WriteLine(s2[i]);
                    i++;

                }
                Dictionary<string, int> D = new Dictionary<string, int>();
                for (int j = 0; j < s2.Length; j++)
                {
                    if (!D.ContainsKey(s2[j]))
                    {
                        D.Add(s2[j], 1);
                        //Console.WriteLine(D[s2[j]]);
                    }
                    else
                    {
                        //Console.WriteLine(s2[j]);
                        D[s2[j]] = D[s2[j]] + 1;

                        //Console.WriteLine(D[s2[j]]);
                    }
                }
                foreach (string s3 in banned)
                {
                    D.Remove(s3);
                }
                //Console.WriteLine(D.Values.Max());
                //Console.WriteLine(s2[0]);
                //Console.WriteLine(s2[1]);
                //Console.WriteLine(s2[2]);
                //Console.WriteLine(s2[3]);
                //Console.WriteLine(s2[4]);
                foreach (KeyValuePair<string, int> temp in D)
                {
                    //Console.WriteLine(s2[k]);
                    if (temp.Value == D.Values.Max())
                    {
                        return temp.Key;
                    }
                }
                return "";


            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        Question 3:
        Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.
        Return the largest lucky integer in the array. If there is no lucky integer return -1.
 
        Example 1:
        Input: arr = [2,2,3,4]
        Output: 2
        Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        Example 2:
        Input: arr = [1,2,2,3,3,3]
        Output: 3
        Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
        Example 3:
        Input: arr = [2,2,2,3,3]
        Output: -1
        Explanation: There are no lucky numbers in the array.
         */

        public static int FindLucky(int[] arr)
        {
            try
            {
                //Dictionary<int, int> D = new Dictionary<int, int>();
                var D = new Dictionary<int, int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!D.ContainsKey(arr[i]))
                    {
                        D.Add(arr[i], 1);
                        //Console.WriteLine(arr[i]);
                    }
                    else
                    {
                        D[arr[i]] = D[arr[i]] + 1;
                        //Console.WriteLine(arr[i]+" "+ D[arr[i]]);
                    }


                }
                int[] arr2 = new int[arr.Length];
                int max = -1;
                foreach (var d in D)
                {
                    if (d.Key == d.Value)
                    {

                        if (d.Key > max)
                        {
                            max = d.Key;
                        }

                    }
                }

                return max;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*
        
        Question 4:
        You are playing the Bulls and Cows game with your friend.
        You write down a secret number and ask your friend to guess what the number is. When your friend makes a guess, you provide a hint with the following info:
        •	The number of "bulls", which are digits in the guess that are in the correct position.
        •	The number of "cows", which are digits in the guess that are in your secret number but are located in the wrong position. Specifically, the non-bull digits in the guess that could be rearranged such that they become bulls.
        Given the secret number secret and your friend's guess guess, return the hint for your friend's guess.
        The hint should be formatted as "xAyB", where x is the number of bulls and y is the number of cows. Note that both secret and guess may contain duplicate digits.
 
        Example 1:
        Input: secret = "1807", guess = "7810"
        Output: "1A3B"
        Explanation: Bulls relate to a '|' and cows are underlined:
        "1807"
          |
        "7810"
        */

        public static string GetHint(string secret, string guess)
        {
            try
            {

                char[] secretC = secret.ToCharArray();
                char[] guessC = guess.ToCharArray();

                int bull = 0;
                //for(int i = 0; i < secret.Length; i++)
                //{
                //    if (secretC[i] == guessC[i])
                //    {
                //        bull += 1;
                //        Console.WriteLine(bull);
                //    }
                //}
                int cow = 0;

                for (int i = 0; i < secretC.Length; i++)
                {
                    if (secretC[i] == guessC[i])
                    {
                        bull += 1;
                        Console.WriteLine(bull);
                    }
                    for (int j = 0; j < guessC.Length; j++)
                    {
                        if (secretC[i] == guessC[i])
                        {
                            cow += 1;
                        }
                    }

                }

                return bull + "A" + (cow - bull) + "B";
            }
            catch (Exception)
            {

                throw;
            }
        }


        /*
        Question 5:
        You are given a string s. We want to partition the string into as many parts as possible so that each letter appears in at most one part.
        Return a list of integers representing the size of these parts.
        Example 1:
        Input: s = "ababcbacadefegdehijhklij"
        Output: [9,7,8]
        Explanation:
        The partition is "ababcbaca", "defegde", "hijhklij".
        This is a partition so that each letter appears in at most one part.
        A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.
        */

        public static List<int> PartitionLabels(string s)
        {
            try
            {
                int i = 0;
                int[] arr = new int[10];
                List<int> output = new List<int>();
                while (i < s.Length)
                {
                    arr[0] = 0;
                    int index = s.LastIndexOf(s[i]);
                    //Console.WriteLine(index);
                    List<char> unique = s.Substring(i, Math.Max(1, index - i)).Distinct().ToList();
                    //unique.Remove(s[i]);
                    int max = -1;
                    foreach (char c in unique)
                    {

                        int index2 = s.LastIndexOf(c);
                        if (index2 > max)
                        {
                            max = index2;
                            //Console.WriteLine(c);
                            //Console.WriteLine(max);
                        }
                    }
                    output.Add(max - i + 1);
                    //arr[j] = max+1-arr[j-1];
                    //Console.WriteLine(max-i+1);
                    //j++;
                    i = max + 1;
                }


                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
        Question 6
        You are given a string s of lowercase English letters and an array widths denoting how many pixels wide each lowercase English letter is. Specifically, widths[0] is the width of 'a', widths[1] is the width of 'b', and so on.
        You are trying to write s across several lines, where each line is no longer than 100 pixels. Starting at the beginning of s, write as many letters on the first line such that the total width does not exceed 100 pixels. Then, from where you stopped in s, continue writing as many letters as you can on the second line. Continue this process until you have written all of s.
        Return an array result of length 2 where:
             •	result[0] is the total number of lines.
             •	result[1] is the width of the last line in pixels.
 
        Example 1:
        Input: widths = [10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], s = "abcdefghijklmnopqrstuvwxyz"
        Output: [3,60]
        Explanation: You can write s as follows:
                     abcdefghij  	 // 100 pixels wide
                     klmnopqrst  	 // 100 pixels wide
                     uvwxyz      	 // 60 pixels wide
                     There are a total of 3 lines, and the last line is 60 pixels wide.
         Example 2:
         Input: widths = [4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], 
         s = "bbbcccdddaaa"
         Output: [2,4]
         Explanation: You can write s as follows:
                      bbbcccdddaa  	  // 98 pixels wide
                      a           	 // 4 pixels wide
                      There are a total of 2 lines, and the last line is 4 pixels wide.
         */

        public static List<int> NumberOfLines(int[] widths, string s)
        {
            try
            {
                var D = new Dictionary<char, int>();
                string s2 = "abcdefghijklmnopqrstuvwxyz";
                for (int i = 0; i < widths.Length; i++)
                {
                    D.Add(s2[i], widths[i]);
                }
                int sum = 0, count = 0;
                int j = 0;
                //for(int i=j; i < widths.Length; i++)
                //int[] arr = new int[s.Length];


                while (j < widths.Length)
                {

                    sum = 0;

                    while (sum <= 100 && j < s.Length)
                    {

                        sum += D[s[j]];
                        //Console.WriteLine(j);
                        //Console.WriteLine(sum);
                        j++;

                    }
                    //Console.WriteLine("after while" + j);
                    if (j < s.Length - 1)
                    {
                        j--;
                        //Console.WriteLine("in if" + j);
                    }


                    count++;


                }



                return new List<int>() { count, sum };
            }
            catch (Exception)
            {
                throw;
            }

        }


        /*
        
        Question 7:
        Given a string bulls_string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
            1.	Open brackets must be closed by the same type of brackets.
            2.	Open brackets must be closed in the correct order.
 
        Example 1:
        Input: bulls_string = "()"
        Output: true
        Example 2:
        Input: bulls_string  = "()[]{}"
        Output: true
        Example 3:
        Input: bulls_string  = "(]"
        Output: false
        */

        public static bool IsValid(string bulls_string10)
        {
            try
            {
                bool v = true;
                for (int i = 0; i < bulls_string10.Length; i = i + 2)
                {

                    if (Convert.ToInt32(bulls_string10[i]) == 40 && Convert.ToInt32(bulls_string10[i]) != Convert.ToInt32(bulls_string10[i + 1]) - 1)
                    {

                        v = false;

                    }
                    else if (Convert.ToInt32(bulls_string10[i]) != 40 && Convert.ToInt32(bulls_string10[i]) != Convert.ToInt32(bulls_string10[i + 1]) - 2)
                    {

                        v = false;
                    }
                }

                return v;


            }
            catch (Exception)
            {
                throw;
            }


        }



        /*
         Question 8
        International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:
        •	'a' maps to ".-",
        •	'b' maps to "-...",
        •	'c' maps to "-.-.", and so on.
        For convenience, the full table for the 26 letters of the English alphabet is given below:
        [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.
            •	For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
        Return the number of different transformations among all words we have.
 
        Example 1:
        Input: words = ["gin","zen","gig","msg"]
        Output: 2
        Explanation: The transformation of each word is:
        "gin" -> "--...-."
        "zen" -> "--...-."
        "gig" -> "--...--."
        "msg" -> "--...--."
        There are 2 different transformations: "--...-." and "--...--.".
        */

        public static int UniqueMorseRepresentations(string[] words)
        {
            try
            {
                var D = new Dictionary<char, string>();
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
                for (int i = 0; i < 26; i++)
                {
                    D.Add(Convert.ToChar('a' + i), morse[i]);
                    // Console.WriteLine(Convert.ToChar('a' + i));
                }
                string[] morsecode = new string[words.Length];

                foreach (string word in words)
                {
                    //string[] ch = new string[word.Length];
                    int j = 0;
                    morsecode[j] = "";
                    foreach (char c in word)
                    {
                        //Console.Write(c);
                        //Console.Write(D[c]);
                        morsecode[j] = morsecode[j] + D[c];

                    }
                    //Console.WriteLine(morsecode[j]);
                    j++;

                    //Console.WriteLine();
                }
                List<string> lst = morsecode.Distinct().ToList();

                HashSet<string> h = new HashSet<string>();
                foreach (string m in morsecode)
                {
                    h.Add(m);
                }

                return h.Count;
                //return lst.Count;
            }
            catch (Exception)
            {
                throw;
            }

        }




        /*
        
        Question 9:
        You are given an n x n integer matrix grid where each value grid[i][j] represents the elevation at that point (i, j).
        The rain starts to fall. At time t, the depth of the water everywhere is t. You can swim from a square to another 4-directionally adjacent square if and only if the elevation of both squares individually are at most t. You can swim infinite distances in zero time. Of course, you must stay within the boundaries of the grid during your swim.
        Return the least time until you can reach the bottom right square (n - 1, n - 1) if you start at the top left square (0, 0).
        Example 1:
        Input: grid = [[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]
        Output: 16
        Explanation: The final route is shown.
        We need to wait until time 16 so that (0, 0) and (4, 4) are connected.
        */

        public static int SwimInWater(int[,] grid)
        {
            try
            {
                var n = grid.Length;
                var seen = new HashSet<(int x, int y)>();
                var pQ = new SortedSet<(int value, int x, int y)>();
                pQ.Add((grid[0, 0], 0, 0));
                var ans = 0;
                while (true)
                {
                    var min = pQ.Min;
                    pQ.Remove(min);
                    ans = Math.Max(ans, min.value);
                    if (min.x == n - 1 && min.y == n - 1)
                        return ans;
                    int r = min.x, c = min.y;
                    seen.Add((r, c));
                    if (IsValid(r, c - 1, grid, n, seen)) pQ.Add((grid[r, c - 1], r, c - 1));
                    if (IsValid(r, c + 1, grid, n, seen)) pQ.Add((grid[r, c + 1], r, c + 1));
                    if (IsValid(r - 1, c, grid, n, seen)) pQ.Add((grid[r - 1, c], r - 1, c));
                    if (IsValid(r + 1, c, grid, n, seen)) pQ.Add((grid[r + 1, c], r + 1, c));
                }

                bool IsValid(int r, int c, int[,] grid, int n, HashSet<(int, int)> seen)
                {
                    if (r < 0 || r >= n || c < 0 || c >= n || seen.Contains((r, c))) return false;
                    return true;
                }
                //return -1;
            }



            catch (Exception)
            {

                throw;
            }
        }

        /*
         
        Question 10:
        Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
        You have the following three operations permitted on a word:
        •	Insert a character
        •	Delete a character
        •	Replace a character
         Note: Try to come up with a solution that has polynomial runtime, then try to optimize it to quadratic runtime.
        Example 1:
        Input: word1 = "horse", word2 = "ros"
        Output: 3
        Explanation: 
        horse -> rorse (replace 'h' with 'r')
        rorse -> rose (remove 'r')
        rose -> ros (remove 'e')
        */

        public static int MinDistance(string word1, string word2)
        {
            try
            {
                string s1 = word1;
                string s2 = word2;


                int min(int a, int b, int c)
                {
                    if (a <= b && a <= c)
                        return a;
                    if (b <= a && b <= c)
                        return b;
                    else
                        return c;
                }

                int editDist(String s1, String str2, int m,
                                   int n)
                {

                    if (m == 0)
                        return n;


                    if (n == 0)
                        return m;


                    if (s1[m - 1] == str2[n - 1])
                        return editDist(s1, str2, m - 1, n - 1);


                    return 1
                        + min(editDist(s1, str2, m, n - 1),
                            editDist(s1, str2, m - 1, n),
                            editDist(s1, str2, m - 1,
                                    n - 1)
                        );
                }

                return editDist(s1, s2, s1.Length, s2.Length);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}