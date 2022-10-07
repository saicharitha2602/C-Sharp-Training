namespace DelegatesExample
{
    public delegate void cal(int a);
    internal class Program
    {
        public static void factorial(int num)
        {
            int res = 1;
            for(int i=num;i>1;i--)
            {
                res *= i;
            }
            Console.WriteLine("Factorial of number is " + res);
        }
        public static void table(int num)
        {
            Console.WriteLine("Printing Multiplication Table");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(num + "*" + i + "=" + (num * i));
            }
        }
        public  void fibonacci(int num)
        {
            int t1 = 0, t2 = 1;
            int nextTerm = t1 + t2;
            Console.Write(t1 + " " + t2+" ");
            for (int i = 3; i <= num; ++i)
            {
                Console.Write(nextTerm+" ");
                t1 = t2;
                t2 = nextTerm;
                nextTerm = t1 + t2;
            }
            Console.WriteLine();
        }
        public void factors(int num)
        {
            Console.WriteLine("The factors of " + num + " are:");
            Console.Write("1"+" ");
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            
            cal obj = new cal(Program.factorial);
            Console.WriteLine("Enter a number to calculate factorail");
            int num1 = Convert.ToInt32(Console.ReadLine());
            obj.Invoke(num1);

            Console.WriteLine("Enter a number to display multiplication table");
            int num2 = Convert.ToInt32(Console.ReadLine());
            obj = table;
            obj.Invoke(num2);

            Console.WriteLine("Enter a number to display fibonacci series");
            int num3=Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            // cal c = new cal(p.fibonacci);
            obj = p.fibonacci;
            obj.Invoke(8);


            Console.WriteLine("Enter a number to display all factors of a given number");
            int num4 = Convert.ToInt32(Console.ReadLine());
            cal c = new cal(p.factors);
            c = p.factors;
            c.Invoke(num4);
        }
    }
}