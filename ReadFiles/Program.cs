namespace ReadFiles
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string file1 = @"C:\Users\Charitha.Neelisetty\OneDrive - Entain Group\Desktop\file1.txt";
            Console.WriteLine(File.ReadAllText(file1));
            string file2 = @"C:\Users\Charitha.Neelisetty\OneDrive - Entain Group\Desktop\file2.txt";
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine(File.ReadAllText(file2));
            });
        }
    }
}