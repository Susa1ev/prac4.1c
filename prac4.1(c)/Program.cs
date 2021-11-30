using System;

namespace prac4._1_c_
{
    class prac
    {
        int a, b;
        public prac()
        {
            reTry:
            Console.WriteLine("Введите два целочисленных значения:");
            if( Int32.TryParse(Console.ReadLine(), out a) &&
                Int32.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(nod(Math.Abs(a), Math.Abs(b)));
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то, попробуйте ещё раз");
                goto reTry;
            }
        }
        int nod(int a,int b)
        {
            if(a == b) { return a; }
            else if(a > b)
            {
                return nod(a - b, b);
            }
            else
            {
                return nod(a, b-a);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}
