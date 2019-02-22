using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class DiapasonArray
    {
        Diapason[] arr;
        int size;

        //конструктор по умолчанию
        public DiapasonArray()
        {
            arr = null;
            size = 0;
        }

        //конструктор для генерации случайных диапазонов
        public DiapasonArray(int s)
        {
            size = s;
            arr = new Diapason[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                double beg = rnd.Next(-100, 100);
                double end = rnd.Next(-100, 100);
                Diapason d = new Diapason(beg, end);
                arr[i] = d;
            }
        }

        //конструктор для ручного ввода диапазонов
        public DiapasonArray(int s, bool manual)
        {
            size = s;
            arr = new Diapason[size];
            for (int i = 0; i < size; i++)
            {
                double beg;
                Console.WriteLine("Введите координату начала диапазона:");
                while (!Double.TryParse(Console.ReadLine(), out beg))
                {
                    Console.WriteLine("Ошибка. Повторите ввод.");
                }
                double end;
                Console.WriteLine("Введите координату конца диапазона:");
                while (!Double.TryParse(Console.ReadLine(), out end))
                {
                    Console.WriteLine("Ошибка. Повторите ввод.");
                }
                Diapason d = new Diapason(beg, end);
                arr[i] = d;
            }
        }

        //вывод массива диапазонов
        public void Show()
        {
            for (int i = 0; i < size; i++)
            {
                arr[i].Show();
            }
        }

        //индексатор
        public Diapason this[int index]
        {
            get
            {
                if (index >=0  && index < size)
                {
                    return arr[index];
                }
                else
                {
                    Console.WriteLine("Неправильно задан индекс.");
                    return new Diapason(1, 10);
                }
            }
            set
            {
                if (index >= 0 && index < size)
                {
                    arr[index] = value;
                }
                else
                {
                    Console.WriteLine("Неправильно задан индекс.");
                }
            }
        }

        public int Length()
        {
            return this.size;
        }

    }
}
