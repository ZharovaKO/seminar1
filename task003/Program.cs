Console.WriteLine ("Введите число :");
int number = Convert.ToInt32(Console.ReadLine()); 
bool paritycheck (int number)
{
    return (number % 2 == 0);
}
Console.WriteLine(paritycheck(number));
