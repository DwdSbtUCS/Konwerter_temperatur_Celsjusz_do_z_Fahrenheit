// Dawid Sobota 78618
// Prosty konwerter temperatur w C# (Celsjusz <-> Fahrenheit)

Console.Write("Wybierz kierunek konwersji (C - z °C na °F, F - z °F na °C): ");
string? kierunek = Console.ReadLine()?.Trim().ToUpper();

Console.Write("Podaj temperaturę: ");
double temperatura = Convert.ToDouble(Console.ReadLine());

if (kierunek == "C")
{
    double wynik = temperatura * 1.8 + 32;
    Console.WriteLine($"{temperatura}°C = {wynik}°F");
}
else if (kierunek == "F")
{
    double wynik = (temperatura - 32) / 1.8;
    Console.WriteLine($"{temperatura}°F = {wynik}°C");
}
else
{
    Console.WriteLine("Nieprawidłowy wybór! Wpisz C lub F.");
}
