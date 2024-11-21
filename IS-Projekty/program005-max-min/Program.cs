using System.Security.Cryptography;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
    Console.WriteLine("*************** Matyáš Karpaš *************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm) || hm < dm)
    {
        Console.Write("Nezadali jste správně horní mez (musí být větší nebo rovna dolní mezi). Zadejte horní mez znovu (celé číslo): ");
    }

    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
    Console.WriteLine("========================================================\n\n");

    // deklarace pole o velikosti n prvků
    int[] myArray = new int[n];

    // příprava pro generátor náhodných čísel
    Random randomNumber = new Random();

    for (int i = 0; i < n; i++)
    {
        myArray[i] = randomNumber.Next(dm, hm + 1);
        Console.Write("{0}; ", myArray[i]);
    }

    int max = myArray[0];
    int min = myArray[0];
    int countMax = 0;
    int countMin = 0;
    string positionsMax = "";
    string positionsMin = "";

    // Jednoduchý průchod polem pro maximum a minimum
    for (int i = 0; i < n; i++)
    {
        if (myArray[i] > max)
        {
            max = myArray[i];
            countMax = 1;
            positionsMax = i.ToString();
        }
        else if (myArray[i] == max)
        {
            countMax++;
            positionsMax += ", " + i;
        }

        if (myArray[i] < min)
        {
            min = myArray[i];
            countMin = 1;
            positionsMin = i.ToString();
        }
        else if (myArray[i] == min)
        {
            countMin++;
            positionsMin += ", " + i;
        }
    }

    // Výstup výsledků
    Console.WriteLine("\n\nMaximum = {0}; Počet výskytů maxima = {1}; Pozice maxima: {2}", max, countMax, positionsMax);
    Console.WriteLine("Minimum = {0}; Počet výskytů minima = {1}; Pozice minima: {2}", min, countMin, positionsMin);

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();
}