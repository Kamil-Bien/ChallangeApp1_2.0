
namespace ChallangeApp1_2._0
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public EmployeeBase(string name, string surname) //konstruktor
        {
            this.Name = name;
            this.Surname = surname;
        }

        public abstract float Result { get; }

        public abstract List<float> Score { get; }

        public abstract void AddScore(float numberOfPionts);

        public abstract void AddScore(string numberOfPionts);

        public abstract void AddScore(decimal numberOfPionts);

        public abstract void AddScore(int numberOfPionts);

        public abstract Statistics GetStatistics();
        
    }
}
