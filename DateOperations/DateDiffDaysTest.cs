using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class DateDiffDaysTests
{
    [Test]
    public void CalculateDateDiffDays_WeekdaysOnly_ReturnsCorrectResult()
    {
        // Arrange
        DateTime from = new DateTime(2022, 1, 1);
        DateTime to = new DateTime(2022, 1, 10);
        List<DateTime> holidays = new List<DateTime>();

        // Act
        int result = DateDiffDays(from, to, holidays);

        // Assert
        Assert.AreEqual(6, result);
    }

    [Test]
    public void CalculateDateDiffDays_WeekdaysWithHolidays_ReturnsCorrectResult()
    {
        // Arrange
        DateTime from = new DateTime(2022, 1, 1);
        DateTime to = new DateTime(2022, 1, 10);
        List<DateTime> holidays = new List<DateTime>()
        {
            new DateTime(2022, 1, 3),
            new DateTime(2022, 1, 6)
        };

        // Act
        int result = DateDiffDays(from, to, holidays);

        // Assert
        Assert.AreEqual(4, result);
    }

    [Test]
    public void CalculateDateDiffDays_WeekdaysWithWeekend_ReturnsCorrectResult()
    {
        // Arrange
        DateTime from = new DateTime(2022, 1, 1);
        DateTime to = new DateTime(2022, 1, 11);
        List<DateTime> holidays = new List<DateTime>();

        // Act
        int result = DateDiffDays(from, to, holidays);

        // Assert
        Assert.AreEqual(7, result);
    }
}