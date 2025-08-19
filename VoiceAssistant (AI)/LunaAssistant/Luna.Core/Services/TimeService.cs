namespace Luna.Core.Services;

public class TimeService
{
    public DateTimeOffset LocalTimeFromUtcOffsetSeconds(int utcOffsetSec)
    {
        return DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromSeconds(utcOffsetSec));
    }
}
