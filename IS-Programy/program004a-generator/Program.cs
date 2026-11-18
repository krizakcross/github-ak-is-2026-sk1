string again = "a";
// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Generátor čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* krizakcross ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Počet generovaných čísel větší než nula
    Console.Write("Zadejte počet generovaných čísel (kladné číslo) ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste kladné číslo. Zadejte první číslo znovu: ");
    }

    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (kladné číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste kladné číslo. Zadejte poslední číslo znovu: ");
    }

    // Načtení horní meze
    Console.Write("Zadejte horní mez (kladné číslo větší nebo rovno dolní meze): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound || upperBound < lowerBound ))
    {
        Console.Write("Nezadali jste kladné číslo. Zadejte poslední číslo znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("===================================================================");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound} ");
    Console.WriteLine("===================================================================");
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem

    // Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}