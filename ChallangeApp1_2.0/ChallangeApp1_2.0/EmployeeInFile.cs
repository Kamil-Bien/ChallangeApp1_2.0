namespace ChallangeApp1_2._0
{
    internal class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private const string fileName = "Score List.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public override void AddScore(float numberOfPionts)
        {
            if (numberOfPionts >= 0 && numberOfPionts <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(numberOfPionts);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Podana liczba musi znajdować się w zakresie 0-100");
            }
        }

        private List<float> score = new List<float>();
        public override Statistics GetStatistics()
        {
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var singleValue = float.Parse(line);
                        score.Add(singleValue);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("plik nieistnieje");
            }

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
