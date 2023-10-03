int []array = {1,28,53,24,5,69,5,27,18};

int n = array.Length;
int finde = 5;

int index = 0;

while(index < n)
{
    if(array[index] == finde)
    {
        Console.WriteLine(index);
        break;                     //если в массиве несколько одинаковых элементов, break остонавливает
        // выполнение условий, после нахождения первого элемента с указаным значением. иначе условие найдет все значения.
    }

    index++;

}