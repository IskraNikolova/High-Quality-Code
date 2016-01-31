namespace DateTime.Now.AddDays
{
    using System;

    public interface IDateTimeProvider
    {
        DateTime DateTimeNow { get; }
    }
}