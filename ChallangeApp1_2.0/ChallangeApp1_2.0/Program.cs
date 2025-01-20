//Kurs podstawowy C#
//Praca domowa nr 11

using ChallangeApp1_2._0;

//tworzenie nowych obiektów (pracowników) korzystając z klasy Employee
var worker1 = new Employee("Jan", "Dzban");


//przydzielanie punktów pracownikom 
worker1.AddScore(5);
worker1.AddScore("10");
worker1.AddScore(12.06m);

//pobranie i wyświetlenie danych statystycznych
var statistics = worker1.GetStatisticsWithForEeach();
Console.WriteLine($"Minimalna wartość punktowa otrzymana przez tego pracownika to {statistics.Min}pkt");
Console.WriteLine($"Maksymalna wartość punktowa otrzymana przez tego pracownika to {statistics.Max}pkt");
Console.WriteLine($"Średnia wartość ocen tego pracownika wynosi {statistics.Avarage:N2}pkt");
Console.WriteLine();

statistics = worker1.GetStatisticsWithFor();
Console.WriteLine($"Minimalna wartość punktowa otrzymana przez tego pracownika to {statistics.Min}pkt");
Console.WriteLine($"Maksymalna wartość punktowa otrzymana przez tego pracownika to {statistics.Max}pkt");
Console.WriteLine($"Średnia wartość ocen tego pracownika wynosi {statistics.Avarage:N2}pkt");
Console.WriteLine();

statistics = worker1.GetStatisticsWithDoWhile();
Console.WriteLine($"Minimalna wartość punktowa otrzymana przez tego pracownika to {statistics.Min}pkt");
Console.WriteLine($"Maksymalna wartość punktowa otrzymana przez tego pracownika to {statistics.Max}pkt");
Console.WriteLine($"Średnia wartość ocen tego pracownika wynosi {statistics.Avarage:N2}pkt");
Console.WriteLine();

statistics = worker1.GetStatisticsWithWhile();
Console.WriteLine($"Minimalna wartość punktowa otrzymana przez tego pracownika to {statistics.Min}pkt");
Console.WriteLine($"Maksymalna wartość punktowa otrzymana przez tego pracownika to {statistics.Max}pkt");
Console.WriteLine($"Średnia wartość ocen tego pracownika wynosi {statistics.Avarage:N2}pkt");