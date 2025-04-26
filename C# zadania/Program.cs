using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wybierz program:");
        Console.WriteLine("1 - Kalkulator");
        Console.WriteLine("2 - Konwerter temperatur");
        Console.WriteLine("3 - Srednia ocen ucznia");
        Console.Write("Twoj wybor (1/2/3): ");
        string wybor = Console.ReadLine();
        if (wybor == "1")
        {
            Console.WriteLine("\n--- Kalkulator ---");
            Console.Write("Podaj pierwsza liczbe: ");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj druga liczbe: ");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wybierz dzialanie (+, -, * lub /): ");
            string dzialanie = Console.ReadLine();
            double wynik = 0;
            bool poprawne = true;
            if (dzialanie == "+")
                wynik = liczba1 + liczba2;
            else if (dzialanie == "-")
                wynik = liczba1 - liczba2;
            else if (dzialanie == "*")
                wynik = liczba1 * liczba2;
            else if (dzialanie == "/")
            {
                if (liczba2 != 0)
                    wynik = liczba1 / liczba2;
                else
                {
                    Console.WriteLine("Blad: Dzielenie przez zero");
                    poprawne = false;
                }
            }
            else
            {
                Console.WriteLine("Nieprawidlowa operacja");
                poprawne = false;
            }

            if (poprawne)
                Console.WriteLine("Wynik: " + wynik);
        }
        else if (wybor == "2")
        {
            Console.WriteLine("\n--- Konwerter temperatur ---");
            Console.WriteLine("1 - Celsjusz -> Fahrenheit");
            Console.WriteLine("2 - Fahrenheit -> Celsjusz");
            Console.Write("Wybierz kierunek: ");
            string kierunek = Console.ReadLine();
            if (kierunek == "1")
            {
                Console.Write("Podaj temperature w C: ");
                double c = Convert.ToDouble(Console.ReadLine());
                double f = c * 1.8 + 32;
                Console.WriteLine($"{c}C = {f}F");
            }
            else if (kierunek == "2")
            {
                Console.Write("Podaj temperature w F: ");
                double f = Convert.ToDouble(Console.ReadLine());
                double c = (f - 32) / 1.8;
                Console.WriteLine($"{f}F = {c}C");
            }
            else
            {
                Console.WriteLine("Nieprawidlowa operacja.");
            }
        }
        else if (wybor == "3")
        {
            Console.WriteLine("\n--- Srednia ocen ucznia ---");
            Console.Write("Ile ocen chcesz wprowadzic? ");
            int ile = Convert.ToInt32(Console.ReadLine());
            double suma = 0;
            for (int i = 0; i < ile; i++)
            {
                Console.Write($"Podaj ocene {i + 1}: ");
                double ocena = Convert.ToDouble(Console.ReadLine());

                if (ocena <= 6)
                    suma += ocena;
                else
                {
                    Console.WriteLine("Blad: Ocena za wysoka. Podaj jeszcze raz:");
                    ocena = Convert.ToDouble(Console.ReadLine());
                    suma += ocena;
                }
            }
            double srednia = suma / ile;
            Console.WriteLine($"Srednia: {srednia:F2}");

            if (srednia >= 3.0)
                Console.WriteLine("Uczen zdal.");
            else
                Console.WriteLine("Uczen nie zdal.");
        }
        else
        {
            Console.WriteLine("Nieprawidlowa operacja.");
        }
    }
}
