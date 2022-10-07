namespace LambdaExpression
{
    internal class Program
    {
        /*public delegate void sum(int num);
        

        static void Main(string[] args)
        {
            sum obj = (num) =>
            {
                int result = 0;
                for(int i=1;i<=num;i++)
                {
                    result+= i;
                }
                Console.WriteLine("Sum of "+ num +" natural numbers is : "+result);
            };
            Console.WriteLine("Enter a number to find sum of n natural numbers");
            int num = int.Parse(Console.ReadLine());
            obj.Invoke(num);

        }*/
        /*public delegate int greater(int a, int b);
        static void Main(string[] args)
        {
            greater obj = (a, b) => a > b ? a : b;
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Greater of 2 numbers is: "+obj.Invoke(num1,num2));
        }*/

        /*public delegate void swap(ref a, ref b);
        static void Main(string[] args)
        {
            swap obj=(a,b)=> b = (a + b) - (a = b);
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("After swapping");
            obj.Invoke(num1,num2);
            Console.WriteLine(num1 + " " + num2);

        }
        */
        /*public delegate void count_prime(int num);
        static void Main(string[] args)
        {
            count_prime obj = delegate (int num)
            {
                int flag = 0;
                int m = num / 2;
                for(int i = 2; i<=m; i++)
                {
                    if(num%i==0)
                    {
                        Console.WriteLine("Not a prime number");
                         flag = 1;
                        break;
                    }
                }
                if(flag==0)
                {
                    Console.WriteLine("Prime number");
                }
            };
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            obj.Invoke(num);
        }*/

    }
}