namespace GenericExample
{
    internal class GenericClass
    {
        public void GenericMethod<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class TestGeneric
    { 
        static void Main(string[] args)
        {

            GenericClass obj1 = new GenericClass();
            obj1.GenericMethod("From a string");

        }
    }
}