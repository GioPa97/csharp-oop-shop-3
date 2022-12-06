using Csharp_Shop3;
using System.Runtime.CompilerServices;

internal class Program
{

    private static void Main(string[] args)
    {
        /*
            //Creo un prodotto e lo stampo//___________________________________________________
            prodotto prodottoUno = new prodotto("pane", "alimentari", 3.99, 4);
            prodottoUno.stampaProdotto();

            //_________________________________________________________________________________
            //Creo un prodotto e lo stampo//___________________________________________________
            prodotto prodottoDue = new prodotto("sparapatate", "utensili", 119.99, 22);
            prodottoDue.stampaProdotto();


            //-------------------------shop2---------------------------------------------------
            //stampante
            Elettrodomestico stampante = new Elettrodomestico("Epson", "Elettrodomestico", "nuovo", 60.99, 22);
            stampante.stampaProdotto();
            stampante.AccendiElettrodomestico();
            stampante.AccendiElettrodomestico();
            stampante.SpegniElettrodomestico();
            stampante.SpegniElettrodomestico();
            //monitor
            Elettrodomestico monitor = new Elettrodomestico("samsung lcd", "Elettrodomestico", "nuovo", 150.50, 22);
            monitor.stampaProdotto();
            */

        //-----------------------------shop3-------------------------------------------------------
        try
        {
            //acqua Dichiaro che i litri sono 6 per verificare la ricezione dell'errore
            Acqua acquaBrutal = new Acqua("Acqua Brutal", "Alimentari", 2, 4, 6, 8, "Alcatraz");
            acquaBrutal.stampaProdotto();
        }
        catch (CapacitàMassimaException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            //acqua Dichiaro che il ph + 11 per verificare la ricezione dell'errore
            Acqua acquaPanna = new Acqua("Acqua Panna", "Alimentari", 1, 4, 2, 11, "Monticchio");
            acquaPanna.stampaProdotto();
            acquaPanna.bevi();
        }
        catch (PhException e)
        {
            Console.WriteLine(e.Message);
        }

        try  //acqua Svuoto la bottiglia e la riempio per più della sua capacità per verificare la ricezione dell'errore
        {
            Acqua acquaLete = new Acqua("Acqua Lete", "Alimentari", 1, 4, 1, 6, "MonteOlimpo");
            acquaLete.stampaProdotto();
            acquaLete.svuota(1);
            acquaLete.riempi(6);
        }
        catch (RiempiLitriException e)
        {
            Console.WriteLine(e.Message);
        }

        Acqua acquaSanta = new Acqua("Acqua Santa", "Alimentari", 1, 4, 1, 6, "MonteOlimpo");
        acquaSanta.stampaProdotto();
        //Metodo statico
         Acqua.convertiInGalloni(5);










        /*
        //Cibo in scatola
        CiboInScatola gattoMatto = new CiboInScatola("GattoMatto", "Alimenti per animali", 300, 2.5, 10);
        gattoMatto.stampaProdotto();

        //Sacchetto frutta
        SacchettoFrutta FruttaMix = new SacchettoFrutta("FruttaMix", "Alimentari", 250, 5, 5, 10);
        FruttaMix.stampaProdotto();
        */



    }
}