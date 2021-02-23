using System;

namespace Honwork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int passWord ;
            String institution;
            Console.Write("Enter your Password :");
            passWord = int.Parse(Console.ReadLine());
            Console.Write("Enter your Institution :");
            institution = Console.ReadLine();
            
            if (institution == "CIA")
            {
                bool check1 = (passWord - 3) % 10 == 0 || (passWord - 6) % 10 == 0 || (passWord - 9) % 10 == 0;
                bool check2 = check1 && ((passWord / 10) - 1) % 10 != 0 && ((passWord / 10) - 3) % 10 != 0 && ((passWord / 10) - 5) % 10 != 0;
                bool check3 = check1 && check2 && (passWord / 1000) % 10 == 6 || (passWord / 1000) % 10 != 8;
                Console.WriteLine("" + check3);
            }
            else if (institution == "FBI")
            {
                bool check1 = (passWord / 100000)  % 10 == 4 || (passWord / 100000) % 10 == 5 || (passWord / 100000) % 10 == 6 || (passWord / 100000) % 10 == 7;
                bool check2 = ((passWord % 100) - 2) / 10 == 0 || ((passWord % 100) - 4) / 10 == 0 || ((passWord % 100) - 8) / 10 == 0 && ((passWord % 100) - 6) / 10 != 0;
                bool check3 =   (passWord / 10000) % 2 == 1  ;
                Console.WriteLine("" + check3);    
            }
            else if (institution == "NSA")
            {
                bool check1 = passWord % 10 == 3 || passWord % 10 == 2 || passWord % 10 == 5;
                bool check2 = check1 && ((passWord / 100) - 3) % 10 == 0 || ((passWord / 100) - 6) % 10 == 1 || ((passWord / 100) - 9) % 10 == 0;
                bool check3 = check1 && check2 &&(passWord - 7) % 10 == 0 || ((passWord / 10) -7 ) % 10  == 0 || ((passWord / 100) - 7) % 10 == 0 || ((passWord / 1000) - 7) % 10 == 0|| ((passWord / 10000) - 7) % 10 == 0 || ((passWord / 100000) - 7) % 10 == 0;

                Console.WriteLine(""+check3);
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
