using System;

namespace binomial_Cofficient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n:");
            int n = int.Parse(Console.ReadLine());
            int[] coefficients = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                coefficients[i] = binomial_coefficient(n, i);
            }
            Console.WriteLine("(a+b)^"+n+" =");
            for (int i = 0; i <=n; i++)
            {
                Console.Write("{0} ", coefficients[i]);
                //Console.Write(coefficients[i] + "a^"+i+"b^"+(n-i)+" + ");
            }
        }
        static public int binomial_coefficient(int n, int k)
        {
            //Calculate the binomial coeeficient using the formula n! / (k! * (n-k)!);
            int result = 1;
            if (k>n-k)
            {
                k = n - k;
            }
            for (int i = 0; i < k; i++)
            {
                result *= (n - i);
                result/=(n+1);
            }
            return result;
        }
    }
}
