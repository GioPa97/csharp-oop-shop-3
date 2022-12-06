using System.Runtime.CompilerServices;

namespace Csharp_Shop3
{
    public class prodotto
    {
        
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private float iva;
        private double prezzoIvato;

        //GETTER//--------------------------------------------------------------------------------
       
        public int getCodice()
        {
            return this.codice;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getDescrizione()
        {
            return this.descrizione;
        }
        public double getPrezzo()
        {
            return this.prezzo;
        }

        public double getPrezzoIvato()
        {
            return this.prezzoIvato;
        }
        public float getIva()
        {
            return this.iva;
        }
        //SETTER//----------------------------------------------------------------------------------
       
        private int setCodice()
        {

            Random number = new Random();
            return number.Next(0, 100000000);

        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }
        public void setPrezzo(double prezzo)
        {
            Math.Round(prezzo, 2);
            this.prezzo = prezzo;
        }

        public void setPrezzoIva(double prezzoIvato)
        {
            Math.Round(prezzoIvato, 2);
            this.prezzoIvato = prezzoIvato;
        }
        public void setIva(float iva)
        {
            Math.Round(iva, 2);
            this.iva = iva;
        }
        //Costruttori----------------------------------------------------------------------------

        public prodotto(string nome, string descrizione, double prezzo, float iva)
        {
            this.codice = this.setCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }


        //Metodi----------------------------------------------------------------------------------
        private void calcolaprezzoIvato()
        {

            float iva = getIva();
            double prezzo = getPrezzo();
            double percentualeIva = Math.Round((prezzo * iva) / 100, 2);
            double prezzoIvato = Math.Round(prezzo + percentualeIva, 2);

            Console.WriteLine("Prezzo finale:" + " " + prezzoIvato + "EUR");
            Console.WriteLine("");
            Console.WriteLine("Di cui Iva:" + " " + percentualeIva);
        }

        private void creaNomeEsteso()
        {
            string codiceString = this.codice.ToString();
            string nomeEsteso = codiceString + this.nome;
            Console.WriteLine("Nome esteso:" + nomeEsteso);

        }


        public virtual void stampaProdotto()
        {

            string nome = getNome();
            string descrizione = getDescrizione();
            prezzo = getPrezzo();
            float iva = getIva();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Info" + " " + nome + "______________________");
            creaNomeEsteso();
            Console.WriteLine("Codice prodotto:" + " " + this.codice);
            Console.WriteLine("Nome prodotto:" + " " + nome);
            Console.WriteLine("Descrizione prodotto:" + " " + descrizione);
            Console.WriteLine("Prezzo prodotto:" + " " + prezzo + "EUR");
            Console.WriteLine("Iva prodotto:" + " " + iva + "%");
            calcolaprezzoIvato();
            Console.WriteLine("_______________________________________");

        }

        //------------------------------------------------------------------------------------------
    }
}
