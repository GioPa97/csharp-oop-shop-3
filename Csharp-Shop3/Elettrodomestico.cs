namespace Csharp_Shop3
{
    public class Elettrodomestico : prodotto
    {
        //Attributi/proprietà
        private string condizione;
        //stato
        private bool acceso = false;
        //Getter
        public string Getcondizione()
        {
            return condizione;
        }

        public bool Getacceso()
        {
            return acceso;
        }
        //Setter
        public void Setcondizione(string condizione)
        {
            this.condizione = condizione;
        }
        public void Setacceso(bool acceso)
        {
            this.acceso = acceso;
        }
        //Costruttori
        public Elettrodomestico(string nome, string descrizione, string condizione, double prezzo, float iva) : base(nome, descrizione, prezzo, iva)
        {
            this.condizione = condizione;

        }

        //Metodi
        public void AccendiElettrodomestico()
        {
            if (this.acceso == false)
            {
                Setacceso(true);
                Console.WriteLine("In funzione!");
                Console.WriteLine("------------------------------------");
            }
            else
            {
                Console.WriteLine("Gia acceso!");
                Console.WriteLine("------------------------------------");
            }
        }
        public void SpegniElettrodomestico()
        {
            if (this.acceso == true)
            {
                Setacceso(false);
                Console.WriteLine("Spento correttamente");
                Console.WriteLine("------------------------------------");
            }
            else
            {
                Console.WriteLine("Gia spento!");
                Console.WriteLine("------------------------------------");
            }
        }

        public override void stampaProdotto()
        {
            base.stampaProdotto();
            Console.WriteLine(this.condizione);
            if (Getacceso())
            {
                Console.WriteLine("Prodotto testato!");
            }
            else
            {
                Console.WriteLine("Prodotto mai acceso!");
                Console.WriteLine("------------------------------------");
            }
        }
    }


}
