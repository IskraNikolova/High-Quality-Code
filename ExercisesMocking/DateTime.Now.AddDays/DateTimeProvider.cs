namespace DateTime.Now.AddDays
{
    using System;

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime DateTimeNow
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
