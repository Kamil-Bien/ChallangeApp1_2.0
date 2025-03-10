﻿//Kurs podstawowy C#
//Praca domowa nr 18

using ChallangeApp1_2._0;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

//tworzenie nowych obiektów (pracowników) korzystając z klasy Employee
var worker1 = new EmployeeInFile("Jan", "Dzban");
worker1.GradeAdded += EmployeeGradeAdded;

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



try
{
    var statistics = worker1.GetStatistics();
    Console.WriteLine();
    Console.WriteLine($"Minimalna wartość punktowa otrzymana przez tego pracownika to {statistics.Min}pkt");
    Console.WriteLine($"Maksymalna wartość punktowa otrzymana przez tego pracownika to {statistics.Max}pkt");
    Console.WriteLine($"Średnia wartość ocen tego pracownika wynosi {statistics.Average:N2}pkt");
    Console.WriteLine($"Ten pracownik osiągnął poziom {statistics.AverageLetter:N2}");
}
catch (Exception toJestTymczasowaZmienna)
{
    Console.WriteLine($"Wykryto wyjątek: {toJestTymczasowaZmienna.Message}");
}
Console.WriteLine();
Console.WriteLine("DZIĘKUJEMY ZA SKORZYSTANIE Z NASZEGO PROGRAMU");
Console.WriteLine();
