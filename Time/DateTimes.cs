//using System.Diagnostics;
public class DateTimes
{
      private DateTime dateTime = DateTime.Now;
      private static DateOnly dateOnly ;
      private static TimeOnly timeOnly ;
    
    public static double GetTimetoDouble()
    {
        timeOnly = TimeOnly.FromDateTime(DateTime.Now);
        double Hour = timeOnly.Hour;
        double Minute = timeOnly.Minute;
        return Hour+(Minute/100);
    }

    public static DateOnly GetDate()
    {
        dateOnly = DateOnly.FromDateTime(DateTime.Now);
        return dateOnly;
    }
    public static TimeOnly GetTime()
    {
        timeOnly = TimeOnly.FromDateTime(DateTime.Now);
        return timeOnly;
    }

}