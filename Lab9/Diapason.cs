using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Diapason
    {
        double x; //начало диапазона
        double y; // конец диапазона
        static int count = 0; //статическая переменная для подсчета количества созданных объектов

        //свойства
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        //конструкторы
        public Diapason()
        {
            x = 1;
            y = 10;
            count++;
        }

        public Diapason(double x, double y)
        {
            if (y >= x)
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                Console.WriteLine("Вторая координата должна быть больше первой.");
                Console.WriteLine("Координата y на 10 больше координаты x в случае неправильных ввода или генерации.");
                this.x = x;
                this.y = x + 10;
            }
            count++;
        }

        //вывод атрибутов
        public void Show()
        {
            Console.WriteLine($"Диапазон от {x} до {y}");
        }

        //проверка на пересечение двух диапазонов
        public static bool Compare(Diapason a, Diapason b)
        {
            if ((b.y >= a.x) && (b.x <= a.y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Compare(Diapason b)
        {
            if ((b.y >= x) && (b.x <= y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Вывод количества созданных объектов
        static public int GetCount()
        {
            return count;
        }

        //перегрузка унарного оператора
        public static double operator !(Diapason a)
        {
            return Math.Abs(a.y - a.x);
        }

        //неявное приведение типов
        //возвращает целую часть координаты x
        public static implicit operator int(Diapason a)
        {
            return (int)Math.Truncate(a.x);
        }

        //явное приведение типов
        //возвращает координату y
        public static explicit operator double(Diapason a)
        {
            return a.y;
        }

        //перегрузка бинарного оператора
        //уменьшение координаты x
        public static Diapason operator -(Diapason a, int x)
        {
            Diapason res = new Diapason();

            res.x = a.x - x;
            res.y = a.y;

            return res;
        }

        //уменьшение координаты y
        public static Diapason operator -(int x, Diapason a)
        {
            Diapason res = new Diapason();

            res.x = a.x;
            res.y = a.y - x;

            return res;
        }

        //пересчение диапазонов
        public static bool operator <(Diapason a, Diapason b)
        {
            if (Diapason.Compare(a, b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Diapason a, Diapason b)
        {
            if (Diapason.Compare(a, b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
