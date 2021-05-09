using System;

namespace wh
{
    class Program
  {
    static void Main(string[] args)
    {
            //counts from 1 to the input number

            Console.WriteLine("input number");
            int n = Int32.Parse(Console.ReadLine());
            int counter = 1;
           
            
            while (n >= counter)
            { 
                Console.WriteLine($"{counter}");
                counter++;
            }
            if (counter > n)
            {
                Console.ReadLine();
            }

            //counts down from the input number to 1

            Console.WriteLine("input number");
            int a = Int32.Parse(Console.ReadLine());
            int counter2 = 1;

        while (a >= counter2)
            {
                a--;
                Console.WriteLine($"{a}");
                
            }
        if (a == 0)
            {
                Console.ReadLine();
            }

             //prints alphabet
           
            int i = 0;

                while (i < 26)
            
            {
                Console.WriteLine(Convert.ToChar(i + (int)'A'));
                i++;
            }
            Console.ReadLine();

            //trying the same thing but another way

            char i2 = 'A';
            
            while (i2 <= 'Z')
            {
                Console.WriteLine("{0}", i2);
                i2++;
            }

            Console.ReadLine();

            //prints all even numbers up to 100

            int c = 2;

            while (c <= 100)
            {
                Console.WriteLine($"{c}");
                c++;
                c++;
            }
            if (c > 100)
            {
                Console.ReadLine();
            }

            //prints all odd numbers to 100

            int d = 1;

                while (d <= 100)
            {
                Console.WriteLine($"{d}");
                d++;
                d++;
            }
            if (d > 100)
            {
                Console.ReadLine();
            }

            //prints the sum of all whole numbers 1 to input number

            Console.WriteLine("input number");
            int e = Int32.Parse(Console.ReadLine());                 
            int e2 = 0;

            while (e >= 1)
            {
                e2 = e2 + e;
                e--; 
            }

            if (e == 0)
            {
                Console.WriteLine($"{e2}");
            }

            //prints the sum of all whole numbers 1 to input number

            Console.WriteLine("input number");
            int f = Int32.Parse(Console.ReadLine());
            int counter4 = 1;
            int answer = 0;

            while (counter4 <= f)
            {
                answer = (counter4 * f);
                Console.WriteLine($"{answer}");
                counter4++;
            }
            


          





        }
    }
}
