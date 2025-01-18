//Kurs podstawowy C#
//Praca domowa nr 9

using ChallangeApp1_2._0;

//tworzenie nowych obiektów (pracowników) korzystając z klasy Employee
var worker1 = new Employee("Jan", "Dzban");


//przydzielanie punktów pracownikom 
worker1.AddScore(5);
worker1.AddScore(-4);
worker1.AddScore(-1);

//pobranie i wyświetlenie danych statystycznych
var statistics = worker1.GetStatistics();
Console.WriteLine($"Minimalna wartość punktowa otrzymana przez tego pracownika to {statistics.Min}pkt");
Console.WriteLine($"Maksymalna wartość punktowa otrzymana przez tego pracownika to {statistics.Max}pkt");
Console.WriteLine($"Średnia wartość tego pracownika wynosi {statistics.Avarage:N2}pkt");
