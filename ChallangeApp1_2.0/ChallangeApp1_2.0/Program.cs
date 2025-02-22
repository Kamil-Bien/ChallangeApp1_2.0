﻿//Kurs podstawowy C#
//Praca domowa nr 16

using ChallangeApp1_2._0;

//tworzenie nowych obiektów (pracowników) korzystając z klasy Employee
var worker1 = new EmployeeInFile("Jan", "Dzban");

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
        worker1.AddScore(input);
    }
    catch (Exception toJestTymczasowaZmienna)
    {
        Console.WriteLine($"Wykryto wyjątek: {toJestTymczasowaZmienna.Message}");
    }


    Console.WriteLine();
    Console.WriteLine("Możesz podać kolejną ocenę lub zakończyć podając Q jako kolejną wartość");
}

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
