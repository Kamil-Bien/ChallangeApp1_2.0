using static ChallangeApp1_2._0.EmployeeBase;

namespace ChallangeApp1_2._0
{
    internal interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        event GradeAddedDelegate GradeAdded;

        void AddScore(float numberOfPionts);
        void AddScore(string numberOfPionts);
        void AddScore(decimal numberOfPionts);
        void AddScore(int numberOfPionts);
        Statistics GetStatistics();
    }
}
