class program
{
    static void Main(string[] args)
    {
        System.Console.Write("enter the base size:");
        int n=System.Convert.ToInt32(System.Console.ReadLine());
        int[][] arr=new int[n][];

        for (int k = 0; k < arr.Length; k++)
        {
            System.Console.Write("enter the subarray size:");
            int a = int.Parse(System.Console.ReadLine());
            arr[k] = new int[a];
        } 
        
        
        for (int i = 0; i <arr.Length; i++)
        {
            for (int j = 0; j <arr[i].Length; j++)
            {
                System.Console.Write("enter the value:");
                arr[i][j] = int.Parse(System.Console.ReadLine());
            }

            System.Console.WriteLine();
        }
         
        for (int i = 0; i <arr.Length; i++)
        {
            for (int j = 0; j <arr[i].Length; j++)
            {
                System.Console.Write(arr[i][j] + " ");
            }

            System.Console.WriteLine();
        }System.Console.ReadLine();
       

    }
}