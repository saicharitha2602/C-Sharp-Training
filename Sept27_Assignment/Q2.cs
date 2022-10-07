using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept27_Assignment
{
    internal class Q2
    {
        public static void Main(string[] args)
        {
            File.Copy("C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Documents\\Q2\\file1.txt", "C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Documents\\Q2\\file2.txt");

            // Display file2 contents
            Console.WriteLine(File.ReadAllText("file2.txt"));
        }
    }
}
