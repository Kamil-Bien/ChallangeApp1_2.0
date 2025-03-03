using System.ComponentModel.Design;

namespace ChallangeApp1_2._0
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
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


        public override Statistics GetStatistics()
        {

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
