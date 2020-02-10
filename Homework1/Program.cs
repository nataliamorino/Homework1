using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            int n4 = 4;
            
            Stones(n4);


        }


        private static void PrintPattern(int n)
        {
            Console.Write("Please enter a number");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 0))
                {
                    for (int row = value_of_input; row >= 1; row--)
                    {
                        for (int column = row; column >= 1; column--)
                        {
                            Console.Write(column + " ");

                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer value greater than 0");
                    Console.WriteLine("Press any key to exit the program and try again");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
        // End of question 1


        private static void PrintSeries(int n2)
        {
            int y = 1, z = 1;
            Console.Write("Please enter a number");
            try
            {

                string input1 = Console.ReadLine();
                int value_of_input1 = int.Parse(input1);
                if ((value_of_input1 > 0))
                {

                    for (int i = 1; i <= value_of_input1; i++)

                    {
                        Console.Write("  {0}  ", y);
                        z = z + 1;
                        y = y + z;


                    }


                    Console.ReadKey(true);
                    Console.WriteLine();

                }


                else
                {
                    Console.WriteLine("Please enter an integer value greater than 0");
                    Console.WriteLine("Press any key to exit the program and try again");
                    Console.ReadKey(true);
                }
                Console.WriteLine();
            }

            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
                Console.WriteLine("Press any key to exit the program and try again");
                Console.ReadKey(true);
            }
        }
        //End of question 2


        public static string UsfTime(string s)
        {

            Console.Write("Please enter a time");

            try
            {
                int hours = 0;
                string timeinput = Console.ReadLine();

                if (timeinput.ToLower().EndsWith("pm"))
                {
                    hours = Convert.ToInt32(timeinput.Substring(0, 2));

                    if (hours != 12)
                    {
                        hours = hours + 12; // 12pm
                    }

                }
                else
                {
                    hours = Int32.Parse(timeinput.Substring(0, 2));
                }
                int minutes = Int32.Parse(timeinput.Substring(3, 2));
                int seconds = Int32.Parse(timeinput.Substring(6, 2));
                int totalSeconds = seconds + (minutes * 60) + (hours * 60 * 60);


                int U = ((totalSeconds / 45) / 60);
                int S = ((totalSeconds / 45) % 60);
                int F = totalSeconds % 45;

                Console.Write(U + ":" + S + ":" + F);
                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;

        }
        // END QUESTION 3

        public static void UsfNumbers(int n3, int k)
        {

            try

            {
                Console.WriteLine("This is exercise 4");
                string[] NArray = new string[n3];
                for (int i = 1; i <= n3; i++)
                {
                    if (i % 3 == 0)
                    {
                        if (i % 5 == 0)
                        {
                            if (i % 7 == 0)
                            {
                                NArray[i - 1] = "USF";
                            }

                            else
                            {
                                NArray[i - 1] = "US";
                            }
                        }
                        else
                        {
                            NArray[i - 1] = "U";
                        }
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                            if (i % 7 == 0)
                            {
                                NArray[i - 1] = "SF";

                            }
                            else
                            {
                                NArray[i - 1] = "S";

                            }
                        }
                        else
                        {
                            if (i % 7 == 0)
                            {
                                if (i % 3 == 0)
                                {
                                    NArray[i - 1] = "UF";

                                }
                                else
                                {
                                    NArray[i - 1] = "F";
                                }
                            }
                            else
                            {
                                NArray[i - 1] = Convert.ToString(i);
                            }
                        }

                    }


                }
                for (int n = 0; n < n3; n++)
                {
                    if (n % k == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(NArray[n] + " ");
                }
                Console.WriteLine();
                Console.ReadKey(true);

            }
            catch
            {

                Console.WriteLine("Exception occured while computing UsfNumbers()");
                Console.ReadKey(true);
            }



        }
        // end of question 4

        public static void PalindromePairs(string[] words)
        {
            try
            {
                Console.WriteLine("The List is: abcd, dcba, lls, s, sssll. Let's find what words can form a palindrome ");
                string output = "Output:";
                bool pal = false;
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (i == j)
                        {

                            continue;
                        }
                        string union = Convert.ToString(words[i] + words[j]);
                        for (int k = 0; k <= union.Length / 2; k++)
                        {
                            if (union[k] == union[union.Length - 1 - k])
                            {
                                pal = true;
                            }
                            else
                            {
                                pal = false;
                                break;
                            }
                        }
                        if (pal == true)
                        {
                            output += ("[" + i + "," + j + "]");
                        }

                    }
                }

                Console.Write(output);
                Console.WriteLine("The palindromes are [dcbaabcd, abcddcba,slls,llssssll]");
                Console.WriteLine();
                Console.ReadKey();


            }


            catch
            {

                Console.WriteLine("Exception occured while computing PalindromePairs()");
                Console.ReadKey(true);
            }
        }
        //end of question 5 
        public static void Stones (int n4)
        {
            List<string> stonesoutput = new List<string>();
            string output = "";

            Console.Write("Let's play the stone game. Please enter a number");
            try
            {
                string input2 = Console.ReadLine();
                int value_of_input2 = int.Parse(input2);
                n4 = value_of_input2;

                if ((n4 % 4 == 0)) // if divisible by 4 no possibilities to win 
                {
                    Console.WriteLine("You lost");
                    Console.ReadKey(true);
                }

                else
                    for (int i = 0; i <= n4; i++) //move 1 
                    {
                        for (int j = 0; j <= n4 / 2; j++) // move 2
                        {
                            for (int k = 0; k <= n4 / 3; k++) // move 3 
                            {

                                int total = 0; // set the count = 0 
                                if (i + 2 * j + 3 * k == n4 && (i + j + k) % 2 != 0)
                                {
                                    int[] array = new int[i + j + k]; // this array stores all different possibilities 
                                    for (int l = 1; l <= i; l++)
                                    {
                                        array[total] = 1;
                                        total++;
                                    }
                                    for (int l = 1; l <= j; l++)
                                    {
                                        array[total] = 2;
                                        total++;
                                    }
                                    for (int l = 1; l <= k; l++)
                                    {
                                        array[total] = 3;
                                        total++;
                                    }
                                    for (int n = 0; n < array.Length; n++)
                                    {
                                        for (int m = 0; m < array.Length; m++)
                                        {
                                            int possible = array[n];
                                            array[n] = array[m];
                                            array[m] = possible;
                                            string outcome = "";
                                            for (int a = 0; a < array.Length; a++)
                                                {
                                                outcome += Convert.ToString(array[a]) + ",";
                                            }
                                            stonesoutput.Add(outcome.Remove(outcome.Length - 1));
                                        }

                                    }
                                }
                            }
                        }
                    }
                IEnumerable<string> last = stonesoutput.Distinct();
                foreach (string el in last)
                {
                    output += "{" + el + "}";
                }
                Console.WriteLine("You win");
                Console.WriteLine("These are your possibilities");
                Console.Write(output.Remove(output.Length - 4));
                Console.ReadKey(true);


            }

              
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
                Console.ReadKey(true);
            }
        }
            
            
    }
}


    



    

