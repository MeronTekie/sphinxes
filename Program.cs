using System;
using System.Collections.Generic;


public class Sphinx
{
    static void Main()
    {
        Console.WriteLine("What can bring back the dead; make you cry, make you laugh, make you young; is born in an instant, yet lasts a lifetime");
        string answer = Console.ReadLine();
        answer.ToUpper();

        if(answer =="MEMORY")
        {
            Console.WriteLine(" Never resting, never still; moving silently from hill to hill; it does not walk, run or trot; all is cool where it is not");
            string answer1 = Console.ReadLine();
            answer1.ToUpper();

            if (answer1 == "SUN") 
            {
                Console.WriteLine("What can bring back the dead; make you cry, make you laugh, make you young; is born in an instant, yet lasts a lifetime");
                string answer2 = Console.ReadLine();
                answer2.ToUpper();

            }
            else
            {
                Console.WriteLine("You answered one hopefully you will do beter next time");
            }
        }
        else
        {
            Console.WriteLine("You answered none hopefully you will do beter next time");
        }
    }
}


