//Schody

//Vypiš zadaný počet schodů (řádků) podle uvedeného příkladu. Napiš program tak, aby uživatel mohl zadat počet schodů, které se mají vypsat.

//Příklad výstupu pro 6 schodů:

//     #

//    ##

//   ###

//  ####

// #####

//######



//(první řádek obsahuje 5 mezer a 1 mřížku, druhý řádek obsahuje 4 mezery a 2 mřížky, …., poslední řádek obsahuje 6 mřížek)



//Zdroj: https://www.hackerrank.com/challenges/staircase/problem 

Console.WriteLine("Zadej počet schodů a já ti udělám schodiště:");
string pocetSchoduText;
int pocetSchodu;
pocetSchoduText = Console.ReadLine();
while (!int.TryParse(pocetSchoduText, out pocetSchodu))
{
    Console.WriteLine("Tak to zkus znovu. Zadej počet schodů.");
    pocetSchoduText = Console.ReadLine();
}

for (int i = pocetSchodu; i > 0; i--)
{
    for (int j = 0; j < (i-1); j++)
    {
        Console.Write(" ");
    }

    for (int k = pocetSchodu; k > (i-1); k--)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}

Console.ReadLine();

//Minimální a maximální součet n-1 prvků

//Zvol si libovolné pole délky n a najdi v něm takovou kombinaci n-1 prvků, které dávají nejnižší a nejvyšší součet. Tyto dva součty vypiš jako výsledek.

//Příklad: Pole s prvky {3, 1, 9, 7, 5} o délce n = 5. Jde nám o to, vybrat z tohoto pole takovou kombinaci n-1 (tedy čtyř) čísel, která dává nejmenší a největší součet.
//Správná odpověď  v tomto případě je 1 + 3 + 5 + 7 = 16, což je minimum a 3 + 5 + 7 + 9 = 24, což je maximum.

//Zdroj: https://www.hackerrank.com/challenges/mini-max-sum/problem 


int[] poleCisel = { 3, 1, 9, 7, 5 };
int nejmensiCislo = int.MaxValue;
int nejvetsiCislo = int.MinValue;
int soucetCisel = 0;

for (int i = 0; i < poleCisel.Length; i++)
{
    if (poleCisel[i] > nejvetsiCislo)
    {
        nejvetsiCislo = poleCisel[i];
    }
    if (poleCisel[i] < nejmensiCislo)
    {
        nejmensiCislo = poleCisel[i];
    }
    soucetCisel += poleCisel[i];
}

Console.WriteLine("Výpis obsahu celého pole: ");
for (int i = 0; i < poleCisel.Length; i++)
{
    Console.Write(poleCisel[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Součet nejmenších {0} čísel ze zadaného pole je {1}.", (poleCisel.Length - 1), (soucetCisel - nejvetsiCislo));
Console.WriteLine("Součet největších {0} čísel ze zadaného pole je {1}.", (poleCisel.Length - 1), (soucetCisel - nejmensiCislo));

Console.ReadLine();