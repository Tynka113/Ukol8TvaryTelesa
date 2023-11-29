/*
Udělej si interface pro těleso a pro tvar. 
Ten prom těleso bude mít metodu pro výpočet objemu a obsahu. Pro tvar bude mít metodu pro výpočet obvodu a obsahu.

Vytvoř třídy, které budou tato rozhraní implementovat 
a udělej aplikaci, ve které budeš moci pohodlně zadávat 
potřebné parametry k tělesu/tvaru a vypočítat si co potřeba.
 */

using Ukol8TvaryTelesa;

bool jeKonec = false;

//List<ITvar> tvary = new List<ITvar>();
//List<ITeleso> telesa = new List<ITeleso>();

while (!jeKonec)
{
    Console.WriteLine("");
    Console.WriteLine("ZÁKLADNÍ MENU:");
    Console.WriteLine("1-Čtverec");
    Console.WriteLine("2-Obdélník");
    Console.WriteLine("3-Krychle");
    Console.WriteLine("4-Kvádr");
    Console.WriteLine("0-Konec");
    Console.Write("Zadej volbu: ");


    int menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 0:
            jeKonec = true;
            break;
        case 1:
            Console.WriteLine("");
            Ctverec ctverec = new Ctverec();
            ctverec.ZadejHodnoty();
            Console.WriteLine("Obvod zadaného čtverce [cm]: "+ ctverec.VypocitejObvod());
            Console.WriteLine("Obsah zadaného čtverce [cm]: " + ctverec.VypocitejObsah());
            break;
        case 2:
            Console.WriteLine("");
            Obdelnik obdelnik = new Obdelnik();
            obdelnik.ZadejHodnoty();
            Console.WriteLine("Obvod zadaného obdélníku [cm]: " + obdelnik.VypocitejObvod());
            Console.WriteLine("Obsah zadaného obdélníku [cm]: " + obdelnik.VypocitejObsah());
            break;
        case 3:
            Console.WriteLine("");
            Krychle krychle = new Krychle();
            krychle.ZadejHodnoty();
            Console.WriteLine("Objem zadané krychle [cm]: " + krychle.VypocitejObjem());
            Console.WriteLine("Povrch zadané krychle [cm]: " + krychle.VypocitejPovrch());
            break;
        case 4:
            Console.WriteLine("");
            Kvadr kvadr = new Kvadr();
            kvadr.ZadejHodnoty();
            Console.WriteLine("Objem zadaného kvádru [cm]: " + kvadr.VypocitejObjem());
            Console.WriteLine("Povrch zadaného kvádru [cm]: " + kvadr.VypocitejPovrch());
            break;
    }
}