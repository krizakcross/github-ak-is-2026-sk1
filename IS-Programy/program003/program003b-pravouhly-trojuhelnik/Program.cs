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
        for (int i = 1; i <= height; i++)
    {
        Console.WriteLine();
                if (i % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            } 
        //  Vnitřní cyklus, který vykresluje v řádku počet teček
        for (int j = 1; j <= i; j++)
        {

            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(25)); // nastavení zpoždění
            Console.Write("• ");
        }
    }

    // Dotaz na opakování
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}