    using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop3
{
    internal class CiboInScatola : prodotto
    
    {
        int peso;
        //Costruttori
        public CiboInScatola(string nome, string descrizione, int peso, double prezzo, float iva) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
        }
        //getter
       public int Getpeso()
        {
            return peso;
        }
        //Setter
        public void Setpeso(int peso)
        {
            this.peso = peso;
        }
        //Metodi
        public override void stampaProdotto()
        {
            base.stampaProdotto();
            Console.WriteLine("Peso:"+" "+this.peso+"g");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
