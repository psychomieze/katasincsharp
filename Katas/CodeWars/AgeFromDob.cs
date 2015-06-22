using System;

namespace Katas.CodeWars
{
    public class AgeFromDob
    {
        public IClock Clock;

        public AgeFromDob(IClock clock)
        {
            Clock = clock;
        }

        public int GetAgeFromDOB(DateTime birthday)
        {
            TimeSpan span = Clock.Now.Subtract(birthday);
            return new DateTime(span.Ticks).Year - 1;
        }
    }

    public interface IClock
    {
        DateTime Now { get; }
    }

    public class SystemClock : IClock
    {
        public DateTime Now { get { return DateTime.Now; } }
    }

    public class StaticClock : IClock
    {
        public DateTime Now { get; }

        public StaticClock(DateTime now)
        {
            Now = now;
        }
    }
}