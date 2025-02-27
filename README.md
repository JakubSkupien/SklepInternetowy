# SklepInternetowy

## 1. Opis projektu
Projekt **"SklepInternetowy"** to aplikacja webowa umożliwiająca zarządzanie produktami oraz zamówieniami w sklepie internetowym. Aplikacja obsługuje dwa typy użytkowników:

- **Administrator** – może zarządzać produktami, użytkownikami i zamówieniami.
- **Zwykły użytkownik** – może przeglądać ofertę sklepu, dodawać produkty do koszyka i składać zamówienia.

Aplikacja została stworzona w **ASP.NET Core MVC** z wykorzystaniem **Entity Framework Core** do obsługi bazy danych **SQL Server**.

---

## 2. Struktura projektu
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

###  Dla administratora:
- Zarządzanie produktami (dodawanie, edytowanie, usuwanie)
- Przeglądanie i zarządzanie zamówieniami
- Przeglądanie listy użytkowników

###  Dla użytkownika:
- Przeglądanie produktów
- Dodawanie produktów do koszyka
- Składanie zamówień
- Przeglądanie historii zamówień

---

## 4. Instrukcja uruchomienia

###  Wymagania wstępne:
- **.NET SDK 8.0+**
- **SQL Server Express** lub **LocalDB**
- **Visual Studio 2022** (z zainstalowanym ASP.NET & EF Core)

###  Konfiguracja bazy danych
Edytuj plik `appsettings.json` i ustaw połączenie do **SQL Server**:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER\\SQLEXPRESS;Database=EcommerceDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False;"
  }
}
Migracje bazy danych

Uruchom następujące komendy:

    dotnet ef database update

 Uruchomienie aplikacji
    Wybierz SklepInternetowy.csproj jako domyślny projekt startowy.

W Package Manager Console wykonaj:

    dotnet ef database update

Otwórz przeglądarkę i przejdź do:

    http://localhost:5035/
    
5. Informacje o bazie danych
    Struktura tabel:
    Users – Przechowuje dane użytkowników (nazwa, email, hasło).
    Products – Przechowuje produkty (nazwa, cena, opis, kategoria).
    Categories – Lista kategorii produktów.
    Orders – Zamówienia użytkowników.
    OrderItems – Pozycje zamówienia (produkty w zamówieniu).
    Inicjalizacja danych
    Plik SeedData.cs dodaje przykładowe kategorie i produkty do bazy.

6. Uprawnienia użytkowników
    Administrator (Admin)
    Może przeglądać, edytować i usuwać produkty.
    Może zarządzać zamówieniami.
    Ma dostęp do listy użytkowników.
    Zwykły użytkownik (User)
    Może przeglądać produkty.
    Może dodawać produkty do koszyka.
    Może składać zamówienia.
Ma dostęp do historii swoich zamówień.
7. Widoki aplikacji
 Dla administratora:
    /Products/Index – Lista produktów z opcjami zarządzania
    /Orders/Index – Lista zamówień
    /Users/Index – Lista użytkowników

 Dla użytkownika:
    /Products/UserIndex – Przeglądanie produktów
    /Orders/UserOrders – Historia zamówień