using System;
public delegate void dell(int a,int b);
class deleg1
{
    public  void display(int a,int b)
    {
        Console.WriteLine("this is d1"+(a+b));
    }
   // public  void display2(int a)
   // {
 //       Console.WriteLine("this is d2"+a);
   }

class prg
{
    public static void Main(string[] args)
    {
       deleg1 d = new deleg1();
       dell obj = new dell(d.display); 
       obj(3,4);
        //dell o1 = new dell(d.display2);
     //   o1(5);
        Console.ReadKey();

    }



}
