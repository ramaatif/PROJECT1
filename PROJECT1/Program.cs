using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT1
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i =0;i<1000;i++)
            {
                Console.WriteLine("Select Your Operation");
                Console.WriteLine("For Summation Press Number 1");
                Console.WriteLine("For Multiplication Press Number 2");
                Console.WriteLine("For Subtructing Press Number 3");
                Console.WriteLine("For Division Press Number 4");
                int SelectedOperation = Convert.ToInt32(Console.ReadLine());

                if(SelectedOperation!=1&&SelectedOperation!=2&&SelectedOperation!=3&&SelectedOperation!=4)

                { Console.WriteLine("You Entered Wrong Number"); Console.ReadKey();return; }

                Console.WriteLine("Enter Your First Number");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Your Second Number");
                int number2 = Convert.ToInt32(Console.ReadLine());


                int Result = 0;
                if(SelectedOperation==1)
                {
                     Result = number + number2;
                    Console.WriteLine($"The Result : {Result}"+ "\n---------------------");
                }

                else if(SelectedOperation==2)
                {
                     Result = number - number2;
                    Console.WriteLine($"The Result : {Result}" + "\n-------------------");
                }
                
                else if(SelectedOperation==3)
                {
                     Result = number * number2;
                    Console.WriteLine($"The Result : {Result}" + "\n--------------------");
                }

                else if(SelectedOperation==4)
                {
                     Result =  number2 / number;

                    Console.WriteLine($"The Result : {Result}" +"\n----------------------");

                }

                Console.WriteLine("Are You Want To Countinue ? Yes Or No");
                string UserOption = Console.ReadLine();

                if(UserOption == "no" && UserOption == "No")
                {
                    break;

                }





            }

            Console.WriteLine("Thank U ;*)");



            Console.ReadKey();
        }
       
    }
}
