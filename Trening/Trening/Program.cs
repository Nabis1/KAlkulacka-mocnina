namespace Trening
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Napisu radek a odentruju.");
            Console.Write("Napisu radek. Zadej vstup: ");
            string inputFromConsoleAsString = Console.ReadLine(); // Tento řádek načte vstup od uživatele.
            /*
            Toto je příklad blokového komentáře.
            */

            string deklarovanaPromenna; // vytvoreni promenne
            string deklarovanaPromennaSInicializaci = "MujText"; // vytvoreni promenne + inicializace hodnotou
            deklarovanaPromenna = deklarovanaPromennaSInicializaci; // prirazuju promenne jiz vytvorenou hodnotu 
            deklarovanaPromenna = "NejakyText"; // prirazuju promenne hodnotu, ktera je typu, ktery byl zadan pri deklaraci.

            int celeCislo = 0;
            double desetinneCislo = 3.1415;
            char znak = 'Z';
            string retezecZnaku = "NejakeZnaky";
            bool pravda = true;
            bool nepravda = false;

            //prace se stringy
            string sectenyString = "A" + "B";
            string formatovanyString = $"Toto je znak {znak}, toto je retezec znaku {retezecZnaku}";

            //stringy jsou ve skutecnosti pole
            char prvniZnak = retezecZnaku[0];
            char posledniZnak = retezecZnaku[retezecZnaku.Length - 1];

            //operatory v c#
            int x;
            x = 0; // assignment
            x += 3; // plus
            x -= 1; // minus
            x *= 2; // multiply
            x /= 2; // divide

            //porovnani v c#
            int a = 0;
            int b = 0;
            bool vysledekPorovnani;
            vysledekPorovnani = a == b; // rovnost
            vysledekPorovnani = a != b; // nerovnost
            vysledekPorovnani = a > b; // vetsi
            vysledekPorovnani = a < b; // mensi
            vysledekPorovnani = a >= b; // vetsi nebo rovno
            vysledekPorovnani = a <= b; // mensi nebo rovno

            //logicke porovnani v c#
            bool pravdaProPorovnani = true;
            bool nepravdaProPorovnani = false;
            bool vysledekLogickehoPorovnani;

            vysledekLogickehoPorovnani = pravdaProPorovnani && nepravdaProPorovnani; //AND (a zaroven), vsechno musi platit (byt true)
            vysledekLogickehoPorovnani = 5 > 2 && 4 < 3; //tohleto vyjde false
            vysledekLogickehoPorovnani = true && true; //tohleto vyjde true
            vysledekLogickehoPorovnani = true && false; //tohleto vyjde false
            vysledekLogickehoPorovnani = false && false; //tohleto vyjde false

            vysledekLogickehoPorovnani = pravdaProPorovnani || nepravdaProPorovnani; //OR (a nebo), alespon jedno musi platit (byt true)
            vysledekLogickehoPorovnani = 5 > 2 || 4 < 3; //tohleto vyjde true
            vysledekLogickehoPorovnani = true || true; //tohleto vyjde true
            vysledekLogickehoPorovnani = true || false; //tohleto vyjde true
            vysledekLogickehoPorovnani = false || false; //tohleto vyjde false

            vysledekLogickehoPorovnani = !pravdaProPorovnani; //NOT (negace), obrati vysledek logicke hodnoty (true -> false, false -> true)
            vysledekLogickehoPorovnani = !nepravdaProPorovnani; //tohleto vyjde true
            vysledekLogickehoPorovnani = !true; //tohleto vyjde false
            vysledekLogickehoPorovnani = !false; //tohleto vyjde true

            vysledekLogickehoPorovnani = !((true && false) || true);  //tohleto vyjde false

            //operace na stringu
            string retezec = "NejakyTrapnyRetezec";
            Console.WriteLine($"Muj retezec {retezec} je {retezec.Length} znaku dlouhy.");
            Console.WriteLine($"Muj retezec vypada {retezec.ToLower()} jako vsechno malym.");
            Console.WriteLine($"Muj retezec vypada {retezec.ToUpper()} jako vsechno velkym.");

            //konverze mezi typy
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            // IF ELSE (pro jednoduche podminky)
            if (true)
            {
                Console.WriteLine("Podminka je vzdy platna.");
            }

            if (false)
            {

            }
            else
            {
                Console.WriteLine("Podminka je vzdy neplatna.");
            }

            if (!false)
            {
                Console.WriteLine("Podminka je znegovana a tedy funguje.");
            }

            int cislo = 5;
            if (cislo < 2)
            {
                Console.WriteLine("Cislo je mensi nez 2.");
            }
            else if (cislo < 3)
            {
                Console.WriteLine("Cislo je mensi nez 3.");
            }
            else if (cislo < 4)
            {
                Console.WriteLine("Cislo je mensi nez 4.");
            }
            else
            {
                Console.WriteLine("Ani jedna podminka nebyla splnena.");
            }

            // SWITCH (pro konecny pocet moznych hodnot)
            switch (cislo)
            {
                case 0:
                    Console.WriteLine("Cislo je nula.");
                    break; // dulezite!
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Cislo je 1 nebo 2 nebo 3 nebo 4.");
                    break;
                default:
                    Console.WriteLine("Ani jeden case nebyl splnen.");
                    break;
            }

            // WHILE (konej dokud podminka plati)
            while (true) //budeme vykonavat stale dokola.
            {
                Console.WriteLine("Vypis.");
                break; //vyskocime z aktualniho cyklu.
            } // nas while vypise Vypis. prave jednou.

            while (false) // nikdy se nevykona
            {
                Console.WriteLine("Vypis.");
            }
            int pocitadlo = 0;
            while (pocitadlo < 8)
            {
                pocitadlo++;
                Console.WriteLine($"Pocitadlo ma hodnotu: {pocitadlo}");
            }

            // FOR (konej xkrat - definovano programatorem)
            for (int i = 5/*pocitadlo*/; i < 8/*podminka kdy zkoncim*/; i++/*co udelam po kazdem provedeni cyklu*/)
            {
                Console.WriteLine(i);
            }

            int pocitadloMimoFor = 0;
            for (Console.WriteLine($"Budeme pocitat! Pocitadla ma nyni hodnotu: {pocitadloMimoFor}")/*vykona se prave jednou na zacatku*/; pocitadloMimoFor < 8/*podminka kdy zkoncim*/; Console.Write("#")/*co udelam po kazdem provedeni cyklu*/)
            {
                pocitadloMimoFor++;
            }
            Console.WriteLine();
            Console.WriteLine($"Pocitadlo ma nyni hodnotu: {pocitadloMimoFor}");

            // Pole (arrays)
            string[] brands = { "Adidas", "Nike", "Puma", "Ťaman"};
            Console.WriteLine("Znam tyto znacky:");
            // FOREACH (konej tolikrat, kolik je hodnot v kolekci)
            foreach (string brand in brands ) 
            {
                Console.WriteLine(brand);
            }

            string[] fejkoveZnacky = brands;
            //fakovane znacky
            for(int i = 0; i < brands.Length; i++ )
            {
                fejkoveZnacky[i] = "Smr" + brands[i].ToLower();
            }

            Console.WriteLine("Fejkove znacky:");
            foreach (string fejk in fejkoveZnacky )
            {
                Console.WriteLine(fejk);
            }
        }
    }
}