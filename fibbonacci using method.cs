using System;

class Demo
{
    void Fibo(int num)
    {
        int n1 = 0, n2 = 1, n3;

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        for (int i = 2; i < num; i++)
        {
            n3 = n2 + n1;
            Console.WriteLine(n3);
            n1 = n2;
            n2 = n3;
}
           

        



    }
    static void Main()
    {

        Console.WriteLine("enter the total digits: ");
        int a = int.Parse(Console.ReadLine());
        
        Demo d = new Demo();
        d.Fibo(a);
        
    }
}