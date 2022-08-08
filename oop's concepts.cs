using System;
class Program
{
    private int empNo;
    public int EmpNo
    {
        set
        {
            empNo = value;
        }
        get
        {
            return empNo;
        }
    }
           private string empName;
    public string EmpName
    {
        set
        {
            empName = value;
        }
        get
        {
            return empName;
        }
    }
           private double empSal;
    public double EmpSal
    {
        set
        {
            empSal = value;
        }
        get
        {
            return empSal;
        }

    }
}
class chetu
{
    static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Enter the employee no : ");
        int a = Convert.ToInt32(Console.ReadLine());
        program.EmpNo = a;
          Console.WriteLine("Enter the employee name is : ");
       string b =  Console.ReadLine();
        program.EmpName = b;
        Console.WriteLine("Enter the employee salary is : ");
        double c = Convert.ToDouble(Console.ReadLine());
        program.EmpSal = c;
        Console.WriteLine("employee no. is:" + program.EmpNo);
        Console.WriteLine("employee name is : " + program.EmpName);
        Console.WriteLine("employee salary is : " + program.EmpSal);
        Console.ReadLine();

    }
}

