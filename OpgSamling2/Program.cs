using System;

Random random = new Random();

// ==========================================
// Opgave 2.1: Plat eller krone
// ==========================================
Console.WriteLine("=== Opgave 2.1: Plat eller krone ===");
Console.Write("Tror du mønten lander på plat eller krone? (skriv 'plat' eller 'krone'): ");
string coinGuess = Console.ReadLine().ToLower();

int coinResult = random.Next(0, 2); // 0 = plat, 1 = krone
string coinActual = "plat";
if (coinResult == 1)
{
    coinActual = "krone";
}

Console.WriteLine($"Mønten landede på: {coinActual}!");
if (coinGuess == coinActual)
{
    Console.WriteLine("Tillykke, du har vundet!");
}
else
{
    Console.WriteLine("Desværre, du har tabt.");
}

Console.WriteLine("\nTryk på Enter for at gå til næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.2: Terningen
// ==========================================
Console.WriteLine("=== Opgave 2.2: Terningen ===");
int dice = random.Next(1, 7);

if (dice == 1)
{
    Console.WriteLine("Du slog en etter");
}
else if (dice == 2)
{
    Console.WriteLine("Du slog en to'er");
}
else if (dice == 3)
{
    Console.WriteLine("Du slog en tre'er");
}
else if (dice == 4)
{
    Console.WriteLine("Du slog en fire'er");
}
else if (dice == 5)
{
    Console.WriteLine("Du slog en fem'er");
}
else if (dice == 6)
{
    Console.WriteLine("Du slog en sekser");
}

Console.WriteLine("\nTryk på Enter for at gå til næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.3: Frysepunktet
// ==========================================
Console.WriteLine("=== Opgave 2.3: Frysepunktet ===");
Console.Write("Indtast den aktuelle temperatur i fryseren: ");
double temp = double.Parse(Console.ReadLine());

if (temp > 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Advarsel: Temperaturen er for høj! Juster fryseren med det samme.");
}
else if (temp < 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Temperaturen er god. Produkterne er sikre.");
}
else // temp == 0
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Temperaturen er ideel (præcis 0), men hold øje med den.");
}
Console.ResetColor();

Console.WriteLine("\nTryk på Enter for at gå til næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.4: Ball and cups
// ==========================================
Console.WriteLine("=== Opgave 2.4: Ball and cups ===");
int winningCup = random.Next(1, 4);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("[Kop 1] ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("[Kop 2] ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("[Kop 3]");
Console.ResetColor();

Console.Write("\nHvilken kop tror du kuglen ligger i? (1, 2 eller 3): ");
int cupGuess = int.Parse(Console.ReadLine());

if (cupGuess == winningCup)
{
    Console.WriteLine("Tillykke! Du fandt kuglen.");
}
else
{
    Console.WriteLine($"Du tabte. Kuglen lå i kop nummer {winningCup}.");
}

Console.WriteLine("\nTryk på Enter for at gå til næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.5: Lufthavnsparkering
// ==========================================
Console.WriteLine("=== Opgave 2.5: Lufthavnsparkering ===");
Console.Write("Har du en parkeringslicens? (ja/nej): ");
bool hasLicense = Console.ReadLine() == "ja";

Console.Write("Er licensen aktiv? (ja/nej): ");
bool isActive = Console.ReadLine() == "ja";

Console.Write("Hvad er klokken? (Indtast time, f.eks. 14): ");
int hour = int.Parse(Console.ReadLine());

Console.Write("Er du medarbejder i lufthavnen? (ja/nej): ");
bool isEmployee = Console.ReadLine() == "ja";

// Betingelse: Licens OG aktiv OG (klokken er mellem 8 og 18 ELLER medarbejder)
if (hasLicense && isActive && ((hour >= 8 && hour < 18) || isEmployee))
{
    Console.WriteLine("Parkering tilladt");
}
else
{
    Console.WriteLine("Parkering ikke tilladt");
}

Console.WriteLine("\nTryk på Enter for at gå til næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.6 (ekstra): Morsekoden
// ==========================================
Console.WriteLine("=== Opgave 2.6: Morsekoden ===");
Console.Write("Indtast en tekst der skal oversættes til morsekode: ");
string inputTekst = Console.ReadLine().ToUpper();

Console.Write("Morsekode: ");
foreach (char c in inputTekst)
{
    switch (c)
    {
        case 'A': Console.Write(".- "); break;
        case 'B': Console.Write("-... "); break;
        case 'C': Console.Write("-.-. "); break;
        case 'D': Console.Write("-.. "); break;
        case 'E': Console.Write(". "); break;
        case 'F': Console.Write("..-. "); break;
        case 'G': Console.Write("--. "); break;
        case 'H': Console.Write(".... "); break;
        case 'I': Console.Write(".. "); break;
        case 'J': Console.Write(".--- "); break;
        case 'K': Console.Write("-.- "); break;
        case 'L': Console.Write(".-.. "); break;
        case 'M': Console.Write("-- "); break;
        case 'N': Console.Write("-. "); break;
        case 'O': Console.Write("--- "); break;
        case 'P': Console.Write(".--. "); break;
        case 'Q': Console.Write("--.- "); break;
        case 'R': Console.Write(".-. "); break;
        case 'S': Console.Write("... "); break;
        case 'T': Console.Write("- "); break;
        case 'U': Console.Write("..- "); break;
        case 'V': Console.Write("...- "); break;
        case 'W': Console.Write(".-- "); break;
        case 'X': Console.Write("-..- "); break;
        case 'Y': Console.Write("-.-- "); break;
        case 'Z': Console.Write("--.. "); break;
        case 'Æ': Console.Write(".-.- "); break;
        case 'Ø': Console.Write("---. "); break;
        case 'Å': Console.Write(".--.- "); break;
        case '1': Console.Write(".---- "); break;
        case '2': Console.Write("..--- "); break;
        case '3': Console.Write("...-- "); break;
        case '4': Console.Write("....- "); break;
        case '5': Console.Write("..... "); break;
        case '6': Console.Write("-.... "); break;
        case '7': Console.Write("--... "); break;
        case '8': Console.Write("---.. "); break;
        case '9': Console.Write("----. "); break;
        case '0': Console.Write("----- "); break;
        case ' ': Console.Write("/ "); break; // Adskiller ord
        default: Console.Write("? "); break;  // Ukendt tegn
    }
}
Console.WriteLine("\n\nProgrammet er slut!");