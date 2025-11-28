//Лабораторная (22)
//Базовый уровень
Console.Write("Введите строку: ");
string text = Console.ReadLine();
int count1 = 0;
int count2 = 0;
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == '!') count1++;
    if (text[i] == '?') count2++;
}
if (count1 > count2)
    Console.WriteLine("Символ '!' встречается чаще.");
else if (count2 > count1)
    Console.WriteLine("Символ '?' встречается чаще.");
else
    Console.WriteLine("Они встречаются одинаково.");
