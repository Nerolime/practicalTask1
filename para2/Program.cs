using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.вычисления значения функции y=7x^2-3x+4  при любом значении x");
            int x=5;
       

            int a = 7, b=3, c=4;
            var y = (a * x * x) - b * x + c;
            Console.WriteLine(y);

            Console.ReadLine();

            Console.WriteLine("2.Дан радиус окружности. Найти длину окружности и площадь круга.");
            var radius=5;

            var length = 2 * Math.PI * radius;
            var square = Math.PI * radius * radius;
            Console.WriteLine("dlina=" + length);
            Console.WriteLine("ploshad="+ square);

            Console.ReadLine();

            Console.WriteLine("3.Дано расстояние в сантиметрах. Найти число полных метров в нем.");
            int centimeters;
            Console.WriteLine("enter count of centimeters");
            centimeters = int.Parse(Console.ReadLine());
            int hundred = 100;

            int meters = centimeters / hundred;
            Console.WriteLine(meters);

            Console.ReadLine();

            Console.WriteLine("4.С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
            int days = 234;
            int daysInWeek = 7;
            int weeks = days / daysInWeek;
            Console.WriteLine(weeks);

            Console.ReadLine();

            Console.WriteLine("5.Дано двузначное число. Найти:");
            Console.WriteLine("enter two - digit number");
            int number;
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("a.число десятков в нем;");          

            int ten = 10;

            int dozensOf = number / ten;
            Console.WriteLine(dozensOf);

            Console.WriteLine("b.число единиц в нем;");
            int units = number % 10;
            Console.WriteLine(units);

            Console.WriteLine("c.сумму его цифр;");
            int sum = dozensOf + units;
            Console.WriteLine(sum);

            Console.WriteLine("d.произведение его цифр");
            int multi = dozensOf * units;
            Console.WriteLine(multi);

            Console.ReadLine();

            Console.WriteLine("6.Дано четырехзначное число. Найти:");
            Console.WriteLine("enter four digit number");
            int number2;
 
            Console.WriteLine("a.сумму его цифр;");
            number2 = int.Parse(Console.ReadLine());
            int thousand = 1000;

            int thousands = number2 / thousand;
            int hundreds = number2 / hundred;
            dozensOf = number2 / ten;
            units = number2 % ten;

            sum = thousands + hundreds + dozensOf + units;
            Console.WriteLine(sum);

            Console.WriteLine("b.произведение его цифр.");
            multi= thousands * hundreds * dozensOf * units;
            Console.WriteLine(multi);

            Console.ReadLine();

            Console.WriteLine("7.В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x.");
            Console.WriteLine("enter thre digit number");
            int number3;
            number3 = int.Parse(Console.ReadLine());

            hundreds = number3 / hundred;
            dozensOf = (number3 / ten)-ten*hundreds;
            units = number3 % ten;

            x = hundreds * hundred + units * ten + dozensOf;
            Console.WriteLine(x);

            Console.ReadLine();

        }
    }
}
