

using System.Globalization;

public class Month
{

    public static string[] GetMonthNames()
    {
        string[] names = new string[12];
        for (int month = 1; month <= 12; month++)
        {
            DateTime firstDay = new DateTime(
            DateTime.Now.Year, month, 1);
            string name = firstDay.ToString("MMMM",
            CultureInfo.CreateSpecificCulture("en"));
            names[month - 1] = name;
        }
        return names;
    }

}

