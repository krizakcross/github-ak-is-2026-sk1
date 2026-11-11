string again = "a";
// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výkres obdelníku *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* krizakcross ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup šířky
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte šířkuznovu: ");
    }

    // Vstup výšky
    Console.Write("Zadejte výšku obrazce (celé kladné číslo) ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte výšku znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Šířka: {width}; Výška: {height}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem





































    // Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}