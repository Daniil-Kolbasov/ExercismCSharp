namespace xUnitTest;

public static class BookingUpForBeautyTests
{
    [Fact]
    public static void Schedule_Fromat_1()
    {
        Assert.Equal(new DateTime(2019, 7, 25, 13, 45, 0), 
            BookingUpForBeauty.Schedule("7/25/2019 13:45:00"));
    }

    [Fact]
    public static void Schedule_Fromat_2()
    {
        Assert.Equal(new DateTime(2019, 7, 25, 13, 45, 0),
            BookingUpForBeauty.Schedule("July 25, 2019 13:45:00"));
    }

    [Fact]
    public static void Schedule_Fromat_3()
    {
        Assert.Equal(new DateTime(2019, 7, 25, 13, 45, 0),
            BookingUpForBeauty.Schedule("Thursday, July 25, 2019 13:45:00"));
    }

    [Fact]
    public static void HasPassed_Test()
    {
        Assert.True(BookingUpForBeauty.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0)));
    }

    [Fact]
    public static void IsAfternoonAppointment_Test()
    {
        Assert.True(BookingUpForBeauty.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0)));
    }

    [Fact]
    public static void Description_Test()
    {
        Assert.Equal("You have an appointment on 3/29/2019 3:00:00 PM.",
            BookingUpForBeauty.Description(new DateTime(2019, 03, 29, 15, 0, 0)));
    }

    [Fact]
    public static void AnniversaryDate_Test()
    {
        Assert.Equal(new DateTime(DateTime.Now.Year, 9, 15),
            BookingUpForBeauty.AnniversaryDate());
    }
}
