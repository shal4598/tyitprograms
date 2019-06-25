using System;
class p1
{
   public void CurrencyConversion()
    {
       int n;
       double dollar,euro,v1,v2;
       Console.WriteLine("1-dollar To rupee \n2-euro To rupee \nchoose option:");
       n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine("Enter the dollar amount");
                dollar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of 1 dollar in rupee");
                 v1 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(dollar+" dollar="+(dollar*v1)+" rupee");
                break;
            case 2:
                 Console.WriteLine("Enter the Euro amount");
                euro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of 1 euro in rupee");
                 v2 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(euro + " euro =" + (euro * v2) + " rupee");
                break;
            default:
                Console.WriteLine("Error!!!");
                break;
        }
    }
    public void factorial()
    {
        int fact=1;
        Console.WriteLine("enter the no:");
        int n=Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("factorial:" + fact);

    }
    public void cube()
    {
        Console.WriteLine("enter the no:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("cube of "+n+" =" + (n*n*n));

    }
    public void fibo()
    {
        int n1 = 0;
        int n2 = 1;
        Console.WriteLine("enter the no of term u want:");
        int n = Convert.ToInt32(Console.ReadLine());
         Console.Write("fibonacci series upto "+n+" : " +n1+","+n2);
         for (int i = 2; i <= n; i++)
         {
             int fibo = n1 + n2;
             n1 = n2;
             n2 = fibo;
             Console.Write("," + fibo);
         }
       

    }
    public static void Main(string[] args)
    {
        for (; ; )
        {
            int n;
            Console.WriteLine("1-currency conversion \n2-factorial \n3-cube of given number \n4-gnerate fionacci series \nchoose option:");
            n = Convert.ToInt32(Console.ReadLine());
            p1 p = new p1();
            switch (n)
            {
                case 1:
                    p.CurrencyConversion();
                    break;
                case 2:
                    p.factorial();
                    break;
                case 3:
                    p.cube();
                    break;
                case 4:
                    p.fibo();
                    break;
                default:
                    Console.WriteLine("Error!!!");
                    break;
            }
            Console.ReadKey();
        }

    }
}