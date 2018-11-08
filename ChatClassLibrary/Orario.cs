using System;

namespace ChatClassLibrary
{
    public class Orario
    {
        private int ora;

        public virtual int Ora
        {
            get => ora;
            set => ora = (value >= 0 && value <= 23) ? value : throw new ArgumentOutOfRangeException("Orario non valido!");
        }

        private int minuti;

        public int Minuti
        {
            get { return minuti; }
            set { minuti = (value >= 0 && value <= 59) ? value : throw new ArgumentOutOfRangeException("Orario non valido!"); }
        }

        private int secondi;

        public int Secondi
        {
            get { return secondi; }
            set { secondi = (value >= 0 && value <= 59) ? value : throw new ArgumentOutOfRangeException("Orario non valido!"); }
        }

        // Costruttore vuoto
        public Orario() : this(0, 0, 0) { }

        public Orario(int h, int m, int s)
        {
            this.Ora = h;
            this.Minuti = m;
            this.Secondi = s;
        }
    }
}
