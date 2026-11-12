int totalExercises = 8;
for (int number = totalExercises; number >= 1; number--){
    Console.WriteLine($"Упражнение {number}");}
Console.WriteLine("Домашнее задание готово");


for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет {room}");
}


int totalWeeks = 3;
for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("____");
}

int skipped = 0;
for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        skipped++;
        continue; 
    }
    Console.WriteLine($"Первый доступный билет: {ticket}, пропущено билетов: {skipped}");
    break;
}


for (; ; )
{
    Console.Write("Введите код группы (для выхода — «выход»): ");
    string groupCode = Console.ReadLine();
    if (groupCode == "выход")
    {
        break;
    }
    Console.WriteLine($"Записан код группы: {groupCode}");
}
Console.WriteLine("Работа с журналом завершена");


int n = 10;
for (int aaa = 1; aaa <= n; aaa += 2)
{
    Console.WriteLine(aaa);
}


for (int bbb = 100; bbb >= 0; bbb -= 10)
{
    Console.WriteLine(bbb);
}


Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

int n2 = 20;
int m2 = 4;
for (int i = n2; i >= 0; i -= m2)
{
    Console.WriteLine(i);
}


for (int a = 1; a <= 5; a++)
{
    for (int b = 1; b <= 5; b++)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
}

Console.Write("Введите количество недель тренировок N: ");
int nb = int.Parse(Console.ReadLine()!.Trim());

int cnt = 0;
bool stop = false;
int w = 1, d = 1;

for (w = 1; w <= nb && !stop; w++)
{
    for (d = 1; d <= 7 && !stop; d++)
    {
        if (d == 7)
        {
            continue; // воскресенье — отдых
        }
        cnt++;
        if (cnt == 20)
        {
            stop = true;
            break;
        }
    }
}

Console.WriteLine($"Набрано 20 тренировочных дней на неделе {w - 1}, дней {d}");
