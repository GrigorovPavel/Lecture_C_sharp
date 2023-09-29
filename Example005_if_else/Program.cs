Console.WriteLine ("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "паша") {
    Console.WriteLine("УРА! это же ПАША!");
}
else {
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}