namespace SwapFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string path = "C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Desktop\\FolderFirst";
            Directory.CreateDirectory(path);
            FileStream fs = new FileStream(path + "\\file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw=new StreamWriter(fs);
            sw.WriteLine("Hello Everyone,\n This is File1 Contents");
            sw.Close();
            fs.Close();
            path= "C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Desktop\\FolderSecond";
            Directory.CreateDirectory(path);
            fs = new FileStream(path + "\\file2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(fs);
            sw.WriteLine("Hello Everyone,\n This is File2 Contents");
            sw.Close();
            fs.Close();
            File.Move("C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Desktop\\FolderFirst\\file1.txt", "C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Desktop\\FolderSecond\\file1.txt");
            File.Delete("C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Desktop\\FolderFirst\\file1.txt");
            File.Move("C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Desktop\\FolderSecond\\file2.txt", "C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Desktop\\FolderFirst\\file2.txt");
            File.Delete("C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Desktop\\FolderSecond\\file2.txt");

        }
    }
}