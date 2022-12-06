using Csharp_Shop3;


internal class Program
{
    private static void Main(string[] args)
    {
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


        //acqua
        Acqua acquaPanna = new Acqua("Acqua Panna", "Alimentari", 1, 4, 2, 7, "Monticchio");
        acquaPanna.stampaProdotto();
        acquaPanna.bevi();
        Acqua acquaLete = new Acqua("Acqua Lete", "Alimentari", 1, 4, 1, 6, "MonteOlimpo");
        acquaLete.stampaProdotto();
        acquaLete.svuota(1);
        acquaLete.riempi(6);

        //Cibo in scatola
        CiboInScatola gattoMatto = new CiboInScatola("GattoMatto", "Alimenti per animali", 300, 2.5, 10);
        gattoMatto.stampaProdotto();

        //Sacchetto frutta
        SacchettoFrutta FruttaMix = new SacchettoFrutta("FruttaMix", "Alimentari", 250, 5, 5, 10);
        FruttaMix.stampaProdotto();
    }
}