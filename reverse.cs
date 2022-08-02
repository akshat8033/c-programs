class Demo
{
    static void Main()
    {
        System.Console.Write("enter a three digit no");
        int n = int.Parse(System.Console.ReadLine());
        int reverse = 0;
        int remainder;
        while (n != 0)
        {
            remainder = n % 10;
            reverse = (reverse * 10) + remainder;
            n = n / 10;

        }
        System.Console.WriteLine(reverse);
    }
}