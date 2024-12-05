using System.ComponentModel;

string again = "a";
while(again == "a") {
    Console.Clear();
    razitko();

    ulong a = ziskatCislo("Zadejte přirozené číslo a: ");
    ulong b = ziskatCislo("Zadejte přirozené číslo b: ");

    ulong nsd = vypocitatNsd(a, b);   

    ulong nsn = vypocitatNsn(a, b, nsd);

    zobrazitVysledky(a, b, nsd, nsn);

    Console.WriteLine("Program můžete opakovat stisknutím klávesy a");
    again = Console.ReadLine();
}

static void razitko() {
    Console.WriteLine("*************************");
    Console.WriteLine("******* NSD a NSN *******");
    Console.WriteLine("*************************");
    Console.WriteLine("***** Matyáš Karpaš *******");
    Console.WriteLine("**************************\n\n");
    Console.WriteLine();
}

static ulong ziskatCislo(string zprava) {
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nezadali jste celé přirozené číslo. Zadejte znovu: ");
    }

    return cislo;
}

static ulong vypocitatNsd(ulong a, ulong b) { //duplicitní hodnoty, nemusi byt a, b
    while(a!=b) {
        if(a>b)
          a = a - b;
        else
          b = b - a;   
    }

    return a;
}

static ulong vypocitatNsn(ulong a, ulong b, ulong nsd) {
    return (a*b)/nsd;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("NSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"NSN čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.White;
}