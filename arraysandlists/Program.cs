


Random random = new();

int transportTypesCount = Enum.GetNames(typeof(Transport)).Length;

Transport[][] transport = new Transport[12][];


for (int month = 0; month < transport.Length; month++)
{

    int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, month + 1);
    transport[month] = new Transport[daysCount];
    for (int i = 0; i < daysCount; i++)
    {

        int randomType = random.Next(transportTypesCount);
        transport[month][i] = (Transport)randomType;
    }
}


string[] monthNames = Month.GetMonthNames();
int monthNamesPart = monthNames.Max(n => n.Length) + 2;
for (int month = 1; month <= transport.Length; month++)
{
    Console.Write(
    $"{monthNames[month - 1]}:".PadRight(monthNamesPart));
    for (int day = 1; day <= transport[month - 1].Length; day++)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor =
        transport[month - 1][day - 1].GetColor();
        Console.Write(transport[month - 1][day - 1].GetChar());
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" ");
    }
    Console.WriteLine();
}

