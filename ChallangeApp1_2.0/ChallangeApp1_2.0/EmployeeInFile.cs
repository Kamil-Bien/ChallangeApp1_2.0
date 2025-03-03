namespace ChallangeApp1_2._0
{
    internal class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private const string fileName = "Score List.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
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

            var statistics = new Statistics();

            foreach (var item in this.score)
            {
                statistics.AddScore(item);
            }


            if (statistics.Count > 0)
            {
                return statistics;
            }
            else
            {
                throw new Exception("Ten pracownik nie ma żadnych ocen");
            }
        }
    }
}
