class Day4
{
    public static void Main(string[] args)
    {
        string username = "admin";
        string password = "admin";
        for(int i=0;i<3;i++)
        {
            Console.Write("Enter Username:");
            string user=Console.ReadLine();
            Console.Write("Enter Password:");
            string pass=Console.ReadLine();
            if(username==user && password==pass)
            {
                Console.WriteLine("Successful login");
                break;
            }
            else if(i<2)
            {
                Console.WriteLine("You have only {0} chances left", 3 - i - 1);
            }
            
        }
    }
}