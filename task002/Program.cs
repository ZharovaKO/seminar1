Console.WriteLine ("Введите первое число :");
int firstNumber = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Введите второе число :");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число :");
int thirdNumber = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Максимальное число: ");
Console.WriteLine(Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber)));

