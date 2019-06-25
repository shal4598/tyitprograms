using System;
public delegate void dell();
class deleg
{
    static void display1()
    {
        Console.WriteLine("this is d1");
    }
     static void display2()
    {
        Console.WriteLine("this is d2");
    }
    public static void Main(string[] argss)
    {
        dell o = new dell(display1);
        o();
        dell o1 = new dell(display2);
        o1();
        Console.ReadKey();

    }



}
