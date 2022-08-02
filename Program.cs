class program
{
    static void Main()
    {
        char[] arr = { 'A', 'b', 'C', '1','$','M','2','v' };
        int count = 0;
        int coun = 0;
        int cou = 0;
        foreach (char x in arr)
        {if (65 <= x && x <= 90)
            { 
                count++;   
            }
             if (97 <= x && x <= 122)
            {
                coun++;
            } 
             if (48 <= x && x <= 57)
            { 
                cou++;
            }
            
           

        }
        System.Console.WriteLine(count + " are capital.");
        System.Console.WriteLine(coun + " are small.");
        System.Console.WriteLine(cou + " are numeric.");
        System.Console.ReadLine();
    }
}