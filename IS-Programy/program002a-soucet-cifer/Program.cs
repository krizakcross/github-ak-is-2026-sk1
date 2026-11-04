string again = "r";
// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "r")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Součet cifer *****");
    Console.WriteLine("****************************");
    Console.WriteLine("***** krizakcross ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup první hodnoty
    Console.Write("Zadejte číslo (celé číslo): ");
    int cislo;
    while (!int.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"První číslo: {cislo}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem

    // Příprava pomocných proměnných
    int cisloBac = cislo;
    int sum = 0;    // Neutrální hodnota pro sčítání
    int sumsoucin = 0;
    int digit;

    // Ošetření záporných čísel (znaménko nemá vliv na číslice)
    if (cislo < 0) {
        cislo = -cislo;
    }

    // Případ pro nulu
    if (cislo == 0)
    {
        sum = 0;
        sumsoucin = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice");
        Console.WriteLine("---------------------------------");

        // Matematický rozklad pomocí cyklu
        while (cislo > 0)
        {
            digit = cislo % 10;         //<---- Modulo
            sum = sum + digit;           // Přičtení cifry k celku

            Console.WriteLine($"Získaná číslice: {digit}");

            cislo = cislo / 10;

        }
    }
    

    // Výpis výsledku
    Console.WriteLine("==========================================");
    Console.WriteLine($"Ciferný součet čísla {cisloBac} je {sum}.");
    Console.WriteLine("==========================================");

    // Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'r' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}