using System;

namespace LeapYear
{
    public class Program_Leap
    {
            public static void Main(string[] args)
        {
            String year = Console.ReadLine();
            int actualYear = Int32.Parse(year);
            if(isLeapYear(actualYear) == true){
                Console.WriteLine("yay");
            }else{
                Console.WriteLine("nay");
            }
        }

        public static bool isLeapYear(int year){
            if(year%4 == 0){
                return true;
            }else{
                return false;
            }
        }
    }
}
