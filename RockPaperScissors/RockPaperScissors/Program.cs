using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 1;
            int r = 2;
            int p = 3;
            int mynum;
            Write("enter r, p, or s ");
            string mystr = ReadLine();
            if(mystr =="r")
            {
                mynum = 2;
            }
            else if (mystr == "s")
            {
                mynum = 1;
            }
            else
            {
                mynum = 3;
            }
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1 , 3);
            if (mynum == randomNumber)
            {
                WriteLine("We have a tie");
            }
            else if (mynum == 1 && randomNumber == 3)
            {
                WriteLine("Sissor beats Paper you win");
            }
            else
            {
                WriteLine("Rock crushes Sissor I win");
            }
            if (mynum == 2 && randomNumber == 1)
            {
                WriteLine("Rock crushes Sissor You win");
            }
            else if (mynum == 2 && randomNumber == 3)
            {
                WriteLine("Paper covers rock I Win");
            }
            if (mynum == 3 && randomNumber == 2)
            {
                WriteLine("Paper covers rock You win");
            }
            else if (mynum == 3 && randomNumber == 1)
            {
                WriteLine("Sissor cuts Paper I win");
            }
        }
    }
}
