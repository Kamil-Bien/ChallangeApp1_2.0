//Kurs podstawowy C#
//Praca domowa nr 13

using System;
using ChallangeApp1_2._0;

//tworzenie nowych obiektów (pracowników) korzystając z klasy Employee
var worker1 = new Employee("Jan", "Dzban");

Console.WriteLine("Podaj ocenę pracownika mieszczącą się w przedziale od 0 do 100");
Console.WriteLine("(Jeżeli chcesz odrazu zakończyć wciśnij Q a następnie ENTER)");
while (true)
{
    var input = Console.ReadLine();
    if ((input == "q") || (input == "Q")) 
    {
        break;
    }

    
    try
    {
        worker1.AddScore(input); //tutaj wykonuje kroki i sprawdza czy pojawiło się ecception
    }
    catch (Exception toJestTymczasowaZmienna)
    {
        Console.WriteLine($"Wykryto wyjątek: {toJestTymczasowaZmienna.Message}"); //jeśli pojawi się Exception to wtedy zadział catch i wykona się ta linia
    }


    Console.WriteLine();
    Console.WriteLine("Możesz podać kolejną ocenę lub zakończyć podając Q jako kolejną wartość");
}

//pobranie i wyświetlenie danych statystycznych

var statistics = worker1.GetStatistics();
if (worker1.GetStatistics() != null)
{
    Console.WriteLine();
    Console.WriteLine($"Minimalna wartość punktowa otrzymana przez tego pracownika to {statistics.Min}pkt");
    Console.WriteLine($"Maksymalna wartość punktowa otrzymana przez tego pracownika to {statistics.Max}pkt");
    Console.WriteLine($"Średnia wartość ocen tego pracownika wynosi {statistics.Average:N2}pkt");
    Console.WriteLine($"Ten pracownik osiągnął poziom {statistics.AverageLetter:N2}");
}
else
{ 
    Console.WriteLine("Ten pracownik nie otrzymał żadnej oceny");
}
Console.WriteLine();
    Console.WriteLine("DZIĘKUJEMY ZA SKORZYSTANIE Z NASZEGO PROGRAMU");
    Console.WriteLine();

try
{
    //tutaj sprawdza czy pojawiło się ecception
}
catch(Exception)
{
    //jeśli pojawi się Exception to wtedy zadział catch i wykona się ta linia
}