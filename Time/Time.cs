public class DateTimes
{
      private DateTime dateTime = DateTime.Now;
      private DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
      private TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);
    public static void Date()
    {
    DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
    Console.WriteLine(dateOnly);
    }
    public static void Time()
    {
    TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);
    Console.WriteLine(timeOnly);
    }

     public DateOnly GetDate()
    {
        return dateOnly;
    }
    public TimeOnly GetTime()
    {
        return timeOnly;
    }
}