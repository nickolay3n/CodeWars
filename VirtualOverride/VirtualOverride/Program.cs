using System;

namespace VirtualOverride
{

    class BaseClass
    {
        // Создать виртуальный метод в базовом классе.
        public virtual void Metod()
        {
            Console.WriteLine("Метод Who() в классе Base");
        }
    }
    class ClassPotomok1 : BaseClass
    {
        // Переопределить метод Who() в производном классе.

        public override void Metod()
        {
            Console.WriteLine("Метод Metod () в классе ClassPotomok1");
        }
    }
    class ClassPotomok2 : BaseClass
    {
        // Переопределить метод Who() в производном классе.
        public override void Metod()
        {
            Console.WriteLine("Метод Metod () в классе ClassPotomok2");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseOb = new BaseClass();
            ClassPotomok1 potomok1 = new ClassPotomok1();
            ClassPotomok2 potomok2 = new ClassPotomok2();
            BaseClass baseRef; // ссылка на базовый класс
            baseRef = baseOb;
            baseRef.Metod();
            baseRef = potomok1; // вызывается метод Metod () из класса ClassPotomok1
            baseRef.Metod();
            baseRef = potomok2;
            baseRef.Metod(); // вызывается метод Metod () из класса ClassPotomok2

        }
    }
}
