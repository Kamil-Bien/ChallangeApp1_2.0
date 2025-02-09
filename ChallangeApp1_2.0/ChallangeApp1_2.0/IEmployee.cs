namespace ChallangeApp1_2._0
{
    internal interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        List<float> Score { get; }   
        
        void AddScore(float numberOfPionts);
        void AddScore(string numberOfPionts);
        void AddScore(decimal numberOfPionts);
        void AddScore(int numberOfPionts);
        float Result { get; }
        Statistics GetStatistics();
    }
}
