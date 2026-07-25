namespace RSSFeedReader.Backend.Models;

public class Subscription
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Url { get; init; } = string.Empty;
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
}
