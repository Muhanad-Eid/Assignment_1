using System;
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(@"welcome to K3K stores
Enter Bill Amount then press Enter");//@ allow multiline string no need for \n
            double billAmount=Convert.ToDouble(Console.ReadLine());
            double finalAmount;
            int discount=0;//d
            //Method 1: if else
            if (billAmount < 0)//validation
            {
                Console.WriteLine("Invalid Bill Amount");
                return;//this will stop the program so it dont print last Line 
            }
            if (billAmount >= 500)
            {
                discount = 20;
                finalAmount = billAmount * 0.8;//20% 
            }
            else if (billAmount >= 300)//no need for (billAmount < 500) because if the bill more than 500 it will not come to third condition
            {
                discount = 10;
                finalAmount = billAmount * 0.9;//10%
            }
            else //no need for (billAmount < 300) because if the bill more than 300 it will not come to fourth condition
            {
                discount = 0;
                finalAmount = billAmount;//0%
            }

            //Method 2: nested short hand if (ternary operator)
            //finalAmount = (billAmount >= 500) ? billAmount * 0.8: (billAmount < 500 && billAmount >= 300) ? billAmount*0.9 : billAmount;

            Console.WriteLine("Your Final Bill after {0}% discount is {1}",discount,finalAmount);//string format

        }
    }
}
