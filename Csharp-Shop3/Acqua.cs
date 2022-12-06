    namespace Csharp_Shop3
{
    internal class Acqua : prodotto
    {

        //Attributi/proprietà
        uint litri = 1;
        uint ph = 7;
        string sorgente;
        uint capacità = 5;
        //stato
        bool vuota = false;
        //getter
        public uint Getlitri()
        {
            return litri;
        }
        public uint Getph()
        {
            return ph;
        }
        public string Getsorgente()
        {
            return sorgente;
        }
        public bool Getvuota()
        {

            return vuota;

        }
        //setter

        /// <summary>
        /// Non puoi inserire un prodotto con più di 5 litri!
        /// </summary>
        /// <param name="litri"></param>
        public void Setlitri(uint litri)
        {
            
            
         this.litri = litri;
            
            
        }
        public void SetVuota(bool vuota)
        {
            this.vuota = vuota;
        }

        public void Setph(uint ph)
        {
            this.ph = ph;
        }

        //Costruttori
        public Acqua(string nome, string descrizione, double prezzo, float iva, uint litri, uint ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            if (litri > this.capacità)
            {
                throw new Exception("Questa categoria di prodotto non può avere più di 5 litri!");
            }
            this.litri = litri;
            if (ph>10)
            {
                throw new PhException("Il ph non può essere maggiore di 10");
            }
            this.ph = ph;
            this.sorgente = sorgente;
        }


        //metodi
        public void bevi()
        {
            if (this.capacità > 0)
            {
                SetVuota(true);
                Console.WriteLine("GLU GLU GLU!!!");
                Console.WriteLine("Ehi quell'acqua la devi pagare! Sicurezzaaaaaaa!!!!");

            }
        }

        public uint riempi(uint litri)
        {
            if (litri <= this.capacità-this.litri)
            {
                this.litri = this.litri + litri;
                Console.WriteLine("Hai aggiunto" + litri + "l" + "al prodotto!");
            }
            else
            {
                Console.WriteLine("Non puoi Aggiungere più di 5 litri!");
            }

            return capacità;
        }
        public uint svuota(uint litri)
        {
            if (litri > 0 && this.litri <= this.capacità)
            {

                this.litri = this.litri - litri;
                Console.WriteLine("Hai svuotato" +" " + litri + "l" + " "+"al prodotto!");
            }
            else
            {
                Console.WriteLine("Non puoi svuotare più di 5 litri!");
            }

            return litri;
        }
        public override void stampaProdotto()
        {
            base.stampaProdotto();
            Console.WriteLine("Sorgente" + " " + this.sorgente);
            Console.WriteLine("Ph" + " " + this.ph);
            Console.WriteLine("Litri contenuti" + " " + this.litri + " " + "l");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }




    }
}
