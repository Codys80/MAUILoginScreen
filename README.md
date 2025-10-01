# Wykonaj aplikację mobilną za pomocą środowiska programistycznego dostępnego na stanowisku egzaminacyjnym oraz uruchom ją w dostępnym emulatorze systemu mobilnego.  
# Opis wyglądu aplikacji  
- Napis „Zaloguj się”.  
- Napis „Adres e-mail:”, jako placeholder.  
- Napis „Hasło:”,  jako placeholder, realizuje ukrywanie hasła po wpisaniu.  
- Przycisk „Zaloguj się”,  jest on wyśrodkowany. ‒ Obszar do wyświetlania komunikatów, jest on wyśrodkowany.  
- Przycisk o treści „Nie pamiętasz hasła?”, jest on wyśrodkowany. 
- Informacja o tym, że można zalogować się przez, a pod nim 3 różne ikony. 
- Na samym dole "Załóż nowe konto". 
- Informacja o cloudflare może być pominięta. Wygląd ma być taki jak na załączonym obrazku. 
- Może być inne logo niż WP Konto jako nagłówek.

# Działanie aplikacji 
- Po wybraniu przycisku Zaloguj się jest sprawdzane:   
- Czy e-mail zawiera znak @.  
- Czy podane hasło jest równe powtórzonemu hasłu.  
- W obszarze do wyświetlania komunikatów pojawia się napis:  
- Na początku działania aplikacji: „Autor”, dalej wstawiony numer PESEL zdającego.  
- Po zatwierdzeniu, gdy e-mail jest niepoprawny: „Nieprawidłowy adres e-mail”.  
- Po zatwierdzeniu, gdy hasła się różnią: „Hasła się różnią”.  
- Po zatwierdzeniu, gdy nie wystąpiły błędy: „Witaj ”, gdzie oznacza aktualnie wprowadzony adres e-mail.

# Założenia aplikacji 
- Interfejs użytkownika zapisany za pomocą języka znaczników wspieranego w danym środowisku (np. XAML, XML).  
- Zastosowany typ rozkładu liniowy (Linear / Stack lub inny o tej idei).  
- Zastosowany kolor tła dla napisu „Zaloguj się”: Teal (#008080).  
- Zastosowany kolory czcionki: czarny i szary, zgodnie z Obrazem.  
- Czcionka napisu „Zaloguj się” jest wizualnie większa od pozostałych.  
Pola edycyjne są rozciągnięte na całą szerokość ekranu. 

Aplikacja powinna być zapisana czytelnie, z zasadami czystego formatowania kodu, stosować znaczące nazwy zmiennych i funkcji. 
