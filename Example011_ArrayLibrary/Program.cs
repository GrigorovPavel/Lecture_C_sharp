void FillArray (int[] collection)  //  задает случайные значения элементов в наш массив (заполняет его)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);   // обращаемся к аргументу collection на позицию [index] 
        // и кладем туда новое случайное число
        // тоесть добавляем числа(элементы), пока кол-во элементов меньше кол-ва index
        index++;
    }
}

void PrintArray (int[] col)  // выводит наш массив в консоль.
{
    int count  =col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf (int[] colection, int finde)
{
    int count = colection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(colection[index] == finde)
        {
            position = index;
            break;  // останавливает проверку при нахождении первого значения элемента.
        }
        index++;
    }
    return position;
}

int [] array = new int [10];  // указали, что в нашем массиве будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 6); // элемент который мы ищем в массиве
// если искомого элемента нет в массиве , мы увидем результат -1, так как position = -1 указана выше, а присваивать ему будет нечего!
Console.WriteLine(pos);

