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

    //--------------------------metody dodawania punktów do oceny ogólnej pracownika, z podziałem na różne typy danych wejściowych-------------------
        public void AddScore(float numberOfPionts) //property (pole/właściwość) odpowiedzialne za dodawanie punktów do puli punktów danego użytkownika
        {
            if (numberOfPionts >= 0 && numberOfPionts <= 100)
            {
                this.score.Add(numberOfPionts);
            }
            else
            {
                Console.WriteLine($"Podana liczba -> {numberOfPionts} nie spełnia wrunków! Musi znajdować się w zakresie 0-100");
            }
        }

        public void AddScore(string numberOfPionts)
        {
            if (float.TryParse(numberOfPionts, out float resultOfTypeCasting))
            {
                this.AddScore(resultOfTypeCasting);
            }
            else
            {
                Console.WriteLine($"Podana wartość -> {numberOfPionts} nie spełnia wrunków! Błąd rzutowania zmiennej");
            }
        }

        public void AddScore(decimal numberOfPionts)
        {
           float numberOfPiontsFromDecimalType = (float)numberOfPionts;
           this.AddScore(numberOfPiontsFromDecimalType);
        }
        public void AddScore(int numberOfPionts)
        {
            float numberOfPiontsFromIntigerType = (float)numberOfPionts;
            this.AddScore(numberOfPiontsFromIntigerType);
        }

        //------------------------------------------------------------------------------------------------------------------
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
