using System;

namespace ReviewPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)    
            {
                Console.WriteLine("Select options:\n1.Flip Coins Program \n2.Leap Year \n3.Power Of 2 \n4.Reverse Number \n5.Harmonic No \n6.even or odd");

                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)   
                {
                    case 1:
                        PracticePblms.flipCoin();
                        break;
                    case 2:
                        PracticePblms.leapYear();
                        break;
                    case 3:
                        PracticePblms.powerOfTwo();
                        break;
                    case 4:
                        PracticePblms.reverseNumber();
                        break;
                    case 5:
                        PracticePblms.harmonicNumber();
                        break;
                    case 6:
                        PracticePblms.evenOdd();
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }

        }
        public class PracticePblms
        {
            public static void flipCoin()
            {
                Console.WriteLine("How many time to flip coin...?");
                int n = Convert.ToInt32(Console.ReadLine()); // eg. n = 10
                int headPer;
                int headCnt = 0, tailCnt = 0;

                for (int i = 1; i <= n; i++) // loops execute 10 times
                {
                    Random random = new Random();
                    double coin = random.NextDouble(); // randomly in between 0 - 1.0

                    if (coin < 0.5)
                    {
                        Console.WriteLine("Tails");
                        tailCnt++;
                    }
                    else
                    {
                        Console.WriteLine("Heads");
                        headCnt++;
                    }
                }
                Console.WriteLine();
                headPer = headCnt * 100 / n;
                Console.WriteLine("Head Percent: " + headPer);
                Console.WriteLine("Tail Percent: " + (100 - headPer));
            }

            public static void leapYear()
            {
                Console.WriteLine("Enter the year leap or not :");
                string str = Console.ReadLine(); //take i/p from user in string str
                int length = str.Length;

                if (length != 4)
                {
                    Console.WriteLine("You must enter the 4 digit number: ");
                }
                else
                {
                    int Year = Convert.ToInt32(str);

                    if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                    {
                        Console.WriteLine("{0} is leap year.", +Year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not leap year.", +Year);
                    }


                }
            }

            public static void powerOfTwo()
            {
                int num = 2;
                int power = 1;
                int i = 1;
                Console.WriteLine("Enter the Power: ");
                int p = Convert.ToInt32(Console.ReadLine());

                if (p >= 0 && p < 31)
                {
                    for (i = 1; i <= p; i++)
                    {
                        power = power * num;  //1*2 = 2 , 2*2 =4 , , 4*2 =8
                        Console.WriteLine(power); //it will print power whatever no user enter
                    }
                }
                else
                {
                    Console.WriteLine("Please enter power between 0-31");
                }
            }

            public static void reverseNumber()
            {
                int reverse = 0, rem;
                Console.WriteLine("Enter a number to be  reversed: ");
                int n = Convert.ToInt32(Console.ReadLine()); // n= 123

                while (n != 0) //it will check conditions  e.g 123!=0 
                { 
                    rem = n % 10; // 123 % 10 = 3 , 
                    reverse = reverse * 10 + rem;  // 0* 10 + 3
                    n = n / 10; // 123 / 10 = 12
                }
                Console.WriteLine("Reversed Number is: " + reverse);
            }

            public static void harmonicNumber()
            {
                Console.WriteLine("Which Harmonic Number you wants: ");
                int n = Convert.ToInt32(Console.ReadLine()); // eg. 3rd no , n = 3

                int i = 1;
                decimal harmonicNo = 0;

                for (i = 1; i <= n; i++)
                {
                    harmonicNo = harmonicNo + (1 / (decimal)i); // 1 + 1/2 + 1/3
                }

                Console.WriteLine("Harmonic Number is " + harmonicNo);
            }

            public static void evenOdd()
            {
                Console.WriteLine("Enter a Number to check even or odd: ");
                int num = Convert.ToInt32(Console.ReadLine()); // num = 4

                if (num % 2 == 0)    // 4 % 2 = 0  condition true
                {
                    Console.WriteLine($"{num} is even.");//no will be print
                }
                else
                {
                    Console.WriteLine($"{num} is odd.");
                }
            }

        }
    }
}