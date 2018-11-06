using System;

namespace ChatClassLibrary
{
    public class Data
    {
        private int giorno;

        public int Giorno
        {
            get { return giorno; }
            private set { giorno = value; }
        }

        private int mese;

        public int Mese
        {
            get { return mese; }
            private set { mese = value; }
        }

        private int anno;

        public int Anno
        {
            get { return anno; }
            private set { anno = value; }
        }

        public Data()
        {
            this.Giorno = 1;
            this.Mese = 1;
            this.Anno = 2000;
        }

        public Data(int g = 1, int m = 1, int a = 1)
        {
            if (a < 1 || m < 1 || m > 12 || g < 1) throw new ArgumentOutOfRangeException("Data non valida");
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                if (g > 31) throw new ArgumentOutOfRangeException("Data non valida");

            if (m == 4 || m == 6 || m == 9 || m == 11)
                if (g > 30) throw new ArgumentOutOfRangeException("Data non valida");

            if (m == 2 && IsBisestile(a)) // bisestile
                if (g > 29) throw new ArgumentOutOfRangeException("Data non valida");

            if (m == 2 && !IsBisestile(a)) // non bisestile
                if (g > 28) throw new ArgumentOutOfRangeException("Data non valida");

            this.Anno = a;
            this.Mese = m;
            this.Giorno = g;
        }

        private bool IsBisestile(int anno) => (anno % 4 == 0 && anno % 100 != 0 || anno % 400 == 0);

        private static int JulianDay(Data d)
        {
            int a, y, m;
            a = (14 - d.Mese) / 12;
            y = d.Anno + 4800 - a;
            m = d.Mese + 12 * a - 3;
            return d.Giorno + (153 * m + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;
        }

        public int Differenza(Data d)
            => Math.Abs(JulianDay(this) - JulianDay(d));
    }
}
