// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими буквами "К",
// а большие "С" заменить маленькими "с".

string text = " - Я думаю, - сказал князь, улыбаясь, - что, " 
+"если бы вас послали вместо нашего милого Винцентгероде"
+"вы бы взяли приступом согласие прусского короля. "
+"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwert"
//             01234 -й символы.
// s[3] - r;

string Replace (string text, char oldValue, char newValue) // Создали Метод с тремя переменными.
{
    string result = String.Empty;  // Инициировали переменную с пустой строкой. 
    int length = text.Length;   // Инициировали переменную, равную длинне текста. (весь текст - это одна переменная)

    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}  // Метод закончен, теперь его нужно вызвать и указать какие символы необходимо заменить.

string newText = Replace(text, ' ', '|'); // создаем переменную, которой присвоим РЕЗУЛЬТАТ МЕТОДА. 
// В Методе указываем переменные или (значения/символы) с которыми метод будет работать.
Console.WriteLine(newText); // Выводим результат в Консоль.
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
