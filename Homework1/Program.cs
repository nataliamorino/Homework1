using System;

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
                    Console.WriteLine( "Press any key to exit the program and try again");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine( "Exception Occured while computing printPattern");
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
                           
                        
                        Console.ReadKey();
                    
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
                Console.WriteLine("Exception Occured while computing printSeries");
                Console.WriteLine("Press any key to exit the program and try again");
                Console.ReadKey(true);
            }
        }
        //End of question 2


        public static string UsfTime(string s)
        {
            try
            {
                //Write your code here .!!
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                // Write your code here
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
