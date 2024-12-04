string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("**** Převod z 10 do 5 soustavy ****");
    Console.WriteLine("******* Matyáš Karpaš ********");
    Console.WriteLine("****************************");
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Zadejte číslo v desítkové soustavě (přirozené číslo): ");
    uint cislo;
    while (!uint.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Špatný vstup. Zadejte číslo v desítkové soustavě (přirozené číslo): ");
    }

    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Desítkové číslo: {0}", cislo);
    Console.WriteLine("========================================================");

    uint zaloha = cislo;
    string vysledek = "";
    uint zbytek;

    while (cislo > 0)
    {
        zbytek = cislo % 5;
        cislo = cislo / 5;
        vysledek = zbytek + vysledek; 
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Celá část = {0}, zbytek = {1}", cislo, zbytek);
    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n Číslo {0} převedené do pětkové soustavy: {1}", zaloha, vysledek);

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();
}