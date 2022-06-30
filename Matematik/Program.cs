using Matematik;
using System;

class Program
{
    static   void Main(string[] args)
    {
        DortIslem dortIslem = new DortIslem();
        dortIslem.Topla(5,6);
        Console.WriteLine(dortIslem.Topla);
    }
}