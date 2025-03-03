namespace ChallangeApp1_2._0

// model danych statystycznych
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var x when x >= 80:
                        return 'A';
                    case var x when x >= 60:
                        return 'B';
                    case var x when x >= 40:
                        return 'C';
                    case var x when x >= 20:
                        return 'D';
                    default:
                        return 'Ę';


                }
            }
        }


        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddScore(float numberOfPionts)
        {
            this.Count++;
            this.Sum += numberOfPionts;
            this.Min = Math.Min(numberOfPionts, this.Min);
            this.Max = Math.Max(numberOfPionts, this.Max);
        }
    }
}
