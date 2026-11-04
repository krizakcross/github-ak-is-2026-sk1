string again = "a";
// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "a")
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
    int digit;


    // Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}