using System;
class eg1
{
    public void factorial()
    {
        int fact = 1;
        Console.WriteLine("enter the no:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("factorial:" + fact);

    }
    public void prime()
    {

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
    }
    public static void Main (string[] args)
    {
        for (; ; )
        {
            int n;
            Console.WriteLine("1-Generate fionacci series \n2-prime no \n3-vowel \n4-reverse \n choose option:");
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