using System;

class Program {
    static void Main() {
            Console.Clear();  //vymaže konzoli
            Console.WriteLine("***Výpis číselné řady *****");
            Console.WriteLine("***Matyáš Karpaš **********");
            Console.WriteLine("***************************");  //napíše mi danou věc na vlastní řádek
            Console.WriteLine(" ");

            //vstup od uživatele

           /* Console.Write("zadejte první číslo: ");
            int first = int.Parse(Console.ReadLine()); */

            //vstup od uživatele lépe řešený
            Console.Write("zadejte číslo: ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {    //dokud uživatel nezadá číslo správně, bude se furt oběvovat console.write(nezadali...)
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: "); 
                }

            Console.ReadKey();  //díky tomu bude čekat konzole na zavření, jinak by se sama zavřela

    }
}