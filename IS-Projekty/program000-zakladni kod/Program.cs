using System;

class Program {
    static void Main() {
            
            string again = "a";
            while (again == "a") {
                
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

                 
                
                Console.WriteLine();
                Console.WriteLine("================================================================================================");
                Console.WriteLine("zadejte hodnoty: {)";)
                Console.WriteLine("číslo řady: {0}", number);  //napišemi hodnotu first na pozici {0}
               
             


                // logika pro výpis řady
                int current = first;
                while (current <= last) {
                    Console.WriteLine(current);
                    current = current + step;
                }


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Program můžete opakovat stiskem klávesy a");
                again = Console.ReadLine();
                //Console.ReadKey();  //díky tomu bude čekat konzole na zavření, jinak by se sama zavřela

            }

    }
}