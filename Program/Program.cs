using System;
using ConsoleApp4;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 vector = new Vector3(1, 2, 3);
            //Cars audi = new Cars("Audi", vector);
            //audi.Start();
            //audi.Move(new Vector3(0, 6, 5));
            //Console.WriteLine(audi.GetInfo());
            //audi.Move(new Vector3(0, 6, 5));
            //Console.WriteLine(audi.GetInfo());
            //audi.Move(new Vector3(0, 6, 5));
            //Console.WriteLine(audi.GetInfo());
            Cars audi = new Cars("audi", vector, 0100);
            audi.KeyValid(0100);
            audi.Start();
            audi.Move(new Vector3(1, 3, 5));
            audi.Move(new Vector3(1, 3, 5));
            Console.WriteLine(audi.GetInfo());

        }
    }
}
