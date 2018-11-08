using System;

namespace ChatClassLibrary
{
    public class OrarioInglese : Orario
    {

        public OrarioInglese() : base() { }

        public OrarioInglese(int h, int m, int s) : base(h, m, s) { }

        public OrarioInglese(int h, int m, int s, bool pm)
        {
            SetOraInglese(h, pm);
            Minuti = m;
            Secondi = s;
        }

        public void SetOraInglese(int h, bool pm)
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

        public int GetOraInglese()
        {
            if (Ora > 12)
                return Ora - 12;
            else if (Ora == 0)
                return 12;
            else
                return Ora;
        }

        public bool IsPM() => (Ora >= 12);
    }
}
