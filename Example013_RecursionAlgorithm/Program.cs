// Двумерные Массивы
// Рекурсия

string[,] table = new string[2, 5];  // 2-число строк, 5-число столбцов

// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] 
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] 
// String.Empty - по умолчанию строки в массиве инициализируются (создаются) пустыми.
// Чтобы обратиться к элементу, нужно укаэать индекс строки и столбца.

table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)  // счетчик для строк.
{
    for (int columns = 0; columns < 5; columns++) // счетчик для столбцов.
    {
        Console.WriteLine($" - {table[rows, columns]} - ");  // Распечатаем массив , обратившись к имени массива, индексу строки и столбца
    }
}

// Далее создадим двумерный массив с числами (матрицу)

void PrintArray(int[,] matr)  // Создадим метод, который будет выводить Массив.
{
    for (int i = 0; i < matr.GetLength(0); i++)   // счетчик для строк.
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // счетчик для столбцов.
        {
            Console.Write($"{matr[i, j]} ");   // Вывод строки через пробел в одну строку
        }
        Console.WriteLine();   //  Вывод с новой строки
    }
}

void FillArray(int[,] matr)   // Создадим метод, который будет заполнять Массив случайными числами.
{
    for (int i = 0; i < matr.GetLength(0); i++)   // счетчик для строк.
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // счетчик для столбцов.
        {
            matr[i, j] = new Random().Next(1, 10);  //Полуинтервал для заполнения случайными числами
        }
    }
}

int[,] matrix = new int[3, 4];  // Инициализация Массива (выделение памяти)

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

////////////////////////////////////////////////
/// Далее создадим картинку и закрасив ее внутреннюю облость.
/// 

int[,] pic = new int[,]  //Условная картинка
{
    {0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,1,1,1,1,1,1,1,1,0,0},
    {0,0,1,0,0,0,0,0,0,1,0,0},
    {0,0,1,0,1,0,0,0,0,1,0,0},
    {0,0,1,0,1,0,0,0,0,1,0,0},
    {0,0,1,0,1,0,0,0,0,1,0,0},
    {0,0,1,0,1,0,0,0,0,1,0,0},
    {0,0,1,0,0,0,0,0,0,1,0,0},
    {0,0,1,1,1,1,1,1,1,1,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0},
};

void PrintImage(int[,] image)  //Метод печатающий картинку
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0)
            {
                Console.Write($" ");
            }
            else
            {
                Console.Write($"+");
            }
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)  // Метод закрашивания row и col - строка и колонка с которой начнем закрашивать
{
    if (pic[row, col] == 0)  // Если элемет массива ==0, то закрашивать будем 8-й (любым символом)
    {
        pic[row, col] = 8;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic);
FillImage(5,5); // Указываем две случайные точки, от которых начнем закрашивать
PrintImage(pic);


// ///////////////////////////////////////////////
// /// Рассмотрим РЕКУРСИЮ НА ПРИМЕРЕ ФАКТОРИАЛА
// /// 

// double Factorial(int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n -1);
// } 
// for (int i = 0; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }
// // Console.WriteLine(Factorial(5));  // 5! -> 5*4*3*2*1=120


// ///////////////////////////////////////////////
// /// Рассмотрим РЕКУРСИЮ НА ПРИМЕРЕ ЧИСЕЛ ФИБОНАЧИ
// /// 

// int Fibonacci(int n)  // Метод вычисления чисел ФИБОНАЧИ
// {
//     if(n ==1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }