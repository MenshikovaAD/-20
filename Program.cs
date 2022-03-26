using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    internal class Program
    {
        delegate double MyDelegate(double R);    
        static void Main(string[] args)
        {
            

            MyDelegate myDelegate = Circumference;
            myDelegate += AreaOfCircle;
            myDelegate += BallVolume;
            Console.WriteLine("Введите радиус круга R");
            Double R = myDelegate(Convert.ToDouble(Console.ReadLine()));
            

            Console.ReadKey();
        }
        static double Circumference(double R)
        {
            double r = (double)2 * Math.PI * R;
            Console.WriteLine("Длина окружности: {0}",  r);
            return r;
        }
        
        static double AreaOfCircle(double R)
        {
            double r = (double)Math.PI * R * R;
            Console.WriteLine("Площадь круга: {0}", r);
            return r;
        }

        static double BallVolume(double R)
        {
            double r = (double) (4 * Math.PI * R * R * R)/3;
            Console.WriteLine("Объем шара: {0}", r);
            return r;
        }

        
    }
}
