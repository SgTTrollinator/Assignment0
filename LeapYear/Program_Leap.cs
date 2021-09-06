using System;

namespace LeapYear
{
    public class Program_Leap
    {
            public static void Main(string[] args)
        {
            Console.WriteLine("Insert year: ");
            String year = Console.ReadLine();
            Console.WriteLine(readInput(year));
        }

        public static bool isLeapYear(int year){
            if(year%4 == 0 && year % 100 != 0 || year % 400 == 0){
                return true;
            }else{
                return false;
            }
        }

        public static string readInput(string year){
            int actualYear = Int32.Parse(year);
            if(isLeapYear(actualYear) == true){
                return "yay";
            }else{
                return "nay";
            }
        }
    }
}
