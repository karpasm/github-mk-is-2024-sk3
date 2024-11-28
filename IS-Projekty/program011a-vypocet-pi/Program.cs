string again = "a";
while (again == "a") {
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("**** Výpočet ln(2) ****");
    Console.WriteLine("******************************");
    Console.WriteLine("******** Matyáš Karpaš *********");
    Console.WriteLine("******************************\n\n");

    Console.WriteLine("Tento program vypočítá hodnotu ln(2) pomocí nekonečné řady.");
    Console.WriteLine("Zadejte přesnost, která určuje, kdy má program zastavit výpočet.");
    Console.WriteLine("Ideální hodnoty přesnosti jsou mezi 0,00001 a 0,1.");
    Console.WriteLine("Větší čísla než 0,1 nebo záporná čísla nebudou přijata.\n");

    Console.Write("Zadejte přesnost (reálné číslo v rozmezí 0.00001 - 0.1): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost) || presnost <= 0 || presnost > 0.1) {
        Console.Write("Nezadali jste správné číslo. Zadejte číslo mezi 0,00001 a 0,1: ");
    }

    double ln2 = 0.0;
    double aktualniClen = 1.0;
    int n = 1;


    while (Math.Abs(aktualniClen) >= presnost) {
        aktualniClen = Math.Pow(-1, n + 1) / n; // (-1)^(n+1) / n
        ln2 += aktualniClen;
        Console.WriteLine("Člen: {0}/{1}; aktuální hodnota ln(2) = {2}", aktualniClen > 0 ? "+" : "-", n, ln2);
        n++;
    }

    Console.WriteLine("\n\nHodnota ln(2) = {0}", ln2);
    Console.WriteLine("Hodnota ln(2) = {0:f4}", ln2);
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}