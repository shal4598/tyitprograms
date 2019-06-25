using System;                           // Factorial , prime no .,vowel ,reverse
class eg1
{
    public void factorial()
    {
        int fact = 1;
        Console.WriteLine("enter the no:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        
            fact = fact * i;
        
        Console.WriteLine("factorial:" + fact);

    }
    public void prime()
    {
        Console.WriteLine("enter the no:");
        int n = Convert.ToInt32(Console.ReadLine());
        int c=0, i;
        for (i = 2; i <= n / 2; i++)
        { 
        if(n%i==0)
        {
            c++;
            break;
        }
        }
        if(c==0)
        {
            Console.WriteLine("this is prime");
        }
        else
        {
            Console.WriteLine("this is not a prime");
        }
           

    }
    public void vowel()
    {
        char c;
        Console.WriteLine("enter the letter:");
        c = Convert.ToChar(Console.ReadLine());
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            Console.WriteLine("this is vowel");
        }
        else
        {
            Console.WriteLine("this is not a vowel");
        }

    }
    public void reverse()
    {
        Console.WriteLine("enter the no:");
        int a = Convert.ToInt32(Console.ReadLine());
        int n = a;
        int rev = 0;
        int rem = 0;
        while (n > 0)
        {
            rem = n % 10;
            rev = rev * 10 + rem;
            n = n / 10;
        }
        Console.WriteLine("Reverse of" + a + "=" + rev);


    }
    public static void Main(string[] args)
    {
        for (; ; )
        {
            int n;
            Console.WriteLine("1-Factorial \n2-prime no \n3-vowel \n4-reverse \n choose option:");
            n = Convert.ToInt32(Console.ReadLine());
            eg1 p = new eg1();
            switch (n)
            {
                case 1:
                    p.factorial();
                    break;
                case 2:
                    p.prime();
                    break;
                case 3:
                    p.vowel();
                    break;
                case 4:
                    p.reverse();
                    break;
                default:
                    Console.WriteLine("Error!!!");
                    break;
            }
            Console.ReadKey();
        }

    }
}