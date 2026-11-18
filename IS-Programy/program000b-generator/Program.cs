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
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Horní mez musí být kladné číslo větší nebo rovno dolní Zadejte poslední číslo znovu: ");
    }

    //Algoritmus
    // Deklarace alokace pole v pamětí
    int[] myRandNumbs = new int[n];

    // Inicializace generátoru nahodných čísel
    Random myRandNumb = new Random();
    

    // Generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
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