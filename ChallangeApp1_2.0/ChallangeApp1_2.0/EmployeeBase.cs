
namespace ChallangeApp1_2._0
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public EmployeeBase(string name, string surname) //konstruktor
        {
            this.Name = name;
            this.Surname = surname;
        }

        public abstract void AddScore(float numberOfPionts);

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

        public abstract Statistics GetStatistics();

    }
}
