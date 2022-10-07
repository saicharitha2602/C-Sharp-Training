
namespace Day7
{
    public struct EmployeeRecord
    {
        public string EmployeeName, DateOfJoining;
        public int salary;
        public EmployeeRecord(string name, int sal,string date)
        {
            EmployeeName =name;
            DateOfJoining = date;
            salary = sal;

        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Name: "+ EmployeeName);
            Console.WriteLine( "Date of Joining: "+ DateOfJoining);
            Console.WriteLine("Salary: "+salary);
        }
    }
    public class Demo
    {
        public static void Main()
        {


            EmployeeRecord emp = new EmployeeRecord("Charitha", 30000, "04-07-2022");
            emp.ShowEmployeeDetails();
        }
    }
}
