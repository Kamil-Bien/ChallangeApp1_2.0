//Kurs podstawowy C#
//Praca domowa nr 5

//deklaracja zmiennych oraz konwersja liczby podanej w typie int na tablice znaków (char)
int number = 4650660; 
string numberInString = number.ToString(); 
char[] letters = numberInString.ToArray(); 
int[] countNumber = new int[10];


foreach (var oneNumber in letters) //pętla dla każdego elementu utworzonej tablicy
{
    //w pętli wykonano dwie konwersje zmiennych w string w celach porównanwczych
    string oneNumberString = oneNumber.ToString();
    for (int i = 0; i < 10; i++) //pętla służąca do inkrementacji wystąpień danej cyfry w tablicy
    {
        string iString = i.ToString();
        if (iString == oneNumberString)
        {
            countNumber[i]++;
        }
    }
}

//wyświetlenie wyników powyższego procesu
Console.WriteLine("cyfra => liczba wystąpień");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + countNumber[i]);
}