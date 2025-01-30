Console.WriteLine("Введіть номер дня тижня (1-7): ");
int dayNumber = int.Parse(Console.ReadLine());

string dayName;
if (dayNumber == 1)
{
    dayName = "понеділок";
}
else if (dayNumber == 2)
{
    dayName = "вівторок";
}
else if (dayNumber == 3)
{
    dayName = "середа";
}
else if (dayNumber == 4)
{
    dayName = "четвер";
}
else if (dayNumber == 5)
{
    dayName = "п'ятниця";
}
else if (dayNumber == 6)
{
    dayName = "субота";
}
else if (dayNumber == 7)
{
    dayName = "неділя";
}
else
{
    dayName = "Неправильний номер дня тижня";
}

Console.WriteLine("Назва дня тижня: " + dayName);

