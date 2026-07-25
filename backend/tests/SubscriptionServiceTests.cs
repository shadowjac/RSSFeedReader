using RSSFeedReader.Backend.Models;
using RSSFeedReader.Backend.Services;

namespace RSSFeedReader.Backend.Tests;

public class SubscriptionServiceTests
{
    [Fact]
    public void AddSubscription_ReturnsCreatedSubscription_WhenUrlIsValid()
    {
        var service = new SubscriptionService();

        var result = service.AddSubscription("https://example.com/feed");

        Assert.NotNull(result);
        Assert.Equal("https://example.com/feed", result.Url);
        Assert.NotEqual(Guid.Empty, result.Id);
    }

    [Fact]
    public void AddSubscription_RejectsDuplicateSubscription_WhenUrlAlreadyExists()
    {
        var service = new SubscriptionService();
        service.AddSubscription("https://example.com/feed");

        var exception = Assert.Throws<ArgumentException>(() => service.AddSubscription("https://example.com/feed"));

        Assert.Contains("already exists", exception.Message);
    }

    [Fact]
    public void AddSubscription_RejectsMalformedUrl_WhenUrlIsInvalid()
    {
        var service = new SubscriptionService();

        var exception = Assert.Throws<ArgumentException>(() => service.AddSubscription("not-a-valid-url"));

        Assert.Contains("valid absolute URL", exception.Message);
    }

    [Fact]
    public void GetSubscriptions_ReturnsAllStoredSubscriptions()
    {
        var service = new SubscriptionService();
        service.AddSubscription("https://example.com/feed-1");
        service.AddSubscription("https://example.com/feed-2");

        IReadOnlyList<Subscription> subscriptions = service.GetSubscriptions();

        Assert.Equal(2, subscriptions.Count);
        Assert.Equal("https://example.com/feed-1", subscriptions[0].Url);
        Assert.Equal("https://example.com/feed-2", subscriptions[1].Url);
    }
}
