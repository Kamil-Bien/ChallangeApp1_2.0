//Kurs podstawowy C#
//Praca domowa nr 6

using ChallangeApp1_2._0;

//tworzenie nowych obiektów (pracowników) korzystając z klasy Employee
Employee worker1 = new Employee("Jan", "Dzban", 24);
Employee worker2 = new Employee("Roman", "Bosy", 35);
Employee worker3 = new Employee("Żylisław", "Świerczyński-Brzęczyszczykiewicz", 55);

//przydzielanie punktów pracownikom 
worker1.AddScore(5);
worker1.AddScore(3);
worker1.AddScore(5);
worker1.AddScore(4);
worker1.AddScore(5);

worker2.AddScore(5);
worker2.AddScore(2);
worker2.AddScore(4);
worker2.AddScore(5);
worker2.AddScore(4);

worker3.AddScore(5);
worker3.AddScore(6);
worker3.AddScore(2);
worker3.AddScore(5);
worker3.AddScore(5);

//utworzenie listy pracowników
List<Employee> workers = new List<Employee>()
{
    worker1, worker2, worker3
};

//deklaracja listy najlepszych pracowników
List<Employee> employeeOfTheMonth = new List<Employee>();

//zmienne pomocnicze do poniższych dwóch pętli
int bestScore = -1;
Employee bestWorker = null;

//wyłonienie najwyższego wyniku
foreach (var worker in workers)
{
    if (worker.Result > bestScore)
    {
        bestScore = worker.Result;
        bestWorker = worker;
    }
}

//wyłonienie pracowników z najwyższym wynikiem i dodanie ich do listy najlepszych pracowników (ex aequo pierwsze miejsce)
foreach (var worker in workers)
{
    if (worker.Result == bestWorker.Result)
    {
        employeeOfTheMonth.Add(worker);
    }
}

//wyświetlenie najlepszego pracownika lub najlepszych pracowników (osiągających ten sam najwyższy wynik)
if (employeeOfTheMonth.Count == 1)
{
    Console.WriteLine("Pracownik miesiąca:");
    Console.WriteLine();
    Console.WriteLine(bestWorker.name + " " + bestWorker.surname + ", wiek: " + bestWorker.age + " lat, uzyskał wynik: " + bestWorker.Result + "pkt");
}
else
{
    Console.WriteLine("Pracownicy miesiąca, uzyskali wynik " + bestScore + "pkt");
    Console.WriteLine();
    foreach (var bestWorkers in employeeOfTheMonth)
    {
        Console.WriteLine(bestWorkers.name + " " + bestWorkers.surname + ", wiek: " + bestWorkers.age);
    }
}