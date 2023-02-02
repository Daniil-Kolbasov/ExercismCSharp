using System.Globalization;

namespace ExercismCSharpLib;

public static class BookingUpForBeauty
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        if (DateTime.TryParse(appointmentDateDescription, out var date))
            return date;
        else if (DateTime.TryParseExact(appointmentDateDescription, "M/d/yyyy HH:mm:ss",
            new CultureInfo("en-US"), DateTimeStyles.None, out var dateValue))
            return dateValue;

        throw new FormatException($"String '{appointmentDateDescription}' was not recognized as a valid DateTime");
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        var currentDate = DateTime.Now;
        int result = DateTime.Compare(currentDate, appointmentDate);

        if (result > 0)
            return true;
        
        return false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
            return true;

        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString(new CultureInfo("en_US"))}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}
