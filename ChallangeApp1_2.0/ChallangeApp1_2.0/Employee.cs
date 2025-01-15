namespace ChallangeApp1_2._0
{
    public class Employee
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        private List<int> score = new List<int>();

        public Employee(string name, string surname, int age) //konstruktor
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public int Result //property (pole/właściwość) zwraca sumę punktów zawartych w liście "score" danego użytkownika
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number) //metoda odpowiedzialna za dodawanie punktów do puli punktów danego użytkownika
        {
            this.score.Add(number);
        }

        public void SubtractScore(int number) //metoda odpowiedzialna za dodawanie punktów ujemnych do puli punktów danego użytkownika
        {
            this.score.Add(-number);
        }
    }
}

