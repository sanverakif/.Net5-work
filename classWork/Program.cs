using System;

namespace classWork
{
    class Program
    {
        static void Main(string [] args)
        {
            Sekil s = new Sekil(5, 5);
            Ucgen u = new Ucgen(9, 10);
            Console.WriteLine(u.AlanHesapla());
        }
    }
    class Sekil
    {
        //sınıf içerisindeki protected kalıtım veren veya kalıtım alan sınıftan erişilebilir..
        protected int _boy;
        protected int _en;
        public Sekil(int a)
        {
            Console.WriteLine(a);
        }
        public Sekil(int boy, int en)
        {
            this._boy = boy;
            this._en = en;
            Console.WriteLine(this._boy + "" + this._en);
        }
        public virtual int AlanHesapla()
        {
            return 5;
        }
    }
    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en) : base(boy, en)
        {
        }
        public Ucgen(int a) : base(a)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en / 2;
        }
    }
    class Dortgen : Sekil
    {
        public Dortgen(int boy, int en) : base(boy, en)
        {
        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }
    class Dikdortgen : Sekil
    {
        public Dikdortgen(int boy, int en) : base(boy, en)
        {
        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }
}