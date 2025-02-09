namespace ChallangeApp1_2._0
{
    public class EmployeeInMemory : EmployeeBase
    {

        public EmployeeInMemory(string name, string surname) //konstruktor
            : base(name, surname)
        {
        }

        private List<float> score = new List<float>();

        public override void AddScore(float numberOfPionts)
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


        public override Statistics GetStatistics()
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

                statistics.Average = this.score.Sum() / this.score.Count;

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
