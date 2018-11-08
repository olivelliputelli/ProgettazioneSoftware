using System;

namespace ChatClassLibrary
{
    public class OrarioInglese : Orario
    {
        public OrarioInglese() : base() { }

        public OrarioInglese(int h, int m, int s)
            : base(h, m, s) { }


        public void SetOrarioInglese(int h, bool pm)
        {
            if (pm)
            {
                if (h >= 1 && h < 12)
                    Ora = h + 12;
                else if (h == 12) Ora = 0;
                else
                    throw new ArgumentOutOfRangeException("Orario non valido!");
            }
            else
            {
                if (h >= 1 && h <= 12)
                    Ora = h;
                else
                    throw new ArgumentOutOfRangeException("Orario non valido!");
            }
        }

        public OrarioInglese(int h, int m, int s, bool pm)
        {
            SetOrarioInglese(h, pm);
            Minuti = m;
            Secondi = s;
        }
    }
}
