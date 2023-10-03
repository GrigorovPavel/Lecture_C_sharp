// Создадим функцию (Метод), который будет находить наибольшее из 3х чисел.

int Max(int arg1, int arg2, int arg3)  // Функция (Метод)
{
    int result = arg1;   // Тело метода
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;   // ??? Почему нельзя arg3 == result; ???
    return result;                     // Данный метод (Max) находит наибольшее из 3х чисел.
}

int [] array = {1,23,36,44,5,16,27,38,19};
array[2] = 12;  // Таким образом мы обращаемся к элементу массива с индексом [2] -36 и 
// присваиваем ему значение 12. Далее выведем в консоль для наглядности.
Console.WriteLine(array[2]);

int result = Max(                     // Результат = функции Max в которой сома функция Max выполняется три раза,
    Max(array0, array1, array2);        // и результат этих вычислений, еще раз выполняет в первой функции Max.
    Max(array3, array4, array5);
    Max(array6, array7, array8);
);

Console.Writeline(result);