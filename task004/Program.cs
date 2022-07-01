Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
if(N % 2 == 0)
{
  while(N>=0)
  {
    Console.WriteLine(N);
    N = N - 2;
  }
}
else
{
  N = N - 1;
  while(N>=0)
  {
    Console.WriteLine(N);
    N = N - 2;
  }
}
