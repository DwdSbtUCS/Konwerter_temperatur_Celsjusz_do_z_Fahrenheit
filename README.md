# Konwerter temperatur - Celsjusz do i z Fahrenheit, wersje dla Python oraz C#

Prosty program konsolowy umożliwiający konwersję temperatur między skalą Celsjusza (`°C`) a Fahrenheita (`°F`) na podstawie wyboru kierunku konwersji (`C` lub `F`).

## Wzory konwersji
- `°F = °C * 1.8 + 32`
- `°C = (°F - 32) / 1.8`

## Struktura repozytorium

```text
.
├── python/
│   └── konwerter.py
├── csharp/
│   ├── Program.cs
│   └── KonwerterTemperatur.csproj
└── README.md
```

## Uruchomienie

### Python
```bash
python python/konwerter.py
```

### C#
```bash
dotnet run --project csharp/KonwerterTemperatur.csproj
```
