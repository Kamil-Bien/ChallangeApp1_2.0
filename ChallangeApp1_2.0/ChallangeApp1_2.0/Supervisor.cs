namespace ChallangeApp1_2._0
{
    public class Supervisor : IEmployee
    {
        public string Name { get; private set; } 

        public string Surname { get; private set; }

        private List<float> score = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddScore(float numberOfPionts)
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

            switch (numberOfPionts)
            {
                case "1":
                    this.score.Add(0);
                    break;
                case "1+":
                case "+1":
                    this.score.Add(5);
                    break;

                case "2-":
                case "-2":
                    this.score.Add(15);
                    break;
                case "2":
                    this.score.Add(20);
                    break;
                case "2+":
                case "+2":
                    this.score.Add(25);
                    break;

                case "3-":
                case "-3":
                    this.score.Add(35);
                    break;
                case "3":
                    this.score.Add(40);
                    break;
                case "3+":
                case "+3":
                    this.score.Add(45);
                    break;

                case "4-":
                case "-4":
                    this.score.Add(55);
                    break;
                case "4":
                    this.score.Add(60);
                    break;
                case "4+":
                case "+4":
                    this.score.Add(65);
                    break;

                case "5-":
                case "-5":
                    this.score.Add(75);
                    break;
                case "5":
                    this.score.Add(80);
                    break;
                case "5+":
                case "+5":
                    this.score.Add(85);
                    break;

                case "6-":
                case "-6":
                    this.score.Add(95);
                    break;
                case "6":
                    this.score.Add(100);
                    break;

                default:
                    if (float.TryParse(numberOfPionts, out float resultOfTypeCasting))
                    {
                        this.AddScore(resultOfTypeCasting);
                    }
                    else
                    {
                        throw new Exception("Błąd rzutowania zmiennej");
                    }
                    break;

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

        public float Result 
        {
            get
            {
                return this.score.Sum();
            }
        }
        public Statistics GetStatistics()
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
