using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Next line start a new line
            Console.WriteLine("Hello World");

       //1. Get user input
            //Next line at the same line
            Console.Write("What is your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

       //2. Data Type
            bool canVote = true;
            char grade = 'A';
            int maxInt = int.MaxValue;
            long maxLong = long.MaxValue;
            decimal maxDec = decimal.MaxValue;
            //int<long<decimal<BigInteger

            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;
            Console.WriteLine("Max Int: " + maxInt);

            var anotherName = "Tom";
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());

            //{0}, {1}...: format different piece of data.
            Console.WriteLine("This {0}.  The value is {1}.", "is a test", 42);

            //3. Calculation
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 -3 = " + (5 - 3));

            //4. Casting
            //put any type you want to cast into the bracket
            double pi = 3.14;
            int intPi = (int)pi;

            //5. Math Function
            double number1 = 10.5;
            double number2 = 15;
            Console.WriteLine("Math.Ceiling(number1)" + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1)" + (Math.Floor(number1)));

            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10" + (rand.Next(1, 11)));

            //6. Conditional
            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else {
                Console.WriteLine("Go to high school");
            }

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                    Console.WriteLine("Baby");
                    break;
                case 2:
                    Console.WriteLine("Toddler");
                    goto case 1;
                //The goto statement transfers the program control directly to a labeled statement.

                default:
                    Console.WriteLine("Child");
                    break;
            }

            //7. Looping
                //7.1 While
            int i = 0;

            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                    //continue will just skip the current iteration
                }

                if (i == 9)
                {
                    break;
                    //break will exit the loop completely
                }

                if ((i % 2) > 0) //odd number
                {
                    Console.WriteLine(i);
                }

                i++;
            }
                //7.2 do 
            string guess;
            do
            {
                Console.WriteLine("Guess a Number");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));

            //7.3 For
            for (int a = 0; a < 10; a++)
            {
                if ((a % 2) > 0) {
                    Console.WriteLine(a);
                }
            }

            //8. Array
            int[] randArray = new int[5];
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array Length " + randArray2.Length);
            Console.WriteLine("Item 0 " + randArray2[0]);

            for (int i2 = 0; i2 < randArray2.Length; i2++)
            {
                Console.WriteLine("{0}:{1}", i2, randArray2[i2]);
            }

            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            //Find the index of the element in the array
            Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));
            //IndexOf(ArrayName, specific thing you are searching for)

            string[] names = { "Tom", "Paul", "Sally" };

            //Join a name into the string
            string nameStr = string.Join(",", names);
                                    //Join(What we want between each string, the actually array we gonna working with)
            Console.WriteLine("nameStr " + nameStr);

            //Multi-demensional Array
            //Declare two demensional array
            int[,] multArray = new int[5, 3];

            //Decalre and set array elements
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach (int num in multArray2) {
                Console.WriteLine(num);
            }

            for (int x = 0; x < multArray2.GetLength(0); x++)
                //get the first part(3) of the array
            {
                //get the second part(2) of the array
                for (int y = 0; y < multArray2.GetLength(1); y++) {
                    Console.WriteLine("{0} | {1}:{2}", x, y, multArray2[x, y]);
                }
            }

            //9.List: When you add in the element, list will automatically resize itself
            List<int> numList = new List<int>();

            //9.1 Throw in the element as you want. No need to worry about the size
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            //9.2 Add array into list
            int[] randArray3 = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray3);

            //9.3 Clear list
            numList.Clear();

            //9.4 Copy an array into list
            List<int> numList2 = new List<int>(randArray3);

            //9.5 Create a list with array
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            //9.6 Insert an item into a specific index (index, item)
            numList2.Insert(1, 10);

            //9.6 Remove an item specific to its name(item)
            numList2.Remove(5);

            //9.7 Remove by index
            numList2.RemoveAt(2);

            for (int i3 = 0; i3 < numList2.Count; i3++)
                //use "Count" to get the length of the list
            {
                Console.WriteLine(numList2[i3]);
            }

            Console.WriteLine("4 is in index " + numList3.IndexOf(4));

            //9.8 Search value in the string list
            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });
            Console.WriteLine("Tom in list " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            //9.9 Sort the list
            strList.Sort();

            //10. Exception Handling: When we want to keep errors from going out to the user
            try
            {
                Console.Write("Divide 10 by ");

                //Convert interger into string
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("10/{0}={1}", num, (10 / num));
            }

            //catch an error (define ex so we can get more info)
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divided by zere");
                Console.WriteLine(ex.GetType().Name);//Get the name of the exception that was triggered
                Console.WriteLine(ex.Message);//Describe the exception
                throw ex;//throw the exception to another catch block that be able to handle
                throw new InvalidOperationException("Operation Failed", ex);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
