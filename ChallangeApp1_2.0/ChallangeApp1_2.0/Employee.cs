namespace ChallangeApp1_2._0
{
    public class Employee
    {
        public string name { get; private set; }
        public string surname { get; private set; }

        private List<float> score = new List<float>();

        public Employee(string name, string surname) //konstruktor
        {
            this.name = name;
            this.surname = surname;
        }

    
        public void AddScore(float number) //property (pole/właściwość) odpowiedzialne za dodawanie punktów do puli punktów danego użytkownika
        {
            this.score.Add(number);
        }

        public float Result //property zwraca sumę punktów zawartych w liście "score" danego użytkownika
        {
            get
            {
                return this.score.Sum();
            }
        }

        public Statistics GetStatistics() //metoda obliczająca statystyki (bazuje na modelu danych z klasy Statistics)
        {
            var statistics = new Statistics();

            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Avarage = 0;

            foreach (var score in this.score)
            {
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Max = Math.Max(statistics.Max, score);
            }

            statistics.Avarage = this.Result / this.score.Count;

            return statistics;
        }

    }
}
