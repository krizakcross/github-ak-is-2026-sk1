string again = "a";
// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************");
    Console.WriteLine("***** Pravoúhly trojuhelník *****");
    Console.WriteLine("*********************************");
    Console.WriteLine("***********krizakcross **********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    // Vstup výšky
    Console.Write("Zadejte výšku obrazce (celé kladné číslo) ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo. Zadejte výšku znovu: ");
        Console.ResetColor();
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================");
    Console.WriteLine($"Výška: {height}");
    Console.WriteLine("==================");
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    // Vykreslovací algoritmus
    

    // Dotaz na opakování
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}