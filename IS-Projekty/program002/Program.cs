using System;

class Program {
    static void Main() {
            
            string again = "a";
            while (again == "a") {
                
                Console.Clear();  
                Console.WriteLine("*******************************");
                Console.WriteLine("***Součet a součin cifer *****");
                Console.WriteLine("***Matyáš Karpaš **********");
                Console.WriteLine("***************************");  
                Console.WriteLine();
               
                Console.Write("zadejte číslo: ");
                int number;
                while(!int.TryParse(Console.ReadLine(), out number)) {    //dokud uživatel nezadá číslo správně, bude se furt oběvovat console.write(nezadali...)
                    Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: "); 
                }

                
                
                Console.WriteLine();
                Console.WriteLine("================================================================================================");
                Console.WriteLine("zadane hodnoty: ");
                Console.WriteLine(" číslo : {0}", number);  
                Console.WriteLine("================================================================================================");

                int suma = 0;
                int multi = 1;
                int numberBackup = number;
                int digit;

                if(number < 0){
                    number = -number;
                }

                while (number >= 10) {
                    digit = number % 10;
                    number = (number - digit)/10;
                    Console.WriteLine("Aktuální zbytek = {0}", digit);
                    suma = suma + digit;
                    multi = multi * digit;
                }


                Console.WriteLine("Aktuální zbytek = {0}", number);
                suma = suma + number;
                multi = multi * number;
                
                Console.WriteLine("\n\nsoučet cifer čísla {0} je {1}", numberBackup, suma);
                Console.WriteLine("\n\nsoučet cifer čísla {0} je {1}", numberBackup, multi);
                
                Console.WriteLine();         
                again = Console.ReadLine;

            }

    }
}