using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Diapason a = new Diapason(25.4, 100.7);
            a.Show();

            Diapason b = new Diapason(-100.8, 100);
            b.Show();

            Diapason c = new Diapason(-0.5, 0.5);
            c.Show();

            if (Diapason.Compare(a, c))
            {
                Console.WriteLine("Диапазоны пересекаются");
            }
            else
            {
                Console.WriteLine("Диапазоны не пересекаются");
            }

            if (a.Compare(c))
            {
                Console.WriteLine("Диапазоны пересекаются");
            }
            else
            {
                Console.WriteLine("Диапазоны не пересекаются");
            }

            Console.WriteLine($"Количество созданных объектов: {Diapason.GetCount()}");

            double length = !c;
            Console.WriteLine($"Длина диапазона: {length}");


            int intPart = a;
            Console.WriteLine($"Приведение типов неявное: {intPart}");

            double coord = (double)a;
            Console.WriteLine($"Приведение типов явное: {coord}");

            a.Show();
            a = a - 5;
            a.Show();
            a = 5 - a;
            a.Show();

            if (a < b)
            {
                Console.WriteLine("Диапазоны пересекаются");
            }
            else
            {
                Console.WriteLine("Диапазоны не пересекаются");
            }

            DiapasonArray da = new DiapasonArray(5);
            da.Show();

            Console.WriteLine($"Количество созданных объектов: {Diapason.GetCount()}");
            Console.WriteLine("");

            Console.WriteLine("Проверка индексатора");
            Console.WriteLine("Доступ к элементу с номером 0 - селектор");
            Diapason d = new Diapason();
            d = da[0];
            d.Show();

            Console.WriteLine("Доступ к элементу с номером 0 - модификатор");
            da[0] = new Diapason(5, 10);
            da.Show();

            Console.WriteLine("Доступ к элементу с номером 10 - селектор");
            d = da[10];
            d.Show();

            Console.WriteLine("Доступ к элементу с номером 10 - модификатор");
            da[10] = new Diapason(5, 10);
            da.Show();

            Console.WriteLine("");
            FindMaxValue(da);
        }

        private static void FindMaxValue(DiapasonArray da)
        {
            Double max = da[0].Y;
            for (int i = 1; i < da.Length(); i++)
            {
                if (da[i].Y > max)
                {
                    max = da[i].Y;
                }
            }
            Console.WriteLine($"Максимальное значение диапазонов: {max}");
        }
    }
}
