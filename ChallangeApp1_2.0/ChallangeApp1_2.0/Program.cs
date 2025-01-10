//Kurs podstawowy C#
//Praca domowa nr 4
string name = "Rysio";
char sex = 'M'; //M = Male
                //F = Female
int age = 30;
if (sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == 'M' &&  age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("To tylko Rysio (potraktuj ten komunikat jako \"nic\")");
}