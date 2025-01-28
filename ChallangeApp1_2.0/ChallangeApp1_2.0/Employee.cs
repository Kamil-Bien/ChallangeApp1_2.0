namespace ChallangeApp1_2._0
{
    public class Employee : Person
    {
  

        private List<float> score = new List<float>();

        public Employee(string name, string surname, char sex) //konstruktor
            : base(name, surname, sex)
        {
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
                throw new Exception("Podana liczba musi znajdować się w zakresie 0-100");
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
                throw new Exception("Błąd rzutowania zmiennej");
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
            if (this.score.Count > 0)
            {
                var statistics = new Statistics();

                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;

                foreach (var score in this.score)
                {
                    statistics.Min = Math.Min(statistics.Min, score);
                    statistics.Max = Math.Max(statistics.Max, score);
                }

                statistics.Average = this.Result / this.score.Count;

                switch (statistics.Average)
                {
                    case var x when x >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var x when x >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var x when x >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var x when x >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'Ę';
                        break;

                }

                return statistics;
            }
            else
            {
                return null;
            }

        }


    }
}
