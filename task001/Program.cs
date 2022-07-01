Console.WriteLine ("Введите первое число :");
int firstNumber = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Введите второе число :");
int secondNumber = Convert.ToInt32(Console.ReadLine());
 if (firstNumber > secondNumber)
 {
    Console.WriteLine(" наибольшее число: " + firstNumber);
    Console.WriteLine(" наименьшее число: " + secondNumber);
 }
 else
 {
    Console.WriteLine(" наибольшее число: " + secondNumber);
    Console.WriteLine(" наименьшее число: " + firstNumber);
 }

