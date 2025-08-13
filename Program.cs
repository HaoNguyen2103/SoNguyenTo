class Program 
{
    static void Main(string[] args)
    {
        int number = 0;
       Console.WriteLine("Cac so nguyen to nho hon 100 la:");
        for (int i = 2; i <= 100; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    number++;
                }
            }
            if (number == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}