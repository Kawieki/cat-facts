# Aplikacja Konsolowa Cat Facts

Prosta aplikacja konsolowa w C#, która pobiera losowe fakty o kotach z API `https://catfact.ninja/fact` i zapisuje je do lokalnego pliku tekstowego `catfacts.txt`.

## Funkcjonalności

- Asynchroniczne pobieranie faktów o kotach przez HTTP.
- Dopisywanie każdego faktu do lokalnego pliku tekstowego.
- Wykorzystanie Dependency Injection
- Asynchroniczny zapis do pliku

## Jak używać

1. Uruchom aplikację.
2. Aplikacja pobierze fakt o kocie z API.
3. Fakt zostanie dopisany do pliku `catfacts.txt` w katalogu głównym rozwiązania.

## Przykład formatu pliku

`fact: Baking chocolate is the most dangerous chocolate to your cat. (length: 61)`

## Technologie

- .NET 8.0
- HttpClient
- DI z `Microsoft.Extensions.DependencyInjection`

## Uwagi

- Plik zapisywany jest względem katalogu głównego rozwiązania, co zapewnia spójność niezależnie od środowiska.
