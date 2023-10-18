///////////////////////////////////////////////
/// Рассмотрим РЕКУРСИЮ НА ПРИМЕРЕ ФАКТОРИАЛА
/// 

double Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n -1);
} 
for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
// Console.WriteLine(Factorial(5));  // 5! -> 5*4*3*2*1=120


///////////////////////////////////////////////
/// Рассмотрим РЕКУРСИЮ НА ПРИМЕРЕ ЧИСЕЛ ФИБОНАЧИ
/// 

int Fibonacci(int n)  // Метод вычисления чисел ФИБОНАЧИ
{
    if(n ==1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}
