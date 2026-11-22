string subject = "Программирование";

foreach (char letter in subject)
{
    Console.WriteLine(letter);
}

Console.WriteLine($"Количество букв: {subject.Length}");

///--------

int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;

foreach (int grade in grades)
{
    Console.WriteLine(grade);
    sum += grade;
}

double average = (double)sum / grades.Length;

Console.WriteLine($"Сумма оценок: {sum}");
Console.WriteLine($"Средний балл: {average}");

///--------
string[] students = { "Аня", "Ярослав", "Вика" };
int count = 0;

foreach (string student in students)
{
    Console.WriteLine(student);
    count++;
}

Console.WriteLine($"Количество учеников: {count}");

///--------
int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
}

foreach (int point in points)
{
    Console.WriteLine(point);
}

///--------
int[] numbers = { 10, 20, 30, 40, 50 };
int sum = 0;

foreach (int number in numbers)
{
    Console.WriteLine(number);
    sum += number;
}

Console.WriteLine($"Сумма чисел: {sum}");

///--------
string[] days =
{
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
    "Воскресенье"
};

foreach (string day in days)
{
    Console.WriteLine($"{day}!");
}

///--------

int[] temperatures = { 15, 17, 18, 16, 20, 19, 21 };
int sum = 0;

foreach (int temperature in temperatures)
{
    sum += temperature;
}

double average = (double)sum / temperatures.Length;

Console.WriteLine($"Средняя температура: {average}");


///--------

string[] participants =
{
    "Анна",
    "Борис",
    "Виктор",
    "Мария",
    "Александр"
};

int number = 1;

foreach (string participant in participants)
{
    Console.WriteLine($"{number}. {participant}");
    number++;
}


///--------

