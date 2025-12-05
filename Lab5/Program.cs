//Лабораторная 5.1 (22)
//Средний уровень
Console.WriteLine("Введите 10 символов:");
char[] mass = new char[10];
for (int i = 0; i < 10; i++)
{
    mass[i] = Console.ReadKey().KeyChar;
}
Console.WriteLine();
char duplicate = '\0';
for (int i = 0; i < mass.Length; i++)
{
    for (int j = i + 1; j < mass.Length; j++)
    {
        if (mass[i] == mass[j])
        {
            duplicate = mass[i];
            break;
        }
    }
    if (duplicate != '\0') break;
}
if (duplicate != '\0')
    Console.WriteLine($"Одинаковая буква: {duplicate}");
else
    Console.WriteLine("Одинаковых букв нет.");
