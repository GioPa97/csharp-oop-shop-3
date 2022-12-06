using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop3
{
    internal class SacchettoFrutta :prodotto
    {
       
        int peso;
        int pezzi;
        //Costruttori
        public SacchettoFrutta(string nome, string descrizione, int peso, int pezzi,double prezzo, float iva) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
            this.pezzi = pezzi;
        }
        //getter
        public int Getpeso()
        {
            return peso;
        }
        public int Getpezzi()
        {
            return pezzi;
        }
        //Setter
        public void Setpeso(int peso)
        {
            this.peso = peso;
        }
        public void Setpezzi(int pezzi)
        {
            this.pezzi = pezzi;
        }
        //Metodi
        public override void stampaProdotto()
        {
            base.stampaProdotto();
            Console.WriteLine("Peso:" + " " + this.peso + "g");
            Console.WriteLine("Pezzi contenuti:" + " " + this.pezzi);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
