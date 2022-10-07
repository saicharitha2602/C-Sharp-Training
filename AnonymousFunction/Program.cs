namespace AnonymousFunction
{
    public delegate void si(int p,int t,int r);
    internal class Program
    {
        static void Main(string[] args)
        {
            si obj = delegate (int p,int t,int r)
            {
                int si = (p * t * r) / 100;
                Console.WriteLine("Simple Interest="+si);
                
                

            };
            Console.WriteLine("Enter principle amount");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of years");
            int t=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            int r=int.Parse(Console.ReadLine());

           obj.Invoke(p,t,r); ;
        }
    }
}