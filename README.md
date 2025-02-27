# Dokumentacja projektu "Projekt_ASPNET_Magazyn"

## 1. Opis projektu

PProjekt **"SklepInternetowy"** to aplikacja webowa umożliwiająca zarządzanie produktami oraz zamówieniami w sklepie internetowym. Aplikacja obsługuje dwa typy użytkowników:

- **Administrator** – może zarządzać produktami, użytkownikami i zamówieniami.
- **Zwykły użytkownik** – może przeglądać ofertę sklepu, dodawać produkty do koszyka i składać zamówienia.

Aplikacja została stworzona w **ASP.NET Core MVC** z wykorzystaniem **Entity Framework Core** do obsługi bazy danych **SQL Server**.

---

## 2. Struktura projektu

### Główne elementy projektu:

SklepInternetowy
SklepInternetowy csproj - Plik projektu
Program cs - Konfiguracja aplikacji
appsettings json - Konfiguracja połączenia z bazą danych
Controllers - Kontrolery aplikacji
HomeController cs - Strona główna
ProductsController cs - Zarządzanie produktami
OrdersController cs - Obsługa zamówień
UsersController cs - Obsługa użytkowników
Models - Modele danych
Product cs - Model produktu
Category cs - Model kategorii
Order cs - Model zamówienia
OrderItem cs - Model pozycji zamówienia
User cs - Model użytkownika
Data - Konfiguracja bazy danych
ApplicationDbContext cs - Klasa DbContext
SeedData cs - Inicjalizacja danych
Views - Widoki aplikacji
Home - Widoki strony głównej
Index cshtml - Widok listy produktów
Products - Widoki produktów
Index cshtml - Lista produktów
Create cshtml - Formularz dodawania produktów
Edit cshtml - Formularz edycji produktów
Details cshtml - Szczegóły produktu
Delete cshtml - Potwierdzenie usunięcia
Shared - Szablony strony Layout cshtml
wwwroot - Zasoby statyczne CSS JS obrazy
Migrations - Pliki migracji Entity Framework
---

## 3. Kluczowe funkcjonalności

### Dla administratora:

- Może przeglądać, edytować i usuwać produkty.
- Może zarządzać zamówieniami
- Ma dostęp do listy użytkowników.

### Dla zwykłego użytkownika:

- Przeglądanie dostępnych produktów.
- Składanie zamówień.
- Przeglądanie historii swoich zamówień.

---

## 4. Instrukcja uruchomienia

1. **Wymagania wstępne:**

   - Zainstalowany .NET SDK 6.0 lub nowszy.
   - SQL Server do obsługi bazy danych.

2. **Konfiguracja:**

   - W pliku `appsettings.json` ustaw poprawne dane połączenia z bazą danych:
     ```json
     "ConnectionStrings": {
         "DefaultConnection": "Data Source=YOUR_SERVER;Initial Catalog=Test;Integrated Security=True;TrustServerCertificate=True"
     }
     ```

3. **Migracje bazy danych:**

   - W konsoli NuGet wykonaj komendy:
     ```
     Update-Database
     ```

4. **Uruchomienie aplikacji:**

   - W Visual Studio wybierz `Test.sln`.
   - W konsoli NuGet wykonaj komende:
     'dotnet run'
   - Otwórz przeglądarkę i przejdź do:
      http://localhost:5035/

---

## 5. Informacje o bazie danych

### Struktura tabel::

    Users – Przechowuje dane użytkowników (nazwa, email, hasło).
    Products – Przechowuje produkty (nazwa, cena, opis, kategoria).
    Categories – Lista kategorii produktów.
    Orders – Zamówienia użytkowników.
    OrderItems – Pozycje zamówienia (produkty w zamówieniu).
    Inicjalizacja danych
    Plik SeedData.cs dodaje przykładowe kategorie i produkty do bazy..

### Inicjalizacja danych:

W pliku `Program.cs` aplikacja:

- Tworzy domyślne role `Admin` i `User`.
- Dodaje użytkownika admina (`admin@admin.com`) z hasłem (`Admin1234!`) i użytkownika (`user@user.com`) z hasłem (`User1234!`).
- Inicjalizuje tabelę `Asortyment` przykładowymi produktami.

---

## 6. Uprawnienia użytkowników

### Administrator (Admin):

- Dostęp do wszystkich funkcji aplikacji.
- Możliwość przeglądania, edytowania i usuwania produktów.
- Możliwość przeglądania i usuwania zamówień.
- Podgląd na wszystkich użytkowników i sumaryczną liczbę ich zamówień.

### Zwykły użytkownik (User):

- Dostęp do przeglądania asortymentu.
- Możliwość składania zamówień.
- Możliwość przeglądania swoich zamówień.

---

## 7. Widoki aplikacji

### Dla administratora:

    /Products/Index – Lista produktów z opcjami zarządzania
    /Orders/Index – Lista zamówień
    /Users/Index – Lista użytkowników

### Dla użytkownika:

    /Products/UserIndex – Przeglądanie produktów
    /Orders/UserOrders – Historia zamówień

