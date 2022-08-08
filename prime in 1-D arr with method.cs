using System;
class Demo
{
    Demo()
    {
        Console.WriteLine("constructor");
    }
    static void Main()
    {
        Demo d = new Demo();
        Console.ReadLine();
    }
}