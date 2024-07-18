using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGitHubProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            double R, S, L;
            Console.Write("R=");
            R = Convert.ToDouble(Console.ReadLine());
            S = Math.PI * R*R;
            L = 2 * Math.PI * R;
            Console.WriteLine("S=" + S + "\n L=" + L);
            //2
            double value, course,summa;
            Console.Write("value:");
            value = Convert.ToDouble(Console.ReadLine());
            Console.Write("course:");
            course = Convert.ToDouble(Console.ReadLine());
            summa = course * value;
            Console.WriteLine("convert summa="+summa+"sum");
            //3
            int year, thisyear,day;
            Console.WriteLine("was born year:");
            year = Convert.ToInt32(Console.ReadLine());
            thisyear = Convert.ToInt32(Console.ReadLine());
            thisyear = Convert.ToInt32(Console.ReadLine());
            day = (thisyear - year) * 365;
            Console.WriteLine("person was born" +$"{ day}  ago");

        }
    }
}
