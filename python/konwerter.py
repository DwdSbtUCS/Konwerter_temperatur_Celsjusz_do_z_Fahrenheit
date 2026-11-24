# Dawid Sobota 78618
# Prosty konwerter temperatur w Pythonie (Celsjusz <-> Fahrenheit)

kierunek = input("Wybierz kierunek konwersji (C - z °C na °F, F - z °F na °C): ").strip().upper()
temperatura = float(input("Podaj temperaturę: "))

if kierunek == "C":
    wynik = temperatura * 1.8 + 32
    print(f"{temperatura:g}°C = {wynik:g}°F")
elif kierunek == "F":
    wynik = (temperatura - 32) / 1.8
    print(f"{temperatura:g}°F = {wynik:g}°C")
else:
    print("Nieprawidłowy wybór! Wpisz C lub F.")
