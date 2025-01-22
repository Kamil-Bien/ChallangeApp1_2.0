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
var statistics = worker1.GetStatistics();
