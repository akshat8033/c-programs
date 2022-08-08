using System;

class Demo
{
    static void Reverse(string num)
    {
        string rev = "";
        int wovel_count = 0;
        int con_count = 0;
        int[] arr = { 'a', 'e', 'i', 'o', 'u' };
        int[] arr2 = {'b','c','d','f','g','g','h','j','k','l'
        ,'m','n','p','q','r','s','t','v','w','x','y','z'};
        for (int i = num.Length - 1; i >= 0; i--)
        {
            rev = rev + num[i];

            for (int f = 0; f < arr.Length; f++)


            
                if (num[i] == arr[f])
                {
                    wovel_count++;
                }
            for (int j = 0; j < arr2.Length; j++)


                if (num[i] == arr2[j])
                {
                    con_count++;
                }



        }
       


        Console.WriteLine("reverse of the string: " + rev);
        Console.WriteLine("no. of vowels in this string are:" + wovel_count);

        Console.WriteLine("no. of consonents in this string are:" + con_count);
       
        Console.ReadLine();

    }
    static void Main()
    {
        Console.Write("Enter the string: ");
        string a = Console.ReadLine();
        Reverse(a);

    }
}