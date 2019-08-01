using System;

namespace Lab9
{
    class Diapason
    {
        //свойства
        public double X { get; set; }

        public double Y { get; set; }

        public static int Count { get; set; } = 0;

        //конструкторы
        public Diapason()
        {
            X = 1;
            Y = 10;
            Count++;
        }

        public Diapason(double x, double y)
        {
            if (y >= x)
            {
                X = x;
                Y = y;
            }
            else
            {
                Console.WriteLine("Вторая координата должна быть больше первой.");
                Console.WriteLine("Координата y на 10 больше координаты x в случае неправильных ввода или генерации.");
                X = x;
                Y = x + 10;
            }
            Count++;
        }

        //вывод атрибутов
        public void Show()
        {
            Console.WriteLine($"Диапазон от {X} до {Y}");
        }

        //проверка на пересечение двух диапазонов
        public static bool Compare(Diapason a, Diapason b)
        {
            if ((b.Y >= a.X) && (b.X <= a.Y))
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
            if ((b.Y >= X) && (b.X <= Y))
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
            return Count;
        }

        //перегрузка унарного оператора
        public static double operator !(Diapason a)
        {
            return Math.Abs(a.Y - a.X);
        }

        //неявное приведение типов
        //возвращает целую часть координаты x
        public static implicit operator int(Diapason a)
        {
            return (int)Math.Truncate(a.X);
        }

        //явное приведение типов
        //возвращает координату y
        public static explicit operator double(Diapason a)
        {
            return a.Y;
        }

        //перегрузка бинарного оператора
        //уменьшение координаты x
        public static Diapason operator -(Diapason a, int x)
        {
            Diapason res = new Diapason();

            res.X = a.X - x;
            res.Y = a.Y;

            return res;
        }

        //уменьшение координаты y
        public static Diapason operator -(int x, Diapason a)
        {
            Diapason res = new Diapason();

            res.X = a.X;
            res.Y = a.Y - x;

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
